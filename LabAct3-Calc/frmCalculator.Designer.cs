namespace LabAct3_Calc
{
    partial class frmCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculator));
            fpnl_buttonsCont = new Panel();
            tableLayoutPanel6 = new TableLayoutPanel();
            btnEqual = new Button();
            btn0 = new Button();
            btnSquare = new Button();
            btnPoint = new Button();
            tableLayoutPanel5 = new TableLayoutPanel();
            btnMultiply = new Button();
            btn7 = new Button();
            btn9 = new Button();
            btn8 = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnMinus = new Button();
            btn4 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnAdd = new Button();
            btn1 = new Button();
            btn3 = new Button();
            btn2 = new Button();
            tableLayoutPanel7 = new TableLayoutPanel();
            btnDivide = new Button();
            btnClear = new Button();
            btnCE = new Button();
            pnl_displayCont = new Panel();
            txtInput = new TextBox();
            lblEntry = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            fpnl_buttonsCont.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            pnl_displayCont.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // fpnl_buttonsCont
            // 
            fpnl_buttonsCont.BackColor = Color.Transparent;
            fpnl_buttonsCont.Controls.Add(tableLayoutPanel6);
            fpnl_buttonsCont.Controls.Add(tableLayoutPanel5);
            fpnl_buttonsCont.Controls.Add(tableLayoutPanel3);
            fpnl_buttonsCont.Controls.Add(tableLayoutPanel2);
            fpnl_buttonsCont.Controls.Add(tableLayoutPanel7);
            fpnl_buttonsCont.Dock = DockStyle.Fill;
            fpnl_buttonsCont.Location = new Point(0, 125);
            fpnl_buttonsCont.Margin = new Padding(4);
            fpnl_buttonsCont.Name = "fpnl_buttonsCont";
            fpnl_buttonsCont.Padding = new Padding(15, 0, 15, 0);
            fpnl_buttonsCont.Size = new Size(576, 636);
            fpnl_buttonsCont.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 4;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel6.Controls.Add(btnEqual, 3, 0);
            tableLayoutPanel6.Controls.Add(btn0, 0, 0);
            tableLayoutPanel6.Controls.Add(btnSquare, 2, 0);
            tableLayoutPanel6.Controls.Add(btnPoint, 1, 0);
            tableLayoutPanel6.Dock = DockStyle.Top;
            tableLayoutPanel6.Location = new Point(15, 500);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(546, 125);
            tableLayoutPanel6.TabIndex = 34;
            // 
            // btnEqual
            // 
            btnEqual.Anchor = AnchorStyles.None;
            btnEqual.BackgroundImage = Properties.Resources.border5;
            btnEqual.BackgroundImageLayout = ImageLayout.Center;
            btnEqual.FlatStyle = FlatStyle.Flat;
            btnEqual.Font = new Font("Cascadia Code", 12F);
            btnEqual.Location = new Point(420, 8);
            btnEqual.Margin = new Padding(4);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(113, 108);
            btnEqual.TabIndex = 23;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // btn0
            // 
            btn0.Anchor = AnchorStyles.None;
            btn0.BackgroundImage = Properties.Resources.border;
            btn0.BackgroundImageLayout = ImageLayout.Center;
            btn0.FlatStyle = FlatStyle.Flat;
            btn0.Font = new Font("Cascadia Code", 12F);
            btn0.Location = new Point(11, 8);
            btn0.Margin = new Padding(4);
            btn0.Name = "btn0";
            btn0.Size = new Size(113, 108);
            btn0.TabIndex = 21;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btnNum_Click;
            // 
            // btnSquare
            // 
            btnSquare.Anchor = AnchorStyles.None;
            btnSquare.BackgroundImage = Properties.Resources.border;
            btnSquare.BackgroundImageLayout = ImageLayout.Center;
            btnSquare.FlatStyle = FlatStyle.Flat;
            btnSquare.Font = new Font("Cascadia Code", 12F);
            btnSquare.Location = new Point(283, 8);
            btnSquare.Margin = new Padding(4);
            btnSquare.Name = "btnSquare";
            btnSquare.Size = new Size(113, 108);
            btnSquare.TabIndex = 24;
            btnSquare.Text = "x^2";
            btnSquare.UseVisualStyleBackColor = true;
            btnSquare.Click += btnSquare_Click;
            // 
            // btnPoint
            // 
            btnPoint.Anchor = AnchorStyles.None;
            btnPoint.BackgroundImage = Properties.Resources.border;
            btnPoint.BackgroundImageLayout = ImageLayout.Center;
            btnPoint.FlatStyle = FlatStyle.Flat;
            btnPoint.Font = new Font("Cascadia Code", 12F);
            btnPoint.Location = new Point(147, 8);
            btnPoint.Margin = new Padding(4);
            btnPoint.Name = "btnPoint";
            btnPoint.Size = new Size(113, 108);
            btnPoint.TabIndex = 22;
            btnPoint.Text = ".";
            btnPoint.UseVisualStyleBackColor = true;
            btnPoint.Click += btnNum_Click;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 4;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.Controls.Add(btnMultiply, 3, 0);
            tableLayoutPanel5.Controls.Add(btn7, 0, 0);
            tableLayoutPanel5.Controls.Add(btn9, 2, 0);
            tableLayoutPanel5.Controls.Add(btn8, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Top;
            tableLayoutPanel5.Location = new Point(15, 375);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(546, 125);
            tableLayoutPanel5.TabIndex = 33;
            // 
            // btnMultiply
            // 
            btnMultiply.Anchor = AnchorStyles.None;
            btnMultiply.BackgroundImage = Properties.Resources.border2;
            btnMultiply.BackgroundImageLayout = ImageLayout.Center;
            btnMultiply.FlatStyle = FlatStyle.Flat;
            btnMultiply.Font = new Font("Cascadia Code", 12F);
            btnMultiply.Location = new Point(420, 8);
            btnMultiply.Margin = new Padding(4);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(113, 108);
            btnMultiply.TabIndex = 12;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnOperator_Click;
            // 
            // btn7
            // 
            btn7.Anchor = AnchorStyles.None;
            btn7.BackgroundImage = Properties.Resources.border;
            btn7.BackgroundImageLayout = ImageLayout.Center;
            btn7.FlatStyle = FlatStyle.Flat;
            btn7.Font = new Font("Cascadia Code", 12F);
            btn7.Location = new Point(11, 8);
            btn7.Margin = new Padding(4);
            btn7.Name = "btn7";
            btn7.Size = new Size(113, 108);
            btn7.TabIndex = 9;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btnNum_Click;
            // 
            // btn9
            // 
            btn9.Anchor = AnchorStyles.None;
            btn9.BackgroundImage = Properties.Resources.border;
            btn9.BackgroundImageLayout = ImageLayout.Center;
            btn9.FlatStyle = FlatStyle.Flat;
            btn9.Font = new Font("Cascadia Code", 12F);
            btn9.Location = new Point(283, 8);
            btn9.Margin = new Padding(4);
            btn9.Name = "btn9";
            btn9.Size = new Size(113, 108);
            btn9.TabIndex = 11;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btnNum_Click;
            // 
            // btn8
            // 
            btn8.Anchor = AnchorStyles.None;
            btn8.BackgroundImage = Properties.Resources.border;
            btn8.BackgroundImageLayout = ImageLayout.Center;
            btn8.FlatStyle = FlatStyle.Flat;
            btn8.Font = new Font("Cascadia Code", 12F);
            btn8.Location = new Point(147, 8);
            btn8.Margin = new Padding(4);
            btn8.Name = "btn8";
            btn8.Size = new Size(113, 108);
            btn8.TabIndex = 10;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btnNum_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.Controls.Add(btnMinus, 3, 0);
            tableLayoutPanel3.Controls.Add(btn4, 0, 0);
            tableLayoutPanel3.Controls.Add(btn6, 2, 0);
            tableLayoutPanel3.Controls.Add(btn5, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Top;
            tableLayoutPanel3.Location = new Point(15, 250);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(546, 125);
            tableLayoutPanel3.TabIndex = 32;
            // 
            // btnMinus
            // 
            btnMinus.Anchor = AnchorStyles.None;
            btnMinus.BackgroundImage = Properties.Resources.border2;
            btnMinus.BackgroundImageLayout = ImageLayout.Center;
            btnMinus.FlatStyle = FlatStyle.Flat;
            btnMinus.Font = new Font("Cascadia Code", 12F);
            btnMinus.Location = new Point(420, 8);
            btnMinus.Margin = new Padding(4);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(113, 108);
            btnMinus.TabIndex = 16;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnOperator_Click;
            // 
            // btn4
            // 
            btn4.Anchor = AnchorStyles.None;
            btn4.BackgroundImage = Properties.Resources.border;
            btn4.BackgroundImageLayout = ImageLayout.Center;
            btn4.FlatStyle = FlatStyle.Flat;
            btn4.Font = new Font("Cascadia Code", 12F);
            btn4.Location = new Point(11, 8);
            btn4.Margin = new Padding(4);
            btn4.Name = "btn4";
            btn4.Size = new Size(113, 108);
            btn4.TabIndex = 13;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btnNum_Click;
            // 
            // btn6
            // 
            btn6.Anchor = AnchorStyles.None;
            btn6.BackgroundImage = Properties.Resources.border;
            btn6.BackgroundImageLayout = ImageLayout.Center;
            btn6.FlatStyle = FlatStyle.Flat;
            btn6.Font = new Font("Cascadia Code", 12F);
            btn6.Location = new Point(283, 8);
            btn6.Margin = new Padding(4);
            btn6.Name = "btn6";
            btn6.Size = new Size(113, 108);
            btn6.TabIndex = 15;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btnNum_Click;
            // 
            // btn5
            // 
            btn5.Anchor = AnchorStyles.None;
            btn5.BackgroundImage = Properties.Resources.border;
            btn5.BackgroundImageLayout = ImageLayout.Center;
            btn5.FlatStyle = FlatStyle.Flat;
            btn5.Font = new Font("Cascadia Code", 12F);
            btn5.Location = new Point(147, 8);
            btn5.Margin = new Padding(4);
            btn5.Name = "btn5";
            btn5.Size = new Size(113, 108);
            btn5.TabIndex = 14;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btnNum_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(btnAdd, 3, 0);
            tableLayoutPanel2.Controls.Add(btn1, 0, 0);
            tableLayoutPanel2.Controls.Add(btn3, 2, 0);
            tableLayoutPanel2.Controls.Add(btn2, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(15, 125);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(546, 125);
            tableLayoutPanel2.TabIndex = 31;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.None;
            btnAdd.BackgroundImage = Properties.Resources.border2;
            btnAdd.BackgroundImageLayout = ImageLayout.Center;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Cascadia Code", 12F);
            btnAdd.Location = new Point(420, 8);
            btnAdd.Margin = new Padding(4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(113, 108);
            btnAdd.TabIndex = 20;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnOperator_Click;
            // 
            // btn1
            // 
            btn1.Anchor = AnchorStyles.None;
            btn1.BackgroundImage = Properties.Resources.border;
            btn1.BackgroundImageLayout = ImageLayout.Center;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Font = new Font("Cascadia Code", 12F);
            btn1.Location = new Point(11, 8);
            btn1.Margin = new Padding(4);
            btn1.Name = "btn1";
            btn1.Size = new Size(113, 108);
            btn1.TabIndex = 17;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btnNum_Click;
            // 
            // btn3
            // 
            btn3.Anchor = AnchorStyles.None;
            btn3.BackgroundImage = Properties.Resources.border;
            btn3.BackgroundImageLayout = ImageLayout.Center;
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.Font = new Font("Cascadia Code", 12F);
            btn3.Location = new Point(283, 8);
            btn3.Margin = new Padding(4);
            btn3.Name = "btn3";
            btn3.Size = new Size(113, 108);
            btn3.TabIndex = 19;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btnNum_Click;
            // 
            // btn2
            // 
            btn2.Anchor = AnchorStyles.None;
            btn2.BackgroundImage = Properties.Resources.border;
            btn2.BackgroundImageLayout = ImageLayout.Center;
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.Font = new Font("Cascadia Code", 12F);
            btn2.Location = new Point(147, 8);
            btn2.Margin = new Padding(4);
            btn2.Name = "btn2";
            btn2.Size = new Size(113, 108);
            btn2.TabIndex = 18;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btnNum_Click;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 3;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel7.Controls.Add(btnDivide, 2, 0);
            tableLayoutPanel7.Controls.Add(btnClear, 0, 0);
            tableLayoutPanel7.Controls.Add(btnCE, 1, 0);
            tableLayoutPanel7.Dock = DockStyle.Top;
            tableLayoutPanel7.Location = new Point(15, 0);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Size = new Size(546, 125);
            tableLayoutPanel7.TabIndex = 35;
            // 
            // btnDivide
            // 
            btnDivide.Anchor = AnchorStyles.None;
            btnDivide.BackgroundImage = Properties.Resources.border2;
            btnDivide.BackgroundImageLayout = ImageLayout.Center;
            btnDivide.FlatStyle = FlatStyle.Flat;
            btnDivide.Font = new Font("Cascadia Code", 12F);
            btnDivide.Location = new Point(421, 8);
            btnDivide.Margin = new Padding(4);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(113, 108);
            btnDivide.TabIndex = 5;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnOperator_Click;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.None;
            btnClear.BackgroundImage = Properties.Resources.border4;
            btnClear.BackgroundImageLayout = ImageLayout.Center;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Cascadia Code", 12F);
            btnClear.Location = new Point(13, 8);
            btnClear.Margin = new Padding(4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(246, 108);
            btnClear.TabIndex = 0;
            btnClear.Tag = "clear";
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnCE
            // 
            btnCE.Anchor = AnchorStyles.None;
            btnCE.BackgroundImage = Properties.Resources.border4;
            btnCE.BackgroundImageLayout = ImageLayout.Center;
            btnCE.FlatStyle = FlatStyle.Flat;
            btnCE.Font = new Font("Cascadia Code", 12F);
            btnCE.Location = new Point(284, 8);
            btnCE.Margin = new Padding(4);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(113, 108);
            btnCE.TabIndex = 4;
            btnCE.Text = "CE";
            btnCE.UseVisualStyleBackColor = true;
            btnCE.Click += btnCE_Click;
            // 
            // pnl_displayCont
            // 
            pnl_displayCont.BackColor = Color.Transparent;
            pnl_displayCont.Controls.Add(txtInput);
            pnl_displayCont.Controls.Add(lblEntry);
            pnl_displayCont.Dock = DockStyle.Top;
            pnl_displayCont.Location = new Point(0, 0);
            pnl_displayCont.Margin = new Padding(4);
            pnl_displayCont.Name = "pnl_displayCont";
            pnl_displayCont.Padding = new Padding(15, 5, 15, 15);
            pnl_displayCont.Size = new Size(576, 125);
            pnl_displayCont.TabIndex = 1;
            // 
            // txtInput
            // 
            txtInput.Dock = DockStyle.Fill;
            txtInput.Font = new Font("Cascadia Code", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInput.Location = new Point(15, 37);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.ReadOnly = true;
            txtInput.ScrollBars = ScrollBars.Horizontal;
            txtInput.Size = new Size(546, 73);
            txtInput.TabIndex = 0;
            txtInput.Text = "0";
            // 
            // lblEntry
            // 
            lblEntry.AutoSize = true;
            lblEntry.Dock = DockStyle.Top;
            lblEntry.Location = new Point(15, 5);
            lblEntry.Name = "lblEntry";
            lblEntry.Padding = new Padding(0, 0, 0, 5);
            lblEntry.Size = new Size(0, 32);
            lblEntry.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 4;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.Controls.Add(button1, 3, 0);
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(200, 100);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackgroundImage = Properties.Resources.border2;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Cascadia Code", 12F);
            button1.Location = new Point(154, 4);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(42, 92);
            button1.TabIndex = 16;
            button1.Text = "-";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackgroundImage = Properties.Resources.border;
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Cascadia Code", 12F);
            button2.Location = new Point(4, 4);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(42, 108);
            button2.TabIndex = 13;
            button2.Text = "4";
            button2.UseVisualStyleBackColor = true;
            // 
            // frmCalculator
            // 
            AutoScaleDimensions = new SizeF(12F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(255, 246, 255);
            ClientSize = new Size(576, 761);
            Controls.Add(fpnl_buttonsCont);
            Controls.Add(pnl_displayCont);
            DoubleBuffered = true;
            Font = new Font("Cascadia Code", 12F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "frmCalculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Basic Calculator";
            fpnl_buttonsCont.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            pnl_displayCont.ResumeLayout(false);
            pnl_displayCont.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel fpnl_buttonsCont;
        private Button btnClear;
        private Panel pnl_displayCont;
        private Button btnCE;
        private Button btnDivide;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnMultiply;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btnMinus;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnAdd;
        private TextBox txtInput;
        private Label lblEntry;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel6;
        private Button btnEqual;
        private Button btn0;
        private Button btnSquare;
        private Button btnPoint;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Button button1;
        private Button button2;
        private TableLayoutPanel tableLayoutPanel7;
    }
}
