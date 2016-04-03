#include <stdio.h>

//void swap1(int, int);
//void swap2(int *, int *);
void swap3(int &, int &);

void main()
{
	int a = 5;
	int b = 3;
	printf("a = %d", a);
	printf("b = %d", b);
	swap3(a, b);
	printf("a = %d", a);
	printf("b = %d", b);
}
/*void swap1(int a, int b)
{
int c = a;
a = b;
b = c;
}
void swap2(int *a, int *b)
{
int c = *a;
*a = *b;
*b = c;
}*/

void swap3(int &a, int &b)
{
	int c = a;
	a = b;
	b = c;
}
