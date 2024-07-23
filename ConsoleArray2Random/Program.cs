namespace ConsoleArray2Random {

    internal class Program {

        static void Main(string[] args) {

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Clear();
            Console.WriteLine("ConsoleArray2Random\n");

            Console.WriteLine("2-Dimensionales Array int[10,14] anlegen\n" +
                              "zufällige Werte ins Array schreiben\n" +
                              "Werte des Arrays anzeigen\n");

            int[,] randomArray = CreateAndShowRandomArray();

            Console.WriteLine("Summe, Mittelwert, Min und Max berechnen\n" +
                              "Werte des Array anzeigen\n");

            CalcAndShowRandomArray(randomArray);

            Console.WriteLine("\nPress enter to exit...");
            Console.ReadLine();
        }

        private static int[,] CreateAndShowRandomArray() {
            
            Random random = new Random();
            int[,] randomArray = new int[10, 14];

            for (int i = 0; i < randomArray.GetLength(0); i++) {
                for (int j = 0; j < randomArray.GetLength(1) - 4; j++) {

                    randomArray[i, j] = random.Next(100);
                    //Console.Write(string.Format("{0,3}", randomArray[i, j]));
                    // = same as:
                    Console.Write("{0,4}", randomArray[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            return randomArray;
        }

        private static void CalcAndShowRandomArray(int[,] randomArray) {
            
            for (int i = 0; i < randomArray.GetLength(0); i++) {
                int sum = 0;
                int min = 99;
                int max = 0;

                for (int j = 0; j < randomArray.GetLength(1) - 4; j++) {
                    Console.Write("{0,4}", randomArray[i, j]);

                    sum += randomArray[i, j];
                    if (min > randomArray[i, j]) {
                        min = randomArray[i, j];
                    }
                    if (max < randomArray[i, j]) {
                        max = randomArray[i, j];
                    }
                }

                randomArray[i, 10] = sum;
                randomArray[i, 11] = sum / 10;
                randomArray[i, 12] = min;
                randomArray[i, 13] = max;

                // print calculations
                Console.Write(" ");
                Console.ForegroundColor = ConsoleColor.Black;
                for (int j = 10; j < 14; j++) {
                    Console.Write("{0,4}", randomArray[i, j]);
                }
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine();
            }
        }
    }
}
