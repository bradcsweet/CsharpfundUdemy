using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpfundUdemy
{
    class Program
    {
        static void Main(string[] args)
        {
            ///////this is an example of overflowing. type "byte" only allows value up to 255. If value out of range it crashes or errors out if checked.

            ////This will break immediately
            ////byte number = 255;
            ////number = number++;

            ////this will throw an error because it's wrapped in "checked"
            //checked
            //{
            //    byte number = 255;
            //    number = number++;
            //}

            //byte number = 2;
            //int count = 10;
            //float totalPrice = 20.95f;
            //char character = 'A';
            //string firstName = "Brad";
            //bool isWorking = false;

            //You can use var for every data type. hover over each to see what the car maps to in C#

            //var number = 2;
            var count = 10;
            var totalPrice = 20.95f;
            var character = 'A';
            var firstName = "Brad";
            var isWorking = false;

            //Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);

            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

            const float Pi = 3.14f; //use const to protect being overwritten later. if they are values that should not be changed.
            //Pi = 1;
            Console.WriteLine(Pi);

            //Type conversions and try catch
            try
            {
                var number = "1234";
                byte b = Convert.ToByte(number);
                Console.WriteLine(b);


            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte.");
            }

            // trying again but with boolean
            try
            {
                string str = "true";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte.");
            }
        }
    }
}
