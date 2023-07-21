namespace CalculatorWebService
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
            loNum1 = new Label();
            loNum2 = new Label();
            loOutput = new Label();
            ctrlNum1 = new TextBox();
            ctrlNum2 = new TextBox();
            ctrlOutput = new TextBox();
            ctrlAdd = new Button();
            ctrlSubtract = new Button();
            ctrlMultiply = new Button();
            ctrlDivide = new Button();
            SuspendLayout();
            // 
            // loNum1
            // 
            loNum1.AutoSize = true;
            loNum1.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            loNum1.Location = new Point(59, 94);
            loNum1.Name = "loNum1";
            loNum1.Size = new Size(116, 24);
            loNum1.TabIndex = 0;
            loNum1.Text = "Number 1:";
            // 
            // loNum2
            // 
            loNum2.AutoSize = true;
            loNum2.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            loNum2.Location = new Point(59, 147);
            loNum2.Name = "loNum2";
            loNum2.Size = new Size(116, 24);
            loNum2.TabIndex = 1;
            loNum2.Text = "Number 2:";
            // 
            // loOutput
            // 
            loOutput.AutoSize = true;
            loOutput.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            loOutput.Location = new Point(59, 369);
            loOutput.Name = "loOutput";
            loOutput.Size = new Size(81, 24);
            loOutput.TabIndex = 2;
            loOutput.Text = "Result:";
            // 
            // ctrlNum1
            // 
            ctrlNum1.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ctrlNum1.Location = new Point(177, 86);
            ctrlNum1.Name = "ctrlNum1";
            ctrlNum1.Size = new Size(148, 32);
            ctrlNum1.TabIndex = 3;
            // 
            // ctrlNum2
            // 
            ctrlNum2.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ctrlNum2.Location = new Point(177, 139);
            ctrlNum2.Name = "ctrlNum2";
            ctrlNum2.Size = new Size(148, 32);
            ctrlNum2.TabIndex = 4;
            // 
            // ctrlOutput
            // 
            ctrlOutput.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ctrlOutput.Location = new Point(177, 361);
            ctrlOutput.Name = "ctrlOutput";
            ctrlOutput.Size = new Size(148, 32);
            ctrlOutput.TabIndex = 5;
            // 
            // ctrlAdd
            // 
            ctrlAdd.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ctrlAdd.Location = new Point(59, 206);
            ctrlAdd.Name = "ctrlAdd";
            ctrlAdd.Size = new Size(115, 38);
            ctrlAdd.TabIndex = 6;
            ctrlAdd.Text = "Add";
            ctrlAdd.UseVisualStyleBackColor = true;
            // 
            // ctrlSubtract
            // 
            ctrlSubtract.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ctrlSubtract.Location = new Point(201, 206);
            ctrlSubtract.Name = "ctrlSubtract";
            ctrlSubtract.Size = new Size(115, 38);
            ctrlSubtract.TabIndex = 7;
            ctrlSubtract.Text = "Subtract";
            ctrlSubtract.UseVisualStyleBackColor = true;
            // 
            // ctrlMultiply
            // 
            ctrlMultiply.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ctrlMultiply.Location = new Point(59, 259);
            ctrlMultiply.Name = "ctrlMultiply";
            ctrlMultiply.Size = new Size(115, 38);
            ctrlMultiply.TabIndex = 8;
            ctrlMultiply.Text = "Multiply";
            ctrlMultiply.UseVisualStyleBackColor = true;
            // 
            // ctrlDivide
            // 
            ctrlDivide.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ctrlDivide.Location = new Point(201, 259);
            ctrlDivide.Name = "ctrlDivide";
            ctrlDivide.Size = new Size(115, 38);
            ctrlDivide.TabIndex = 9;
            ctrlDivide.Text = "Divide";
            ctrlDivide.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 472);
            Controls.Add(ctrlDivide);
            Controls.Add(ctrlMultiply);
            Controls.Add(ctrlSubtract);
            Controls.Add(ctrlAdd);
            Controls.Add(ctrlOutput);
            Controls.Add(ctrlNum2);
            Controls.Add(ctrlNum1);
            Controls.Add(loOutput);
            Controls.Add(loNum2);
            Controls.Add(loNum1);
            Name = "Form1";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label loNum1;
        private Label loNum2;
        private Label loOutput;
        private TextBox ctrlNum1;
        private TextBox ctrlNum2;
        private TextBox ctrlOutput;
        private Button ctrlAdd;
        private Button ctrlSubtract;
        private Button ctrlMultiply;
        private Button ctrlDivide;
    }
}