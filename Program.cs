namespace EmployeesAndSpecializations
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee aEmployee1 = new Employee("Chloe", 128000);
            Employee aEmployee2 = new Employee("Emilynn", 320000);
            Employee aEmployee3 = new Employee("Marlee", 43000);





            Manager aManager1 = new Manager("Chloe", 100, 13);
            Manager aManager2 = new Manager("Emilynn", 114, 10);


            Engineer aEngineer = new Engineer("Marlee", 300, "airplanes");

            Console.WriteLine(aEmployee1.ToString());
            Console.WriteLine(aEmployee2.ToString());
            Console.WriteLine(aEmployee3.ToString());

            Console.WriteLine(aEngineer.ToString());
            Console.WriteLine(aManager1.ToString());
            Console.WriteLine(aManager2.ToString());
        }
    }
}
