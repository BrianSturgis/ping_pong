using System;
using System.Collections.Generic;

class Pong
{
    static void Main()
    {
        Console.WriteLine("enter a number");
        int number = int.Parse(Console.ReadLine());
        
        List<int> numberRange = new List<int> {};

        //Add numbers to our number range list

        for (int index = 0; index < number; index++){
          numberRange.Add(index + 1);
        }

        //Loop through list and replace specified numbers
        for(int index = 0; index < numberRange.Count; index++){
          if(numberRange[index] % 3 == 0 &&  numberRange[index] % 5 == 0){
            Console.WriteLine("Ping-Pong");
          } else if( numberRange[index] % 5 == 0){
            Console.WriteLine("Pong");
          } else if(numberRange[index] % 3 == 0){
            Console.WriteLine("Ping");
          } else {
            Console.WriteLine(numberRange[index]);
          }
        }

    

    }




  }

