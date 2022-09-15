// See https://aka.ms/new-console-template for more information

string[] favouriteFood =
{
    "Cannelloni ripieni", "Lasagna", "Parmigiana", "Frittata di pasta", "Pizza", "Sushi"
};

int arrayLenght = favouriteFood.Length;

//Lunghezza della classifica

Console.WriteLine(arrayLenght);

//Stampare la classifica con la posizione

for (int i = 0; i < arrayLenght; i++)
{
    Console.WriteLine(favouriteFood[i]);
    Console.WriteLine(i + 1);
};

//Prima posizione

Console.WriteLine(favouriteFood[0]);

//Ultima posizione 

Console.WriteLine(favouriteFood[arrayLenght - 1]);

if (arrayLenght % 2 == 0)
{
    Console.WriteLine(favouriteFood[(arrayLenght / 2) - 1]);
    Console.WriteLine(favouriteFood[(arrayLenght / 2)]);
} else
{
    Console.WriteLine(favouriteFood[arrayLenght / 2]);
}

