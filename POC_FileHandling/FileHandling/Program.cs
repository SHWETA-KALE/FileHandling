using System.IO;

namespace FileHandling
    
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String line;
            string filePath = "C:\\Users\\shweta.kale\\Desktop\\Sample78.txt";
            try
            {
                StreamReader streamReader = new StreamReader(filePath);
                line = streamReader.ReadLine();
                while (line != null) {
                    Console.WriteLine(line);
                    //read the next line
                    line  = streamReader.ReadLine();
                }
                streamReader.Close();
                Console.ReadLine();

            }
            catch(Exception e) {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block");
            }
        }
    }
}
