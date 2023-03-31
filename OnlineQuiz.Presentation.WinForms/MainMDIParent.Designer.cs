namespace OnlineQuiz.Presentation.WinForms
{
    partial class MainMDIParent
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
            components = new System.ComponentModel.Container();
            menuStrip = new MenuStrip();
            windowsMenu = new ToolStripMenuItem();
            newWindowToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            cascadeToolStripMenuItem = new ToolStripMenuItem();
            tileVerticalToolStripMenuItem = new ToolStripMenuItem();
            tileHorizontalToolStripMenuItem = new ToolStripMenuItem();
            closeAllToolStripMenuItem = new ToolStripMenuItem();
            Login_Register_ToolStripMenuItem = new ToolStripMenuItem();
            toolTip = new ToolTip(components);
            logoutToolStripMenuItem = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(40, 40);
            menuStrip.Items.AddRange(new ToolStripItem[] { windowsMenu, Login_Register_ToolStripMenuItem, logoutToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.MdiWindowListItem = windowsMenu;
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(17, 6, 0, 6);
            menuStrip.Size = new Size(1791, 60);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "MenuStrip";
            // 
            // windowsMenu
            // 
            windowsMenu.DropDownItems.AddRange(new ToolStripItem[] { newWindowToolStripMenuItem, toolStripSeparator1, cascadeToolStripMenuItem, tileVerticalToolStripMenuItem, tileHorizontalToolStripMenuItem, closeAllToolStripMenuItem });
            windowsMenu.Name = "windowsMenu";
            windowsMenu.Size = new Size(165, 48);
            windowsMenu.Text = "&Windows";
            // 
            // newWindowToolStripMenuItem
            // 
            newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
            newWindowToolStripMenuItem.Size = new Size(375, 54);
            newWindowToolStripMenuItem.Text = "&New Window";
            newWindowToolStripMenuItem.Click += ShowNewForm;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(372, 6);
            // 
            // cascadeToolStripMenuItem
            // 
            cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            cascadeToolStripMenuItem.Size = new Size(375, 54);
            cascadeToolStripMenuItem.Text = "&Cascade";
            cascadeToolStripMenuItem.Click += CascadeToolStripMenuItem_Click;
            // 
            // tileVerticalToolStripMenuItem
            // 
            tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            tileVerticalToolStripMenuItem.Size = new Size(375, 54);
            tileVerticalToolStripMenuItem.Text = "Tile &Vertical";
            tileVerticalToolStripMenuItem.Click += TileVerticalToolStripMenuItem_Click;
            // 
            // tileHorizontalToolStripMenuItem
            // 
            tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            tileHorizontalToolStripMenuItem.Size = new Size(375, 54);
            tileHorizontalToolStripMenuItem.Text = "Tile &Horizontal";
            tileHorizontalToolStripMenuItem.Click += TileHorizontalToolStripMenuItem_Click;
            // 
            // closeAllToolStripMenuItem
            // 
            closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            closeAllToolStripMenuItem.Size = new Size(375, 54);
            closeAllToolStripMenuItem.Text = "C&lose All";
            closeAllToolStripMenuItem.Click += CloseAllToolStripMenuItem_Click;
            // 
            // Login_Register_ToolStripMenuItem
            // 
            Login_Register_ToolStripMenuItem.Name = "Login_Register_ToolStripMenuItem";
            Login_Register_ToolStripMenuItem.Size = new Size(235, 48);
            Login_Register_ToolStripMenuItem.Text = "Login/Register";
            Login_Register_ToolStripMenuItem.Click += loginToolStripMenuItem1_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(137, 48);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // MainMDIParent
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1791, 1899);
            Controls.Add(menuStrip);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Margin = new Padding(8, 9, 8, 9);
            Name = "MainMDIParent";
            Text = "OnlineQuiz";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsMenu;
        private System.Windows.Forms.ToolStripMenuItem newWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem Login_Register_ToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
    }
}



