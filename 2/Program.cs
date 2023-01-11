using _2;

int n = int.Parse(Console.ReadLine());
int i = 0;

while (i < n)
{
    string str = Console.ReadLine();

    Generic<string> currentString = new Generic<string>(str);
    Console.WriteLine($"{currentString}");
    i++;
}