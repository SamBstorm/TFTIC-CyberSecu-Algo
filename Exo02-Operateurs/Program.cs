int A, B, C, D, E;

A = 8 % 3;
B = 4 + A;
C = B * A;
D = (C - A) * B;
E = ((A + 7) * (D / A)) * 0;

//Console.WriteLine("A : " + A);
//Console.WriteLine("A : {0}", A);
Console.WriteLine($"A : {A}");
Console.WriteLine($"B : {B}");
Console.WriteLine($"C : {C}");
Console.WriteLine($"D : {D}");
Console.WriteLine($"E : {E}");