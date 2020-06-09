namespace ProjectT
{
    partial class MenuForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_closeSystem = new System.Windows.Forms.Button();
            this.btn_trainSystem = new System.Windows.Forms.Button();
            this.btn_testSystem = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(424, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // File
            // 
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(37, 20);
            this.File.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_closeSystem);
            this.panel1.Controls.Add(this.btn_trainSystem);
            this.panel1.Controls.Add(this.btn_testSystem);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 338);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(60, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 73);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome ";
            // 
            // btn_closeSystem
            // 
            this.btn_closeSystem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_closeSystem.Location = new System.Drawing.Point(71, 244);
            this.btn_closeSystem.Name = "btn_closeSystem";
            this.btn_closeSystem.Size = new System.Drawing.Size(255, 54);
            this.btn_closeSystem.TabIndex = 2;
            this.btn_closeSystem.Text = "Close System";
            this.btn_closeSystem.UseVisualStyleBackColor = true;
            this.btn_closeSystem.Click += new System.EventHandler(this.btn_closeSystem_Click);
            // 
            // btn_trainSystem
            // 
            this.btn_trainSystem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_trainSystem.Location = new System.Drawing.Point(71, 172);
            this.btn_trainSystem.Name = "btn_trainSystem";
            this.btn_trainSystem.Size = new System.Drawing.Size(255, 54);
            this.btn_trainSystem.TabIndex = 1;
            this.btn_trainSystem.Text = "Train System";
            this.btn_trainSystem.UseVisualStyleBackColor = true;
            this.btn_trainSystem.Click += new System.EventHandler(this.btn_trainSystem_Click);
            // 
            // btn_testSystem
            // 
            this.btn_testSystem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_testSystem.Location = new System.Drawing.Point(71, 98);
            this.btn_testSystem.Name = "btn_testSystem";
            this.btn_testSystem.Size = new System.Drawing.Size(255, 54);
            this.btn_testSystem.TabIndex = 0;
            this.btn_testSystem.Text = "Test System";
            this.btn_testSystem.UseVisualStyleBackColor = true;
            this.btn_testSystem.Click += new System.EventHandler(this.btn_testSystem_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 377);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btn_closeSystem;
        private System.Windows.Forms.Button btn_trainSystem;
        private System.Windows.Forms.Button btn_testSystem;
        private System.Windows.Forms.Label label1;


    }
}

