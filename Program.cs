// See https://aka.ms/new-console-template for more information
string[] favFood = {"culurgiones", "seadas", "pizza", "sushi", "kebab"};


Console.WriteLine("inserisci il tuo cibo preferito:");

string userFood = Console.ReadLine();
Random rnd = new Random();
string pcFood = favFood[rnd.Next(0, favFood.Length)];

while (!favFood.Contains(userFood))
{
    Console.WriteLine("il cibo non era tra i preferiti, riprova\n");
    userFood = Console.ReadLine();
    Console.WriteLine();
}

Console.WriteLine("i cibi preferiti sono " + favFood.Length + ":\n");

for (int i = 0; i < favFood.Length; i++)
{
    if (favFood[i] == userFood && favFood[i] == pcFood){
        Console.WriteLine(favFood[i] + " abbiamo gli stessi gusti\n");
    }else if (favFood[i] == userFood)
    {
        Console.WriteLine(favFood[i] + " il tuo preferito\n");
    }else if (favFood[i] == pcFood)
    {
        Console.WriteLine(favFood[i] + " il mio preferito\n");
    }
    else
    {
        Console.WriteLine(favFood[i] + "\n");
    }
}

Console.WriteLine("quello che preferisco di piu' e' " + favFood[0] + "\n");

Console.WriteLine("quello che preferisco di meno e' " + favFood[favFood.Length - 1] + "\n");

int halfValue = favFood.Length / 2;

if (favFood.Length % 2 == 0)
{
    Console.WriteLine("i cibi a meta' classifica sono: " + favFood[halfValue - 1] + " e " + favFood[halfValue]);
}
else
{
    Console.WriteLine("il cibo a meta' classifica e' " + favFood[halfValue]);
}