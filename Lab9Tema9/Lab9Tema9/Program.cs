// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
using static System.Net.Mime.MediaTypeNames;

Console.WriteLine("Hello, World!");
//Scrieti un program care va modela conturi bancare. Un cont bancar poate fi cont de economii,
//cont de investitii sau cont curent si va fi caracterezat de un nume.
//In toate conturile vom putea depune bani (La depunerea banilor soldul curent va crește cu valoarea depusa)
//Din toate conturile vom putea extrage bani(În situatia in care suma ceruta depașește soldul curent, pe ecran va fi afișat un mesaj
//corespunzator iar suma nu va fi extrasa.)
//Toate conturile vor pune la dispozitie descrierea acestora. Descrierea va
//contine toate detaliile relevante ale contului (nume, tip, sold curent, rata dobanzii, ziua termenului de extragere, etc)