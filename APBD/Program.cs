
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

Sprzęt asd = new Laptop("Dell",64);
s1.AddSprzęt(asd);

Sprzęt asdf = new Camera(1000,"Jakaśtam");
s1.AddSprzęt(asdf);

Sprzęt asdzx = new Projektor(400,"Full HD");
s1.AddSprzęt(asd);

Sprzęt asdfcx = new Camera(500,"Full HD");
s1.AddSprzęt(asdf);

s1.rent(test2,asd,new DateTime(2021,12,31));
s1.rent(test2,asd,new DateTime(2021,12,31));
s1.rent(test2,asd,new DateTime(2021,12,31));
s1.rent(test2,asd,new DateTime(2021,12,31));


