using System;

namespace Antibiooti.Forum2016
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // using(var screen = new Screen()) {
            //     screen.Clear();
            //     screen.Write(10, 10, "*   *   *     *   *   *    *   *   *     *   *   *     *   *   *");
            //     screen.Write(10, 11, "  * * *         * * *        * * *         * * *         * * *  ");
            //     screen.Write(10, 12, "* * * * *     * * * * *    * * * * *     * * * * *     * * * * *");
            //     screen.Write(10, 13, "  * * *         * * *        * * *         * * *         * * *  ");
            //     screen.Write(10, 14, "*   *   *     *   *   *    *   *   *     *   *   *     *   *   *");
            //     Console.ReadKey(true);
            
            // }

            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }
        }
    }
}
