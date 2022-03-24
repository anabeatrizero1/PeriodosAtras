using System;

namespace PeriodosAtras.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
           
            PeriodoDeTempo periodosAtras = new PeriodoDeTempo();

            periodosAtras.RecebeData("23/03/2022");
            periodosAtras.TempoQuePassou();

            periodosAtras.RecebeData("22/03/2022");
            periodosAtras.TempoQuePassou();

            periodosAtras.RecebeData("17/03/2022");
            periodosAtras.TempoQuePassou();

            periodosAtras.RecebeData("17/01/2022");
            periodosAtras.TempoQuePassou();

            periodosAtras.RecebeData("21/01/2022");
            periodosAtras.TempoQuePassou();

            periodosAtras.RecebeData("24/03/2011");
            periodosAtras.TempoQuePassou();

            Console.ReadLine();
        }
    }
}
