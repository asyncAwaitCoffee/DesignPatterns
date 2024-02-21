using Builder.Sandwiches;

namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * OPTION #1
             */
            Chief chief = new Chief();

            OriginalSandwichBuilder osb = new OriginalSandwichBuilder();
            Sandwich original = chief.MakeSandwich(osb);

            Console.WriteLine(original);

            ChilliSandwichBuilder csb = new ChilliSandwichBuilder();
            Sandwich chilli = chief.MakeSandwich(csb);

            Console.WriteLine(chilli);

            /*
             * OPTION #2
             */

            Sandwich super = SuperSandwichBuilder
                .CreateSanwich()
                .AddBread("Baguette")
                .AddHam("Breakfast Ham")
                .AddSouce("Chipotle");

            Console.WriteLine(super);
        }
    }
}
