using System;

public static class Kata
{
  public static int DescendingOrder(int num)
  {
    // Bust a move right here
    char[] arr = num.ToString().ToCharArray();
    Array.Sort(arr);
    Array.Reverse(arr);
    
    return Convert.ToInt32(new string(arr));
  }
}
