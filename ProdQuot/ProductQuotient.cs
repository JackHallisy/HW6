using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdQuot
{
    class Program
    {
        static void Main(string[] args)
        { 
            try
            {
                Random rnd = new Random();
                double tempx, tempy, prod = 0;
                double quot = 0;
                for (int rndNum = 0; rndNum <= 11; rndNum++)
                {
                    tempx = rnd.Next(0, 11);
                    tempy = rnd.Next(0, 11);
                    prod = tempx * tempy;
                    quot = tempx / tempy;

                    Console.WriteLine("The product of " + tempx + ", " + tempy + " = " + prod);
                    Console.WriteLine("The quotient of " + tempx + ", " + tempy + " = " + Math.Round(quot, 2));
                    Console.WriteLine();
                }
            }   
            catch(DivideByZeroException )
            {
                Console.WriteLine("DivideByZeroException caught!");
            }         
            catch (Exception ex)
            {
                Console.WriteLine("GeneralmException Thrown" + ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
