using System;
using System.Linq;

public static class Kata
{
  public static string HighAndLow(string numbers)
  {
  //The fancy method
     var nums_arr = numbers.Split(' ').Select(int.Parse);
     return nums_arr.Max()+" "+nums_arr.Min();
  }
}

//another solution -- 
/*
  public static string HighAndLow(string numbers)
  {
    // Code here or
    string[] split = numbers.Split(' ').ToArray();
    int[] int_arr = Array.ConvertAll(split, Int32.Parse);
    int max = int_arr[0];
    int min = int_arr[0];
    
    foreach(int i in int_arr)
    {
      if(i > max)
      {
        max = i;
      }
    }
    
    foreach(int i in int_arr)
    {
      if(i < min)
      {
        min = i;
      }
    }
    
    string result = max.ToString() +" "+min.ToString();
    
    Console.WriteLine(max);
    Console.WriteLine(min);
    
    return result;
  }
}
*/
