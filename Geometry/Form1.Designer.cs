namespace Geometry
{
    partial class GraphicObjects
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraphicObjects));
            this.picture = new System.Windows.Forms.PictureBox();
            this.buttonMoveMe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // Picture
            // 
            this.picture.BackColor = System.Drawing.Color.White;
            this.picture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picture.Location = new System.Drawing.Point(0, 0);
            this.picture.Name = "Picture";
            this.picture.Size = new System.Drawing.Size(1184, 811);
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            // 
            // buttonMoveMe
            // 
            this.buttonMoveMe.Location = new System.Drawing.Point(1037, 0);
            this.buttonMoveMe.Name = "buttonMoveMe";
            this.buttonMoveMe.Size = new System.Drawing.Size(48, 48);
            this.buttonMoveMe.TabIndex = 1;
            this.buttonMoveMe.Text = "move";
            this.buttonMoveMe.UseVisualStyleBackColor = true;
            this.buttonMoveMe.Click += new System.EventHandler(this.ButtonMoveMe_Click);
            // 
            // GraphicObjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 811);
            this.Controls.Add(this.buttonMoveMe);
            this.Controls.Add(this.picture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GraphicObjects";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Графические объекты";
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Button buttonMoveMe;
    }
}

