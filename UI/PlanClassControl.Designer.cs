namespace UI
{
    partial class PlanClassControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.planPanel = new System.Windows.Forms.Panel();
            this.planPictureBox = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.addPlanButton = new System.Windows.Forms.Button();
            this.planPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.planPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // planPanel
            // 
            this.planPanel.Controls.Add(this.planPictureBox);
            this.planPanel.Location = new System.Drawing.Point(3, 36);
            this.planPanel.Name = "planPanel";
            this.planPanel.Size = new System.Drawing.Size(201, 326);
            this.planPanel.TabIndex = 0;
            // 
            // planPictureBox
            // 
            this.planPictureBox.Location = new System.Drawing.Point(3, 3);
            this.planPictureBox.Name = "planPictureBox";
            this.planPictureBox.Size = new System.Drawing.Size(195, 320);
            this.planPictureBox.TabIndex = 0;
            this.planPictureBox.TabStop = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(85, 10);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(0, 12);
            this.titleLabel.TabIndex = 1;
            // 
            // addPlanButton
            // 
            this.addPlanButton.Location = new System.Drawing.Point(176, 5);
            this.addPlanButton.Name = "addPlanButton";
            this.addPlanButton.Size = new System.Drawing.Size(25, 23);
            this.addPlanButton.TabIndex = 2;
            this.addPlanButton.Text = "+";
            this.addPlanButton.UseVisualStyleBackColor = true;
            this.addPlanButton.Click += new System.EventHandler(this.addPlanButton_Click);
            // 
            // PlanClassControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addPlanButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.planPanel);
            this.Name = "PlanClassControl";
            this.Size = new System.Drawing.Size(207, 365);
            this.planPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.planPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel planPanel;
        private System.Windows.Forms.PictureBox planPictureBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button addPlanButton;
    }
}
