using ceTe.DynamicPDF;
using ceTe.DynamicPDF.PageElements;
using System;
using System.IO;

namespace example_create_pdf_dotnet
{
    // This example shows how to create a PDF document from scratch.
    // It references the ceTe.DynamicPDF.CoreSuite.NET NuGet package.
    class Program
    {
        // Create a PDF document from scratch.
        // Use the ceTe.DynamicPDF namespace for the Document and Page classes.
        // Use the ceTe.DynamicPDF.PageElements namespace to use page elements (the Label class in this case).
        static void Main(string[] args)
        {
            //Create a Document object
            Document document = new Document();

            //Create a Page object with required sizes
            Page page = new Page(PageSize.Letter, PageOrientation.Portrait, 54.0f);
            //Add page to document
            document.Pages.Add(page);

            //Create a Label object with required parameters and add to the page.
            string labelText = "Hello World...\nFrom DynamicPDF Generator for .NET\nDynamicPDF.com";
            Label label = new Label(labelText, 0, 0, 504, 100, Font.Helvetica, 18, TextAlign.Center);
            page.Elements.Add(label);

            //Save the document.
            document.Draw("output.pdf");
        }
    }
}
