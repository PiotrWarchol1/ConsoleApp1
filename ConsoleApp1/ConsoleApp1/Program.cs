int age = 30;
string name = "Ewa";
char sex = 'W';

if (name == "Ewa" && age == 30)
{
    Console.WriteLine("Ewa lat 30");
}
else if (sex == 'W' && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}

else if (age < 18 && sex == 'W')
{
    Console.WriteLine("Niepełnoletnia kobieta");
}