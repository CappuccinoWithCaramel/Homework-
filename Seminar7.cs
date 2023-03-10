
//Exercise 1.

// double [,] Create2D(int col, int row, double min, double max)
// {
//     double [,] newarray=new double[row, col];

//     for(int i=0; i<row; i++)
//     {
//         for (int j=0; j<col; j++)
//         {
//             newarray[i,j]=Math.Round (min +new Random().NextDouble()*(max+max),1);
//         }
//     }
//     return newarray;
// }

// void Show2DArray(double[,] array)
// {
//     for (int i=0; i<array.GetLength(0); i++)
//     {
//         for(int j=0; j<array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j]+" ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Input rows value of array");
// int row= Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input columns value of array");
// int col= Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input min value of array");
// double min= Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array");
// double max= Convert.ToInt32(Console.ReadLine());

// double[,] Array= Create2D(col, row,min,max);
// Show2DArray(Array);


//Exercise 2.


// int [,] Create2D(int col, int row, int min, int max)
// {
//     int [,] newarray= new int[row, col];

//     for(int i=0; i<row; i++)
//     {
//         for (int j=0; j<col; j++)
//         {
//             newarray[i,j]= new Random().Next(min,max+1);
//         }
//     }
//     return newarray;
// }

// void Show2DArray(int[,] array)
// {
//     for (int i=0; i<array.GetLength(0); i++)
//     {
//         for(int j=0; j<array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j]+" ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void Element(int[,]newarray,int pos1,int pos2)
// {
//     if(pos1<0 && pos1>newarray.GetLength(0) && pos2<0 && pos2>newarray.GetLength(1))
//     {
//         Console.WriteLine($"Array don't have this element->{newarray[pos1,pos2]}");
//     }
//     else Console.WriteLine($"this number is -> {newarray[pos1,pos2]}");
// }

// Console.WriteLine("Input position 1");
// int pos1=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input position 2");
// int pos2=Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input rows value of array");
// int row= Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input columns value of array");
// int col= Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input min value of array");
// int min= Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array");
// int max= Convert.ToInt32(Console.ReadLine());


// int[,] Array= Create2D(col, row, min, max);
// Show2DArray(Array); 
// Element(Array,pos1,pos2);


//Exercise 3.


// int [,] Create2D(int col, int row, int min, int max)
// {
//     int [,] newarray= new int[row, col];

//     for(int i=0; i<row; i++)
//     {
//         for (int j=0; j<col; j++)
//         {
//             newarray[i,j]= new Random().Next(min,max+1);
//         }
//     }
//     return newarray;
// }

// void Show2DArray(int[,] array)
// {
//     for (int i=0; i<array.GetLength(0); i++)
//     {
//         for(int j=0; j<array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j]+" ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int[,] Arif(int[,]array, int col, int row)
// {
//     for(int j=0; j<col; j++)
//     {
//         double Sum=0;
//         for (int i=0; i<row; i++)
//         {
//             Sum=Sum+array[i,j];
//         }
//         Sum=Sum / col;
//         Console.Write(Sum+", ");
//     }
//     return array;
// }
// Console.WriteLine("Input rows value of array");
// int row= Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input columns value of array");
// int col= Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input min value of array");
// int min= Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array");
// int max= Convert.ToInt32(Console.ReadLine());

// int[,] Array= Create2D(col, row, min, max);
// Show2DArray(Array);
// int[,] NEWARRAY=Arif(Array,row,col);
