using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnCollections
{
    class ArrayProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter size of elements");
            int size = int.Parse(Console.ReadLine());
            int[] a = new int[size];
            if(size%2!=0)
            {
                Console.WriteLine("enter elements");

                for (int i = 0; i < size; i++)
                {
                    a[i] = int.Parse(Console.ReadLine());
                }
                int 
                first = a[0],
                middle = a[size / 2],
                last = a[size - 1];
               
                
                    if (size == 1)
                    {
                        Console.WriteLine("large element : " + a[0]);
                    }
                    else
                    {                       
                        
                        if ((first > middle) && (first > last))
                        {
                            Console.WriteLine("largest element : " + first);
                        }
                        else if ((middle>first)&&(middle > last))
                        {
                            Console.WriteLine("largest element : " + middle);
                        }
                        else
                        {
                            Console.WriteLine("largest element : " + last);
                        }
                    }
                
            }
            else
            {
                Console.WriteLine("enter odd numbers");
            }
            
            Console.ReadLine();

        }
    }
}
