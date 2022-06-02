namespace tic_tac_toe
{
    partial class ttt_bg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ttt_bg));
            this.middle = new System.Windows.Forms.Button();
            this.middle_right = new System.Windows.Forms.Button();
            this.middle_left = new System.Windows.Forms.Button();
            this.bottom_left = new System.Windows.Forms.Button();
            this.top_right = new System.Windows.Forms.Button();
            this.bottom_middle = new System.Windows.Forms.Button();
            this.top_middle = new System.Windows.Forms.Button();
            this.bottom_right = new System.Windows.Forms.Button();
            this.top_left = new System.Windows.Forms.Button();
            this.transparent_bg = new System.Windows.Forms.Panel();
            this.transparent_bg.SuspendLayout();
            this.SuspendLayout();
            // 
            // middle
            // 
            this.middle.Location = new System.Drawing.Point(131, 138);
            this.middle.Name = "middle";
            this.middle.Size = new System.Drawing.Size(78, 79);
            this.middle.TabIndex = 4;
            this.middle.UseVisualStyleBackColor = true;
            this.middle.Click += new System.EventHandler(this.middle_Click);
            // 
            // middle_right
            // 
            this.middle_right.Location = new System.Drawing.Point(215, 138);
            this.middle_right.Name = "middle_right";
            this.middle_right.Size = new System.Drawing.Size(78, 79);
            this.middle_right.TabIndex = 5;
            this.middle_right.UseVisualStyleBackColor = true;
            this.middle_right.Click += new System.EventHandler(this.middle_right_Click);
            // 
            // middle_left
            // 
            this.middle_left.Location = new System.Drawing.Point(47, 138);
            this.middle_left.Name = "middle_left";
            this.middle_left.Size = new System.Drawing.Size(78, 79);
            this.middle_left.TabIndex = 3;
            this.middle_left.UseVisualStyleBackColor = true;
            this.middle_left.Click += new System.EventHandler(this.middle_left_Click);
            // 
            // bottom_left
            // 
            this.bottom_left.Location = new System.Drawing.Point(47, 223);
            this.bottom_left.Name = "bottom_left";
            this.bottom_left.Size = new System.Drawing.Size(78, 79);
            this.bottom_left.TabIndex = 6;
            this.bottom_left.UseVisualStyleBackColor = true;
            this.bottom_left.Click += new System.EventHandler(this.buttonl_left_Click);
            // 
            // top_right
            // 
            this.top_right.BackColor = System.Drawing.Color.Transparent;
            this.top_right.Location = new System.Drawing.Point(215, 53);
            this.top_right.Name = "top_right";
            this.top_right.Size = new System.Drawing.Size(78, 79);
            this.top_right.TabIndex = 2;
            this.top_right.UseVisualStyleBackColor = false;
            this.top_right.Click += new System.EventHandler(this.button3_Click);
            // 
            // bottom_middle
            // 
            this.bottom_middle.Location = new System.Drawing.Point(131, 223);
            this.bottom_middle.Name = "bottom_middle";
            this.bottom_middle.Size = new System.Drawing.Size(78, 79);
            this.bottom_middle.TabIndex = 7;
            this.bottom_middle.UseVisualStyleBackColor = true;
            this.bottom_middle.Click += new System.EventHandler(this.bottom_middle_Click);
            // 
            // top_middle
            // 
            this.top_middle.BackColor = System.Drawing.Color.Transparent;
            this.top_middle.ForeColor = System.Drawing.Color.Black;
            this.top_middle.Location = new System.Drawing.Point(131, 53);
            this.top_middle.Name = "top_middle";
            this.top_middle.Size = new System.Drawing.Size(78, 79);
            this.top_middle.TabIndex = 1;
            this.top_middle.UseVisualStyleBackColor = false;
            this.top_middle.Click += new System.EventHandler(this.button2_Click);
            // 
            // bottom_right
            // 
            this.bottom_right.Location = new System.Drawing.Point(215, 223);
            this.bottom_right.Name = "bottom_right";
            this.bottom_right.Size = new System.Drawing.Size(78, 79);
            this.bottom_right.TabIndex = 8;
            this.bottom_right.UseVisualStyleBackColor = true;
            this.bottom_right.Click += new System.EventHandler(this.bottom_right_Click);
            // 
            // top_left
            // 
            this.top_left.BackColor = System.Drawing.Color.Transparent;
            this.top_left.ForeColor = System.Drawing.Color.Black;
            this.top_left.Location = new System.Drawing.Point(47, 53);
            this.top_left.Name = "top_left";
            this.top_left.Size = new System.Drawing.Size(78, 79);
            this.top_left.TabIndex = 0;
            this.top_left.UseVisualStyleBackColor = true;
            this.top_left.Click += new System.EventHandler(this.button1_Click);
            // 
            // transparent_bg
            // 
            this.transparent_bg.Controls.Add(this.top_left);
            this.transparent_bg.Controls.Add(this.bottom_right);
            this.transparent_bg.Controls.Add(this.top_middle);
            this.transparent_bg.Controls.Add(this.bottom_middle);
            this.transparent_bg.Controls.Add(this.top_right);
            this.transparent_bg.Controls.Add(this.bottom_left);
            this.transparent_bg.Controls.Add(this.middle_left);
            this.transparent_bg.Controls.Add(this.middle_right);
            this.transparent_bg.Controls.Add(this.middle);
            this.transparent_bg.Location = new System.Drawing.Point(100, 91);
            this.transparent_bg.Name = "transparent_bg";
            this.transparent_bg.Size = new System.Drawing.Size(336, 349);
            this.transparent_bg.TabIndex = 9;
            this.transparent_bg.Paint += new System.Windows.Forms.PaintEventHandler(this.transparent_bg_Paint);
            // 
            // ttt_bg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(548, 522);
            this.Controls.Add(this.transparent_bg);
            this.Name = "ttt_bg";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.transparent_bg.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button middle;
        private System.Windows.Forms.Button middle_right;
        private System.Windows.Forms.Button middle_left;
        private System.Windows.Forms.Button bottom_left;
        private System.Windows.Forms.Button top_right;
        private System.Windows.Forms.Button bottom_middle;
        private System.Windows.Forms.Button top_middle;
        private System.Windows.Forms.Button bottom_right;
        private System.Windows.Forms.Button top_left;
        private System.Windows.Forms.Panel transparent_bg;
    }
}

