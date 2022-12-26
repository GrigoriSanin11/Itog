String[] znach = new string[7] { "sadf", "adadfs", "afafds", "afsdgwe", "wfwevs", "ar", "a" };
String[] znach1 = new string[znach.Length];


void main(string[] znach, string[] znach1)
{
    int count = 0;
    
    for (int i = 0; i < znach.Length; i++)
    {
    if (znach[i].Length <= 3)
        {
            znach1[count] = znach[i];
            count++;

        }
    }
}

void Print(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

main(znach, znach1);
Print(znach1);

