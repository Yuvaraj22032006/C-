using System;

public class Program {
    public static void Main(string[] args) {
        string text = Console.ReadLine();
        string[] arr = text.Split(',');
        // Write your code below
        int count = 0;
        for (int i = 0; i < arr.Length; i++) {
            if (arr[i].Length > 5){
                count++;
            }

            string[] newArr = new string[count];

            int newArrIndex = 0;
            for (int i = 0; i < arr.Length; i++) {
                if (arr[i].Length > 5) {
                    newArr[newArrIndex] = arr[i];
                    newArrIndex++;
                }
            }
            Console.WriteLine(string.Join(", ", newArr));
        }
    }
}
