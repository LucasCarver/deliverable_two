using System;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            string message = "";
            int checksum = 0;
            Boolean valid = false;

            while (!valid)
            {
                input = Console.ReadLine().ToUpper();
                for (int i = 0; i < input.Length; i++)
                {
                    if ((int)input[i] < 64 ||(int)input[i] > 90)
                    {
                        Console.WriteLine("Unsupported character detected.");
                        valid = false;
                        break;
                    }
                    else
                    {
                        valid = true;
                    }

                }
                
            }

            
            for (int i = 0; i < input.Length; ++i)
            {
                if (i+1 < input.Length)
                {
                    message += (int)input[i]-64 + "-";
                }
                else
                {
                    message += (int)input[i]-64;
                }
                checksum += (int)input[i];
            }
            Console.WriteLine("Your encoded message is " + message);
            Console.WriteLine("Message checksum is " + checksum);
        }
    }
}
