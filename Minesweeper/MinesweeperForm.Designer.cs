namespace Minesweeper
{
    partial class MinesweeperForm
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
            this.button82 = new System.Windows.Forms.Button();
            this.button83 = new System.Windows.Forms.Button();
            this.button84 = new System.Windows.Forms.Button();
            this.button85 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.MineField = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // button82
            // 
            this.button82.Location = new System.Drawing.Point(23, 12);
            this.button82.Name = "button82";
            this.button82.Size = new System.Drawing.Size(83, 39);
            this.button82.TabIndex = 1;
            this.button82.Text = "button82";
            this.button82.UseVisualStyleBackColor = true;
            // 
            // button83
            // 
            this.button83.Location = new System.Drawing.Point(260, 12);
            this.button83.Name = "button83";
            this.button83.Size = new System.Drawing.Size(83, 39);
            this.button83.TabIndex = 2;
            this.button83.Text = "button83";
            this.button83.UseVisualStyleBackColor = true;
            // 
            // button84
            // 
            this.button84.Location = new System.Drawing.Point(349, 12);
            this.button84.Name = "button84";
            this.button84.Size = new System.Drawing.Size(83, 39);
            this.button84.TabIndex = 3;
            this.button84.Text = "button84";
            this.button84.UseVisualStyleBackColor = true;
            // 
            // button85
            // 
            this.button85.Location = new System.Drawing.Point(438, 12);
            this.button85.Name = "button85";
            this.button85.Size = new System.Drawing.Size(83, 39);
            this.button85.TabIndex = 4;
            this.button85.Text = "button85";
            this.button85.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(653, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mines Remaining: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(754, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(44, 20);
            this.textBox1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(653, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Time Elapsed:";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(754, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "label3";
            // 
            // MineField
            // 
            this.MineField.Location = new System.Drawing.Point(23, 57);
            this.MineField.Name = "MineField";
            this.MineField.Size = new System.Drawing.Size(775, 775);
            this.MineField.TabIndex = 9;
            // 
            // MinesweeperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 854);
            this.Controls.Add(this.MineField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button85);
            this.Controls.Add(this.button84);
            this.Controls.Add(this.button83);
            this.Controls.Add(this.button82);
            this.Name = "MinesweeperForm";
            this.Text = "Minesweeper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button82;
        private System.Windows.Forms.Button button83;
        private System.Windows.Forms.Button button84;
        private System.Windows.Forms.Button button85;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel MineField;
    }
}

