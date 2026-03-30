
namespace APBD_s24192;

public class Sprzęt
{
   private static int Counter = 0;
   private bool CzyWypożyczonySprzęt = false;
   private int id;
   private bool czyDostępny = true;

   public Sprzęt()
   {
      id = ++Counter;
   }
   public int GetId()
   {
      return id;
   }

   public void ZmieńDostępność(bool NowyStatus)
   {
      CzyWypożyczonySprzęt = NowyStatus;
   }

   public bool GetCzyDostępnySprzęt()
   {
      return czyDostępny;
   }
   public bool GetCzyWypożyczonySprzęt()
   {
      return CzyWypożyczonySprzęt;
   }

   public void SetCzyDostępnySprzęt(bool status)
   {
      czyDostępny = status;
      CzyWypożyczonySprzęt = !czyDostępny;
   }
   public void wypożyczony(bool status)
   {
      CzyWypożyczonySprzęt = status;
      czyDostępny = !CzyWypożyczonySprzęt;
      
   }

   public override string ToString()
   {
      return  " ID sprzętu: "+id.ToString();
   }
}

public class Laptop: Sprzęt
{
   private string nazwaFirmy;
   private int ilośćRAMu;
   public Laptop(string nazwaFirmy, int ram):base()
   {
      this.nazwaFirmy = nazwaFirmy;
      ilośćRAMu = ram;
   }

}

public class Projektor : Sprzęt
{
   private int pobórMocy;
   private string rozdzielczość;

   public Projektor(int pobórMocy, string rozdzielczość) : base()
   {
      this.pobórMocy = pobórMocy;
      this.rozdzielczość = rozdzielczość;
   }
}

public class Camera : Sprzęt
{
   private int wbudowanaPamięć;
   private string typSoczewki;

   public Camera(int wbudowanaPamięć, string typSocziewki) : base()
   {
      this.wbudowanaPamięć = wbudowanaPamięć;
      this.typSoczewki = typSocziewki;
   }
}
