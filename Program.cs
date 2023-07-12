using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace ConAppday3
{
    internal class Program
    {
        enum MonthOfYear {jan=1,feb=2,mar=3,apr=4};

        static void Main(string[] args)
        {
            Console.WriteLine("month"+(int)MonthOfYear.feb);
            Console.ReadKey();


            /*
            //data types
            byte mybytes = 12;
            sbyte mysbyte = 1;
            short myshort = 12;
            int myint = 12;
            long mylong = 12;
            double mydouble = 12.5;
            float myFloat = 12.5F;
            decimal mydecimal = 12;
            char myChar = 'A';
            string mystring = "our String";
            DateTime mydateTime = new DateTime(day: 12,month:12,year:2022) ;
            bool mybool = false;*/


            /* byte ourByte;
             Console.WriteLine("Enter a number");
             ourByte=Convert.ToByte(Console.ReadLine());
             Console.WriteLine("Number is: "+ourByte);
             Console.ReadKey();
 */

            /*   try {

                   byte ourbyte;
                   Console.WriteLine("Enter a number");

                   ourbyte = Convert.ToByte(Console.ReadLine());
                   Console.WriteLine("Number is "+ourbyte);
               }
               catch(FormatException ex)
               {
                   Console.WriteLine("Format Exception "+ex.Message);
               }
               catch(OverflowException ex) {
                   Console.WriteLine("Overflow Exception"+ex.Message);
               }
               catch(Exception ex)
               {
                   Console.WriteLine("Error !!!"+ex.Message);
               }
               finally
               {
                   Console.WriteLine("End of the program !!!");
                   Console.ReadKey();
   */



        }
        }
    }
}
