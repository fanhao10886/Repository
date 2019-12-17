using System;

namespace jisuanfa
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int i;   //公鸡
            int j;   //母鸡
            int c;   //小鸡
            for( i=0; i <=20;i++)
            {
                for( j=0;j<=30;j++)
                {
                     for( c=0;c<=100;c+=3)
                    {
                         if((i+j+c)==100&& (5*i+3*j+c/3)==100)
                        {
                            Console.WriteLine("公鸡有:{0}   母鸡有:{1}   小鸡有:{2}",i,j,c);

                        }
                    }
                }
            }
            Console.ReadLine();                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             
        }

    }
}
