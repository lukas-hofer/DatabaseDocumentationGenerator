using DinkToPdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Orientation = DinkToPdf.Orientation;

namespace DatabaseDocumentationGenerator
{
    internal class PdfGenerator
    {

        public byte[] generatePdfOutOfCsv(string csv)
        {
            var converter = new BasicConverter(new PdfTools());

            string html = generateHtml(csv);

            var doc = new HtmlToPdfDocument()
            {
                GlobalSettings = {
                    ColorMode = ColorMode.Color,
                    Orientation = Orientation.Portrait,
                    PaperSize = PaperKind.A4Plus,
                },
                Objects = {
                    new ObjectSettings() {
                        PagesCount = true,
                        HtmlContent = html,
                        WebSettings = { DefaultEncoding = "utf-8" }
                    }
                }
            };

            byte[] pdf = converter.Convert(doc);

            return pdf;
        }

        private string generateHtml(string csv)
        {
            string html = $@"
	            <!DOCTYPE html>
	            <head>
		            <style>
		               table, th, td {{
                           border: 1px solid;
                        }} 
                        table {{
                              border-collapse: collapse;
                        }}
                        td, th {{
                          padding: 5px;             
                       }}
		            </style>
	            </head>
	            <body>
	            ";
            int tableRow = 0;

            foreach (string row in csv.Split("\r\n"))
            {
                //heading
                if (!row.Contains(";"))
                {
                    if (tableRow != 0)
                    {
                        html += @"</table>";
                        tableRow = 0;
                    }
                    html += "<h1>" + row + "</h1>";
                    
                } else
                {
                    if (tableRow == 0)
                    {
                        html += @"<table>";
                    }
                    string[] colData = row.Split(";");

                    html += "<tr>";

                    foreach (string tableCol in colData)
                    {
                        html += ("<td>" + tableCol + "</td>");
                    }

                    html += "</tr>";
                    

                    tableRow++;
                }

            }

            return html;
        }

    }
}
