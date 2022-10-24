// зад 52 Устройство для поиска среднего арифметического по каждому столбцу
Console.Clear();
int m=new Random().Next(5,6);
int n=new Random().Next(5,6);
void PrintArray (int[,] array)
    {   for (int i=0;i<array.GetLength(0);i++)
            {   for (int j=0;j<array.GetLength(1);j++)
                    Console.Write(" "+array[i,j]);
            Console.WriteLine();
            }}
int [,] FillArray(int[,] array1)
    {   for (int i1=0;i1<array1.GetLength(0);i1++)
            for (int j1=0;j1<array1.GetLength(1);j1++)
                    array1[i1,j1]=new Random().Next(1,9);
        return array1;}
void EachColumnArithmeticMean(int[,] array2)
    {   for (int j2=0;j2<array2.GetLength(1);j2++)
            {double sum=0;
            for (int i2=0;i2<array2.GetLength(0);i2++)
                sum+=array2[i2,j2];
            Console.WriteLine("Среднее арифметическое "+(j2+1)+" столбца составляет "+"{0:f}", sum/(array2.GetLength(0)));
            }}
int[,] array3=new int [m,n];
Console.WriteLine("Исходный массив");
PrintArray(FillArray(array3));
EachColumnArithmeticMean(array3);