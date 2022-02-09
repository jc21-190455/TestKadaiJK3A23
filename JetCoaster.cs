using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yosi12l10.Properties
{
    public class JetCoaster
    {
        //k:定員、g:配列、ｒ:回す回数



        static int i = 0;



        public static int ride(int k, int[] g, int r)//メイン
        {
            i = 0;
            int saisyukekka = 0;

            for (int j = 1; j <= r; j++)//回す回数
            {
                saisyukekka += ride2(k, g);
            }
            return saisyukekka;




        }




        public static int ride2(int k, int[] g)//定員、配列
        {
            int kekka = 0;



            Boolean flg = true;
            while (flg)
            {
                Console.Write(i);
                if (kekka + g[i] > k)
                {
                    flg = false;

                }
                else
                {
                    kekka += g[i];
                    i = (i + 1) % g.Length;
                }

            }



            return kekka;

        }



    }
}