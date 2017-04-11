namespace UI
{
    partial class Main
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
            this.plansPanel = new System.Windows.Forms.Panel();
            this.addPlanButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // plansPanel
            // 
            this.plansPanel.Location = new System.Drawing.Point(12, 12);
            this.plansPanel.Name = "plansPanel";
            this.plansPanel.Size = new System.Drawing.Size(736, 359);
            this.plansPanel.TabIndex = 0;
            // 
            // addPlanButton
            // 
            this.addPlanButton.Location = new System.Drawing.Point(673, 377);
            this.addPlanButton.Name = "addPlanButton";
            this.addPlanButton.Size = new System.Drawing.Size(75, 23);
            this.addPlanButton.TabIndex = 1;
            this.addPlanButton.UseVisualStyleBackColor = true;
            this.addPlanButton.Click += new System.EventHandler(this.addPlanButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 449);
            this.Controls.Add(this.addPlanButton);
            this.Controls.Add(this.plansPanel);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plansPanel;
        private System.Windows.Forms.Button addPlanButton;


    }
}