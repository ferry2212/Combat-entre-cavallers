using System;
class Combat
{
    private Boxejador _boxejador1;
    private Boxejador _boxejador2;

    public Combat(Boxejador boxejador1, Boxejador boxejador2)
    {
        _boxejador1 = boxejador1;
        _boxejador2 = boxejador2;
    }

    // Mètode per iniciar el combat
    public void Iniciar()
    {
        Console.WriteLine($"\nCombat entre {_boxejador1.Nom} i {_boxejador2.Nom}");
        Console.WriteLine("-------------------------------------");

        Random random = new Random();
        bool torn = true;

        while (_boxejador1.Resistencia > 0 && _boxejador2.Resistencia > 0)
        {
            Boxejador atacant = torn ? _boxejador1 : _boxejador2;
            Boxejador defensor = torn ? _boxejador2 : _boxejador1;

            string cop = atacant.Colpejar();
            string[] protegides = defensor.Protegir();

            if (Array.IndexOf(protegides, cop) != -1)
            {
                Console.WriteLine($"— {atacant.Nom} pica: Protegit");
            }
            else
            {
                Console.WriteLine($"— {atacant.Nom} pica: Cop a {cop}");
                defensor.Resistencia--; 
            }

            torn = !torn;
        }

        if (_boxejador1.Resistencia <= 0)
        {
            Console.WriteLine($"\n{_boxejador1.Nom} CAU!");
            Console.WriteLine($"GUANYADOR: {_boxejador2.Nom}");
        }
        else
        {
            Console.WriteLine($"\n{_boxejador2.Nom} CAU!");
            Console.WriteLine($"GUANYADOR: {_boxejador1.Nom}");
        }
    }
}