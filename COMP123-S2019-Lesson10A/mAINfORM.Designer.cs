namespace COMP123_S2019_Lesson10A
{
    partial class MainForm
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
            this.NextButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.UnitSelectionGroupBox = new System.Windows.Forms.GroupBox();
            this.MetricUnitRadioButton = new System.Windows.Forms.RadioButton();
            this.ImperialUnitRadioButton = new System.Windows.Forms.RadioButton();
            this.UnitSelectionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(614, 453);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(148, 66);
            this.NextButton.TabIndex = 1;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(3, 460);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(148, 66);
            this.BackButton.TabIndex = 2;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // UnitSelectionGroupBox
            // 
            this.UnitSelectionGroupBox.Controls.Add(this.MetricUnitRadioButton);
            this.UnitSelectionGroupBox.Controls.Add(this.ImperialUnitRadioButton);
            this.UnitSelectionGroupBox.Location = new System.Drawing.Point(12, 12);
            this.UnitSelectionGroupBox.Name = "UnitSelectionGroupBox";
            this.UnitSelectionGroupBox.Size = new System.Drawing.Size(436, 217);
            this.UnitSelectionGroupBox.TabIndex = 3;
            this.UnitSelectionGroupBox.TabStop = false;
            // 
            // MetricUnitRadioButton
            // 
            this.MetricUnitRadioButton.AutoSize = true;
            this.MetricUnitRadioButton.Location = new System.Drawing.Point(28, 120);
            this.MetricUnitRadioButton.Name = "MetricUnitRadioButton";
            this.MetricUnitRadioButton.Size = new System.Drawing.Size(200, 67);
            this.MetricUnitRadioButton.TabIndex = 1;
            this.MetricUnitRadioButton.Text = "Metric";
            this.MetricUnitRadioButton.UseVisualStyleBackColor = true;
            // 
            // ImperialUnitRadioButton
            // 
            this.ImperialUnitRadioButton.AutoSize = true;
            this.ImperialUnitRadioButton.Checked = true;
            this.ImperialUnitRadioButton.Location = new System.Drawing.Point(28, 47);
            this.ImperialUnitRadioButton.Name = "ImperialUnitRadioButton";
            this.ImperialUnitRadioButton.Size = new System.Drawing.Size(246, 67);
            this.ImperialUnitRadioButton.TabIndex = 0;
            this.ImperialUnitRadioButton.TabStop = true;
            this.ImperialUnitRadioButton.Text = "Imperial";
            this.ImperialUnitRadioButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(31F, 61F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 531);
            this.Controls.Add(this.UnitSelectionGroupBox);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.NextButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.UnitSelectionGroupBox.ResumeLayout(false);
            this.UnitSelectionGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.GroupBox UnitSelectionGroupBox;
        private System.Windows.Forms.RadioButton MetricUnitRadioButton;
        private System.Windows.Forms.RadioButton ImperialUnitRadioButton;
    }
}

