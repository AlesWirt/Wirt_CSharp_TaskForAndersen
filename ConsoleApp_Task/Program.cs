using System;

namespace ConsoleApp_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.Run();
        }

        public void CheckSeven(int number)
        {
            if(number > 6)
            {
                Console.WriteLine("Hello");
            }
        }



    }
}
