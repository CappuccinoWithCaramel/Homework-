

// Задача 1. Палиндром

// int Pali(int N)
// {
//     if (N % 10 == N / 10000 && N % 100/ 10== N  % 10000 /  1000)
//     {
//         Console.WriteLine($"Digit {N} is a palindrome");
//     }
//     else
//     {
//         Console.WriteLine($"Number {N} is not a palindrome ");
//     }
//     return N;

// }

// Console.WriteLine("Input number");

// int N=Convert.ToInt32(Console.ReadLine());

// Pali(N);



// Задача 2. 3Д

// double Distance(double xa,double ya, double xb, double yb, double za, double zb)

// {
//     return Math.Round(Math.Sqrt(Math.Pow(xb-xa,2) + Math.Pow(yb-ya,2) + Math.Pow(zb-za,2)), 2);
// }

// Console.WriteLine("Введите xa");
// double xa=Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Введите xb");
// double xb=Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Введите ya");
// double ya=Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Введите yb");
// double yb=Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Введите za");
// double za=Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Введите zb");
// double zb=Convert.ToDouble(Console.ReadLine());

// Console.WriteLine($"Distance between A and B is -> {Distance(xa, ya, xb, yb, za, zb)}");


// Задача 3. Кубы до N


// void Cubes(int N, int cur)
// {
//     cur=1;
//     while (cur <= N)
//         {
//             int num= cur*cur*cur;
//             Console.Write(num +",  ");
//             cur ++;
//         }
// }

// Console.WriteLine("Inpunt number");
// int N=Convert.ToInt32(Console.ReadLine());
// int cur=Convert.ToInt32(1);
// Cubes(N,cur);