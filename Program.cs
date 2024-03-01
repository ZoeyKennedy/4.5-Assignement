using System.Text;

namespace _4._5_Assignement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("press ENTER to reveal a fish");
            DrawFish1();
             
        }
        public static void DrawFish1()
            {
            Console.WriteLine("      /\\");
            Console.WriteLine("    _/./");
            Console.WriteLine(" ,-'    `-:..-'/");
            Console.WriteLine(": o )      _  (");
            Console.WriteLine("\"`-....,--; `-.\\");
            Console.WriteLine("    `'");
            }
        public static void DrawFish2()
        {
            Console.WriteLine("  o o          .:/    ");
            Console.WriteLine("    o      ,,///;,   ,;/ ");
            Console.WriteLine("      o   o)::::::;;///");
            Console.WriteLine("         >::::::::;;\\\\\\ ");
            Console.WriteLine("           ''\\\\\\\\\\'\" ';\\ ");
            Console.WriteLine("              ';\\");
        }
        public static void DrawShark()
        {
            Console.WriteLine(" _________         .    .");
            Console.WriteLine("(..       \\_    ,  |\\  /|");
            Console.WriteLine(" \\       O  \\  /|  \\ \\/ /");
            Console.WriteLine("  \\______    \\/ |   \\  / ");
            Console.WriteLine("     vvvv\\    \\ |   /  |");
            Console.WriteLine("     \\^^^^  ==   \\_/   |");
            Console.WriteLine("      `\\_   ===    \\.  |");
            Console.WriteLine("      / /\\_   \\ /      |");
            Console.WriteLine("      |/   \\_  \\|      /");
            Console.WriteLine("             \\________/");
        }

        
    }


}
