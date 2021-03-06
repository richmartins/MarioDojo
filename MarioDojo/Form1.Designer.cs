﻿namespace MarioDojo
{
    partial class MarioDojo
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
            this.screen = new System.Windows.Forms.Panel();
            this.Block1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.player = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.screen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Block1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // screen
            // 
            this.screen.Controls.Add(this.Block1);
            this.screen.Controls.Add(this.label1);
            this.screen.Controls.Add(this.player);
            this.screen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screen.Location = new System.Drawing.Point(0, 0);
            this.screen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(1099, 645);
            this.screen.TabIndex = 0;
            // 
            // Block1
            // 
            this.Block1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Block1.Location = new System.Drawing.Point(535, 539);
            this.Block1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Block1.Name = "Block1";
            this.Block1.Size = new System.Drawing.Size(214, 104);
            this.Block1.TabIndex = 2;
            this.Block1.TabStop = false;
            this.Block1.Click += new System.EventHandler(this.Block1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 80);
            this.label1.TabIndex = 1;
            this.label1.Text = "Commands : \r\n[< -] Left             \r\n[- >] Right \r\n[space] Jump";
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Black;
            this.player.InitialImage = null;
            this.player.Location = new System.Drawing.Point(836, 413);
            this.player.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(38, 40);
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            this.player.Click += new System.EventHandler(this.player_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MarioDojo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 645);
            this.Controls.Add(this.screen);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MarioDojo";
            this.Text = "MarioDojo";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MarioDojo_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MarioDojo_KeyUp);
            this.screen.ResumeLayout(false);
            this.screen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Block1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel screen;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Block1;
    }
}

