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

//Ejercicio 13
Console.WriteLine("Ejercicio 13");
int numero2;
int contador1 = 0;
do
{
    Console.Write("Ingrese un número (0 para terminar): ");
    numero2 = int.Parse(Console.ReadLine());

    if (numero2 != 0)
    {
        contador1++;
    }

} while (numero2 != 0);
Console.WriteLine("Cantidad de números ingresados: " + contador1);
Console.WriteLine();

//Ejercicio 14
Console.WriteLine("Ejercicio 14");
int numero3;
int mayor = 0;
do
{
    Console.Write("Ingrese un número (0 para terminar): ");
    numero3 = int.Parse(Console.ReadLine());

    if (numero3 > mayor)
    {
        mayor = numero3;
    }

} while (numero3 != 0);
Console.WriteLine("El número mayor ingresado fue: " + mayor);
Console.WriteLine();

//Ejercicio 15
Console.WriteLine("Ejercicio 15");
int numero4;
do
{
    Console.Write("Ingrese un número positivo: ");
    numero4 = int.Parse(Console.ReadLine());

} while (numero4 <= 0);
Console.WriteLine("Número válido ingresado: " + numero4);

//Ejercicio 16
Console.WriteLine("Ejercicio 16");
string pass;
int intentos1 = 0;
do
{
    Console.WriteLine("Ingrese contraseña: ");
    pass = Console.ReadLine();
    intentos1++;
    if (intentos1 == 3)
    {
        Console.WriteLine("Acceso bloqueado");
        break;
    }
    else if (pass != "1234")
    {
        Console.WriteLine("Contraseña incorrecta, intente de nuevo");
        Console.WriteLine("Intentos: " + intentos1);
    }
    else
    {
        Console.WriteLine("Contraseña correcta");
        Console.WriteLine("Acceso permitido");
    }

} while (pass != "1234");
Console.WriteLine("Acceso permitido");
Console.WriteLine();

//Ejercicio 17
Console.WriteLine("Ejercicio 17");
int numero5;
int contador3 = 0;
do
{
    Console.Write("Ingrese un número (0 para terminar): ");
    numero5 = int.Parse(Console.ReadLine());

    if (numero5 % 2 == 0 && numero5 != 0)
    {
        contador3++;
    }

} while (numero5 != 0);
Console.WriteLine("Cantidad de números pares: " + contador3);
Console.WriteLine();


//Ejercicio 18
Console.WriteLine("Ejercicio 18");
int opcion;

do
{
    Console.WriteLine("MENU");
    Console.WriteLine("1. Mostrar saludo");
    Console.WriteLine("2. Mostrar número aleatorio");
    Console.WriteLine("0. Salir");

    Console.Write("Elija una opción: ");
    opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.WriteLine("Hola, bienvenido al programa");
            break;

        case 2:
            Random r = new Random();
            Console.WriteLine("Número aleatorio: " + r.Next(1, 101));
            break;

        case 0:
            Console.WriteLine("Saliendo del programa...");
            break;

        default:
            Console.WriteLine("Opción no válida");
            break;
    }

} while (opcion != 0);
Console.WriteLine();

//Ejercicio 19
Console.WriteLine("Ejercicio 19");
int numero6;
int i19 = 1;
Console.Write("Ingrese un número: ");
numero6 = int.Parse(Console.ReadLine());
do
{
    Console.WriteLine(numero6 + " x " + i19 + " = " + (numero6 * i19));
    i19++;

} while (i19 <= 10);
Console.WriteLine();

//Ejercicio 20
Console.WriteLine("Ejercicio 20");