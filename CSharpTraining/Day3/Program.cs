using StaticFolder;

namespace Day3;

public class Program
{
    public static void Main(string[] args)
    {
        //Help help = new Help();
        //Help help1 = new Help();
        //help1.AnyInt = 20;
        //int getFive = Helper.five;
        //Console.WriteLine(help.AnyInt + " I belong in help");
        //Console.WriteLine(help1.AnyInt + " I belong in help1");
        //Console.WriteLine(Help.PI);
        //Help.PI = 15;
        //Console.WriteLine(Help.PI);
        //Console.WriteLine(Help.PI.IsEven());


        double d = 2.1d / 0;
        double dd = 2.1123d / 0;
        double nd = -2.32d / 0;

        Console.WriteLine(d + "     " + nd);
        Console.WriteLine(d == dd);

        //value types declared as a variable in a method are stored in a stack
        //value types declared as a parameter in a method are stored in a stack
        //value types that are declared as a memeber of a class stored in the heap
        //Value types Can be stored in the stack, can also be stored in the heap
        //Reference types are stored in the heap.

        string b = "sadfasfd";
        b = "ajsdkfldsjfd";

        string i = "";
        string j = "";

        Comparer<string> comparer = new Comparer<string>();
        Console.WriteLine( comparer.CheckEquality(i, j));

        Student[] stud = new Student[3];


        List<Student> studList = new List<Student>();
        studList.Add(new Student() { Id = 1, Name = "Billy Jean"});
    }
}