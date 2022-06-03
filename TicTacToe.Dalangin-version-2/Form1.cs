namespace TicTacToe.Dalangin_version_2
{
    public partial class TicTacToeLabel : Form
    {
        public TicTacToeLabel()
        {
            InitializeComponent();
        }

        String[] keyPad = new string[9];
        int currentPlayer = 0;

        public String backSymbol(int turn)
        {
            if (turn % 2 == 0)
            {
                return "O";
            }
            else
            {
                return "X";
            }
        }

        public System.Drawing.Color colorChanger(String symbol)
        {
            if (symbol.Equals("O"))
            {
                return System.Drawing.Color.LightYellow;
            }
            else if (symbol.Equals("X"))
            {
                return System.Drawing.Color.LightBlue;
            }
            return System.Drawing.Color.Silver;
        }

        public void theWinner()
        {
            for (int i = 0; i < 8; i++)
            {
                String combination = "";
                int one = 0, two = 0, three = 0;


                switch (i)
                {
                    case 0:
                        combination = keyPad[2] + keyPad[4] + keyPad[6];
                        one = 2;
                        two = 4;
                        three = 6;
                        break;
                    case 1:
                        combination = keyPad[0] + keyPad[4] + keyPad[8];
                        one = 0;
                        two = 4;
                        three = 8;
                        break;
                    case 2:
                        combination = keyPad[0] + keyPad[1] + keyPad[2];
                        one = 0;
                        two = 1;
                        three = 2;
                        break;
                    case 3:
                        combination = keyPad[3] + keyPad[4] + keyPad[5];
                        one = 3;
                        two = 4;
                        three = 5;
                        break;
                    case 4:
                        combination = keyPad[6] + keyPad[7] + keyPad[8];
                        one = 6;
                        two = 7;
                        three = 8;
                        break;
                    case 5:
                        combination = keyPad[2] + keyPad[5] + keyPad[8];
                        one = 2;
                        two = 5;
                        three = 8;
                        break;
                    case 6:
                        combination = keyPad[1] + keyPad[4] + keyPad[7];
                        one = 1;
                        two = 4;
                        three = 7;
                        break;
                    case 7:
                        combination = keyPad[0] + keyPad[3] + keyPad[6];
                        one = 0;
                        two = 3;
                        three = 6;
                        break;
                }

                if (combination.Equals("OOO"))
                {
                    winnerColor(one);
                    winnerColor(two);
                    winnerColor(three);
                    MessageBox.Show("Player O has won the game!", "We have a winner!", MessageBoxButtons.OK);
                }
                else if (combination.Equals("XXX"))
                {
                    winnerColor(one);
                    winnerColor(two);
                    winnerColor(three);
                    MessageBox.Show("Player X has won the game!", "We have a winner!", MessageBoxButtons.OK);
                }

                else tieBreaker();


            }
        }

        public void reset()
        {
            ButtonA1.Text = "";
            ButtonA2.Text = "";
            ButtonA3.Text = "";
            ButtonB1.Text = "";
            ButtonB2.Text = "";
            ButtonB3.Text = "";
            ButtonC1.Text = "";
            ButtonC2.Text = "";
            ButtonC3.Text = "";
            ButtonA1.BackColor = System.Drawing.Color.Silver;
            ButtonA2.BackColor = System.Drawing.Color.Silver;
            ButtonA3.BackColor = System.Drawing.Color.Silver;
            ButtonB1.BackColor = System.Drawing.Color.Silver;
            ButtonB2.BackColor = System.Drawing.Color.Silver;
            ButtonB3.BackColor = System.Drawing.Color.Silver;
            ButtonC1.BackColor = System.Drawing.Color.Silver;
            ButtonC2.BackColor = System.Drawing.Color.Silver;
            ButtonC3.BackColor = System.Drawing.Color.Silver;
            keyPad = new string[9];
            currentPlayer = 0;
        }

        public void winnerColor(int number)
        {
            switch (number)
            {
                case 0:
                    ButtonA1.BackColor = System.Drawing.Color.Green; break;
                case 1:
                    ButtonA2.BackColor = System.Drawing.Color.Green; break;
                case 2:
                    ButtonA3.BackColor = System.Drawing.Color.Green; break;
                case 3:
                    ButtonB1.BackColor = System.Drawing.Color.Green; break;
                case 4:
                    ButtonB2.BackColor = System.Drawing.Color.Green; break;
                case 5:
                    ButtonB3.BackColor = System.Drawing.Color.Green; break;
                case 6:
                    ButtonC1.BackColor = System.Drawing.Color.Green; break;
                case 7:
                    ButtonC2.BackColor = System.Drawing.Color.Green; break;
                case 8:
                    ButtonC3.BackColor = System.Drawing.Color.Green; break;

            }
        }

        public void tieBreaker()
        {
            int counter = 0;
            for (int i = 0; i < keyPad.Length; i++)
            {
                if (keyPad[i] != null) { counter++; }

                if (counter == 9)
                {
                    reset();
                    MessageBox.Show("That's a draw!", "No winner", MessageBoxButtons.OK);
                }
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            currentPlayer++;
            keyPad[1] = backSymbol(currentPlayer);
            Color keypadColor = colorChanger(keyPad[1]);
            ButtonA2.BackColor = keypadColor;
            ButtonA2.Text = keyPad[1];
            theWinner();
        }

        private void ButtonA1_Click(object sender, EventArgs e)
        {
            currentPlayer++;
            keyPad[0] = backSymbol(currentPlayer);
            Color keypadColor = colorChanger(keyPad[0]);
            ButtonA1.BackColor = keypadColor;
            ButtonA1.Text = keyPad[0];
            theWinner();
        }

        private void ButtonA3_Click(object sender, EventArgs e)
        {
            currentPlayer++;
            keyPad[2] = backSymbol(currentPlayer);
            Color keypadColor = colorChanger(keyPad[2]);
            ButtonA3.BackColor = keypadColor;
            ButtonA3.Text = keyPad[2];
            theWinner();
        }

        private void ButtonB1_Click(object sender, EventArgs e)
        {
            currentPlayer++;
            keyPad[3] = backSymbol(currentPlayer);
            Color keypadColor = colorChanger(keyPad[3]);
            ButtonB1.BackColor = keypadColor;
            ButtonB1.Text = keyPad[3];
            theWinner();
        }

        private void ButtonB2_Click(object sender, EventArgs e)
        {
            currentPlayer++;
            keyPad[4] = backSymbol(currentPlayer);
            Color keypadColor = colorChanger(keyPad[4]);
            ButtonB2.BackColor = keypadColor;
            ButtonB2.Text = keyPad[4];
            theWinner();
        }

        private void ButtonB3_Click(object sender, EventArgs e)
        {
            currentPlayer++;
            keyPad[5] = backSymbol(currentPlayer);
            Color keypadColor = colorChanger(keyPad[5]);
            ButtonB3.BackColor = keypadColor;
            ButtonB3.Text = keyPad[5];
            theWinner();
        }

        private void ButtonC1_Click(object sender, EventArgs e)
        {
            currentPlayer++;
            keyPad[6] = backSymbol(currentPlayer);
            Color keypadColor = colorChanger(keyPad[6]);
            ButtonC1.BackColor = keypadColor;
            ButtonC1.Text = keyPad[6];
            theWinner();
        }

        private void ButtonC2_Click(object sender, EventArgs e)
        {
            currentPlayer++;
            keyPad[7] = backSymbol(currentPlayer);
            Color keypadColor = colorChanger(keyPad[7]);
            ButtonC2.BackColor = keypadColor;
            ButtonC2.Text = keyPad[7];
            theWinner();
        }

        private void ButtonC3_Click(object sender, EventArgs e)
        {
            currentPlayer++;
            keyPad[8] = backSymbol(currentPlayer);
            Color keypadColor = colorChanger(keyPad[8]);
            ButtonC3.BackColor = keypadColor;
            ButtonC3.Text = keyPad[8];
            theWinner();
        }

        private void playerInstructions_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The object of Tic Tac Toe is to get three in a row. You play on a three by three game board. The first player is known as X and the second is O. Players alternate placing Xs and Os on the game board until either opponent has three in a row or all nine squares are filled. X always goes first, and in the event that no one has three in a row, the stalemate is called a tie game.", "Instructions", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void newgameButton_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}