namespace IzvajdaneStepenuvaneDelenieSubirane
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
            txtName1 = new Label();
            btn1 = new TextBox();
            btn2 = new TextBox();
            txtName2 = new Label();
            btnSimple = new Button();
            btnStar = new Button();
            btnMinus = new Button();
            btnDivision = new Button();
            btnRazlika = new Button();
            btnStepenuvane = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // txtName1
            // 
            txtName1.AutoSize = true;
            txtName1.Location = new Point(179, 77);
            txtName1.Name = "txtName1";
            txtName1.Size = new Size(102, 15);
            txtName1.TabIndex = 0;
            txtName1.Text = "Въведете число 1";
            // 
            // btn1
            // 
            btn1.Location = new Point(172, 106);
            btn1.Name = "btn1";
            btn1.Size = new Size(100, 23);
            btn1.TabIndex = 1;
            btn1.Leave += btn1_Leave;
            // 
            // btn2
            // 
            btn2.Location = new Point(309, 106);
            btn2.Name = "btn2";
            btn2.Size = new Size(100, 23);
            btn2.TabIndex = 3;
            btn2.Leave += btn2_Leave;
            // 
            // txtName2
            // 
            txtName2.AutoSize = true;
            txtName2.Location = new Point(316, 77);
            txtName2.Name = "txtName2";
            txtName2.Size = new Size(102, 15);
            txtName2.TabIndex = 2;
            txtName2.Text = "Въведете число 2";
            txtName2.Click += txtName2_Click;
            // 
            // btnSimple
            // 
            btnSimple.Font = new Font("Showcard Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSimple.ForeColor = Color.LightSeaGreen;
            btnSimple.Location = new Point(49, 160);
            btnSimple.Name = "btnSimple";
            btnSimple.Size = new Size(73, 56);
            btnSimple.TabIndex = 6;
            btnSimple.Text = "+";
            btnSimple.UseVisualStyleBackColor = true;
            btnSimple.Click += btnSimple_Click;
            // 
            // btnStar
            // 
            btnStar.Font = new Font("Showcard Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStar.ForeColor = Color.LightSeaGreen;
            btnStar.Location = new Point(309, 160);
            btnStar.Name = "btnStar";
            btnStar.Size = new Size(73, 56);
            btnStar.TabIndex = 7;
            btnStar.Text = "*";
            btnStar.UseVisualStyleBackColor = true;
            btnStar.Click += btnStar_Click;
            // 
            // btnMinus
            // 
            btnMinus.Font = new Font("Showcard Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMinus.ForeColor = Color.LightSeaGreen;
            btnMinus.Location = new Point(179, 160);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(73, 56);
            btnMinus.TabIndex = 8;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnDivision
            // 
            btnDivision.Font = new Font("Showcard Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDivision.ForeColor = Color.LightSeaGreen;
            btnDivision.Location = new Point(435, 160);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(73, 56);
            btnDivision.TabIndex = 9;
            btnDivision.Text = "/";
            btnDivision.UseVisualStyleBackColor = true;
            // 
            // btnRazlika
            // 
            btnRazlika.Font = new Font("Showcard Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRazlika.ForeColor = Color.LightSeaGreen;
            btnRazlika.Location = new Point(554, 160);
            btnRazlika.Name = "btnRazlika";
            btnRazlika.Size = new Size(96, 56);
            btnRazlika.TabIndex = 10;
            btnRazlika.Text = "N1 !";
            btnRazlika.UseVisualStyleBackColor = true;
            btnRazlika.Click += btnRazlika_Click;
            // 
            // btnStepenuvane
            // 
            btnStepenuvane.Font = new Font("Showcard Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStepenuvane.ForeColor = Color.LightSeaGreen;
            btnStepenuvane.Location = new Point(682, 160);
            btnStepenuvane.Name = "btnStepenuvane";
            btnStepenuvane.Size = new Size(73, 56);
            btnStepenuvane.TabIndex = 11;
            btnStepenuvane.Text = "^";
            btnStepenuvane.UseVisualStyleBackColor = true;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(30, 290);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 15);
            lblResult.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(btnStepenuvane);
            Controls.Add(btnRazlika);
            Controls.Add(btnDivision);
            Controls.Add(btnMinus);
            Controls.Add(btnStar);
            Controls.Add(btnSimple);
            Controls.Add(btn2);
            Controls.Add(txtName2);
            Controls.Add(btn1);
            Controls.Add(txtName1);
            Name = "Form1";
            Text = "Calculator Mega Simple";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtName1;
        private TextBox btn1;
        private TextBox btn2;
        private Label txtName2;
        private Button btnSimple;
        private Button btnStar;
        private Button btnMinus;
        private Button btnDivision;
        private Button btnRazlika;
        private Button btnStepenuvane;
        private Label lblResult;
    }
}
