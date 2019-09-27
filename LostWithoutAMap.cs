public class Kata
{
  public static int[] Maps(int[] x)
  {
    var myArr = new int[x.Length]; //new array to store values
    for(int c = 0; c < x.Length; c++) //iterate thru each item n double each number in the x array
    {
      myArr[c] = x[c]*2;
    }
    return myArr; //return your new array 
  }
}
