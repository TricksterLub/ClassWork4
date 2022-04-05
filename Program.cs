string input = Console.ReadLine();
List<string> temp = new List<string>();
while (input!="stop")
{   
    temp.Add(input);
    input = Console.ReadLine();
}

int [] x = new int[temp.Count];
Console.Clear();
for (int i = 0; i < temp.Count; i++)
{
    int.TryParse(temp[i], out x[i]);
}

for (int i = 0; i < x.Length-1; i++)
{
    for (int j = 0; j<x.Length-1; j++)
    {   if (x[j] > x[j + 1])
        {
            int k;
            k = x[j];
            x[j] = x[j + 1];
            x[j + 1] = k;
        }
    }
}

for (int i = 0; i < x.Length; i++)
{
    if (x[i] < 0)
    {
        Console.WriteLine($"{i + 1}. (-){Math.Abs(x[i])}");
    }
    else if (x[i] != 0)
    {
        Console.WriteLine($"{i + 1}. (+){x[i]}");
    }
    else
    {
        Console.WriteLine($"{i + 1}. {x[i]}");
    }
}


