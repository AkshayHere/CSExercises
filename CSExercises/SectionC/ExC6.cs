using System;

namespace CSExercises
{
    //Electrifying Electronics Pte Ltd. manufactures 
    //three audio-visual electronic products named 
    //as TV, DVD, and MP3.  The table below gives 
    //the unit price for each of these products:

    //PRODUCT   PRICE
    //TV	    $900
    //DVD	    $500
    //MP3	    $700

    //Retailers make orders for these products. 
    //Each order will have the product code and quantity 
    //(only one product in an order).  The company has a policy 
    //that discount of 10% is given when the order amount exceeds 
    //$5000 and 15% discount when the order amount exceeds $10000.  
    //These discounts apply to TV and DVD only and no discount is provided for MP3.

    //Write a program that would prompt the user successively 
    //the three product codes viz., TV, DVD, MP3 and after each prompt, 
    //the user enters the order quantity for that product.  
    //Then apply the price computations.  (Obviously, if the user does not 
    //wish to order the item prompted he/she would enter a zero for the order quantity).

    public class ExC6
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE - get user input, call the function and return the discounted price
            string code = null;
            int tvNo = 0, DVDNo = 0, mp3No = 0;

            do
            {
                Console.WriteLine("Enter product code \n 1. TV \n 2. DVD \n 3. MP3 \n 4. Exit");
                code = Console.ReadLine();
                
                switch (code)
                {
                    case "1":
                        Console.WriteLine("Enter the no of TVs");
                        tvNo = Convert.ToInt32(Console.ReadLine());
                        break;
                    case "2":
                        Console.WriteLine("Enter the no of DVDs");
                        DVDNo = Convert.ToInt32(Console.ReadLine());
                        break;
                    case "3":
                        Console.WriteLine("Enter the no of Mp3s");
                        mp3No = Convert.ToInt32(Console.ReadLine());
                        break;
                    case "4":
                        code = null;
                        break;
                }
            } while (code != null);

            double totalObtained = CalculateTotalPrice(tvNo, DVDNo, mp3No);
            Console.WriteLine("Your order is as follows \n TVs:"+ tvNo +" \n DVDs: "+ DVDNo+" \n Mp3s: "+ mp3No+"");
            Console.WriteLine("Total cost after discount is "+ totalObtained);

            Console.ReadLine();
        }

        public static double CalculateTotalPrice(int tvQty, int dvdQty, int mp3Qty)
        {
            //YOUR CODE HERE

            int tvTotal = 900 * tvQty;
            int dvdTotal = 500 * dvdQty;
            int mp3Total = 700 * mp3Qty;
            int discount = 0;

            int total = tvTotal + dvdTotal + mp3Total;

            if ((tvTotal + dvdTotal) >= 5000)
            {
                discount = (10 * total) / 100;
            }
            else if ((tvTotal + dvdTotal) >= 10000)
            {
                discount = (15 * total) / 100;
            }

            double revisedTotal = total - discount;

            return revisedTotal;

        }
    }
}