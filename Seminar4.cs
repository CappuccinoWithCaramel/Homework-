
// Exercise 1.

// int Stepen(int A, int B)
// {
//     int step=0;
//     int res=1;
//     while (step < B)
//     {
//         res=res*A;
//         step++;
//     }
//     return res;
// }


// Console.WriteLine("Input A");
// int A=Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input B");
// int B=Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(Stepen(A,B));



// Exercise 2.


// int sum(int num)
// {
//     int ost=0;
//     while (num > 0)
//     {
//     int dig = num % 10;
//     ost= ost+dig;
//     num =num/10;
//     }
//     return ost;
    
// }

// Console.WriteLine("Input number");

// int num= Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(sum(num));


//Exercise 3.


// int[] Array(int size)
// {
//     int i=0;
//     int[] Array= new int[size];
//     for (i=0; i< size; i++)
//     {
//         Array[i] = (Convert.ToInt32(Console.ReadLine()));
//     }
//     return Array;
// }

// void ShowArray(int[] Array)
// {
//     for (int i=0; i< Array.Length; i++)
//     {
//         Console.Write(Array[i] + ", ");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Input size of array");

// int size= Convert.ToInt32(Console.ReadLine());

// int[] myArray = Array(size);

// ShowArray(myArray);
// Array(size);
