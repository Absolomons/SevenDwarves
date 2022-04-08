
using SevenDwarves;

List<IDwarves> dwarvesList = new List<IDwarves>();
Random random = new Random();
Randomizer randomizer = new Randomizer();

int temp = randomizer.Randomize(random);

while (dwarvesList.Count<2)
{
    temp = randomizer.Randomize(random);
    switch (temp)
    {
        case 1:
            if (!(dwarvesList.Any(p => p.GetType() == typeof(Sneezy))))
            {
                dwarvesList.Add(new Sneezy());
            }
            break;

        case 2:
            if (!(dwarvesList.Any(p => p.GetType() == typeof(Happy))))
            {
                dwarvesList.Add(new Happy());
            }

            break;
        case 3:
            if (!(dwarvesList.Any(p => p.GetType() == typeof(Grumpy))))
            {
                dwarvesList.Add(new Grumpy());
            }
            break;
        case 4:
            if (!(dwarvesList.Any(p => p.GetType() == typeof(Sleepy))))
            {
                dwarvesList.Add(new Sleepy());
            }
            break;
    }
}

foreach (IDwarves dwarves in dwarvesList)
{
    Console.WriteLine(dwarves);
}

dwarvesList.ElementAt(1).ReactCallDwarf();

while (dwarvesList.Count < 3)
{
    temp = randomizer.Randomize(random);
    switch (temp)
    {
        case 1:
            if (!(dwarvesList.Any(p => p.GetType() == typeof(Sneezy))))
            {
                dwarvesList.Add(new Sneezy());
            }
            break;

        case 2:
            if (!(dwarvesList.Any(p => p.GetType() == typeof(Happy))))
            {
                dwarvesList.Add(new Happy());
            }

            break;
        case 3:
            if (!(dwarvesList.Any(p => p.GetType() == typeof(Grumpy))))
            {
                dwarvesList.Add(new Grumpy());
            }
            break;
        case 4:
            if (!(dwarvesList.Any(p => p.GetType() == typeof(Sleepy))))
            {
                dwarvesList.Add(new Sleepy());
            }
            break;

    }
}

foreach (IDwarves dwarves in dwarvesList)
{
    Console.WriteLine(dwarves);
}

dwarvesList.ElementAt(2).ReactRemoveDwarf(dwarvesList.ElementAt(0));
IDwarves tempdwarf = dwarvesList.ElementAt(0);

List<IDwarves> deadDwarvesList = new List<IDwarves>();

deadDwarvesList.Add(dwarvesList.ElementAt(0));


dwarvesList.RemoveAt(0);

foreach (IDwarves dwarves in dwarvesList)
{
    Console.WriteLine(dwarves);
}

dwarvesList.ElementAt(1).ReactCallDwarf();

while (dwarvesList.Count < 3)
{
    temp = randomizer.Randomize(random);
    switch (temp)
    {
        case 1:
            if (!(dwarvesList.Any(p => p.GetType() == typeof(Sneezy))) && !(deadDwarvesList.Any(p => p.GetType()==typeof(Sneezy))))
            {
                dwarvesList.Add(new Sneezy());
            }
            break;

        case 2:
            if (!(dwarvesList.Any(p => p.GetType() == typeof(Happy))) && !(deadDwarvesList.Any(p => p.GetType() == typeof(Happy))))
            {
                dwarvesList.Add(new Happy());
            }

            break;
        case 3:
            if (!(dwarvesList.Any(p => p.GetType() == typeof(Grumpy))) && !(deadDwarvesList.Any(p => p.GetType() == typeof(Grumpy))))
            {
                dwarvesList.Add(new Grumpy());
            }
            break;
        case 4:
            if (!(dwarvesList.Any(p => p.GetType() == typeof(Sleepy))) && !(deadDwarvesList.Any(p => p.GetType() == typeof(Sleepy))))
            {
                dwarvesList.Add(new Sleepy());
            }
            break;

    }
}

foreach (IDwarves dwarves in dwarvesList)
{
    Console.WriteLine(dwarves);
}

dwarvesList.ElementAt(2).ReactRemoveDwarf(dwarvesList.ElementAt(0));
dwarvesList.RemoveAt(0);

foreach (IDwarves dwarves in dwarvesList)
{
    Console.WriteLine(dwarves);
}

dwarvesList.ElementAt(1).ReactRemoveDwarf(dwarvesList.ElementAt(0));
dwarvesList.RemoveAt(0);

foreach (IDwarves dwarves in dwarvesList)
{
    Console.WriteLine(dwarves);
}

dwarvesList.ElementAt(0).ReactLastOnList();

Console.WriteLine("\n\n The End");



