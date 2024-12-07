
//  Author: PHNO - Technologist | Postgraduate
//  Release Date: 29/11/2024
//  Version: 0.0.0.2v
//  Replit: @PHNO, @PHREPLIT
//  E-mail: phreplit@gmail.com

// Algorithm: Measurement and Calculation for Residential Painting, algorithm built in c, built for professionals in the area.

#include <stdio.h> // import lib
#include <stdlib.h> 
#include <math.h> 

int menu(); 
void op1(); // header
void op2(); 
void op3();
void op4();
void op8();
void reset_screen();
int menu_programmer();

int menu() { // Menu Function  
int op, c;

printf("\n Measurement and Calculation for Residential Painting \n");

printf("\n");
printf("\n\t     Menu    \n");
printf("\n");

printf("\n1. Calculate Square Meter of a Wall");
printf("\n2. Calculate Quantity of Cans per M²");
printf("\n3. Calculate Quantity of Coats per Can(s)");
printf("\n4. Calculate Quantity of Coats per M²");
printf("\n5. Exit\n");
printf("\n[8] Info\n");
printf("\n[9] About \n");

printf("\nEnter your choice: "); // option
scanf("%d", &op);

while ((c = getchar()) != '\n' && c != EOF) {
} // clear keyboard buffer.   
return op; 
}

int main() { // Main Function

int op = 0, c;

while (op != -1) { 
op = menu(); 
switch (op) { 
case 1: 
op1(); // function 
break; 
case 2: 
op2(); // function
break; 
case 3: 
op3(); // function
break;
case 4:
op4(); // function
break;
case 5:
printf("\n");
printf("\n Finished Algorithm! \n"); // exit
printf("\n");
return 0;
break;
case 8:
op8(); // function
break;
case 9:
menu_programmer(); // function
break; 
default: 
printf("\n");
printf("Wrong Option!\n");
printf("\n");
//printf("\n");
printf("\nPress enter to return menu...\n");
getchar();
scanf("c\n");
reset_screen();
} 
} 
return 0; 
} 

void op1() { 
int v1;
int v2;
int resultado;
printf("\n");
printf("\nEnter the height of the wall: ");
scanf("%d", &v1, stdin);
printf("\n");
printf("\nEnter the wall width: ");
scanf("%d", &v2, stdin);
resultado = v1 * v2;
printf("\nThe wall is %d square meters.\n", resultado);

printf("\nPress enter to return menu...\n");
getchar();
scanf("c\n");
reset_screen();
return; 
}

void op2() { 
int v1; // square meters
int v2 = 360; // amount of paint per 1 square meter
int resultado; // amount of paint per (n) so many m²
int qtdtinta = 3600; // 1 can has 3600ml (3.6)
int resultado2; // amount of cans
printf("\n");
printf("\nEnter how many square meters the wall has: ");
scanf("%d", &v1, stdin);
printf("\n");
resultado = (v1 * v2);
resultado2 = (resultado / qtdtinta);
printf("\nThe amount of paint to paint %d M² is %d milliliter(s) and the amount of can(s) is %d can(s).\n", v1, resultado, resultado2);

printf("\nPress enter to return menu...\n");
getchar();
scanf("c\n");
reset_screen();
return; 
}

void op3() {
int v1;
int v2 = 3; // 3600ml(3.6) divided by 3 will be 1200ml equivalent to 3 coats
int lata1 = 3600; // 1 can of paint
int resultado; // coat
int calcqtdlitro; // amount of paint
int calcmq; // square meter
int mq1 = 360; // one square meter
printf("\n");
printf("\nEnter the amount of paint cans obtained per M²: ");
scanf("%d", &v1, stdin);
printf("\n");
resultado = (v1 * v2);
calcqtdlitro = (v1 * lata1);
calcmq = (calcqtdlitro / mq1);
printf("\nThe number of coats per %d can(s) of paint will be %d coat(s).\n", v1, resultado);

printf("\nPress enter to return menu...\n");
getchar();
scanf("c\n");
reset_screen();
return; 
}

void op4() {
int v1;
int v2 = 3; // 3600ml(3.6) divided by 3 will be 1200ml equivalent to 3 coats
int lata1 = 3600; // 1 can of paint
int resultado; // coat
int calcqtdlitro; // amount of paint
int calcmq; // square meter
int mq1 = 360; // one square meter
printf("\n");
printf("\nEnter the amount of paint cans obtained per M²: ");
scanf("%d", &v1, stdin);
printf("\n");
resultado = (v1 * v2);
calcqtdlitro = (v1 * lata1);
calcmq = (calcqtdlitro / mq1);
printf("\nThe number of coats to paint % square meters will be %d coat(s).\n", calcmq, resultado);

printf("\nPress enter to return menu...\n");
getchar();
scanf("c\n");
reset_screen();
return; 
}

void op8() {
reset_screen();
printf("\nInfo\n");
printf("\nTo Calculate Painting with Undiluted Paint:\n");
printf("\nTaking a example on a 3.6L paint can and based on a wall with (H 2.70 meters x W 3.70 meters) we have that A x L = a 10M², \n");
printf("\nand then we have that 1 can with 3600ml of paint divided by 10 will give 360ml for each 1M², this will be the standard for the calculation 360ml = 1M², \n");
printf("\nso, any (N) square meters x 360ml = (N) liters of paint and this result divided by 3600ml will be equal to (N) number of cans of paint.\n");
printf("\nTo calculate one coat: \n");
printf("\nTo paint one coat we have that a paint tray has 1000ml as a reference per coat, and a can of paint has 3600ml so we have that one can has 1200ml per coat since 1200ml vs 3 = 3600ml (3.6L). \n");
printf("\nOne coat is equivalent to a complete painting of a wall. Generally it is necessary to paint two to three coats.\n");
printf("\nImportant information: \n");
printf("\nThis algorithm was built with integer variables so it does not accept numbers with commas, e.g.: 2.90 meters change to 3 meters.\n");
printf("\nPress enter to return menu...\n ");
getchar();
scanf("c\n");
reset_screen();
return;
}

void reset_screen(){
system("clear");      // linux
system("tput reset"); // linux
system("Cls"); // windows clear screen
return;
}

int menu_programmer(){
  reset_screen();
  printf("\n Algorithm: Measurement and Calculation for Residential Painting \n");
  printf("\n Author: PHNO ");
  printf("\n Release Date: 29/11/2024 ");
  printf("\n Version: 0.0.0.2v");
  printf("\n Replit: @PHNO, @PHREPLIT");
  printf("\n E-mail: phreplit@gmail.com \n");
  printf("\n Press enter to return menu...\n ");
  getchar();
  scanf("c\n");
  reset_screen();
  return 0;
}
