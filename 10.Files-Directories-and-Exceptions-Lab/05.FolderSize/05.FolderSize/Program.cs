﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _05.FolderSize
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] filesDir = Directory.GetFiles("TestFolder");
            double sum = 0;

            foreach (var file in filesDir)
            {
                FileInfo fileInf = new FileInfo(file);

                sum += fileInf.Length;
            }

            sum = sum / 1024 / 1024;


            File.WriteAllText("output.txt", sum.ToString());
        }
    }
}
