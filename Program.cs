using System;

namespace Gangetabell
{
    class Program
    {

        static void Main(string[] args)
        {

            GangetabellLager();
        }
        public static void GangetabellLager()
        {
            int labelWidth = 4;
            Console.WriteLine("Skriv in ønsket max tall (30max)");
            GangetabellGenerator(Convert.ToInt32(Console.ReadLine()), labelWidth);

            Console.ReadLine();

        }

        private static void GangetabellGenerator(int brukerinput, int labelWidth)
        {

            int[] tabell = new int[brukerinput + 1];

            // Console.WriteLine(tabell.Length);

            for (int j = 1; j < brukerinput + 1; j++)
            {
                Console.WriteLine();

                for (int i = 1; i < brukerinput + 1; i++)
                {
                    

                    tabell[i] = i;
                    
                    //if (Convert.ToString(tabell[i]).Length > 1)
                    //{ 
                    //labelWidth = 3 - Convert.ToString(tabell[i]).Length;
                    //}
                    //else
                    //{
                    //    labelWidth = 2 - Convert.ToString(tabell[i]).Length;
                    //}
                    if (tabell[i] * j > brukerinput)
                    {
                        labelWidth = 4;
                        //labelWidth = 4 - Convert.ToString(tabell[i]).Length;
                        labelWidth--;
                    }
                    else if (tabell[i] * j > brukerinput * j)
                    {
                        labelWidth = 4;
                        //labelWidth = 4 - Convert.ToString(tabell[i]).Length;
                        labelWidth--;
                    }
                    else
                    {
                        
                        labelWidth = 5 - Convert.ToString(tabell[i]).Length;
                    }
                    //Array rad = new Array[i];
                    Console.Write(string.Empty.PadRight(labelWidth, ' ') + tabell[i] * j);
                }

            }

        }
    }
}
