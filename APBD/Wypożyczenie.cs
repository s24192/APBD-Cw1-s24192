namespace APBD_s24192;

public class Wypożyczenie
{
    private DateTime dataWypożyczenia;
    private DateTime dataZakończeniaWypożyczenia;
    private DateTime dataZwrotu;
    private Użytkownik najemca;
    private Sprzęt sprzęt;

    public Wypożyczenie(DateTime dataWypożyczenia, DateTime dataZakończeniaWypożyczenia,DateTime dataZwrotu, Użytkownik najemca, Sprzęt sprzęt)
    {
        this.dataWypożyczenia = dataWypożyczenia;
        this.dataZakończeniaWypożyczenia = dataZakończeniaWypożyczenia;
        this.najemca = najemca;
        this.sprzęt = sprzęt;
        this.dataZwrotu = dataZwrotu;
    }

    public double czasnaWypożyczenie()
    {
        return (dataZakończeniaWypożyczenia - dataWypożyczenia).TotalDays;
    }

    public bool czyTerminowyZwrot()
    {
        return czasnaWypożyczenie() > (dataZwrotu - dataWypożyczenia).TotalDays;
    }

    public int karaZaOpóźnienie()
    {
        return (int)(dataZwrotu - dataWypożyczenia).TotalDays * 10;
    }

    public override string ToString()
    {
        if (czyTerminowyZwrot())
        {
            return " " + najemca + " " + sprzęt + " Czas wypożyczenia: " + czasnaWypożyczenie() + " Czy zwrócono w terminie: "+czyTerminowyZwrot().ToString();
        }
        else
        {
            return " " + najemca + " " + sprzęt + " Czas wypożyczenia: " + czasnaWypożyczenie() + " Naliczona kara: "+karaZaOpóźnienie().ToString() + " zł";
        }
    }
}