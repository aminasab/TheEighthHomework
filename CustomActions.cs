namespace TheEighthProgram
{
    internal class CustomActions
    {
        /// <summary>
        /// Ввод информации о сотруднике и его зарплате.
        /// </summary>
        public static Worker InputEmployees(Worker root)
        {
            Console.WriteLine("Введите на 1 строке Ф.И.О. сотрудника,\n" +
                "а на 2 строке его зарплату.\n" +
                "Окончанием ввода будет служить пустая строка.");
            while (true)
            {
                var name = Console.ReadLine() ?? "";
                if (name == string.Empty)
                {
                    break;
                }
                int salary;
                while (!int.TryParse(Console.ReadLine() ?? "", out salary))
                {
                    Console.WriteLine("Введите целое число");
                }

                if (root == null)
                {
                    root = new Worker(name, salary);
                }
                else
                {
                    BinaryTree.AddNode(root, new Worker(name, salary));
                }
            }
            return root;
        }

        /// <summary>
        /// Поиск сотрудника по зарплате.
        /// </summary>
        public static int InputSalaryForSearch()
        {
            Console.WriteLine("Введите зарплату для поиска: ");
            var salary = Console.ReadLine() ?? "";
            return int.Parse(salary);
        }

        public static int InputUserChoice()
        {
            string choice;
            while (true)
            {
                Console.WriteLine("Выберите действие:\n" +
                    "0 - переход к началу программы\n" +
                    "1 - поиск зарплаты");
                choice = Console.ReadLine()?.Trim() ?? "";
                if (choice is "0" or "1")
                    break;
            }
            return int.Parse(choice);
        }
    }
}
