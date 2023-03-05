//HomeWork

//#1


// int takeSecondDigit(int number)
// {
//     if(number >= 100 && number < 1000)
//     {
//         number = (number - number / 100 * 100) / 10;
//         return (number);
//     }
//     else 
//     {
//         return (-1);
//     }
// }
// Console.WriteLine("Input the number:");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(takeSecondDigit(number));


//# 2

// int takeThirdDigit(int number)
// {
//     if (number > 99)
//     {
//     while(number > 999)
//     {
//         number = number / 100;
        
//     }
//     return (number%10);
//     }
//     else
//     {
//          return (-1);
//     }

// }
// Console.WriteLine(takeThirdDigit(78345));

//# 3

// void weekend(int day)
// {
//      if (day < 1 || day >7)
//      {
//         Console.WriteLine("Error");
//      }

//      else if (day <= 5)
//     {
//         Console.WriteLine("Net");
        
//     }
//     else
//     {
//         Console.WriteLine("Da");
//     }
// }
// Console.WriteLine("Input the number of week day");
// int day = Convert.ToInt32(Console.ReadLine());
// weekend(day);
