using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Computing 
    {
       // private int x;
       // private int sdvig;
        private string wor;

        public Computing()
    {
        //sdvig = 0;
        //wor = "na";
    }

        public Computing(string wor,int sdvig)
        {
            int kolvo;
            //int sdvig = 3;
            //string wor;

            kolvo = wor.Length; //kolichestvo simvolov v sroke
            char[] insim = new char[kolvo];
            int[] number = new int[26];
            char[] sim = wor.ToCharArray(); // preobrazovanie string v char

            for (int i = 0; i < kolvo; i++)
            {
                for (; ; )
                {
                    if (sim[i] == 'a') { number[i] = 0; break; }
                    if (sim[i] == 'b') { number[i] = 1; break; }
                    if (sim[i] == 'c') { number[i] = 2; break; }
                    if (sim[i] == 'd') { number[i] = 3; break; }
                    if (sim[i] == 'e') { number[i] = 4; break; }
                    if (sim[i] == 'f') { number[i] = 5; break; }
                    if (sim[i] == 'g') { number[i] = 6; break; }
                    if (sim[i] == 'h') { number[i] = 7; break; }
                    if (sim[i] == 'i') { number[i] = 8; break; }
                    if (sim[i] == 'j') { number[i] = 9; break; }
                    if (sim[i] == 'k') { number[i] = 10; break; }
                    if (sim[i] == 'l') { number[i] = 11; break; }
                    if (sim[i] == 'm') { number[i] = 12; break; }
                    if (sim[i] == 'n') { number[i] = 13; break; }
                    if (sim[i] == 'o') { number[i] = 14; break; }
                    if (sim[i] == 'p') { number[i] = 15; break; }
                    if (sim[i] == 'q') { number[i] = 16; break; }
                    if (sim[i] == 'r') { number[i] = 17; break; }
                    if (sim[i] == 's') { number[i] = 18; break; }
                    if (sim[i] == 't') { number[i] = 19; break; }
                    if (sim[i] == 'u') { number[i] = 20; break; }
                    if (sim[i] == 'v') { number[i] = 21; break; }
                    if (sim[i] == 'w') { number[i] = 22; break; }
                    if (sim[i] == 'x') { number[i] = 23; break; }
                    if (sim[i] == 'y') { number[i] = 24; break; }
                    if (sim[i] == 'z') { number[i] = 25; break; }
                }
            }

            //preobrazovanie

            for (int i = 0; i < kolvo; i++)
            {
                number[i] = number[i] + sdvig;
                if (number[i] >= 26) number[i] = number[i] - 26;
                if (number[i] < 0 ) number[i] = number[i] + 26;
                for (; ; )
                {
                    if (number[i] == 0) { insim[i] = 'a'; break; }
                    if (number[i] == 1) { insim[i] = 'b'; break; }
                    if (number[i] == 2) { insim[i] = 'c'; break; }
                    if (number[i] == 3) { insim[i] = 'd'; break; }
                    if (number[i] == 4) { insim[i] = 'e'; break; }
                    if (number[i] == 5) { insim[i] = 'f'; break; }
                    if (number[i] == 6) { insim[i] = 'g'; break; }
                    if (number[i] == 7) { insim[i] = 'h'; break; }
                    if (number[i] == 8) { insim[i] = 'i'; break; }
                    if (number[i] == 9) { insim[i] = 'j'; break; }
                    if (number[i] == 10) { insim[i] = 'k'; break; }
                    if (number[i] == 11) { insim[i] = 'l'; break; }
                    if (number[i] == 12) { insim[i] = 'm'; break; }
                    if (number[i] == 13) { insim[i] = 'n'; break; }
                    if (number[i] == 14) { insim[i] = 'o'; break; }
                    if (number[i] == 15) { insim[i] = 'p'; break; }
                    if (number[i] == 16) { insim[i] = 'q'; break; }
                    if (number[i] == 17) { insim[i] = 'r'; break; }
                    if (number[i] == 18) { insim[i] = 's'; break; }
                    if (number[i] == 19) { insim[i] = 't'; break; }
                    if (number[i] == 20) { insim[i] = 'u'; break; }
                    if (number[i] == 21) { insim[i] = 'v'; break; }
                    if (number[i] == 22) { insim[i] = 'w'; break; }
                    if (number[i] == 23) { insim[i] = 'x'; break; }
                    if (number[i] == 24) { insim[i] = 'y'; break; }
                    if (number[i] == 25) { insim[i] = 'z'; break; }
                }
            }

            string inwor = string.Concat(insim);
            this.wor = inwor;
           
        }
        
        public string PrintWord()
        {
            return this.wor;
        }
 
    }
}
