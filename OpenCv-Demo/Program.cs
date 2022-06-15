using System;

namespace OpenCv_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CVSImage cVS = new CVSImage(@"C:\Duke\C#dev\Rust.png");

            cVS.ShowImage("OOP");
        }
    }
}
