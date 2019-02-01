#include <stdio.h>
#include <unistd.h>
int main()
{
for(;;)

{
		
char key [30];

printf("Enter the Key: ");

scanf("%s",&key);

if (strcmp(key, "MrSaturn") == 0)

{

 printf("\nCorrect Key!\n");
 
 sleep(5);
 
 break;
 
}
 
else

{

 printf("\nWrong Key!\n\n");
 printf("Press Any Key to Try Again.\n");
 
 getch();
 
system ("cls");
 
}
 
}

return 0;
}
