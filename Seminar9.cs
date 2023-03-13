// void ShowNumbers(int N)
// {
//     if(N>=1)
//     {
//         ShowNumbers(N-1);
//         Console.Write(N+" ");
        
//     }
// }

// Console.WriteLine("Input N");
// int N=Convert.ToInt32(Console.ReadLine());

// ShowNumbers(N);



// int SumOfNumbers(int N)
// {
//     if(N>0)
//     {
//         return SumOfNumbers(N/10) + N%10;   
//     }
//     else
//     {
//         return N;
//     }
// }

// Console.WriteLine("Input N");
// int N=Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(SumOfNumbers(N));





// void ShowNumbers(int N, int M)
// {
//     if(N!=M)
//     {
//         if(M<=N)
//         {

//             ShowNumbers(N-1,M);
//             Console.WriteLine(N+" ");
        
//         }
//         else
//         {
//             ShowNumbers(N,M-1);
//             Console.WriteLine(M+" ");
//         }
//     }
//     else
//     {
//         Console.WriteLine(N);
//     }

// }

// Console.WriteLine("Input N");
// int N=Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input N");
// int M=Convert.ToInt32(Console.ReadLine());
// ShowNumbers(N,M);


// int ShowNumbers(int A, int B)
// {
//     if(B!=0)
//     {
//         return ShowNumbers(A,B-1)*A;
//     }
//     else return 1;
// }

// Console.WriteLine("Input A");
// int A=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input B");
// int B=Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(ShowNumbers(A,B));


//Exercise 1.


// void ShowNumbers(int N)
// {
//     if(N!=0)
//     {
        
//         Console.Write(N+" ");
//         ShowNumbers(N-1);
        
//     }
// }

// Console.WriteLine("Input N");
// int N=Convert.ToInt32(Console.ReadLine());

// ShowNumbers(N);


//Exercise 2.



// int ShowNumbers(int A, int B)
// {
//     if(B==1)
//     {
//         return 1;
//     }
//     else
//     {
//         return ShowNumbers(A,B-1)+B;
//     }
// }

// Console.WriteLine("Input A");
// int A=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input B");
// int B=Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(ShowNumbers(A,B));



//Exercise 3.



int Akkerman(int n, int m)
{
   if(n==0)
   {
        return m+1;    
   }
   if(n>0||m==0)
   {
        return Akkerman(n-1,1);
   }
   if(n>0||m>0)
   {
        return Akkerman(n-1,Akkerman(n,m-1));
   }
   else
   {
        return Akkerman(n,m);
   }
}

Console.WriteLine("Input m");
int n=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input n");
int m=Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Akkerman(n,m));