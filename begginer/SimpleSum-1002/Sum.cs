namespace SimpleSum_1002
{
    public class Sum
    {
        public int Number1, Number2, Number3;

        public Sum()
        {
        }

        public int AddingNumbers(int number1, int number2, int number3)
        {
            this.Number1 = number1;
            this.Number2 = number2;
            this.Number3 = number3;
            int sum = Number1 + Number2 + Number3;
            return sum;
        }
        
    }
}