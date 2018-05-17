using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication001
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = { "葉俊廷", "張澤瑜", "王程捷 的咩？", "江儀婷", "張秉華", "陳柏霖", "黃紀瑜", "黃昱維", "蔡逸群", "登琳", "世新魏鈞孝吧", "劉定南", "陳信如", "童信傑", "李岳倫", "鄒和恆", "簡毓玟", "劉子瑄", "蕭紹洋", "李亞宸la", "張以潔", "邱仕紳", "呂家瑩", "世新林鑫佑", "徐均得", "陳佳欣", "張恩瑋", "周詮", "王湘婷", "蕭宇成", "Max Cheung(BANG)", "馬嘉誠Σヽ(ﾟД ﾟ; )ﾉ魔貫光殺砲(ﾟДﾟ)σ━0000", "陳昱嘉", "康珈熏", "盧奕宏", "陳郁佳的大哥黃博涵", "遲正雯", "世新林星彤", "許晏誠ｘ勒是奇多＿８＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝Ｄ", "許子安", "高子晴", "陳思婷", "矝鵘鮿", "余彥廷", "吳耀輝", "鄭丞智", "林冠廷", "世新何曜宇", "邵喬雨", "張豐愷", "林子晴", "邱雁回", "陳家欣是韓妞", "鄧雅馨", "謝汶珊", "李曼寧", "世新徐偉哲", "张钰慈", "鍾宜珊", "raer_tsai", "世新李姳諼", "鄭曼君", "陳柏霖", "世新許子安", "世新方若帆", "李曼寧", "世新遲正雯", "世新周詮" };
            string[] sexy = { "男", "男", "男", "女", "男", "男", "女", "男", "男", "男", "男", "男", "女", "男", "男", "男", "女", "女", "男", "男", "女", "男", "女", "男", "男", "女", "男", "男", "女", "男", "男", "男", "男", "女", "男", "男", "女", "女", "男", "男", "女", "女", "男", "男", "男", "男", "男", "男", "女", "男", "女", "女", "女", "女", "女", "女", "男", "女", "女", "女", "女", "女", "男", "男", "女", "女", "女", "男" };
            string[] Bo = { "O", "其他", "O", "O", "A", "O", "A", "A", "O", "O", "A", "O", "A", "B", "O", "O", "A", "其他", "O", "O", "A", "", "B", "O", "", "O", "B", "O", "B", "B", "B", "O", "O", "AB", "O", "B", "A", "O", "O", "", "O", "A", "", "O", "O", "A", "O", "O", "其他", "B", "O", "O", "O", "A", "AB", "A", "O", "B", "AB", "", "O", "O", "O", "", "O", "A", "A", "O" };
            string[] Stay = { "金牛", "", "巨蟹", "白羊", "雙魚", "雙子", "天蠍", "巨蟹", "獅子", "雙魚", "雙子", "雙子", "獅子", "雙魚", "天蠍", "天蠍", "處女", "處女", "金牛", "雙魚", "處女", "摩羯", "雙魚", "白羊", "天蠍", "處女", "雙子", "金牛", "雙子", "白羊", "白羊", "摩羯", "射手", "巨蟹", "雙魚", "獅子", "射手", "摩羯", "天蠍", "", "雙魚", "雙子", "", "雙魚", "處女", "金牛", "天秤", "水瓶", "巨蟹", "處女", "白羊", "摩羯", "水瓶", "天秤", "金牛", "天蠍", "天蠍", "處女", "雙子", "", "摩羯", "天蠍", "雙子", "", "獅子", "天蠍", "射手", "金牛" };
            int[] H = { 173, 0, 179, 155, 183, 170, 163, 174, 165, 189, 177, 180, 154, 167, 170, 173, 165, 158, 180, 165, 153, 175, 162, 165, 0, 160, 165, 173, 164, 177, 177, 180, 170, 151, 176, 180, 168, 152, 666, 2147483647, 165, 155, 777, 173, 169, 170, 169, 171, 0, 170, 150, 160, 155, 164, 163, 165, 184, 165, 155, 0, 168, 160, 169, 0, 150, 163, 168, 173 };

            // 開頭

            Console.WriteLine("班上同學姓名:");
            Console.WriteLine(" ");

            // 變數

            int countG = 0;
            int countM = 0;
            int countA = 0;
            int countB = 0;
            int countAB = 0;
            int countO = 0;
            int count = 0;

            // 個數

            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);

                if (H[i] > 100 && H[i] < 200 && sexy[i] == "女")
                {
                    countG += 1;
                }
                else if (H[i] > 100 && H[i] < 200 && sexy[i] == "男")
                {
                    countM += 1;
                }
                else
                    count += 1;
            }

            // 身高

            int sumG = 0;
            int sumM = 0;
            int sum = 0;
            for (int i = 0; i < H.Length; i++)
            {
                if (H[i] > 100 && H[i] < 200 && sexy[i] == "女")
                {
                    sumG = sumG + H[i];
                }
                else if (H[i] > 100 && H[i] < 200 && sexy[i] == "男")
                {
                    sumM = sumM + H[i];
                }
                else
                    sum = sum + H[i];
            }
            double Gph = sumG / countG;
            double Mph = sumM / countM;

            // 找出班上最高與最矮身高
            int max = -9999;
            int min = 9999;
            int n = 0;

            for (n = 0; n < H.Length; n++)
            {
                if (H[n] > 100 && H[n] < 200)
                {
                    if (H[n] > max)
                    {
                        max = H[n];
                    }
                    if (H[n] < min)
                    {
                        min = H[n];
                    }
                }
            }

            // 血型

            for (int i = 0; i < Bo.Length; i++)
            {
                if (Bo[i] == "A")
                {
                    countA += 1;
                }
                else if (Bo[i] == "B")
                {
                    countB += 1;
                }
                else if (Bo[i] == "AB")
                {
                    countAB += 1;
                }
                else if (Bo[i] == "O")
                    countO += 1;
                else
                    count += 1;
            }

            // 百分比

            double perM = (double)countM / (double)sexy.Length * 100;
            double perG = (double)countG / (double)sexy.Length * 100;
            double perA = (double)countA / (double)Bo.Length * 100;
            double perB = (double)countB / (double)Bo.Length * 100;
            double perAB = (double)countAB / (double)Bo.Length * 100;
            double perO = (double)countO / (double)Bo.Length * 100;

            // 輸出

            Console.WriteLine(" ");
            Console.WriteLine("上列資料中:");
            Console.WriteLine(" ");
            Console.WriteLine("女生人數:{0} 佔:{1:0}%", countG, perG);
            Console.WriteLine("女生身高總和:" + sumG);
            Console.WriteLine("女生身高平均:" + Gph);
            Console.WriteLine(" ");
            Console.WriteLine("男生人數:{0} 佔:{1:0}%", countM, perM);
            Console.WriteLine("男生身高總和:" + sumM);
            Console.WriteLine("男生身高平均:" + Mph);
            Console.WriteLine(" ");
            Console.WriteLine("全班最高的人:" + max);
            Console.WriteLine("全班最矮的人:" + min);
            Console.WriteLine(" ");
            Console.WriteLine("A型人數:{0} 佔:{1:0}%", countA, perA);
            Console.WriteLine("B型人數:{0} 佔:{1:0}%", countB, perB);
            Console.WriteLine("AB型人數:{0} 佔:{1:0}%", countAB, perAB);
            Console.WriteLine("O型人數:{0} 佔:{1:0}%", countO, perO);
            Console.WriteLine(" ");

            // 天蠍座O型的人

            for (int i = 0; i < name.Length; i++)
            {
                if (Stay[i] == "天蠍" && Bo[i] == "O")
                {
                    Console.WriteLine("天蠍座O型的人為:" + name[i]);
                }
            }

            // 結束

            Console.ReadLine();
        }
    }
}
