using System;

namespace ErroresYLog
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 0;

            int resultado;


            try
            {
                DivisionSegura(10, 0);
            }            
            catch (DivideByZeroException ex2)
            {
                Console.WriteLine("Se produjo un error de de división por cero");
                //throw;
            }
            catch (Exception ex1)
            {
                Console.WriteLine("Se produjo un error desconocido");
                Console.WriteLine(ex1.ToString());
            }

        }

        public static int DivisionSegura(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException();                
            }
            return a / b;

        }
    }
}
