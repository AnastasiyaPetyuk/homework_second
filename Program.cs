using System;

// Программа-калькулятор. Пользователю предлагается ввести 3 строки. Первая – первый операнд,
// вторая – операция (* , / , + , -), третья – второй операнд.
// Программа должна выполнить запрошенную операцию с этими операндами.
// Программа должна обрабатывать ввод всех недопустимых данных (обратите внимание,
// что вторым параметром можно ввести 1 из 4х знаков), сообщить пользователю об ошибке и запросить
// это параметр заново. В конце программа должна выдать результат вычисления;

namespace homework_second
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            int firstNumber = First();
            string sign = Second();
            int secondNumber = Third();
            Console.WriteLine("Результат:\n" + Result(firstNumber, sign, secondNumber));
        }

        static int First()
        {
            Console.WriteLine("Введите первый операнд: ");
            string a = Console.ReadLine();
            try
            {
                return int.Parse(a);
            }
            catch (FormatException)
            {
                Console.WriteLine("Можно вводить только цифры");
                return First();
            }
        }

        static string Second()
        {
            Console.WriteLine("Введите операцию: ");
            string sign = Console.ReadLine();

            if (sign == "*" || sign == "/" || sign == "+" || sign == "-")
            {
                return sign;
            }
            else
            {
                Console.WriteLine("Можно вводить только *, /, +, -");
                return Second();
            }
        }

        static int Third()
        {
            Console.WriteLine("Введите второй операнд: ");
            string b = Console.ReadLine();
            try
            {
                return int.Parse(b);
            }
            catch (FormatException)
            {
                Console.WriteLine("Можно вводить только цифры");
                return Third();
            }
        }

        static int Result(int firstNumber, string sign, int secondNumber)
        {
            switch (sign)
            {
                case "*":
                    return firstNumber * secondNumber;
                case "/":
                    return firstNumber / secondNumber;
                case "+":
                    return firstNumber + secondNumber;
                case "-":
                    return firstNumber - secondNumber;

            }
            return 0;
        }
    }
}
