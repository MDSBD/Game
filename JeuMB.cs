using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class JeuMB
    {
        string secret;

        public void genererSecret()
        {
            Random rand = new Random();
           string a= rand.Next(0,9).ToString();
              string b= rand.Next(0,9).ToString();
                string c= rand.Next(0,9).ToString();
                    string d= rand.Next(0,9).ToString();
            while(a==b || a==c || a==d || b==c || b==d || c==d)
            {
                 
                 b= rand.Next(0,9).ToString();
                 c= rand.Next(0,9).ToString();
                 d= rand.Next(0,9).ToString();
            }
            secret = a + b + c + d;
        }
        public string getSecret()
        {
            return secret;
        }

        public string comparer(string prop)
        {
            int m = 0;
            int b = 0;
            for (int i = 0; i < 4; i++)
            {
                if (secret.Contains(prop[i]))
                {
                    if (secret[i] == prop[i])
                    {
                        m++;
                    }
                    else
                    {
                        b++;
                    }
                }

            }
            return m + "M" + b + "B";
        }
    }
}
