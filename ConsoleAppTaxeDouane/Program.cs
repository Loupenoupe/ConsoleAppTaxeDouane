namespace ConsoleAppTaxeDouane
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //commentaire     
            Console.WriteLine("Quel est le prix de l'arme en pièces d'or ?");
            decimal prix = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Votre arme vient-elle :\n\n1 - Des Forges de la capital\n2 - Ateliers des Nains des Montagnes\n3 -  Port des Contrebandiers\n4 - Terres Sacrées du Temple");
            int choix = Convert.ToInt32(Console.ReadLine());
            switch (choix)
            {
                case 1: prix = prix * 1.2m; break;
                case 2: prix = prix * 1.1m; break;
                case 3: prix = prix * 1.055m; break;
                case 4: prix = prix * 1.021m; break;
            }
            prix = Convert.ToInt32(prix);
            Console.WriteLine($"Le prix final est de {prix} ! ");
        }
    }
}
