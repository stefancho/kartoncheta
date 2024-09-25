using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kartoncheta
{
    class Program
    {
        static void Main(string[] args)
        {
            //Въвеждаме броя картончета в променливата n
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());

            //Въвеждаме номерата на картончетата
            int[] cards = new int[n];
            for (int i = 0; i < cards.Length; i++)
            {
                cards[i] = int.Parse(Console.ReadLine());
            }

            //Променливите minCard и maxCard ще бъдат използвани за намиране на най-малката и съответно най-голямата стойности
            int minCard = int.MaxValue, maxCard = int.MinValue;
            //Първо намираме най-малката стойност
            for (int i = 0; i < cards.Length; i++)
            {
                if (cards[i] == (i + 1) && minCard > cards[i])
                {
                    minCard = cards[i];
                }
            }
            //Nамираме най-голямата стойност
            for (int i = 0; i < cards.Length; i++)
            {
                if (cards[i] == (i + 1) && maxCard < cards[i])
                {
                    maxCard = cards[i];
                }
            }

            //Извеждаме резултата
            if (minCard == int.MaxValue || maxCard == int.MinValue || minCard == maxCard)//няма картончета по местата си или само едно картонче си е на мястото
            {
                Console.WriteLine("0 0");
            }
            else
            {
                Console.WriteLine(minCard + " " + maxCard);
            }
        }
    }
}
