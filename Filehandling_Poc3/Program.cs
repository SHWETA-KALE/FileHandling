using System;
using System.IO;
using System.Text;
using System.Threading.Channels;

namespace Filehandling_Poc3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "D:\\Assignments\\Filehandling_Poc3\\output2.txt";

            try
            { // Create StreamWriter with using statement for automatic disposal
                using (StreamWriter sw = new StreamWriter(filePath, true, Encoding.ASCII)) 
                {
                    Console.WriteLine("Enter Your Name: ");
                    string userName = Console.ReadLine();
                    sw.WriteLine(userName);
                }
               
            }
            catch (Exception e) {
                Console.WriteLine($"Error writing in a file: {e.Message} ");
            }
            finally
            {
                Console.WriteLine("Executing finally block");
            }



        }
    }
}
//true => appending to a file
//false => overwriting in a file

//add cond for reading if file does not exist 