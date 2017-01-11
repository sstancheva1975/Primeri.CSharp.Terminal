using System;


namespace H02
{
    class Length
    {
        static void Main()
        {
            /*Да се въведат от командния ред 1 число или цифра и 1 дума/стринг.*/
            int number = 0;
            string word = "";
            Console.Write("Въведете число: ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Въведете дума: ");
            word = Console.ReadLine();
            /* След това да изведе дължината на получения стринг при конкатенация,
             * тоест броя на символите в новополучения стринг при конкатенация.
             * (Hint: Трябва да преобразувате int към String и след това да конкатениратe.)
             */
           
            Console.Write("Броят на символите в новополучения стринг при конкатенацията на числото и думата е: ");
            Console.WriteLine(number.ToString().Length + word.Length);
        }
    }
}
