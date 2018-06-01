namespace newsCreator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.selectPath = new System.Windows.Forms.Button();
            this.textPath = new System.Windows.Forms.TextBox();
            this.startClicked = new System.Windows.Forms.Button();
            this.stopClicked = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // selectPath
            // 
            this.selectPath.Location = new System.Drawing.Point(42, 94);
            this.selectPath.Name = "selectPath";
            this.selectPath.Size = new System.Drawing.Size(99, 32);
            this.selectPath.TabIndex = 1;
            this.selectPath.Text = "Select Path";
            this.selectPath.UseVisualStyleBackColor = true;
            this.selectPath.Click += new System.EventHandler(this.selectPath_Click);
            // 
            // textPath
            // 
            this.textPath.Location = new System.Drawing.Point(161, 99);
            this.textPath.Name = "textPath";
            this.textPath.Size = new System.Drawing.Size(482, 22);
            this.textPath.TabIndex = 17;
            // 
            // startClicked
            // 
            this.startClicked.Location = new System.Drawing.Point(42, 150);
            this.startClicked.Name = "startClicked";
            this.startClicked.Size = new System.Drawing.Size(99, 32);
            this.startClicked.TabIndex = 3;
            this.startClicked.Text = "Start";
            this.startClicked.UseVisualStyleBackColor = true;
            this.startClicked.Click += new System.EventHandler(this.startClicked_Click);
            // 
            // stopClicked
            // 
            this.stopClicked.Location = new System.Drawing.Point(42, 203);
            this.stopClicked.Name = "stopClicked";
            this.stopClicked.Size = new System.Drawing.Size(99, 32);
            this.stopClicked.TabIndex = 4;
            this.stopClicked.Text = "Stop";
            this.stopClicked.UseVisualStyleBackColor = true;
            this.stopClicked.Click += new System.EventHandler(this.stopClicked_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 19;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 373);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.stopClicked);
            this.Controls.Add(this.startClicked);
            this.Controls.Add(this.textPath);
            this.Controls.Add(this.selectPath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "newsCreator 0.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button selectPath;
        private System.Windows.Forms.TextBox textPath;
        private System.Windows.Forms.Button startClicked;
        private System.Windows.Forms.Button stopClicked;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

