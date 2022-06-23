// See https://aka.ms/new-console-template for more information
string[] favFood = {"culurgiones", "seadas", "pizza", "shushi", "kebab"};

Console.WriteLine("ho " + favFood.Length + " cibi preferiti");
Console.WriteLine("e sono:");

for (int i = 0; i < favFood.Length; i++)
{
    Console.WriteLine(favFood[i]);
}

Console.WriteLine("quello che preferisco di piu' e' " + favFood[0]);
Console.WriteLine("quello che preferisco di meno e' " + favFood[favFood.Length-1]);

int halfValue = favFood.Length / 2;

if(favFood.Length % 2 == 0)
{
    Console.WriteLine("i cibi a meta' classifica sono: " + favFood[halfValue-1] + " e " + favFood[halfValue]);
}else
{
    Console.WriteLine("il cibo a meta' classifica e' " + favFood[halfValue]);
}