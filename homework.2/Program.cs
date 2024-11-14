using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework._2
{
    internal class Program
    {
        struct Person
        {
            public string name;
            public string city;
            public int age;
            public int pincode;
            public void Personinfo()
            {
                Console.WriteLine($"Имя: {name} Город: {city} Возраст: {age} Пин-код: {pincode}");
            }
        }
        static void Main(string[] args)
        {
            /*1. Выведите на экран информацию о каждом типе данных в виде:
            Тип данных – максимальное значение – минимальное значение*/
            Console.WriteLine("задание 1");

            Console.WriteLine($"sbyte - {sbyte.MaxValue} - {sbyte.MinValue}");
            Console.WriteLine($"byte - {byte.MaxValue} - {byte.MinValue}");
            Console.WriteLine($"short - {short.MaxValue} - {short.MinValue}");
            Console.WriteLine($"ushort - {ushort.MaxValue} - {ushort.MinValue}");
            Console.WriteLine($"int - {int.MaxValue} - {int.MinValue}");
            Console.WriteLine($"uint - {uint.MaxValue} - {uint.MinValue}");
            Console.WriteLine($"long - {long.MaxValue} - {long.MinValue}");
            Console.WriteLine($"ulong - {ulong.MaxValue} - {ulong.MinValue}");
            Console.WriteLine($"float - {float.MaxValue} - {float.MinValue}");
            Console.WriteLine($"double - {double.MaxValue} - {double.MinValue}");
            Console.WriteLine($"decimal - {decimal.MaxValue} - {decimal.MinValue}");
            Console.WriteLine($"char - {char.MaxValue} - {char.MinValue}");

            /*2.Напишите программу, в которой принимаются данные пользователя в виде имени,
            города, возраста и PIN-кода.Далее сохраните все значение в соответствующей
            переменной, а затем распечатайте всю информацию в правильном формате.*/
            Console.WriteLine("задание 2");

            Person person = new Person();
            Console.WriteLine("Напишите имя");
            person.name = Console.ReadLine();
            Console.WriteLine("Напишите город");
            person.city = Console.ReadLine();
            Console.WriteLine("Введите возраст");
            person.age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите пин-код");
            person.pincode = Convert.ToInt32(Console.ReadLine());
            person.Personinfo();

            /*3. Преобразуйте входную строку: строчные буквы замените на заглавные, заглавные – на
            строчные.*/
            Console.WriteLine("задание 3");

            Console.WriteLine("Введите текст");
            string text = Console.ReadLine();
            string newtext = "";
            foreach (char c in text)
            {
                if (char.IsLower(c))
                {
                    newtext += char.ToUpper(c);
                }
                else if (char.IsUpper(c))
                {
                    newtext += char.ToLower(c);
                }
                else
                {
                    newtext += c;
                }
            }
            Console.WriteLine(newtext);


            /*4.Введите строку, введите подстроку. Необходимо найти количество вхождений и вывести
            на экран.*/
            Console.WriteLine("задание 4");

            Console.WriteLine("Введите строку:");
            string inputString = Console.ReadLine();
            Console.WriteLine("Введите подстроку:");
            string substring = Console.ReadLine();

            int count = 0;
            int index = 0;

            while ((index = inputString.IndexOf(substring, index)) != -1)
            {
                count++;
                index += substring.Length;
            }
            Console.WriteLine($"Количество вхождений подстроки \"{substring}\" в строке: {count}");


            /*5. Цель этой задачи - определить, сколько бутылок виски беспошлинной торговли вам
            нужно будет купить, чтобы экономия по сравнению с обычной средней ценой фактически
            покрыла расходы на ваш отпуск. Вам будет предоставлена стандартная цена (normPrice),
            скидка в Duty Free (salePrice) и стоимость отпуска (holidayPrice). Например, если бутылка
            обычно стоит 10 фунтов стерлингов, а скидка в дьюти фри составляет 10%, вы
            сэкономите 1 фунт стерлингов на каждой бутылке. Если ваш отпуск стоит 500 фунтов
            стерлингов, ответ, который вы должны вернуть, будет 500. Все входные данные будут
            целыми числами. Пожалуйста, верните целое число. Округлить в меньшую сторону.*/
            Console.WriteLine("задание 5");

            Console.WriteLine("Введите стандартную цену");
            int normPrice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите скидку в дьюти фри в процентах");
            int salePrice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите стоимость отпуска");
            int holidayPrice = Convert.ToInt32(Console.ReadLine());
            double savings = normPrice * salePrice / 100;
            double bottlesamount = (holidayPrice / savings);
            Console.WriteLine($"Вам нужно купить бутылок: {Math.Floor(bottlesamount)}");


            /*6. Создать структуру студента. У студента есть Фамилия, Имя, его Идентификатор, Дата
            рождения, Категория алкоголизма (a – студент алкоголик, b – студент любитель
            выпить, но не алкоголик, c – студент пьет по праздникам, d – студент не пьет), также у
            студента есть Объем выпитой жидкости конкретного напитка. Создать 5 студентов с
            различными параметрами. Посчитать общий объем выпитого, общий объем алкоголя
            (процент спирта) и кто сколько процентов алкоголя и жидкости от общего количества
            выпил. Предполагается, что студент пьет один вид напитка. Напитки задать в виде
            структуры: наименование типа напитка и процент спирта.*/

        }
    }
}
