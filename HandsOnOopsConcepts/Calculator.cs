﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnOopsConcepts
{
    class Calculator
    {
        private int val1;
        private int val2;

        public int Val1 { get => val1; set => val1 = value; }
        public int Val2 { get => val2; set => val2 = value; }
        public Calculator(int val1,int val2)
        {
            this.val1 = val1;
            this.val2 = val2;

        }
        
        public int Add(int num1,int num2)
        {
            return num1 + num2;
        }
        
        /*public void Swap(int num1,int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
            Console.Write(num1"\t");
            Console.WriteLine(num2);
        }
        */
        public void Subtract(int num1,int num2,out int res)
        {
            res = num1 - num2;
        }
      
        
        
    }
}
