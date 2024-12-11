using System;

class Programa
{
    public static int DemanarResistencia(string nom)
    {
        int resistencia;
        while (true)
        {
            Console.WriteLine($"Resistència del {nom}:");
            string entrada = Console.ReadLine();

            if (int.TryParse(entrada, out resistencia) && resistencia > 0)
            {
                return resistencia;
            }
            else
            {
                Console.WriteLine("Valor no vàlid. Si us plau, introdueix un número positiu.");
            }
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Nom del primer boxejador:");
        string nom1 = Console.ReadLine();

        int resistencia1 = DemanarResistencia(nom1);

        Console.WriteLine("Nom del segon boxejador:");
        string nom2 = Console.ReadLine();

        int resistencia2 = DemanarResistencia(nom2);

        Boxejador boxejador1 = new Boxejador(nom1, resistencia1);
        Boxejador boxejador2 = new Boxejador(nom2, resistencia2);

        Combat combat = new Combat(boxejador1, boxejador2);
        combat.Iniciar();
    }
}