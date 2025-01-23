using System.ComponentModel.Design;

namespace OOP04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01

            #region Q1

            //Calculator calcu = new Calculator();
            //Console.WriteLine("Sum of 2 integers: " + calcu.Add(3, 7));
            //Console.WriteLine("Sum of 3 integers: " + calcu.Add(3, 7, 5));
            //Console.WriteLine("Sum of 2 doubles: " + calcu.Add(3.5, 7.5));

            #endregion

            #region Q2

            //Rectangle rectangle1 = new Rectangle();
            //Console.WriteLine($"Rectangle 1 , {rectangle1}"); 
            //Rectangle rectangle2 = new Rectangle(2,4);
            //Console.WriteLine($"Rectangle 2 , {rectangle2}");
            //Rectangle rectangle3 = new Rectangle(5);
            //Console.WriteLine($"Rectangle 3 , {rectangle3}");

            #endregion

            #region Q3

            ComplexNumber c1 = new ComplexNumber(2, 4);
            ComplexNumber c2 = new ComplexNumber(3, 5);
           

            ComplexNumber sum = c1 + c2;
            Console.WriteLine($"Sum: {sum}");

            ComplexNumber difference = c1 - c2;
            Console.WriteLine($"Difference: {difference}");

            //c1++;
            //Console.WriteLine($" C1++ : {c1}");

            //c2--;
            //Console.WriteLine($" C1-- : {c2}");

            if(c1>c2)
                Console.WriteLine("c1 is Greater than is C2 ");
            else if (c1 < c2)
                Console.WriteLine("c1 is Less than is C2");
            else
                Console.WriteLine("c1 is Equal C2");
                        



            #endregion

            #region Q4
            //Employee employee = new Employee();
            //employee.Work();

            //Manager manager = new Manager();
            //manager.Work();

            #endregion

            #region Q5

            //BaseClass baseObj = new BaseClass();
            //baseObj.DisplayMessage(); 

            //DerivedClass1 derivedObj1 = new DerivedClass1();
            //derivedObj1.DisplayMessage(); 

            //DerivedClass2 derivedObj2 = new DerivedClass2();
            //derivedObj2.DisplayMessage(); 

            #endregion

            #endregion

            #region Part 02

            #region 1.2
            //Duration duration1 = new Duration(1, 30, 45);
            //Duration duration2 = new Duration(1, 30, 45);
            //Duration duration3 = new Duration(2, 15, 0);

            //Console.WriteLine(duration1);
            //Console.WriteLine(duration1.Equals(duration2));
            //Console.WriteLine(duration1.Equals(duration3));

            //Console.WriteLine($"Hash Code of duration1: {duration1.GetHashCode()}");
            //Console.WriteLine($"Hash Code of duration2: {duration2.GetHashCode()}");
            //Console.WriteLine($"Hash Code of duration3: {duration3.GetHashCode()}");
            #endregion

            #region 3

            /* Duration D1 = new Duration(1, 10, 15);
             Console.WriteLine(D1.ToString());*/

            //Duration D1 = new Duration(3600);
            //Console.WriteLine(D1.ToString()); 

            //Duration D2 = new Duration(7800);
            //Console.WriteLine(D2.ToString()); 

            //Duration D3 = new Duration(666);
            //Console.WriteLine(D3.ToString());

            #endregion

            #region 4
            //Duration D1 = new Duration(1, 10, 15);
            //Duration D2 = new Duration(2, 10, 0);
            //Duration D3;

            //D3 = D1 + D2;
            //Console.WriteLine(D3);

            //D3 = D1 + 7800;
            //Console.WriteLine(D3);

            //D3 = 666 + D3;
            //Console.WriteLine(D3);

            //D3 = ++D1;
            //Console.WriteLine(D3);

            //D3 = --D2;
            //Console.WriteLine(D3);

            //D1 = D1 - D2;
            //Console.WriteLine(D1);

            //if (D1 > D2)
            //    Console.WriteLine("D1 is greater than D2");
            //else
            //    Console.WriteLine("D1 is not greater than D2");

            //if (D1 < D2)
            //    Console.WriteLine("D1 is less than or equal to D2");


            //DateTime obj = (DateTime)D1;
            //Console.WriteLine(obj);
            #endregion

            #endregion

        }
    }
}
