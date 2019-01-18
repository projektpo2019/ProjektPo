using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProjektPO
{
    [Serializable]
    [XmlInclude(typeof(Zamowienie))]

    public class ZamowieniaDoZrealizowania
    {
        Queue<Zamowienie> kolejkaZamowien;
        int liczbaZamowien;
        
        public Queue<Zamowienie> KolejkaZamowien { get => kolejkaZamowien; set => kolejkaZamowien = value; }
        public int LiczbaZamowien { get => liczbaZamowien; set => liczbaZamowien = value; }

        public ZamowieniaDoZrealizowania()
        {
            kolejkaZamowien = new Queue<Zamowienie>();
            liczbaZamowien = 0;
        }
        public void DodajDoKolejki(Zamowienie z)
        {

            liczbaZamowien++;
            kolejkaZamowien.Enqueue(z);

        }
        public void Realizuj()
        {
            kolejkaZamowien.Dequeue();
            liczbaZamowien--;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("****Kolejka zamówień do zrealizowania****");
            foreach (Zamowienie Z in kolejkaZamowien)
            {
                sb.AppendLine(Z.ToString());
            }
            sb.AppendLine("Liczba zamówień: " + liczbaZamowien);
            return sb.ToString();
        }

        //public void ZapiszXML(string n, ZamowieniaDoZrealizowania z)
        //{
        //    XmlSerializer sr = new XmlSerializer(typeof(ZamowieniaDoZrealizowania));
        //    StreamWriter sw = new StreamWriter(n);
        //    sr.Serialize(sw, z);
        //    sw.Close();

        //}

        //public ZamowieniaDoZrealizowania OdczytajXML(string n)
        //{
        //    ZamowieniaDoZrealizowania kolejkaZamowienOdczytana;
        //    try
        //    {
        //        XmlSerializer sr = new XmlSerializer(typeof(ZamowieniaDoZrealizowania));
        //        TextReader tr = new StreamReader(n);
        //        kolejkaZamowienOdczytana = (ZamowieniaDoZrealizowania)sr.Deserialize(tr);
        //        return kolejkaZamowienOdczytana;
        //    }
        //    catch (FileNotFoundException)
        //    {
        //        Console.WriteLine("Plik nie został odczytany.");
        //    }
        //    return null;
        //}


    }
}
