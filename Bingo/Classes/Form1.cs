using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using WMPLib;
using System.IO;

namespace Bingo.Classes
{
    public partial class frmConnectFour : Form
    {
        //global variables to be used
        private const int CARDSIZE = 7;
        private const int clickButtonMax = 42;

        private int currentPlayer = 1;

        //global objects
        private Button[,] newButton = new Button[CARDSIZE, CARDSIZE];
        InternalBoard board = new InternalBoard();
        Timer t = new Timer();
        Timer pause = new Timer();
        WindowsMediaPlayer piecePlayer = new WindowsMediaPlayer();
        WindowsMediaPlayer wplayer = new WindowsMediaPlayer();

        // Total width and height of a card cell
        int cardCellWidth = 75;
        int cardCellHeight = 75;
        int barWidth = 6;  // Width or thickness of horizontal and vertical bars
        int xcardUpperLeft = 45;
        int ycardUpperLeft = 45;
        int padding = 20;

        int counter = 0;
        int pauseCounter = 0;
        int buttonClickCounter = 0;

        int p1ID = 1;
        int p2ID = 2;

        string p1Color = "Red";
        string p2Color = "Yellow";

        int clickedRowID = 0;
        int clickedColID = 0;

        Player Player1 = new Player();
        Player Player2 = new Player();

        public frmConnectFour()
        {
            InitializeComponent();
            this.Height = 800;
            this.Width = 900;

            String musicPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\Sound\Main_Theme.mp3";
            wplayer.URL = musicPath;
            wplayer.controls.play();
            wplayer.settings.playCount = 99;


        }

