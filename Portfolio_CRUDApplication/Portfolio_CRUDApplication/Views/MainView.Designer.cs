namespace PackageTracker.Views
{
    partial class MainView
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
            panel1 = new Panel();
            txt_Title = new Label();
            btn_Packages = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(txt_Title);
            panel1.Controls.Add(btn_Packages);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 571);
            panel1.TabIndex = 0;
            // 
            // txt_Title
            // 
            txt_Title.AutoSize = true;
            txt_Title.Location = new Point(70, 18);
            txt_Title.Name = "txt_Title";
            txt_Title.Size = new Size(60, 15);
            txt_Title.TabIndex = 1;
            txt_Title.Text = "Databases";
            // 
            // btn_Packages
            // 
            btn_Packages.Location = new Point(12, 51);
            btn_Packages.Name = "btn_Packages";
            btn_Packages.Size = new Size(174, 23);
            btn_Packages.TabIndex = 0;
            btn_Packages.Text = "Packages";
            btn_Packages.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1283, 571);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Name = "MainView";
            Text = "MainView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label txt_Title;
        private Button btn_Packages;
    }
}