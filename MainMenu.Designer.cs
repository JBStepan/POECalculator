namespace POECalculator2
{
    partial class MainMenu
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createSaveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wheelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearSaveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Wheels";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(430, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(225, 44);
            this.button2.TabIndex = 1;
            this.button2.Text = "Levers";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.menusToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(708, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createSaveFileToolStripMenuItem,
            this.clearSaveFileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // createSaveFileToolStripMenuItem
            // 
            this.createSaveFileToolStripMenuItem.Name = "createSaveFileToolStripMenuItem";
            this.createSaveFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createSaveFileToolStripMenuItem.Text = "Create Save File";
            this.createSaveFileToolStripMenuItem.Click += new System.EventHandler(this.createSaveFileToolStripMenuItem_Click);
            // 
            // menusToolStripMenuItem
            // 
            this.menusToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wheelsToolStripMenuItem,
            this.leversToolStripMenuItem});
            this.menusToolStripMenuItem.Name = "menusToolStripMenuItem";
            this.menusToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.menusToolStripMenuItem.Text = "Menus";
            // 
            // wheelsToolStripMenuItem
            // 
            this.wheelsToolStripMenuItem.Name = "wheelsToolStripMenuItem";
            this.wheelsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.wheelsToolStripMenuItem.Text = "Wheels";
            // 
            // leversToolStripMenuItem
            // 
            this.leversToolStripMenuItem.Name = "leversToolStripMenuItem";
            this.leversToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.leversToolStripMenuItem.Text = "Levers";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // clearSaveFileToolStripMenuItem
            // 
            this.clearSaveFileToolStripMenuItem.Name = "clearSaveFileToolStripMenuItem";
            this.clearSaveFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clearSaveFileToolStripMenuItem.Text = "Clear Save File";
            this.clearSaveFileToolStripMenuItem.Click += new System.EventHandler(this.clearSaveFileToolStripMenuItem_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 158);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenu_FormClosed);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createSaveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wheelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearSaveFileToolStripMenuItem;
    }
}

