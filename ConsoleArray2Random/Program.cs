namespace ConsoleArray2Random {
    internal class Program {
        static void Main(string[] args) {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Clear();
            Console.WriteLine("ConsoleArray2Random\n");

            Random random = new Random();
            int[,] randomArray = new int[10,14];
            
            for (int i = 0; i < randomArray.GetLength(0); i++) {
                for (int j = 0; j < randomArray.GetLength(1); j++) {
                    
                    if (j < randomArray.GetLength(1) - 4) {
                        randomArray[i, j] = random.Next(100);
                        Console.Write(string.Format("{0,3}", randomArray[i, j]));
                    
                    } else if (j == randomArray.GetLength(1) -1) {
                        //randomArray[i, j -4] = 
                    }

                    
                }
            }

            for (int i = 0; i < randomArray.GetLength(0); i++) {
                for (int j = 0; j < randomArray.GetLength(1); j++) {
                    Console.Write(string.Format("{0,3}", randomArray[i, j]));
                }


                Console.Write("\n");
            }

            Console.ReadLine();
        }
    }
}
