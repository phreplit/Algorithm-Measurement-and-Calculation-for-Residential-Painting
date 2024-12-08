
''' Author: PHNO - Technologist | Postgraduate
    Release Date: 29/11/2024
    Version: 0.0.0.2v
    Replit: @PHNO, @PHREPLIT
    E-mail: phreplit@gmail.com '''

''' Algorithm: Measurement and Calculation for Residential Painting, algorithm built in python, built for professionals in the area. '''

import os # import lib - os clear
import sys
import json

def reset_text():
    os.system('cls' if os.name=='nt' else 'clear')

op = 0 
while op != -1:
  print('')
  print('Measurement and Calculation for Residential Painting')
  print('')
  print('')
  print('1. Calculate Square Meter of a Wall')
  print('2. Calculate Quantity of Cans per M²')
  print('3. Calculate Quantity of Coats per Can(s)')
  print('4. Calculate Quantity of Coats per M²')
  print('5. Exit')
  print('[8] Info')
  print('[9] About')
  print('')
  op = int(input('Enter with your choice: '))
  if op == 1:
   print('')
   v1 = int(input('Enter the height of the wall:  '))
   print('')
   v2 = int(input('Enter the wall width:  '))
   result = int(v1 * v2)
   print('')
   print('The wall is {} square meters.'.format(result))
   print('')
   print('Press enter to return to the menu...')
   a1 = str(input(''))
   reset_text()
  elif op == 2:
   qtdtinta = int(3600); # 1 can has 3600ml (3.6)
   v4 = int(360) # amount of paint per 1 square meter
   print('')
   v3 = int(input('Enter how many square meters the wall has: ')) # square meters
   print('')
   result2 = int(v3 * v4) # amount of paint per (n) so many m²
   result3 = int(result2 / qtdtinta); # amount of cans
   print('')
   print('The amount of paint to paint {} M² is {} milliliter(s) and the amount of can(s) is {} can(s).'.format(v3,result2,result3))
   print('')
   print('Press enter to return to the menu...')
   a2 = str(input(''))
   reset_text() # clear screen - lib os
  elif op == 3:
   lata1 = int(3600); # 1 can of paint
   mq1 = int(360); # one square meter
   v6 = int(3) # 3600ml(3.6) divided by 3 will be 1200ml equivalent to 3 coats
   print('')
   v5 = int(input('Enter the amount of paint cans obtained per M²: '))
   print('')
   result4 = int(v5 * v6); # coat
   calcqtdlitro = int(v5 * lata1); # amount of paint
   # calcmq = int(calcqtdlitro / mq1); # square meter
   print('')
   print('The number of coats per {} can(s) of paint will be {} coat(s).'.format(v5,result4))
   print('')
   print('Press enter to return to the menu...')
   a3 = str(input(''))
   reset_text() # clear screen - lib os  
  elif op == 4:
   lata1 = int(3600); # 1 can of paint
   mq1 = int(360); # one square meter
   v8 = int(3) # 3600ml(3.6) divided by 3 will be 1200ml equivalent to 3 coats
   print('')
   v7 = int(input('Enter the amount of paint cans obtained per M²: '))
   print('')
   result5 = int(v7 * v8) # coat
   calcqtdlitro = int(v7 * lata1); # amount of paint
   calcmq = int(calcqtdlitro / mq1); # square meter
   print('')
   print('The number of coats to paint {} square meters will be {} coat(s).'.format(calcmq,result5))
   print('')
   print('Press enter to return to the menu...')
   a4 = str(input(''))
   reset_text() # clear screen - lib os   
  elif op == 5:
   print('')
   print('Finished Algorithm!')
   print('')
   break
  elif op == 8:
   reset_text()
   print('')
   print('Info')
   print('')   
   print('To Calculate Painting with Undiluted Paint:')
   print('Taking a example on a 3.6L paint can and based on a wall with (H 2.70 meters x W 3.70 meters) we have that A x L = a 10M², ')
   print('and then we have that 1 can with 3600ml of paint divided by 10 will give 360ml for each 1M², this will be the standard for the calculation 360ml = 1M², ')
   print('so, any (N) square meters x 360ml = (N) liters of paint and this result divided by 3600ml will be equal to (N) number of cans of paint.')
   print('To calculate one coat: ')
   print('To paint one coat we have that a paint tray has 1000ml as a reference per coat, and a can of paint has 3600ml so we have that one can has 1200ml per coat since 1200ml vs 3 = 3600ml (3.6L).')
   print('One coat is equivalent to a complete painting of a wall. Generally it is necessary to paint two to three coats.')
   print('')
   print('Important information: ')
   print('')
   print('This algorithm was built with integer variables so it does not accept numbers with commas e.g.: 2.90 meters change to 3 meters.')
   print('This algorithm was built in Python 3 and by default always requires that its syntax and indentation are always correct for its correct compilation in the console.')
   print('')
   print('Press enter to return to the menu...')
   a5 = str(input(''))
   reset_text()
  elif op == 9:
   reset_text()
   print('')
   print('Algorithm: Measurement and Calculation for Residential Painting')
   print('')
   print('Author: PHNO')
   print('Release Date: 29/11/2024')
   print('Version: 0.0.0.2v')
   print('Replit: @PHNO, @PHREPLIT')
   print('E-mail: phreplit@gmail.com')
   print('')
   print('Press enter to return to the menu...')
   a6 = str(input(''))
   reset_text()
  else: 
   print('')
   print('Error. Wrong Choice!')
   print('')
   print('Press enter to return to the menu...')
   a7 = str(input(''))
   reset_text()