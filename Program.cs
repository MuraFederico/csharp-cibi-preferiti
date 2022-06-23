// See https://aka.ms/new-console-template for more information
string[] favFood = {"culurgiones", "seadas", "pizza", "shushi", "kebab"};

Console.WriteLine("ho " + favFood.Length + " cibi preferiti\n");

Console.WriteLine("e sono:\n");

for (int i = 0; i < favFood.Length; i++)
{
    Console.WriteLine(favFood[i] + "\n");
}

Console.WriteLine("quello che preferisco di piu' e' " + favFood[0] + "\n");

Console.WriteLine("quello che preferisco di meno e' " + favFood[favFood.Length-1] + "\n");

int halfValue = favFood.Length / 2;

if(favFood.Length % 2 == 0)
{
    Console.WriteLine("i cibi a meta' classifica sono: " + favFood[halfValue-1] + " e " + favFood[halfValue]);
}else
{
    Console.WriteLine("il cibo a meta' classifica e' " + favFood[halfValue]);
}