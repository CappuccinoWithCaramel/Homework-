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

// int[] ReverseArray(int[] array)
// {
//     for (int i=0; i<array.Length/2; i++)
//     {
//         int temp= array[i];
//         array[i]=array[array.Length-i-1];
//         array[array.Length-i-1]=temp;
//     }
//     return array;
// }

// Console.WriteLine("Input size of array");
// int size= Convert.ToInt32(Console.ReadLine());

//  int[] myArray= CreateRandom(size);

// ShowArray(myArray);

// int[] reverse=ReverseArray(myArray);
// ShowArray(reverse);




// bool CheckTriangle(int x, int y, int z)
// {
//     if ((x<y+z) && (y<x+z) && (z<x+y))
//     {
//         return true;
//     }
//     return false; 
// }

// Console.WriteLine("Input X");
// int x=Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input Y");
// int y=Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input Z");
// int z=Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Triangle with sides {x}, {y}, {z} can exist? -> {CheckTriangle(x,y,z)}");








// int[] Fibonacci(int N,int a,int b)// a-> 3  b-> 5
// {
//     int[] array= new int[N];
//     array[0]=a;
//     array[1]=b;
//     for(int i=2; i<array.Length; i++)
//     {
//         array[i]=array[i-1] + array[i-2];

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

// Console.WriteLine("Input array size -> N");
// int N=Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input a");
// int a=Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input b");
// int b=Convert.ToInt32(Console.ReadLine());

//  int[] myArray= Fibonacci(N, a, b);

// ShowArray(myArray);




// void DoubleNumber(int num)
// {
//     string Sum= string.Empty;
//     while(num>0)
//     {
//         Sum=num%2+Sum;
//         num=num/2;
//     }
//     Console.WriteLine(Sum);
// }

// Console.WriteLine("Input num");
// int num=Convert.ToInt32(Console.ReadLine());

// DoubleNumber(num);



//Exercise 1.

//  int[] CreateRandom(int size)
// {
//     int[] array= new int[size];
//     for(int i=0; i< size; i++)
//     {
//         array[i]= Convert.ToInt32(Console.ReadLine());
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

// void MoreThanZero(int[] array)
// {
//     int count=0;
//     for(int i=0; i<array.Length; i++)
//     {
//         if(array[i]>0)
//         {
//             count++;
//         }
//     }
//     Console.WriteLine($"Numbers more than zero is -> {count}");
// }

// Console.WriteLine("Input size of array");
// int size= Convert.ToInt32(Console.ReadLine());


// int[] myArray= CreateRandom(size);

// ShowArray(myArray);

// MoreThanZero(myArray);




//Exercise 2.


// void Peresech(double k1, double b1, double k2, double b2)
// {
//     double x= Math.Round((b2-b1)/ (k1-k2),2);
//     double y= Math.Round(k1*x+b1, 2);
//     if (k1==k2)
//     {
//         Console.WriteLine("Линии не пересекаются");
//     }
//     else
//     {
//         Console.WriteLine($"Линии пересекаются в точке x->{x}, y->{y}");
//     }
// }

// Console.WriteLine("Введите b1");
// double b1=Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Введите k1");
// double k1=Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Введите b2");
// double b2=Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Введите k2");
// double k2=Convert.ToDouble(Console.ReadLine());

// Peresech(k1,b1,k2,b2);