using TPBasesPOO;

livre livre1 = new livre("Super Livre", "Super Auteur", new DateTime(2024,06,07), "AQWKOP");
livre livre2 = new livre("Livre un peu bien", "Auteur un peu bien", new DateTime(2024,08,04), "AUIOPKD");
livre livre3 = new livre("Livre cool", "Auteur Cool", new DateTime(2024, 08, 04), "AUIOPKD");
livre livre4 = new livre("Livre nul", "Auteur nul", new DateTime(2024, 02, 09), "KLGHTY");
livre livre5 = new livre("Livre bof", "Auteur bof", new DateTime(2024, 03, 07), "SONTZT");

user user1 = new user("MOI", "Moimoi", 1, false);
user user2 = new user("LUI", "Luilui", 2, true);
user user3 = new user("EUX", "Euxeux", 3, false);

Console.WriteLine("------ Menu de navigation ------\n");
Console.WriteLine("1. Consulter les livres");
Console.WriteLine("2. Consulter les livres empruntés");
Console.WriteLine("3. Emprunter un livre");
Console.WriteLine("4. Retourner un livre");
Console.WriteLine("5. Consulter les utilisateurs");
Console.WriteLine("6. Ajouter un livre");
Console.WriteLine("7. Supprimer un livre");
Console.WriteLine("8. Ajouter un utilisateur");
Console.WriteLine("9. Supprimer un utilisateur");
Console.WriteLine("10. Quitter");

int choix = int.Parse(Console.ReadLine());

switch(choix)
{
    case 1:
        Console.Write("1");
        break;

    case 2:
        Console.Write("2");
        break;

    case 3:
        Console.Write("3");
        break;

    case 4:
        Console.Write("4");
        break;

    case 5:
        Console.Write("5");
        break;

    case 6:
        Console.Write("6");
        break;

    case 7:
        Console.Write("7");
        break;

    case 8:
        Console.Write("8");
        break;

    case 9:
        Console.Write("9");
        break;

    case 10:
        Console.Write("10");
        break;

}










