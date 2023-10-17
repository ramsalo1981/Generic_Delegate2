namespace CAGeneric_Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Action delegete dont return value
            //Action<in T> : in T <=> mean dont return value just take a parameter(string name)
            Action<string> action = Print;
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            action(name);

            //Func delegete take aparameters and return value
            //func<in T, out T> : in T, out T=> mean (out) return value (out result n1+n2)
            //                                      (in) take a parameter(int n1 ,int n2)
            Func<int, int, int> addD = Add;
            Console.Write("Enter number1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter number2: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(addD(num1,num2));

            //use with boolian
            Predicate<int> predicate = IsEven;
            Console.WriteLine(predicate(3));

        }

        static void Print(string name) => Console.WriteLine(name);
        static int Add(int n1, int n2) => n1 + n2;
        static bool IsEven(int n) => n % 2 == 0;
    }
}