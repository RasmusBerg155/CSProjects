  /* Given two integers a and b, which can be positive or negative, find the sum of all the integers between and including 
  them and return it. If the two numbers are equal return a or b.

Note: a and b are not ordered! */
  
  public class Sum
  {
    public int GetSum(int a, int b)
        {
            int max = Math.Max(a, b);
            int min = Math.Min(a, b);
            int result = 0;
            for (int i = min; i <= max; i++)
            {
                result += i;
            }
            return result;
        }
 }