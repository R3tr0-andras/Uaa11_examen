using System;
using System.Collections.Generic;
using System.Text;

namespace CeUAA11_2023_Andras
{
    public struct other
    {
        //Cryptage en Vigenere
        public static string matVigenere(string phClaire, string phCle)
        {
            string[,] matVigenere = new string[4, phClaire.Length];
            int j = 0;
            int codeAscii;

            for (int i = 0; i < phClaire.Length - 1; i++)
            {
                matVigenere[0, i] = phClaire[i].ToString();

                if (j == phCle.Length)
                {
                    j = 0;
                }
                matVigenere[1, i] = phCle[j].ToString();
                matVigenere[2, i] = ((int)phCle[j] - 65).ToString();

                if ((int)phClaire[i] + int.Parse(matVigenere[2, i]) <= 90)
                {
                    codeAscii = (int)char.Parse(matVigenere[2, i]);
                }
                else
                {
                    codeAscii = (int)phClaire[i] + int.Parse(matVigenere[2, i]) - 26;
                }
                matVigenere[3, i] = Convert.ToChar(codeAscii).ToString();
                j = j + 1;
            }

            //sortir le résultat
            string resultat = "";
            for (int k = 0; k < phClaire.Length; k++)
            {
                resultat += matVigenere[3, k];
            }
            return resultat;
        }

        //Cryptage en Affine
        public static string CryptAffine(string phClaire, string phCle, int aa, int b)
        {
            string[,] matAffine = new string[4, phClaire.Length];

            for (int i = 0; i < phClaire.Length - 1; i++)
            {
                matAffine[0, i] = phClaire[i].ToString();
                int x = ((int)phClaire[i] - 65);
                matAffine[1, i] = x.ToString();
                int y = (aa * x + b) % 26;
                matAffine[2, i] = y.ToString();
                matAffine[3, i] = ((char)(y + 65)).ToString();
            }

            //sortir le résultat
            string result = "";
            for (int j = 0; j < phClaire.Length; j++)
            {
                result += matAffine[3, j];
            }
            return result;
        }
    }

}