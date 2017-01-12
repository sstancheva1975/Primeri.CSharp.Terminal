using System;

namespace H01
{
    class TypeCasting
    {
        static void Main()
        {
            /*Зад.1
             * Декларирайте две променливи от тип string и им присвоете
             * стойности "Hello" и "World".*/
            string first= "Hello";
            string second = "World!";
            /*Декларирайте променлива от тип object и 
             *й присвоете стойността на конкатенацията
             *на двете променливи от тип string
             *(не изпускайте интервала по средата).*/
            object obj = first + " " + second;
            Console.WriteLine(obj);
            /*Декларирайте трета променлива от тип string
             *и я инициализирайте със стойността на
             *променливата от тип object.
            *( Hint: Трябва да използвате type casting.)
             */
            string third;
            third = (string)obj;
            Console.WriteLine(third);
            

            
          }


      }
}
