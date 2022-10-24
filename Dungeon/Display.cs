namespace Dungeon
{
    public class Display
    {
        public static void Floor()
        {
            Console.WriteLine("hello");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("\n");
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(" ");
                    Console.Write($"\t{Map.FullMap[i, j].GetStatus} ");
                }
            }
            Console.WriteLine("\n");
        }
    }
}
