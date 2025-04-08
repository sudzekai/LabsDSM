namespace LabWork15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Option option = Sum;
            option += Divide;
            option += Multiplicate;
            option += Subtract;
            option.Invoke(10, 2);
        }

        delegate void Option(int firstNumber, int secondNumber);

        static void Sum(int firstNumber, int secondNumber)
        {
            Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
        }
        static void Divide(int firstNumber, int secondNumber)
        {
            Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
        }
        static void Multiplicate(int firstNumber, int secondNumber)
        {
            Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
        }
        static void Subtract(int firstNumber, int secondNumber)
        {
            Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
        }
    }
}
