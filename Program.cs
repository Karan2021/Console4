using System;
using System.IO;

class filexercise2
{
    public static void Main()
    {
        string fileName = @"C:\Training\CSharp\ConsoleApp4\ConsoleApp4\mytest.txt";
        Console.Write("Remove a file from the disk (at first create the file)\n");

        if (File.Exists(fileName))
        {
            File.Delete(fileName);
            Console.WriteLine(" The file {0} deleted successfully", fileName);
        }
        else
        {
            Console.WriteLine(" File does not exist");
            Console.ReadKey();
        }
    }
}
