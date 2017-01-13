using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysH02
{
    class Compare_Wrong
    {
        static void Main(string[] args)
        {
            /* Задача 2.
             * Да се напише програма, която чете два масива от конзолата
             * и проверява дали са еднакви.
             * (Hint: Два масива са еднакви, когато имат еднаква дължина
             * и стойностите на елементите в тях съответно съвпадат.)*/

            Console.WriteLine("Въведете размер на първия масив: ");
            int firstArrayLength = int.Parse(Console.ReadLine()); //*прочитаме един ред от конзолата и парсваме(преобразуваме към цяло число)
            int[] firstArray = new int[firstArrayLength];         //*присвояваме на n, за да го ползваме като размер(length) на масива

            Console.WriteLine("Въведете размер на втория масив: ");
            int secondArrayLength = int.Parse(Console.ReadLine());
            int[] secondArray = new int[secondArrayLength];
            if (firstArray.Length != secondArray.Length)
            {
                Console.WriteLine("Error! Write again!");
               // break;
            }
            else
            {

                for (int i = 0; i < firstArray.Length; i++)
                {
                    Console.WriteLine("Моля въведете {0} число от първия масив: ", i);
                    firstArray[i] = int.Parse(Console.ReadLine());
                }

                for (int i = 0; i < secondArray.Length; i++)
                {
                    Console.WriteLine("Моля въведете {0} число от втория масив: ", i);
                    secondArray[i] = int.Parse(Console.ReadLine());
                }

                for (int i = 0; i <= firstArray.Length; i++)
                {
                    if (firstArray[i] != (secondArray[i]-1))
                    {

                        Console.WriteLine("Error!");
                        //break;

                    }
                    else
                    {
                        Console.WriteLine("Двата масива са еднакви");
                    }


                }

            }
        }
    }
}

/*//ОБЯСНЕНИЕ: Първото нещо, което правим е да инициализираме самия размер на двата масива. 
Макар и незадължително по условие, с помоща на if условието проверяваме дали броя на елементите в двата масива са равни. 
Това може и да не го правим, ако просто накараме потребителя веднъж да въведе число за размера на масивите (веднъж като го въведе ще го ползваме същата променлива при инициализацията и на втория масив).
След това с помощта на for цикли въвеждаме самите стойности из одтелните позиции на двата масива.
Преминаваме към същинската част на задачата - сравняване на самите отделни стойности в масива една по една. Използваме булева променлива, в която изначално казваме че елементите в двата масива са равни, до доказване на противното.
С помощта на for цикъл започваме да сравняваме отделните елементи на масивите един по един. 
В случай че два елемента от една и съща позиция в масивите се случи да не са равни се изпълнява if условието, променливата, която съзадохе по-горе вече става false и се прехвърляме към break оператъра, тъй като при това положение няма смисъл да продължаваме да сравняваме останалите елементи из масивите.
Отпечатваме резултата на конзолата.*/

           