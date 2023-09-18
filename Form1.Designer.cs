namespace Module1BaiSo_TrinhHongNgoc
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
            this.bntClickMe_Click = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bntClickMe_Click
            // 
            this.bntClickMe_Click.BackColor = System.Drawing.Color.Red;
            this.bntClickMe_Click.Font = new System.Drawing.Font("Times New Roman", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntClickMe_Click.Location = new System.Drawing.Point(66, 73);
            this.bntClickMe_Click.Name = "bntClickMe_Click";
            this.bntClickMe_Click.Size = new System.Drawing.Size(537, 164);
            this.bntClickMe_Click.TabIndex = 0;
            this.bntClickMe_Click.Text = "Click Me";
            this.bntClickMe_Click.UseVisualStyleBackColor = false;
            this.bntClickMe_Click.Click += new System.EventHandler(this.bntClickMe_Click_Click);
            this.bntClickMe_Click.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bntClickMe_Click_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(692, 311);
            this.Controls.Add(this.bntClickMe_Click);
            this.Name = "Form1";
            this.Text = "Simple Event Example";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bntClickMe_Click;
    }
}

