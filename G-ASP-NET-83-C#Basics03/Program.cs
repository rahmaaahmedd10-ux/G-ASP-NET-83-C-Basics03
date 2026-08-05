using System;

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
            Console.WriteLine("--------------------------------------------------");
            #endregion

            #region Question 02
            // Create a 2x2 multidimensional array int[,] shelfCopies. Print shelf 1, slot 0.
            int[,] shelfCopies = {
                { 3, 5 },
                { 1, 4 }
            };
            Console.WriteLine($"Shelf 1, Slot 0 copies: {shelfCopies[1, 0]}");
            Console.WriteLine("--------------------------------------------------");
            #endregion

            #region Question 03
            // Write a method PrintWelcomeMessage that prints "Welcome to the Library!". Call it from Main.
            PrintWelcomeMessage();
            Console.WriteLine("--------------------------------------------------");
            #endregion

            #region Question 04
            // Write a method PrintBookTitle(string title) that prints "Book title: " + title. Call it with "Clean Code".
            PrintBookTitle("Clean Code");
            Console.WriteLine("--------------------------------------------------");
            #endregion

            #region Question 05
            // Write a method AddBonusPages(int pages) that adds 50 to pages. Call it with a variable int pages = 400; and print pages afterward. What do you expect to see, and why?
            int pages = 400;
            AddBonusPages(pages);
            Console.WriteLine($"Pages after AddBonusPages: {pages}");
            Console.WriteLine("--------------------------------------------------");
            #endregion

            #region Question 06
            double[] pricesQ6 = { 25.5, 40.0 };
            ApplyDiscount(pricesQ6);
            Console.WriteLine($"prices[0] after ApplyDiscount: {pricesQ6[0]}");
            Console.WriteLine("----------------------------------------------------");
            #endregion
            #region Question 07
            // Rewrite the method from question 5 as AddBonusPagesByRef(ref int pages) using ref. Call it and print pages afterward. How is the result different from question 5?
            int pagesQ7 = 400;
            AddBonusPagesByRef(ref pagesQ7);
            Console.WriteLine($"Pages after AddBonusPagesByRef: {pagesQ7}");
            Console.WriteLine("-----------------------------------------------------");
            #endregion

            #region Question 08
            // Write a method ReplaceArray(ref double[] prices) that replaces prices entirely with a new array { 10.0, 12.5, 15.0 }. Call it with your prices array and print prices.Length afterward.
            double[] pricesQ8 = { 25.5, 40.0 };
            ReplaceArray(ref pricesQ8);
            Console.WriteLine($"prices.Length after ReplaceArray: {pricesQ8.Length}");
            Console.WriteLine("----------------------------------------------------");
            #endregion
            #region Question 09
            if (TryGetPrice("Clean Code", out double foundPrice))
            {
                Console.WriteLine($"Price found: {foundPrice}");
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
            #endregion

        }

        #region Methods Definitions


        public static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Library!");
        }


        public static void PrintBookTitle(string title)
        {
            Console.WriteLine("Book title: " + title);
        }

        #endregion

        public static void AddBonusPages(int pages)
        {
            pages += 50;
        }
        public static void ApplyDiscount(double[] prices)
        {
            if (prices.Length > 0)
            {
                prices[0] -= 5;
            }
        }

        public static void AddBonusPagesByRef(ref int pages)
        {
            pages += 50;

        }
        public static void ReplaceArray(ref double[] prices)
        {
            prices = new double[] { 10.0, 12.5, 15.0 };
        }
        public static bool TryGetPrice(string title, out double price)
        {
            if (title == "Clean Code")
            {
                price = 25.5;
                return true;
            }

            price = 0;
            return false;
        }
    }
}

