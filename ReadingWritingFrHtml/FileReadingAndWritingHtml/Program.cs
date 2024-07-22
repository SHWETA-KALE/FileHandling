using System;
//using HtmlAgilityPack;
using System.IO;

namespace FileReadingAndWritingHtml
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "D:\\Assignments\\ReadingWritingFrHtml\\FileReadingAndWritingHtml\\index.html";
            string filePath2 = "D:\\Assignments\\ReadingWritingFrHtml\\FileReadingAndWritingHtml\\output.html";

            //try
            //{
            //    // Read the entire file as a string
            //    string htmlContent = File.ReadAllText(filePath);

            //    Console.WriteLine(htmlContent);
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine($"This file could not be read: {e.Message}");
            //}
            //finally
            //{
            //    Console.WriteLine("Executing finaaly block");
            //}

            //reading
            //try
            //{
            //    HtmlDocument htmlDoc = new HtmlDocument();
            //    htmlDoc.Load(filePath);

            //    HtmlNode titleNode = htmlDoc.DocumentNode.SelectSingleNode("//title");
            //    HtmlNode pNode = htmlDoc.DocumentNode.SelectSingleNode("//p");

            //    if (titleNode != null)
            //        Console.WriteLine($"Title: {titleNode.InnerText}");
            //    else
            //        Console.WriteLine("Title not found");

            //    if (pNode != null)
            //        Console.WriteLine($"Paragraph: {pNode.InnerText}");
            //    else
            //        Console.WriteLine("Paragraph not found");
            //}
            //catch (Exception e)
            //{
            //    {
            //        Console.WriteLine($"Error reading HTML file {e.Message}");
            //    }



                //Reading an html file
                try
                {
                    using StreamReader reader = new StreamReader(filePath);
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error writing HTML file: {e.Message}");

                }

            //writing to an html doc
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath2, true))
                {
                    writer.WriteLine("<!DOCTYPE html>");
                    writer.WriteLine("<html lang=\"en\">");
                    writer.WriteLine("<head>");
                    writer.WriteLine("    <meta charset=\"UTF-8\">");
                    writer.WriteLine("    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">");
                    writer.WriteLine("    <title>Generated HTML</title>");
                    writer.WriteLine("</head>");
                    writer.WriteLine("<body>");
                    writer.WriteLine("    <h1>Hello from C#!</h1>");
                    writer.WriteLine("    <p>This HTML file is generated using C#.</p>");
                    writer.WriteLine("</body>");
                    writer.WriteLine("</html>");
                }

                Console.WriteLine($"html file successfully written to {filePath} ");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error writing HTML file: {e.Message}");
            }
        }

        }

    }