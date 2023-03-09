//Упорядочить по возрастанию строки в двумерном массиве
Console.WriteLine("Введите кол-во элементов по горизонтали в массиве:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во элементов по вертикали в массиве:");
int n = Convert.ToInt32(Console.ReadLine());
int [ , ] mas = new int [m,n];
Random rnd = new Random();
for (int count1 = 0; count1 < m; count1++)
{
    for (int count2 = 0; count2 < n; count2++)
    {
        mas[count1,count2] = rnd.Next(-15, 15);
        Console.Write(" " + mas[count1,count2] + " ");
    }
    Console.WriteLine();
}

int m1 = mas.GetUpperBound(0) + 1;
int n1 = mas.Length / m1;
Console.WriteLine("m1 = " + m1);
Console.WriteLine("n1 = " + n1);
int buf = 0;
int count5 = 0;
for (int count3 = 0; count3 < m1; count3++)
{
   // Console.WriteLine("count3 = " + count3);
    for (int count4 = 0; count4 < (n1 - 1); count4++)
    {
        //Console.WriteLine("count4 = " + count4);
        count5 = 0;
        do 
        {
           // Console.WriteLine("count5 = " + count5);
            if (mas [count3,count5] > mas [count3,count5+1])
            {
                buf = mas [count3,count5];
                mas [count3,count5] = mas [count3,count5+1];
                mas [count3,count5+1] = buf;
            }
            count5++;
        }
        while (count5 < (n1-1));
        //Console.WriteLine("Выход из третьего цикла ");
    }
}
Console.WriteLine();
for (int count1 = 0; count1 < m; count1++)
{
    for (int count2 = 0; count2 < n; count2++)
    {
        //mas[count1,count2] = rnd.Next(-15, 15);
        Console.Write(" " + mas[count1,count2] + " ");
    }
    Console.WriteLine();
}

