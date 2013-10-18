namespace ThreadedProgramming
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
            this.labelIncremental = new System.Windows.Forms.Label();
            this.buttonBlockUIThread = new System.Windows.Forms.Button();
            this.buttonNewThread = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelIncremental
            // 
            this.labelIncremental.AutoSize = true;
            this.labelIncremental.Location = new System.Drawing.Point(46, 54);
            this.labelIncremental.Name = "labelIncremental";
            this.labelIncremental.Size = new System.Drawing.Size(0, 13);
            this.labelIncremental.TabIndex = 0;
            // 
            // buttonBlockUIThread
            // 
            this.buttonBlockUIThread.Location = new System.Drawing.Point(75, 307);
            this.buttonBlockUIThread.Name = "buttonBlockUIThread";
            this.buttonBlockUIThread.Size = new System.Drawing.Size(114, 23);
            this.buttonBlockUIThread.TabIndex = 1;
            this.buttonBlockUIThread.Text = "Block UI Thread";
            this.buttonBlockUIThread.UseVisualStyleBackColor = true;
            this.buttonBlockUIThread.Click += new System.EventHandler(this.buttonBlockUIThread_Click);
            // 
            // buttonNewThread
            // 
            this.buttonNewThread.Location = new System.Drawing.Point(240, 306);
            this.buttonNewThread.Name = "buttonNewThread";
            this.buttonNewThread.Size = new System.Drawing.Size(75, 23);
            this.buttonNewThread.TabIndex = 2;
            this.buttonNewThread.Text = "New Thread";
            this.buttonNewThread.UseVisualStyleBackColor = true;
            this.buttonNewThread.Click += new System.EventHandler(this.buttonNewThread_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 363);
            this.Controls.Add(this.buttonNewThread);
            this.Controls.Add(this.buttonBlockUIThread);
            this.Controls.Add(this.labelIncremental);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIncremental;
        private System.Windows.Forms.Button buttonBlockUIThread;
        private System.Windows.Forms.Button buttonNewThread;
    }
}

