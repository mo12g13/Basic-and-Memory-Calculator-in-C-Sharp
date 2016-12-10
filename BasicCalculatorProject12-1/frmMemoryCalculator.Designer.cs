namespace BasicCalculatorProject12_1
{
    partial class frmMemoryCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMemoryCalculator));
            this.lblresultDisplayBox = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnDivideOne = new System.Windows.Forms.Button();
            this.btnSquareRoot = new System.Windows.Forms.Button();
            this.btnAddition = new System.Windows.Forms.Button();
            this.btnSubstract = new System.Windows.Forms.Button();
            this.btnMultiplication = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnSignChange = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnMemoryContainValue = new System.Windows.Forms.Button();
            this.btnMemoryClear = new System.Windows.Forms.Button();
            this.btnMemoryRecall = new System.Windows.Forms.Button();
            this.btnMemoryStore = new System.Windows.Forms.Button();
            this.btnMemoryPlus = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.memoryCalculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblresultDisplayBox
            // 
            this.lblresultDisplayBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblresultDisplayBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblresultDisplayBox.Location = new System.Drawing.Point(12, 34);
            this.lblresultDisplayBox.Name = "lblresultDisplayBox";
            this.lblresultDisplayBox.Size = new System.Drawing.Size(69, 19);
            this.lblresultDisplayBox.TabIndex = 57;
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.Black;
            this.lblResult.Location = new System.Drawing.Point(11, 34);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(285, 31);
            this.lblResult.TabIndex = 56;
            this.lblResult.Text = "0";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // btnEqual
            // 
            this.btnEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqual.ForeColor = System.Drawing.Color.Red;
            this.btnEqual.Location = new System.Drawing.Point(256, 205);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(41, 82);
            this.btnEqual.TabIndex = 35;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.EqualButtonPress);
            // 
            // btnDivideOne
            // 
            this.btnDivideOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivideOne.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDivideOne.Location = new System.Drawing.Point(256, 161);
            this.btnDivideOne.Name = "btnDivideOne";
            this.btnDivideOne.Size = new System.Drawing.Size(41, 38);
            this.btnDivideOne.TabIndex = 51;
            this.btnDivideOne.Text = "1/X";
            this.btnDivideOne.UseVisualStyleBackColor = true;
            this.btnDivideOne.Click += new System.EventHandler(this.OperatorPress);
            // 
            // btnSquareRoot
            // 
            this.btnSquareRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSquareRoot.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSquareRoot.Location = new System.Drawing.Point(256, 117);
            this.btnSquareRoot.Name = "btnSquareRoot";
            this.btnSquareRoot.Size = new System.Drawing.Size(41, 38);
            this.btnSquareRoot.TabIndex = 50;
            this.btnSquareRoot.Text = "sqrt";
            this.btnSquareRoot.UseVisualStyleBackColor = true;
            this.btnSquareRoot.Click += new System.EventHandler(this.OperatorPress);
            // 
            // btnAddition
            // 
            this.btnAddition.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddition.ForeColor = System.Drawing.Color.Red;
            this.btnAddition.Location = new System.Drawing.Point(209, 249);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(41, 38);
            this.btnAddition.TabIndex = 49;
            this.btnAddition.TabStop = false;
            this.btnAddition.Text = "+";
            this.btnAddition.UseVisualStyleBackColor = true;
            this.btnAddition.Click += new System.EventHandler(this.OperatorPress);
            // 
            // btnSubstract
            // 
            this.btnSubstract.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubstract.ForeColor = System.Drawing.Color.Red;
            this.btnSubstract.Location = new System.Drawing.Point(209, 205);
            this.btnSubstract.Name = "btnSubstract";
            this.btnSubstract.Size = new System.Drawing.Size(41, 38);
            this.btnSubstract.TabIndex = 48;
            this.btnSubstract.Text = "-";
            this.btnSubstract.UseVisualStyleBackColor = true;
            this.btnSubstract.Click += new System.EventHandler(this.OperatorPress);
            // 
            // btnMultiplication
            // 
            this.btnMultiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplication.ForeColor = System.Drawing.Color.Red;
            this.btnMultiplication.Location = new System.Drawing.Point(209, 161);
            this.btnMultiplication.Name = "btnMultiplication";
            this.btnMultiplication.Size = new System.Drawing.Size(41, 38);
            this.btnMultiplication.TabIndex = 47;
            this.btnMultiplication.Text = "*";
            this.btnMultiplication.UseVisualStyleBackColor = true;
            this.btnMultiplication.Click += new System.EventHandler(this.OperatorPress);
            // 
            // btnDivide
            // 
            this.btnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.ForeColor = System.Drawing.Color.Red;
            this.btnDivide.Location = new System.Drawing.Point(209, 116);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(41, 38);
            this.btnDivide.TabIndex = 46;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.OperatorPress);
            // 
            // btnDot
            // 
            this.btnDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDot.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnDot.Location = new System.Drawing.Point(162, 249);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(41, 38);
            this.btnDot.TabIndex = 45;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = true;
            this.btnDot.Click += new System.EventHandler(this.UserNumberClick);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn3.Location = new System.Drawing.Point(162, 205);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(41, 38);
            this.btn3.TabIndex = 44;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.UserNumberClick);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn6.Location = new System.Drawing.Point(162, 161);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(41, 38);
            this.btn6.TabIndex = 37;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.UserNumberClick);
            // 
            // btnSignChange
            // 
            this.btnSignChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignChange.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnSignChange.Location = new System.Drawing.Point(115, 249);
            this.btnSignChange.Name = "btnSignChange";
            this.btnSignChange.Size = new System.Drawing.Size(41, 38);
            this.btnSignChange.TabIndex = 43;
            this.btnSignChange.Text = "+/-";
            this.btnSignChange.UseVisualStyleBackColor = true;
            this.btnSignChange.Click += new System.EventHandler(this.OperatorPress);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn2.Location = new System.Drawing.Point(115, 205);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(41, 38);
            this.btn2.TabIndex = 42;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.UserNumberClick);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn0.Location = new System.Drawing.Point(68, 249);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(41, 38);
            this.btn0.TabIndex = 41;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.UserNumberClick);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn5.Location = new System.Drawing.Point(115, 161);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(41, 38);
            this.btn5.TabIndex = 40;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.UserNumberClick);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn1.Location = new System.Drawing.Point(68, 205);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(41, 38);
            this.btn1.TabIndex = 39;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.UserNumberClick);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn9.Location = new System.Drawing.Point(162, 117);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(41, 38);
            this.btn9.TabIndex = 38;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.UserNumberClick);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn4.Location = new System.Drawing.Point(68, 161);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(41, 38);
            this.btn4.TabIndex = 53;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.UserNumberClick);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn8.Location = new System.Drawing.Point(115, 117);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(41, 38);
            this.btn8.TabIndex = 54;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.UserNumberClick);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn7.Location = new System.Drawing.Point(68, 117);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(41, 38);
            this.btn7.TabIndex = 52;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.UserNumberClick);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Red;
            this.btnClear.Location = new System.Drawing.Point(162, 68);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(135, 42);
            this.btnClear.TabIndex = 36;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Red;
            this.btnBack.Location = new System.Drawing.Point(67, 68);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(88, 43);
            this.btnBack.TabIndex = 55;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnMemoryContainValue
            // 
            this.btnMemoryContainValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemoryContainValue.Location = new System.Drawing.Point(11, 68);
            this.btnMemoryContainValue.Name = "btnMemoryContainValue";
            this.btnMemoryContainValue.Size = new System.Drawing.Size(50, 42);
            this.btnMemoryContainValue.TabIndex = 58;
            this.btnMemoryContainValue.Text = "M";
            this.btnMemoryContainValue.UseVisualStyleBackColor = true;
            // 
            // btnMemoryClear
            // 
            this.btnMemoryClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemoryClear.ForeColor = System.Drawing.Color.Red;
            this.btnMemoryClear.Location = new System.Drawing.Point(12, 117);
            this.btnMemoryClear.Name = "btnMemoryClear";
            this.btnMemoryClear.Size = new System.Drawing.Size(50, 37);
            this.btnMemoryClear.TabIndex = 58;
            this.btnMemoryClear.Text = "MC";
            this.btnMemoryClear.UseVisualStyleBackColor = true;
            this.btnMemoryClear.Click += new System.EventHandler(this.memoryButtonsClick);
            // 
            // btnMemoryRecall
            // 
            this.btnMemoryRecall.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemoryRecall.ForeColor = System.Drawing.Color.Red;
            this.btnMemoryRecall.Location = new System.Drawing.Point(11, 162);
            this.btnMemoryRecall.Name = "btnMemoryRecall";
            this.btnMemoryRecall.Size = new System.Drawing.Size(50, 37);
            this.btnMemoryRecall.TabIndex = 58;
            this.btnMemoryRecall.Text = "MR";
            this.btnMemoryRecall.UseVisualStyleBackColor = true;
            this.btnMemoryRecall.Click += new System.EventHandler(this.memoryButtonsClick);
            // 
            // btnMemoryStore
            // 
            this.btnMemoryStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemoryStore.ForeColor = System.Drawing.Color.Red;
            this.btnMemoryStore.Location = new System.Drawing.Point(11, 205);
            this.btnMemoryStore.Name = "btnMemoryStore";
            this.btnMemoryStore.Size = new System.Drawing.Size(50, 37);
            this.btnMemoryStore.TabIndex = 58;
            this.btnMemoryStore.Text = "MS";
            this.btnMemoryStore.UseVisualStyleBackColor = true;
            this.btnMemoryStore.Click += new System.EventHandler(this.memoryButtonsClick);
            // 
            // btnMemoryPlus
            // 
            this.btnMemoryPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemoryPlus.ForeColor = System.Drawing.Color.Red;
            this.btnMemoryPlus.Location = new System.Drawing.Point(11, 248);
            this.btnMemoryPlus.Name = "btnMemoryPlus";
            this.btnMemoryPlus.Size = new System.Drawing.Size(50, 37);
            this.btnMemoryPlus.TabIndex = 58;
            this.btnMemoryPlus.Text = "M+";
            this.btnMemoryPlus.UseVisualStyleBackColor = true;
            this.btnMemoryPlus.Click += new System.EventHandler(this.memoryButtonsClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(301, 29);
            this.menuStrip1.TabIndex = 59;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.memoryCalculatorToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(56, 25);
            this.toolStripMenuItem1.Text = "View";
            // 
            // memoryCalculatorToolStripMenuItem
            // 
            this.memoryCalculatorToolStripMenuItem.AutoSize = false;
            this.memoryCalculatorToolStripMenuItem.Name = "memoryCalculatorToolStripMenuItem";
            this.memoryCalculatorToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.memoryCalculatorToolStripMenuItem.Text = "Standard Calculator";
            this.memoryCalculatorToolStripMenuItem.Click += new System.EventHandler(this.memoryCalculatorToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 20);
            this.label1.TabIndex = 62;
            this.label1.Text = "Momo Johnson Project 14-1";
            // 
            // frmMemoryCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 289);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnMemoryPlus);
            this.Controls.Add(this.btnMemoryStore);
            this.Controls.Add(this.btnMemoryRecall);
            this.Controls.Add(this.btnMemoryClear);
            this.Controls.Add(this.btnMemoryContainValue);
            this.Controls.Add(this.lblresultDisplayBox);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnDivideOne);
            this.Controls.Add(this.btnSquareRoot);
            this.Controls.Add(this.btnAddition);
            this.Controls.Add(this.btnSubstract);
            this.Controls.Add(this.btnMultiplication);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btnSignChange);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmMemoryCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memory Calculator";
            this.Load += new System.EventHandler(this.frmMemoryCalculator_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.calculator_KeyPress);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblresultDisplayBox;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnDivideOne;
        private System.Windows.Forms.Button btnSquareRoot;
        private System.Windows.Forms.Button btnAddition;
        private System.Windows.Forms.Button btnSubstract;
        private System.Windows.Forms.Button btnMultiplication;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnSignChange;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnMemoryContainValue;
        private System.Windows.Forms.Button btnMemoryClear;
        private System.Windows.Forms.Button btnMemoryRecall;
        private System.Windows.Forms.Button btnMemoryStore;
        private System.Windows.Forms.Button btnMemoryPlus;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem memoryCalculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}