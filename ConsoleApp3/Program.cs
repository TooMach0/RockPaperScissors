

namespace ConsoleApp
{
    class Program
    {
    

        static void Main(string[] args)
        {
            
            string player1 = Console.ReadLine();
            string player2 = Console.ReadLine();

           Console.WriteLine(Rps(player1, player2));

        }

        public static string Rps(string p1, string p2)
        {
            string[] KamenPapierNoznice = new string[] { "rock", "paper", "scissors" };

            for (int i = 0; i < KamenPapierNoznice.Length; i++)
            {
                p1.Equals(KamenPapierNoznice[i], StringComparison.OrdinalIgnoreCase);
                p2.Equals(KamenPapierNoznice[i], StringComparison.OrdinalIgnoreCase);
            }
            

            if (p1 == "scissors" && p2 == "paper")
            {

                return "player1 wins";
            }
            else if (p1 == "paper" && p2 == "rock")
            {

                return "player1 wins";
            }
            else if (p1 == "rock" && p2 == "scissors")
            {
                return "player1 wins";
            }
            else if(p1 ==p2)
            {
                return "Draw";
            }
            else
            {
                return "player2 wins";
            }
        }
    }
}