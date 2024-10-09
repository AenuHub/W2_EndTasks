
// 1- print sth to the console
Console.WriteLine("Hello");
Console.WriteLine("How are you?");
Console.WriteLine("I'm fine");
Console.WriteLine("How about you?");
Console.WriteLine(); // print an empty line

// 2- assign 2 variables, then print them
int a = 5;
string b = "Sam";
Console.WriteLine($"{b} is {a} years old");
Console.WriteLine(); // print an empty line

// 3- assign a random number, then print it
Random rand = new Random();
int c = rand.Next(1, 100);
Console.WriteLine(c);
Console.WriteLine(); // print an empty line

// 4- assign a random number, then print remainder of division by 3
int d = rand.Next(1, 100);
Console.WriteLine($"{d} % 3 = {d % 3}");
Console.WriteLine(); // print an empty line

// 5- ask user his age, print + if older than 18, print - if younger
Console.Write("How old are you?: ");
int age;
bool result = int.TryParse(Console.ReadLine(), out age);
if (age >= 18)
{
    Console.WriteLine("+");
}
else
{
    Console.WriteLine("-");
}
Console.WriteLine(); // print an empty line

// 6- print 10 times

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Sen Vodafone gibi anı yaşarken, ben Turkcell gibi seni her yerde çekemem");
}
Console.WriteLine(); // print an empty line

// 7- get 2 user inputs and swap them
Console.Write("Give me name of a famous person: ");
string famous1 = Console.ReadLine();
Console.Write("Give me another one: ");
string famous2 = Console.ReadLine();

string temp = famous1;
famous1 = famous2;
famous2 = temp;

Console.WriteLine($"{famous1} {famous2} are swapped");
Console.WriteLine(); // print an empty line

// 8- create a method with no return value
void NotReturnValue()
{
    Console.WriteLine("I'm not returning any value, I don't have any return type. Do not try to assign me to a variable");
}
Console.WriteLine(); // print an empty line

// 9- method takes two number and returns their sum
int SumTwoNum(int num1,  int num2)
{
    return num1 + num2;
}

// 10- method takes True/False input, returns a string
string BoolMethod(bool value)
{
    return value ? "True" : "False";
}

// 11- method takes 3 numbers, returns max
int MaxAge(int age1,  int age2, int age3)
{
    int max = age1;
    if (age2 > max)
    {
        max = age2;
    }
    if (age3 > max)
    {
        max = age3;
    }
    return max;
}

// 12- method takes infinite number from user, print and return max
int MaxAll(List<int> list)
{
    int max = list[0];
    for (int i = 0; i < list.Count; i++)
    {
        if (list[i] > max)
        {
            max = list[i];
        }
    }
    Console.WriteLine($"Max is {max}");
    return max;
}

// 13- method swaps given two strings
void SwapNames(string name1,  string name2)
{
    string temp = name1;
    name1 = name2;
    name2 = temp;

    Console.WriteLine($"{name1} {name2} are swapped");
}

// 14- method takes a number, returns if its odd or even
string OddOrEven(int num)
{
    return num % 2 == 0 ? "Even" : "Odd";
}

// 15- method calculates road with given speed and time
int CalcRoad(int speed, int time)
{
    return speed * time;
}

// 16- method takes diameter, returns area of circle
double CircleArea(double r)
{
    return Math.PI * r * r;
}

// 17- take given string, make it all lower case and upper case
string sample = "Zaman bir GeRi Sayim";
Console.WriteLine(sample.ToLower());
Console.WriteLine(sample.ToUpper());
Console.WriteLine(); // print an empty line

// 18- take a string with empty spaces, trim spaces
string str = "  Selamlar  ";
string fixedStr = str.Trim();
