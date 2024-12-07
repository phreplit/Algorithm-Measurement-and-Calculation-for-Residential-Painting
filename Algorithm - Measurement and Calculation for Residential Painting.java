
//  Author: PHNO - Technologist | Postgraduate
//  Release Date: 29/11/2024
//  Version: 0.0.0.2v
//  Replit: @PHNO, @PHREPLIT
//  E-mail: phreplit@gmail.com

// Algorithm: Measurement and Calculation for Residential Painting, algorithm built in c, built for professionals in the area.

import java.io.IOException;
import java.util.Scanner; // import lib

public class Main {

public static void main(String[] args) throws IOException, InterruptedException {

loop: // choice Menu
while (true) {

	System.out.println("\n");
	System.out.println("\n");
	System.out.println(" Measurement and Calculation for Residential Painting ");
	System.out.println("");
	System.out.println("");
	System.out.println("1. Calculate Square Meter of a Wall");
	System.out.println("2. Calculate Quantity of Cans per M²");
	System.out.println("3. Calculate Quantity of Coats per Can(s)");
	System.out.println("4. Calculate Quantity of Coats per M²");
	System.out.println("5. Exit");
	System.out.println("");
	System.out.println("[8] Info");
	System.out.println("\n[9] About "); // about
  
  System.out.println("\nEnter your choice: ");

Scanner scanner = new Scanner(System.in);

int choice = scanner.nextInt();

try {
  
switch (choice) {
  case 1:
    System.out.println("\nEnter the height of the wall: "); 
    int v1 = scanner.nextInt();
    System.out.println("\nEnter the wall width: "); 
    int v2 = scanner.nextInt();
    int result = (v1 * v2); 
    System.out.println("\n");
    System.out.println("\nThe wall is " + result + " square meters."); 
    Scanner scanner1 = new Scanner(System.in);
    System.out.println("\nPress enter to return to the menu...\n");
    String enter = scanner1.nextLine();
    clear(); 
    break;
  case 2:
    int v4 = 360; // amount of paint per 1 square meter
    int qtdtinta = 3600; // 1 can has 3600ml (3.6)
    System.out.println("\nEnter how many square meters the wall has: ");  
    int v3 = scanner.nextInt(); // square meters
    System.out.println("\n");
    int resultado = (v3 * v4); // amount of paint per (n) so many m
    int resultado2 = (resultado / qtdtinta); // amount of cans
    System.out.println("\nThe amount of paint to paint " + (v3) + " M² is " + (resultado) + " milliliter(s) and the amount of can(s) is " + (resultado2) + " can(s).");
    Scanner scanner2 = new Scanner(System.in);
    System.out.println("\nPress enter to return to the menu...\n");
    String enter2 = scanner2.nextLine();
    clear(); 
    break;
  case 3:
    int lata1 = 3600; // 1 can of paint
    int mq1 = 360; // one square meter
    int v6 = 3; // 3600ml(3.6) divided by 3 will be 1200ml equivalent to 3 coats
    System.out.println("\nEnter the amount of paint cans obtained per M²: ");  
    int v5 = scanner.nextInt();
    System.out.println("\n");
    int result2 = (v5 * v6); // coat
    int calcqtdlitro = (v5 * lata1); // amount of paint
    int calcmq = (calcqtdlitro / mq1); // square meter
    System.out.println("\nThe number of coats per " + (v5) + " can(s) of paint will be " + (result2) + " coat(s).");
    Scanner scanner3 = new Scanner(System.in);
    System.out.println("\nPress enter to return to the menu...\n");
    String enter3 = scanner3.nextLine();
    clear();
  break;
  case 4:
    int lata01 = 3600; // 1 can of paint
    int mq01 = 360; // one square meter  
    int v8 = 3; // 3600ml(3.6) divided by 3 will be 1200ml equivalent to 3 coats
    System.out.println("\nEnter the amount of paint cans obtained per M²: ");   
    int v7 = scanner.nextInt();
    System.out.println("\n");
    int result3 = (v7 * v8); // coat
    int calcqtdlitro01 = (v7 * lata01); // amount of paint
    int calcmq01 = (calcqtdlitro01 / mq01); // square meter
    System.out.println("\nThe number of coats to paint " + (calcmq01) + " square meters will be " + (result3) + " coat(s).");
    Scanner scanner4 = new Scanner(System.in);
    System.out.println("\nPress enter to return to the menu...\n");
    String enter4 = scanner4.nextLine();
    clear(); 
  break;
  case 5:
    System.out.println("\n Finished Algorithm! ");
  break loop;
  case 8:
  clear();
  System.out.println("\n");
  System.out.println("Info");
  System.out.println("");
  System.out.println("To Calculate Painting with Undiluted Paint:");
  System.out.println("Taking a example on a 3.6L paint can and based on a wall with (H 2.70 meters x W 3.70 meters) we have that H x W = to 10M², ");
  System.out.println("and then we have that 1 can with 3600ml of paint divided by 10 will give 360ml for each 1M², this will be the standard for the calculation 360ml = 1M², ");
  System.out.println("so, any (N) square meters x 360ml = (N) liters of paint and this result divided by 3600ml will be equal to (N) number of cans of paint.");
  System.out.println("");
  System.out.println("To calculate one coat: ");
  System.out.println("To paint one coat we have that a paint tray has 1000ml as a reference per coat, and a can of paint has 3600ml so we have that one can has 1200ml per coat since 1200ml vs 3 = 3600ml (3.6L). ");
  System.out.println("One coat is equivalent to a complete painting of a wall. Generally it is necessary to paint two to three coats.");
  System.out.println("");
  System.out.println("Important information: ");
  System.out.println("");
  System.out.println("This algorithm was built with integer variables so it does not accept numbers with commas e.g.: 2.90 meters change to 3 meters.");
  System.out.println("This algorithm was built in Java and by default always requires that its syntax are always correct for its correct compilation in the console.");
  System.out.println("");
  Scanner scanner7 = new Scanner(System.in);
  System.out.println("\nPress enter to return to the menu...\n");
  String enter7 = scanner7.nextLine();
  clear();
  break;
  case 9:
  clear();
  System.out.println("\n");
  System.out.println("Algorithm: Measurement and Calculation for Residential Painting");
  System.out.println("");
  System.out.println("Author: PHNO");
  System.out.println("Release Date: 29/11/2024");
  System.out.println("Version: 0.0.0.2v");
  System.out.println("Replit: @PHNO, @PHREPLIT");
  System.out.println("E-mail: phreplit@gmail.com");
  System.out.println("");
  Scanner scanner8 = new Scanner(System.in);
  System.out.println("\nPress enter to return to the menu...\n");
  String enter8 = scanner8.nextLine();
  clear();
  break;
  default:
    Scanner scanner9 = new Scanner(System.in);
    System.out.println("\n Error, choose again. ");
    System.out.println("\nPress enter to return to the menu...\n");
    String enter9 = scanner9.nextLine();
    clear();
    }
  } catch (Exception e) {
  Scanner scanner9 = new Scanner(System.in);
  System.out.println("\nError, system failure!");
  System.out.println("\nPress enter to return to the menu...\n");
  String enter9 = scanner9.nextLine();
  clear();
  }            
}
}
public static void clear() {
     System.out.print("\033[H\033[2J"); // clear screen
     System.out.flush();
}
}