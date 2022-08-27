Console.Write("Enter a count of numbers ");
int numbers = int.Parse(Console.ReadLine());

int[] massive = new int[numbers];

   void InputNumbers(int numbers)
   {
   for (int i = 0; i < numbers; i++)
     {
      massive[i] = int.Parse(Console.ReadLine());
     }
   }


   int massive2(int[] massive)
   {
     int count = 0;
     for (int i = 0; i < massive.Length; i++)
     {
       if(massive[i] > 0 ) 
       count = count + 1; 
     }
     return count;
   }

   InputNumbers(numbers);


Console.WriteLine($"Count of numbers > 0 --- {massive2(massive)} ");