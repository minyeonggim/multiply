using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("구구단 입력 프로그램");
            while(true)
            {
                Console.WriteLine("수를 입력하세요");
                string input = Console.ReadLine();
                int inputNum;
                if (int.TryParse(input, out inputNum))
                {
                    for (int i = 1; i <= 9; i++)

                    {
                        Console.WriteLine($"{inputNum}*{i} = {inputNum * i}");
                    }
                    Console.Read();
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("숫자만 입력하세요");
                }
            }
            
            
        }
    }
}
