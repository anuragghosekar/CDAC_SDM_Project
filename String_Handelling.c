
/*
#include <stdio.h>

int cal_len(char *);
int main()
{
	char a[]="PG-DAC";
	int result;
	result=cal_len(a);
	printf("The length of the string is:%d",result);
	
	return 0;
	
}

int cal_len(char *b)
{
	int len=0;
	int i;
	for(i=0;b[i]!='\0';i++)
	len++;
	
	return len;
}

*/
//
//#include <stdio.h>
//#include<string.h>
//
//int main()
//{
//	char a[]="PG-DAC";
//	char b[]="CDAC ";
//	int result;
//
//	printf("The length of the string is:%d\n",strlen(a));
//	printf("The length of the string is:%d\n",strlen(b));
//	printf("Concatinated string is: %s\n", strcat(b,a));	
//	printf("Reversed string is: %s\n", strrev(b));
//	printf("Copied string: %s\n", strcpy(b,a));
//	printf("Compare string: %d\n",strcmp(a,b));
//	return 0;
//	
//}

#include<stdio.h>
#include<string.h>
void ustrcat(char*, char*);
int main()
{
	char a[]="abc", b[]="xyz";
	char res[]={"pqrstuvw"};
	
	printf("Enter string1:");
	scanf("%s",a);
	printf("Enter string2:");
	scanf("%s",b);
        printf("before concat string is:%s %d\n",a,&a);
   
	ustrcat(a, b);//abcxyz
	printf("Concatinated string is:%s %d\n", a,&a);//abcxyz
		//strcpy(b,a);
	printf("%s\n",a);
	printf("%d\n", sizeof(a));
	printf("%d\n",&a);
	printf("%d\n", strlen(a));
}

void ustrcat(char* p, char* q)
{
	int i;
	for(i=0; *p!='\0';i++)
	{
		p++;
	}
	while(*q!='\0')
	{
		*p=*q;
		p++;
		q++;
	}

	
}




