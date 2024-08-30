namespace OperatorOverload___Homework12
{
    internal class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        private int _age;
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if(value < 0)
                {
                    Console.WriteLine("Age cannot be less than 0");
                    Environment.Exit(0);
                }
                _age = value;
            }
        }
        
        public Student(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public static bool operator >(Student s1, Student s2)
        {
            return s1.Age > s2.Age;
        }

        public static bool operator <(Student s1, Student s2)
        {
            return s1.Age < s2.Age;
        }
    }
}
