#include <stdio.h>
#include <stdlib.h>
/*If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.

Find the sum of all the multiples of 3 or 5 below 1000.*/
int maximum;
int pricti;
int suma=0;
int main()
{
    for(int control=0;control<1000;control++)
    {
        if(control%5==0 || control%3==0)
        {
            suma=suma+control;
        }
    }
    printf("Je to: %d\n",suma);
    suma=0;
    int x=0,y=0;
    while(x<=1000 || y<=1000)
    {
        if(y<=1000)
        {
            y=y+3;
            suma=suma+y;
        }
        if(x<=1000)
        {
            x=x+5;
            suma=suma+x;
        }

    }
    printf("Je to: %d\n",suma);
    return 0;
}
