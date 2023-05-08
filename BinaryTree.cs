namespace TheEighthProgram
{
    // Бинарное дерево.
    internal class BinaryTree
    { 
        /// <summary>
        /// Поиск узла по зарплате.
        /// </summary>
        public static Worker? FindNodeBySalary(Worker? root, int salary)
        {
            if (salary < root?.Salary)
            {
                return root.LeftNode != null ? FindNodeBySalary(root.LeftNode, salary) : null;
            }
            if (salary > root?.Salary)
            {
                return root.RightNode != null ? FindNodeBySalary(root.RightNode, salary) : null;
            }
            return root;
        }

        /// <summary>
        /// Вывод сотрудников, отсортированный по их зарплате.
        /// </summary>
        public static Worker Traverse(Worker? root)
        {
            if (root?.LeftNode != null)
            {
                Traverse(root.LeftNode);
            }
            Console.WriteLine(root);
            if (root?.RightNode != null)
            {
                Traverse(root.RightNode);
            }
            return root!;
        }

        /// <summary>
        /// Добавить узел.
        /// </summary>
        public static void AddNode(Worker root, Worker employeeNode)
        {
            if (employeeNode.Salary < root.Salary)
            {
                if (root.LeftNode != null)
                {
                    AddNode(root.LeftNode, employeeNode);
                }
                else
                {
                    root.LeftNode = employeeNode;
                }
            }
            else
            {
                if (root.RightNode != null)
                {
                    AddNode(root.RightNode, employeeNode);
                }
                else
                {
                    root.RightNode = employeeNode;
                }
            }
        }
    }
}
