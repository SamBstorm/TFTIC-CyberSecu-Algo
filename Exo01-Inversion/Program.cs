int A, B, temp;

Console.WriteLine("Veuillez indiquer une valeur pour A:");
A = int.Parse(Console.ReadLine());

Console.WriteLine("Veuillez indiquer une valeur pour B:");
B = int.Parse(Console.ReadLine());

temp = A;
A = B;
B = temp;

Console.WriteLine("Après inversion, A vaut " + A);
Console.WriteLine("Après inversion, B vaut " + B);