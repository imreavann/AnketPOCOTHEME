namespace AnketWINFORM
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nameLBL = new System.Windows.Forms.Label();
            this.surnameLBL = new System.Windows.Forms.Label();
            this.ageLBL = new System.Windows.Forms.Label();
            this.genderLBL = new System.Windows.Forms.Label();
            this.nameTXTBOX = new System.Windows.Forms.TextBox();
            this.surnameTXTBOX = new System.Windows.Forms.TextBox();
            this.ageTXTBOX = new System.Windows.Forms.TextBox();
            this.genderTXTBOX = new System.Windows.Forms.TextBox();
            this.savefileBTN = new System.Windows.Forms.Button();
            this.loadfileBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AnketWINFORM.Properties.Resources.Xiaomi_logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(573, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // nameLBL
            // 
            this.nameLBL.AutoSize = true;
            this.nameLBL.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nameLBL.Location = new System.Drawing.Point(151, 205);
            this.nameLBL.Name = "nameLBL";
            this.nameLBL.Size = new System.Drawing.Size(111, 34);
            this.nameLBL.TabIndex = 1;
            this.nameLBL.Text = "Adınız:";
            // 
            // surnameLBL
            // 
            this.surnameLBL.AutoSize = true;
            this.surnameLBL.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.surnameLBL.Location = new System.Drawing.Point(101, 242);
            this.surnameLBL.Name = "surnameLBL";
            this.surnameLBL.Size = new System.Drawing.Size(161, 34);
            this.surnameLBL.TabIndex = 2;
            this.surnameLBL.Text = "Soyadınız:";
            // 
            // ageLBL
            // 
            this.ageLBL.AutoSize = true;
            this.ageLBL.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ageLBL.Location = new System.Drawing.Point(138, 276);
            this.ageLBL.Name = "ageLBL";
            this.ageLBL.Size = new System.Drawing.Size(124, 34);
            this.ageLBL.TabIndex = 3;
            this.ageLBL.Text = "Yaşınız:";
            // 
            // genderLBL
            // 
            this.genderLBL.AutoSize = true;
            this.genderLBL.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.genderLBL.Location = new System.Drawing.Point(125, 310);
            this.genderLBL.Name = "genderLBL";
            this.genderLBL.Size = new System.Drawing.Size(137, 34);
            this.genderLBL.TabIndex = 4;
            this.genderLBL.Text = "Cinsiniz:";
            // 
            // nameTXTBOX
            // 
            this.nameTXTBOX.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nameTXTBOX.Location = new System.Drawing.Point(268, 205);
            this.nameTXTBOX.Name = "nameTXTBOX";
            this.nameTXTBOX.Size = new System.Drawing.Size(139, 29);
            this.nameTXTBOX.TabIndex = 5;
            // 
            // surnameTXTBOX
            // 
            this.surnameTXTBOX.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.surnameTXTBOX.Location = new System.Drawing.Point(268, 240);
            this.surnameTXTBOX.Name = "surnameTXTBOX";
            this.surnameTXTBOX.Size = new System.Drawing.Size(139, 29);
            this.surnameTXTBOX.TabIndex = 6;
            // 
            // ageTXTBOX
            // 
            this.ageTXTBOX.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ageTXTBOX.Location = new System.Drawing.Point(268, 275);
            this.ageTXTBOX.Name = "ageTXTBOX";
            this.ageTXTBOX.Size = new System.Drawing.Size(139, 29);
            this.ageTXTBOX.TabIndex = 7;
            // 
            // genderTXTBOX
            // 
            this.genderTXTBOX.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.genderTXTBOX.Location = new System.Drawing.Point(268, 310);
            this.genderTXTBOX.Name = "genderTXTBOX";
            this.genderTXTBOX.Size = new System.Drawing.Size(139, 29);
            this.genderTXTBOX.TabIndex = 8;
            // 
            // savefileBTN
            // 
            this.savefileBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.savefileBTN.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.savefileBTN.ForeColor = System.Drawing.Color.White;
            this.savefileBTN.Location = new System.Drawing.Point(131, 358);
            this.savefileBTN.Name = "savefileBTN";
            this.savefileBTN.Size = new System.Drawing.Size(131, 53);
            this.savefileBTN.TabIndex = 9;
            this.savefileBTN.Text = "Save File";
            this.savefileBTN.UseVisualStyleBackColor = false;
            this.savefileBTN.Click += new System.EventHandler(this.savefileBTN_Click);
            // 
            // loadfileBTN
            // 
            this.loadfileBTN.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loadfileBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.loadfileBTN.Location = new System.Drawing.Point(268, 358);
            this.loadfileBTN.Name = "loadfileBTN";
            this.loadfileBTN.Size = new System.Drawing.Size(139, 53);
            this.loadfileBTN.TabIndex = 10;
            this.loadfileBTN.Text = "Load File";
            this.loadfileBTN.UseVisualStyleBackColor = true;
            this.loadfileBTN.Click += new System.EventHandler(this.loadfileBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(559, 450);
            this.Controls.Add(this.loadfileBTN);
            this.Controls.Add(this.savefileBTN);
            this.Controls.Add(this.genderTXTBOX);
            this.Controls.Add(this.ageTXTBOX);
            this.Controls.Add(this.surnameTXTBOX);
            this.Controls.Add(this.nameTXTBOX);
            this.Controls.Add(this.genderLBL);
            this.Controls.Add(this.ageLBL);
            this.Controls.Add(this.surnameLBL);
            this.Controls.Add(this.nameLBL);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximumSize = new System.Drawing.Size(575, 489);
            this.MinimumSize = new System.Drawing.Size(575, 489);
            this.Name = "Form1";
            this.Text = "Anket";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label nameLBL;
        private System.Windows.Forms.Label surnameLBL;
        private System.Windows.Forms.Label ageLBL;
        private System.Windows.Forms.Label genderLBL;
        private System.Windows.Forms.TextBox nameTXTBOX;
        private System.Windows.Forms.TextBox surnameTXTBOX;
        private System.Windows.Forms.TextBox ageTXTBOX;
        private System.Windows.Forms.TextBox genderTXTBOX;
        private System.Windows.Forms.Button savefileBTN;
        private System.Windows.Forms.Button loadfileBTN;
    }
}

