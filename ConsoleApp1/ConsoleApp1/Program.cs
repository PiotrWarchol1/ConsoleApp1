int number = 454669;
string numberAsString = number.ToString();
char[] letters = numberAsString.ToArray();
Console.WriteLine("W numerze są cyfry:");
int counter0 = 0;
int counter1 = 0;
int counter2 = 0;
int counter3 = 0;
int counter4 = 0;
int counter5 = 0;
int counter6 = 0;
int counter7 = 0;
int counter8 = 0;
int counter9 = 0;


foreach (char l in letters)
{
    if(l == '0')
    {
        counter0++;
    }
    else if (l =='1')
    {
        counter1++;
    }
    else if (l == '2')
    {
        counter2++;
    }
    else if (l == '3')
    {
        counter3++;
    }
    else if (l == '4')
    {
        counter4++;
    }
    else if (l== '5')
    {
        counter5++;
    }
    else if (l == '6')
    {
        counter6++;
    }
    else if (l == '7')
    {
        counter7++;
    }
    else if (l == '8')
    {
        counter8++;
    }
    else if (l == '9')
    {
        counter9++;
    }
}
Console.WriteLine("Cyfry 0 jest" + counter0);
Console.WriteLine("Cyfry 1 jest" + counter1);
Console.WriteLine("Cyfry 2 jest" + counter2);
Console.WriteLine("Cyfry 3 jest" + counter3);
Console.WriteLine("Cyfry 4 jest" + counter4);
Console.WriteLine("Cyfry 5 jest" + counter5);
Console.WriteLine("Cyfry 6 jest" + counter6);
Console.WriteLine("Cyfry 7 jest" + counter7);
Console.WriteLine("Cyfry 8 jest" + counter8);
Console.WriteLine("Cyfry 9 jest" + counter9);