namespace poker
{
    partial class frmPicTest
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDeal = new System.Windows.Forms.Button();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.txtBet = new System.Windows.Forms.TextBox();
            this.btnBet = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.picCard4 = new System.Windows.Forms.PictureBox();
            this.picCard2 = new System.Windows.Forms.PictureBox();
            this.picCard5 = new System.Windows.Forms.PictureBox();
            this.picCard3 = new System.Windows.Forms.PictureBox();
            this.picCard1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnChange = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDeal
            // 
            this.btnDeal.BackColor = System.Drawing.Color.Lavender;
            this.btnDeal.Location = new System.Drawing.Point(22, 51);
            this.btnDeal.Name = "btnDeal";
            this.btnDeal.Size = new System.Drawing.Size(100, 60);
            this.btnDeal.TabIndex = 0;
            this.btnDeal.Text = "發牌";
            this.btnDeal.UseVisualStyleBackColor = false;
            this.btnDeal.Click += new System.EventHandler(this.btnDeal_Click);
            // 
            // txtMoney
            // 
            this.txtMoney.Location = new System.Drawing.Point(157, 53);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(286, 36);
            this.txtMoney.TabIndex = 6;
            this.txtMoney.TextChanged += new System.EventHandler(this.txtMoney_TextChanged);
            // 
            // txtBet
            // 
            this.txtBet.Location = new System.Drawing.Point(157, 118);
            this.txtBet.Name = "txtBet";
            this.txtBet.Size = new System.Drawing.Size(286, 36);
            this.txtBet.TabIndex = 7;
            this.txtBet.TextChanged += new System.EventHandler(this.txtBet_TextChanged);
            // 
            // btnBet
            // 
            this.btnBet.BackColor = System.Drawing.Color.Lavender;
            this.btnBet.Location = new System.Drawing.Point(631, 62);
            this.btnBet.Name = "btnBet";
            this.btnBet.Size = new System.Drawing.Size(194, 101);
            this.btnBet.TabIndex = 8;
            this.btnBet.Text = "押注";
            this.btnBet.UseVisualStyleBackColor = false;
            this.btnBet.Click += new System.EventHandler(this.btnBet_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.Lavender;
            this.btnCheck.Location = new System.Drawing.Point(138, 51);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(86, 126);
            this.btnCheck.TabIndex = 9;
            this.btnCheck.Text = "判斷牌型";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(240, 99);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(585, 36);
            this.txtResult.TabIndex = 10;
            this.txtResult.TextChanged += new System.EventHandler(this.txtResult_TextChanged);
            // 
            // picCard4
            // 
            this.picCard4.Image = global::poker.Properties.Resources.d2;
            this.picCard4.Location = new System.Drawing.Point(541, 48);
            this.picCard4.Name = "picCard4";
            this.picCard4.Size = new System.Drawing.Size(100, 150);
            this.picCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCard4.TabIndex = 12;
            this.picCard4.TabStop = false;
            this.picCard4.Click += new System.EventHandler(this.picCard_Click);
            // 
            // picCard2
            // 
            this.picCard2.Image = global::poker.Properties.Resources.d10;
            this.picCard2.Location = new System.Drawing.Point(176, 48);
            this.picCard2.Name = "picCard2";
            this.picCard2.Size = new System.Drawing.Size(100, 150);
            this.picCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCard2.TabIndex = 11;
            this.picCard2.TabStop = false;
            this.picCard2.Click += new System.EventHandler(this.picCard_Click);
            // 
            // picCard5
            // 
            this.picCard5.Image = global::poker.Properties.Resources.d3;
            this.picCard5.Location = new System.Drawing.Point(725, 48);
            this.picCard5.Name = "picCard5";
            this.picCard5.Size = new System.Drawing.Size(100, 150);
            this.picCard5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCard5.TabIndex = 5;
            this.picCard5.TabStop = false;
            this.picCard5.Click += new System.EventHandler(this.picCard_Click);
            // 
            // picCard3
            // 
            this.picCard3.Image = global::poker.Properties.Resources.d11;
            this.picCard3.Location = new System.Drawing.Point(354, 48);
            this.picCard3.Name = "picCard3";
            this.picCard3.Size = new System.Drawing.Size(100, 150);
            this.picCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCard3.TabIndex = 3;
            this.picCard3.TabStop = false;
            this.picCard3.Click += new System.EventHandler(this.picCard_Click);
            // 
            // picCard1
            // 
            this.picCard1.Image = global::poker.Properties.Resources.d1;
            this.picCard1.Location = new System.Drawing.Point(22, 48);
            this.picCard1.Name = "picCard1";
            this.picCard1.Size = new System.Drawing.Size(100, 150);
            this.picCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCard1.TabIndex = 2;
            this.picCard1.TabStop = false;
            this.picCard1.Click += new System.EventHandler(this.picCard_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picCard1);
            this.groupBox1.Controls.Add(this.picCard4);
            this.groupBox1.Controls.Add(this.picCard2);
            this.groupBox1.Controls.Add(this.picCard3);
            this.groupBox1.Controls.Add(this.picCard5);
            this.groupBox1.Location = new System.Drawing.Point(50, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(850, 220);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "牌桌";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtMoney);
            this.groupBox2.Controls.Add(this.txtBet);
            this.groupBox2.Controls.Add(this.btnBet);
            this.groupBox2.Location = new System.Drawing.Point(50, 337);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(850, 200);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "下注";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "總資金";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "押注金額";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnChange);
            this.groupBox3.Controls.Add(this.btnDeal);
            this.groupBox3.Controls.Add(this.btnCheck);
            this.groupBox3.Controls.Add(this.txtResult);
            this.groupBox3.Location = new System.Drawing.Point(50, 581);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(850, 200);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "功能";
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.Lavender;
            this.btnChange.Location = new System.Drawing.Point(22, 117);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(100, 60);
            this.btnChange.TabIndex = 16;
            this.btnChange.Text = "換牌";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // frmPicTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 879);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPicTest";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDeal;
        private System.Windows.Forms.PictureBox picCard1;
        private System.Windows.Forms.PictureBox picCard3;
        private System.Windows.Forms.PictureBox picCard5;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.TextBox txtBet;
        private System.Windows.Forms.Button btnBet;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.PictureBox picCard2;
        private System.Windows.Forms.PictureBox picCard4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnChange;
    }
}

