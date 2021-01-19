using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Net.Sockets;
namespace tictactoe
{
    public partial class Form1 : Form
    {
        int playerStatus = 0;
        int scoreplayer1 = 0;
        int scoreplayer2 = 0;

        public Form1(/*bool isHost, string ip = null*/)
        {
            InitializeComponent();
            //MessageReceiver.DoWork += MessageReceiver_DoWork;
            //CheckForIllegalCrossThreadCalls = false;

            //if (isHost)
            //{
            //    playerStatus = 0;
            //    server = new TcpListener(System.Net.IPAddress.Any, 12);
            //    server.Start();
            //    soc = server.AcceptSocket();
            //}
            //else
            //{
            //    playerStatus = 1;
            //    try
            //    {
            //        user = new TcpClient(ip, 12);
            //        soc = user.Client;
            //        MessageReceiver.RunWorkerAsync();
            //    }
            //    catch(Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //        Close();
            //    }
            //}

        }

        //private void MessageReceiver_DoWork(object Sender, DoWorkEventArgs e)
        //{
        //    if (check())
        //    {
        //        return;
        //    }
        //    //freeze
        //    //opponent's turn
        //    ReceiveMove();
        //    //your turn
        //    if (!check())
        //    {
        //        //unfreeze
        //    }
        //}

        //private Socket soc;
        //private BackgroundWorker MessageReceiver = new BackgroundWorker();
        //private TcpListener server = null;
        //private TcpClient user;

