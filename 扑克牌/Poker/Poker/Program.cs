using System;
using System.Collections;

namespace Poker
{
    enum Color { HongTao = -1, HeiTao = -2, MeiHua = -3, FangPian = -4 }//花色
    enum Point { A, two, three, four, five, six, seven, eight, nine, ten, J, Q, K }//点数
    struct Poker
    {
        private string p1, p2;
        public Poker(string p1, string p2)
        {
            // TODO: Complete member initialization
            this.p1 = p1;
            this.p2 = p2;
        }
        public void Printp()
        {
            Console.Write("({0},{1}) ", this.p1, this.p2);
        }
    }
    class Program
    {

        static void Main(string[] args)
        {

            //int[] num = new int[10];
            //int[] newNum = new int[10];
            //int z, m = 9;
            //int n;
            //int tmp;
            //Random rand = new Random();
            //for (z = 0; z < 10; z++)
            //{
            //    num[z] = z;
            //}
            //for (z = 0; z < 10; z++)
            //{
            //    n = rand.Next(0, m);
            //    newNum[z] = num[n];
            //    tmp = num[n];
            //    num[n] = num[m];
            //    num[m] = tmp;
            //    m--;
            //}
            //for (z = 0; z < 10; z++)
            //{
            //    Console.Write("{0} ", newNum[z]);
            //}
            //Console.Read();





            //Poker po = new Poker();
            ArrayList myPoker = new ArrayList();
            ArrayList Person1 = new ArrayList();
            ArrayList Person2 = new ArrayList();
            ArrayList Person3 = new ArrayList();
            ArrayList Person4 = new ArrayList();
            Random r = new Random();
            for (int i = -4; i <= -1; i++)
            {
                for (int j = 0; j <= 12; j++)
                {
                    myPoker.Add(new Poker(
                        Enum.GetName(typeof(Color), i),
                        Enum.GetName(typeof(Point), j)
                        ));
                }
            }
            Console.WriteLine("打印所有的扑克牌：");
            for (int i = 0; i < 52; i++)
            {
                Poker poAll = (Poker)myPoker[i];
                poAll.Printp();
            }

            for (int i = 0; i < 13; i++)
            {
                int te = r.Next(0, myPoker.Count);
                Person1.Add(myPoker[te]);
                myPoker.RemoveAt(te);
            }
            for (int i = 0; i < 13; i++)
            {
                int te = r.Next(0, myPoker.Count);
                Person2.Add(myPoker[te]);
                myPoker.RemoveAt(te);
            }
            for (int i = 0; i < 13; i++)
            {
                int te = r.Next(0, myPoker.Count);
                Person3.Add(myPoker[te]);
                myPoker.RemoveAt(te);
            }
            for (int i = 0; i < 13; i++)
            {
                int te = r.Next(0, myPoker.Count);
                Person4.Add(myPoker[te]);
                myPoker.RemoveAt(te);
            }

            Console.WriteLine();
            Console.WriteLine("打印第一个人的扑克牌：");
            for (int i = 0; i < 13; i++)
            {
                Poker po1 = (Poker)Person1[i];
                po1.Printp();
            }
            Console.WriteLine();
            Console.WriteLine("打印第二个人的扑克牌：");
            for (int i = 0; i < 13; i++)
            {
                Poker po2 = (Poker)Person2[i];
                po2.Printp();
            }
            Console.WriteLine();
            Console.WriteLine("打印第三个人的扑克牌：");
            for (int i = 0; i < 13; i++)
            {
                Poker po3 = (Poker)Person3[i];
                po3.Printp();
            }
            Console.WriteLine();
            Console.WriteLine("打印第四个人的扑克牌：");
            for (int i = 0; i < 13; i++)
            {
                Poker po4 = (Poker)Person4[i];
                po4.Printp();
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }


}
