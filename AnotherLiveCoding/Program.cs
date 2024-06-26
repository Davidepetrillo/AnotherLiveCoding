﻿
using CsharpShop2;

Prodotto Cereali = new Prodotto("Cereali", "Cereali a base di miele e cannella ", 1.99, 17);
Frutta Banana = new Frutta("Banana", "Banane coltivate in Brasile e prodotte in Guatemala", 2, 1.69, 19);
Acqua Lete = new Acqua("Lete", "L’acqua che il tuo corpo vuole", 2.19, 18, 6, 2, "plastica", 6.30, "Appennino meridionale");
Elettrodomestico Lavatrice = new Elettrodomestico("Lavatrice", "Samsung Elettrodomestici WD10T534DBW/S3", 70, 10.5, 1400, 60, 60, 85, "bianco", 679.00, 22);
CiboInScatola Tonno = new CiboInScatola("Tonno", "Nostromo - Tonno Leggero all'Olio di Oliva con -60% di Grassi, Qualità Pinne Gialle, Senza Conservanti", 6, 60, 2.99, 8, "12/09/2023");

Console.WriteLine("Inserisci i litri da bere:");
double litri = double.Parse(Console.ReadLine());


try
{
    Lete.Bevi(litri);
}
catch (ArgumentOutOfRangeException e)
{
    Console.WriteLine("Mi dispiace ma il parametro " + e.ParamName + " ha detto " + e.Message);
} catch (EmptyButtonException e)
{
    Console.WriteLine(e.Message);
}





















/*
Cereali.StampaProdotto();
Banana.StampaProdotto();
Lete.StampaProdotto();
Lavatrice.StampaProdotto();
Tonno.StampaProdotto();

Lete.Bevi(0.2);
Lete.Bevi(0.8);
Lete.Svuota(0.3);
Lete.Riempi(0.5);
Lete.Svuota(0.3);
Lete.Bevi(0.2);
Lete.Riempi(0.4);
*/





/*
Lete.Riempi(0.5);
Lete.Bevi(0.5);
Lete.Svuota(0.5);
Lete.Riempi(0.5);
Lete.Bevi(0.5);
Lete.Riempi(0.5);
Lete.Svuota(2);
*/