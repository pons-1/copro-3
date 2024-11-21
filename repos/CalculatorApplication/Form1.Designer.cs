namespace CalculatorApplication
{
    partial class FrmCalculator
    {

        private System.ComponentModel.IContainer components = null;


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
            components = new System.ComponentModel.Container();
            txtBoxInput1 = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txtBoxInput2 = new TextBox();
            cbOperator = new ComboBox();
            lblDisplayTotal = new Label();
            btnEqual = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtBoxInput1
            // 
            txtBoxInput1.Location = new Point(182, 22);
            txtBoxInput1.Margin = new Padding(3, 2, 3, 2);
            txtBoxInput1.Name = "txtBoxInput1";
            txtBoxInput1.Size = new Size(110, 23);
            txtBoxInput1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txtBoxInput2
            // 
            txtBoxInput2.Location = new Point(182, 76);
            txtBoxInput2.Margin = new Padding(3, 2, 3, 2);
            txtBoxInput2.Name = "txtBoxInput2";
            txtBoxInput2.Size = new Size(110, 23);
            txtBoxInput2.TabIndex = 2;
            txtBoxInput2.TextChanged += txtBoxInput2_TextChanged;
            // 
            // cbOperator
            // 
            cbOperator.FormattingEnabled = true;
            cbOperator.Items.AddRange(new object[] { "+", "-", "*", "/" });
            cbOperator.Location = new Point(210, 49);
            cbOperator.Margin = new Padding(3, 2, 3, 2);
            cbOperator.Name = "cbOperator";
            cbOperator.Size = new Size(54, 23);
            cbOperator.TabIndex = 3;
            // 
            // lblDisplayTotal
            // 
            lblDisplayTotal.AutoSize = true;
            lblDisplayTotal.Location = new Point(213, 112);
            lblDisplayTotal.Name = "lblDisplayTotal";
            lblDisplayTotal.Size = new Size(13, 15);
            lblDisplayTotal.TabIndex = 4;
            lblDisplayTotal.Text = "0";
            // 
            // btnEqual
            // 
            btnEqual.Location = new Point(182, 138);
            btnEqual.Margin = new Padding(3, 2, 3, 2);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(82, 22);
            btnEqual.TabIndex = 5;
            btnEqual.Text = "Enter";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 22);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 6;
            label1.Text = "Enter Number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 79);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 7;
            label2.Text = "Enter Number:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(130, 112);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 8;
            label3.Text = "Answer";
            // 
            // FrmCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 205);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEqual);
            Controls.Add(lblDisplayTotal);
            Controls.Add(cbOperator);
            Controls.Add(txtBoxInput2);
            Controls.Add(txtBoxInput1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmCalculator";
            Text = "FrmCalculator";
            Load += FrmCalculator_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxInput1;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txtBoxInput2;
        private ComboBox cbOperator;
        private Label lblDisplayTotal;
        private Button btnEqual;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
