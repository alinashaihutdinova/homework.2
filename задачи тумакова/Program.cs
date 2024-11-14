using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задачи_тумакова
{
    internal class Program
    {
        public enum AccountType
        {
            текущий,
            сберегательный
        }
        public struct Bank
        {
            public int id;
            public string type;
            public int balance;
            public void Print()
            {
                Console.WriteLine($"номер счета: {id}; тип счета: {type}; средств на счете:{balance};");
            }
        }
        public enum ВУЗ
        {
            КГУ,
            КАИ,
            КХТИ
        }
        public struct Worker
        {
            public string Name;
            public ВУЗ University;
            public Worker(string name, ВУЗ university)
            {
                Name = name;
                University = university;
            }
        }
        static void Main(string[] args)
        {
            /*Упражнение 3.1 Создать перечислимый тип данных отображающий виды банковского
            счета (текущий и сберегательный). Создать переменную типа перечисления, присвоить ей
            значение и вывести это значение на печать.*/
            Console.WriteLine("Упражнение 3.1");

            AccountType bankType = AccountType.сберегательный;
            Console.WriteLine($"текущий вид счета: {bankType}");

            /*Упражнение 3.2 Создать структуру данных, которая хранит информацию о банковском
            счете – его номер, тип и баланс. Создать переменную такого типа, заполнить структуру
            значениями и напечатать результат.*/
            Console.WriteLine("Упражнение 3.2");

            Bank bank = new Bank();
            bank.id = 1234;
            bank.type = "текущий";
            bank.balance = 100000000;
            bank.Print();


            /*Домашнее задание 3.1 Создать перечислимый тип ВУЗ{КГУ, КАИ, КХТИ}. Создать
            структуру работник с двумя полями: имя, ВУЗ. Заполнить структуру данными и
            распечатать.*/
            Console.WriteLine("Домашнее задание 3.1");


            Worker[] workers = new Worker[3];
            workers[0] = new Worker("Иван Иванов", ВУЗ.КАИ);
            workers[1] = new Worker("Сергей Смирнов", ВУЗ.КГУ);
            workers[2] = new Worker("Александр Пушкин", ВУЗ.КХТИ);
            Console.WriteLine("Список работников:");
            foreach (var worker in workers)
            {
                Console.WriteLine($"Имя: {worker.Name}, ВУЗ: {worker.University}");
            }
        }
    }
}
