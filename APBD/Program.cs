
using APBD_s24192;

var s1 = new Serwis();

Console.WriteLine("Start!");

Użytkownik test1 = new Emplyee("Paweł","testowy");
s1.dodajUżytkownika(test1);
Użytkownik test2 = new Student("Gaweł","testowy");
s1.dodajUżytkownika(test2);
Użytkownik test3 = new Emplyee("asd","testowy");
s1.dodajUżytkownika(test3);
Użytkownik test4 = new Student("zxc","testowy");
s1.dodajUżytkownika(test4);

Sprzęt asd = new Laptop();
s1.AddSprzęt(asd);

Sprzęt asdf = new Camera();
s1.AddSprzęt(asdf);

Sprzęt asdzx = new Projektor();
s1.AddSprzęt(asd);

Sprzęt asdfcx = new Camera();
s1.AddSprzęt(asdf);

s1.rent(test1,asd,new DateTime(2021,12,31));