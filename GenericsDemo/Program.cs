using System.Collections;
public class MyClass<T>
{
    public T Add<T>(T a, T b, Func<T, T, T> addFunction)
    {
        return addFunction(a, b);
    }
}

// Usage:



public class Student<T>
    {
        // define a variable of type T 
        public T data;

        // define a constructor of the Student class 
        public Student(T data)
        {
            this.data = data;
            Console.WriteLine("Data passed: " + this.data);
        }

    }
    internal class Program
    {

        //static int Add (int a, int b)
        //{
        //    return a + b;
        //}

        // Generic Method

        // generic > type will be decided at run  time

        //static void Add<T>(T1 x , T2 y)
//public void displayData(T data)
//        {
//            Console.WriteLine("Data Passed: " + data);
        //}

        static void Main(string[] args)
        {

        var myClass = new MyClass<int>();
        int result = myClass.Add(5, 3, (x, y) => x + y); // Using a lambda expression
        Student<int> student = new Student<int>(10);

        Console.WriteLine(result);





        //ArrayList list = new ArrayList();
        //list.Add(10);
        //list.Add("0");

        List<int> list2 = new List<int>();
        //List<string> list3 = new List<string>();

    }
    }
