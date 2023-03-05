
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