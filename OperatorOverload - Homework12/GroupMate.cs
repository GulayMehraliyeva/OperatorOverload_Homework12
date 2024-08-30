namespace OperatorOverload___Homework12
{
    internal class GroupMate
    {
        public Student[] students;
        public int count;

        public GroupMate(int size)
        {
            students = new Student[size];
            count = 0;
        }

        public void Add(Student student)
        {
            if (count < students.Length)
            {
                students[count] = student;
                count++;
            }
            else
            {
                Console.WriteLine("Cannot add more students");
            }
        }

        public void Sort()
        {
            for (int i = 0; i < count - 1; i++)
            {
                for (int j = 0; j < count - i - 1; j++)
                {
                    if (students[j] < students[j + 1])
                    {
                        Student temp = students[j];
                        students[j] = students[j + 1];
                        students[j + 1] = temp;
                    }
                }
            }
        }
    }
}
    
