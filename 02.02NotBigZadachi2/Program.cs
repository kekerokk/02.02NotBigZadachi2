float t1 = 12,t2 = 7,t3;
float T1 = 0.04f,T2 = 1/35f,T3 = 1/12f;

int[] vs = new int[6]{7,5,2,3,9,6};

static int[] BubbleSort(int[] mas)
{
    int temp;
    for (int i = 0; i < mas.Length; i++)
    {
        for (int j = i + 1; j < mas.Length; j++)
        {
            if (mas[i] > mas[j])
            {
                temp = mas[i];
                mas[i] = mas[j];
                mas[j] = temp;
            }
        }
    }
    return mas;
}

Console.WriteLine("Количество колебаний маятника за 12 секунд:");
Console.WriteLine(t1/T1);
Console.WriteLine("\nКоличество колебаний маятника за 7 секунд:");
Console.WriteLine(t2/(T2));
Console.WriteLine("\nВведите время колебания маятника:");
t3 = Convert.ToUInt16(Console.ReadLine());
Console.WriteLine("Время колебания маятника за " + t3 + " :");
Console.WriteLine(t3/(T3));
Console.WriteLine("\nСортировка пузырьком:");


BubbleSort(vs);
for (int i = 0; i < vs.Length; i++)
{
    Console.WriteLine(vs[i]);
}