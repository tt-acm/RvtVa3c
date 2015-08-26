namespace Spectacles.RevitExporter
{
    partial class ExportOptions
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Description = new System.Windows.Forms.Label();
            this.checkBox_FilterParameters = new System.Windows.Forms.CheckBox();
            this.checkBox_IncludeTypeParameters = new System.Windows.Forms.CheckBox();
            this.checkBox_CreateViews = new System.Windows.Forms.CheckBox();
            this.button_OK = new System.Windows.Forms.Button();
            this.button_CANCEL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Spectacles.RevitExporter.Properties.Resources.CORE_logo_horizontal;
            this.pictureBox2.Location = new System.Drawing.Point(193, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(404, 29);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Spectacles.RevitExporter.Properties.Resources.SPECTACLES_100px;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 45);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Description
            // 
            this.Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description.Location = new System.Drawing.Point(12, 92);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(598, 28);
            this.Description.TabIndex = 11;
            this.Description.Text = "Please specify what you\'d like to include in the exported Spectacles model.";
            // 
            // checkBox_FilterParameters
            // 
            this.checkBox_FilterParameters.AutoSize = true;
            this.checkBox_FilterParameters.Checked = true;
            this.checkBox_FilterParameters.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_FilterParameters.Location = new System.Drawing.Point(15, 134);
            this.checkBox_FilterParameters.Name = "checkBox_FilterParameters";
            this.checkBox_FilterParameters.Size = new System.Drawing.Size(476, 17);
            this.checkBox_FilterParameters.TabIndex = 14;
            this.checkBox_FilterParameters.Text = "Filter Parameters?  If checked, you can specify which parameters to include in th" +
    "e next window.";
            this.checkBox_FilterParameters.UseVisualStyleBackColor = true;
            this.checkBox_FilterParameters.CheckedChanged += new System.EventHandler(this.checkBox_FilterParameters_CheckedChanged);
            // 
            // checkBox_IncludeTypeParameters
            // 
            this.checkBox_IncludeTypeParameters.AutoSize = true;
            this.checkBox_IncludeTypeParameters.Checked = true;
            this.checkBox_IncludeTypeParameters.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_IncludeTypeParameters.Location = new System.Drawing.Point(15, 157);
            this.checkBox_IncludeTypeParameters.Name = "checkBox_IncludeTypeParameters";
            this.checkBox_IncludeTypeParameters.Size = new System.Drawing.Size(150, 17);
            this.checkBox_IncludeTypeParameters.TabIndex = 15;
            this.checkBox_IncludeTypeParameters.Text = "Include Type Parameters?";
            this.checkBox_IncludeTypeParameters.UseVisualStyleBackColor = true;
            this.checkBox_IncludeTypeParameters.CheckedChanged += new System.EventHandler(this.checkBox_IncludeTypeParameters_CheckedChanged);
            // 
            // checkBox_CreateViews
            // 
            this.checkBox_CreateViews.AutoSize = true;
            this.checkBox_CreateViews.Checked = true;
            this.checkBox_CreateViews.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_CreateViews.Location = new System.Drawing.Point(15, 180);
            this.checkBox_CreateViews.Name = "checkBox_CreateViews";
            this.checkBox_CreateViews.Size = new System.Drawing.Size(248, 17);
            this.checkBox_CreateViews.TabIndex = 16;
            this.checkBox_CreateViews.Text = "Create views from Cameras in the Revit model?";
            this.checkBox_CreateViews.UseVisualStyleBackColor = true;
            this.checkBox_CreateViews.CheckedChanged += new System.EventHandler(this.checkBox_CreateViews_CheckedChanged);
            // 
            // button_OK
            // 
            this.button_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_OK.Location = new System.Drawing.Point(15, 215);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(436, 48);
            this.button_OK.TabIndex = 17;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button_CANCEL
            // 
            this.button_CANCEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CANCEL.Location = new System.Drawing.Point(457, 215);
            this.button_CANCEL.Name = "button_CANCEL";
            this.button_CANCEL.Size = new System.Drawing.Size(140, 48);
            this.button_CANCEL.TabIndex = 18;
            this.button_CANCEL.Text = "Cancel";
            this.button_CANCEL.UseVisualStyleBackColor = true;
            this.button_CANCEL.Click += new System.EventHandler(this.button_CANCEL_Click);
            // 
            // ExportOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(614, 282);
            this.ControlBox = false;
            this.Controls.Add(this.button_CANCEL);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.checkBox_CreateViews);
            this.Controls.Add(this.checkBox_IncludeTypeParameters);
            this.Controls.Add(this.checkBox_FilterParameters);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Description);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(630, 320);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(630, 320);
            this.Name = "ExportOptions";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Spectacles Export Options";
            this.Load += new System.EventHandler(this.ExportOptions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.CheckBox checkBox_FilterParameters;
        private System.Windows.Forms.CheckBox checkBox_IncludeTypeParameters;
        private System.Windows.Forms.CheckBox checkBox_CreateViews;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_CANCEL;

    }
}