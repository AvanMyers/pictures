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
            int pituresInLine = 3;

            int beyondMeasure = allPictures % pituresInLine;
            int filledRows = allPictures / pituresInLine;

            Console.WriteLine($"Полностью заполненных рядов картнок {filledRows}" +
                $", а картинок сверх меры {beyondMeasure}");
            

            Console.ReadKey();

        }
    }
}
