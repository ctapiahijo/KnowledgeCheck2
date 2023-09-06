namespace KnowledgeCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" How many records would you like to add?");

            int numberOfRecords = 0;
            bool Userinput = false;
            do{
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    if(number > 0)
                    {
                        numberOfRecords = number;
                        Userinput = true;
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a number greater than 0");
                }
            }
            while(Userinput == false);
          

            List<Student> personlist = new List<Student>();

            for(int i = 0; i < numberOfRecords; ++i) 
            {
                Student person1 = new Student();

                Console.WriteLine("What is the student's first name?");
                person1.FirstName = Console.ReadLine();
                Console.WriteLine("What is the student's last name?");
                person1.LastName = Console.ReadLine();
                Console.WriteLine("What is the student's age?");
                if(int.TryParse(Console.ReadLine(),out int age) && age >=0)
                {
                    person1.Age = age;
                }
                else
                {
                    Console.WriteLine("Invalid age. Please enter a positive integer.");
                }
                Console.WriteLine("What is the student's address?");
                person1.Address = Console.ReadLine();
                Console.WriteLine("What is the student's email?");
                person1.Email = Console.ReadLine();
                Console.WriteLine("What is the student's phone number?");
                person1.PhoneNumber = Console.ReadLine();
                Console.WriteLine("What is the student's id?");
                person1.StudentId = Console.ReadLine();
                Console.WriteLine("What was the student's enrollment date? format: yyyy-MM-dd");
                if(DateTime.TryParse(Console.ReadLine(), out DateTime date))
                {
                    person1.EnrollmentDate = date;
                }
                else
                {
                    Console.WriteLine("Incorrect format, please use this date format: yyyy-MM-dd");
                }

                personlist.Add(person1);

                foreach(Student person in personlist)
                    Console.WriteLine(
                        $"Student's First Name:       {person.FirstName}\n".PadRight(30) +
                        $"Student's Last Name:        {person.LastName}\n".PadRight(30) +
                        $"Student's age:              {person.Age}\n".PadRight(30) +
                        $"Student's address:          {person.Address}\n".PadRight(30) +
                        $"Student's email:            {person.Email}\n".PadRight(30) +
                        $"Student's phone number:     {person.PhoneNumber}\n".PadRight(30) +
                        $"Student's Id number:        {person.StudentId}\n".PadRight(30) +
                        $"Student's enrollment date:  {person.EnrollmentDate.ToString("yyyy-MM-dd")}\n".PadRight(30));
            }
        }
    }
}