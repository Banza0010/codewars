namespace Solution
{
  using System;


  class Kata
    {
      public static int binaryArrayToNumber(int[] BinaryArray)
        {
          //Code here
          int solution = 0;
          Array.Reverse(BinaryArray);
          
          for(int i = 0; i < BinaryArray.Length; i++)
          {
            solution = solution + (int)(Math.Pow(2,i) * BinaryArray[i]);
          }
          
          return(solution);
        }
    }
}
