namespace PicBedTest
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_gitAdd = new System.Windows.Forms.Label();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.btn_copy = new System.Windows.Forms.Button();
            this.btn_push = new System.Windows.Forms.Button();
            this.btn_saveImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(169, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(351, 26);
            this.textBox1.TabIndex = 0;
            // 
            // lbl_gitAdd
            // 
            this.lbl_gitAdd.AutoSize = true;
            this.lbl_gitAdd.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_gitAdd.Location = new System.Drawing.Point(66, 38);
            this.lbl_gitAdd.Name = "lbl_gitAdd";
            this.lbl_gitAdd.Size = new System.Drawing.Size(88, 20);
            this.lbl_gitAdd.TabIndex = 1;
            this.lbl_gitAdd.Text = "Git Address:";
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(70, 92);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(279, 206);
            this.picBox.TabIndex = 2;
            this.picBox.TabStop = false;
            // 
            // btn_copy
            // 
            this.btn_copy.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_copy.Location = new System.Drawing.Point(415, 247);
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.Size = new System.Drawing.Size(105, 30);
            this.btn_copy.TabIndex = 4;
            this.btn_copy.Text = "Copy Add";
            this.btn_copy.UseVisualStyleBackColor = true;
            // 
            // btn_push
            // 
            this.btn_push.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_push.Location = new System.Drawing.Point(415, 188);
            this.btn_push.Name = "btn_push";
            this.btn_push.Size = new System.Drawing.Size(105, 30);
            this.btn_push.TabIndex = 4;
            this.btn_push.Text = "Push";
            this.btn_push.UseVisualStyleBackColor = true;
            // 
            // btn_saveImage
            // 
            this.btn_saveImage.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_saveImage.Location = new System.Drawing.Point(415, 132);
            this.btn_saveImage.Name = "btn_saveImage";
            this.btn_saveImage.Size = new System.Drawing.Size(105, 30);
            this.btn_saveImage.TabIndex = 4;
            this.btn_saveImage.Text = "Save Pic";
            this.btn_saveImage.UseVisualStyleBackColor = true;
            this.btn_saveImage.Click += new System.EventHandler(this.btn_saveImage_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 388);
            this.Controls.Add(this.btn_saveImage);
            this.Controls.Add(this.btn_push);
            this.Controls.Add(this.btn_copy);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.lbl_gitAdd);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_gitAdd;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Button btn_copy;
        private System.Windows.Forms.Button btn_push;
        private System.Windows.Forms.Button btn_saveImage;
    }
}

