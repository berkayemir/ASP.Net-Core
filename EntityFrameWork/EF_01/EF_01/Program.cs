using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //ToList metodu ile bölümleri listele
            void BolumleriListele()
            {
                HastaneSabahEntities hastaneSabah = new HastaneSabahEntities();
                var bolumler = hastaneSabah.Bolumler.ToList();
                Console.WriteLine($"Bölüm ID\tBolum Adı");

                foreach (var bolum in bolumler)
                {
                    Console.WriteLine($"{bolum.ID}\t\t{bolum.BolumAd}");
                }
                Console.ReadLine();
            }

            //Where ile sorgulama,Diş Bölümünü getir
            void BolumGetir()
            {
                using (HastaneSabahEntities hastane = new HastaneSabahEntities())
                {
                    //var sonuc = hastane.Bolumler.Where(x => x.BolumAd == "Diş");
                    var sonuc = hastane.Bolumler.Where(x => x.BolumAd.StartsWith("D"));
                    foreach (var item in sonuc)
                    {
                        Console.WriteLine($"Bölüm ID : {item.ID} Bölüm Ad:{item.BolumAd}");
                    }
                    Console.ReadLine();
                }
            }

            //Select ile specific veri çekme
            void DoktorAdListele ()
            {
                using (HastaneSabahEntities hastane = new HastaneSabahEntities())
                {
                    var adlar = hastane.Doktorlar.Select(x => x.AdSoyad);
                    Console.WriteLine($"DoktorAdı");
                    foreach (var ad in adlar)
                    {
                        Console.WriteLine(ad);
                    }
                    Console.ReadLine();
                }
            }

            //Find ile hızlı arama yapma
            void HizliAra()
            {
                using (HastaneSabahEntities hastane = new HastaneSabahEntities())
                {   
                    //Find metodu ilgili tablodaki primary key üzerinden arama yapar
                    //Bu da onu oldukça hızlı hale getirir.
                    Doktorlar doktor = hastane.Doktorlar.Find(4);
                    Console.WriteLine($"Doktor Adı: {doktor.AdSoyad} Bölüm: {doktor.Bolumler.BolumAd}");
                }
                Console.ReadLine();
            }

            //İlk kaydı getirme,ilk Demet Evgar'ı getir
            void IlkKayit()
            {
                using (HastaneSabahEntities hastane = new HastaneSabahEntities()) 
                {
                    Doktorlar doktor = hastane.Doktorlar
                        .Where(x => x.AdSoyad == "Demet Evgar")
                        .First();
                    Console.WriteLine($"Doktor Ad: {doktor.AdSoyad} Bölüm Ad: {doktor.Bolumler.BolumAd}");
                }

                Console.ReadLine();
            }

            //İlk üç doktoru getir
            void IlkUcDoktor()
            {
                using (HastaneSabahEntities hastane = new HastaneSabahEntities())
                {
                    var ilUcDoktor = hastane.Doktorlar.Take(3);
                    foreach (var doktor in ilUcDoktor)
                    {
                        Console.WriteLine($"Doktor Adı: {doktor.AdSoyad}");
                    }
                    Console.ReadLine();

                }
            }

            //Var mı?
            void VarMi()
            {
                using (HastaneSabahEntities hastane=new HastaneSabahEntities())
                {
                    bool sonuc = hastane.Doktorlar.Any(x => x.AdSoyad == "Berkay Evgar");
                    if (sonuc)
                    {
                        Console.WriteLine("Aradığınız doktor var!");
                    }else
                    {
                        Console.WriteLine("Aradığınız doktor yok!");
                    }

                    Console.ReadLine();
                }
            }

            //Uygunluk var mı?
            void UyuyorMu()
            {
                using (HastaneSabahEntities hastane=new HastaneSabahEntities())
                {
                    bool sonuc = hastane.Doktorlar.All(x => x.Bolumler.BolumAd == "Dahiliye");
                    if(sonuc)
                    {
                        Console.WriteLine("Evet,tümü uygun");
                    }
                    else
                    {
                        Console.WriteLine("Hayır uymayanlar var");
                    }
                }
                Console.ReadLine();
            }

            //Ascending sıralama,A'dan Z'ye,küçükten büyüğe
            void SiralaAsc()
            {
                using (HastaneSabahEntities hastane=new HastaneSabahEntities())
                {
                    var siraliDoktorlar = hastane.Doktorlar.OrderBy(x => x.AdSoyad);
                    foreach (var doktor in siraliDoktorlar)
                    {
                        Console.WriteLine($"AdSoyad: {doktor.AdSoyad}");
                    }
                    Console.ReadLine();
                }
            }

            //Descending sıralama,Z'den A'ya,büyükten küçüğe
            void SiralaDes()
            {
                using (HastaneSabahEntities hastane=new HastaneSabahEntities())
                {
                    var TersSiralaDoktor = hastane.Doktorlar.OrderByDescending(x => x.AdSoyad);
                    foreach (var doktor in TersSiralaDoktor)
                    {
                        Console.WriteLine(doktor.AdSoyad);
                    }
                    Console.ReadLine();
                }
            }

            //Son üç doktoru getir
            void SonUcDoktor()
            {
                using (HastaneSabahEntities hastane=new HastaneSabahEntities())
                {
                    var sonUcDoktor = hastane.Doktorlar.OrderByDescending(x => x.ID).Take(3);
                    foreach (var doktor in sonUcDoktor)
                    {
                        Console.WriteLine($"{doktor.AdSoyad}");
                    }
                    Console.Read();
                }
            }

            //Blümlere göre doktor sayisi
            void BolumlereGoreDoktorSayisiGetir()
            {
                using (HastaneSabahEntities hastane=new HastaneSabahEntities())
                {
                    var sonuc = hastane.Doktorlar
                        .GroupBy(x => x.Bolumler.BolumAd)
                        .Select(y => new
                        {
                            name = y.Key,
                            count = y.Count()

                        });
                    Console.WriteLine($"Bölüm\tDoktor Sayisi");
                    foreach (var item in sonuc)
                    {
                        Console.WriteLine($"{item.name}\t{item.count}");
                    }
                    Console.ReadLine();

                }

            }

            //BolumGetir();
            //BolumleriListele();
            //DoktorAdListele();
            //HizliAra();
            //IlkKayit();
            //IlkUcDoktor();
            //VarMi();
            //UyuyorMu();
            //SiralaAsc();
            //SiralaDes
            //SonUcDoktor();
            //BolumlereGoreDoktorSayisiGetir();

        }
    }
}
