
namespace Registre_Tools
{
    partial class Form6
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.label1 = new System.Windows.Forms.Label();
            this.ipTxt = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.sizeTxt = new System.Windows.Forms.TextBox();
            this.dataTxt = new System.Windows.Forms.Label();
            this.floodTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP :";
            // 
            // ipTxt
            // 
            this.ipTxt.Location = new System.Drawing.Point(58, 46);
            this.ipTxt.Name = "ipTxt";
            this.ipTxt.Size = new System.Drawing.Size(254, 23);
            this.ipTxt.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(32, 368);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 70);
            this.button2.TabIndex = 3;
            this.button2.Text = "Flood Start";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // sizeTxt
            // 
            this.sizeTxt.Location = new System.Drawing.Point(58, 88);
            this.sizeTxt.Multiline = true;
            this.sizeTxt.Name = "sizeTxt";
            this.sizeTxt.Size = new System.Drawing.Size(254, 21);
            this.sizeTxt.TabIndex = 4;
            // 
            // dataTxt
            // 
            this.dataTxt.AutoSize = true;
            this.dataTxt.BackColor = System.Drawing.Color.Transparent;
            this.dataTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataTxt.Location = new System.Drawing.Point(3, 88);
            this.dataTxt.Name = "dataTxt";
            this.dataTxt.Size = new System.Drawing.Size(36, 21);
            this.dataTxt.TabIndex = 5;
            this.dataTxt.Text = "size";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataTxt);
            this.Controls.Add(this.sizeTxt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ipTxt);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form6";
            this.Text = "IP-FLOODER";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ipTxt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox sizeTxt;
        private System.Windows.Forms.Label dataTxt;
        private System.Windows.Forms.Timer floodTimer;
    }
}