using System;

namespace LessonHW9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Предположим, что логин\пароль для входа в систему: johnsilver\qwerty.
            //Запросить у пользователя логин и пароль. Дать пользователю только три попытки для ввода корректной пары логин\пароль.
            //Если пользователь произвёл корректный ввод, вывести на консоль: "Enter the System" и прекратить запрос логина\пароля.
            //Если пользователь ошибся трижды -вывести "The number of available tries have been exceeded" и прекратить запрос пары логин\пароль.

           
            string access = "johnsilver qwerty";

            Console.WriteLine("Введите логин и пароль");
            
            for(int i = 2;i >= 0; i--)
            {

                string input = Console.ReadLine();

                if (access == input)
                {
                    Console.WriteLine("Enter the system");
                    break;
                }
                else if (i == 0)
                {
                    Console.WriteLine("Вы исчерпали поытки ввода пароля, повторите позже.");
                }
                else
                {
                    Console.WriteLine($"У вас осталось {i} попытка(-и)");
                }
            }

            Console.ReadLine();

        }
    }
}
