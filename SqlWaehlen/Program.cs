using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlWaehlen
{
    class Program
    {
        /// <summary>
        public static void FrameS(int x1, int y1, int x2, int y2, int tek, int bck, int txt, string metin)
        {
            Console.BackgroundColor = (ConsoleColor)Convert.ToInt16(bck);
            Console.ForegroundColor = (ConsoleColor)Convert.ToInt16(txt);

            //Console.BackgroundColor = ConsoleColor.Blue;
            ////Console.Clear();
            //Console.ForegroundColor = ConsoleColor.Red;
            char ch1, ch2, ch3, ch4, ch5, ch6;
            int x, y;
            if (tek == 1) { ch1 = '─'; ch2 = '│'; ch3 = '┌'; ch4 = '┐'; ch5 = '└'; ch6 = '┘'; }
            else { ch1 = '═'; ch2 = '║'; ch3 = '╔'; ch4 = '╗'; ch5 = '╚'; ch6 = '╝'; }
            for (x = x1; x < x2; x++)
                for (y = y1; y < y2; y++)
                { Console.SetCursorPosition(x, y); Console.WriteLine(" "); }
            for (x = x1; x < x2; x++)
            {
                Console.SetCursorPosition(x, y1); Console.WriteLine(ch1);
                Console.SetCursorPosition(x, y2); Console.WriteLine(ch1);
            }
            for (y = y1; y < y2; y++)
            {
                Console.SetCursorPosition(x1, y); Console.WriteLine(ch2);
                Console.SetCursorPosition(x2, y); Console.WriteLine(ch2);
            }
            Console.SetCursorPosition(x1, y1); Console.WriteLine(ch3);
            Console.SetCursorPosition(x2, y1); Console.WriteLine(ch4);
            Console.SetCursorPosition(x1, y2); Console.WriteLine(ch5);
            Console.SetCursorPosition(x2, y2); Console.WriteLine(ch6);
            Console.SetCursorPosition(x1 + 2, y1); Console.WriteLine(metin);

        }
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            CustomerManager customerManager = new CustomerManager();
            customerManager.baseDataManager = new OracleDBManager();
            //customerManager.baseDataManager = new SqlServerDBManager();
           //customerManager.baseDataManager = new MySqlDBManager();
          
            //customerManager.ReadFn();
            //customerManager.DeleteFn();
            //customerManager.UpdateFn();
            //Frames solust 
            //Frames (TopX1,Y1,BottomX2(80son),Y2,Tekcift(1 yada 2),CerceveArkarenk,Yazirenk,tirnak ici yazi)
            FrameS(2, 2, 78, 9, 2, 4, 7, "MESSAGE");
          
            Console.SetCursorPosition(5, 5); 
            customerManager.GetCustomer();
            Console.SetCursorPosition(5, 6);
            customerManager.CreatFn(); ;
            FrameS(60, 5, 70, 7, 1, 2, 7, "");  /*Resim*/
            Console.SetCursorPosition(64, 6); Console.WriteLine("Ok");
            Console.SetCursorPosition(78, 11);
            Console.ReadKey();
        }
    }
}
