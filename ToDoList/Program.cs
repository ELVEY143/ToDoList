using ToDoList;
ToDoList1 list = new ToDoList1();
void Menu()
{
    Console.WriteLine();
    Console.WriteLine("Выбeрите функцию");
    Console.WriteLine();
    Console.WriteLine("1. Создать список дел");
    Console.WriteLine("2. Добавить запись");
    Console.WriteLine("3. Просмотреть список дел");
    Console.WriteLine("4. Удалить запись из списка");
    Console.WriteLine();
    string func = Console.ReadLine();
    int func1 = int.Parse(func);
    if (func1 == 1)
    {
        list.MadeList();
    }

    else if (func1 == 2)
    {

        list.Add();

    }

    else if (func1 == 3)
    {

        list.CheckList();

    }
    else if (func1 == 4)
    {

        list.Delete();

    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Такого пункта нет в меню");
        Console.WriteLine();
    }

}
while (true)
{
    Menu();
}
