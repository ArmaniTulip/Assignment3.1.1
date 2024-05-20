using System.Text;

namespace Assignment3._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetEvenNumbers());
        }





          public class EvenNumbers;
        

        
        

            public static string GetEvenNumbers()
            {
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < 100; i++)
                {
                    if (i % 2 == 0)
                    {
                        sb.Append(i).Append(" ");
                    }
                }
                return sb.ToString();
            }
        }

    }


        
    

