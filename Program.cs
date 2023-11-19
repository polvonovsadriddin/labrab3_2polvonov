//вариант 25 сложный уровень



int a = 1;
int s = 0;
int b = a;
while (a > 0)
{
    while (b > 0)
    {

        s = s + b % 10;
        b /= 10;

    }
    if (a % 7 == 0 && s % 7 == 0)
        Console.Write(a);
    a++;
    b++;
}



















































//long x=1;
//double y = x % 10;
//double sum=0;
//while (x!=10000)
//{
//    x /= 10;
//    sum += x%10;

//    Console.WriteLine(sum+" ");

//}