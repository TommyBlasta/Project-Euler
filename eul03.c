#include <stdio.h>
#include <stdlib.h>
int najdi_delitel(long long int number)
{
    for(int counter=2;counter!=number;counter++)
    {
         if(counter==number)
        {
            continue;
        }

        else
        {
            if(number%counter==0)
            {
                return counter;
            }
        }
    }
    return 0;
}
int is_prime(long long int number)
{
    //int zbytek=0;
    for(long long int counter=2;counter!=number;counter++)
    {
        if(counter==number)
        {
            continue;
        }

        else
        {
            if(number%counter==0)
            {
                return 0;
            }
        }
    }
    return 1;
    /*if(0==(number%2+number%3+number%4+number%5+number%6+number%7+number%8+number%9+number%10))
    {
        return 1;
    }
    else
    {
        return 0;
    }*/
}
long long int zadani=600851475143;
long long int prubeh;
int *ptr_nums=NULL;
int pocet_nums=0;
int main()
{
    /*The prime factors of 13195 are 5, 7, 13 and 29.

What is the largest prime factor of the number 600851475143 ?*/
    //printf("Hello world!\n");
    /*for(int counter=2;counter<1000;counter++)
    {
        if(is_prime(counter))
        {
            printf("%d, ", counter);
        }
    }*/

    while(!is_prime(zadani))
    {
        printf("Delitel je: %d \n",najdi_delitel(zadani));
        //vytvor nebo rozsir pamet o jeden int
        //ptr_nums=(int*)realloc(ptr_nums,sizeof(int));
        //do volneho pole dej delitele, kterym se bude delit
        //ptr_nums[pocet_nums]=najdi_delitel(zadani);
        //vydel soucasne cislo delitelem
        zadani=zadani/najdi_delitel(zadani);
        printf("Posledni cislo je:%I64d\n",zadani);
    }
    free(ptr_nums);
    return 0;
}
