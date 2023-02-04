﻿using DinkToPdf;
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

        public byte[] generateCatalogPdf(List<SqlTable> tables)
        {
            var converter = new BasicConverter(new PdfTools());

            string html = generateHtml(tables);

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

        private string generateHtml(List<SqlTable> tables)
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

            foreach (SqlTable table in tables)
            {
                //heading

                html += "<h1>" + table.name + "</h1>";

                html += "<table>";

                html += @"
                
                <tr>
                <th>Name</th>
                <th>DataType</th>
                <th>Nullable</th>
                </tr>
    
                ";

                foreach (SqlTableCol tableCol in table.sqlTableColumns)
                {
                    html += "<tr>";
                    html += ("<td>" + tableCol.name + "</td>");
                    html += ("<td>" + tableCol.datatype + "</td>");
                    html += ("<td>" + tableCol.nullable + "</td>");
                    html += "</tr>";
                }

                html += @"</table>";
            }
            
            return html;
        }


    }
}
