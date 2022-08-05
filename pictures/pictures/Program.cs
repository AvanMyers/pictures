using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pictures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int allPictures = 52;
            int linedUp = 3;

            int beyondMeasure = allPictures % linedUp;
            int result = allPictures / linedUp;

            Console.WriteLine($"Полностью заполненных рядов картнок {result}" +
                $", а картинок сверх меры {beyondMeasure}");
            

            Console.ReadKey();

        }
    }
}
