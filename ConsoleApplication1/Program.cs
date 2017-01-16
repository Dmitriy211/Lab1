using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int k= 0;   //дополнительная переменная
            for (int i = 0; i < args.Length; i++)   //Цикл для проверки каждого числа массива
            {                
                k = 0;  //Обнуление переменной для повторных вычислений
                for (int j = 2; j < int.Parse(args[i]); j++)    // j - это числа между еденицей и проверяемым числом
                {         
                    if (int.Parse(args[i]) % j == 0)    // Делится ли проверяемое число на j
                    {
                        k = 1;  // Если да, то переменная k изменяется 
                    }
                }
                if (k == 0)  // Если переменная осталась неизменной,...
                {
                    Console.WriteLine(args[i]); // ...То выводится числj
                }                                
            }
        }
    }
}
