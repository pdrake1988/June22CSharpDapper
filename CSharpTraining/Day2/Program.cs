namespace Day2;
public class Program
{
    public static void Main(string[] args)
    {
        Unfinished un = new Unfinished();
        //un.Example();
        un.Add(10, 20);
        un.Add(10, 20, 30);
        un.Add("10", 20);
        un.Add(b: 10, a:"20"); // a way to manipulate parameter names for the function
        //Pricinples of OOP
        //Overloading
        
        
        //Encapsulation:
        //2 parts 
        //variables/properties + methods to a singular unit.
        // class
        Person bob = new Person(1, "bobby");
        //Person bill = new Person();

        //Constructor is a special method which shares the same name as the class
        //and does not have a return type (not even void)

        //constructors is used to create an object of the class and initialize class members
        /*If there are no constructors in the class, the compiler provides a default constructor
        default constructor does not take any input parameters
        if we create any other constructors, default will be replaced
        constructors are overloadable.
        constructors cannot be overridden
        by default, derived class constructor will make a call to the base parameterless constructor*/

        //FullTime emp = new FullTime();
        //emp.Work();

        //Employees fullAsEmp = new FullTime(); //Upcasting child to parent
        //FullTime fullBackToFull = (FullTime)fullAsEmp; //Downcasting
        //fullBackToFull.SpecialWork();

        //Selector se = new Selector();
        //Employees result = se.Deduct(fullBackToFull, 5);

        //FullTime fullResult = (FullTime)result;

        //switch (fullAsEmp)
        //{
        //    case (FullTime):
        //        Console.WriteLine("I am actually a fulltime emp");
        //        break;
        //    case (PartTime):
        //        Console.WriteLine("I am actually a parttime emp");
        //        break;
        //    default:
        //        Console.WriteLine("Just a regular employee");
        //        break;
        //}

        ////Another Use case:
        //if(result is FullTime)
        //{
        //    //we can also apply logic.
        //    Console.WriteLine("Ha. whooo FULLTIME");
        //}


        Employees empFull = new FullTime();
        Employees empPart = new PartTime();
        Employees empEmp   = new Employees();   
        empFull.Work();


        FullTime fullTime = new FullTime();
        Employees fullEmp = new FullTime();

        Console.WriteLine("-----------------------Method Hiding-------------------");
        Console.WriteLine("Child implementation");
        fullTime.SpecialWork();
        Console.WriteLine("upcasted implemention");
        fullEmp.SpecialWork();
        Console.WriteLine("-----------------------Method Overloading-------------------");
        Console.WriteLine("Child implementation");
        fullTime.Work();
        Console.WriteLine("upcasted implemention");
        fullEmp.Work();

        Shape s = new Square();

 
    }
}