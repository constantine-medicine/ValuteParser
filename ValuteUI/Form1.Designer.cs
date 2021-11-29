namespace ValuteUI
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.txtBoxResult = new System.Windows.Forms.RichTextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.checkBoxClear = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtBoxResult
            // 
            this.txtBoxResult.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxResult.Location = new System.Drawing.Point(230, 22);
            this.txtBoxResult.Name = "txtBoxResult";
            this.txtBoxResult.Size = new System.Drawing.Size(558, 169);
            this.txtBoxResult.TabIndex = 2;
            this.txtBoxResult.Text = "";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(138, 21);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(86, 34);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn1.Location = new System.Drawing.Point(230, 197);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(51, 34);
            this.btn1.TabIndex = 3;
            this.btn1.Text = "USD";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btnGetResult_Click);
            this.btn1.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn2.Location = new System.Drawing.Point(230, 237);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(51, 34);
            this.btn2.TabIndex = 4;
            this.btn2.Text = "EUR";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn3.Location = new System.Drawing.Point(395, 197);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(51, 34);
            this.btn3.TabIndex = 5;
            this.btn3.Text = "GBP";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btnGetResult_Click);
            this.btn3.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn4.Location = new System.Drawing.Point(395, 237);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(51, 34);
            this.btn4.TabIndex = 7;
            this.btn4.Text = "JPY";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btnGetResult_Click);
            this.btn4.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn5.Location = new System.Drawing.Point(576, 237);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(51, 34);
            this.btn5.TabIndex = 9;
            this.btn5.Text = "AZN";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btnGetResult_Click);
            this.btn5.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn6.Location = new System.Drawing.Point(737, 277);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(51, 34);
            this.btn6.TabIndex = 10;
            this.btn6.Text = "BRL";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btnGetResult_Click);
            this.btn6.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn7.Location = new System.Drawing.Point(576, 197);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(51, 34);
            this.btn7.TabIndex = 11;
            this.btn7.Text = "AMD";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btnGetResult_Click);
            this.btn7.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn8.Location = new System.Drawing.Point(737, 197);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(51, 34);
            this.btn8.TabIndex = 12;
            this.btn8.Text = "BYN";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btnGetResult_Click);
            this.btn8.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn9.Location = new System.Drawing.Point(737, 237);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(51, 34);
            this.btn9.TabIndex = 13;
            this.btn9.Text = "BGN";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btnGetResult_Click);
            this.btn9.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // checkBoxClear
            // 
            this.checkBoxClear.AutoSize = true;
            this.checkBoxClear.ForeColor = System.Drawing.Color.Yellow;
            this.checkBoxClear.Location = new System.Drawing.Point(68, 61);
            this.checkBoxClear.Name = "checkBoxClear";
            this.checkBoxClear.Size = new System.Drawing.Size(156, 26);
            this.checkBoxClear.TabIndex = 14;
            this.checkBoxClear.Text = "Авто-очистка";
            this.checkBoxClear.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(808, 329);
            this.Controls.Add(this.checkBoxClear);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txtBoxResult);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Курсы валют";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RichTextBox txtBoxResult;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnClear;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private ToolTip toolTip1;
        private CheckBox checkBoxClear;
    }
}