// See https://aka.ms/new-console-template for more information
string[] favFood = {"culurgiones", "seadas", "pizza", "shushi", "kebab", "lasagne"};

Console.WriteLine("ho " + favFood.Length + " cibi preferiti");
Console.WriteLine("e sono:");
for (int i = 0; i < favFood.Length; i++)
{
    Console.WriteLine(favFood[i]);
}
Console.WriteLine("quello che preferisco di piu' e' " + favFood[0]);
Console.WriteLine("quello che preferisco di meno e' " + favFood[favFood.Length-1]);
