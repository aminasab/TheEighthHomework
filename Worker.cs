namespace TheEighthProgram
{
    internal class Worker 
    {
        public string Name { get; set; }
        public int Salary { get; set; }
        public Worker? LeftNode { get; set; }
        public Worker? RightNode { get; set; }

        public Worker (string name, int salary)
        {
            Name = name;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"{Name} : {Salary} рублей";
        }
    }
}
