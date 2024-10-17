using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace e94106012_practice_6_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Button[][][] btn  = new Button[6][][];
        private void Form1_Load(object sender, EventArgs e)
        {
            Reset_Buttons(sender,e);
            timer1.Enabled = true;    // 預設開啟計時器
            timer1.Interval = 1000;    //(1秒)
            timer2.Enabled = false;
            timer2.Interval = 1000;    //(1秒)
            textBox1.Text = "";
        }

        public void Reset_Buttons(object sender, EventArgs e)
        {
            // 初始化按钮数组
            btn = new Button[6][][];
            for (int i = 0; i < 6; i++)
            {
                btn[i] = new Button[7][];
                for (int j = 0; j < 7; j++)
                {
                    btn[i][j] = new Button[5];
                }
            }

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    for (int k = 0; k < 5; k++)
                    {
                        btn[i][j][k] = new Button();
                        btn[i][j][k].SetBounds((100 + (190 * i)) + (26 * k), 100 + (26 * j), 30, 30); //(starting point X, starting point Y, width, height)
                        Controls.Add(btn[i][j][k]);
                        btn[i][j][k].Enabled = false;
                    }
                }
            }
        }//重設按鈕
        
        private void Set_Button_Number(int number, int btnnum)
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    for (int k = 0; k < 5; k++)
                    {
                        btn[btnnum][j][k].BackColor = Color.White;

                    }
                }
            }
            if (number == 0)
            {
                btn[btnnum][0][1].BackColor = Color.Blue;
                btn[btnnum][0][2].BackColor = Color.Blue;
                btn[btnnum][0][3].BackColor = Color.Blue;
                btn[btnnum][1][0].BackColor = Color.Blue;
                btn[btnnum][1][4].BackColor = Color.Blue;
                btn[btnnum][2][0].BackColor = Color.Blue;
                btn[btnnum][2][4].BackColor = Color.Blue;
                btn[btnnum][4][0].BackColor = Color.Blue;
                btn[btnnum][4][4].BackColor = Color.Blue;
                btn[btnnum][5][0].BackColor = Color.Blue;
                btn[btnnum][5][4].BackColor = Color.Blue;
                btn[btnnum][6][1].BackColor = Color.Blue;
                btn[btnnum][6][2].BackColor = Color.Blue;
                btn[btnnum][6][3].BackColor = Color.Blue;
            }
            else if (number == 1)
            {
                // 设置数字1的部分按钮背景颜色
                btn[btnnum][1][4].BackColor = Color.Blue;
                btn[btnnum][2][4].BackColor = Color.Blue;
                btn[btnnum][4][4].BackColor = Color.Blue;
                btn[btnnum][5][4].BackColor = Color.Blue;
            }
            else if (number == 2)
            {
                // 设置数字2的部分按钮背景颜色
                btn[btnnum][0][1].BackColor = Color.Blue;
                btn[btnnum][0][2].BackColor = Color.Blue;
                btn[btnnum][0][3].BackColor = Color.Blue;
                btn[btnnum][1][4].BackColor = Color.Blue;
                btn[btnnum][2][4].BackColor = Color.Blue;
                btn[btnnum][3][1].BackColor = Color.Blue;
                btn[btnnum][3][2].BackColor = Color.Blue;
                btn[btnnum][3][3].BackColor = Color.Blue;
                btn[btnnum][4][0].BackColor = Color.Blue;
                btn[btnnum][5][0].BackColor = Color.Blue;
                btn[btnnum][6][1].BackColor = Color.Blue;
                btn[btnnum][6][2].BackColor = Color.Blue;
                btn[btnnum][6][3].BackColor = Color.Blue;
            }
            else if (number == 3)
            {
                // 设置数字3的部分按钮背景颜色
                btn[btnnum][0][1].BackColor = Color.Blue;
                btn[btnnum][0][2].BackColor = Color.Blue;
                btn[btnnum][0][3].BackColor = Color.Blue;
                btn[btnnum][1][4].BackColor = Color.Blue;
                btn[btnnum][2][4].BackColor = Color.Blue;
                btn[btnnum][3][1].BackColor = Color.Blue;
                btn[btnnum][3][2].BackColor = Color.Blue;
                btn[btnnum][3][3].BackColor = Color.Blue;
                btn[btnnum][4][4].BackColor = Color.Blue;
                btn[btnnum][5][4].BackColor = Color.Blue;
                btn[btnnum][6][1].BackColor = Color.Blue;
                btn[btnnum][6][2].BackColor = Color.Blue;
                btn[btnnum][6][3].BackColor = Color.Blue;
            }
            else if (number ==4)
            {
                // 设置数字4的部分按钮背景颜色
                btn[btnnum][1][0].BackColor = Color.Blue;
                btn[btnnum][1][4].BackColor = Color.Blue;
                btn[btnnum][2][0].BackColor = Color.Blue;
                btn[btnnum][2][4].BackColor = Color.Blue;
                btn[btnnum][3][1].BackColor = Color.Blue;
                btn[btnnum][3][2].BackColor = Color.Blue;
                btn[btnnum][3][3].BackColor = Color.Blue;
                btn[btnnum][4][4].BackColor = Color.Blue;
                btn[btnnum][5][4].BackColor = Color.Blue;
            }
            else if (number == 5)
            {
                // 设置数字5的部分按钮背景颜色
                btn[btnnum][0][1].BackColor = Color.Blue;
                btn[btnnum][0][2].BackColor = Color.Blue;
                btn[btnnum][0][3].BackColor = Color.Blue;
                btn[btnnum][1][0].BackColor = Color.Blue;
                btn[btnnum][2][0].BackColor = Color.Blue;
                btn[btnnum][3][1].BackColor = Color.Blue;
                btn[btnnum][3][2].BackColor = Color.Blue;
                btn[btnnum][3][3].BackColor = Color.Blue;
                btn[btnnum][4][4].BackColor = Color.Blue;
                btn[btnnum][5][4].BackColor = Color.Blue;
                btn[btnnum][6][1].BackColor = Color.Blue;
                btn[btnnum][6][2].BackColor = Color.Blue;
                btn[btnnum][6][3].BackColor = Color.Blue;
            }
            else if (number == 6)
            {
                // 设置数字6的部分按钮背景颜色
                btn[btnnum][0][1].BackColor = Color.Blue;
                btn[btnnum][0][2].BackColor = Color.Blue;
                btn[btnnum][0][3].BackColor = Color.Blue;
                btn[btnnum][1][0].BackColor = Color.Blue;
                btn[btnnum][2][0].BackColor = Color.Blue;
                btn[btnnum][3][1].BackColor = Color.Blue;
                btn[btnnum][3][2].BackColor = Color.Blue;
                btn[btnnum][3][3].BackColor = Color.Blue;
                btn[btnnum][4][4].BackColor = Color.Blue;
                btn[btnnum][4][0].BackColor = Color.Blue;
                btn[btnnum][5][4].BackColor = Color.Blue;
                btn[btnnum][5][0].BackColor = Color.Blue;
                btn[btnnum][6][1].BackColor = Color.Blue;
                btn[btnnum][6][2].BackColor = Color.Blue;
                btn[btnnum][6][3].BackColor = Color.Blue;
            }
            else if (number == 7)
            {
                // 设置数字7的部分按钮背景颜色
                btn[btnnum][0][1].BackColor = Color.Blue;
                btn[btnnum][0][2].BackColor = Color.Blue;
                btn[btnnum][0][3].BackColor = Color.Blue;
                btn[btnnum][1][4].BackColor = Color.Blue;
                btn[btnnum][2][4].BackColor = Color.Blue;
                btn[btnnum][4][4].BackColor = Color.Blue;
                btn[btnnum][5][4].BackColor = Color.Blue;
            }
            else if (number == 8)
            {
                // 设置数字8的部分按钮背景颜色
                btn[btnnum][0][1].BackColor = Color.Blue;
                btn[btnnum][0][2].BackColor = Color.Blue;
                btn[btnnum][0][3].BackColor = Color.Blue;
                btn[btnnum][1][0].BackColor = Color.Blue;
                btn[btnnum][2][0].BackColor = Color.Blue;
                btn[btnnum][1][4].BackColor = Color.Blue;
                btn[btnnum][2][4].BackColor = Color.Blue;
                btn[btnnum][3][1].BackColor = Color.Blue;
                btn[btnnum][3][2].BackColor = Color.Blue;
                btn[btnnum][3][3].BackColor = Color.Blue;
                btn[btnnum][4][0].BackColor = Color.Blue;
                btn[btnnum][4][4].BackColor = Color.Blue;
                btn[btnnum][5][0].BackColor = Color.Blue;
                btn[btnnum][5][4].BackColor = Color.Blue;
                btn[btnnum][6][1].BackColor = Color.Blue;
                btn[btnnum][6][2].BackColor = Color.Blue;
                btn[btnnum][6][3].BackColor = Color.Blue;
            }
            else if (number == 9)
            {
                // 设置数字9的部分按钮背景颜色
                btn[btnnum][0][1].BackColor = Color.Blue;
                btn[btnnum][0][2].BackColor = Color.Blue;
                btn[btnnum][0][3].BackColor = Color.Blue;
                btn[btnnum][1][0].BackColor = Color.Blue;
                btn[btnnum][2][0].BackColor = Color.Blue;
                btn[btnnum][1][4].BackColor = Color.Blue;
                btn[btnnum][2][4].BackColor = Color.Blue;
                btn[btnnum][3][1].BackColor = Color.Blue;
                btn[btnnum][3][2].BackColor = Color.Blue;
                btn[btnnum][3][3].BackColor = Color.Blue;
                btn[btnnum][4][4].BackColor = Color.Blue;
                btn[btnnum][5][4].BackColor = Color.Blue;
                btn[btnnum][6][1].BackColor = Color.Blue;
                btn[btnnum][6][2].BackColor = Color.Blue;
                btn[btnnum][6][3].BackColor = Color.Blue;
            }



        }//設定數字的樣式

        int clkhour, clkminute,clksecond;
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            // 获取当前时间的小时
            clkhour = now.Hour;
            // 获取当前时间的分钟
            clkminute = now.Minute;
            // 获取当前时间的秒
            clksecond = now.Second;
            if(clkhour < 12)
            {
                AmOrPm.Text = "上午";
            }
            else
            {
                AmOrPm.Text = "下午";
            }
            Set_Button_Number(0, 0);
            Set_Button_Number(clkhour % 10, 1);
            Set_Button_Number(clkminute / 10, 2);
            Set_Button_Number(clkminute % 10, 3);
            Set_Button_Number(clksecond / 10, 4);
            Set_Button_Number(clksecond % 10, 5);
        }//即時更新時鐘

        SoundPlayer player1 = new SoundPlayer();        // 建立播放器物件

        private void btnChoose_Click(object sender, EventArgs e)//鬧鈴檔案
        {
            String stFilter = "WAV(*.wav)|*.wav";
            openFileDialog1.Filter = stFilter;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path.Text = openFileDialog1.FileName;
                DateTime now = DateTime.Now;
                textBox1.Text += String.Format("{0}:已設定鬧鈴\r\n", now.ToString());
                player1.SoundLocation = path.Text;           // 指定音效所在路徑檔名
                player1.Load();                                 // 載入音效檔資料
                
            }
        }

        private void textWriteBtn_Click(object sender, EventArgs e)//匯出記錄檔
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "文本文件|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                using (FileStream fsOut = new FileStream(filePath, FileMode.Create))
                using (BinaryWriter bw = new BinaryWriter(fsOut))
                {
                    bw.Write(textBox1.Text);
                    bw.Flush();
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            if ( (clkhour == (hours0*10 + hours1) ) && (clkminute == (minutes0*10 +minutes1) ))
            {
                timer2.Enabled = false;
                player1.PlayLooping();
                textBox1.Text += String.Format("{0}:鬧鐘響鈴\r\n", now.ToString());
                MessageBox.Show("時間到！該起床囉~", "", MessageBoxButtons.OK);
            }
        }//當鬧鐘跟時鐘一樣時播放鈴聲

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        int hours0, hours1;
        int minutes0, minutes1;

        private void timeLabel_Click(object sender, EventArgs e)
        {

        }

        private void activateBtn_Click(object sender, EventArgs e)//啟動&停止鬧鈴
        {
            DateTime now = DateTime.Now;
            if (activateBtn.Text == "啟動" && !(path.Text == ""))
            {
                textBox1.Text += String.Format("{0}:已設定鬧鐘\r\n", now.ToString());
                timer2.Enabled = true;
                activateBtn.Text = "停止"; 
            }
            else if(path.Text == "")
            {
                MessageBox.Show("請先設定鬧鈴!", "", MessageBoxButtons.OK);
            }
            else
            {
                activateBtn.Text = "啟動";
                textBox1.Text += String.Format("{0}:已關閉鬧鐘\r\n", now.ToString());
                player1.Stop();     
                
            }
        }

        string APm;
        private void countNum_ValueChanged(object sender, EventArgs e)
        {
            
            minutes0 = ((int)countNum.Value % 60)/10;
            minutes1 = ((int)countNum.Value % 60) % 10;
            hours0 = ((int)countNum.Value / 60) / 10;
            hours1 = ((int)countNum.Value / 60) % 10;
            if (((int)countNum.Value / 60) < 12)
            {
                APm = "上午";
            }
            else
            {
                APm = "下午";
            }
            if ((hours0 * 10 + hours1) >= 12)
            {
                hours0 -= 1;
                hours1 -= 2;
            }
            // 将小时转换为下午时间
            timeLabel.Text = String.Format("{0} {1}{2}:{3}{4}", APm, hours0, hours1, minutes0, minutes1);

        }//設定鬧鐘時間
    }
}
