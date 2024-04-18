using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hak = 3;

            while (true)
            {

                Console.Write("Lütfen şifrenizi giriniz : ");
                string sifre = Console.ReadLine();

                if (sifre == "1234")
                {
                    Console.Clear();
                    int bakiye = 1200;

                    Console.WriteLine("ATM'ye hoş geldiniz.");
                    Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz");
                    Console.WriteLine("1 - Bakiye sorgula ");
                    Console.WriteLine("2 - Para çekme ");
                    Console.WriteLine("3 - Para yatırma ");
                    Console.WriteLine("4 - Fatura yatırma");
                    Console.WriteLine("5 - Çıkış yapma");
                    string seçim = Console.ReadLine();

                    switch (seçim)
                    {
                        case "1":
                            Console.WriteLine("Bakiyeniz : " + bakiye);break;                          
                        case "2":
                            Console.WriteLine("Bakiyeniz = " + bakiye);
                            Console.Write("Çekmek istediğiniz tutarı giriniz: ");
                            int tutar = Convert.ToInt32(Console.ReadLine());
                            if (tutar % 10 != 0)
                            {
                                Console.WriteLine("Lütfen 10 ve katlarıyla ile işlem yapınız.");
                            }
                            else if (tutar > bakiye)
                            {
                                Console.Write("Yetersiz bakiye.");
                                tutar = Convert.ToInt32(Console.ReadLine());
                            }
                            else
                            {
                                bakiye -= tutar;
                                Console.WriteLine("Yeni bakiyeniz = " + bakiye);
                            }

                            break;
                        case "3":
                            Console.WriteLine("Lütfen yatırmak istediğiniz tutarı giriniz ");
                            int xpara = int.Parse(Console.ReadLine());

                            if (xpara % 10 != 0)
                            {
                                Console.WriteLine("Lütfen 10'un katlarıyla işlem yapınız.");
                            }
                            else
                            {
                                int toplam = bakiye + xpara;
                                Console.WriteLine("Yeni Bakiyeniz={0}", toplam);
                            }
                            break;

                        case "4":
                            int yfatura = 80;
                            Console.WriteLine("Faturanız : " + yfatura);
                            Console.WriteLine("Lütfen bozuk para kullanmayınız.");
                            Console.WriteLine("Parayı yerleştiriniz");

                            int yatırma = int.Parse(Console.ReadLine());
                            int bozukluk = yatırma - yfatura;
                            if (yatırma <= 80)
                            {
                                Console.WriteLine("Yüklediğiniz tutar faturayı ödemeye yetmiyor");

                            }
                            else
                            {
                                Console.WriteLine("İşlem tamamlanmıştır. Lütfen para üstünü almayı unutmayınız. {0}TL", bozukluk);
                            }
                            break;

                        case "5":
                            Console.WriteLine("Çıkış yapılıyor.");
                            break;
                        default:
                          
                            Console.WriteLine("Lütfen geçerli bir sayı giriniz.");
                            Console.WriteLine("Bu 1, 2 ,3 veya 4 sayısı olabilir.");
                            break;
                    }
                }
                else
                {
                    if (hak > 0)
                    {
                        hak -= 1;
                    }
                    if (hak == 2)
                    {
                        Console.Clear();
                        Console.WriteLine("Kullanıcı adı veya şifreyi yanlış girdiniz.");
                    }
                    if (hak == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Kullanıcı adı veya şifreyi yanlış girdiniz.");
                    }
                    if (hak == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Hesabınız, siz banka ile görüştükten sonra erişime açılacaktır.");
                        break;
                    }

                    Console.WriteLine(hak + " hakkınız kaldı ");

                }


            }

        }
    }
}