        private void button2_Click(object sender, EventArgs e)
        {
            if (playerStatus == 0)
            {
                button2.Text = "O";
                playerStatus = 1;
                button2.Enabled = false;
            }
            else if (playerStatus == 1)
            {
                button2.Text = "X";
                playerStatus = 0;
                button2.Enabled = false;
            }
            check2();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            //byte[] num = { 1 };
            //soc.Send(num);
            if (playerStatus == 0)
            {
                button1.Text = "O";
                playerStatus = 1;
                button1.Enabled = false;
            }
            else if (playerStatus == 1)
            {
                button1.Text = "X";
                playerStatus = 0;
                button1.Enabled = false;
            }
            check2();
            //MessageReceiver.RunWorkerAsync();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (playerStatus == 0)
            {
                button3.Text = "O";
                playerStatus = 1;
                button3.Enabled = false;
            }
            else if (playerStatus == 1)
            {
                button3.Text = "X";
                playerStatus = 0;
                button3.Enabled = false;
            }
            check2();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (playerStatus == 0)
            {
                button4.Text = "O";
                playerStatus = 1;
                button4.Enabled = false;
            }
            else if (playerStatus == 1)
            {
                button4.Text = "X";
                playerStatus = 0;
                button4.Enabled = false;
            }
            check2();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (playerStatus == 0)
            {
                button5.Text = "O";
                playerStatus = 1;
                button5.Enabled = false;
            }
            else if (playerStatus == 1)
            {
                button5.Text = "X";
                playerStatus = 0;
                button5.Enabled = false;
            }
            check2();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (playerStatus == 0)
            {
                button6.Text = "O";
                playerStatus = 1;
                button6.Enabled = false;
            }
            else if (playerStatus == 1)
            {
                button6.Text = "X";
                playerStatus = 0;
                button6.Enabled = false;
            }
            check2();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (playerStatus == 0)
            {
                button7.Text = "O";
                playerStatus = 1;
                button7.Enabled = false;
            }
            else if (playerStatus == 1)
            {
                button7.Text = "X";
                playerStatus = 0;
                button7.Enabled = false;
            }
            check2();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (playerStatus == 0)
            {
                button8.Text = "O";
                playerStatus = 1;
                button8.Enabled = false;
            }
            else if (playerStatus == 1)
            {
                button8.Text = "X";
                playerStatus = 0;
                button8.Enabled = false;
            }
            check2();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (playerStatus == 0) 
            {
                button9.Text = "O";
                playerStatus = 1;
                button9.Enabled = false;
            }
            else if (playerStatus == 1)
            {
                button9.Text = "X";
                playerStatus = 0;
                button9.Enabled = false;
            }
            check2();
            //{
            //    return;
            //}
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        //void (hapus return) or bool
        private /*bool*/ void check()
        {
            if (button1.Text != "" && button2.Text != "" && button3.Text != "")
            {
                if (button1.Text == button2.Text && button1.Text == button3.Text)
                {
                    button1.BackColor = Color.Chartreuse;
                    button1.ForeColor = Color.Chartreuse;
                    button2.BackColor = Color.Chartreuse;
                    button2.ForeColor = Color.Chartreuse;
                    button3.BackColor = Color.Chartreuse;
                    button3.ForeColor = Color.Chartreuse;
                    if (button1.Text == "O")
                    {
                        MessageBox.Show("Player 1 Wins!");
                        scoreplayer1++;
                        string scorep1 = Convert.ToString(scoreplayer1);
                        labelScorePlayer1.Text = scorep1;
                        reset();
                    }
                    else
                    {
                        MessageBox.Show("Player 2 Wins!");
                        scoreplayer2++;
                        string scorep2 = Convert.ToString(scoreplayer2);
                        labelScorePlayer2.Text = scorep2;
                        reset();
                    }
                    //return true;
                }
                //return false;
            }
            else if (button1.Text != "" && button4.Text != "" && button7.Text != "")
            {
                if (button1.Text == button4.Text && button1.Text == button7.Text)
                {
                    button1.BackColor = Color.Chartreuse;
                    button1.ForeColor = Color.Chartreuse;
                    button4.BackColor = Color.Chartreuse;
                    button4.ForeColor = Color.Chartreuse;
                    button7.BackColor = Color.Chartreuse;
                    button7.ForeColor = Color.Chartreuse;
                    if (button1.Text == "O")
                    {
                        MessageBox.Show("Player 1 Wins!");
                        scoreplayer1++;
                        string scorep1 = Convert.ToString(scoreplayer1);
                        labelScorePlayer1.Text = scorep1;
                        reset();
                    }
                    else
                    {
                        MessageBox.Show("Player 2 Wins!");
                        scoreplayer2++;
                        string scorep2 = Convert.ToString(scoreplayer2);
                        labelScorePlayer2.Text = scorep2;
                        reset();
                    }
                    //return true;
                }
                //return false;
            }
            else if (button2.Text != "" && button5.Text != "" && button8.Text != "")
            {
                if (button2.Text == button5.Text && button2.Text == button8.Text)
                {
                    button2.BackColor = Color.Chartreuse;
                    button2.ForeColor = Color.Chartreuse;
                    button5.BackColor = Color.Chartreuse;
                    button5.ForeColor = Color.Chartreuse;
                    button8.BackColor = Color.Chartreuse;
                    button8.ForeColor = Color.Chartreuse;
                    if (button2.Text == "O")
                    {
                        MessageBox.Show("Player 1 Wins!");
                        scoreplayer1++;
                        string scorep1 = Convert.ToString(scoreplayer1);
                        labelScorePlayer1.Text = scorep1;
                        reset();
                    }
                    else
                    {
                        MessageBox.Show("Player 2 Wins!");
                        scoreplayer2++;
                        string scorep2 = Convert.ToString(scoreplayer2);
                        labelScorePlayer2.Text = scorep2;
                        reset();
                    }
                    //return true;
                }
                //return false;
            }

            else if (button3.Text != "" && button6.Text != "" && button9.Text != "")
            {
                if (button3.Text == button6.Text && button3.Text == button9.Text)
                {
                    button3.BackColor = Color.Chartreuse;
                    button3.ForeColor = Color.Chartreuse;
                    button6.BackColor = Color.Chartreuse;
                    button6.ForeColor = Color.Chartreuse;
                    button9.BackColor = Color.Chartreuse;
                    button9.ForeColor = Color.Chartreuse;
                    if (button3.Text == "O")
                    {
                        MessageBox.Show("Player 1 Wins!");
                        scoreplayer1++;
                        string scorep1 = Convert.ToString(scoreplayer1);
                        labelScorePlayer1.Text = scorep1;
                        reset();
                    }
                    else
                    {
                        MessageBox.Show("Player 2 Wins!");
                        scoreplayer2++;
                        string scorep2 = Convert.ToString(scoreplayer2);
                        labelScorePlayer2.Text = scorep2;
                        reset();
                    }
                    //return true;
                }
                //return false;
            }

            else if (button4.Text != "" && button5.Text != "" && button6.Text != "")
            {
                if (button4.Text == button5.Text && button4.Text == button6.Text)
                {
                    button4.BackColor = Color.Chartreuse;
                    button4.ForeColor = Color.Chartreuse;
                    button5.BackColor = Color.Chartreuse;
                    button5.ForeColor = Color.Chartreuse;
                    button6.BackColor = Color.Chartreuse;
                    button6.ForeColor = Color.Chartreuse;
                    if (button4.Text == "O")
                    {
                        MessageBox.Show("Player 1 Wins!");
                        scoreplayer1++;
                        string scorep1 = Convert.ToString(scoreplayer1);
                        labelScorePlayer1.Text = scorep1;
                        reset();
                    }
                    else
                    {
                        MessageBox.Show("Player 2 Wins!");
                        scoreplayer2++;
                        string scorep2 = Convert.ToString(scoreplayer2);
                        labelScorePlayer2.Text = scorep2;
                        reset();
                    }
                    //return true;
                }
                //return false;
            }

            else if (button7.Text != "" && button8.Text != "" && button9.Text != "")
            {
                if (button7.Text == button8.Text && button7.Text == button9.Text)
                {
                    button7.BackColor = Color.Chartreuse;
                    button7.ForeColor = Color.Chartreuse;
                    button8.BackColor = Color.Chartreuse;
                    button8.ForeColor = Color.Chartreuse;
                    button9.BackColor = Color.Chartreuse;
                    button9.ForeColor = Color.Chartreuse;
                    if (button7.Text == "O")
                    {
                        MessageBox.Show("Player 1 Wins!");
                        scoreplayer1++;
                        string scorep1 = Convert.ToString(scoreplayer1);
                        labelScorePlayer1.Text = scorep1;
                        reset();
                    }
                    else
                    {
                        MessageBox.Show("Player 2 Wins!");
                        scoreplayer2++;
                        string scorep2 = Convert.ToString(scoreplayer2);
                        labelScorePlayer2.Text = scorep2;
                        reset();
                    }
                    //return true;
                }
                //return false;
            }

            else if (button1.Text != "" && button5.Text != "" && button9.Text != "")
            {
                if (button1.Text == button5.Text && button1.Text == button9.Text)
                {
                    button1.BackColor = Color.Chartreuse;
                    button1.ForeColor = Color.Chartreuse;
                    button5.BackColor = Color.Chartreuse;
                    button5.ForeColor = Color.Chartreuse;
                    button9.BackColor = Color.Chartreuse;
                    button9.ForeColor = Color.Chartreuse;
                    if (button1.Text == "O")
                    {
                        MessageBox.Show("Player 1 Wins!");
                        scoreplayer1++;
                        string scorep1 = Convert.ToString(scoreplayer1);
                        labelScorePlayer1.Text = scorep1;
                        reset();
                    }
                    else
                    {
                        MessageBox.Show("Player 2 Wins!");
                        scoreplayer2++;
                        string scorep2 = Convert.ToString(scoreplayer2);
                        labelScorePlayer2.Text = scorep2;
                        reset();
                    }
                    //return true;
                }
                //return false;
            }

            if (button3.Text != "" && button5.Text != "" && button7.Text != "")
            {
                if (button3.Text == button5.Text && button3.Text == button7.Text)
                {
                    button3.BackColor = Color.LimeGreen;
                    button3.ForeColor = Color.White;
                    button5.BackColor = Color.LimeGreen;
                    button5.ForeColor = Color.White;
                    button7.BackColor = Color.LimeGreen;
                    button7.ForeColor = Color.White;
                    if (button3.Text == "O")
                    {
                        MessageBox.Show("Player 1 Wins!");
                        scoreplayer1++;
                        string scorep1 = Convert.ToString(scoreplayer1);
                        labelScorePlayer1.Text = scorep1;
                        reset();
                    }
                    else
                    {
                        MessageBox.Show("Player 2 Wins!");
                        scoreplayer2++;
                        string scorep2 = Convert.ToString(scoreplayer2);
                        labelScorePlayer2.Text = scorep2;
                        reset();
                    }
                    //return true;
                }
                //return false;
            }

            if (button1.Text != "" && button2.Text != "" && button3.Text != "" && button4.Text != "" && button5.Text != "" && button6.Text != "" && button7.Text != "" && button8.Text != "" && button9.Text != "")
            {
                MessageBox.Show("Draw !");
                reset();
                //return true;
            }
            //return false;

            //MessageBox.Show(this, index.Message, );
            

        }

        public int jumlahinput = 0;
        private void check2()
        {
            jumlahinput++;
            int siapamenang = 0;
            //cek baris 1
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                siapamenang = 1;
                

            }
            else if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                siapamenang = 2;
                
            }

