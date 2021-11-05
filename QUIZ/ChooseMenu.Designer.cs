
namespace QUIZ
{
    partial class ChooseMenu
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
            this.buttonStartNewQUIZ = new System.Windows.Forms.Button();
            this.labelUserName = new System.Windows.Forms.Label();
            this.buttonShowResults = new System.Windows.Forms.Button();
            this.buttonShowTop20 = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonTheme1 = new System.Windows.Forms.Button();
            this.buttonTheme2 = new System.Windows.Forms.Button();
            this.buttonRandomTheme = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonStartNewQUIZ
            // 
            this.buttonStartNewQUIZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStartNewQUIZ.Location = new System.Drawing.Point(321, 57);
            this.buttonStartNewQUIZ.Name = "buttonStartNewQUIZ";
            this.buttonStartNewQUIZ.Size = new System.Drawing.Size(162, 52);
            this.buttonStartNewQUIZ.TabIndex = 0;
            this.buttonStartNewQUIZ.Text = "Start new QUIZ";
            this.buttonStartNewQUIZ.UseVisualStyleBackColor = true;
            this.buttonStartNewQUIZ.Click += new System.EventHandler(this.StartNewQUIZ);
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(12, 22);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(33, 13);
            this.labelUserName.TabIndex = 1;
            this.labelUserName.Text = "Login";
            this.labelUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonShowResults
            // 
            this.buttonShowResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowResults.Location = new System.Drawing.Point(236, 204);
            this.buttonShowResults.Name = "buttonShowResults";
            this.buttonShowResults.Size = new System.Drawing.Size(162, 52);
            this.buttonShowResults.TabIndex = 2;
            this.buttonShowResults.Text = "Show Results";
            this.buttonShowResults.UseVisualStyleBackColor = true;
            // 
            // buttonShowTop20
            // 
            this.buttonShowTop20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowTop20.Location = new System.Drawing.Point(404, 204);
            this.buttonShowTop20.Name = "buttonShowTop20";
            this.buttonShowTop20.Size = new System.Drawing.Size(162, 52);
            this.buttonShowTop20.TabIndex = 3;
            this.buttonShowTop20.Text = "Show Top-20";
            this.buttonShowTop20.UseVisualStyleBackColor = true;
            // 
            // buttonSettings
            // 
            this.buttonSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSettings.Location = new System.Drawing.Point(321, 359);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(162, 34);
            this.buttonSettings.TabIndex = 4;
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // buttonTheme1
            // 
            this.buttonTheme1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTheme1.Location = new System.Drawing.Point(153, 115);
            this.buttonTheme1.Name = "buttonTheme1";
            this.buttonTheme1.Size = new System.Drawing.Size(162, 52);
            this.buttonTheme1.TabIndex = 5;
            this.buttonTheme1.Text = "Theme1";
            this.buttonTheme1.UseVisualStyleBackColor = true;
            this.buttonTheme1.Visible = false;
            // 
            // buttonTheme2
            // 
            this.buttonTheme2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTheme2.Location = new System.Drawing.Point(321, 115);
            this.buttonTheme2.Name = "buttonTheme2";
            this.buttonTheme2.Size = new System.Drawing.Size(162, 52);
            this.buttonTheme2.TabIndex = 6;
            this.buttonTheme2.Text = "Theme 2";
            this.buttonTheme2.UseVisualStyleBackColor = true;
            this.buttonTheme2.Visible = false;
            // 
            // buttonRandomTheme
            // 
            this.buttonRandomTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRandomTheme.Location = new System.Drawing.Point(489, 115);
            this.buttonRandomTheme.Name = "buttonRandomTheme";
            this.buttonRandomTheme.Size = new System.Drawing.Size(162, 52);
            this.buttonRandomTheme.TabIndex = 7;
            this.buttonRandomTheme.Text = "Random theme";
            this.buttonRandomTheme.UseVisualStyleBackColor = true;
            this.buttonRandomTheme.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "UserName:";
            // 
            // ChooseMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRandomTheme);
            this.Controls.Add(this.buttonTheme2);
            this.Controls.Add(this.buttonTheme1);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.buttonShowTop20);
            this.Controls.Add(this.buttonShowResults);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.buttonStartNewQUIZ);
            this.Name = "ChooseMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStartNewQUIZ;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Button buttonShowResults;
        private System.Windows.Forms.Button buttonShowTop20;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonTheme1;
        private System.Windows.Forms.Button buttonTheme2;
        private System.Windows.Forms.Button buttonRandomTheme;
        private System.Windows.Forms.Label label1;
    }
}