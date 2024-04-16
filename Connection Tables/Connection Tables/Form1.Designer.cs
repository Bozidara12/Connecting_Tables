namespace Connection_Tables
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
            txt1 = new TextBox();
            lbl1 = new Label();
            txt2 = new TextBox();
            lbl2 = new Label();
            btn1 = new Button();
            SuspendLayout();
            // 
            // txt1
            // 
            txt1.Location = new Point(97, 72);
            txt1.Name = "txt1";
            txt1.Size = new Size(118, 23);
            txt1.TabIndex = 0;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(97, 54);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(39, 15);
            lbl1.TabIndex = 1;
            lbl1.Text = "Name";
            // 
            // txt2
            // 
            txt2.Location = new Point(421, 71);
            txt2.Name = "txt2";
            txt2.Size = new Size(135, 23);
            txt2.TabIndex = 2;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(421, 53);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(59, 15);
            lbl2.TabIndex = 3;
            lbl2.Text = "Name_BG";
            // 
            // btn1
            // 
            btn1.Location = new Point(239, 215);
            btn1.Name = "btn1";
            btn1.Size = new Size(241, 51);
            btn1.TabIndex = 4;
            btn1.Text = "Insert into rod";
            btn1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn1);
            Controls.Add(lbl2);
            Controls.Add(txt2);
            Controls.Add(lbl1);
            Controls.Add(txt1);
            Name = "Form1";
            Text = "Connecting Tables";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt1;
        private Label lbl1;
        private TextBox txt2;
        private Label lbl2;
        private Button btn1;
    }
}
