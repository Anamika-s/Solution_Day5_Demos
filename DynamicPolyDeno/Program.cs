namespace DynamicPolyDeno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee;
            Console.WriteLine("What type of Employee");
            int ch = byte.Parse(Console.ReadLine());
            switch(ch)
            {
                case 1:
                    employee = new PartTimeEmployee();
                    employee.GetDetails();
                    employee.DisplayDetails();
                    break;
                case 2:
                    employee = new FullTimeEmployee();
                    employee.GetDetails();
                    employee.DisplayDetails();
                    break;
            }
           


        }
    }
}