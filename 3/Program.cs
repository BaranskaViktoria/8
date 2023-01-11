using _3;

int n = int.Parse(Console.ReadLine());
int i = 0;

while (i < n)
{
    int number = int.Parse(Console.ReadLine());

    GenericBox2<int> currentInteger = new GenericBox2<int>(number);
    Console.WriteLine($"\n{currentInteger}");
    i++;
}