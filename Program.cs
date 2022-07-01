using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B0226497_段昱如_PDPR__Week11_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("B0226497_段昱如_PDPR__Week11_3");
            string x;
            {
                while (true)
                {
                    Console.WriteLine("if 敘述");
                    Console.Write("請輸入代號系別01~06:");
                    x = Console.ReadLine();
                    if (x == "01")
                        Console.WriteLine("選擇為:{0}國際貿易學系_B0226497", x);
                    else if (x == "02")
                        Console.WriteLine("選擇為:{0}國際企業管理學系_B0226497", x);
                    else if (x == "03")
                        Console.WriteLine("選擇為:{0}會計學系_B0226497", x);
                    else if (x == "04")
                        Console.WriteLine("選擇為:{0}觀光事業學系_B0226497", x);
                    else if (x == "05")
                        Console.WriteLine("選擇為:{0}資訊管理學系_B0226497", x);
                    else if (x == "06")
                        Console.WriteLine("選擇為:{0}財務金融學系_B0226497", x);
                    else
                        Console.WriteLine("選擇為:無法辨識");
                    Console.WriteLine("switch 敘述");
                    Console.Write("請輸入代號系別01~06:");
                    x = Console.ReadLine();
                    switch (x)
                    {
                        case "01":
                            Console.WriteLine("選擇為:{0}國際貿易學系_B0226497", x);
                            break;
                        case "02":
                            Console.WriteLine("選擇為:{0}國際企業管理學系_B0226497", x);
                            break;
                        case "03":
                            Console.WriteLine("選擇為:{0}會計學系_B0226497", x);
                            break;
                        case "04":
                            Console.WriteLine("選擇為:{0}觀光事業學系_B0226497", x);
                            break;
                        case "05":
                            Console.WriteLine("選擇為:{0}資訊管理學系_B0226497", x);
                            break;
                        case "06":
                            Console.WriteLine("選擇為:{0}財務金融學系_B0226497", x);
                            break;
                        default:
                            Console.WriteLine("選擇為:無法辨識");
                            break;
                    }
                    Console.ReadLine();
                }
            }
        }
    }
}
