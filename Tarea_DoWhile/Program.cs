//Ejercicio 1
Console.WriteLine("Ejercicio 1");
int i = 1;
do
{
    Console.WriteLine(i);
    i++;
} while (i <= 5);
Console.WriteLine();

//Ejercicio 2
Console.WriteLine("Ejercicio 2");
int i2 = 1;
do
{
    Console.WriteLine(i2);
    i2++;
} while (i2 <= 10);
Console.WriteLine();

//Ejercicio 3
Console.WriteLine("Ejercicio 3");
int i3 = 10;
do
{
    Console.WriteLine(i3);
    i3--;
} while (i3 >= 1);
Console.WriteLine();

//Ejercicio 4
Console.WriteLine("Ejercicio 4");
int i4 = 2;
do
{
    Console.WriteLine(i4);
    i4+=2;
} while (i4 <= 20);
Console.WriteLine();

//Ejercicio 5
Console.WriteLine("Ejercicio 5");
int i5 = 1;
do
{
    Console.WriteLine(i5);
    i5 += 2;
} while (i5 <= 15);
Console.WriteLine();

//Ejercicio 6
Console.WriteLine("Ejercicio 6");
int i6 = 1;
do
{
    Console.WriteLine(i6 + " = " + (i6 * i6));
    i6++;
} while (i6 <= 10);
Console.WriteLine();

//Ejercicio 7
Console.WriteLine("Ejercicio 7");
int i7 = 1;
int suma = 0;
do
{
    suma += i7;
    i7++;
}
while (i7 <= 10);
Console.WriteLine("La suma es: " + suma);
Console.WriteLine();

//Ejercicio 8
Console.WriteLine("Ejercicio 8");
int i8 = 1;
do
{
    Console.WriteLine(i8 + " X 5 = " + (i8 * 5));
    i8++;
} while (i8 <= 10);
Console.WriteLine();

//Ejercicio 9
Console.WriteLine("Ejercicio 9");
int i9 = 1;
do
{
    if (i9 % 2 == 0)
    {
        Console.WriteLine(i9 + " es par");
    }
    else
    {
        Console.WriteLine(i9 + " es impar");
    }
    i9++;
}
while (i9 <= 20);
Console.WriteLine();

//Ejercicio 10
Console.WriteLine("Ejercicio 10");
int i10 = 1;
int cantidad = 0;
do
{
    i10++;
    cantidad++;
} while (i10 <= 50);
Console.WriteLine("Cantidad: " + cantidad);
Console.WriteLine();

//Ejercicio 11
Console.WriteLine("Ejercicio 11");
int i11 = 1;
int total = 0;
do
{
    Console.WriteLine($"Ingrese número {i11}: ");
    int numero = int.Parse(Console.ReadLine());
    total += numero;
    i11++;
} while (i11 <= 5);
Console.WriteLine("Total: " + total);
Console.WriteLine();

//Ejercicio 12
Console.WriteLine("Ejercicio 12");
int numero1;
int suma1 = 0;
do
{
    Console.Write("Ingrese un número (0 para terminar): ");
    numero1 = int.Parse(Console.ReadLine());

    suma1 += numero1;

} while (numero1 != 0);
Console.WriteLine("La suma total es: " + suma1);
Console.WriteLine();