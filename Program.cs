using System;
using System.Drawing;

namespace SharpScreenhot
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("usage: SharpScreenhot.exe C:\\windows\\temp\\test.png ");
                return;
            }
            Rectangle rectangle = Rectangle.FromLTRB(0, 0, 1920, 1080);

            screenhot(rectangle, args[0]);
        }

        public static void screenhot(Rectangle rectangle, string file)
        {
            Bitmap map = new Bitmap(rectangle.Width, rectangle.Height);

            Graphics graphics = Graphics.FromImage(map);
            graphics.CopyFromScreen(rectangle.Location, Point.Empty, rectangle.Size);
            map.Save(file);
            Console.WriteLine("{0} save successful !", file);
            graphics.Dispose();
            map.Dispose();

        }
    }
}
