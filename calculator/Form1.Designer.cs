namespace calculator
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
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.textBoxHistory = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.operatorDiv = new System.Windows.Forms.Button();
            this.operatorModulus = new System.Windows.Forms.Button();
            this.btnParentClose = new System.Windows.Forms.Button();
            this.btnParentOpen = new System.Windows.Forms.Button();
            this.buttonSquare = new System.Windows.Forms.Button();
            this.OperatorMult = new System.Windows.Forms.Button();
            this.operand9 = new System.Windows.Forms.Button();
            this.operand8 = new System.Windows.Forms.Button();
            this.operand7 = new System.Windows.Forms.Button();
            this.buttonCube = new System.Windows.Forms.Button();
            this.operatorMin = new System.Windows.Forms.Button();
            this.operand6 = new System.Windows.Forms.Button();
            this.operand5 = new System.Windows.Forms.Button();
            this.operand4 = new System.Windows.Forms.Button();
            this.buttonPangkatN = new System.Windows.Forms.Button();
            this.opeartorPlus = new System.Windows.Forms.Button();
            this.operand3 = new System.Windows.Forms.Button();
            this.operand2 = new System.Windows.Forms.Button();
            this.operand1 = new System.Windows.Forms.Button();
            this.button10pangkatN = new System.Windows.Forms.Button();
            this.buttonResult = new System.Windows.Forms.Button();
            this.buttonDot = new System.Windows.Forms.Button();
            this.operand0 = new System.Windows.Forms.Button();
            this.buttonPlusMinus = new System.Windows.Forms.Button();
            this.buttonPerX = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxResult
            // 
            this.textBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxResult.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxResult.Location = new System.Drawing.Point(13, 84);
            this.textBoxResult.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(323, 35);
            this.textBoxResult.TabIndex = 1;
            this.textBoxResult.Text = "0";
            this.textBoxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxHistory
            // 
            this.textBoxHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxHistory.Enabled = false;
            this.textBoxHistory.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHistory.Location = new System.Drawing.Point(13, 52);
            this.textBoxHistory.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxHistory.Name = "textBoxHistory";
            this.textBoxHistory.ReadOnly = true;
            this.textBoxHistory.Size = new System.Drawing.Size(323, 17);
            this.textBoxHistory.TabIndex = 0;
            this.textBoxHistory.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(12, 133);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 40);
            this.button3.TabIndex = 4;
            this.button3.Text = "C";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnClearClick);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(210, 133);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(60, 40);
            this.button6.TabIndex = 7;
            this.button6.Text = "tan";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.btnTrigonoClick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(144, 133);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(60, 40);
            this.button5.TabIndex = 6;
            this.button5.Text = "cos";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btnTrigonoClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(78, 133);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 40);
            this.button4.TabIndex = 5;
            this.button4.Text = "sin";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnTrigonoClick);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(276, 133);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(60, 40);
            this.button7.TabIndex = 8;
            this.button7.Text = "Del";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.btnDeleteClick);
            // 
            // operatorDiv
            // 
            this.operatorDiv.Location = new System.Drawing.Point(276, 179);
            this.operatorDiv.Name = "operatorDiv";
            this.operatorDiv.Size = new System.Drawing.Size(60, 40);
            this.operatorDiv.TabIndex = 13;
            this.operatorDiv.Text = "/";
            this.operatorDiv.UseVisualStyleBackColor = true;
            this.operatorDiv.Click += new System.EventHandler(this.btnOperatorClick);
            // 
            // operatorModulus
            // 
            this.operatorModulus.Location = new System.Drawing.Point(210, 179);
            this.operatorModulus.Name = "operatorModulus";
            this.operatorModulus.Size = new System.Drawing.Size(60, 40);
            this.operatorModulus.TabIndex = 12;
            this.operatorModulus.Text = "%";
            this.operatorModulus.UseVisualStyleBackColor = true;
            this.operatorModulus.Click += new System.EventHandler(this.btnOperatorClick);
            // 
            // btnParentClose
            // 
            this.btnParentClose.Location = new System.Drawing.Point(144, 179);
            this.btnParentClose.Name = "btnParentClose";
            this.btnParentClose.Size = new System.Drawing.Size(60, 40);
            this.btnParentClose.TabIndex = 11;
            this.btnParentClose.Text = ")";
            this.btnParentClose.UseVisualStyleBackColor = true;
            this.btnParentClose.Click += new System.EventHandler(this.btnParentClick);
            // 
            // btnParentOpen
            // 
            this.btnParentOpen.Location = new System.Drawing.Point(78, 179);
            this.btnParentOpen.Name = "btnParentOpen";
            this.btnParentOpen.Size = new System.Drawing.Size(60, 40);
            this.btnParentOpen.TabIndex = 10;
            this.btnParentOpen.Text = "(";
            this.btnParentOpen.UseVisualStyleBackColor = true;
            this.btnParentOpen.Click += new System.EventHandler(this.btnParentClick);
            // 
            // buttonSquare
            // 
            this.buttonSquare.Location = new System.Drawing.Point(12, 179);
            this.buttonSquare.Name = "buttonSquare";
            this.buttonSquare.Size = new System.Drawing.Size(60, 40);
            this.buttonSquare.TabIndex = 9;
            this.buttonSquare.Text = "x^2";
            this.buttonSquare.UseVisualStyleBackColor = true;
            this.buttonSquare.Click += new System.EventHandler(this.btnPangkatClick);
            // 
            // OperatorMult
            // 
            this.OperatorMult.Location = new System.Drawing.Point(276, 225);
            this.OperatorMult.Name = "OperatorMult";
            this.OperatorMult.Size = new System.Drawing.Size(60, 40);
            this.OperatorMult.TabIndex = 18;
            this.OperatorMult.Text = "*";
            this.OperatorMult.UseVisualStyleBackColor = true;
            this.OperatorMult.Click += new System.EventHandler(this.btnOperatorClick);
            // 
            // operand9
            // 
            this.operand9.BackColor = System.Drawing.SystemColors.HighlightText;
            this.operand9.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operand9.Location = new System.Drawing.Point(210, 225);
            this.operand9.Name = "operand9";
            this.operand9.Size = new System.Drawing.Size(60, 40);
            this.operand9.TabIndex = 17;
            this.operand9.Text = "9";
            this.operand9.UseVisualStyleBackColor = false;
            this.operand9.Click += new System.EventHandler(this.btnOperandClick);
            // 
            // operand8
            // 
            this.operand8.BackColor = System.Drawing.SystemColors.HighlightText;
            this.operand8.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operand8.Location = new System.Drawing.Point(144, 225);
            this.operand8.Name = "operand8";
            this.operand8.Size = new System.Drawing.Size(60, 40);
            this.operand8.TabIndex = 16;
            this.operand8.Text = "8";
            this.operand8.UseVisualStyleBackColor = false;
            this.operand8.Click += new System.EventHandler(this.btnOperandClick);
            // 
            // operand7
            // 
            this.operand7.BackColor = System.Drawing.SystemColors.HighlightText;
            this.operand7.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operand7.Location = new System.Drawing.Point(78, 225);
            this.operand7.Name = "operand7";
            this.operand7.Size = new System.Drawing.Size(60, 40);
            this.operand7.TabIndex = 15;
            this.operand7.Text = "7";
            this.operand7.UseVisualStyleBackColor = false;
            this.operand7.Click += new System.EventHandler(this.btnOperandClick);
            // 
            // buttonCube
            // 
            this.buttonCube.Location = new System.Drawing.Point(12, 225);
            this.buttonCube.Name = "buttonCube";
            this.buttonCube.Size = new System.Drawing.Size(60, 40);
            this.buttonCube.TabIndex = 14;
            this.buttonCube.Text = "x^3";
            this.buttonCube.UseVisualStyleBackColor = true;
            this.buttonCube.Click += new System.EventHandler(this.btnPangkatClick);
            // 
            // operatorMin
            // 
            this.operatorMin.Location = new System.Drawing.Point(276, 271);
            this.operatorMin.Name = "operatorMin";
            this.operatorMin.Size = new System.Drawing.Size(60, 40);
            this.operatorMin.TabIndex = 23;
            this.operatorMin.Text = "-";
            this.operatorMin.UseVisualStyleBackColor = true;
            this.operatorMin.Click += new System.EventHandler(this.btnOperatorClick);
            // 
            // operand6
            // 
            this.operand6.BackColor = System.Drawing.SystemColors.HighlightText;
            this.operand6.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operand6.Location = new System.Drawing.Point(210, 271);
            this.operand6.Name = "operand6";
            this.operand6.Size = new System.Drawing.Size(60, 40);
            this.operand6.TabIndex = 22;
            this.operand6.Text = "6";
            this.operand6.UseVisualStyleBackColor = false;
            this.operand6.Click += new System.EventHandler(this.btnOperandClick);
            // 
            // operand5
            // 
            this.operand5.BackColor = System.Drawing.SystemColors.HighlightText;
            this.operand5.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operand5.Location = new System.Drawing.Point(144, 271);
            this.operand5.Name = "operand5";
            this.operand5.Size = new System.Drawing.Size(60, 40);
            this.operand5.TabIndex = 21;
            this.operand5.Text = "5";
            this.operand5.UseVisualStyleBackColor = false;
            this.operand5.Click += new System.EventHandler(this.btnOperandClick);
            // 
            // operand4
            // 
            this.operand4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.operand4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operand4.Location = new System.Drawing.Point(78, 271);
            this.operand4.Name = "operand4";
            this.operand4.Size = new System.Drawing.Size(60, 40);
            this.operand4.TabIndex = 20;
            this.operand4.Text = "4";
            this.operand4.UseVisualStyleBackColor = false;
            this.operand4.Click += new System.EventHandler(this.btnOperandClick);
            // 
            // buttonPangkatN
            // 
            this.buttonPangkatN.Location = new System.Drawing.Point(12, 271);
            this.buttonPangkatN.Name = "buttonPangkatN";
            this.buttonPangkatN.Size = new System.Drawing.Size(60, 40);
            this.buttonPangkatN.TabIndex = 19;
            this.buttonPangkatN.Text = "x^n";
            this.buttonPangkatN.UseVisualStyleBackColor = true;
            this.buttonPangkatN.Click += new System.EventHandler(this.btnPangkatClick);
            // 
            // opeartorPlus
            // 
            this.opeartorPlus.Location = new System.Drawing.Point(276, 317);
            this.opeartorPlus.Name = "opeartorPlus";
            this.opeartorPlus.Size = new System.Drawing.Size(60, 40);
            this.opeartorPlus.TabIndex = 28;
            this.opeartorPlus.Text = "+";
            this.opeartorPlus.UseVisualStyleBackColor = true;
            this.opeartorPlus.Click += new System.EventHandler(this.btnOperatorClick);
            // 
            // operand3
            // 
            this.operand3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.operand3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operand3.Location = new System.Drawing.Point(210, 317);
            this.operand3.Name = "operand3";
            this.operand3.Size = new System.Drawing.Size(60, 40);
            this.operand3.TabIndex = 27;
            this.operand3.Text = "3";
            this.operand3.UseVisualStyleBackColor = false;
            this.operand3.Click += new System.EventHandler(this.btnOperandClick);
            // 
            // operand2
            // 
            this.operand2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.operand2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operand2.Location = new System.Drawing.Point(144, 317);
            this.operand2.Name = "operand2";
            this.operand2.Size = new System.Drawing.Size(60, 40);
            this.operand2.TabIndex = 26;
            this.operand2.Text = "2";
            this.operand2.UseVisualStyleBackColor = false;
            this.operand2.Click += new System.EventHandler(this.btnOperandClick);
            // 
            // operand1
            // 
            this.operand1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.operand1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operand1.Location = new System.Drawing.Point(78, 317);
            this.operand1.Name = "operand1";
            this.operand1.Size = new System.Drawing.Size(60, 40);
            this.operand1.TabIndex = 25;
            this.operand1.Text = "1";
            this.operand1.UseVisualStyleBackColor = false;
            this.operand1.Click += new System.EventHandler(this.btnOperandClick);
            // 
            // button10pangkatN
            // 
            this.button10pangkatN.Location = new System.Drawing.Point(12, 317);
            this.button10pangkatN.Name = "button10pangkatN";
            this.button10pangkatN.Size = new System.Drawing.Size(60, 40);
            this.button10pangkatN.TabIndex = 24;
            this.button10pangkatN.Text = "10^n";
            this.button10pangkatN.UseVisualStyleBackColor = true;
            this.button10pangkatN.Click += new System.EventHandler(this.btnPangkatClick);
            // 
            // buttonResult
            // 
            this.buttonResult.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonResult.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonResult.Location = new System.Drawing.Point(276, 363);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(60, 40);
            this.buttonResult.TabIndex = 33;
            this.buttonResult.Text = "=";
            this.buttonResult.UseVisualStyleBackColor = false;
            this.buttonResult.Click += new System.EventHandler(this.btnResultClick);
            // 
            // buttonDot
            // 
            this.buttonDot.BackColor = System.Drawing.SystemColors.HighlightText;
            this.buttonDot.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDot.Location = new System.Drawing.Point(210, 363);
            this.buttonDot.Name = "buttonDot";
            this.buttonDot.Size = new System.Drawing.Size(60, 40);
            this.buttonDot.TabIndex = 32;
            this.buttonDot.Text = ".";
            this.buttonDot.UseVisualStyleBackColor = false;
            this.buttonDot.Click += new System.EventHandler(this.btnOperandClick);
            // 
            // operand0
            // 
            this.operand0.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.operand0.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operand0.Location = new System.Drawing.Point(144, 364);
            this.operand0.Name = "operand0";
            this.operand0.Size = new System.Drawing.Size(60, 40);
            this.operand0.TabIndex = 31;
            this.operand0.Text = "0";
            this.operand0.UseVisualStyleBackColor = false;
            this.operand0.Click += new System.EventHandler(this.btnOperandClick);
            // 
            // buttonPlusMinus
            // 
            this.buttonPlusMinus.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPlusMinus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonPlusMinus.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlusMinus.Location = new System.Drawing.Point(78, 363);
            this.buttonPlusMinus.Name = "buttonPlusMinus";
            this.buttonPlusMinus.Size = new System.Drawing.Size(60, 40);
            this.buttonPlusMinus.TabIndex = 30;
            this.buttonPlusMinus.Text = "+/-";
            this.buttonPlusMinus.UseVisualStyleBackColor = false;
            this.buttonPlusMinus.Click += new System.EventHandler(this.btnPlusMinusClicked);
            // 
            // buttonPerX
            // 
            this.buttonPerX.Location = new System.Drawing.Point(12, 363);
            this.buttonPerX.Name = "buttonPerX";
            this.buttonPerX.Size = new System.Drawing.Size(60, 40);
            this.buttonPerX.TabIndex = 29;
            this.buttonPerX.Text = "1/x";
            this.buttonPerX.UseVisualStyleBackColor = true;
            this.buttonPerX.Click += new System.EventHandler(this.btnPangkatClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 416);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.buttonDot);
            this.Controls.Add(this.operand0);
            this.Controls.Add(this.buttonPlusMinus);
            this.Controls.Add(this.buttonPerX);
            this.Controls.Add(this.opeartorPlus);
            this.Controls.Add(this.operand3);
            this.Controls.Add(this.operand2);
            this.Controls.Add(this.operand1);
            this.Controls.Add(this.button10pangkatN);
            this.Controls.Add(this.operatorMin);
            this.Controls.Add(this.operand6);
            this.Controls.Add(this.operand5);
            this.Controls.Add(this.operand4);
            this.Controls.Add(this.buttonPangkatN);
            this.Controls.Add(this.OperatorMult);
            this.Controls.Add(this.operand9);
            this.Controls.Add(this.operand8);
            this.Controls.Add(this.operand7);
            this.Controls.Add(this.buttonCube);
            this.Controls.Add(this.operatorDiv);
            this.Controls.Add(this.operatorModulus);
            this.Controls.Add(this.btnParentClose);
            this.Controls.Add(this.btnParentOpen);
            this.Controls.Add(this.buttonSquare);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBoxHistory);
            this.Controls.Add(this.textBoxResult);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.TextBox textBoxHistory;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button operatorDiv;
        private System.Windows.Forms.Button operatorModulus;
        private System.Windows.Forms.Button btnParentClose;
        private System.Windows.Forms.Button btnParentOpen;
        private System.Windows.Forms.Button buttonSquare;
        private System.Windows.Forms.Button OperatorMult;
        private System.Windows.Forms.Button operand9;
        private System.Windows.Forms.Button operand8;
        private System.Windows.Forms.Button operand7;
        private System.Windows.Forms.Button buttonCube;
        private System.Windows.Forms.Button operatorMin;
        private System.Windows.Forms.Button operand6;
        private System.Windows.Forms.Button operand5;
        private System.Windows.Forms.Button operand4;
        private System.Windows.Forms.Button buttonPangkatN;
        private System.Windows.Forms.Button opeartorPlus;
        private System.Windows.Forms.Button operand3;
        private System.Windows.Forms.Button operand2;
        private System.Windows.Forms.Button operand1;
        private System.Windows.Forms.Button button10pangkatN;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.Button buttonDot;
        private System.Windows.Forms.Button operand0;
        private System.Windows.Forms.Button buttonPlusMinus;
        private System.Windows.Forms.Button buttonPerX;
    }
}

