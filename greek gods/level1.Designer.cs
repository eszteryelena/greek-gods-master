﻿namespace greek_gods
{
    partial class level1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(level1));
            this.pnlGame = new System.Windows.Forms.Panel();
            this.imageDown = new System.Windows.Forms.PictureBox();
            this.blast = new System.Windows.Forms.PictureBox();
            this.imageUp = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.tmrVillan = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.txtLives = new System.Windows.Forms.TextBox();
            this.txtscore = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuStart = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStop = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrHero = new System.Windows.Forms.Timer(this.components);
            this.txtName = new System.Windows.Forms.TextBox();
            this.tmrBlast = new System.Windows.Forms.Timer(this.components);
            this.tmrLevel = new System.Windows.Forms.Timer(this.components);
            this.pnlGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGame
            // 
            this.pnlGame.BackColor = System.Drawing.Color.Transparent;
            this.pnlGame.Controls.Add(this.imageDown);
            this.pnlGame.Controls.Add(this.blast);
            this.pnlGame.Controls.Add(this.imageUp);
            this.pnlGame.Location = new System.Drawing.Point(24, 51);
            this.pnlGame.Name = "pnlGame";
            this.pnlGame.Size = new System.Drawing.Size(500, 400);
            this.pnlGame.TabIndex = 0;
            this.pnlGame.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGame_Paint);
            // 
            // imageDown
            // 
            this.imageDown.BackColor = System.Drawing.Color.Transparent;
            this.imageDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imageDown.BackgroundImage")));
            this.imageDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageDown.Location = new System.Drawing.Point(203, 0);
            this.imageDown.Name = "imageDown";
            this.imageDown.Size = new System.Drawing.Size(297, 95);
            this.imageDown.TabIndex = 22;
            this.imageDown.TabStop = false;
            this.imageDown.Visible = false;
            // 
            // blast
            // 
            this.blast.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("blast.BackgroundImage")));
            this.blast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.blast.Location = new System.Drawing.Point(380, 360);
            this.blast.Name = "blast";
            this.blast.Size = new System.Drawing.Size(15, 15);
            this.blast.TabIndex = 0;
            this.blast.TabStop = false;
            // 
            // imageUp
            // 
            this.imageUp.BackColor = System.Drawing.Color.Transparent;
            this.imageUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imageUp.BackgroundImage")));
            this.imageUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageUp.Location = new System.Drawing.Point(203, 310);
            this.imageUp.Name = "imageUp";
            this.imageUp.Size = new System.Drawing.Size(297, 90);
            this.imageUp.TabIndex = 23;
            this.imageUp.TabStop = false;
            this.imageUp.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(24, 31);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(132, 33);
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(24, 64);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(186, 41);
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            // 
            // tmrVillan
            // 
            this.tmrVillan.Tick += new System.EventHandler(this.tmrVillan_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(550, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "lives";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.BackColor = System.Drawing.Color.Transparent;
            this.lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.ForeColor = System.Drawing.Color.White;
            this.lb.Location = new System.Drawing.Point(545, 157);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(70, 25);
            this.lb.TabIndex = 16;
            this.lb.Text = "score";
            // 
            // txtLives
            // 
            this.txtLives.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLives.Font = new System.Drawing.Font("rainyhearts", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLives.Location = new System.Drawing.Point(535, 262);
            this.txtLives.Name = "txtLives";
            this.txtLives.ReadOnly = true;
            this.txtLives.Size = new System.Drawing.Size(92, 17);
            this.txtLives.TabIndex = 17;
            this.txtLives.Text = "5";
            // 
            // txtscore
            // 
            this.txtscore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtscore.Font = new System.Drawing.Font("rainyhearts", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtscore.Location = new System.Drawing.Point(534, 183);
            this.txtscore.Name = "txtscore";
            this.txtscore.ReadOnly = true;
            this.txtscore.Size = new System.Drawing.Size(92, 17);
            this.txtscore.TabIndex = 18;
            this.txtscore.Text = "0";
            this.txtscore.TextChanged += new System.EventHandler(this.txtscore_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(538, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "player:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Lavender;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuStart,
            this.mnuStop,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(634, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // mnuStart
            // 
            this.mnuStart.Font = new System.Drawing.Font("rainyhearts", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuStart.Name = "mnuStart";
            this.mnuStart.Size = new System.Drawing.Size(50, 20);
            this.mnuStart.Text = "&play";
            this.mnuStart.Click += new System.EventHandler(this.mnuStart_Click);
            // 
            // mnuStop
            // 
            this.mnuStop.Font = new System.Drawing.Font("rainyhearts", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuStop.Name = "mnuStop";
            this.mnuStop.Size = new System.Drawing.Size(60, 20);
            this.mnuStop.Text = "&pause";
            this.mnuStop.Click += new System.EventHandler(this.mnuStop_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("rainyhearts", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.exitToolStripMenuItem.Text = "&exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tmrHero
            // 
            this.tmrHero.Enabled = true;
            this.tmrHero.Interval = 200;
            this.tmrHero.Tick += new System.EventHandler(this.tmrHero_Tick);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("rainyhearts", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.SystemColors.Info;
            this.txtName.Location = new System.Drawing.Point(534, 105);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(92, 20);
            this.txtName.TabIndex = 21;
            this.txtName.Text = "0";
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tmrBlast
            // 
            this.tmrBlast.Enabled = true;
            this.tmrBlast.Tick += new System.EventHandler(this.tmrBlast_Tick);
            // 
            // tmrLevel
            // 
            this.tmrLevel.Enabled = true;
            this.tmrLevel.Tick += new System.EventHandler(this.tmrLevel_Tick);
            // 
            // level1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::greek_gods.Properties.Resources.one;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(634, 461);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtscore);
            this.Controls.Add(this.txtLives);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlGame);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "level1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.level1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.onKeyDown);
            this.pnlGame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlGame;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Timer tmrVillan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.TextBox txtLives;
        private System.Windows.Forms.TextBox txtscore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuStart;
        private System.Windows.Forms.ToolStripMenuItem mnuStop;
        private System.Windows.Forms.Timer tmrHero;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.PictureBox blast;
        private System.Windows.Forms.Timer tmrBlast;
        private System.Windows.Forms.Timer tmrLevel;
        private System.Windows.Forms.PictureBox imageDown;
        private System.Windows.Forms.PictureBox imageUp;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}