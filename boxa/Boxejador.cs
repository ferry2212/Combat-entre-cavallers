using System;
class Boxejador
{
    public string Nom { get; set; }
    public int Resistencia { get; set; }

    public Boxejador(string nom, int resistencia)
    {
        Nom = nom;
        Resistencia = resistencia;
    }

    public string Colpejar()
    {
        string[] zones = { "cap", "panxa", "esquerra", "dreta" };
        Random random = new Random();
        return zones[random.Next(zones.Length)];
    }

    public string[] Protegir()
    {
        string[] zones = { "cap", "panxa", "esquerra", "dreta" };
        Random random = new Random();
        string[] protegides = new string[3];
        int index = 0;

        while (index < 3)
        {
            string zona = zones[random.Next(zones.Length)];
            if (Array.IndexOf(protegides, zona) == -1)
            {
                protegides[index] = zona;
                index++;
            }
        }

        return protegides;
    }
}