
using System;

//ejercicio1
/*
Console.WriteLine("Introduce tu nombre:");
var nombre = Console.ReadLine();
Console.WriteLine("Introduce una Ciudad:");
var ciudad = Console.ReadLine();
Console.WriteLine("Hola " + nombre + " bienvenido a " + ciudad);
*/

//ejercicio2
/*
int numero1 = 1;
int numero2 = 2;
int numero3 = 3;
int resultado = numero1 + numero2 + numero3;
Console.WriteLine("El resultado de la suma de " + numero1 + " + " + numero2 + " + " + numero3 + " es " + resultado); 
*/

//ejercicio3
/*
Console.WriteLine("Introduce un número:");
int numero1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Introduce otro número:");
int numero2 = Convert.ToInt32(Console.ReadLine());
int resultado = numero1 + numero2;
Console.WriteLine("El resultado de la suma de " + numero1 + " + " + numero2 + " es " + resultado);

if (numero1 > numero2) 
{
    Console.WriteLine("El número " + numero1 + " es mayor que " + numero2);
}
else if (numero1 < numero2)
{
    Console.WriteLine("El número " + numero2 + " es mayor que " + numero1);
}
else
{
    Console.WriteLine("Los números son iguales");
}
*/

//ejercicio4
/*
Console.WriteLine("Introduce el dia de la semana:");
string dia = Console.ReadLine();
switch (dia)
{
    case "lunes":
    case "martes":
    case "miercoles":
    case "jueves":
    case "viernes":
        Console.WriteLine("Hoy es entre semana");
        break;

    case "sabado":
    case "domingo":
        Console.WriteLine("Hoy es fin de semana");
        break;

    default:
        Console.WriteLine("Introduce un día valido");
        break;
}
*/

//ejercicio5
/*
Console.WriteLine("Introduce el precio del producto:");
    double precio = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Introduce el metodo de pago:");
    string metodo = Console.ReadLine();
    if (metodo == "efectivo")
    {
        Console.WriteLine("El precio del producto es " + precio + " y el metodo de pago es " + metodo + " el precio final es " + precio);
    }
    else if (metodo == "tarjeta")
    {
        double precioFinal = precio + (precio * 0.16);
        Console.WriteLine("El precio del producto es " + precio + " y el metodo de pago es " + metodo + " el precio final es " + precioFinal);
    }
    else
    {
        Console.WriteLine("El metodo de pago no es valido");
    }
*/

//ejercicio6
/*
for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else
    {
        Console.WriteLine(i);
    }
}
*/

//ejercicio7
/*
int[] array = new int[100];

for (int i = 0; i < 100; i++)
{
    if (i % 2 == 0)
    {
        array[i] = i;
    }

}
foreach (int i in array)
    {
        if (i != 0)
        {
            Console.WriteLine(i);
        }
    }
*/

//ejercicio8
/*
int[] array = new int[10];
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Introduce un numero:");
    int numero = Convert.ToInt32(Console.ReadLine());
    array[i] = numero;
}

int suma = 0;
int resta = 0;

foreach (int i in array)
{ 
    if (i % 2 == 0)
    {
        suma += i;
    }
    else
    {
        resta -= i;
    }
}
Console.WriteLine("La suma de los numeros pares es " + suma);
Console.WriteLine("La resta de los numeros impares es " + resta);
Console.ReadLine();
*/

//ejercicio9
/*
Console.WriteLine("Introduce un numero del 1 al 7");
    int dia = Convert.ToInt32(Console.ReadLine());
switch (dia)
    {
    case 1:
        Console.WriteLine("Lunes");
        break;
    case 2:
        Console.WriteLine("Martes");
        break;
    case 3:
        Console.WriteLine("Miercoles");
        break;
    case 4:
        Console.WriteLine("Jueves");
        break;
    case 5:
        Console.WriteLine("Viernes");
        break;
    case 6:
        Console.WriteLine("Sabado");
        break;
    case 7:
        Console.WriteLine("Domingo");
        break;
    default:
        Console.WriteLine("Introduce un numero valido");
        break;
}
*/

//ejercicio10
/*
Console.WriteLine("Introduce un numero del 1 al 1000:");
int numero = Convert.ToInt32(Console.ReadLine());
int resultadoSuma = 0;
int resutladoMedia = 0;

for (int i = 1; i <= numero; i++)
{
    resultadoSuma += i;
}
resutladoMedia = resultadoSuma / numero;
Console.WriteLine("La suma de los numeros del 1 al " + numero + " es " + resultadoSuma);
Console.WriteLine("La media de los numeros del 1 al " + numero + " es " + resutladoMedia);
*/

//ejercicio11
Console.WriteLine("Introduce un numero:");
int numero = Convert.ToInt32(Console.ReadLine());

bool flag1 = false;
bool flag2 = false;

for (int i = 1; i <= numero; i++)
{
    if (numero % i == 0)
    {
        flag1 = true;
    }
    if 
}