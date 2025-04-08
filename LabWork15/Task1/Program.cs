namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1");
            Option option = Raise;
            Console.WriteLine(option.Invoke(10));

            option = Factorial;
            Console.WriteLine(option.Invoke(5));

            option = Module;
            Console.WriteLine(option.Invoke(-10));
            Task4();
        }

        static void Task4()
        {
            Console.WriteLine("\nTask4");
            Option[] options = [
                Raise, Factorial, Module
                ];

            foreach (Option option in options)
            {
                Console.WriteLine(option.Invoke(5)); 
            }
        }

        delegate int Option(int value);

        static int Raise(int value)
            => value * value;

        static int Factorial(int value)
        {
            if (value < 0)
                return -1;
            
            int result = 1;
            for (int i = value; i > 0; i--)
            {
                result *= i;
            }
            return result;
        }

        static int Module(int value)
            => Math.Abs(value);

    }
}
