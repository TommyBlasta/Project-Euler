#include <stdio.h>
#include <stdlib.h>
int cislo1=1;
int cislo2=2;
int cislo3;
int soucet=2;
int main()
{
    while(cislo1<4000000 && cislo2<4000000 && cislo3<4000000)
    {
        cislo3=cislo1+cislo2;
        if(cislo3%2==0 && cislo3<4000000)
        {
            soucet+=cislo3;
        }
        cislo1=cislo3+cislo2;
        if(cislo1%2==0 && cislo1<4000000)
        {
            soucet+=cislo1;
        }
        cislo2=cislo1+cislo3;
        if(cislo2%2==0 && cislo2<4000000)
        {
            soucet+=cislo2;
        }
    }
    printf("Soucet je:%d\n",soucet);

    return 0;
}
