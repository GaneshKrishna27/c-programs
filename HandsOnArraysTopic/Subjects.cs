using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArraysTopic
{
    class Subjects
    {
        static void Main(String[] arg)
        {
            Console.WriteLine("enter elements in arry");
            int[,] marks = new int[5, 3];
            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < 3; col++)
                {

                    marks[row, col] = int.Parse(Console.ReadLine());

                }
                Console.WriteLine();             
            }
            
            for (int col = 0; col < 3; col++)
            {
                int topscore = 0;
                for (int row = 0; row < 5; row++)
                {
                    if (row == 0) 
                        topscore = marks[row, col];
                    else
                    {
                        if (marks[row, col] > topscore) 
                            topscore = marks[row, col];
                    }
                    Console.WriteLine("highest for subject" + (col + 1) + "is" + topscore);
                    




                }
            }
            
            foreach (int x in marks)
            {
                Console.WriteLine(x);
                Console.ReadLine();
            }
        }
    }
}

