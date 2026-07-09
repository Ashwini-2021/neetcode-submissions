public class Solution {
    public int MaxProfit(int[] prices) {
         int minPrice = int.MaxValue;
        int maxprofit=0;

        foreach(int p in prices)
        {
            if(p < minPrice)
            {
                minPrice = p;
            }
            else
            {
                int profit= p-minPrice;
                maxprofit= Math.Max(maxprofit,profit);
            }
        }

        return maxprofit;
    }
}
