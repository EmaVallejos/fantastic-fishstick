
// See https://aka.ms/new-console-template for more information
// doble comillas palabras, comillas simples un solo caracter.
// string = textos, int = numeros enteros, float = fracciones, void = booleano
int numeros1, numeros2, suma, resta, mult, div;
// Console.WriteLine("Hello, World!");
Console.Write("Ingrese el primer número: ");
numeros1 = int.Parse(Console.ReadLine());
Console.Write("Ingrese el segundo número: ");
numeros2 = int.Parse(Console.ReadLine());
Console.WriteLine("-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-");

suma = numeros1 + numeros2;
resta = numeros1 - numeros2;
mult = numeros1 * numeros2;
div = numeros1 / numeros2;
Console.WriteLine("Suma: " + suma);
Console.WriteLine("Resta: " + resta);
Console.WriteLine("Multiplicación: " + mult);
Console.WriteLine("Division: " + div);
Console.ReadKey();
