using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Disco_Zoo
{
    public partial class PuzzleScreen : UserControl
    {

        List<string[]> patterns = new List<string[]>();
        string[] board = new string[5];

        /* Adds the patterns to a list of string arrays */
        void AddPatterns()
        {
            // Clear list
            patterns.Clear();

            // Sheep
            patterns.Add(new string[]
            {
                "1111"
            });

            // Pig
            patterns.Add(new string[]
            {
                "11",
                "11"
            });

            // Rabbit
            patterns.Add(new string[]
            {
                "1",
                "1",
                "1",
                "1"
            });

            // Cow
            patterns.Add(new string[]
            {
                "111"
            });

            // Horse
            patterns.Add(new string[]
            {
                "1",
                "1",
                "1"
            });

            // Unicorn
            patterns.Add(new string[]
            {
                "100",
                "011"
            });
        }

        /* Clears the board */
        void SetupBoard()
        {
            for(int i = 0;i < 5;i++)
            {
                board[i] = "00000";
            }
        }

        /* Adds a pattern to the board */
        void AddPatternToBoard(int pattern)
        {
            List<Point> possiblePositions = new List<Point>();

            // Y of board
            for (int i = 0; i < board.Length; i++)
            {
                // X of board
                for (int j = 0; j < board[i].Length; j++)
                {
                    bool canFit = true;
                    // Y of pattern
                    for (int y = 0; y < patterns[pattern].Length; y++)
                    {
                        // X of pattern
                        for (int x = 0; x < patterns[pattern][y].Length; x++)
                        {
                            if (x + j >= board[i].Length || x + j < 0 || y + i >= board.Length || y + i < 0)
                            {
                                canFit = false;
                            }
                            if (canFit == true) {

                                if (board[i + y][j + x] != '0')
                                {
                                    canFit = false;
                                }
                            }
                        }
                    }
                }
            }
        }

        /* Adds things to the board */
        void AddToBoard()
        {

        }

        void Setup()
        {
            // Setup lists
            AddPatterns();

            // Setup board
            SetupBoard();
            AddToBoard();
        }


        public PuzzleScreen()
        {
            InitializeComponent();
            Setup();
        }

        private void PuzzleScreen_MouseClick(object sender, MouseEventArgs e)
        {
            Console.WriteLine(e.X.ToString() + ", " + e.Y.ToString());
        }

        private void PuzzleScreen_Paint(object sender, PaintEventArgs e)
        {

        }

        private void updateTick_Tick(object sender, EventArgs e)
        {

        }
    }
}
