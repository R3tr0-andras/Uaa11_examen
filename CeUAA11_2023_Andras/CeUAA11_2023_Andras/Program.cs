using System;

namespace CeUAA11_2023_Andras
{
    class Program
    {

        static void Main(string[] args)
        {
            other mesOutils = new other();

            int a = 0;
            bool recom = false;

            //boucle pour recommencer
            while (recom == false)
            {
                Console.Clear();
                Console.WriteLine("fait un choix\n 1. cryptage Vigenere\n 2. cryptage Affine");
                string choix = Console.ReadLine();
                
                switch (a)
                {
                    //Vigenere
                    case 0:
                        Console.Clear();
                        //demander le message
                        Console.WriteLine("message a crypter");
                        string phClaire = Console.ReadLine();

                        Console.Clear();
                        //demander la cle
                        Console.WriteLine("cle de cryptage");
                        string phCle = Console.ReadLine();

                        Console.Clear();
                        //utiliser MP
                        string resVig = other.matVigenere(phClaire, phCle);
                        Console.WriteLine("voici : \n" + resVig);

                        //demander recommencer
                        Console.WriteLine("\nvoulez vous recommencer ?");
                        string reponse1 = Console.ReadLine();
                        recom = (reponse1 == "non");

                        break;
                    //Affine
                    case 1:
                        Console.Clear();
                        //demander a
                        Console.WriteLine("donner a");
                        int aa = int.Parse(Console.ReadLine());

                        Console.Clear();
                        //demander b
                        Console.WriteLine("donner b");
                        int b = int.Parse(Console.ReadLine());

                        Console.Clear();
                        //demander le message
                        Console.WriteLine("message a crypter");
                        phClaire = Console.ReadLine();

                        Console.Clear();
                        //demander la cle
                        Console.WriteLine("cle de cryptage");
                        phCle = Console.ReadLine();

                        Console.Clear();
                        //utiliser MP
                        string resAff = other.CryptAffine(phClaire, phCle, a, b);
                        Console.WriteLine("voici : \n" + resAff);

                        //demander recommencer
                        Console.WriteLine("\nvoulez vous recommencer ?");
                        string reponse2 = Console.ReadLine();
                        recom = (reponse2 == "non");

                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("recommencer");
                        break;

                }
            }
            Console.Clear();
            Console.WriteLine("hello world");
        }
    }
}
