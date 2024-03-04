using System.Text;

namespace _4._5_Assignement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("press ENTER to reveal a fish");
            Console.ReadLine();
            DrawFish1();
            Console.WriteLine("Press ENTER to reveal another fish");
            Console.ReadLine();
            DrawFish2();
            Console.WriteLine("Press ENTER to reveal one more fish");
            Console.ReadLine();
            DrawShark();

            Console.WriteLine();
            Console.WriteLine("Knock knock!");
            Thread.Sleep(750);
            Console.WriteLine("Who's there?");
            Thread.Sleep(750);
            Console.WriteLine("Ice cream");
            Thread.Sleep(750);
            Console.WriteLine("Ice cream who?");
            Thread.Sleep(750);
            Console.WriteLine("Ice cream when I get scared, don't you?");
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
            Console.WriteLine(" _________           .    .");
            Console.WriteLine("(..       \\_     , |\\  /|");
            Console.WriteLine(" \\       O  \\  /|  \\ \\/ ");
            Console.WriteLine("  \\______    \\/ |   \\ / ");
            Console.WriteLine("     vvvv\\    \\ |   /  |");
            Console.WriteLine("     \\^^^^  ==   \\_/   |");
            Console.WriteLine("      `\\_   ===    \\.  |");
            Console.WriteLine("      / /\\_   \\ /      |");
            Console.WriteLine("      |/   \\_  \\|      /");
            Console.WriteLine("             \\________/");
        }
        

        

    }
    

}
