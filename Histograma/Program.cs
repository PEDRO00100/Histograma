int[,] histograma = new int[10, 10];
int i, i2, h;
for (i = 0; i < 10; i++)
{
    for (i2 = 0; i2 < 10; i2++)
    {
        Random rdm = new Random();
        histograma[i, i2] = rdm.Next(1, 11);
        Console.Write("  {0}\t",histograma[i,i2]);
    }
    Console.WriteLine("\n");
}
#region Histograma
//1
h = 1;
Console.Write("1.-\t");
for (i = 0; i < 10; i++)
{
    for (i2 = 0; i2 < 10; i2++)
    {

        if (histograma[i, i2] == 1)
        {
            Console.Write("=");
            h++;
        }
    }
}
Console.Write(" {0}\n", h - 1);
//2
h = 1;
Console.Write("2.-\t");
for (i = 0; i < 10; i++)
{
    for (i2 = 0; i2 < 10; i2++)
    {

        if (histograma[i, i2] == 2)
        {
            Console.Write("=");
            h++;
        }
    }
}
Console.Write(" {0}\n", h - 1);
//3
h = 1;
Console.Write("3.-\t");
for (i = 0; i < 10; i++)
{
    for (i2 = 0; i2 < 10; i2++)
    {

        if (histograma[i, i2] == 3)
        {
            Console.Write("=");
            h++;
        }
    }
}
Console.Write(" {0}\n", h - 1);
//4
h = 1;
Console.Write("4.-\t");
for (i = 0; i < 10; i++)
{
    for (i2 = 0; i2 < 10; i2++)
    {

        if (histograma[i, i2] == 4)
        {
            Console.Write("=");
            h++;
        }
    }
}
Console.Write(" {0}\n", h - 1);
//5
h = 1;
Console.Write("5.-\t");
for (i = 0; i < 10; i++)
{
    for (i2 = 0; i2 < 10; i2++)
    {

        if (histograma[i, i2] == 5)
        {
            Console.Write("=");
            h++;
        }
    }
}
Console.Write(" {0}\n", h - 1);
//6
h = 1;
Console.Write("6.-\t");
for (i = 0; i < 10; i++)
{
    for (i2 = 0; i2 < 10; i2++)
    {

        if (histograma[i, i2] == 6)
        {
            Console.Write("=");
            h++;
        }
    }
}
Console.Write(" {0}\n", h - 1);
//7
h = 1;
Console.Write("7.-\t");
for (i = 0; i < 10; i++)
{
    for (i2 = 0; i2 < 10; i2++)
    {

        if (histograma[i, i2] == 7)
        {
            Console.Write("=");
            h++;
        }
    }
}
Console.Write(" {0}\n", h - 1);
//8
h = 1;
Console.Write("8.-\t");
for (i = 0; i < 10; i++)
{
    for (i2 = 0; i2 < 10; i2++)
    {

        if (histograma[i, i2] == 8)
        {
            Console.Write("=");
            h++;
        }
    }
}
Console.Write(" {0}\n", h - 1);
//9
h = 1;
Console.Write("9.-\t");
for (i = 0; i < 10; i++)
{
    for (i2 = 0; i2 < 10; i2++)
    {

        if (histograma[i, i2] == 9)
        {
            Console.Write("=");
            h++;
        }
    }
}
Console.Write(" {0}\n", h - 1);
//10
h = 1;
Console.Write("10.-\t");
for (i = 0; i < 10; i++)
{
    for (i2 = 0; i2 < 10; i2++)
    {

        if (histograma[i, i2] == 10)
        {
            Console.Write("=");
            h++;
        }
    }
}
Console.Write(" {0}\n", h - 1);
#endregion