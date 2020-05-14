using System;
public class Canon : IPrinterWindows
    {
        public void show()
        {
         Console.WriteLine("Canon Display dimension : 9.5*12");
        }

        public void print()
        {
         Console.WriteLine("Canon printer printing ...");
        }
    }