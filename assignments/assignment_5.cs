Check to see if a string has the same amount of 'x's and 'o's. The method must return a boolean and be case insensitive. The string can contain any char.

Examples input/output:


public static class Kata 
{
  public static bool XO (string input)
  {
    string low = input.ToLower();
    return low.Count(x => x == 'x') == low.Count(x => x == 'o');
  }
}