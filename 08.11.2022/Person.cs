
namespace _08._11._2022
{
    public class person
    {
        public int Debt { get; set; }
        private int Money { get; set; }

        public person()
        {
            Debt = new Random().Next(10000, 50000);
            Money = new Random().Next(0, Debt);
            Console.WriteLine( $"your debt:{Debt}");
            GetMoney();
        }

       private void GetMoney()
        {
            Theft();
            SellKidney();
            
        }

        private void Theft()
        {
            int rand = new Random().Next(0, 100);
            Money += rand;
            Console.WriteLine($"Stole {rand} money");
        }

        private void SellKidney()
        {
            int rand = new Random().Next(10000, 100000);
            Money += rand;
            Console.WriteLine($"Sold kidney for {rand}");
        }

      
    }
}
