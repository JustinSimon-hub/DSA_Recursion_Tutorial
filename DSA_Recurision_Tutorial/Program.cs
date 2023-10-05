MinusByOne(5);

void MinusByOne(int n)
{
    //THis is base case , prevents stack overflow
    if(n != 0)
    {
        MinusByOne(n - 1);
    }
    //ALl these functions are going to execute, store state , THEN they are going to minus 
    Console.WriteLine("Call:" + n);
}


//factorial question : Always think recursion, this is what iterative factorial looks like NOT recursive
IterativeFactorial(5);
int IterativeFactorial(int num)
{
   
    int factorial = 1;

    for(int i = 1; i <= num; i++)
    {
        factorial = factorial * i;
    }
    return factorial;
}
//1 x 1;
//1 x 2;
// 1 x 2 x 3;
//1 x 2 x 3 x 4;

Console.WriteLine(RecursiveFactorial(5));

int RecursiveFactorial(int num)
{
    //base case
    if(num == 0)
    {
        return 1;
    }
    return num * RecursiveFactorial(num - 1);
    
}


