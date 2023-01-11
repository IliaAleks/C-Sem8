//Task 54
Console.WriteLine("Task 54");
int [,] createMassiv()
{
    Console.WriteLine("Исходный двухмерный массив:");
    Random rnNum= new Random();
    int [,] newMas=new int [5, 5];
        for (int i=0; i<5; i++)
        {
            for (int j=0; j<5; j++)
            {
                newMas[i,j]=rnNum.Next(0, 100);
                Console.Write($"{newMas[i,j]} ");
            }
            Console.WriteLine();
        }
        return newMas;
}

int [,] sortMas(int [,] masin)
{
    for (int i=0; i<masin.GetLength(0); i++)
    {
        for (int j=0; j<masin.GetLength(1); j++)
        {
            // if (masin[i,j+1]>masin[i,j])
            // {
            //     int numb =  masin[i,j];
            //    masin[i,j]= masin[i,j+1];
            //     masin[i,j+1]=numb;
            //     j=0;
            // }
        }
    }
    return masin;
}

int [,] masivUse=createMassiv();
sortMas(masivUse);