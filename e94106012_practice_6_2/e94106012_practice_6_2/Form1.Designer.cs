namespace e94106012_practice_6_2
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.AmOrPm = new System.Windows.Forms.Label();
            this.btnChoose = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.path = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtWriteBtn = new System.Windows.Forms.Button();
            this.countNum = new System.Windows.Forms.NumericUpDown();
            this.activateBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.countNum)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("宋体", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(438, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 27);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("宋体", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(438, 228);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 27);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.Enabled = false;
            this.button3.Font = new System.Drawing.Font("宋体", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(819, 228);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 27);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.Enabled = false;
            this.button4.Font = new System.Drawing.Font("宋体", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.Location = new System.Drawing.Point(819, 142);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(25, 27);
            this.button4.TabIndex = 2;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AmOrPm
            // 
            this.AmOrPm.AutoSize = true;
            this.AmOrPm.Font = new System.Drawing.Font("宋体", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AmOrPm.Location = new System.Drawing.Point(1186, 254);
            this.AmOrPm.Name = "AmOrPm";
            this.AmOrPm.Size = new System.Drawing.Size(66, 27);
            this.AmOrPm.TabIndex = 4;
            this.AmOrPm.Text = "上午";
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(99, 364);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(75, 23);
            this.btnChoose.TabIndex = 5;
            this.btnChoose.Text = "選擇鬧鈴";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // path
            // 
            this.path.AutoSize = true;
            this.path.Location = new System.Drawing.Point(180, 369);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(0, 12);
            this.path.TabIndex = 6;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.Location = new System.Drawing.Point(1280, 38);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(300, 300);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtWriteBtn
            // 
            this.txtWriteBtn.Location = new System.Drawing.Point(1280, 358);
            this.txtWriteBtn.Name = "txtWriteBtn";
            this.txtWriteBtn.Size = new System.Drawing.Size(75, 23);
            this.txtWriteBtn.TabIndex = 8;
            this.txtWriteBtn.Text = "匯出記錄檔";
            this.txtWriteBtn.UseVisualStyleBackColor = true;
            this.txtWriteBtn.Click += new System.EventHandler(this.textWriteBtn_Click);
            // 
            // countNum
            // 
            this.countNum.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.countNum.Location = new System.Drawing.Point(836, 351);
            this.countNum.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.countNum.Name = "countNum";
            this.countNum.Size = new System.Drawing.Size(155, 30);
            this.countNum.TabIndex = 9;
            this.countNum.ValueChanged += new System.EventHandler(this.countNum_ValueChanged);
            // 
            // activateBtn
            // 
            this.activateBtn.Location = new System.Drawing.Point(1012, 351);
            this.activateBtn.Name = "activateBtn";
            this.activateBtn.Size = new System.Drawing.Size(92, 30);
            this.activateBtn.TabIndex = 10;
            this.activateBtn.Text = "啟動";
            this.activateBtn.UseVisualStyleBackColor = true;
            this.activateBtn.Click += new System.EventHandler(this.activateBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(687, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "設定鬧鐘時間";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.BackColor = System.Drawing.Color.White;
            this.timeLabel.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.timeLabel.Location = new System.Drawing.Point(839, 356);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(109, 20);
            this.timeLabel.TabIndex = 12;
            this.timeLabel.Text = "上午 00:00";
            this.timeLabel.Click += new System.EventHandler(this.timeLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1598, 431);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.activateBtn);
            this.Controls.Add(this.countNum);
            this.Controls.Add(this.txtWriteBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.path);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.AmOrPm);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.countNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label AmOrPm;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label path;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button txtWriteBtn;
        private System.Windows.Forms.NumericUpDown countNum;
        private System.Windows.Forms.Button activateBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label timeLabel;
    }
}

