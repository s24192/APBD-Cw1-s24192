namespace APBD_s24192;

public class Serwis
{
    private List<Wypożyczenie> listaWypożyczeń = [];
    private List<Sprzęt> listaSprzętu = [];
    private List<Użytkownik> listaUżytkowników = [];

    public void AddSprzęt(Sprzęt asd)
    {
        listaSprzętu.Add(asd);
    }

    public void ListaSprzętów()
    {
        foreach (var a in listaSprzętu)
        {
            Console.WriteLine("Id sprzętu: "+a.GetId() + " Status wypożyczenia: " +a.GetCzyDostępnySprzęt() + " Status dostępności: " + a.GetCzyWypożyczonySprzęt());
        }
    }

    public void ListaDostępnegoSprzętu()
    {
        foreach (var a in listaSprzętu.Where(a => a.GetCzyDostępnySprzęt()))
        {
            Console.WriteLine("Id sprzętu: "+a.GetId() + " Dostepność: " +a.GetCzyDostępnySprzęt());
        }
    }

    public void dodajUżytkownika(Użytkownik uzy)
    {
        listaUżytkowników.Add(uzy);
    }
    
    public void Listaużytkownikow()
    {
        foreach (var a in listaUżytkowników)
        {
            Console.WriteLine(a.ToString());
        }
    }


    public void rent(Użytkownik najemca, Sprzęt sprzęt, DateTime dataZwrotu)
    {
        if (najemca.getIlośćWypożyczeń() >= najemca.maksWypożyczeń()  )
        {
            Console.WriteLine("Limit wynajęć osiągnięty!");
            return;
        }
        if (sprzęt.GetCzyWypożyczonySprzęt())
        {
            Console.WriteLine("Limit wynajęć osiągnięty!");
            return;
        }

        var asd = new Wypożyczenie(DateTime.Today,dataZwrotu,najemca,sprzęt);
        najemca.NaliczWypożyczenie();
        sprzęt.wypożyczony(true);
        listaWypożyczeń.Add(asd);
    }

    public void listaWypożyczonych()
    {
        foreach (var a in listaWypożyczeń)
        {
            Console.WriteLine(a.ToString());
        }
    }
}