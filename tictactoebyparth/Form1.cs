using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoebyparth
{
    public partial class Form1 : Form
    {
        bool turn = true; //when true X = turn, false  = Y turn
        bool play_against_computer = true;
        int t_count = 0;// keeps a count on how many times both players has a turn
        static String player1, player2; //too store names of players 
        public Form1()
        {
            InitializeComponent();
        }

        public static void playerNames(String name1, String name2) 
        {
            player1 = name1;
            player2 = name2;
        }//end playerNames

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
            tb1.Text = player1;
            tb2.Text = player2;

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Parth Patel", "About");

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void label4_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X"; // displays X on game board when pressed
            else
                b.Text = "O"; // displays O on game board when perssed
            turn = !turn; // switches between X, O turn
            b.Enabled = false;
            t_count++; // increments how many times the button clicks also useful to check if its a draw 
            checkifwon();

            if ((!turn) && (play_against_computer))
            {
                computer_make_move();
            }//end if
        }
        private void checkifwon()
        {
            
            bool is_won = false;

            // HORRIZONTAL WINNER CRITERIA
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled)) is_won = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled)) is_won = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled)) is_won = true;
            // HORRIZONTAL WINNER CRITERIA END

            // Vertical WINNER CRITERIA

            if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled)) is_won = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled)) is_won = true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled)) is_won = true;
            //END VERTICAL CHECK

            //Diagonal CHECK

            if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled)) is_won = true;
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled)) is_won = true;
         //   else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled)) is_won = true;

            //Display who won

            if (is_won)
            {
                disabledButtons();
                String won = "";
                if (turn)
                {
                    won = player2;
                    owon.Text = (Int32.Parse(owon.Text) + 1).ToString();

                    MessageBox.Show(won + " wins!");
                }
                else
                {
                    won = player1;
                    xwon.Text = (Int32.Parse(xwon.Text) + 1).ToString();

                    MessageBox.Show(won + " wins!");

                }
            } //end if (is_won)
           
            else
            {
                if (t_count == 9)
                {
                    draw.Text = (Int32.Parse(draw.Text) + 1).ToString();
                    MessageBox.Show("It's a DRAW! Well, played "+player1+" and " + player2+"!");
                }
            }

           
        }//end checkifwon

        private void disabledButtons()
        {
           
                foreach (Control c in Controls)
                {
                     try
            {
                    Button b = (Button)c;

                    b.Enabled = false;
            }//end try
                     catch { }
                } //end foreach

            

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            t_count = 0;
            
                foreach (Control c in Controls)
                {
                    try
            {
                    Button b = (Button)c;

                    b.Enabled = true;
                    b.Text = "";
            }//end try
                    catch { }
                } //end foreach

           

        }

        private void button_enter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                
                if (turn)
                    b.Text = "X";
                else
                    b.Text = "O";
            }//end iff base.enabled
        }


        private void button_leave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                b.Text = "";

            }//endiff

        }

        private void manualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Player 1 is X\n Player 2 is O \n To Reset Score, Click File --> Reset Score \n For New Game, Click File --> New Game");

            //  MessageBox.Show("Hovering over a button, will show who's turn is it!");
            // MessageBox.Show("# Number of X, or O, and Draws count is kept below.");
            //MessageBox.Show("GoodLuck!");
        }

        private void resetScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {


            owon.Text = "0";
            xwon.Text = "0";
            draw.Text = "0";
            newGameToolStripMenuItem_Click(sender, e); // resets the whole board, instead of just clearing scores. 
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

  

        private void label2_TextChanged(object sender, EventArgs e)
        {
      //      label2.Enabled = false;
        }

        private void label4_TextChanged_1(object sender, EventArgs e)
        {

            if (tb2.Text.ToUpper() == "Computer")
                play_against_computer = true;
            else
                play_against_computer = false;
        }//end label4_textChanged
   

        private void computer_make_move()
        {
            //priority 1:  get tick tac toe
            //priority 2:  block x tic tac toe
            //priority 3:  go for corner space
            //priority 4:  pick open space

            Button move = null;

            //look for tic tac toe opportunities
            move = look_for_win_or_block("O"); //look for win
            if (move == null)
            {
                move = look_for_win_or_block("X"); //look for block
                if (move == null)
                {
                    move = look_for_corner();
                    if (move == null)
                    {
                        move = look_for_open_space();
                    }//end if
                }//end if
            }//end if

        //    move.PerformClick();
        }

        private Button look_for_open_space()
        {
            Console.WriteLine("Looking for open space");
            Button b = null;
            foreach (Control c in Controls)
            {
                b = c as Button;
                if (b != null)
                {
                    if (b.Text == "")
                        return b;
                }//end if
            }//end if

            return null;
        }

        private Button look_for_corner()
        {
            Console.WriteLine("Looking for corner");
            if (A1.Text == "O")
            {
                if (A3.Text == "")
                    return A3;
                if (C3.Text == "")
                    return C3;
                if (C1.Text == "")
                    return C1;
            }

            if (A3.Text == "O")
            {
                if (A1.Text == "")
                    return A1;
                if (C3.Text == "")
                    return C3;
                if (C1.Text == "")
                    return C1;
            }

            if (C3.Text == "O")
            {
                if (A1.Text == "")
                    return A3;
                if (A3.Text == "")
                    return A3;
                if (C1.Text == "")
                    return C1;
            }

            if (C1.Text == "O")
            {
                if (A1.Text == "")
                    return A3;
                if (A3.Text == "")
                    return A3;
                if (C3.Text == "")
                    return C3;
            }

            if (A1.Text == "")
                return A1;
            if (A3.Text == "")
                return A3;
            if (C1.Text == "")
                return C1;
            if (C3.Text == "")
                return C3;

            return null;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private Button look_for_win_or_block(string mark)
        {
            Console.WriteLine("Looking for win or block:  " + mark);
            //HORIZONTAL TESTS
            if ((A1.Text == mark) && (A2.Text == mark) && (A3.Text == ""))
                return A3;
            if ((A2.Text == mark) && (A3.Text == mark) && (A1.Text == ""))
                return A1;
            if ((A1.Text == mark) && (A3.Text == mark) && (A2.Text == ""))
                return A2;

            if ((B1.Text == mark) && (B2.Text == mark) && (B3.Text == ""))
                return B3;
            if ((B2.Text == mark) && (B3.Text == mark) && (B1.Text == ""))
                return B1;
            if ((B1.Text == mark) && (B3.Text == mark) && (B2.Text == ""))
                return B2;

            if ((C1.Text == mark) && (C2.Text == mark) && (C3.Text == ""))
                return C3;
            if ((C2.Text == mark) && (C3.Text == mark) && (C1.Text == ""))
                return C1;
            if ((C1.Text == mark) && (C3.Text == mark) && (C2.Text == ""))
                return C2;

            //VERTICAL TESTS
            if ((A1.Text == mark) && (B1.Text == mark) && (C1.Text == ""))
                return C1;
            if ((B1.Text == mark) && (C1.Text == mark) && (A1.Text == ""))
                return A1;
            if ((A1.Text == mark) && (C1.Text == mark) && (B1.Text == ""))
                return B1;

            if ((A2.Text == mark) && (B2.Text == mark) && (C2.Text == ""))
                return C2;
            if ((B2.Text == mark) && (C2.Text == mark) && (A2.Text == ""))
                return A2;
            if ((A2.Text == mark) && (C2.Text == mark) && (B2.Text == ""))
                return B2;

            if ((A3.Text == mark) && (B3.Text == mark) && (C3.Text == ""))
                return C3;
            if ((B3.Text == mark) && (C3.Text == mark) && (A3.Text == ""))
                return A3;
            if ((A3.Text == mark) && (C3.Text == mark) && (B3.Text == ""))
                return B3;

            //DIAGONAL TESTS
            if ((A1.Text == mark) && (B2.Text == mark) && (C3.Text == ""))
                return C3;
            if ((B2.Text == mark) && (C3.Text == mark) && (A1.Text == ""))
                return A1;
            if ((A1.Text == mark) && (C3.Text == mark) && (B2.Text == ""))
                return B2;

            if ((A3.Text == mark) && (B2.Text == mark) && (C1.Text == ""))
                return C1;
            if ((B2.Text == mark) && (C1.Text == mark) && (A3.Text == ""))
                return A3;
            if ((A3.Text == mark) && (C1.Text == mark) && (B2.Text == ""))
                return B2;

            return null;
        }
    }



}
