using System;

class Program
{
    static void Main()
    {
        Random rnd = new Random();
        int[] tableau = new int[10];

        // 1. Remplissage aléatoire
        for (int i = 0; i < tableau.Length; i++)
        {
            tableau[i] = rnd.Next(1, 101);
        }

        // 2. Affichage initial
        Console.WriteLine("==========================================");
        Console.WriteLine("          TABLEAU INITIAL                 ");
        Console.WriteLine("==========================================");
        Console.WriteLine(" Index  |  Valeur                         ");
        Console.WriteLine("------------------------------------------");
        for (int i = 0; i < tableau.Length; i++)
        {
            Console.WriteLine("   [" + i + "]  |  " + tableau[i]);
        }
        Console.WriteLine();

        // 3. Tri à bulles décroissant manuel
        int[] tableauTrie = new int[tableau.Length];
        for (int i = 0; i < tableau.Length; i++)
        {
            tableauTrie[i] = tableau[i];
        }

        for (int i = 0; i < tableauTrie.Length - 1; i++)
        {
            for (int j = 0; j < tableauTrie.Length - 1 - i; j++)
            {
                if (tableauTrie[j] < tableauTrie[j + 1])
                {
                    int temporaire = tableauTrie[j];
                    tableauTrie[j] = tableauTrie[j + 1];
                    tableauTrie[j + 1] = temporaire;
                }
            }
        }

        Console.WriteLine("==========================================");
        Console.WriteLine("        TABLEAU TRIÉ (DÉCROISSANT)        ");
        Console.WriteLine("==========================================");
        Console.WriteLine(" Index  |  Valeur                         ");
        Console.WriteLine("------------------------------------------");
        for (int i = 0; i < tableauTrie.Length; i++)
        {
            Console.WriteLine("   [" + i + "]  |  " + tableauTrie[i]);
        }
        Console.WriteLine();

        // 4. Médiane calculée sur le tableau trié
        int milieu = tableauTrie.Length / 2;
        double mediane = (tableauTrie[milieu - 1] + tableauTrie[milieu]) / 2.0;

        Console.WriteLine("==========================================");
        Console.WriteLine("                 MÉDIANE                  ");
        Console.WriteLine("==========================================");
        Console.WriteLine("Médiane (données initiales) : " + mediane);
        Console.WriteLine();

        // 5. Multiplication par 2
        Console.WriteLine("==========================================");
        Console.WriteLine("       VALEURS MULTIPLIÉES PAR 2          ");
        Console.WriteLine("==========================================");
        Console.WriteLine(" Index  |  Nouvelle valeur                ");
        Console.WriteLine("------------------------------------------");
        for (int i = 0; i < tableau.Length; i++)
        {
            tableau[i] = tableau[i] * 2;
            Console.WriteLine("   [" + i + "]  |  " + tableau[i]);
        }
        Console.WriteLine();

        // 6. Somme et Moyenne
        int sommeT = 0;
        for (int i = 0; i < tableau.Length; i++)
        {
            sommeT = sommeT + tableau[i];
        }

        double moyenneT = (double)sommeT / tableau.Length;

        Console.WriteLine("==========================================");
        Console.WriteLine("              STATISTIQUES                ");
        Console.WriteLine("==========================================");
        Console.WriteLine("Somme totale  : " + sommeT);
        Console.WriteLine("Moyenne       : " + moyenneT);
        Console.WriteLine();

        // 7. Inversion manuelle
        int[] tableauInverser = new int[tableau.Length];
        for (int i = 0; i < tableau.Length; i++)
        {
            tableauInverser[i] = tableau[tableau.Length - 1 - i];
        }

        Console.WriteLine("==========================================");
        Console.WriteLine("            TABLEAU INVERSÉ               ");
        Console.WriteLine("==========================================");
        Console.WriteLine(" Index  |  Valeur inversée                ");
        Console.WriteLine("------------------------------------------");
        for (int i = 0; i < tableauInverser.Length; i++)
        {
            Console.WriteLine("   [" + i + "]  |  " + tableauInverser[i]);
        }
        Console.WriteLine();

        // 8.1 Remise à zéro d'un élément (index 7)
        int indexAZero = 7;
        tableau[indexAZero] = 0;

        Console.WriteLine("==========================================");
        Console.WriteLine("   REMISE À ZÉRO DE L'ÉLÉMENT À L'INDEX " + indexAZero);
        Console.WriteLine("==========================================");
        Console.WriteLine(" Index  |  Valeur                         ");
        Console.WriteLine("------------------------------------------");
        for (int i = 0; i < tableau.Length; i++)
        {
            Console.WriteLine("   [" + i + "]  |  " + tableau[i]);
        }
        Console.WriteLine("==========================================");

        // 8.2 Suppression manuelle d'un élément (index 7)
        int indexASupprimer = 7;
        int[] tableauReduit = new int[tableau.Length - 1];
        int curseur = 0;

        for (int i = 0; i < tableau.Length; i++)
        {
            if (i != indexASupprimer)
            {
                tableauReduit[curseur] = tableau[i];
                curseur++;
            }
        }

        Console.WriteLine("==========================================");
        Console.WriteLine("    SUPPRESSION DE L'ÉLÉMENT À L'INDEX " + indexASupprimer);
        Console.WriteLine("==========================================");
        Console.WriteLine(" Index  |  Valeur restante                ");
        Console.WriteLine("------------------------------------------");
        for (int i = 0; i < tableauReduit.Length; i++)
        {
            Console.WriteLine("   [" + i + "]  |  " + tableauReduit[i]);
        }
        Console.WriteLine("==========================================");
    }
}