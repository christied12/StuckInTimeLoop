﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timeLoop
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());

            for (int i=0; i < number; i++)
            {
                Console.WriteLine((i+1) + "Abracadabra");
            }
            

           
        }
    }
}
