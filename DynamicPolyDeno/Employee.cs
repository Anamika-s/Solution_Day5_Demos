using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicPolyDeno
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public virtual void GetDetails()
        {
            Console.WriteLine("Enter ID");
            Id = Byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Address");
            Address = Console.ReadLine();
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine("ID is  " + Id);
            Console.WriteLine("Name is " + Name);
            Console.WriteLine("Address is " + Address);
        }
    }

    class PartTimeEmployee : Employee
    {
        public string ProjectName { get; set; }
        public int Charges { get; set; }
        public override void GetDetails()
        {
            base.GetDetails();
            Console.WriteLine("Enter ProjectName");
            ProjectName = Console.ReadLine();
            Console.WriteLine("Enter Charges");
            Charges = int.Parse(Console.ReadLine());
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("ProjectName is  " + ProjectName);
            
            Console.WriteLine("Charges are " + Charges);
        }
    }


    class FullTimeEmployee : Employee
    {
        public string Department { get; set; }
        public string ManagerName { get; set; }
        public float BasicSalary { get; set; }
        public override void GetDetails()
        {
            base.GetDetails();
            Console.WriteLine("Enter Department");
            Department = Console.ReadLine();
            Console.WriteLine("Enter ManagerName");
            ManagerName = Console.ReadLine();
            Console.WriteLine("Enter BasicSalary");
            BasicSalary = float.Parse(Console.ReadLine());
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Department is  " + Department);
            Console.WriteLine("ManagerName is " + ManagerName);
            Console.WriteLine("BasicSalary is " + BasicSalary);
        }
    }


}
