#include <stdio.h>
#include <stdlib.h>
int cislo1=1;
int cislo2=2;
int cislo3;
int soucet=2;
int main()
{
	/*Each new term in the Fibonacci sequence is generated by adding the previous two terms.
	By starting with 1 and 2, the first 10 terms will be:

1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...

By considering the terms in the Fibonacci sequence whose values do not exceed four million,
 find the sum of the even-valued terms.*/
	//todo create const for max value
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
