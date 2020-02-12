﻿using System;
using System.IO;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"z:\marcelo\workspaces\files\file1.txt";//path to a file.txt with some texts
            FileStream fS = null;
            StreamReader sR = null;

            try
            {
                fS = new FileStream(sourcePath, FileMode.Open);
                sR = new StreamReader(fS);

                string line = sR.ReadLine();
                Console.WriteLine(line);
            }catch(IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sR != null) sR.Close();
                if (fS != null) fS.Close();
            }
        }
    }
}
