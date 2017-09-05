namespace WindowsFormsApp1
{
    partial class NLogForm
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
            this.traceButton = new System.Windows.Forms.Button();
            this.debugButton = new System.Windows.Forms.Button();
            this.infoButton = new System.Windows.Forms.Button();
            this.warnButton = new System.Windows.Forms.Button();
            this.errorButton = new System.Windows.Forms.Button();
            this.fatalButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // traceButton
            // 
            this.traceButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.traceButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.traceButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.traceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.traceButton.Location = new System.Drawing.Point(15, 16);
            this.traceButton.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.traceButton.Name = "traceButton";
            this.traceButton.Size = new System.Drawing.Size(429, 53);
            this.traceButton.TabIndex = 0;
            this.traceButton.Text = "Trace";
            this.traceButton.UseVisualStyleBackColor = true;
            this.traceButton.Click += new System.EventHandler(this.traceButton_Click);
            // 
            // debugButton
            // 
            this.debugButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.debugButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.debugButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.debugButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.debugButton.Location = new System.Drawing.Point(15, 83);
            this.debugButton.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.debugButton.Name = "debugButton";
            this.debugButton.Size = new System.Drawing.Size(429, 53);
            this.debugButton.TabIndex = 0;
            this.debugButton.Text = "Debug";
            this.debugButton.UseVisualStyleBackColor = true;
            this.debugButton.Click += new System.EventHandler(this.debugButton_Click);
            // 
            // infoButton
            // 
            this.infoButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.infoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.infoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.infoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infoButton.Location = new System.Drawing.Point(15, 150);
            this.infoButton.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(429, 53);
            this.infoButton.TabIndex = 0;
            this.infoButton.Text = "Info";
            this.infoButton.UseVisualStyleBackColor = true;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // warnButton
            // 
            this.warnButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.warnButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.warnButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.warnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.warnButton.Location = new System.Drawing.Point(15, 217);
            this.warnButton.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.warnButton.Name = "warnButton";
            this.warnButton.Size = new System.Drawing.Size(429, 53);
            this.warnButton.TabIndex = 0;
            this.warnButton.Text = "Warn";
            this.warnButton.UseVisualStyleBackColor = true;
            this.warnButton.Click += new System.EventHandler(this.warnButton_Click);
            // 
            // errorButton
            // 
            this.errorButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.errorButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.errorButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.errorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.errorButton.Location = new System.Drawing.Point(15, 284);
            this.errorButton.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.errorButton.Name = "errorButton";
            this.errorButton.Size = new System.Drawing.Size(429, 53);
            this.errorButton.TabIndex = 0;
            this.errorButton.Text = "Error";
            this.errorButton.UseVisualStyleBackColor = true;
            this.errorButton.Click += new System.EventHandler(this.errorButton_Click);
            // 
            // fatalButton
            // 
            this.fatalButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.fatalButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.fatalButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.fatalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fatalButton.Location = new System.Drawing.Point(15, 351);
            this.fatalButton.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.fatalButton.Name = "fatalButton";
            this.fatalButton.Size = new System.Drawing.Size(429, 53);
            this.fatalButton.TabIndex = 0;
            this.fatalButton.Text = "Fatal";
            this.fatalButton.UseVisualStyleBackColor = true;
            this.fatalButton.Click += new System.EventHandler(this.fatalButton_Click);
            // 
            // NLogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(459, 417);
            this.Controls.Add(this.fatalButton);
            this.Controls.Add(this.errorButton);
            this.Controls.Add(this.warnButton);
            this.Controls.Add(this.infoButton);
            this.Controls.Add(this.debugButton);
            this.Controls.Add(this.traceButton);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "NLogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NLog";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button traceButton;
        private System.Windows.Forms.Button debugButton;
        private System.Windows.Forms.Button infoButton;
        private System.Windows.Forms.Button warnButton;
        private System.Windows.Forms.Button errorButton;
        private System.Windows.Forms.Button fatalButton;
    }
}

