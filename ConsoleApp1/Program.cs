using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {

        public static int ada;
        static void Main(string[] args)
        {
            double lamda = 0.25;
            double alfa = 0.6;

            double[][] hazırlık = new double[24][];
            hazırlık[0] = new double[] { 5.1, 3.5, 1.4, 0.2, 1, 0, 0 };
            hazırlık[1] = new double[] { 4.7, 3.2, 1.6, 0.2, 1, 0, 0 };
            hazırlık[2] = new double[] { 6.1, 2.8, 4.0, 1.3, 0, 1, 0 };
            hazırlık[3] = new double[] { 7.7, 3.8, 6.7, 2.2, 0, 0, 1 };
            hazırlık[3] = new double[] { 7.7, 3.8, 6.7, 2.2, 0, 0, 1 };
            hazırlık[4] = new double[] { 6.0, 3.4, 4.5, 1.6, 0, 1, 0 };
            hazırlık[5] = new double[] { 6.3, 3.4, 5.6, 2.4, 0, 0, 1 };
            hazırlık[6] = new double[] { 5.0, 3.5, 1.3, 0.3, 1, 0, 0 };
            hazırlık[7] = new double[] { 6.3, 3.3, 4.7, 1.6, 0, 1, 0 };
            hazırlık[8] = new double[] { 6.0, 2.2, 4.0, 1.0, 0, 1, 0 };
            hazırlık[9] = new double[] { 4.9, 3.1, 1.5, 0.1, 1, 0, 0 };
            hazırlık[10] = new double[] { 6.7, 2.5, 5.8, 1.8, 0, 0, 1 };
            hazırlık[11] = new double[] { 5.0, 2.3, 3.3, 1.0, 0, 1, 0 };
            hazırlık[12] = new double[] { 6.3, 2.7, 4.9, 1.8, 0, 0, 1 };
            hazırlık[13] = new double[] { 5.7, 3.8, 1.7, 0.3, 1, 0, 0 };
            hazırlık[14] = new double[] { 4.4, 2.9, 1.4, 0.2, 1, 0, 0 };
            hazırlık[15] = new double[] { 5.7, 2.6, 3.5, 1.0, 0, 1, 0 };
            hazırlık[16] = new double[] { 4.6, 3.6, 1.0, 0.2, 1, 0, 0 };
            hazırlık[17] = new double[] { 6.7, 3.0, 5.2, 2.3, 0, 0, 1 };
            hazırlık[18] = new double[] { 5.8, 2.7, 4.1, 1.0, 0, 1, 0 };
            hazırlık[19] = new double[] { 6.4, 2.8, 5.6, 2.1, 0, 0, 1 };
            hazırlık[20] = new double[] { 5.1, 2.5, 3.0, 1.1, 0, 1, 0 };
            hazırlık[21] = new double[] { 4.8, 3.0, 1.4, 0.1, 1, 0, 0 };
            hazırlık[22] = new double[] { 6.9, 3.1, 5.1, 2.3, 0, 0, 1 };
            hazırlık[23] = new double[] { 6.3, 2.5, 5.0, 1.9, 0, 0, 1 };

            double[][] denemeset = new double[6][];
            denemeset[0] = new double[] { 5.6, 3.0, 4.1, 1.3, 0, 1, 0 };
            denemeset[1] = new double[] { 6.3, 2.9, 5.6, 1.8, 0, 0, 1 };
            denemeset[2] = new double[] { 5.8, 4.0, 1.2, 0.2, 1, 0, 0 };
            denemeset[3] = new double[] { 4.6, 3.1, 1.5, 0.2, 1, 0, 0 };
            denemeset[4] = new double[] { 6.9, 3.1, 4.9, 1.5, 0, 1, 0 };
            denemeset[5] = new double[] { 6.0, 3.0, 4.8, 1.8, 0, 0, 1 };

            int girisnoronsay = 4;
            int gizlinoronsay = 4;
            int cıkışnoronsay = 3;

            double[] giris = new double[4];
            double[] cıkıs = new double[3];
            double[] hedef = new double[3];
            double[] gizli = new double[4];

            Random r = new Random();

            double[][] ggagırlık = new double[4][];
            double [] gbias = new double[4];

            for(int i=0;i<ggagırlık.Length;i++)
            {
                ggagırlık[i] = new double[4];
                for(int j=0;j<ggagırlık[i].Length;j++)
                {
                    ggagırlık[i][j] = -1 + r.NextDouble() * 2;
                }
            }
            for(int i=0;i<girisnoronsay;i++)
            {
                gbias[i] = -1 + r.NextDouble() * 2;
            }
            double[][] gcagırlık = new double[4][];
            double[] cbias = new double[3];

            for(int i=0;i<gcagırlık.Length;i++)
            {
                gcagırlık[i] = new double[3];
                for(int j=0;j<gcagırlık[i].Length;j++)
                {
                    gcagırlık[i][j] = -1 + r.NextDouble() * 2;

                }
            }
            for(int i=0;i<cıkışnoronsay;i++)
            {
                cbias[i] = -1 + r.NextDouble() * 2; 
            }

            for(int run = 0; run < 1000;run++)
            {
                for(int i = 0; i < hazırlık.Length; i++)
                {
                    for(int j=0;j<4;j++)
                    {
                        giris[j] = hazırlık[i][j];

                    }
                    int sayac = 0;
                    for(int j=4;j<hazırlık[i].Length;j++)
                    {
                        hedef[sayac++] = hazırlık[i][j];
                    }
                    double[] gizlitoplam = new double[gizlinoronsay];

                    for(int j=0;j<gizlinoronsay;j++)
                    {
                        for(int k=0;k<girisnoronsay;k++)
                        {
                            gizlitoplam[j] += giris[k] * ggagırlık[k][j];
                        }
                        gizlitoplam[j] += gbias[j];
                        gizlitoplam[j] = sigmoid(gizlitoplam[j]);
                    }
                    double[] cıkıstoplam = new double[cıkışnoronsay];
                    for(int j=0; j<cıkışnoronsay;j++)
                    {
                        for(int k=0;k<gizlinoronsay;k++)
                        {
                            cıkıstoplam[j] += gizlitoplam[k] * gcagırlık[k][j];
                        }
                        cıkıstoplam[j] += cbias[j];
                        cıkıs[j] = sigmoid(cıkıstoplam[j]);
                    }
                    double[] hatalar = new double[cıkışnoronsay];
                    double th = 0;
                    for (int j=0;j<cıkışnoronsay;j++)
                    {
                        hatalar[j] = hedef[j] - cıkıs[j];
                        th += (hatalar[j] * hatalar[j]) / 2;
                    }

                    double[] sigma = new double[cıkışnoronsay];//geriyayılım
                    for(int j=0;j<cıkışnoronsay;j++)
                    {
                        sigma[j] = cıkıs[j] * (1 - cıkıs[j]) * hatalar[j];
                    }
                    double[][] gcdelta = new double[gizlinoronsay][];
                    double[] gcdeltabias = new double[cıkışnoronsay];

                    for(int j=0;j<gizlinoronsay;j++)
                    {
                        gcdelta[j] = new double[cıkışnoronsay];
                        for(int m=0;m<cıkışnoronsay;m++)
                        {
                            gcdelta[j][m] = lamda * sigma[m] * gizlitoplam[j] + alfa * gcdelta[j][m]; 
                        }
                    }
                    for(int j=0;j<gizlinoronsay;j++)
                    {
                        for(int m=0;m < cıkışnoronsay; m++)
                        {
                            gcagırlık[j][m] += gcdelta[j][m];
                        }
                    }
                    for(int m=0;m < cıkışnoronsay;m++)
                    {
                        gcdeltabias[m] = lamda * sigma[m] + alfa * gcdeltabias[m];
                        cbias[m] += gcdeltabias[m];
                    }

                    double[] sigmaara = new double[gizlinoronsay];
                    for(int j=0;j<gizlinoronsay;j++)
                    {
                        sigmaara[j] = gizlitoplam[j] * (1 - gizlitoplam[j]);
                        double tmp = 0;
                        for(int m=0;m<cıkışnoronsay;m++)
                        {
                            tmp += (sigma[m] * gcagırlık[j][m]);
                        }
                        sigmaara[j] *= tmp;
                    }
                    double[][] ihdelta = new double[girisnoronsay][];
                    double[] ihdeltabias = new double[gizlinoronsay];
                    for(int k=0;k<girisnoronsay;k++)
                    {
                        ihdelta[k] = new double[gizlinoronsay];
                        for (int j = 0; j < gizlinoronsay; j++)
                        {
                            ihdelta[k][j] = lamda * sigmaara[j] * giris[k] * alfa * ihdelta[k][j];
                        }
                    }
                    for(int k=0;k<girisnoronsay;k++)
                    {
                        for(int j=0;j<gizlinoronsay;j++)
                        {
                            ggagırlık[k][j] += ihdelta[k][j];
                        }
                    }
                    for(int j=0;j<gizlinoronsay;j++)
                    {
                        ihdeltabias[j] = alfa * sigmaara[j] + alfa * ihdeltabias[j];
                        gbias[j] += ihdeltabias[j];
                    }
                }
            }
            for(int i=0;i<denemeset.Length;i++)
            {
                for(int j=0;j<4;j++)
                {
                    giris[j] = denemeset[i][j];
                }
                int sayac = 0;
                for(int j=4;j<denemeset[i].Length;j++)
                {
                    hedef[sayac++] = denemeset[i][j];
                }
                double[] hsum = new double[gizlinoronsay];

                for(int j=0;j<gizlinoronsay;j++)
                {
                    for(int k=0;k<girisnoronsay;k++)
                    {
                        hsum[j] += giris[k] * ggagırlık[k][j];
                    }
                    hsum[j] += gbias[j];
                    hsum[j] = sigmoid(hsum[j]);
                }
                double[] osum = new double[cıkışnoronsay];

                for(int j=0;j<cıkışnoronsay;j++)
                {
                    for(int k = 0; k < gizlinoronsay; k++)
                    {
                        osum[j] += hsum[k] * gcagırlık[k][j];
                    }
                    osum[j] += cbias[j];
                    cıkıs[j] = sigmoid(osum[j]);
                }
                double[] hatalar = new double[cıkışnoronsay];

                int[] outputint = new int [cıkıs.Length];
                
                for(int j=0; j<cıkıs.Length;j++)
                {
                    outputint[j] = 0;
                }
                int maxsayac = 0;
                double max = Double.MinValue;

                for(int j=0;j<cıkıs.Length;j++)
                {
                    if(cıkıs[j] > max)
                    {
                        max = cıkıs[j];
                        maxsayac = j;
                    }
                }
                outputint[maxsayac] = 1;

                for (int j=0;j<cıkışnoronsay;j++)
                {
                    Console.Write(outputint[j] + " ");
                }
                Console.Write("\t");
                for(int j=0;j<cıkışnoronsay;j++)
                {
                    Console.Write(hedef[j] + " ");
                }
                Console.WriteLine();
            }
            Console.Read();


        }
        private static double sigmoid(double v)
        {
            return 1 / (1 + (Math.Pow(Math.E, v * -1)));
        }
    }

}