        private void createCard() //creates cards on the board
        {
            Size size = new Size(75, 75);
            Point loc = new Point(0, 0);
            int topMargin = 60;

            int x;
            int y;

            // Draw Column indexes
            y = 0;
            DrawColumnLabels();

            x = xcardUpperLeft;
            y = ycardUpperLeft;

            // Draw top line for card
            drawHorizBar(x, y, CARDSIZE);
            y = y + barWidth;

            // The board is treated like a 5x5 array
            drawVertBar(x, y);

            for (int row = 0; row < CARDSIZE - 1; row++)
            {
                loc.Y = topMargin + row * (size.Height + padding);
                int extraLeftPadding = 50;
                for (int col = 0; col < CARDSIZE; col++)
                {
                    newButton[row, col] = new Button();
                    newButton[row, col].BackColor = Color.DarkGray;
                    newButton[row, col].Location = new Point(extraLeftPadding + col * (size.Width + padding) + barWidth, loc.Y);
                    newButton[row, col].Size = size;
                    newButton[row, col].Font = new Font("Arial", 24, FontStyle.Bold);

                    newButton[row, col].Font = new Font("Arial", 24, FontStyle.Bold);
                    newButton[row, col].Text = "0";

                    if (row == 5)
                    {
                        newButton[row, col].Enabled = true;
                        newButton[row, col].BackColor = Color.LightGray;
                    }
                    else
                    {
                        newButton[row, col].Enabled = false;
                    }
                    newButton[row, col].Name = "btn" + row.ToString() + col.ToString();

                    // Associates the same event handler with each of the buttons generated
                    newButton[row, col].Click += new EventHandler(Button_Click);

                    // Add button to the form
                    pnlCard.Controls.Add(newButton[row, col]);

                    // Draw vertical delimiter                 
                    x += cardCellWidth + padding;
                    if (row == 0) drawVertBar(x - 5, y);
                } // end for col
                // One row now complete

                // Draw bottom square delimiter if square complete
                x = xcardUpperLeft - 20;
                y = y + cardCellHeight + padding;
                drawHorizBar(x + 25, y - 10, CARDSIZE - 10);
            } // end for row

            // Draw column indices at bottom of card
            y += barWidth - 1;
            DrawColumnLabels();
        } // end createBoard
        // Draws column indexes at top and bottom of card
        private void DrawColumnLabels()
        {
            Label lblColID = new Label();
            lblColID.Font = new System.Drawing.Font("Microsoft Sans Serif", (float)24.0, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblColID.ForeColor = System.Drawing.Color.Orange;
            lblColID.Location = new System.Drawing.Point(cardCellWidth, 0);
            lblColID.Name = "lblColIDConnect4";
            lblColID.Size = new System.Drawing.Size(488, 32);
            lblColID.TabIndex = 0;
            pnlCard.Controls.Add(lblColID);
            lblColID.Visible = true;
            lblColID.CreateControl();
            lblColID.Show();
        } // end drawColumnLabels
        // Draw the dark horizontal bar
        private void drawHorizBar(int x, int y, int cardSize)
        {
            int currentx;
            currentx = x;

            Label lblHorizBar = new Label();
            lblHorizBar.BackColor = System.Drawing.SystemColors.ControlText;
            lblHorizBar.Location = new System.Drawing.Point(currentx, y);
            lblHorizBar.Name = "lblHorizBar";
            lblHorizBar.Size = new System.Drawing.Size((cardCellWidth + padding - 1) * CARDSIZE, barWidth);
            lblHorizBar.TabIndex = 20;
            pnlCard.Controls.Add(lblHorizBar);
            lblHorizBar.Visible = true;
            lblHorizBar.CreateControl();
            lblHorizBar.Show();
            currentx = currentx + cardCellWidth;
        } // end drawHorizBar
        // Draw dark vertical bar
        private void drawVertBar(int x, int y)
        {
            Label lblVertBar = new Label();
            lblVertBar.BackColor = System.Drawing.SystemColors.ControlText;
            lblVertBar.Location = new System.Drawing.Point(x, y);
            lblVertBar.Name = "lblVertBar" + x.ToString();
            lblVertBar.Size = new System.Drawing.Size(barWidth, (cardCellHeight + padding - 1) * 6);
            lblVertBar.TabIndex = 19;
            pnlCard.Controls.Add(lblVertBar);
            lblVertBar.Visible = true;
            lblVertBar.CreateControl();
            lblVertBar.Show();
        }  // end drawVertBar

        private void Button_Click(object sender, EventArgs e)  //event handler when a bingo card is clicked
        {
            String piecePath = Path.GetDirectoryName(Directory.GetCurrentDirectory()) + @"\Debug\Sound\Connect4Piece.wav";
            piecePlayer.URL = piecePath;
            piecePlayer.controls.play();
            buttonClickCounter++;
            Console.WriteLine(buttonClickCounter);
            int rowID = convertCharToInt(((Button)sender).Name[3]);
            int colID = convertCharToInt(((Button)sender).Name[4]);
            //MessageBox.Show("Cell[" + rowID + "," + colID + "] has been selected!");
            int cellID = rowID * 3 + colID;

            if (currentPlayer == Player1.getPlayerID())
            {
                clickedRowID = rowID;
                clickedColID = colID;
                t.Start();
                //newButton[rowID, colID].BackColor = System.Drawing.Color.Red;
                newButton[rowID, colID].Enabled = false;
                board.markCell(rowID, colID, currentPlayer);   //mark cell in internal 2d array   
                counter = 0;
                lblCurrentPlayer.Text = "Player " + Player2.getPlayerID().ToString() + " Move (" + Player2.getPlayerColor().ToString() + ")";
                // newButton[rowID, colID].Text = "1";
                if (rowID == 0)
                {
                    Console.WriteLine(colID + " has reached the top of the board.");
                }
                else
                {
                    newButton[rowID - 1, colID].Enabled = true;
                }


                counter = 0;
                pauseCounter = 0;

            }
            else if (currentPlayer == Player2.getPlayerID())
            {
                clickedRowID = rowID;
                clickedColID = colID;
                t.Start();
                newButton[rowID, colID].Enabled = false;
                board.markCell(rowID, colID, currentPlayer);   //mark cell in internal 2d array
                counter = 0;
                pauseCounter = 0;
                lblCurrentPlayer.Text = "Player " + Player1.getPlayerID().ToString() + " Move (" + Player1.getPlayerColor().ToString() + ")";
                // newButton[rowID, colID].Text = "2";

                if (rowID == 0)
                {
                    Console.WriteLine(colID + " has reached the top of the board.");
                }
                else
                {
                    newButton[rowID - 1, colID].Enabled = true;
                }



            }
            if (buttonClickCounter == clickButtonMax)
            {
                MessageBox.Show("Uh oh! Looks like you have reached a tie!", "Tie Detected");
                DialogResult dg = MessageBox.Show("Would you like to play again?", "Play again?", MessageBoxButtons.YesNo);
                if (dg == DialogResult.Yes)
                {
                    board.resetBoard();
                    buttonClickCounter = 0;
                    currentPlayer = Player1.getPlayerID();
                    lblCurrentPlayer.Text = "Player " + Player1.getPlayerID().ToString() + " Move (" + Player1.getPlayerColor().ToString() + ")";
                    for (int row = 0; row < CARDSIZE - 1; row++)
                    {


                        for (int col = 0; col < CARDSIZE; col++)
                        {

                            newButton[row, col].BackColor = Color.DarkGray;
                            newButton[row, col].Text = "0";


                            if (row == 5)
                            {
                                newButton[row, col].Enabled = true;
                                newButton[row, col].BackColor = Color.LightGray;
                            }
                            else
                            {
                                newButton[row, col].Enabled = false;
                            }
                            newButton[row, col].Name = "btn" + row.ToString() + col.ToString();

                            // Associates the same event handler with each of the buttons generated
                            //newButton[row, col].Click += new EventHandler(Button_Click);
                        }
                    } // end for col

                }
                else if (dg == DialogResult.No)
                {
                    this.Close();
                }
            }
        } // end button clickhandler 

        public int convertCharToInt(char c)  //converts a character to an int
        {
            return (int)char.GetNumericValue(c);
        }

        private void btnExit_Click(object sender, EventArgs e) //event handler for exit button
        {
            Close();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            if (((String.IsNullOrEmpty(txtPlayer1Name.Text) && String.IsNullOrEmpty(txtPlayer2Name.Text))))  //name input validation
            {
                MessageBox.Show("Both players must enter names to continue.", "No Names Found");
                txtPlayer1Name.Focus();
            }
            else if (String.IsNullOrEmpty(txtPlayer1Name.Text))
            {
                MessageBox.Show("Player 1 must enter a name to continue.", "Player 1 Name Not Found");
                txtPlayer1Name.Focus();
            }
            else if (String.IsNullOrEmpty(txtPlayer2Name.Text))
            {
                MessageBox.Show("Player 2 must enter a name to continue.", "Player 2 Name Not Found");
                txtPlayer2Name.Focus();
            }
            else
            {
                Player1.setPlayerName(txtPlayer1Name.Text);
                Player1.setPlayerID(p1ID);
                Player1.setPlayerColor(p1Color);

                Player2.setPlayerName(txtPlayer2Name.Text);
                Player2.setPlayerID(p2ID);
                Player2.setPlayerColor(p2Color);

                Console.WriteLine(Player1.getPlayerName());
                Console.WriteLine(Player2.getPlayerName());

                lblPlay.Visible = false;
                pnlCard.Visible = true;
                createCard();
                btnYes.Enabled = false;
                lblCurrentPlayer.Visible = true;
                lblCurrentPlayer.Text = "Player " + Player1.getPlayerID().ToString() + " Move (" + Player1.getPlayerColor().ToString() + ")";

                txtPlayer1Name.ReadOnly = true;
                txtPlayer2Name.ReadOnly = true;

                t.Tick += new EventHandler(timer_Tick);
                t.Interval = 30; // specify interval time as you want

                pause.Tick += new EventHandler(pause_Tick);
                pause.Interval = 30;
            }
        }

        void playTheGame()
        {
            if (currentPlayer == Player1.getPlayerID())
            {
                currentPlayer = Player2.getPlayerID();
            }
            else if (currentPlayer == Player2.getPlayerID())
            {
                currentPlayer = Player1.getPlayerID();
            }
        } // end playTheGame

        void timer_Tick(object sender, EventArgs e)
        {
            if (currentPlayer == Player1.getPlayerID())
            {
                if (clickedRowID == 0)
                {
                    pause.Start();
                }
                else if (counter == 0)
                {
                    newButton[counter, clickedColID].BackColor = System.Drawing.Color.Red;
                    counter++;
                }
                else if (counter == 1)
                {
                    newButton[counter - 1, clickedColID].BackColor = System.Drawing.Color.DarkGray;
                    newButton[counter, clickedColID].BackColor = System.Drawing.Color.Red;
                    counter++;
                }
                else if (counter == 2)
                {
                    newButton[counter - 1, clickedColID].BackColor = System.Drawing.Color.DarkGray;
                    newButton[counter, clickedColID].BackColor = System.Drawing.Color.Red;
                    counter++;
                }
                else if (counter == 3)
                {
                    newButton[counter - 1, clickedColID].BackColor = System.Drawing.Color.DarkGray;
                    newButton[counter, clickedColID].BackColor = System.Drawing.Color.Red;
                    counter++;
                }
                else if (counter == 4)
                {
                    newButton[counter - 1, clickedColID].BackColor = System.Drawing.Color.DarkGray;
                    newButton[counter, clickedColID].BackColor = System.Drawing.Color.Red;
                    counter++;
                }
                if (counter == clickedRowID)
                {
                    pause.Start();
                    //MessageBox.Show("working?");
                    newButton[clickedRowID, clickedColID].Text = Player1.getPlayerID().ToString();
                    t.Stop();
                }
            }
            else if (currentPlayer == Player2.getPlayerID())
            {
                if (clickedRowID == 0)
                {
                    pause.Start();
                }
                else if (counter == 0)
                {
                    newButton[counter, clickedColID].BackColor = System.Drawing.Color.Yellow;
                    counter++;
                }
                else if (counter == 1)
                {
                    newButton[counter - 1, clickedColID].BackColor = System.Drawing.Color.DarkGray;
                    newButton[counter, clickedColID].BackColor = System.Drawing.Color.Yellow;
                    counter++;
                }
                else if (counter == 2)
                {
                    newButton[counter - 1, clickedColID].BackColor = System.Drawing.Color.DarkGray;
                    newButton[counter, clickedColID].BackColor = System.Drawing.Color.Yellow;
                    counter++;
                }
                else if (counter == 3)
                {
                    newButton[counter - 1, clickedColID].BackColor = System.Drawing.Color.DarkGray;
                    newButton[counter, clickedColID].BackColor = System.Drawing.Color.Yellow;
                    counter++;
                }
                else if (counter == 4)
                {
                    newButton[counter - 1, clickedColID].BackColor = System.Drawing.Color.DarkGray;
                    newButton[counter, clickedColID].BackColor = System.Drawing.Color.Yellow;
                    counter++;
                }
                if (counter == clickedRowID)
                {
                    pause.Start();
                    newButton[clickedRowID, clickedColID].Text = Player2.getPlayerID().ToString();
                    //MessageBox.Show("working?");
                    t.Stop();
                }
            }
        }

        void pause_Tick(object sender, EventArgs e)
        {
            // Console.WriteLine("Pause Counter: " + counter);
            // Console.WriteLine(clickedColID);
            if (clickedRowID == 0)
            {
                if (currentPlayer == Player1.getPlayerID())
                {
                    newButton[clickedRowID, clickedColID].BackColor = System.Drawing.Color.Red;
                }
                else if (currentPlayer == Player2.getPlayerID())
                {
                    newButton[clickedRowID, clickedColID].BackColor = System.Drawing.Color.Yellow;
                }
                pause.Stop();
            }
            else if (pauseCounter == 0)
            {
                newButton[counter - 1, clickedColID].BackColor = System.Drawing.Color.LightGray;
                counter = 0;
                pauseCounter = 1;
                if (currentPlayer == Player1.getPlayerID())
                {
                    newButton[clickedRowID, clickedColID].BackColor = System.Drawing.Color.Red;
                }
                else if (currentPlayer == Player2.getPlayerID())
                {
                    newButton[clickedRowID, clickedColID].BackColor = System.Drawing.Color.Yellow;
                }
                pause.Stop();
            }
            pauseCounter++;
            if (board.checkConnectFour() == true)
            {
                if (currentPlayer == Player1.getPlayerID())
                {
                    MessageBox.Show(Player1.getPlayerName().ToString() + " (Player 1) Wins! Congrats!", "You are a Winner!");
                    DialogResult dg = MessageBox.Show("Would you like to play again?", "Play again?", MessageBoxButtons.YesNo);
                    if (dg == DialogResult.Yes)
                    {
                        board.resetBoard();
                        buttonClickCounter = 0;
                        currentPlayer = Player1.getPlayerID();
                        lblCurrentPlayer.Text = "Player " + Player1.getPlayerID().ToString() + " Move (" + Player1.getPlayerColor().ToString() + ")";
                        for (int row = 0; row < CARDSIZE - 1; row++)
                        {


                            for (int col = 0; col < CARDSIZE; col++)
                            {

                                newButton[row, col].BackColor = Color.DarkGray;
                                newButton[row, col].Text = "0";


                                if (row == 5)
                                {
                                    newButton[row, col].Enabled = true;
                                    newButton[row, col].BackColor = Color.LightGray;
                                }
                                else
                                {
                                    newButton[row, col].Enabled = false;
                                }
                                newButton[row, col].Name = "btn" + row.ToString() + col.ToString();

                                // Associates the same event handler with each of the buttons generated
                                //newButton[row, col].Click += new EventHandler(Button_Click);
                            }
                        } // end for col
                        counter = 0;

                    }
                    else if (dg == DialogResult.No)
                    {
                        this.Close();
                    }
                }
                else if (currentPlayer == Player2.getPlayerID())
                {
                    MessageBox.Show(Player2.getPlayerName().ToString() + " (Player 2) Wins! Congrats!", "You are a Winner!");
                    DialogResult dg = MessageBox.Show("Would you like to play again?", "Play again?", MessageBoxButtons.YesNo);
                    if (dg == DialogResult.Yes)
                    {
                        board.resetBoard();
                        buttonClickCounter = 0;
                        currentPlayer = Player1.getPlayerID();
                        lblCurrentPlayer.Text = "Player " + Player1.getPlayerID().ToString() + " Move (" + Player1.getPlayerColor().ToString() + ")";
                        for (int row = 0; row < CARDSIZE - 1; row++)
                        {


                            for (int col = 0; col < CARDSIZE; col++)
                            {

                                newButton[row, col].BackColor = Color.DarkGray;
                                newButton[row, col].Text = "0";


                                if (row == 5)
                                {
                                    newButton[row, col].Enabled = true;
                                    newButton[row, col].BackColor = Color.LightGray;
                                }
                                else
                                {
                                    newButton[row, col].Enabled = false;
                                }
                                newButton[row, col].Name = "btn" + row.ToString() + col.ToString();

                                // Associates the same event handler with each of the buttons generated
                                //newButton[row, col].Click += new EventHandler(Button_Click);
                            }
                        } // end for col

                    }
                    else if (dg == DialogResult.No)
                    {
                        this.Close();
                    }
                }
            }
            else if (currentPlayer == Player1.getPlayerID())
            {
                currentPlayer = Player2.getPlayerID();
            }
            else if (currentPlayer == Player2.getPlayerID())
            {
                currentPlayer = Player1.getPlayerID();
            }
        }
    }
}
