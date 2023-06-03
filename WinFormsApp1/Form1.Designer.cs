namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 1000);
            panel1.TabIndex = 0;
            panel1.Click += panel1_Click;
            panel1.MouseClick += panel1_MouseClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 1015);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 0;
            label1.Text = "left click: start fill";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(114, 1015);
            label2.Name = "label2";
            label2.Size = new Size(117, 15);
            label2.TabIndex = 1;
            label2.Text = "right click: place wall";
            // 
            // button1
            // 
            button1.Location = new Point(237, 1015);
            button1.Name = "button1";
            button1.Size = new Size(75, 24);
            button1.TabIndex = 2;
            button1.Text = "reset";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 1039);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}