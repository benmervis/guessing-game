# guessing-game

#include <stdio.h>
#include <stdlib.h>
#include <time.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char *argv[]) {
	
	int sayi,random;
	srand(time(NULL));
	random=rand()%2+98;
	
	
basla:
	printf("98 ve 100 arasinda bir sayi tahmin ediniz:\n");
	scanf("%d",&sayi);
	
	if(sayi<random)
	{
	printf("yukari\n");
	goto basla;
}
	
	
	else if(sayi>random)
	{
	printf("asagi\n");
	goto basla;
}
	
	else if(sayi==random)
	printf("tebrikler! sayiyi dogru bildiniz.");
	
	
	
	return 0;
}
