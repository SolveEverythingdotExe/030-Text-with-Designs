namespace MainApplication
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
            this.label1 = new System.Windows.Forms.Label();
            this.designLabel4 = new MainApplication.DesignLabel();
            this.designLabel3 = new MainApplication.DesignLabel();
            this.designLabel2 = new MainApplication.DesignLabel();
            this.designLabel1 = new MainApplication.DesignLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(635, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "SolveEverything.exe";
            // 
            // designLabel4
            // 
            this.designLabel4.Font = new System.Drawing.Font("Arial Black", 40F);
            this.designLabel4.Location = new System.Drawing.Point(80, 274);
            this.designLabel4.Name = "designLabel4";
            this.designLabel4.Size = new System.Drawing.Size(629, 86);
            this.designLabel4.TabIndex = 4;
            this.designLabel4.Text = "SolveEverything.exe";
            this.designLabel4.TextBorderStyle = MainApplication.DesignLabel.TextBorderStyles.Shadow;
            this.designLabel4.TextDesign = MainApplication.DesignLabel.TextDesigns.Neon;
            // 
            // designLabel3
            // 
            this.designLabel3.Font = new System.Drawing.Font("Arial Black", 40F);
            this.designLabel3.Location = new System.Drawing.Point(80, 183);
            this.designLabel3.Name = "designLabel3";
            this.designLabel3.Size = new System.Drawing.Size(629, 85);
            this.designLabel3.TabIndex = 3;
            this.designLabel3.Text = "SolveEverything.exe";
            this.designLabel3.TextBorderStyle = MainApplication.DesignLabel.TextBorderStyles.Embossed;
            this.designLabel3.TextDesign = MainApplication.DesignLabel.TextDesigns.Aqua;
            // 
            // designLabel2
            // 
            this.designLabel2.Font = new System.Drawing.Font("Arial Black", 40F);
            this.designLabel2.Location = new System.Drawing.Point(87, 94);
            this.designLabel2.Name = "designLabel2";
            this.designLabel2.Size = new System.Drawing.Size(641, 85);
            this.designLabel2.TabIndex = 2;
            this.designLabel2.Text = "SolveEverything.exe";
            this.designLabel2.TextBorderStyle = MainApplication.DesignLabel.TextBorderStyles.Normal;
            this.designLabel2.TextDesign = MainApplication.DesignLabel.TextDesigns.Metallic;
            // 
            // designLabel1
            // 
            this.designLabel1.Font = new System.Drawing.Font("Arial Black", 40F);
            this.designLabel1.Location = new System.Drawing.Point(68, 111);
            this.designLabel1.Name = "designLabel1";
            this.designLabel1.Size = new System.Drawing.Size(627, 90);
            this.designLabel1.TabIndex = 1;
            this.designLabel1.Text = null;
            this.designLabel1.TextBorderStyle = MainApplication.DesignLabel.TextBorderStyles.Normal;
            this.designLabel1.TextDesign = MainApplication.DesignLabel.TextDesigns.Metallic;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.designLabel4);
            this.Controls.Add(this.designLabel3);
            this.Controls.Add(this.designLabel2);
            this.Controls.Add(this.designLabel1);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DesignLabel designLabel1;
        private DesignLabel designLabel2;
        private DesignLabel designLabel3;
        private DesignLabel designLabel4;
    }
}

