#include <stdio.h>
#include <stdlib.h>
/*2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.

What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?*/
int isEvenly(int number,int max_delitel)
{
    for(int a=1;a!=max_delitel+1;a++)
    {
        if(number%a!=0)
        {
            return 0;
        }
    }
    return 1;
}
int main()
{
    int done=0;
    for(int a=20;done!=1;a+=20)
    {
        if(isEvenly(a,20))
        {
            printf("%d",a);
            done=1;
        }

    }
    return 0;
}
