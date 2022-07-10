using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcusYonetimSistemi.Classes;

namespace UcusYonetimSistemi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Pilot pilot = new Pilot(1, "Ömer", "Özbek", 10);
                YardımcıPilot yardımcıPilot = new YardımcıPilot(1, "Emir", "Özbek", 2);
                Ucak ucak = new Ucak(1, false, Enums.UcakTipi.Airbus, pilot, yardımcıPilot); // Pilotları ucak sınıfına parametre olarak verdik ve ucak tanımlandıgında önceden tanımladıgımız pilotları ucaga atamıs olduk, ucak tiplerini de enum olarak tanımladık ve bizim belirlediğimiz enum degerleri arasından secim yapılmasını sağlamıs olduk.

                HavaAlanı Inis = new HavaAlanı(1, "EsenBoğa"); // Havaalanı sıfınından iniş ve kalkıs havaalanlarını olusturduk
                HavaAlanı Kalkis = new HavaAlanı(2, "Atatürk");

                HavaYoluSirketi sirket = new HavaYoluSirketi(1, "ÖzbekAirLines", ucak); // Havayolu şirketi Id isim ve Ucak tipinde parametreler aldı. Ucak tipinde daha onceden tanımlamamızı yaparken Ucagın tipi- Pilot ve Yardımcı Pilot tanımlamızı yapmıstık
                Ucus ucus = new Ucus(1, DateTime.Now, 10, Inis, Kalkis, sirket);// Ucus da içine iniş- kalkıs zamanları ,İniş-kalkıs hava alanları ve şirket bilgilerini aldı. Şirket bilgileri içinde pilotlar ve ucak bilgilerine sahip oldugu için bütün bilgileri buraya aktarmıs olduk

                List<Ucus> listofUcus = new List<Ucus>(); // ucusu list e ekledik ve artık foreach döngüsü ile istediğimiz bilgilere ulaşabiliriz
                listofUcus.Add(ucus);
                foreach (var item in listofUcus)
                {
                    Console.WriteLine(item.sirket.ucak.pilot.Name); // Ucusun sirketinin ucagının pilotunun ismi
                    Console.WriteLine(item.sirket.Name); // Ucusun sirketinin ismi
                    Console.WriteLine(item.sirket.ucak.CalisirMi); // Ucusun sirketinin ucagı calısır durumda mı
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message); // Ucak calısır durumda olmaz ise (yani CalisirMi false secilirse) burdan Ucusun constractur 'ını olustururken false seçimi yapılırsa fırlat dedigimiz hata mesajı yayınlanacak
            }
           

            
            Console.ReadLine();
        }
    }
}
