﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @params
{
    class myClass
    {
        public static void UseParams(params int[] list) {
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(list[i] + " ");
            }
            Console.WriteLine();
        }
        public static void UseParams2(params object[] list) {
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(list[i] + " ");
            }
            Console.WriteLine();
        }
        static void Main()
        {
            UseParams(1, 2, 3, 4);
            UseParams2(1, 'a', "test");
            UseParams();
            int[] myArray = { 5, 6, 7, 8 };
            UseParams(myArray);
            object[] myObjs = { 2, 'b', "test", "again" };
            UseParams2(myObjs);
            //UseParams(myObjs);
            //I am not sure why the following line just prints System.Int32. This example if from 
            //MSDN's content with Title Params(C# reference) and here is the comment they have about
            // it: "The following call does not cause an error, but the entire 
            // integer array becomes the first element of the params array."

            UseParams2(myArray);
            Console.ReadLine();
        }
    }
}
