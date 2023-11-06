namespace MultithreadApp
{
    partial class Form1
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
            panel2 = new Panel();
            d1Text = new TextBox();
            s1Text = new TextBox();
            x1Text = new TextBox();
            n1Text = new TextBox();
            d1 = new Label();
            s1 = new Label();
            x1 = new Label();
            n1 = new Label();
            textThread1 = new Label();
            panel1 = new Panel();
            d2Text = new TextBox();
            d2 = new Label();
            s2Text = new TextBox();
            textThread2 = new Label();
            x2Text = new TextBox();
            s2 = new Label();
            t2Text = new TextBox();
            x2 = new Label();
            t2 = new Label();
            Thread1 = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(d1Text);
            panel2.Controls.Add(s1Text);
            panel2.Controls.Add(x1Text);
            panel2.Controls.Add(n1Text);
            panel2.Controls.Add(d1);
            panel2.Controls.Add(s1);
            panel2.Controls.Add(x1);
            panel2.Controls.Add(n1);
            panel2.Controls.Add(textThread1);
            panel2.Location = new Point(40, 23);
            panel2.Name = "panel2";
            panel2.Size = new Size(299, 336);
            panel2.TabIndex = 5;
            // 
            // d1Text
            // 
            d1Text.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            d1Text.Location = new Point(85, 220);
            d1Text.Name = "d1Text";
            d1Text.Size = new Size(186, 27);
            d1Text.TabIndex = 8;
            // 
            // s1Text
            // 
            s1Text.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            s1Text.Location = new Point(83, 168);
            s1Text.Name = "s1Text";
            s1Text.Size = new Size(188, 27);
            s1Text.TabIndex = 7;
            // 
            // x1Text
            // 
            x1Text.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            x1Text.Location = new Point(85, 113);
            x1Text.Name = "x1Text";
            x1Text.Size = new Size(186, 27);
            x1Text.TabIndex = 6;
            // 
            // n1Text
            // 
            n1Text.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            n1Text.Location = new Point(83, 58);
            n1Text.Name = "n1Text";
            n1Text.Size = new Size(188, 27);
            n1Text.TabIndex = 5;
            // 
            // d1
            // 
            d1.AutoSize = true;
            d1.Location = new Point(39, 223);
            d1.Name = "d1";
            d1.Size = new Size(40, 20);
            d1.TabIndex = 4;
            d1.Text = "d1 =";
            // 
            // s1
            // 
            s1.AutoSize = true;
            s1.Location = new Point(38, 171);
            s1.Name = "s1";
            s1.Size = new Size(37, 20);
            s1.TabIndex = 3;
            s1.Text = "s1 =";
            // 
            // x1
            // 
            x1.AutoSize = true;
            x1.Location = new Point(38, 116);
            x1.Name = "x1";
            x1.Size = new Size(38, 20);
            x1.TabIndex = 2;
            x1.Text = "x1 =";
            // 
            // n1
            // 
            n1.AutoSize = true;
            n1.Location = new Point(38, 58);
            n1.Name = "n1";
            n1.Size = new Size(39, 20);
            n1.TabIndex = 1;
            n1.Text = "n1 =";
            // 
            // textThread1
            // 
            textThread1.AutoSize = true;
            textThread1.Location = new Point(21, 13);
            textThread1.Name = "textThread1";
            textThread1.Size = new Size(67, 20);
            textThread1.TabIndex = 0;
            textThread1.Text = "Thread 1";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(d2Text);
            panel1.Controls.Add(d2);
            panel1.Controls.Add(s2Text);
            panel1.Controls.Add(textThread2);
            panel1.Controls.Add(x2Text);
            panel1.Controls.Add(s2);
            panel1.Controls.Add(t2Text);
            panel1.Controls.Add(x2);
            panel1.Controls.Add(t2);
            panel1.Location = new Point(461, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 336);
            panel1.TabIndex = 4;
            // 
            // d2Text
            // 
            d2Text.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            d2Text.Location = new Point(86, 220);
            d2Text.Name = "d2Text";
            d2Text.Size = new Size(186, 27);
            d2Text.TabIndex = 12;
            // 
            // d2
            // 
            d2.AutoSize = true;
            d2.Location = new Point(43, 223);
            d2.Name = "d2";
            d2.Size = new Size(40, 20);
            d2.TabIndex = 8;
            d2.Text = "d2 =";
            // 
            // s2Text
            // 
            s2Text.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            s2Text.Location = new Point(84, 168);
            s2Text.Name = "s2Text";
            s2Text.Size = new Size(188, 27);
            s2Text.TabIndex = 11;
            // 
            // textThread2
            // 
            textThread2.AutoSize = true;
            textThread2.Location = new Point(24, 13);
            textThread2.Name = "textThread2";
            textThread2.Size = new Size(67, 20);
            textThread2.TabIndex = 0;
            textThread2.Text = "Thread 2";
            // 
            // x2Text
            // 
            x2Text.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            x2Text.Location = new Point(86, 113);
            x2Text.Name = "x2Text";
            x2Text.Size = new Size(186, 27);
            x2Text.TabIndex = 10;
            // 
            // s2
            // 
            s2.AutoSize = true;
            s2.Location = new Point(42, 171);
            s2.Name = "s2";
            s2.Size = new Size(37, 20);
            s2.TabIndex = 7;
            s2.Text = "s2 =";
            // 
            // t2Text
            // 
            t2Text.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            t2Text.Location = new Point(84, 58);
            t2Text.Name = "t2Text";
            t2Text.Size = new Size(188, 27);
            t2Text.TabIndex = 9;
            // 
            // x2
            // 
            x2.AutoSize = true;
            x2.Location = new Point(42, 116);
            x2.Name = "x2";
            x2.Size = new Size(38, 20);
            x2.TabIndex = 6;
            x2.Text = "x2 =";
            // 
            // t2
            // 
            t2.AutoSize = true;
            t2.Location = new Point(42, 58);
            t2.Name = "t2";
            t2.Size = new Size(36, 20);
            t2.TabIndex = 5;
            t2.Text = "t2 =";
            // 
            // Thread1
            // 
            Thread1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            Thread1.Location = new Point(353, 395);
            Thread1.Name = "Thread1";
            Thread1.Size = new Size(94, 33);
            Thread1.TabIndex = 3;
            Thread1.Text = "Start";
            Thread1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(Thread1);
            Name = "Form1";
            Text = "Multithread";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private TextBox d1Text;
        private TextBox s1Text;
        private TextBox x1Text;
        private TextBox n1Text;
        private Label d1;
        private Label s1;
        private Label x1;
        private Label n1;
        private Label textThread1;
        private Panel panel1;
        private TextBox d2Text;
        private Label d2;
        private TextBox s2Text;
        private Label textThread2;
        private TextBox x2Text;
        private Label s2;
        private TextBox t2Text;
        private Label x2;
        private Label t2;
        private Button Thread1;
    }
}