using System;
public class Epson : IPrinterWindows
    {
        public void show()
        {
         Console.WriteLine("Epson Display dimension : 10*11");
        }

        public void print()
        {
         Console.WriteLine("Epson printer printing ...");
        }
    }