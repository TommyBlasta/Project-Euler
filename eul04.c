#include <stdio.h>
#include <stdlib.h>
#include <string.h>

/*A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.

Find the largest palindrome made from the product of two 3-digit numbers.*/
int isPalindrom(int number)
{
    char znaky[200];
    sprintf(znaky,"%d",number);
            //zkontroluj, jestli je palindrom
            for(int c=0;c!=strlen(znaky);c++)
            {
                //porovnej znaky po stranach
                if(znaky[c]==znaky[strlen(znaky)-(c+1)])
                {
                    //pokud se divam na stejny znak
                    if(c>=strlen(znaky)-(c+1))
                    {
                        return 1;
                    }
                    continue;
                }
                //pokud se znaky nerovnaji
                else
                {
                    return 0;
                }
            }
            return 0;
}
int nasobek,nejvetsi=0;
int main()
{
    //stare
    /*puts("zadej cislo");
    scanf("%d",&cislo);
    sprintf(znaky,"%d",cislo);
    printf("zadal jsi cislo dlouhe: %d \n",strlen(znaky));
    for(int a=0;a<strlen(znaky);a++)
    {
        printf("%c",znaky[a]);
    }*/
    //nove reseni
    /*for(int a=999;a>99;a--)
    {
        for(int b=999;b>99;b--)
        {
            nasobek=b*a;
            if(isPalindrom(nasobek) && (nasobek>nejvetsi))
            {
                nejvetsi=nasobek;
                printf("%d x %d \n",a,b);
                printf("%d \n",nasobek);
            }
        }

    }
    printf("Nejvetsi nalezeny je: %d", nejvetsi);*/
    //dle jelintaka
    int a=999,b=999;
    while(a>99 || b>99)
    {
        nasobek=a*b;
        if(isPalindrom(nasobek) && (nasobek>nejvetsi))
            {
                nejvetsi=nasobek;
                printf("%d x %d \n",a,b);
                printf("%d \n",nasobek);
            }
        if(a==b)
        {
            a=999;
            b--;
        }
        else
        {
            a--;
        }
    }
    printf("Nejvetsi nalezeny je: %d", nejvetsi);
    /*if(isPalindrom(925529))
    {
        puts("Je");
    }*/
    return 0;
}
