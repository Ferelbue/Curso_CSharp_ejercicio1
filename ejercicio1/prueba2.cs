using System;


public class Ejercicio1
{
    public void Bienvenida()
    {
        Console.WriteLine("Introduce tu nombre:");
        var nombre = Console.ReadLine();
        Console.WriteLine("Introduce una Ciudad:");
        var ciudad = Console.ReadLine();
        Console.WriteLine("Hola " + nombre + " bienvenido a " + ciudad);
    }
}

public class Ejercicio2
{
    public int Sumar(int n1, int n2, int n3)
    {
        int numero1 = n1;
        int numero2 = n2;
        int numero3 = n3;
        int resultado = numero1 + numero2 + numero3;
        return resultado;
    }
}

public class Ejercicio3
{
    public void Suma3()
    {
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
    }
}

public class Ejercicio4
{
    public void DiaSemana()
    {
        Console.WriteLine("Introduce el dia de la semana:");
        string? dia = Console.ReadLine();
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
                Console.WriteLine("El día introducido no es válido");
                break;
        }
    }
}

public class Ejercicio5
{
    public void Precio()
    {
        Console.WriteLine("Introduce el precio del producto:");
        double precio = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Introduce el metodo de pago:");
        string? metodo = Console.ReadLine();
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
    }
}

public class Ejercicio6
{
    public void FizzBuzz()
    {
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
    }
}

public class Ejercicio7
{
    public void NumerosPares()
    {
        int[] array = new int[100];

        for (int i = 0; i < 100; i++)
        {
            if (i % 2 == 0)
            {
                array[i] = i;
            }
        }

        for (int i = 0; i < 100; i++)
        {
            if (array[i] != 0)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}

public class Ejercicio8
{
    public void SumarNumerosPares()
    {
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
    }
}

public class Ejercicio9
{
    public void DevolverDiaSemana()
    {
        Console.WriteLine("Introduce un número del 1 al 7:");
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
                Console.WriteLine("El número introducido no es válido");
                break;
        }
    }
}

public class Ejercicio10
{
    public void SumaMedia()
    {
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
    }
}

public class Ejercicio11
{
    public void EsPrimo()
    {
        Console.WriteLine("Introduce un numero:");
        int numero = Convert.ToInt32(Console.ReadLine());

        int flag1 = 0;

        for (int i = 1; i <= numero; i++)
        {
            if (numero % i == 0)
            {
                flag1 ++;
            }
        }
        if (flag1 == 2)
        {
            Console.WriteLine("El numero " + numero + " es primo");
        }
        else
        {
            Console.WriteLine("El numero " + numero + " no es primo");
        }
    }
}

public class Ejercicio12
{
    public void CalcularCifrasNumero()
    {
        Console.WriteLine("Introduce un numero:");
        int numero = Convert.ToInt32(Console.ReadLine());
        var numero2 = numero.ToString().ToCharArray();
        Console.WriteLine("El numero " + numero + " tiene " + numero2.Length + " cifras");
    }
}