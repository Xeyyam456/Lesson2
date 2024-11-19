
//int eded = 12;
//Console.WriteLine(eded);

//double onluqSay = 12.4;
//Console.WriteLine(onluqSay);

//float onluqSay2 = 4.2F;
//Console.WriteLine(onluqSay2);

//string ad = "Xeyyam";
//string soyad = "Elizade";


//decimal eded2 = 12.8m;
//Console.WriteLine(eded2);


//Console.WriteLine(ad +" "+ soyad);


//char symbol = 'A';
//Console.WriteLine(symbol);



//bool cavab = eded < onluqSay;
//Console.WriteLine(cavab);



//5 isci ad soyad  maas yas maasdan 10 faiz vergi tutulacag

//string isci1 = "Elizade Xeyyam";
//string isci2 = "Eliyev Eli";
//string isci3 = "Veliyev Veli";
//string isci4 = "ELizade Tebriz";
//string isci5 = "Elizade Xeyal";


//decimal isci1Maas = 350.90m;
//decimal isci2Maas = 450.50m;
//decimal isci3Maas = 560.80m;
//decimal isci4Maas = 640.60m;
//decimal isci5Maas = 780.60m;

//int age1 = 30;
//int age2 = 20;
//int age3 = 23;
//int age4 = 28;
//int age5 = 29;


//Console.WriteLine("1 ci isci: " + isci1 + ":\n" + "Maasi:  " + isci1Maas + "\n" + "Yasi:   " + age1);
//Console.WriteLine("*************************************");
//Console.WriteLine("2 ci isci: " + isci2 + ":\n" + "Maasi:  " + isci2Maas + "\n" + "Yasi:   " + age2);
//Console.WriteLine("*************************************");
//Console.WriteLine("3 cu isci: " + isci3 + ":\n" + "Maasi:  " + isci3Maas + "\n" + "Yasi:   " + age3);
//Console.WriteLine("*************************************");
//Console.WriteLine("4 cu isci: " + isci4 + ":\n" + "Maasi:  " + isci4Maas + "\n" + "Yasi:   " + age4);
//Console.WriteLine("*************************************");
//Console.WriteLine("5 ci isci: " + isci5 + ":\n" + "Maasi:  " + isci5Maas + "\n" + "Yasi:   " + age5);

//Console.WriteLine("*************************************");

//Console.WriteLine();
//Console.WriteLine();



//double toplamMaas = Convert.ToDouble(isci1Maas + isci2Maas + isci3Maas + isci4Maas + isci5Maas);
//Console.WriteLine("Toplam Maas:            " + toplamMaas);







//decimal vergiTutulanMaas1 = Convert.ToDecimal(isci1Maas * 10 / 100);
//decimal vergiTutulanMaas2 = Convert.ToDecimal(isci2Maas * 10 / 100);
//decimal vergiTutulanMaas3 = Convert.ToDecimal(isci3Maas * 10 / 100);
//decimal vergiTutulanMaas4 = Convert.ToDecimal(isci4Maas * 10 / 100);
//decimal vergiTutulanMaas5 = Convert.ToDecimal(isci5Maas * 10 / 100);


//decimal toplamVergi = vergiTutulanMaas1 + vergiTutulanMaas2 + vergiTutulanMaas3 + vergiTutulanMaas4 + vergiTutulanMaas5;



//Console.WriteLine("Toplam vergi meblegi:   " + toplamVergi);


//Console.WriteLine();
//Console.WriteLine();
//Console.WriteLine("*************************************");





//Console.WriteLine();
//Console.WriteLine();





//task1




decimal a = 55;
decimal b = 99;
decimal c = 52;

decimal toplam = (a + b + c);
decimal cixma = (a - b - c);
decimal vurma = (a * b * c);
decimal bolme = (a / b / c);


Console.WriteLine("        (A) ededi: "+a+"\n" +
                  "        (B) ededi: " + 
        b+ "\n" + "        (C) ededi: " + c);

Console.WriteLine("******************************");


Console.WriteLine("Toplam:            " + toplam);
Console.WriteLine("******************************");

Console.WriteLine("Ferq:             " + cixma);
Console.WriteLine("******************************");

Console.WriteLine("Hasil:             " + vurma);
Console.WriteLine("******************************");
//Fix edilmis eded
var bolme2 = bolme.ToString("0.000");

Console.WriteLine("Qismet:            " + bolme2);





















Console.Read();
