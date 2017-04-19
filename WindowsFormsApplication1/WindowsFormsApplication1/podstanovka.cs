using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Pad
    {
        private string wor;

        public Pad(string wor)
        {
            int kolvo;

            kolvo = wor.Length; //kolichestvo simvolov v sroke
            //char[] insim1 = new char[26];
            char[] insim = new char[kolvo];
            char[] sim = wor.ToCharArray(); // preobrazovanie string v char

            for (int i = 0; i < kolvo; i++)
            {
                for (; ; )
                {
                    if (sim[i] == 'a') { insim[i] = 'z'; break; }
                    if (sim[i] == 'b') { insim[i] = 'y'; break; }
                    if (sim[i] == 'c') { insim[i] = 'x'; break; }
                    if (sim[i] == 'd') { insim[i] = 'w'; break; }
                    if (sim[i] == 'e') { insim[i] = 'v'; break; }
                    if (sim[i] == 'f') { insim[i] = 'u'; break; }
                    if (sim[i] == 'g') { insim[i] = 't'; break; }
                    if (sim[i] == 'h') { insim[i] = 's'; break; }
                    if (sim[i] == 'i') { insim[i] = 'r'; break; }
                    if (sim[i] == 'j') { insim[i] = 'q'; break; }
                    if (sim[i] == 'k') { insim[i] = 'p'; break; }
                    if (sim[i] == 'l') { insim[i] = 'o'; break; }
                    if (sim[i] == 'm') { insim[i] = 'n'; break; }
                    if (sim[i] == 'n') { insim[i] = 'm'; break; }
                    if (sim[i] == 'o') { insim[i] = 'l'; break; }
                    if (sim[i] == 'p') { insim[i] = 'k'; break; }
                    if (sim[i] == 'q') { insim[i] = 'j'; break; }
                    if (sim[i] == 'r') { insim[i] = 'i'; break; }
                    if (sim[i] == 's') { insim[i] = 'h'; break; }
                    if (sim[i] == 't') { insim[i] = 'g'; break; }
                    if (sim[i] == 'u') { insim[i] = 'f'; break; }
                    if (sim[i] == 'v') { insim[i] = 'e'; break; }
                    if (sim[i] == 'w') { insim[i] = 'd'; break; }
                    if (sim[i] == 'x') { insim[i] = 'c'; break; }
                    if (sim[i] == 'y') { insim[i] = 'b'; break; }
                    if (sim[i] == 'z') { insim[i] = 'a'; break; }
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
