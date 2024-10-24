
namespace TypeStuff
{
    partial class Form1
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.textBoxDisplay = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox.Font = new System.Drawing.Font("Courier New", 18F);
            this.textBox.Location = new System.Drawing.Point(48, 446);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(569, 38);
            this.textBox.TabIndex = 0;
            this.textBox.Tag = "";
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBoxDisplay
            // 
            this.textBoxDisplay.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDisplay.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDisplay.Location = new System.Drawing.Point(48, 61);
            this.textBoxDisplay.Name = "textBoxDisplay";
            this.textBoxDisplay.Size = new System.Drawing.Size(569, 360);
            this.textBoxDisplay.TabIndex = 1;
            this.textBoxDisplay.Text = "";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(664, 550);
            this.Controls.Add(this.textBoxDisplay);
            this.Controls.Add(this.textBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.RichTextBox textBoxDisplay;
    }
}

