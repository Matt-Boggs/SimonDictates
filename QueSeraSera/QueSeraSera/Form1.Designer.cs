
namespace QueSeraSera
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
            this.RedBtn = new System.Windows.Forms.Button();
            this.BlueBtn = new System.Windows.Forms.Button();
            this.YellowBtn = new System.Windows.Forms.Button();
            this.GreenBtn = new System.Windows.Forms.Button();
            this.BeginBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RedBtn
            // 
            this.RedBtn.BackColor = System.Drawing.Color.DarkRed;
            this.RedBtn.Location = new System.Drawing.Point(88, 12);
            this.RedBtn.Name = "RedBtn";
            this.RedBtn.Size = new System.Drawing.Size(150, 150);
            this.RedBtn.TabIndex = 0;
            this.RedBtn.UseVisualStyleBackColor = false;
            this.RedBtn.Click += new System.EventHandler(this.ButtonClicked);
            this.RedBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RedBtn_MouseDown);
            this.RedBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RedBtn_MouseUp);
            // 
            // BlueBtn
            // 
            this.BlueBtn.BackColor = System.Drawing.Color.DarkBlue;
            this.BlueBtn.Location = new System.Drawing.Point(244, 12);
            this.BlueBtn.Name = "BlueBtn";
            this.BlueBtn.Size = new System.Drawing.Size(150, 150);
            this.BlueBtn.TabIndex = 1;
            this.BlueBtn.UseVisualStyleBackColor = false;
            this.BlueBtn.Click += new System.EventHandler(this.ButtonClicked);
            this.BlueBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BlueBtn_MouseDown);
            this.BlueBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BlueBtn_MouseUp);
            // 
            // YellowBtn
            // 
            this.YellowBtn.BackColor = System.Drawing.Color.Olive;
            this.YellowBtn.Location = new System.Drawing.Point(244, 168);
            this.YellowBtn.Name = "YellowBtn";
            this.YellowBtn.Size = new System.Drawing.Size(150, 150);
            this.YellowBtn.TabIndex = 3;
            this.YellowBtn.UseVisualStyleBackColor = false;
            this.YellowBtn.Click += new System.EventHandler(this.ButtonClicked);
            this.YellowBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.YellowBtn_MouseDown);
            this.YellowBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.YellowBtn_MouseUp);
            // 
            // GreenBtn
            // 
            this.GreenBtn.BackColor = System.Drawing.Color.DarkGreen;
            this.GreenBtn.Location = new System.Drawing.Point(88, 168);
            this.GreenBtn.Name = "GreenBtn";
            this.GreenBtn.Size = new System.Drawing.Size(150, 150);
            this.GreenBtn.TabIndex = 2;
            this.GreenBtn.UseVisualStyleBackColor = false;
            this.GreenBtn.Click += new System.EventHandler(this.ButtonClicked);
            this.GreenBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GreenBtn_MouseDown);
            this.GreenBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GreenBtn_MouseUp);
            // 
            // BeginBtn
            // 
            this.BeginBtn.Location = new System.Drawing.Point(28, 399);
            this.BeginBtn.Name = "BeginBtn";
            this.BeginBtn.Size = new System.Drawing.Size(108, 39);
            this.BeginBtn.TabIndex = 4;
            this.BeginBtn.Text = "Begin";
            this.BeginBtn.UseVisualStyleBackColor = true;
            this.BeginBtn.Click += new System.EventHandler(this.BeginClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.BeginBtn);
            this.Controls.Add(this.YellowBtn);
            this.Controls.Add(this.GreenBtn);
            this.Controls.Add(this.BlueBtn);
            this.Controls.Add(this.RedBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RedBtn;
        private System.Windows.Forms.Button BlueBtn;
        private System.Windows.Forms.Button YellowBtn;
        private System.Windows.Forms.Button GreenBtn;
        private System.Windows.Forms.Button BeginBtn;
    }
}

