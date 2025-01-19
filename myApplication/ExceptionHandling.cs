using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace myApplication
{
    class ExceptionHandling
    {


        public static void Main17()
        {
            StreamReader streamreader = null;
            try
            {
                streamreader = new StreamReader(@"C:\Users\chint\OneDrive\Documents\data1.txt");
                Console.WriteLine(streamreader.ReadToEnd());
                
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Please Check If the file {0} exists", ex.FileName);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Please check the Directory");
            }
            finally
            {
                if(streamreader != null)
                {
                    streamreader.Close();
                }
                
                Console.WriteLine("Finally Block Executed");
            }

        }
    }
    
}
