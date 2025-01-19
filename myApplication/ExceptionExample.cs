using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace myApplication
{
    internal class ExceptionExample
    {
        public static void Main18(string[] args)
        {
            try
            {


                try
                {


                    Console.WriteLine("Enter First Number");
                    int fn = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter Second Number");
                    int Sn = Convert.ToInt32(Console.ReadLine());

                    int result = fn / Sn;
                    Console.WriteLine("isresult:{0}", result);
                }
                catch (Exception ex)

                {
                    string filepath = @"C:\Users\chint\OneDrive\Documents\data1.txt";
                    if (File.Exists(filepath))
                    {


                        StreamWriter streamWriter = new StreamWriter(filepath);
                        Console.WriteLine("Please try again later");
                        //Console.WriteLine(ex.Message);
                        //Console.WriteLine();
                        //Console.WriteLine(ex.StackTrace);



                        streamWriter.Write(ex.GetType().Name);
                        streamWriter.Write(ex.Message);
                        streamWriter.Write(ex.StackTrace);


                        streamWriter.Close();
                    }
                    else
                    {
                        throw new FileNotFoundException(filepath + "Please check the Path",ex);
                    }
                }
            }
            catch(Exception exception)
            {
                Console.WriteLine( "current Exception {0}", exception.GetType().Name);
                if (exception.InnerException != null)
                {

                    Console.WriteLine("Inner Exception {0}", exception.InnerException.GetType().Name);

                }
            }

        }
    }
}
