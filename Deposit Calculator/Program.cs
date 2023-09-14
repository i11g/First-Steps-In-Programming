namespace Deposit_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double depositAmount=double.Parse(Console.ReadLine());
            int termsOfDeposit=int.Parse(Console.ReadLine());
            double annualInterestRate=double.Parse(Console.ReadLine());

            double finalAmount = depositAmount + termsOfDeposit * (depositAmount * annualInterestRate / 100) / 12;

            Console.WriteLine(finalAmount);

        }
    }
}