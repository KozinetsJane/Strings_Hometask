using System;

namespace Strings_Hometask
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] glasnie = new char[20] { 'а', 'о', 'и', 'е', 'ё', 'э', 'ы', 'у', 'ю', 'я', 'А', 'О', 'И', 'Е', 'Ё', 'Э', 'Ы', 'У', 'Ю', 'Я' };
            string str = "За двумя зайцами погонишься – ни одного не поймаешь.";
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < glasnie.Length; j++)
                {
                    if (glasnie[j] == str[i])
                    {
                        count++;
                    }
                }

            }
            Console.WriteLine("Количество гласных в строке:" + count);
            str = str.Replace('а', 'А');
            Console.WriteLine(str);
            Console.ReadKey();




        }
    }
}
