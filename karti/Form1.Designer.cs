namespace karti
{
    partial class Form1
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
            this.kart36 = new System.Windows.Forms.Button();
            this.kart54 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.score = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kart36
            // 
            this.kart36.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kart36.Location = new System.Drawing.Point(3, 3);
            this.kart36.Name = "kart36";
            this.kart36.Size = new System.Drawing.Size(201, 90);
            this.kart36.TabIndex = 0;
            this.kart36.Text = "36 kart";
            this.kart36.UseVisualStyleBackColor = true;
            this.kart36.Click += new System.EventHandler(this.kart36_Click);
            // 
            // kart54
            // 
            this.kart54.Enabled = false;
            this.kart54.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kart54.Location = new System.Drawing.Point(3, 99);
            this.kart54.Name = "kart54";
            this.kart54.Size = new System.Drawing.Size(201, 85);
            this.kart54.TabIndex = 1;
            this.kart54.Text = "54 kart";
            this.kart54.UseVisualStyleBackColor = true;
            this.kart54.Click += new System.EventHandler(this.kart52_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.kart54);
            this.panel1.Controls.Add(this.kart36);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 187);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(228, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 79);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Location = new System.Drawing.Point(9, -1);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(44, 13);
            this.score.TabIndex = 4;
            this.score.Text = "Score 0";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(400, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 45);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(234, 211);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.score);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(800, 400);
            this.MaximumSize = new System.Drawing.Size(1000, 500);
            this.MinimumSize = new System.Drawing.Size(250, 250);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Karti";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kart36;
        private System.Windows.Forms.Button kart54;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Button button2;
    }
}

