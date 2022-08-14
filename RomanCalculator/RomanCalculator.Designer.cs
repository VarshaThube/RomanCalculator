namespace RomanCalculator
{
    partial class RomanCalculator
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
            this.txtFirstNumber = new System.Windows.Forms.TextBox();
            this.txtSecondNumber = new System.Windows.Forms.TextBox();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.btnCalculateSum = new System.Windows.Forms.Button();
            this.pictureBoxPlusSymbol = new System.Windows.Forms.PictureBox();
            this.pictureBoxEqualSymbol = new System.Windows.Forms.PictureBox();
            this.lblFirstNumber = new System.Windows.Forms.Label();
            this.lblSecondNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlusSymbol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEqualSymbol)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFirstNumber
            // 
            this.txtFirstNumber.Location = new System.Drawing.Point(281, 31);
            this.txtFirstNumber.Name = "txtFirstNumber";
            this.txtFirstNumber.Size = new System.Drawing.Size(239, 20);
            this.txtFirstNumber.TabIndex = 0;
            // 
            // txtSecondNumber
            // 
            this.txtSecondNumber.Location = new System.Drawing.Point(281, 89);
            this.txtSecondNumber.Name = "txtSecondNumber";
            this.txtSecondNumber.Size = new System.Drawing.Size(239, 20);
            this.txtSecondNumber.TabIndex = 1;
            // 
            // txtSum
            // 
            this.txtSum.BackColor = System.Drawing.SystemColors.Window;
            this.txtSum.ForeColor = System.Drawing.Color.Black;
            this.txtSum.Location = new System.Drawing.Point(281, 183);
            this.txtSum.Name = "txtSum";
            this.txtSum.Size = new System.Drawing.Size(239, 20);
            this.txtSum.TabIndex = 2;
            // 
            // btnCalculateSum
            // 
            this.btnCalculateSum.Location = new System.Drawing.Point(298, 236);
            this.btnCalculateSum.Name = "btnCalculateSum";
            this.btnCalculateSum.Size = new System.Drawing.Size(206, 23);
            this.btnCalculateSum.TabIndex = 3;
            this.btnCalculateSum.Text = "Compute";
            this.btnCalculateSum.UseVisualStyleBackColor = true;
            this.btnCalculateSum.Click += new System.EventHandler(this.btnCalculateSum_Click);
            // 
            // pictureBoxPlusSymbol
            // 
            this.pictureBoxPlusSymbol.Image = global::RomanCalculator.Properties.Resources.plus;
            this.pictureBoxPlusSymbol.Location = new System.Drawing.Point(208, 56);
            this.pictureBoxPlusSymbol.Name = "pictureBoxPlusSymbol";
            this.pictureBoxPlusSymbol.Size = new System.Drawing.Size(35, 35);
            this.pictureBoxPlusSymbol.TabIndex = 4;
            this.pictureBoxPlusSymbol.TabStop = false;
            // 
            // pictureBoxEqualSymbol
            // 
            this.pictureBoxEqualSymbol.Image = global::RomanCalculator.Properties.Resources.Equalsymbol_svg;
            this.pictureBoxEqualSymbol.Location = new System.Drawing.Point(208, 171);
            this.pictureBoxEqualSymbol.Name = "pictureBoxEqualSymbol";
            this.pictureBoxEqualSymbol.Size = new System.Drawing.Size(35, 32);
            this.pictureBoxEqualSymbol.TabIndex = 5;
            this.pictureBoxEqualSymbol.TabStop = false;
            // 
            // lblFirstNumber
            // 
            this.lblFirstNumber.AutoSize = true;
            this.lblFirstNumber.Location = new System.Drawing.Point(281, 56);
            this.lblFirstNumber.Name = "lblFirstNumber";
            this.lblFirstNumber.Size = new System.Drawing.Size(0, 13);
            this.lblFirstNumber.TabIndex = 6;
            this.lblFirstNumber.ForeColor = System.Drawing.Color.Red;
            // 
            // lblSecondNumber
            // 
            this.lblSecondNumber.AutoSize = true;
            this.lblSecondNumber.Location = new System.Drawing.Point(281, 112);
            this.lblSecondNumber.Name = "lblSecondNumber";
            this.lblSecondNumber.Size = new System.Drawing.Size(0, 13);
            this.lblSecondNumber.TabIndex = 7;
            this.lblSecondNumber.ForeColor = System.Drawing.Color.Red;
            // 
            // RomanCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 353);
            this.Controls.Add(this.lblSecondNumber);
            this.Controls.Add(this.lblFirstNumber);
            this.Controls.Add(this.pictureBoxEqualSymbol);
            this.Controls.Add(this.pictureBoxPlusSymbol);
            this.Controls.Add(this.btnCalculateSum);
            this.Controls.Add(this.txtSum);
            this.Controls.Add(this.txtSecondNumber);
            this.Controls.Add(this.txtFirstNumber);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "RomanCalculator";
            this.Text = "Roman Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlusSymbol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEqualSymbol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstNumber;
        private System.Windows.Forms.TextBox txtSecondNumber;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.Button btnCalculateSum;
        private System.Windows.Forms.PictureBox pictureBoxPlusSymbol;
        private System.Windows.Forms.PictureBox pictureBoxEqualSymbol;
        private System.Windows.Forms.Label lblFirstNumber;
        private System.Windows.Forms.Label lblSecondNumber;
    }
}

