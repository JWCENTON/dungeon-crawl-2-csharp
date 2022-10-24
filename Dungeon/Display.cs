namespace Dungeon
{
    public class Display
    {
        public void DisplayFoor()
        {
            Console.WriteLine();
            for (int i = 0; i < Map.Width; i++)
            {
                Console.WriteLine("\n");
                for (int j = 0; j < Map.Width; j++)
                {
                    Console.Write(" ");
                    Console.Write($"\t{Map.FullMap[i, j].SqStatus} ");
                }
            }
            Console.WriteLine("\n");
        }
    }
}
