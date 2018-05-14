namespace Solicitudes
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabStep1 = new System.Windows.Forms.TabPage();
            this.tabStep2 = new System.Windows.Forms.TabPage();
            this.tabStep3 = new System.Windows.Forms.TabPage();
            this.grdStep1 = new System.Windows.Forms.DataGridView();
            this.grdStep2 = new System.Windows.Forms.DataGridView();
            this.boxData = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabStep1.SuspendLayout();
            this.tabStep2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdStep1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdStep2)).BeginInit();
            this.boxData.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabStep1);
            this.tabControl1.Controls.Add(this.tabStep2);
            this.tabControl1.Controls.Add(this.tabStep3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabStep1
            // 
            this.tabStep1.Controls.Add(this.boxData);
            this.tabStep1.Controls.Add(this.grdStep1);
            this.tabStep1.Location = new System.Drawing.Point(4, 22);
            this.tabStep1.Name = "tabStep1";
            this.tabStep1.Padding = new System.Windows.Forms.Padding(3);
            this.tabStep1.Size = new System.Drawing.Size(792, 424);
            this.tabStep1.TabIndex = 0;
            this.tabStep1.Text = "Etapa 1";
            this.tabStep1.UseVisualStyleBackColor = true;
            // 
            // tabStep2
            // 
            this.tabStep2.Controls.Add(this.groupBox1);
            this.tabStep2.Controls.Add(this.grdStep2);
            this.tabStep2.Location = new System.Drawing.Point(4, 22);
            this.tabStep2.Name = "tabStep2";
            this.tabStep2.Padding = new System.Windows.Forms.Padding(3);
            this.tabStep2.Size = new System.Drawing.Size(792, 424);
            this.tabStep2.TabIndex = 1;
            this.tabStep2.Text = "Etapa 2";
            this.tabStep2.UseVisualStyleBackColor = true;
            // 
            // tabStep3
            // 
            this.tabStep3.Location = new System.Drawing.Point(4, 22);
            this.tabStep3.Name = "tabStep3";
            this.tabStep3.Size = new System.Drawing.Size(792, 424);
            this.tabStep3.TabIndex = 2;
            this.tabStep3.Text = "Etapa 3";
            this.tabStep3.UseVisualStyleBackColor = true;
            // 
            // grdStep1
            // 
            this.grdStep1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdStep1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdStep1.Location = new System.Drawing.Point(3, 140);
            this.grdStep1.Name = "grdStep1";
            this.grdStep1.Size = new System.Drawing.Size(786, 281);
            this.grdStep1.TabIndex = 0;
            // 
            // grdStep2
            // 
            this.grdStep2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdStep2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdStep2.Location = new System.Drawing.Point(3, 140);
            this.grdStep2.Name = "grdStep2";
            this.grdStep2.Size = new System.Drawing.Size(786, 281);
            this.grdStep2.TabIndex = 0;
            // 
            // boxData
            // 
            this.boxData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boxData.Controls.Add(this.button1);
            this.boxData.Location = new System.Drawing.Point(3, 6);
            this.boxData.Name = "boxData";
            this.boxData.Size = new System.Drawing.Size(786, 128);
            this.boxData.TabIndex = 1;
            this.boxData.TabStop = false;
            this.boxData.Text = "groupBox1";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(705, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(786, 128);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(705, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabStep1.ResumeLayout(false);
            this.tabStep2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdStep1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdStep2)).EndInit();
            this.boxData.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabStep1;
        private System.Windows.Forms.TabPage tabStep2;
        private System.Windows.Forms.DataGridView grdStep1;
        private System.Windows.Forms.DataGridView grdStep2;
        private System.Windows.Forms.TabPage tabStep3;
        private System.Windows.Forms.GroupBox boxData;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
    }
}

