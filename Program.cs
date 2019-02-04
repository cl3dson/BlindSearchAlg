using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Base;
using IA.Algoritmos;
using IA.Problemas;
using IA.Problemas.Aspirador;

namespace IA
{
    class Program
    {
        static void Main(string[] args)
        {
            ISolver solverStrategy = new SolverAspirador();
            String problem;
            Console.WriteLine("escolha um problema:");
            Console.WriteLine("1 ------------------- aspirador");
            Console.WriteLine("2 ------------------- romenia");
            problem = Console.ReadLine();

            switch (problem)
            {
                case "1":
                   solverStrategy = new SolverAspirador();
                   break;
                case "2":
                   solverStrategy = new SolverRomenia();
                   break;
            }

            try
            {
                solverStrategy.solve();
            }
            catch (SemSolucaoException e)
            {
                Console.WriteLine("nao há solucoes");
            }
        }
    }
}