Console.WriteLine("Enter a b1 number");
double b1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter a k1 number");
double k1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter a b2 number ");
double b2 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter a k2 number");
double k2 = int.Parse(Console.ReadLine());

double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2;

Console.WriteLine($"The point of intersection of two straight lines:\n;({x};{y})");
