// See https://aka.ms/new-console-template for more information

string[] favouriteFood =
{
    "Cannelloni ripieni", "Lasagna", "Parmigiana", "Frittata di pasta", "Pizza", "Sushi"
};

int arrayLength = favouriteFood.Length;

//Lunghezza della classifica

Console.WriteLine($"Lunghezza della classifica: {arrayLength}");

//Stampare la classifica con la posizione

for (int i = 0; i < arrayLength; i++)
{
    //Console.WriteLine(favouriteFood[i]);
    //Console.WriteLine(i + 1);
    Console.WriteLine($"Posizione {i + 1} : {favouriteFood[i]}");
};

//Prima posizione

Console.WriteLine($"Prima posizione: {favouriteFood[0]}");

//Ultima posizione 

Console.WriteLine($"Ultima posizione: {favouriteFood[arrayLength - 1]}");

if (arrayLength % 2 == 0)
{
    //Console.WriteLine(favouriteFood[(arrayLength / 2) - 1]);
    Console.WriteLine($"Cibo a metà classifica : {(favouriteFood[(arrayLength / 2) - 1])}");
    //Console.WriteLine(favouriteFood[(arrayLength / 2)]);
    Console.WriteLine($"Cibo a metà classifica : {(favouriteFood[(arrayLength / 2)])}");
} else
{
    Console.WriteLine($"Cibo a metà classifica : {(favouriteFood[(arrayLength / 2)])}");
}

