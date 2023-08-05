// See https://aka.ms/new-console-template for more information




calisan calisan1 = new calisan();
calisan1.ad = "Alp";
calisan1.soyad = "Dereli";
calisan1.no = 32413;
calisan1.departman = "Insan kaynaklari";

calisan1.calisanbilgileri();

calisan calisan2 = new calisan();
calisan2.ad = "Yusuf Emre";
calisan2.soyad = "Coban";
calisan2.no = 313131;
calisan2.departman = "Satin alim";

calisan2.calisanbilgileri();

class calisan
{
    public string ad;
    public string soyad;
    public int no;
    public string departman;

    public void calisanbilgileri()
    {
        Console.WriteLine("Adi: " +  ad);
        Console.WriteLine("Soyadi: " +  soyad);
        Console.WriteLine("No: " +  no);
        Console.WriteLine("Departmani: " +  departman);
    }
}