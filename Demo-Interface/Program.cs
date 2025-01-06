using Demo_Interface.Interface_EX01;
using Demo_Interface.Interface_EX02;
using Demo_Interface.Interface_EX03;
using System.Text;

namespace Demo_Interface
{
    internal class Program
    {
        //static void Print10Numbers(SeriesByTwo series)
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        System.Console.Write($"{series.current} ");
        //        series.Next();

        //    }
        //    Console.WriteLine();
        //    series.Reset();
        //}

        //static void Print10Numbers(SeriesByThree series)
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        System.Console.Write($"{series.current} ");
        //        series.Next();

        //    }
        //    Console.WriteLine();
        //    series.Reset();
        //}

        //static void Print10Numbers(SeriesByFour series)
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        System.Console.Write($"{series.current} ");
        //        series.Next();

        //    }
        //    Console.WriteLine();
        //    series.Reset();
        //}

        //static void Print10Numbers(ISeries series)
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        System.Console.Write($"{series.current} ");
        //        series.Next();

        //    }
        //    Console.WriteLine();
        //    series.Reset();
        //}
        static void Main(string[] args)
        {
            #region Interface EX01
            //    MyType myType = new MyType();
            //    myType.salary = 12000;
            //    Console.WriteLine(myType.salary);
            //    myType.MyFun();

            //IMyType myType = new MyType();
            //myType.salary = 12000;
            //System.Console.WriteLine(myType.salary);
            //myType.MyFun();
            //myType.print(); 
            #endregion

            #region Interface EX02

            //SeriesByTwo seriesByTwo = new SeriesByTwo();

            //Print10Numbers(seriesByTwo);

            //SeriesByThree seriesByThree = new SeriesByThree();
            //Print10Numbers(seriesByThree);

            //SeriesByFour seriesByFour = new SeriesByFour();
            //Print10Numbers(seriesByFour);

            //Employee[] employees = new Employee[3] { 
            //    new Employee() {id=1, name = "Ahmed",age=25, salary = 12000 },
            //    new Employee() {id=2, name = "Mohamed",age=28, salary = 15000 },
            //    new Employee() {id=3, name = "Ali",age=30, salary = 10000 }
            //};
            //Array.Sort(employees);

            //foreach(Employee item in employees)
            //{
            //    System.Console.WriteLine(item);
            //}
            #endregion

            #region Interface EX03

            //Car car = new Car();
            //car.forward();
            //car.backward();

            //Imovable imovable = new Airplane();
            //imovable.forward();

            //imovable.backward();

            //Iflyable iflyable = new Airplane();
            //iflyable.forward();
            //iflyable.backward();

            #endregion

            #region Deep Copy Vs Shallow Copy

            //int[] Arr01 = { 1, 2, 3 };
            //int[] Arr02 = { 4, 5, 6 };

            //Console.WriteLine(Arr01.GetHashCode());
            //Console.WriteLine(Arr02.GetHashCode());


            //Arr02 = Arr01;

            //Console.WriteLine(Arr01.GetHashCode());
            //Console.WriteLine(Arr02.GetHashCode());


            //Arr02[0] = 100;

            //Console.WriteLine(Arr01[0]);

            //Arr02 = (int[]) Arr01.Clone();

            //Console.WriteLine(Arr01.GetHashCode());
            //Console.WriteLine(Arr02.GetHashCode());

            //Arr02[0] = 100;

            //Console.WriteLine(Arr01[0]);

            //string[] Arr01 = { "Ahmed", "Adel", "Khaled" };
            //string[] Arr02 = { "Mohamed", "Ziad", "Ali" };

            //Console.WriteLine(Arr01.GetHashCode());
            //Console.WriteLine(Arr02.GetHashCode());

            //Arr02 = Arr01;

            //Console.WriteLine(Arr01.GetHashCode());
            //Console.WriteLine(Arr02.GetHashCode());

            //Arr02[0] = "Hassan";

            //Console.WriteLine(Arr01[0]);

            //Arr02 =(string[]) Arr01.Clone();

            //Console.WriteLine(Arr01.GetHashCode());
            //Console.WriteLine(Arr02.GetHashCode());

            //Arr02[0] = "Hassan";

            //Console.WriteLine(Arr01[0]);


            //StringBuilder[] Arr01 = { new StringBuilder("Ahmed"), new StringBuilder("Adel"), new StringBuilder("Khaled") };
            //StringBuilder[] Arr02 = { new StringBuilder("Mohamed"), new StringBuilder("Ziad"), new StringBuilder("Ali") };

            //Console.WriteLine(Arr01.GetHashCode());
            //Console.WriteLine(Arr02.GetHashCode());

            //Arr02 = Arr01;

            //Console.WriteLine(Arr01.GetHashCode());
            //Console.WriteLine(Arr02.GetHashCode());

            //Arr02 = (StringBuilder[])Arr01.Clone();

            //Arr02[0].Append("Hassan");

            //Console.WriteLine(Arr02.GetHashCode());
            //Console.WriteLine(Arr01.GetHashCode());
            //Console.WriteLine(Arr01[0]);


            #endregion

            #region IClonable

            //Employee employee = new Employee() { id = 1, name = "Ahmed", age = 25, salary = 12000 };
            //Employee employee2 = new Employee() { id = 2, name = "Mohamed", age = 28, salary = 15000 };

            //Console.WriteLine(employee.GetHashCode());
            //Console.WriteLine(employee2.GetHashCode());

            //employee2 = employee;

            //Console.WriteLine(employee.GetHashCode());
            //Console.WriteLine(employee2.GetHashCode());

            //employee2.salary=5;

            //Console.WriteLine(employee.GetHashCode());
            //Console.WriteLine(employee2.GetHashCode());
            //Console.WriteLine(employee.salary);

            //employee2 = (Employee) employee.Clone();

            //Console.WriteLine(employee.GetHashCode());
            //Console.WriteLine(employee2.GetHashCode());
            //Console.WriteLine(employee);
            //Console.WriteLine(employee2);
            #endregion

            #region IComparable

            //Employee[] employees = {

            //    new Employee(){ id = 1, name = "Ahmed", age = 25, salary = 12000 },
            //    new Employee(){ id = 2,name = "Mohamed", age = 28, salary = 15000 },
            //    new Employee(){ id = 3,name="Ziad",age=23,salary=10000}
            //};


            //Array.Sort(employees);

            //Console.WriteLine(employees[0].CompareTo(employees[1]));
            //Console.WriteLine(employees[1].CompareTo(employees[2]));
            //Console.WriteLine(employees[2].CompareTo(employees[2]));

            //foreach(Employee item in employees)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region IComparer

            //Employee[] employees = {

            //    new Employee(){ id = 1, name = "Ahmed", age = 25, salary = 12000 },
            //    new Employee(){ id = 2,name = "Mohamed", age = 28, salary = 15000 },
            //    new Employee(){ id = 3,name="Ziad",age=23,salary=10000}
            //};

            //Array.Sort(employees, new EmployeeComparerSalary());

            //foreach (Employee item in employees)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
        }
    }
}
