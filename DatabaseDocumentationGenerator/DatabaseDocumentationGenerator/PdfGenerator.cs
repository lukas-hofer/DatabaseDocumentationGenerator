using DinkToPdf;
using System;
using System.Collections.Generic;
using System.Linq;
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

            var doc = new HtmlToPdfDocument()
            {
                    GlobalSettings = {
                    ColorMode = ColorMode.Color,
                    Orientation = Orientation.Landscape,
                    PaperSize = PaperKind.A4Plus,
                    },
                    Objects = {
                    new ObjectSettings() {
                        PagesCount = true,
                        HtmlContent = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. In consectetur mauris eget ultrices  iaculis. Ut                               odio viverra, molestie lectus nec, venenatis turpis.",
                        WebSettings = { DefaultEncoding = "utf-8" },
                        HeaderSettings = { FontSize = 9, Right = "Page [page] of [toPage]", Line = true, Spacing = 2.812 }
                    }
                }
            };

            byte[] pdf = converter.Convert(doc);

            return pdf;
        }

    }
}
