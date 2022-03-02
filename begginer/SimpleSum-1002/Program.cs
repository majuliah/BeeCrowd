using static System.Console;

namespace SimpleSum_1002
{
    class Program
    {
        static void Main(string[] args)
        {
            Sum soma = new Sum();
            WriteLine($"Enter with three numbers: ");
            string[] numbers = ReadLine().Split(' ');
            
            soma.Number1 = int.Parse(numbers[0]);
            soma.Number2 = int.Parse(numbers[1]);
            soma.Number3 = int.Parse(numbers[2]);

            int total = (soma.AddingNumbers(soma.Number1, soma.Number2, soma.Number3));
            WriteLine($"O resultado é: {total}");
            
        }
    }
}