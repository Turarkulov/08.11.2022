
namespace _08._11._2022
{
    public class Collector
    {
        public const int Cap = 5000;

        public void BreakKnees(person person)
        {
            if (person.Debt > Cap)
            {
                Console.WriteLine("The debt is too big, we will break your knees");
            }
        }
        
        public Collector(person person)
        {
            BreakKnees(person);
        }

    }
}
