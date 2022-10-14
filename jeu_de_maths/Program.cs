using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {

        enum e_Operateur
        {
            ADDITION = 1,
            MULTIPLICATION = 2,
            SOUSTRACTION = 3,
        }

        static bool PoserQuestion(int MIN, int MAX)
        {
            Random rand = new Random();

            while (true)
            {
                int a = rand.Next(MIN, MAX + 1);
                int b = rand.Next(MIN, MAX + 1);
                e_Operateur o = (e_Operateur)rand.Next(1, 4);
                int resultatAttendu;



                switch (o)
                {
                    case e_Operateur.ADDITION:
                        Console.Write(a + " + " + b + " = ");
                        resultatAttendu = a + b;
                        break;
                    case e_Operateur.MULTIPLICATION:
                        Console.Write(a + " x " + b + " = ");
                        resultatAttendu = a * b;
                        break;
                    case e_Operateur.SOUSTRACTION:
                        Console.Write(a + " - " + b + " = ");
                        resultatAttendu = a - b;
                        break;
                    default:
                        Console.Write("ERREUR : Opérateur inconnu");
                        return false;

                }




                if (o == e_Operateur.ADDITION)
                {
                    Console.Write(a + " + " + b + " = ");
                    resultatAttendu = a + b;
                }
                else if (o == e_Operateur.MULTIPLICATION)
                {
                    Console.Write(a + " x " + b + " = ");
                    resultatAttendu = a * b;
                }
                else if (o == e_Operateur.SOUSTRACTION)
                {
                    Console.Write(a + " - " + b + " = ");
                    resultatAttendu = a - b;
                }
                else
                {
                    Console.Write("ERREUR : Opérateur inconnu");
                    return false;
                }

                string reponse = Console.ReadLine();
                try
                {
                    int reponseInt = int.Parse(reponse);
                    if (reponseInt == resultatAttendu)
                    {
                        return true;
                    }
                    return false;
                }
                catch
                {
                    Console.WriteLine("Erreur : vous devez rentrer un nombre");
                }
            }
        }



        static void Main(string[] args)
        {
            // 5 + 2 = 7
            // Bonne réponse / Mauvaise réponse
            // a + b
            // min et max

            // 1 - Définir MIN et MAX
            // 2 - Nombres aléatoires pour a et b
            // 3 - Calculer a + b == reponseInt
            // 4 - return true/false
            // 5 - true -> bonne reponse / mauvaise reponse

            const int MIN = 1;
            const int MAX = 10;
            const int NB_QUESTIONS = 5;

            int points = 0;

            for (int i = 0; i< NB_QUESTIONS; i++)
            {
                Console.WriteLine("Question n°" + (i+1) + "/" + NB_QUESTIONS);
                bool bonneReponse = PoserQuestion(MIN, MAX);
                if (bonneReponse)
                {
                    Console.WriteLine("Bonne réponse !");
                    points++;
                }
                else
                {
                    Console.WriteLine("Mauvaise réponse.");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Nombre de points : " + points + "/" + NB_QUESTIONS);

            int moyenne = NB_QUESTIONS / 2;

            if (points == 0)
            {
                Console.WriteLine("Révisez vos maths.");
            }
            else if (points == NB_QUESTIONS)
            {
                Console.WriteLine("Excellent !");
            }
            else if (points > moyenne)
            {
                Console.WriteLine("Pas mal.");
            }
            else if (points <= moyenne)
            {
                Console.WriteLine("Peut mieux faire.");
            }
            // 100% bonne réponse => Excellent
            // 0 => Révisez vos maths

            // 10 => 5 (10/2 = 5)
            // 5/2 => 2,5 => 2
            

            // > moyenne => Pas mal
            // <= moyenne => Peut mieux faire



        }
    }
}