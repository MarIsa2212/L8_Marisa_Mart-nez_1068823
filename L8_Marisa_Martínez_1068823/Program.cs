namespace L8_Marisa_Martínez_1068823
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 2");

            // n -> sumatoria = 1 + 2+ ...n
            // if solos se ejecutan una vez o nunguna
            //ciclos o while se ejecuta muchas veces 
            Console.WriteLine("a. Sumatoria");
            Console.WriteLine("b. Tablas de multiplicar");

            char opcion = Convert.ToChar(Console.ReadLine());


            switch (opcion)
            {
                case 'a':
                    Console.WriteLine("Ingrese un numero: ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    
                    int resultado = 0;
                    do
                    {
                            resultado = resultado + n;
                            n--;
                    } while (n > 0);
                    Console.WriteLine("Sumatoria = " + resultado); //regresa nuevamente a la condición 
                    break;

                case 'b':
                    for (int i = 1; i < 11; i++)
                    {
                        Console.WriteLine(i + ": ");
                        for (int j = 1; j < 11; j++) 
                        {
                            Console.Write((i * j) + "\t");
                        }
                        Console.Write("\n");
                    }

                    break;
            }

            
            
            

             
            
        }
    }
}