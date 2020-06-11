using System;
 
 public class ArrayChangeMethod
 {
     public static void Main()
     {
           int[] arrayA = new int[5] {1, 2, 3, 4, 5};
 
           ChangeArray1(arrayA);
           PrintArray(arrayA);
 
           Console.Out.WriteLine();
 
           ChangeArray2(arrayA);
           PrintArray(arrayA);
     }
 
     public static void PrintArray(int [] tempArray)
     {
           for(int count=0; count < tempArray.Length; count++)
                 Console.Out.WriteLine(tempArray[count]);
     }
 
 
     public static void ChangeArray1(int[] tempArray1)
     {
           tempArray1= new int[5] {10, 9, 8, 7, 6};
     }
 
     public static void ChangeArray2(int[] tempArray2)
     {
           tempArray2[0] = 100;
     }
 }