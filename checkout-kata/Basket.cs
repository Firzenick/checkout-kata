using System;

namespace checkout_kata
{
    public class Basket
    {
        List<string> itemScan = new List<String>();
        List<int> nrScan = new List<Int32>();



        public void Scan(string item, int nr) {
            throw new NotImplementedException("TODO");
            /*TODO: Enter objects into basket [list]
             *      Check amount of object XX entered
             */
            itemScan.Add(item);
            nrScan.Add(nr);
        }
        public void Total()
        {
            throw new NotImplementedException("TODO");
            /*TODO: On checkout, sum prices from baskets
             * 
             * Divide by amount in discount and multiply by discount
                    Modulo by amount in discount and multiply by normal
                    Add sum
             * 
             * 
             */
            StreamReader reader = new StreamReader(File.OpenRead(@"C:\Users\Emin\Desktop\example.csv"));
            List<string> listProd = new List<String>();
            List<string> listPrice = new List<String>();
            List<string> listDiscountNr = new List<String>();
            List<string> listDiscountPrice = new List<String>();
            string discount;
            string[] values, dicountText;
            //read the list of product identifiers, prices and discounts as per the example table
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (!String.IsNullOrWhiteSpace(line))
                {
                    values = line.Split(',');
                    listProd.Add(values[0]);
                    listPrice.Add(values[1]);
                    //if there is a discount, save the string, else save 1 for normal price as if it was the discount
                    if (values[2].size != null) { discount = values[2]; } else { discount = "1 for " + values[1]; }
                    discountText = discount.Split(' ');
                    listDiscountNr.Add(ToInt32(discountText[0]));
                    listDiscountPrice.Add(ToInt32(discountText[2]));
                }
            }
            int priceSum = 0;
            int mod, div, itemIndex;
            //implement index finder function... or rework to not need to find index
            //loop through itemScan for each product and add all instances per product? seems highly inefficient at this time
            foreach(string item in itemScan)
            {
                //add discount times division by discount
                priceSum += listDiscountPrice[itemIndex] * (nrScan[x] / listDiscountNr);
                priceSum += listPrice[itemIndex] * (nrScan[x] % listDiscountNr);
            }


        }
    }

}
