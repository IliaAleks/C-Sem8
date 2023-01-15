int [,] createMassiv()
{
    Console.WriteLine("Исходный двухмерный массив:");
    Random rnNum= new Random();
    int [,] newMas=new int [5, 5];
        for (int i=0; i<5; i++)
        {
            for (int j=0; j<5; j++)
            {
                newMas[i,j]=rnNum.Next(0, 5);
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
        for (int j=0; j<masin.GetLength(1)-1; j++)
        {
            if (masin[i,j+1]>masin[i,j])
            {
                int numb =  masin[i,j];
               masin[i,j]= masin[i,j+1];
                masin[i,j+1]=numb;
                j=0;
            }
        }
    }
    return masin;
}

void writeMas(int [,] masInWrite)
{
    for (int i=0; i<masInWrite.GetLength(0); i++)
    {
        for (int j=0; j<masInWrite.GetLength(1); j++)
        {
            Console.Write($"{masInWrite[i,j]} ");
        }
    Console.WriteLine();
    }
}

bool repeatNum(int [,,] masInProv, int bufIn)
{
    bool Val=false;
      for (int i=0; i<3; i++)
    {
        for (int j=0; j<3; j++)
        {
            for (int k=0; k<3; k++)
            {
                if (bufIn==masInProv[i,j,k])
                {
                    Val=true;
                    i=2;
                    j=2;
                    k=2;
                } else
                {
                    Val=false;
                } 
            }
        }
    }
    return Val;

}

int [,] compMatrix(int [,] A, int [,] B)
{
    int [,] matrixC=new int [5,5];
    for (int i=0; i<5; i++)
    {
        for (int j=0; j<5; j++)
        {
            for (int k=0; k<5; k++)
            {
                matrixC[i,j]=matrixC[i,j]+A[i,k]*B[k,j];
            }
            
        }
    }
return matrixC;
}

void strMin(int [,] masMin)
{
    int str=0;
    int numStr=0;
    for (int i=0; i<masMin.GetLength(0); i++)
    {
        int minSum=0;
        for (int j=0; j<masMin.GetLength(1); j++)
        {
           minSum=minSum+masMin[i,j];
        }
        if (i==0)
        {
            str=minSum;
        } else
        {
            if (minSum<str)
            {
            numStr=i;
            str=minSum;
            }
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов: {numStr}");
}

int [,,] CreateMatrixTrex()
{
    int [,,] matr3=new int [3,3,3];
    Random rnNum= new Random();
    for (int i=0; i<3; i++)
    {
        for (int j=0; j<3; j++)
        {
            for (int n=0; n<3; n++)
            { int buf=rnNum.Next(10, 99);
            bool prov=repeatNum(matr3, buf);
             if (prov==true)
                {
                    n--;
                } else
                {
                    matr3[i,j,n]=buf;
                }
            }
        }
    }
    return matr3;
}

int [,] createMasSpir()
{
    int [,] mas62=new int [4,4];
    int sizeMas62=mas62.GetLength(0)*mas62.GetLength(1);
    bool nxPLUS=true;
    bool nyPLUS=false;
    bool nxMinus=false;
    bool nyMinus=false;
    int indX=0;
    int indY=0;
    int indRight = 4;
    int indLeft = -1;
    int indHigh = 0;
    int indLow = 4;
    int CountK=2;
while (CountK<sizeMas62+1)
{
    {
        if (nxPLUS & indX<indRight)
        {
            for (int h=indX; h<indRight; h++)
            {
                mas62[indY, h]=CountK;
                CountK++;
                
            }
            nxPLUS=false;
            nyPLUS=true;
            indY++;
            indRight--;
            indX=indRight;
        }
         if (nyPLUS & indY<indLow)
        {
            for (int h=indY; h<indLow; h++)
            {
                mas62[h, indX]=CountK;
                CountK++;
                
            }
            nyPLUS=false;
            nxMinus=true;
            indX--;
            indLow--;
            indY=indLow;
        }
        if (nxMinus & indX>indLeft)
        {
            for (int h=indX; h>indLeft; h--)
            {
                mas62[indY, h]=CountK;
                CountK++;
            }
            nxMinus=false;
            nyMinus=true;
            indY--;
            indLeft++;
            indX=indLeft;
        }
        if (nyMinus & indY>indHigh)
        {
            for (int h=indY; h>indHigh; h--)
            {
                mas62[h, indX]=CountK;
                CountK++;
               
            }
            
            nyMinus=false;
            nxPLUS=true;
            indX++;
            indHigh++;
            indY=indHigh;
        }
    }
}
return  mas62;
}

//Task 54
Console.WriteLine("Task 54");
int [,] masivUse=createMassiv();
int [,] sortMasWork=sortMas(masivUse);
Console.WriteLine("Отсортированный массив: ");
for (int i=0; i<sortMasWork.GetLength(0); i++)
{
    for (int j=0; j<sortMasWork.GetLength(1); j++)
    {
    Console.Write($"{sortMasWork[i,j]} ");
    }
    Console.WriteLine();
}

//Task 56
Console.WriteLine("Task 56");
int [,] mas56=createMassiv();
strMin(mas56);

//Task 58
Console.WriteLine("Task 58");
Console.WriteLine("Матрица А: ");
int [,] matrixA=createMassiv();
Console.WriteLine("Матрица B: ");
int [,] matrixB=createMassiv();

Console.WriteLine("Матрица, получившаяся в результате произведения матриц А и B:");
writeMas(compMatrix(matrixA, matrixB));

//Task 60
Console.WriteLine("Task 60");
int [,,] newMas=CreateMatrixTrex();

for (int i=0; i<3; i++)
{
    for (int j=0; j<3; j++)
    {
        for (int k=0; k<3; k++)
        {
            Console.Write($"{newMas[i,j,k]}({i},{j},{k}) ");
        }
    }
    Console.WriteLine();
}

//Task 62

Console.WriteLine("Task 62");
int [,] mas62Work=createMasSpir();
  for (int i=0; i<mas62Work.GetLength(0); i++)
    {
        for (int j=0; j<mas62Work.GetLength(1); j++)
        {
            Console.Write($"{mas62Work[i,j]} ");
        }
    Console.WriteLine();
    }



// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07