namespace APBD_s24192;

public abstract class Użytkownik
{
    private static int IdGenerator=0;
    private int id;
    private string imie;
    private string nazwisko;
    private int IlośćWypożyczeń;

    public Użytkownik(string imie, string nazwisko)
    {
        id = ++IdGenerator;
        this.imie = imie;
        this.nazwisko = nazwisko;
    }

    public int who()
    {
        return id;
    }

    public int getIlośćWypożyczeń()
    {
        return IlośćWypożyczeń;
    }

    public int getId()
    {
        return id;
    }

    public void NaliczWypożyczenie()
    {
        IlośćWypożyczeń = IlośćWypożyczeń + 1;
    }

    public override string ToString()
    {
        return this.imie + " " + this.nazwisko +  " " + this.id;
    }

    public abstract int maksWypożyczeń();
}

public class Student : Użytkownik
{
    public Student(string imie, string nazwisko) : base(imie, nazwisko)
    {
    }

    public override int maksWypożyczeń()
    {
        return 2;
    }

}

public class Emplyee : Użytkownik
{
    public Emplyee(string imie, string nazwisko) : base(imie, nazwisko)
    {
    }
    public override int maksWypożyczeń()
    {
        return 5;
    }
    
}