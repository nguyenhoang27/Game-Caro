using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Caro
{
    public partial class Form1 : Form
    {
        #region Properties
        ChessBoardManager ChessBoard;
        KetNoiMang socket;
        #endregion
        public Form1()
        {
            InitializeComponent();

            Control.CheckForIllegalCrossThreadCalls = false;

            ChessBoard = new ChessBoardManager(pnlChessBoard, txbPlayerName, pctbMark);
            ChessBoard.EndedGame += ChessBoard_EndedGame;
            ChessBoard.PlayerMarked += ChessBoard_PlayerMarked;
            

            pcbCircular.Step = Constant.COOL_DOWN_STEP;
            pcbCircular.Maximum = Constant.COOL_DOWN_TIME;
            pcbCircular.Value = 0;

            tmCoolDown.Interval = Constant.COOL_DOWN_INTERVAL;

            socket = new KetNoiMang();

            NewGame();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void EndGame()
        {
            tmCoolDown.Stop();
            pnlChessBoard.Enabled = false;
            undoToolStripMenuItem.Enabled = false;
            //MessageBox.Show("Kết thúc");
        }
        
        void NewGame()
        {
            pcbCircular.Value = 0;
            tmCoolDown.Stop();
            undoToolStripMenuItem.Enabled = true;
            ChessBoard.DrawChessBar();
        }

        void Exit()
        {
            Application.Exit();
        }

        void ChessBoard_PlayerMarked(object sender, ButtonClickEvent e)
        {
            tmCoolDown.Start();
            pnlChessBoard.Enabled = false;
            pcbCircular.Value = 0;

            socket.Send(new SocketData((int)SocketCommand.SEND_POINT, "", e.ClickedPoint));
            undoToolStripMenuItem.Enabled = false;
            Listen();
        }

        void ChessBoard_EndedGame(object sender, EventArgs e)
        {
            EndGame();
            socket.Send(new SocketData((int)SocketCommand.END_GAME, "", new Point()));
        }

        void Undo()
        {
            ChessBoard.Undo();
            tmCoolDown.Start();
            pcbCircular.Value = 0;
        }

        private void tmCoolDown_Tick(object sender, EventArgs e)
        {
            pcbCircular.PerformStep();

            if (pcbCircular.Value >= pcbCircular.Maximum)
            {
                EndGame();
                socket.Send(new SocketData((int)SocketCommand.TIME_OUT, "", new Point()));
            }
        }

        private void button2_Click(object sender, EventArgs e) //Exit
        {
            Exit();
        }

        private void btnPvsC_Click(object sender, EventArgs e)
        {

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
            socket.Send(new SocketData((int)SocketCommand.NEW_GAME, "", new Point()));
            pnlChessBoard.Enabled = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            NewGame();
            socket.Send(new SocketData((int)SocketCommand.NEW_GAME, "", new Point()));
            pnlChessBoard.Enabled = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (MaterialMessageBox.Show("Bạn có chắc muốn thoát", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            if (MessageBox.Show("Bạn có chắc muốn thoát", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                e.Cancel = true;
            else
            {
                try
                {
                    socket.Send(new SocketData((int)SocketCommand.QUIT, "", new Point()));
                }
                catch { }
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Undo();
            socket.Send(new SocketData((int)SocketCommand.UNDO, "", new Point()));
        } //Menu Undo

        private void btnPvsP_Click(object sender, EventArgs e)
        {
            socket.IP = txbIP.Text;

            if (!socket.ConnectServer()) //Kết nối với server không được thì tự tạo server.
            {
                socket.isServer = true;
                pnlChessBoard.Enabled = true;
                socket.CreateServer();

            }
            else
            {
                socket.isServer = false;
                pnlChessBoard.Enabled = false;
                Listen();
            }

        }

        void Listen() //Thực hiện Receive
        {
           
            
                Thread listenThread = new Thread(() =>
                {
                    try
                    {
                        SocketData data = (SocketData)socket.Receive();

                        ProcessData(data);
                    }
                    catch (Exception )
                    {
                    }

                });
                listenThread.IsBackground = true;
                listenThread.Start();
      

        }

        private void ProcessData(SocketData data)
        {
            switch (data.Command)
            {
                case (int)SocketCommand.NOTIFY:
                    MessageBox.Show(data.Message);
                    break;
                case (int)SocketCommand.NEW_GAME:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        NewGame();
                        pnlChessBoard.Enabled = false;
                    }));
                    break;
                case (int)SocketCommand.SEND_POINT:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        pcbCircular.Value = 0;
                        pnlChessBoard.Enabled = true;
                        tmCoolDown.Start();
                        ChessBoard.OtherPlayerMark(data.Point);
                        undoToolStripMenuItem.Enabled = true;
                    }));
                    break;
                case (int)SocketCommand.UNDO:
                    Undo();
                    pcbCircular.Value = 0;
                    break;
                case (int)SocketCommand.END_GAME:
                    MaterialMessageBoxOK.Show("Đã 5 con trên 1 hàng", "Thông báo", MessageBoxButtons.OK);
                    break;
                case (int)SocketCommand.TIME_OUT:
                    MaterialMessageBoxOK.Show("Hết giờ", "Thông báo", MessageBoxButtons.OK);
                    break;
                case (int)SocketCommand.QUIT:
                    tmCoolDown.Stop();
                    MaterialMessageBoxOK.Show("Người chơi đã thoát!!", "Thông báo", MessageBoxButtons.OK);
                    break;
                default:
                    break;
            }

            Listen();
        }


        private void Form1_Shown(object sender, EventArgs e)
        {
            pnlChessBoard.Enabled = false;
            txbIP.Text = socket.GetLocalIPv4(NetworkInterfaceType.Wireless80211);
            if (string.IsNullOrEmpty(txbIP.Text))
            {
                txbIP.Text = socket.GetLocalIPv4(NetworkInterfaceType.Ethernet);
            }
        }

        private void pcbCircular_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaterialMessageBoxInfo.Show("\n\nTrường Đại học Công nghệ thông tin\n\nLập trình trực quan - IT008.J11\n\nNguyễn Minh Hoàng - 15520257", "Thông tin", MessageBoxButtons.OK);
        }
    }
}
