Console.Write("Введите первое число: ");
int numberА = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

 if(numberА > numberB)
            {
                Console.Write("max = ");
                Console.WriteLine(numberА);
                Console.Write(" min = ");
                Console.WriteLine(numberB);
            }
            else if (numberА < numberB)
            {
                Console.Write("max = ");
                Console.WriteLine(numberB);
                Console.Write("min = ");
                Console.WriteLine(numberА);
            }