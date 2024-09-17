//Escriba un programa en C#, que simule el tirar dos dados. El programa deberá utilizar la función
//rand para tirar el primer dado, y después volverá a utilizar la función rand para tirar el segundo.
//suma de los valores deberá entonces ser calculada. 

using System;
public class SimulacionDados
{
   public static void Main()
    {
        Random aleatorio = new Random();
        int[] sumas = new int[13]; // Arreglo para contar las sumas de 2 a 12

        // Tirar los dados 36,000 veces
        for (int i = 0; i < 36000; i++)
        {
            int dado1 = aleatorio.Next(1, 7); // Tirar el primer dado (1-6)
            int dado2 = aleatorio.Next(1, 7); // Tirar el segundo dado (1-6)
            int suma = dado1 + dado2; // Calcular la suma
            sumas[suma]++; // Incrementar el contador de la suma correspondiente
        }

        // Imprime los resultados en formato tabular
        Console.WriteLine("Suma\tFrecuencia");
        for (int i = 2; i < sumas.Length; i++)
        {
            Console.WriteLine($"{i}\t{sumas[i]}");
        }

        // Verifica si los totales son razonables
        Console.WriteLine("\nVerificación de totales razonables:");
        Console.WriteLine($"Frecuencia esperada para la suma 7: {36000 / 6}");
        Console.WriteLine($"Frecuencia obtenida para la suma 7: {sumas[7]}");
    }

}

