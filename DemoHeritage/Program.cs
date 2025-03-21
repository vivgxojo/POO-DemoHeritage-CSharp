using DemoHeritage;

Etudiant etudiant = new Etudiant();
etudiant.Etablissement = "Cegep";
etudiant.FirstName = "Alex";
//etudiant.NAS = ... //illégal car NAS est privé
//etudiant.NAM = ... //illégal car NAM est protégé
Etudiant etudiant2 = new Etudiant(1234567, "Bedard", "Joe", "123123123", "BEDJ5664125",
    "Cegep", "Programmation");
Console.WriteLine(etudiant);
Console.WriteLine(etudiant2);
try
{
    Etudiant etudiant3 = new Etudiant(1234567, "Bédard", "Joe", "123123123", "BEDJ5664125",
    "Cegep", "Programmation");
    Console.WriteLine(etudiant3);
}
catch (PersonneException ex)
{
    Console.WriteLine(ex);
    //Console.WriteLine(ex.Message);
}
