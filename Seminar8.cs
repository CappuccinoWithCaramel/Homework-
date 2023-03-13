



// Exercise 1.



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

// int [,] Upor(int [,]newarray,int col,int row)
// {

//     for(int i=0; i<newarray.GetLength(0); i++)
//     {
//         for(int j=1; j<newarray.GetLength(1); j++)
//         {

//             if (newarray[i,j]>newarray[i,j-1])
//             {
//                 int temp=newarray[i,j];
//                 newarray[i,j]=newarray[i,j-1];
//                 newarray[i,j-1]=temp;
//                 j=0;

//             }
//         }
//     }
//     return newarray;
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
// Console.WriteLine();
// int[,] NewArray=Upor(Array,col,row);
// Show2DArray(NewArray);




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

// void MaxRow(int [,]newarray, int row, int col)
// {
//     int MinRow=0;
//     int MinSum=0;
//     for(int i=0; i<newarray.GetLength(0); i++)
//     {
//         int sum=0;
//         for(int j=0; j<newarray.GetLength(1); j++)
//         {
//             sum=sum+newarray[i,j];
//             if(i<=0)
//             {
//                 MinSum=sum;
//             }
//             else
//             {
//                 if(sum<MinSum)
//                 {
//                     MinSum=sum;
//                     MinRow=i;
//                 }
//             }
//         }
//     }
//     Console.WriteLine($"Row with min summ ->{MinRow}");
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
// Console.WriteLine();
// MaxRow(Array,row,col);


//Exercise 3.



// int[,] CreateMatrix(int col, int row, int min, int max)
// {
//     int[,] array = new int[row, col];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {      
//         for (int j = 0; j < array.GetLength(1); j++)
//         {   
//             array[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return array;
// }

// int[,] CreateMatrix2(int col, int row, int min, int max)
// {
//     int[,] array2 = new int[row, col];
//     for (int i = 0; i < array2.GetLength(0); i++)
//     {       
//         for (int j = 0; j < array2.GetLength(1); j++)
//         {   
//             array2[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return array2;
// }

// int[,] ResultMatrix(int[,]array,int[,]array2)
// {
//     int[,] result=new int[row,col];
//     for (int i = 0; i < array2.GetLength(0); i++)
//     {       
//         for (int j = 0; j < array2.GetLength(1); j++)
//         {   
//             for(int k=0; k<array2.GetLength(0); k++)
//             {
//                 result[i,j]+= array[i,k]*array2[k,j];
//             }
//         }
//     }
//     return result;
// }

// void Show2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }



// Console.WriteLine("Input rows value of array");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input columns value of array");
// int col = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input min value of array");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] Array= CreateMatrix(col, row, min, max);
// Show2DArray(Array); 
// Console.WriteLine();
// int[,] Array2=CreateMatrix2(col,row,min,max);
// Show2DArray(Array2);
// Console.WriteLine();
// int[,] Array3=ResultMatrix(Array,Array2);
// Show2DArray(Array3);



//Exercise 4.


// int[,,] CreateMatrix(int col, int row,int dep, int min, int max)
// {
//     int[,,] array = new int[row, col, dep];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {      
//         for (int j = 0; j < array.GetLength(1); j++)
//         {   
//             for(int k=0; k<array.GetLength(0);k++)
//             {
//                 array[i,j,k] = new Random().Next(min, max + 1);
//                 array[i,j,k] = array[i,j,k]+ new Random().Next(1,5);
//             }
//         }
//     }
//     return array;
// }

// void Show2DArray(int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for(int k=0; k<array.GetLength(0); k++)
//             {
//                 Console.Write($"{array[i,j,k]} ({ i},{ j},{ k}) ");
//             }
//             Console.WriteLine();
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Input rows value of array");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input columns value of array");
// int col = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input depth value of array");
// int dep = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input min value of array");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,,] Array= CreateMatrix(col, row,dep, min, max);
// Show2DArray(Array); 

//Exercise 5.


// int[,] SpiralArray(int row, int col)
// {
//     int[,] array= new int[row,col];
//     int i=0;
//     int j=0;
//     int di=0;
//     int dj=1;
//     int cd=0;
//     int temp=0;
//     for(int k=0; k<row*col;k++)
//     {
//         array[i,j]=k+1;
//         if(i+di>row-1 || i+di<0 || j+dj>col-1 || j+dj<0) {cd=1;}
//         else
//         {
//             if(array[i+di,j+dj]!=0)
//             {cd=1;}
//         }
//         if(cd==1)
//         {
//             temp=di;
//             di=dj;
//             dj=-temp;
//             cd=0;
//         }
//         i=i+di;
//         j=j+dj;
//     }
//     return array;


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

// Console.WriteLine("Input rows value of array");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input columns value of array");
// int col = Convert.ToInt32(Console.ReadLine());

// int[,] Array= SpiralArray(col, row);
// Show2DArray(Array); 