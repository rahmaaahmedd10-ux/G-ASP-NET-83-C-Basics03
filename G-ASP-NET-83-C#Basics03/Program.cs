namespace G_ASP_NET_83_C_Basics03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 01
            // Create a 1D array double[] prices with values 25.5, 40.0, 33.75. Print the second price (index 1).
            double[] prices = { 25.5, 40.0, 33.75 };
            Console.WriteLine($"Second price: {prices[1]}");
            #endregion
            #region Question 02
            // Create a 2x2 multidimensional array int[,] shelfCopies. Print shelf 1, slot 0.
            int[,] shelfCopies = {
                     { 3, 5 },
                     { 1, 4 }
                         };
            Console.WriteLine($"Shelf 1, Slot 0 copies: {shelfCopies[1, 0]}");
            #endregion

        }
    }
}
