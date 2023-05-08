namespace TheEighthProgram
{
    internal class Program
    {
        public static Worker? Root { get; set; }
        public static int UserChoice { get; set; }

        static void Main(string[] args)
        {
            while (true)
            {
                if (UserChoice == 0)
                {
                    Root = null;
                    Root = CustomActions.InputEmployees(Root!);
                    Root = BinaryTree.Traverse(Root);
                }
                var salary = CustomActions.InputSalaryForSearch();
                var foundNode = BinaryTree.FindNodeBySalary(Root, salary);
                if (foundNode != null)
                {
                    Console.WriteLine(foundNode);
                }
                else
                {
                    Console.WriteLine("Такой сотрудник не найден!");
                }
                UserChoice = CustomActions.InputUserChoice();
            }
        }
    }
}