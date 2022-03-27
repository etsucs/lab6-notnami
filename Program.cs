IsPrime();

    void IsPrime()
    {
System.Console.WriteLine("Please enter a Number.");
int Number = Int32.Parse( Console.ReadLine());
  int n = Number, a = 0;
         for (int i = 1; i <= n; i++) 
         {
            if (n % i == 0) {
               a++;
            }
         }
         if (a == 2) {
            Console.WriteLine($"{Number} is a Prime Number", n);
         } else 
         {
            Console.WriteLine($"{Number} is not a Prime Number");
         }

    }



