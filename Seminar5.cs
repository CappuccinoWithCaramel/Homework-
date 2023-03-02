  // Exercise 1.
 

//  int[] CreateRandom(int size)
// {
//     int[] array= new int[size];
//     for(int i=0; i< size; i++)
//     {
//         array[i]= new Random().Next(100, 1000);
//     }
//     return array;
// }

// void ShowArray (int[] array)
// {
//     for(int i=0; i< array.Length; i++)
//     {
//         Console.Write(array[i]+" ");
//     }
//     Console.WriteLine();
// }

// int [] Chetn(int [] array)
// {
//     int counter=0;
//     for(int i=0; i<array.Length; i++)
//     {
//         if(array[i]%2==0)
//         {
//             counter++;
//         }
//     }
//     Console.WriteLine(counter);
//     return array;
// }

// Console.WriteLine("Input size of array");
// int size= Convert.ToInt32(Console.ReadLine());

//  int[] myArray= CreateRandom(size);

// ShowArray(myArray);

// myArray= Chetn(myArray);


// Exercise 2.

//  int[] CreateRandom(int size)
// {
//     int[] array= new int[size];
//     for(int i=0; i< size; i++)
//     {
//         array[i]= new Random().Next(-100, 100+1);
//     }
//     return array;
// }

// void ShowArray (int[] array)
// {
//     for(int i=0; i< array.Length; i++)
//     {
//         Console.Write(array[i]+" ");
//     }
//     Console.WriteLine();
// }

// int [] Chetn(int [] array)
// {
//     int sum=0;
//     int i=0;
//     while(i<array.Length)
//     {
//         if(array[i]%2==0)
//         sum= sum+ array[i];
//         i++;
//     }
//     Console.WriteLine(sum);
//     return array;
// }

// Console.WriteLine("Input size of array");
// int size= Convert.ToInt32(Console.ReadLine());

//  int[] myArray= CreateRandom(size);

// ShowArray(myArray);

// myArray= Chetn(myArray);



// Exercise 3.

//  int[] CreateRandom(int size)
// {
//     int[] array= new int[size];
//     for(int i=0; i< size; i++)
//     {
//         array[i]= new Random().Next(1, 100+1);
//     }
//     return array;
// }

// void ShowArray (int[] array)
// {
//     for(int i=0; i< array.Length; i++)
//     {
//         Console.Write(array[i]+" ");
//     }
//     Console.WriteLine();
// }

// int[] FindDiff(int [] array)
// {
//     int i=0;
//     int Min=array[i];
//     int Max=0;
//     for(i=0; i< array.Length; i++)
//     {
//         if(array[i]>Max)
//         {
//             Max=array[i];
//         }
//         if(array[i]<Min)
//         {
//             Min=array[i];
//         }
//     }
//     Console.WriteLine($"Max nuber of array is -> {Max} and Min number of array is -> {Min}");
//     int Diff=Max-Min;
//     Console.WriteLine($"Difference between Max and Min numbers of array is {Diff}");
//     return array;
// }

// Console.WriteLine("Input size of array");
// int size= Convert.ToInt32(Console.ReadLine());

//  int[] myArray= CreateRandom(size);

// ShowArray(myArray);

// myArray= FindDiff(myArray);