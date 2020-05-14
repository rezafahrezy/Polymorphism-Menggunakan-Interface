using System;
public class LaserJet : IPrinterWindows
    {
        public void show()
        {
         Console.WriteLine("Laserjet Display dimension : 12*12");
        }

        public void print()
        {
         Console.WriteLine("LaserJet printer printing ...");
        }
    }