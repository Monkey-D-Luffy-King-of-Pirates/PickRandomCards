using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickRandomCards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of cards to pick: ");
            string line = Console.ReadLine();
            if (int.TryParse(line, out int numberOfCards))
            {
                foreach (string card in CardPicker.PickSomeCards(numberOfCards))
                {
                    Console.WriteLine(card);
                }
                // этот блок выполняется в том случае, если строка МОЖЕТ БЫТЬ преобразована в int
                // значение, сохраняемое в новой переменной, называется numberOfCards
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
                // этот блок выполняется, если строка НЕ МОЖЕТ БЫТЬ преобразована в int
            }
            Console.ReadKey();
        }
    }
}
