using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Caro
{
    public class ChessBoardManager
    {
        #region Properties
        private Panel chessBoard;

        public Panel ChessBoard { get => chessBoard; set => chessBoard = value; }

        #endregion

        #region Initialize
        public ChessBoardManager(Panel chessBoard)
        {
            this.ChessBoard = chessBoard;
        }
        #endregion
        #region Methods
        public void DrawChessBar()
        {
            
            Button oldButton = new Button() { Width = 0, Location = new Point(0, 0) };
            for (int i = 0; i < Constant.Chess_Board_Height; i++)
            {

                for (int j = 0; j < Constant.Chess_Board_Width; j++)
                {
                    Button btn = new Button()
                    {
                        Width = Constant.Chess_Square_Width,
                        Height = Constant.Chess_Square_Height,
                        Location = new Point(oldButton.Location.X + oldButton.Width, oldButton.Location.Y),
                    };

                    btn.Click += btn_Click;

                    ChessBoard.Controls.Add(btn);
                    oldButton = btn;
                }
                oldButton.Location = new Point(0, oldButton.Location.Y + Constant.Chess_Square_Height);
                oldButton.Width = 0;
                oldButton.Height = 0;
            }
        }
        //Đổi người chơi + hiện cờ trên bàn cờ
        void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            //Đổi hình Chess_Square 
            if (btn.BackgroundImage != null)
                return;

            Mark(btn);

            ChangePlayer();
        }
        private void Mark(Button btn)
        {
            btn.BackgroundImage = Player[CurrentPlayer].Mark;

            CurrentPlayer = CurrentPlayer == 1 ? 0 : 1;
        }
        private void ChangePlayer()
        {
            PlayerName.Text = Player[CurrentPlayer].Name;

            PlayerMark.Image = Player[CurrentPlayer].Mark;
        }
        #endregion
    }
}
