using System;

namespace Program
{
    class Program
    {
        public static void Main (string [] args)
        {
            IVivencia habita;
            Console.Clear();

            Console.WriteLine("HABITAS ANIMALES");
            Console.WriteLine("Cual habita desea conocer? " +
            "\n 1: Cuadrupedo " +
            "\n 2: Pez " +
            "\n 3: Ave ");
            int opc = int.Parse(Console.ReadLine());

            habita = Fabrica.GetHabita(opc);
            habita.Habita();
            Console.ReadKey();
            Main(args);
        }
    }
}
