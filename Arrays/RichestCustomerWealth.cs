
namespace Solutions.Arrays
{
    /*   1672. Richest Customer Wealth https://leetcode.com/problems/richest-customer-wealth/
         You are given an m x n integer grid accounts where accounts[i][j] is 
         the amount of money the i​​​​​​​​​​​th​​​​ customer has in the j​​​​​​​​​​​th​​​​ bank. 
         Return the wealth that the richest customer has.
         A customer's wealth is the amount of money they have in all their bank accounts.
         The richest customer is the customer that has the maximum wealth.
         */
    public class RichestCustomerWealth
    {
        public int MaximumWealth(int[][] accounts)
        {
            int max_value = 0;

            for (var i = 0; i < accounts.Length; i++)
            {
                int acum = 0;

                for (var j = 0; j < accounts[i].Length; j++)
                {
                    acum += accounts[i][j];
                }

                if (acum > max_value)
                {
                    max_value = acum;
                }

            }

            return max_value;

        }
    }
}
