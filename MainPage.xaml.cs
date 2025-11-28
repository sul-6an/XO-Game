namespace ekso
{
    public partial class MainPage : ContentPage
    {

        static string player1 = "Player 1";
        static string player2 = "Player 2";
        string CurrentPlayer = player1;

        public MainPage()
        {
            InitializeComponent();
        }


        private void b1_Clicked(object sender, EventArgs e)
        {


            var btn = (Button)sender;
            


            if (CurrentPlayer == player1)
            {
                btn.Text = "X";
                btn.IsEnabled = false;

                checkWinner("X");
                CurrentPlayer = player2;
                label1.Text = "player 2";
            }
            else
            {
                btn.Text = "O";
                btn.IsEnabled = false;

                checkWinner("O");
                CurrentPlayer = player1;
                label1.Text = "player 1";
            }
        }





        private void Newgame(object sender, EventArgs e)
        {


            b1.Text = " ";
            b2.Text = " ";
            b3.Text = " ";
            b4.Text = " ";
            b5.Text = " ";
            b6.Text = " ";
            b7.Text = " ";
            b8.Text = " ";
            b9.Text = " ";
            
            b1.IsEnabled = true;
            b2.IsEnabled = true;
            b3.IsEnabled = true;
            b4.IsEnabled = true;
            b5.IsEnabled = true;
            b6.IsEnabled = true;
            b7.IsEnabled = true;
            b8.IsEnabled = true;
            b9.IsEnabled = true;


            label1.Text = "player 1";
            winnerLabel.Text = "winner";
            CurrentPlayer = player1;



        }


        private void checkWinner(string xo)
        {
            if ((b1.Text == xo && b2.Text == xo && b3.Text == xo)
            || (b4.Text == xo && b5.Text == xo && b6.Text == xo)
            || (b7.Text == xo && b8.Text == xo && b9.Text == xo)
            || (b1.Text == xo && b4.Text == xo && b7.Text == xo)
            || (b2.Text == xo && b5.Text == xo && b8.Text == xo)
            || (b3.Text == xo && b6.Text == xo && b9.Text == xo)
            || (b1.Text == xo && b5.Text == xo && b9.Text == xo)
            || (b3.Text == xo && b5.Text == xo && b7.Text == xo))
                winnerLabel.Text = CurrentPlayer + " Wins!";
        }


    }
}
