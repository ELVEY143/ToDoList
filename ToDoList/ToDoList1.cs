using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    internal class ToDoList1
    {
        private List<string> _todoList;
        private bool _checkList = false;
        public void MadeList()
        {
            if (_checkList == false)
            {
                Console.WriteLine();
                Console.WriteLine("Вы создали список дел");
                Console.WriteLine();
                _todoList = new List<string>();
                _checkList = true;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("У вас уже есть список дел");
                Console.WriteLine();
            }
        }
        public void Add()
        {
            if (_checkList == true)
            {
                Console.WriteLine();
                Console.WriteLine("Введите дело которое нужно записать");
                Console.WriteLine();
                string a = Console.ReadLine();
                bool b = _todoList.Contains(a);

                if (b == false)
                {
                    _todoList.Add(a);
                    Console.WriteLine();
                    Console.WriteLine("Дело добавлено в список");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Дело уже есть в списке");
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Сначала создайте лист дел");
                Console.WriteLine();
            }
        }
        public void CheckList()
        {
            if (_checkList == true)
            {
                if (_todoList == null)
                {
                    Console.WriteLine();
                    Console.WriteLine("Список пуст");
                    Console.WriteLine();
                }
                else
                {
                    foreach (string list in _todoList)
                    {
                        Console.WriteLine();
                        Console.WriteLine(list);
                    }
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Сначала создайте лист дел");
                Console.WriteLine();
            }
        }
        public void Delete()
        {
            if (_checkList == true)
            {
                Console.WriteLine("Введите дело которое хотите удалить ");
                string b = Console.ReadLine();
                bool a = _todoList.Contains(b);
                if (a == true)
                {
                    _todoList.Remove(b);
                    Console.WriteLine();
                    Console.WriteLine("Элемент удален");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Элемент не найден");
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Сначала создайте лист дел");
                Console.WriteLine();
            }
        }
    }
}