            //cek baris 2
            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                siapamenang = 1;
                
            }
            else if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                siapamenang = 2;
                
            }

            //cek baris 3
            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                siapamenang = 1;
                
            }
            else if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                siapamenang = 2;
                
            }

            //cek kolom 1
            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                siapamenang = 1;
                
            }
            else if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                siapamenang = 2;
            }

            //cek kolom 2
            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                siapamenang = 1;
            }
            else if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                siapamenang = 2;
            }

            // cek kolom 3
            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                siapamenang = 1;
            }
            else if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                siapamenang = 2;
            }

            // cek diagonal kiri atas kanan bawah
            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                siapamenang = 1;
            }
            else if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                siapamenang = 2;
            }

            // cek diagonal kanan atas kiri bawah
            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                siapamenang = 1;
            }
            else if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                siapamenang = 2;
            }

            if (siapamenang == 1)
            {
                MessageBox.Show("Player 1");
                scoreplayer1++;
                string scorep1 = Convert.ToString(scoreplayer1);
                labelScorePlayer1.Text = scorep1;
                reset();
            }
            else if (siapamenang == 2)
            {
                MessageBox.Show("Player 2");
                scoreplayer2++;
                string scorep2 = Convert.ToString(scoreplayer2);
                labelScorePlayer2.Text = scorep2;
                reset();
            }
            else if (siapamenang == 0 && jumlahinput == 9)
            {
                MessageBox.Show("Draw");
                reset();
            }
        }

        private void reset()
        {
            playerStatus = 0;
            jumlahinput = 0;
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            button1.BackColor = Color.Transparent;
            button1.ForeColor = Color.Transparent;
            button2.BackColor = Color.Transparent;
            button2.ForeColor = Color.Transparent;
            button3.BackColor = Color.Transparent;
            button3.ForeColor = Color.Transparent;
            button4.BackColor = Color.Transparent;
            button4.ForeColor = Color.Transparent;
            button5.BackColor = Color.Transparent;
            button5.ForeColor = Color.Transparent;
            button6.BackColor = Color.Transparent;
            button6.ForeColor = Color.Transparent;
            button7.BackColor = Color.Transparent;
            button7.ForeColor = Color.Transparent;
            button8.BackColor = Color.Transparent;
            button8.ForeColor = Color.Transparent;
            button9.BackColor = Color.Transparent;
            button9.ForeColor = Color.Transparent;

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            var formplay = new Form2();
            formplay.Show();
        }

        private void ReceiveMove()
        {
            //byte[] buffer = new byte[1];
            //soc.Receive(buffer);
            //if (playerStatus == 0)
            //{
            //    if (buffer[0] == 0)
            //    {
            //        button1.Text = "O";
            //    }
            //    if (buffer[1] == 0)
            //    {
            //        button1.Text = "O";
            //    }
            //    if (buffer[2] == 0)
            //    {
            //        button1.Text = "O";
            //    }
            //    if (buffer[3] == 0)
            //    {
            //        button1.Text = "O";
            //    }
            //    if (buffer[4] == 0)
            //    {
            //        button1.Text = "O";
            //    }
            //    if (buffer[5] == 0)
            //    {
            //        button1.Text = "O";
            //    }
            //    if (buffer[6] == 0)
            //    {
            //        button1.Text = "O";
            //    }
            //    if (buffer[7] == 0)
            //    {
            //        button1.Text = "O";
            //    }
            //    if (buffer[8] == 0)
            //    {
            //        button1.Text = "O";
            //    }
            //}
            //if (playerStatus == 1)
            //{
            //    if (buffer[0] == 0)
            //    {
            //        button1.Text = "X";
            //    }
            //    if (buffer[1] == 0)
            //    {
            //        button1.Text = "X";
            //    }
            //    if (buffer[2] == 0)
            //    {
            //        button1.Text = "X";
            //    }
            //    if (buffer[3] == 0)
            //    {
            //        button1.Text = "X";
            //    }
            //    if (buffer[4] == 0)
            //    {
            //        button1.Text = "X";
            //    }
            //    if (buffer[5] == 0)
            //    {
            //        button1.Text = "X";
            //    }
            //    if (buffer[6] == 0)
            //    {
            //        button1.Text = "X";
            //    }
            //    if (buffer[7] == 0)
            //    {
            //        button1.Text = "X";
            //    }
            //    if (buffer[8] == 0)
            //    {
            //        button1.Text = "X";
            //    }
            //}

        }
    }
}
