namespace APBD_s24192;

public class Wypożyczenie
{
    private DateTime dataWypożyczenia;
    private DateTime dataZakończeniaWypożyczenia;
    private Użytkownik najemca;
    private Sprzęt sprzęt;
    private bool czyTerminowyZwrot;

    public Wypożyczenie(DateTime dataWypożyczenia, DateTime dataZakończeniaWypożyczenia, Użytkownik najemca, Sprzęt sprzęt)
    {
        this.dataWypożyczenia = dataWypożyczenia;
        dataZakończeniaWypożyczenia = dataZakończeniaWypożyczenia;
        this.najemca = najemca;
        this.sprzęt = sprzęt;
    }

    public double czasWypożyczenia()
    {
        return (dataWypożyczenia - dataZakończeniaWypożyczenia).TotalDays;
    }

    public override string ToString()
    {
        return " " + najemca + " " + sprzęt + " Czas wypożyczenia: " + czasWypożyczenia();
    }
}