
/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yosi12l10
{
    public class DirectedE
    {
        //int[] SEARCH(edgeFirst)
        public static int[] SEARCH(int[] edgeFirst, int[] edgeNext, int x)
        {
            //edgeFirst.Lengthは点の個数
            //edgeNext.Lengthは辺の個数
            try
            {
                //const int N = edgeFirst.Length;
                int N = edgeFirst.Length;
                //const int M = 8;
                int M = edgeNext.Length;

                int[] start = new int[M];
                int[] end = new int[M];
                int[] edgefirst = new int[N];
                int[] edgenext = new int[M];
                int[] current = new int[N];
                int[] searched = new int[M];
                int[] path = new int[M];

*/
/*
int N = 6;
int M = 8;

int[] start = new int[6];
int[] end = new int[6];
int[] edgefirst = new int[8];
int[] edgenext = new int[8];
int[] current = new int[6];
int[] searched = new int[8];
int[] path = new int[8];
*/



/*
                for (int i = 1; i <= N; i++)//各点での未探索の辺の番号を初期化
                {
                    current[i] = edgefirst[i];
                }
                int top = 1;    //探索済の経路の辺の格納位置を初期化     //変える?  
                int last = M;   //確定済の経路の辺の格納位置を初期化
                //int x = 1;    //出発点は点1
                x = 1;
                int temp;//追加
                while (last >= 1)
                {
                    if (current[x] != 0)    //●未探索の辺がある場合?
                    {
                        temp = current[x];      //点Xからたどる接続辺はtemp
                        searched[top] = temp;   //接続辺tempを探索済の経路に登録
                        current[x] = edgenext[temp];    //●点Xから次にたどる未探索の辺を格納
                        x = end[temp];          //接続辺tempの終点を点Xにする
                        top = top + 1;
                    }
                    else
                    {
                        top = top - 1;          //●探索済の辺を遡る
                        temp = searched[top];   //遡った辺はtemp
                        path[last] = temp;      //辺tempを確定済にする
                        x = start[temp];        //●
                        last = last - 1;
                    }
                }
                return path;
                //int[] tadasii = { 1, 2, 3, 7, 8, 5, 6, 4 };
                //return tadasii;
            }
            catch (IndexOutOfRangeException ex)
            {
                int[] no = new int[1];
                return no;
            }
        }
    }
}

*/

namespace WindowsFormsApp2
{
    public class DirectedE
    {
        public static int[] SEARCH(int[] edgeFirst, int[] edgeNext, int s)//メイン
        {
            int N = 6;
            int M = 8;
            int temp;



            int[] start = { 0, 1, 2, 3, 1, 4, 3, 5 };
            int[] end = { 1, 2, 3, 0, 4, 3, 5, 1 };
            int[] current = new int[7];
            int[] searched = new int[9];
            int[] path = new int[8];



            for (int i = 0; i < N; i++)
            {
                current[i] = edgeFirst[i] - 1;
            }



            int top = 0;
            int last = M - 1;
            int x = s - 1;



            while (last >= 0)
            {
                if (current[x] != -1)
                {
                    temp = current[x];
                    searched[top] = temp;
                    current[x] = edgeNext[temp] - 1;
                    x = end[temp];
                    top++;
                }
                else
                {
                    top = top - 1;
                    temp = searched[top];
                    path[last] = temp + 1;
                    x = start[temp];
                    last--;
                }
            }
            return path;
        }
    }
}
