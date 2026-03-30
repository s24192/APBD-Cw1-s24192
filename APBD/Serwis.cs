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
            Console.WriteLine("Id sprzętu: "+a.GetId() + " Dostepność: " +a.GetCzyWypożyczonySprzęt());
        }
    }

    public void ListaDostępnegoSprzętu()
    {
        foreach (var a in listaSprzętu.Where(a => a.GetCzyWypożyczonySprzęt()))
        {
            Console.WriteLine("Id sprzętu: "+a.GetId() + " Dostepność: " +a.GetCzyWypożyczonySprzęt());
        }
    }

    public void Listaużytkownikow()
    {
        foreach (var a in listaUżytkowników)
        {
            Console.WriteLine(a.ToString());
        }
    }

    public void dodajUżytkownika(Użytkownik uzy)
    {
        listaUżytkowników.Add(uzy);
    }

    public void rent(Użytkownik najemca, Sprzęt sprzęt, DateTime dataZwrotu)
    {
        if (najemca.getIlośćWypożyczeń() >= najemca.maksWypożyczeń() && sprzęt.GetCzyDostępnySprzęt())
        {
            Console.WriteLine("Limit wynajęć osiągnięty!");
            return;
        }
        var asd = new Wypożyczenie(DateTime.Today,dataZwrotu,najemca,sprzęt);
        najemca.NaliczWypożyczenie();
        listaWypożyczeń.Add(asd);
    }
}