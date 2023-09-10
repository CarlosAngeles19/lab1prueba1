using System;

class Program
{
    static void Main()
    {
        Console.Write("digite la cantidad de minutos: ");
        int minutos = int.Parse(Console.ReadLine());

        int horas = minutos / 60;//se utiliza en este contexto para calcular el residuo de la división de los minutos entre 60
        int minutosRestantes = minutos % 60;//se utiliza para calcular cuántos minutos quedan después de que se han calculado todas las horas completas.

        Console.WriteLine($"{minutos} minutos son {horas} horas y {minutosRestantes} minutos");
