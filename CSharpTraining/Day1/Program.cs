
//string str = "Hello World";
//// See https://aka.ms/new-console-template for more information
//Console.WriteLine(str);
//int Num = 5;

//double dub = 3.14d;
//float flo = 3.14f;
//decimal deciMal = 3.14m;
//bool flag = true; //or false

//float inttoFlo = Num;
//int floToInt = (int)inttoFlo;

//string strWithInt = Num + "";
//int strtoInt = Convert.ToInt32(strWithInt);


//Console.WriteLine(str + " This is string concatination");
//Console.WriteLine($"We can easily reference a variabel with str {str + strWithInt} like that. we can also put some slight logic" +
//    $"in the brackets like this { 1 + 5 }");

//Specifying size when new int
using Day1;
using System.Collections;

Menu m = new Menu();
m.Run();
//int[] array1 = new int[3];
//array1[0] = 100;
//array1[1] = 1000;
//array1[2] = 10000;

//int[] array2 = new int[3] {100, 1000, 10000};
//int[] array3 = new int[] { 100, 1000, 10000 };
//int[] array4 = { 100, 1000, 10000 };

//int[] array5 = array4;

//array4[0] = 100000;
//Console.WriteLine(array5[0]);

//// new creates an instance of an object 

////int[,] array6 = new int[2, 3];
////array6[2, 0] = 100;
//int[,] array7 = new int[2,3]{ { 1, 2, 3 }, {4, 5, 6 } };

////Jagged Arrays: multiarray that does not need to have the same length
//int[][] jagged = new int[3][];
//jagged[0] = new int[4]{ 1, 2, 3, 4};
//jagged[1] = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8,9 ,10 };


//List<List<List<int>>> ListInt = new List<List<List<int>>>();
////Dictionary
////ArrayList
//int[] arra = new int[]{ 1,2,3,4,5};


////var i = 0;
////var another = "string";
////var anotherCollection = new List<int>();

////foreach(var t in arra)
////{

////}

////i = 1000;
////i = "string";

////dynamic data = 10;
////data = "string";
////dynamic qwerty;

//int Monday = 1;
//int Tuesday = 2; // ....
//int a = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine((int)DayOfWeek.Monday == a);

//[Access modifier] "Static" [return-type] MethodName (Formal parameters)

int a = 10;
int b = 20;
Parameters p = new Parameters();
p.PassByValue(a, b);
Console.WriteLine($" a = {a}, b = {b} sum = {a + b} Outside the funciton");
Console.WriteLine("-----------------------------------------------------");
p.PassByRef(ref a, ref b);
Console.WriteLine($" a = {a}, b = {b} sum = {a + b} Outside the funciton");
Console.WriteLine("-----------------------------------------------------");

p.AreaOfCircle(pi : 10, radius: 20);


string msg = "";
bool Result = p.Author("bob", "notpass", out msg);
Console.WriteLine($"{Result} {msg}");

Console.WriteLine(p.AddNumbers("100", 200, 300, 400, 500));

//namespace Day1;
//public class Program
//{
//    public static void Main(string[] args)
//    {
//        Program p = new Program();
//        p.AddNumbers(1, 2, 3, 4, 5)
//    }

//    public int AddNumbers(string str, params int[] arr)
//    {
//        int sum = 0;
//        foreach (var i in arr)
//        {
//            sum += i;
//        }
//        return sum;
//    }

    //SOLID Principles: Single Responcibility Principle 
    //Dry : Dont repeat yourself:  helped solved with Generics
}