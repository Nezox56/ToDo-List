List<string> toDoList = new List<string>();

void App()
{
    Console.WriteLine("Выберете действие (введите цифру): \n" +
       "1) Показать список задач \n" +
       "2) Добавить новую задачу \n" +
       "3) Очистить список \n");

    switch (Console.ReadLine())
    {
        case "1":
            Console.Clear();
            Console.WriteLine("Список задач: \n");
            foreach (var n in toDoList)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("--------------------------");
            App();
            break;

        case "2":
            var str = Console.ReadLine();
            if (str != "")
            {
                AddTask(str);
                App();
            }
            else
            {
                goto case "2";
            }
            break;

        case "3":
            ClearList();
            App();
            break;

        default:
            Console.WriteLine("Такого варината нету, введите еще раз номер действия!");
            Console.Clear();
            App();
            break;
    }
}

void AddTask(string str)
{
    toDoList.Add(str);
}

void ClearList()
{
    toDoList.Clear();
}

App();