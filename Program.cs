// See https://aka.ms/new-console-template for more information

string[] favouriteFood =
{
    "Cannelloni ripieni", "Lasagna", "Parmigiana", "Frittata di pasta", "Pizza", "Sushi"
};

//Lunghezza della classifica

Console.WriteLine(favouriteFood.Length);

//Stampare la classifica con la posizione

for (int i = 0; i < favouriteFood.Length; i++)
{
    Console.WriteLine(favouriteFood[i]);
    Console.WriteLine(i + 1);
};

//Prima posizione

Console.WriteLine(favouriteFood[0]);

//Ultima posizione 

Console.WriteLine(favouriteFood[favouriteFood.Length - 1]);

