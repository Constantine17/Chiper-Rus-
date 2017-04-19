using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Vigenere
    {
        public string wor;
        public Vigenere(string wor, string key, int razciper)
        {

            
            int kolvo, keykolvo;
            //int sdvig = 3;

            //kolvo = 4 % 3;
            //Console.WriteLine(kolvo);
            kolvo = wor.Length;
            keykolvo = key.Length;
            int[] chsim = new int[kolvo];// chisla slova
            int[] chinsim = new int[kolvo];// chisla klycha
            int[] chcipher = new int[kolvo];// chisla shifra
            char[] insim = new char[kolvo];// massiv 
            char[] chipher = new char[kolvo];
            char[] sim = wor.ToCharArray();
            //char[] key1 = key.ToCharArray();
            char[] key1 = new char[kolvo];

            int j = 0;
            for (int i = 0; i < kolvo; i++) //udlinee ili ukorochenie klycha
            {
                key1[i] = key[j];
                j++;
                if (j >= keykolvo) j = j - keykolvo;
            }

            //int[] nubmer ;
            for (int i = 0; i < kolvo; i++)
            {
                for (; ; )
                {
                    if (sim[i] == 'a') { chsim[i] = 0; break; }
                    if (sim[i] == 'b') { chsim[i] = 1; break; }
                    if (sim[i] == 'c') { chsim[i] = 2; break; }
                    if (sim[i] == 'd') { chsim[i] = 3; break; }
                    if (sim[i] == 'e') { chsim[i] = 4; break; }
                    if (sim[i] == 'f') { chsim[i] = 5; break; }
                    if (sim[i] == 'g') { chsim[i] = 6; break; }
                    if (sim[i] == 'h') { chsim[i] = 7; break; }
                    if (sim[i] == 'i') { chsim[i] = 8; break; }
                    if (sim[i] == 'j') { chsim[i] = 9; break; }
                    if (sim[i] == 'k') { chsim[i] = 10; break; }
                    if (sim[i] == 'l') { chsim[i] = 11; break; }
                    if (sim[i] == 'm') { chsim[i] = 12; break; }
                    if (sim[i] == 'n') { chsim[i] = 13; break; }
                    if (sim[i] == 'o') { chsim[i] = 14; break; }
                    if (sim[i] == 'p') { chsim[i] = 15; break; }
                    if (sim[i] == 'q') { chsim[i] = 16; break; }
                    if (sim[i] == 'r') { chsim[i] = 17; break; }
                    if (sim[i] == 's') { chsim[i] = 18; break; }
                    if (sim[i] == 't') { chsim[i] = 19; break; }
                    if (sim[i] == 'u') { chsim[i] = 20; break; }
                    if (sim[i] == 'v') { chsim[i] = 21; break; }
                    if (sim[i] == 'w') { chsim[i] = 22; break; }
                    if (sim[i] == 'x') { chsim[i] = 23; break; }
                    if (sim[i] == 'y') { chsim[i] = 24; break; }
                    if (sim[i] == 'z') { chsim[i] = 25; break; }
                }
            }

            for (int i = 0; i < kolvo; i++)
            {
                for (; ; )
                {
                    if (key1[i] == 'a') { chinsim[i] = 0; break; }
                    if (key1[i] == 'b') { chinsim[i] = 1; break; }
                    if (key1[i] == 'c') { chinsim[i] = 2; break; }
                    if (key1[i] == 'd') { chinsim[i] = 3; break; }
                    if (key1[i] == 'e') { chinsim[i] = 4; break; }
                    if (key1[i] == 'f') { chinsim[i] = 5; break; }
                    if (key1[i] == 'g') { chinsim[i] = 6; break; }
                    if (key1[i] == 'h') { chinsim[i] = 7; break; }
                    if (key1[i] == 'i') { chinsim[i] = 8; break; }
                    if (key1[i] == 'j') { chinsim[i] = 9; break; }
                    if (key1[i] == 'k') { chinsim[i] = 10; break; }
                    if (key1[i] == 'l') { chinsim[i] = 11; break; }
                    if (key1[i] == 'm') { chinsim[i] = 12; break; }
                    if (key1[i] == 'n') { chinsim[i] = 13; break; }
                    if (key1[i] == 'o') { chinsim[i] = 14; break; }
                    if (key1[i] == 'p') { chinsim[i] = 15; break; }
                    if (key1[i] == 'q') { chinsim[i] = 16; break; }
                    if (key1[i] == 'r') { chinsim[i] = 17; break; }
                    if (key1[i] == 's') { chinsim[i] = 18; break; }
                    if (key1[i] == 't') { chinsim[i] = 19; break; }
                    if (key1[i] == 'u') { chinsim[i] = 20; break; }
                    if (key1[i] == 'v') { chinsim[i] = 21; break; }
                    if (key1[i] == 'w') { chinsim[i] = 22; break; }
                    if (key1[i] == 'x') { chinsim[i] = 23; break; }
                    if (key1[i] == 'y') { chinsim[i] = 24; break; }
                    if (key1[i] == 'z') { chinsim[i] = 25; break; }
                }
            }

            if (razciper == 0)
                for (int i = 0; i < kolvo; i++)
                {
                    chcipher[i] = (chsim[i] + chinsim[i]) % 26;
                }
            else
                for (int i = 0; i < kolvo; i++)
                {
                    chcipher[i] = (chsim[i] - chinsim[i] + 26) % 26;
                }

            for (int i = 0; i < kolvo; i++)
            {

                for (; ; )
                {
                    if (chcipher[i] == 0) { chipher[i] = 'a'; break; }
                    if (chcipher[i] == 1) { chipher[i] = 'b'; break; }
                    if (chcipher[i] == 2) { chipher[i] = 'c'; break; }
                    if (chcipher[i] == 3) { chipher[i] = 'd'; break; }
                    if (chcipher[i] == 4) { chipher[i] = 'e'; break; }
                    if (chcipher[i] == 5) { chipher[i] = 'f'; break; }
                    if (chcipher[i] == 6) { chipher[i] = 'g'; break; }
                    if (chcipher[i] == 7) { chipher[i] = 'h'; break; }
                    if (chcipher[i] == 8) { chipher[i] = 'i'; break; }
                    if (chcipher[i] == 9) { chipher[i] = 'j'; break; }
                    if (chcipher[i] == 10) { chipher[i] = 'k'; break; }
                    if (chcipher[i] == 11) { chipher[i] = 'l'; break; }
                    if (chcipher[i] == 12) { chipher[i] = 'm'; break; }
                    if (chcipher[i] == 13) { chipher[i] = 'n'; break; }
                    if (chcipher[i] == 14) { chipher[i] = 'o'; break; }
                    if (chcipher[i] == 15) { chipher[i] = 'p'; break; }
                    if (chcipher[i] == 16) { chipher[i] = 'q'; break; }
                    if (chcipher[i] == 17) { chipher[i] = 'r'; break; }
                    if (chcipher[i] == 18) { chipher[i] = 's'; break; }
                    if (chcipher[i] == 19) { chipher[i] = 't'; break; }
                    if (chcipher[i] == 20) { chipher[i] = 'u'; break; }
                    if (chcipher[i] == 21) { chipher[i] = 'v'; break; }
                    if (chcipher[i] == 22) { chipher[i] = 'w'; break; }
                    if (chcipher[i] == 23) { chipher[i] = 'x'; break; }
                    if (chcipher[i] == 24) { chipher[i] = 'y'; break; }
                    if (chcipher[i] == 25) { chipher[i] = 'z'; break; }
                }
            }

            string ciper = string.Concat(chipher);

            this.wor = ciper;


        }
        public string PrintWord()
        {
            return this.wor;
        }
    }

}
