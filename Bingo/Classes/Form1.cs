/*Tommy Huynh
 * 2/5/19
 * Purpose: Implements form letting user play bingo*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;

//Tommy
namespace Bingo.Classes
{
    public partial class frmBingo : Form
    {
        //global variables to be used
        private const int BINGOCARDSIZE = 7;
        private const int NUMBERSPERCOLUMN = 15;
        private const int MAXBINGONUMBER = 75;

        private int currentPlayer = 1;
        
        //global objects
        private Button[,] newButton = new Button[BINGOCARDSIZE, BINGOCARDSIZE];
        RNGType RNGType = new RNGType();
        char[] bingoLetters = { 'B', 'I', 'N', 'G', 'O' };
        InternalBoard board = new InternalBoard();

        // Total width and height of a card cell
        int cardCellWidth = 75;
        int cardCellHeight = 75;
        int barWidth = 6;  // Width or thickness of horizontal and vertical bars
        int xcardUpperLeft = 45;
        int ycardUpperLeft = 45;
        int padding = 20;

        public frmBingo()
        {
            InitializeComponent();
            this.Height = 825;
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
            drawHorizBar(x, y, BINGOCARDSIZE);
            y = y + barWidth;

            // The board is treated like a 5x5 array
            drawVertBar(x, y);
            Globals.selectedNumbersListObj.reset(); //ensure clear array, recommended by professor
             
            for (int row = 0; row < BINGOCARDSIZE-1; row++)
            {
                loc.Y = topMargin + row * (size.Height + padding);
                int extraLeftPadding = 50;
                for (int col = 0; col < BINGOCARDSIZE; col++)
                {
                    newButton[row, col] = new Button();
                    newButton[row, col].Location = new Point(extraLeftPadding + col * (size.Width + padding) + barWidth, loc.Y);
                    newButton[row, col].Size = size;
                    newButton[row, col].Font = new Font("Arial", 24, FontStyle.Bold);

                    newButton[row, col].Font = new Font("Arial", 24, FontStyle.Bold);
                    newButton[row, col].Text = "h";

                    if(row == 6)
                    {
                        newButton[row, col].Enabled = true;
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
                drawHorizBar(x + 25, y - 10, BINGOCARDSIZE - 10);
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
            lblHorizBar.Size = new System.Drawing.Size((cardCellWidth + padding - 1) * BINGOCARDSIZE, barWidth);
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
            lblVertBar.Size = new System.Drawing.Size(barWidth, (cardCellHeight + padding - 1) * BINGOCARDSIZE);
            lblVertBar.TabIndex = 19;
            pnlCard.Controls.Add(lblVertBar);
            lblVertBar.Visible = true;
            lblVertBar.CreateControl();
            lblVertBar.Show();
        }  // end drawVertBar

        private void Button_Click(object sender, EventArgs e)  //event handler when a bingo card is clicked
        {
            /*
            int selectedNumber;  // number clicked on 
            int rowID = convertCharToInt(((Button)sender).Name[3]);
            int colID = convertCharToInt(((Button)sender).Name[4]);
            MessageBox.Show("Cell[" + rowID + "," + colID + "] has been selected!");
            int cellID = rowID * 3 + colID;

            // Double check that clicked on button value matches called value            
            selectedNumber = Convert.ToInt32(newButton[rowID, colID].Text);  //cast button text to an int so it can be compared to nextCalledNumber                  
            
            if (selectedNumber == nextCalledNumber)
             {
                newButton[rowID, colID].BackColor = System.Drawing.Color.Orange;
                newButton[rowID, colID].Enabled = false;                                
                board.markCell(rowID, colID);   //mark cell in internal 2d array
                
                //Globals.selectedNumbersListObj.setUsedNumber(selectedNumber);

                // Check for winner
                if (board.checkBingo() == true)
                {
                    MessageBox.Show("You win! Congrats!");
                    this.Close();
                }                            
                 playTheGame();               
            }
             else
             {
                 MessageBox.Show("Called number does not match the one in the box you selected." + "Try again!", "Numbers Do Not Match");
             } // end outer if
             */
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
                pnlCard.Visible = true;
                createCard();
                btnYes.Enabled = false;
                playTheGame();               
            }
        }

       

        private void btnDontHave_Click(object sender, EventArgs e)
        {
            playTheGame();  //continue to call numbers if dont have button is clicked
        }
        void playTheGame()
        {
           
        } // end playTheGame  
    }
}
