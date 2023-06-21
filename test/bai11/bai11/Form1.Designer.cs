namespace bai11
{
    partial class tool
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tool));
            this.textBoxfilepath = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewdata = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._2FA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proxy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cookie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Token = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxproxy = new System.Windows.Forms.TextBox();
            this.button3run = new System.Windows.Forms.Button();
            this.numericUpDownluong = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewdata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownluong)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxfilepath
            // 
            this.textBoxfilepath.Location = new System.Drawing.Point(167, 25);
            this.textBoxfilepath.Name = "textBoxfilepath";
            this.textBoxfilepath.Size = new System.Drawing.Size(268, 22);
            this.textBoxfilepath.TabIndex = 0;
            this.textBoxfilepath.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Đường dẫn file: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(475, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Nhập tài khoản";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewdata
            // 
            this.dataGridViewdata.AllowUserToAddRows = false;
            this.dataGridViewdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Uid,
            this.Pass,
            this._2FA,
            this.Proxy,
            this.Cookie,
            this.Token,
            this.Status});
            this.dataGridViewdata.Location = new System.Drawing.Point(24, 86);
            this.dataGridViewdata.Name = "dataGridViewdata";
            this.dataGridViewdata.RowHeadersVisible = false;
            this.dataGridViewdata.RowHeadersWidth = 51;
            this.dataGridViewdata.RowTemplate.Height = 24;
            this.dataGridViewdata.Size = new System.Drawing.Size(1005, 410);
            this.dataGridViewdata.TabIndex = 4;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.Width = 125;
            // 
            // Uid
            // 
            this.Uid.HeaderText = "Uid";
            this.Uid.MinimumWidth = 6;
            this.Uid.Name = "Uid";
            this.Uid.Width = 125;
            // 
            // Pass
            // 
            this.Pass.HeaderText = "Pass";
            this.Pass.MinimumWidth = 6;
            this.Pass.Name = "Pass";
            this.Pass.Width = 125;
            // 
            // _2FA
            // 
            this._2FA.HeaderText = "_2FA";
            this._2FA.MinimumWidth = 6;
            this._2FA.Name = "_2FA";
            this._2FA.Width = 125;
            // 
            // Proxy
            // 
            this.Proxy.HeaderText = "Proxy";
            this.Proxy.MinimumWidth = 6;
            this.Proxy.Name = "Proxy";
            this.Proxy.Width = 125;
            // 
            // Cookie
            // 
            this.Cookie.HeaderText = "Cookie";
            this.Cookie.MinimumWidth = 6;
            this.Cookie.Name = "Cookie";
            this.Cookie.Width = 125;
            // 
            // Token
            // 
            this.Token.HeaderText = "Token";
            this.Token.MinimumWidth = 6;
            this.Token.Name = "Token";
            this.Token.Width = 125;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.Width = 125;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(475, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Nhập proxy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Đường dẫn proxy: ";
            // 
            // textBoxproxy
            // 
            this.textBoxproxy.Location = new System.Drawing.Point(167, 57);
            this.textBoxproxy.Name = "textBoxproxy";
            this.textBoxproxy.Size = new System.Drawing.Size(268, 22);
            this.textBoxproxy.TabIndex = 5;
            // 
            // button3run
            // 
            this.button3run.Location = new System.Drawing.Point(835, 21);
            this.button3run.Name = "button3run";
            this.button3run.Size = new System.Drawing.Size(147, 23);
            this.button3run.TabIndex = 8;
            this.button3run.Text = "Chạy";
            this.button3run.UseVisualStyleBackColor = true;
            this.button3run.Click += new System.EventHandler(this.button3run_Click);
            // 
            // numericUpDownluong
            // 
            this.numericUpDownluong.Location = new System.Drawing.Point(862, 50);
            this.numericUpDownluong.Name = "numericUpDownluong";
            this.numericUpDownluong.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownluong.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(783, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Số luồng: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 552);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownluong);
            this.Controls.Add(this.button3run);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxproxy);
            this.Controls.Add(this.dataGridViewdata);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxfilepath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "tool";
            this.Text = "Tool thử nghiệm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewdata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownluong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxfilepath;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewdata;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pass;
        private System.Windows.Forms.DataGridViewTextBoxColumn _2FA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proxy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cookie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Token;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxproxy;
        private System.Windows.Forms.Button button3run;
        private System.Windows.Forms.NumericUpDown numericUpDownluong;
        private System.Windows.Forms.Label label3;
    }
}

