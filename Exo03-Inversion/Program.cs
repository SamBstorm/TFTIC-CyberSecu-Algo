int A, B;

Console.WriteLine("Veuillez indiquer la valeur de A :");
A = int.Parse(Console.ReadLine());

Console.WriteLine("Veuillez indiquer la valeur de B :");
B = int.Parse(Console.ReadLine());

A = A + B;      //A += B;
B = A - B;
A = A - B;      //A -= B;

Console.WriteLine($"Après inversion, A vaut {A}");
Console.WriteLine($"Après inversion, B vaut {B}");