namespace OOP_lab_3_task_1
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
            lblDesc1 = new Label();
            btnPassenger = new Button();
            lblDesc2 = new Label();
            btnFighter = new Button();
            lblDesc3 = new Label();
            btnBomber = new Button();
            btnMainLoop = new Button();
            lblDesc4 = new Label();
            lblOutputTitle = new Label();
            txtOutput = new TextBox();
            SuspendLayout();
            // 
            // lblDesc1
            // 
            lblDesc1.AutoSize = true;
            lblDesc1.Location = new Point(20, 15);
            lblDesc1.Name = "lblDesc1";
            lblDesc1.Size = new Size(196, 15);
            lblDesc1.TabIndex = 0;
            lblDesc1.Text = "Пасажирський (сорт. за вартістю):";
            // 
            // btnPassenger
            // 
            btnPassenger.Location = new Point(20, 35);
            btnPassenger.Name = "btnPassenger";
            btnPassenger.Size = new Size(335, 35);
            btnPassenger.TabIndex = 1;
            btnPassenger.Text = "Виконати пасажирські";
            btnPassenger.UseVisualStyleBackColor = true;
            btnPassenger.Click += btnPassenger_Click;
            // 
            // lblDesc2
            // 
            lblDesc2.AutoSize = true;
            lblDesc2.Location = new Point(365, 15);
            lblDesc2.Name = "lblDesc2";
            lblDesc2.Size = new Size(190, 15);
            lblDesc2.TabIndex = 2;
            lblDesc2.Text = "Винищувач (сорт. за швидкістю):";
            // 
            // btnFighter
            // 
            btnFighter.Location = new Point(365, 35);
            btnFighter.Name = "btnFighter";
            btnFighter.Size = new Size(335, 35);
            btnFighter.TabIndex = 3;
            btnFighter.Text = "Виконати винищувачі";
            btnFighter.UseVisualStyleBackColor = true;
            btnFighter.Click += btnFighter_Click;
            // 
            // lblDesc3
            // 
            lblDesc3.AutoSize = true;
            lblDesc3.Location = new Point(20, 90);
            lblDesc3.Name = "lblDesc3";
            lblDesc3.Size = new Size(184, 15);
            lblDesc3.TabIndex = 4;
            lblDesc3.Text = "Бомбардувальник (розрахунок):";
            // 
            // btnBomber
            // 
            btnBomber.Location = new Point(20, 110);
            btnBomber.Name = "btnBomber";
            btnBomber.Size = new Size(335, 35);
            btnBomber.TabIndex = 5;
            btnBomber.Text = "Виконати бомбардувальник";
            btnBomber.UseVisualStyleBackColor = true;
            btnBomber.Click += btnBomber_Click;
            // 
            // btnMainLoop
            // 
            btnMainLoop.Location = new Point(365, 110);
            btnMainLoop.Name = "btnMainLoop";
            btnMainLoop.Size = new Size(335, 35);
            btnMainLoop.TabIndex = 6;
            btnMainLoop.Text = "Виконати цикл (5 літаків)";
            btnMainLoop.UseVisualStyleBackColor = true;
            btnMainLoop.Click += btnMainLoop_Click;
            // 
            // lblDesc4
            // 
            lblDesc4.AutoSize = true;
            lblDesc4.Location = new Point(365, 90);
            lblDesc4.Name = "lblDesc4";
            lblDesc4.Size = new Size(162, 15);
            lblDesc4.TabIndex = 7;
            lblDesc4.Text = "Випадковий цикл (5 літаків):";
            // 
            // lblOutputTitle
            // 
            lblOutputTitle.AutoSize = true;
            lblOutputTitle.Location = new Point(20, 155);
            lblOutputTitle.Name = "lblOutputTitle";
            lblOutputTitle.Size = new Size(132, 15);
            lblOutputTitle.TabIndex = 8;
            lblOutputTitle.Text = "Результати виконання:";
            // 
            // txtOutput
            // 
            txtOutput.Font = new Font("Consolas", 10F);
            txtOutput.Location = new Point(20, 175);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.ScrollBars = ScrollBars.Vertical;
            txtOutput.Size = new Size(680, 450);
            txtOutput.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 641);
            Controls.Add(txtOutput);
            Controls.Add(lblOutputTitle);
            Controls.Add(lblDesc4);
            Controls.Add(btnMainLoop);
            Controls.Add(btnBomber);
            Controls.Add(lblDesc3);
            Controls.Add(btnFighter);
            Controls.Add(lblDesc2);
            Controls.Add(btnPassenger);
            Controls.Add(lblDesc1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Лабораторна робота №3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDesc1;
        private Button btnPassenger;
        private Label lblDesc2;
        private Button btnFighter;
        private Label lblDesc3;
        private Button btnBomber;
        private Button btnMainLoop;
        private Label lblDesc4;
        private Label lblOutputTitle;
        private TextBox txtOutput;
    }
}
