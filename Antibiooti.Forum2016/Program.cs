using System;

namespace Antibiooti.Forum2016
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*using(var screen = new Screen()) {
                screen.Clear();
                screen.Write(10, 10, "*   *   *     *   *   *    *   *   *     *   *   *     *   *   *",ConsoleColor.Blue);
                screen.Write(10, 11, "  * * *         * * *        * * *         * * *         * * *  ");
                screen.Write(10, 12, "* * * * *     * * * * *    * * * * *     * * * * *     * * * * *");
                screen.Write(10, 13, "  * * *         * * *        * * *         * * *         * * *  ");
                screen.Write(10, 14, "*   *   *     *   *   *    *   *   *     *   *   *     *   *   *");
                Console.ReadKey(true);

            }*/
            /*FakeScreen scr=new FakeScreen();
            //scr.Clear();
                scr.Write(10, 10, "*   *   *     *   *   *    *   *   *     *   *   *     *   *   *",ConsoleColor.Blue);
                scr.Write(10, 11, "  * * *         * * *        * * *         * * *         * * *  ");
                scr.Write(10, 12, "* * * * *     * * * * *    * * * * *     * * * * *     * * * * *");
                scr.Write(10, 13, "  * * *         * * *        * * *         * * *         * * *  ");
                scr.Write(10, 14, "*   *   *     *   *   *    *   *   *     *   *   *     *   *   *");
                Console.ReadKey(true);*/
                
           Screen scr=new Screen();
           Character c = new Character('.');
           
        //    scr.printCharacter(c, 0, ConsoleColor.White);
        //    scr.printCharacter(c, 1, ConsoleColor.White);
        //    scr.printCharacter(c, 2, ConsoleColor.White);
        //    scr.printCharacter(new Character('/'), 3, ConsoleColor.Cyan);
        //    scr.printCharacter(new Character('\\'), 4, ConsoleColor.Green);

            CommandlineScanner scanner= new CommandlineScanner();
            scanner.ProcessArgs(args);
        }
        
    }
}
