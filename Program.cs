﻿using System;
using System.Diagnostics.Tracing;
using System.Security.Cryptography.X509Certificates;

namespace ExercicioDeFixação08 {
    class Program {
        static void Main(string[] args) {

            int x = int.Parse(Console.ReadLine());
            string dia;

            if (x == 1) { 
                dia = "Domingo";
            }
            else if (x == 2) {
                dia = "Segunda";
            }
            else if (x == 3) {
                dia = "Terça";
            }
            else if (x == 4) {
                dia = "Quarta";
            }
            else if (x == 5) {
                dia = "Quinta";
            }
            else if (x == 6) {
                dia = "Sexta";
            }
            else if (x == 7) {
                dia = "Sábado";
            }
            else {
                dia = "Valor inválido";
            }

            Console.WriteLine("Dia da semana: " + dia);
            Console.ReadLine();
        }
    }
}
