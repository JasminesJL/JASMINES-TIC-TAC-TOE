namespace JASMINES__TIC_TAC_TOE
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Bot1 = new System.Windows.Forms.Button();
            this.Bot2 = new System.Windows.Forms.Button();
            this.Bot3 = new System.Windows.Forms.Button();
            this.Bot4 = new System.Windows.Forms.Button();
            this.Bot5 = new System.Windows.Forms.Button();
            this.Bot6 = new System.Windows.Forms.Button();
            this.Bot7 = new System.Windows.Forms.Button();
            this.Bot8 = new System.Windows.Forms.Button();
            this.Bot9 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Bot1
            // 
            this.Bot1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bot1.Location = new System.Drawing.Point(190, 93);
            this.Bot1.Name = "Bot1";
            this.Bot1.Size = new System.Drawing.Size(65, 65);
            this.Bot1.TabIndex = 0;
            this.Bot1.UseVisualStyleBackColor = true;
            this.Bot1.Click += new System.EventHandler(this.Bot1_Click);
            // 
            // Bot2
            // 
            this.Bot2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bot2.Location = new System.Drawing.Point(190, 173);
            this.Bot2.Name = "Bot2";
            this.Bot2.Size = new System.Drawing.Size(65, 65);
            this.Bot2.TabIndex = 1;
            this.Bot2.UseVisualStyleBackColor = true;
            this.Bot2.Click += new System.EventHandler(this.Bot2_Click);
            // 
            // Bot3
            // 
            this.Bot3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bot3.Location = new System.Drawing.Point(190, 253);
            this.Bot3.Name = "Bot3";
            this.Bot3.Size = new System.Drawing.Size(65, 65);
            this.Bot3.TabIndex = 2;
            this.Bot3.UseVisualStyleBackColor = true;
            this.Bot3.Click += new System.EventHandler(this.Bot3_Click);
            // 
            // Bot4
            // 
            this.Bot4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bot4.Location = new System.Drawing.Point(273, 93);
            this.Bot4.Name = "Bot4";
            this.Bot4.Size = new System.Drawing.Size(65, 65);
            this.Bot4.TabIndex = 3;
            this.Bot4.UseVisualStyleBackColor = true;
            this.Bot4.Click += new System.EventHandler(this.Bot4_Click);
            // 
            // Bot5
            // 
            this.Bot5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bot5.Location = new System.Drawing.Point(273, 173);
            this.Bot5.Name = "Bot5";
            this.Bot5.Size = new System.Drawing.Size(65, 65);
            this.Bot5.TabIndex = 4;
            this.Bot5.UseVisualStyleBackColor = true;
            this.Bot5.Click += new System.EventHandler(this.Bot5_Click);
            // 
            // Bot6
            // 
            this.Bot6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bot6.Location = new System.Drawing.Point(273, 253);
            this.Bot6.Name = "Bot6";
            this.Bot6.Size = new System.Drawing.Size(65, 65);
            this.Bot6.TabIndex = 5;
            this.Bot6.UseVisualStyleBackColor = true;
            this.Bot6.Click += new System.EventHandler(this.Bot6_Click);
            // 
            // Bot7
            // 
            this.Bot7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bot7.Location = new System.Drawing.Point(353, 93);
            this.Bot7.Name = "Bot7";
            this.Bot7.Size = new System.Drawing.Size(65, 65);
            this.Bot7.TabIndex = 6;
            this.Bot7.UseVisualStyleBackColor = true;
            this.Bot7.Click += new System.EventHandler(this.Bot7_Click);
            // 
            // Bot8
            // 
            this.Bot8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bot8.Location = new System.Drawing.Point(353, 173);
            this.Bot8.Name = "Bot8";
            this.Bot8.Size = new System.Drawing.Size(65, 65);
            this.Bot8.TabIndex = 7;
            this.Bot8.UseVisualStyleBackColor = true;
            this.Bot8.Click += new System.EventHandler(this.Bot8_Click);
            // 
            // Bot9
            // 
            this.Bot9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bot9.Location = new System.Drawing.Point(353, 253);
            this.Bot9.Name = "Bot9";
            this.Bot9.Size = new System.Drawing.Size(65, 65);
            this.Bot9.TabIndex = 8;
            this.Bot9.UseVisualStyleBackColor = true;
            this.Bot9.Click += new System.EventHandler(this.Bot9_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(639, 418);
            this.Controls.Add(this.Bot9);
            this.Controls.Add(this.Bot8);
            this.Controls.Add(this.Bot7);
            this.Controls.Add(this.Bot6);
            this.Controls.Add(this.Bot5);
            this.Controls.Add(this.Bot4);
            this.Controls.Add(this.Bot3);
            this.Controls.Add(this.Bot2);
            this.Controls.Add(this.Bot1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "TIC TAC TOE";
            this.ResumeLayout(false);

        }

        #endregion

        private Button Bot1;
        private Button Bot2;
        private Button Bot3;
        private Button Bot4;
        private Button Bot5;
        private Button Bot6;
        private Button Bot7;
        private Button Bot8;
        private Button Bot9;
    }
}