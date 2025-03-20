using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static string projectDirectory = AppDomain.CurrentDomain.BaseDirectory; // Répertoire du projet
    static string filePath = Path.Combine(projectDirectory, "fnumero.txt");
    static string clientsFilePath = Path.Combine(projectDirectory, "clients.txt");

    static Dictionary<string, int> ticketNumbers = new Dictionary<string, int>
    {
        { "V", 0 },
        { "R", 0 },
        { "I", 0 }
    };
    static List<string> clients = new List<string>();

    static void Main()
    {
        LoadTicketNumbers();
        Console.WriteLine($" Fichier des numéros : {filePath}");
        Console.WriteLine($" Fichier des clients : {clientsFilePath}");

        bool continuer = true;

        while (continuer)
        {
            Console.Clear();
            Console.WriteLine("=== 🏦 Bienvenue à la banque 🏦 ===");
            Console.WriteLine("1. Versement");
            Console.WriteLine("2. Retrait");
            Console.WriteLine("3. Informations");
            Console.WriteLine("4. Quitter");
            Console.Write("Votre choix : ");
            string choix = Console.ReadLine();

            if (choix == "4")
            {
                Console.WriteLine("Merci d'avoir utilisé notre service !");
                break;
            }

            string typeOperation = choix switch
            {
                "1" => "V",
                "2" => "R",
                "3" => "I",
                _ => null
            };

            if (typeOperation == null)
            {
                Console.WriteLine(" Choix invalide. Veuillez réessayer.");
                continue;
            }

            Console.Write("Entrez votre numéro de compte : ");
            string numCompte = Console.ReadLine();
            Console.Write("Entrez votre nom : ");
            string nom = Console.ReadLine();
            Console.Write("Entrez votre prénom : ");
            string prenom = Console.ReadLine();

            ticketNumbers[typeOperation]++;
            string ticket = $"{typeOperation}-{ticketNumbers[typeOperation]}";
            clients.Add($"{nom} {prenom} - Compte: {numCompte} - Ticket: {ticket}");

            Console.WriteLine($"Votre numéro est {ticket}. Il y a {ticketNumbers[typeOperation] - 1} personne(s) avant vous.");
            SaveTicketNumbers();

            Console.Write("Voulez-vous prendre un autre numéro ? (O/N) : ");
            continuer = Console.ReadLine()?.Trim().ToUpper() == "O";
        }

        Console.WriteLine("\nListe des clients enregistrés :");
        foreach (var client in clients)
        {
            Console.WriteLine(client);
        }
    }

    static void LoadTicketNumbers()
    {
        try
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine(" Création du fichier des numéros...");
                File.WriteAllLines(filePath, new List<string> { "V=0", "R=0", "I=0" });
            }

            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                var parts = line.Split('=');
                if (parts.Length == 2 && ticketNumbers.ContainsKey(parts[0]))
                {
                    ticketNumbers[parts[0]] = int.Parse(parts[1]);
                }
            }

            if (File.Exists(clientsFilePath))
            {
                clients.AddRange(File.ReadAllLines(clientsFilePath));
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($" Erreur lors du chargement des fichiers : {ex.Message}");
        }
    }

    static void SaveTicketNumbers()
    {
        File.WriteAllLines(filePath, new List<string>
        {
            $"V={ticketNumbers["V"]}",
            $"R={ticketNumbers["R"]}",
            $"I={ticketNumbers["I"]}"
        });

        File.WriteAllLines(clientsFilePath, clients);
    }
}
