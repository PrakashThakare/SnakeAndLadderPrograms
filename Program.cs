namespace SnakeAndLadderProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************** Welcome To Snake And Ladder Programs ******************");
            SnakeAndLadderStar obj = new SnakeAndLadderStar();
            obj.PlayerRolled();
            Console.ReadLine();
        }
    }
}