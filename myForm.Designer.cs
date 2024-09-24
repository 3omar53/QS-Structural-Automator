namespace ClassLibrary3
{
    partial class myForm
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
            this.btnCalculateAreaColumn = new System.Windows.Forms.Button();
            this.txtLayerColumnName = new System.Windows.Forms.TextBox();
            this.lblTotalArea = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxColumnVolume = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxColumnHeight = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxPCFootingVolume = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPCFootingHeight = new System.Windows.Forms.TextBox();
            this.txtLayerPCFootingName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalculateAreaPCFooting = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxRCFootingVolume = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxRCFootingHeight = new System.Windows.Forms.TextBox();
            this.txtLayerRCFootingName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCalculateAreaRCFooting = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxBeamVolume = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxBeamHeight = new System.Windows.Forms.TextBox();
            this.txtLayerBeamName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCalculateAreaBeam = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxSlabVolume = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxSlabHeight = new System.Windows.Forms.TextBox();
            this.txtLayerSlabName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCalculateAreaSlab = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalculateAreaColumn
            // 
            this.btnCalculateAreaColumn.Location = new System.Drawing.Point(312, 18);
            this.btnCalculateAreaColumn.Name = "btnCalculateAreaColumn";
            this.btnCalculateAreaColumn.Size = new System.Drawing.Size(145, 20);
            this.btnCalculateAreaColumn.TabIndex = 0;
            this.btnCalculateAreaColumn.Text = "Caculate Volume";
            this.btnCalculateAreaColumn.UseVisualStyleBackColor = true;
            this.btnCalculateAreaColumn.Click += new System.EventHandler(this.btnCalculateAreaColumn_Click);
            // 
            // txtLayerColumnName
            // 
            this.txtLayerColumnName.Location = new System.Drawing.Point(88, 19);
            this.txtLayerColumnName.Name = "txtLayerColumnName";
            this.txtLayerColumnName.Size = new System.Drawing.Size(100, 20);
            this.txtLayerColumnName.TabIndex = 1;
            // 
            // lblTotalArea
            // 
            this.lblTotalArea.AutoSize = true;
            this.lblTotalArea.Location = new System.Drawing.Point(6, 26);
            this.lblTotalArea.Name = "lblTotalArea";
            this.lblTotalArea.Size = new System.Drawing.Size(64, 13);
            this.lblTotalArea.TabIndex = 2;
            this.lblTotalArea.Text = "Layer Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.textBoxColumnVolume);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxColumnHeight);
            this.groupBox1.Controls.Add(this.txtLayerColumnName);
            this.groupBox1.Controls.Add(this.lblTotalArea);
            this.groupBox1.Controls.Add(this.btnCalculateAreaColumn);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(744, 78);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Columns";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(281, 51);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "Volume";
            // 
            // textBoxColumnVolume
            // 
            this.textBoxColumnVolume.Location = new System.Drawing.Point(329, 48);
            this.textBoxColumnVolume.Name = "textBoxColumnVolume";
            this.textBoxColumnVolume.Size = new System.Drawing.Size(100, 20);
            this.textBoxColumnVolume.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "height";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxColumnHeight
            // 
            this.textBoxColumnHeight.Location = new System.Drawing.Point(88, 52);
            this.textBoxColumnHeight.Name = "textBoxColumnHeight";
            this.textBoxColumnHeight.Size = new System.Drawing.Size(100, 20);
            this.textBoxColumnHeight.TabIndex = 3;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.textBoxPCFootingVolume);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.textBoxPCFootingHeight);
            this.groupBox6.Controls.Add(this.txtLayerPCFootingName);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.btnCalculateAreaPCFooting);
            this.groupBox6.Location = new System.Drawing.Point(12, 109);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(744, 78);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "PC Footings";
            this.groupBox6.Enter += new System.EventHandler(this.groupBox6_Enter);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(281, 51);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Volume";
            // 
            // textBoxPCFootingVolume
            // 
            this.textBoxPCFootingVolume.Location = new System.Drawing.Point(329, 48);
            this.textBoxPCFootingVolume.Name = "textBoxPCFootingVolume";
            this.textBoxPCFootingVolume.Size = new System.Drawing.Size(100, 20);
            this.textBoxPCFootingVolume.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "height";
            // 
            // textBoxPCFootingHeight
            // 
            this.textBoxPCFootingHeight.Location = new System.Drawing.Point(88, 52);
            this.textBoxPCFootingHeight.Name = "textBoxPCFootingHeight";
            this.textBoxPCFootingHeight.Size = new System.Drawing.Size(100, 20);
            this.textBoxPCFootingHeight.TabIndex = 3;
            // 
            // txtLayerPCFootingName
            // 
            this.txtLayerPCFootingName.Location = new System.Drawing.Point(88, 19);
            this.txtLayerPCFootingName.Name = "txtLayerPCFootingName";
            this.txtLayerPCFootingName.Size = new System.Drawing.Size(100, 20);
            this.txtLayerPCFootingName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Layer Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnCalculateAreaPCFooting
            // 
            this.btnCalculateAreaPCFooting.Location = new System.Drawing.Point(312, 22);
            this.btnCalculateAreaPCFooting.Name = "btnCalculateAreaPCFooting";
            this.btnCalculateAreaPCFooting.Size = new System.Drawing.Size(145, 20);
            this.btnCalculateAreaPCFooting.TabIndex = 0;
            this.btnCalculateAreaPCFooting.Text = "Caculate Volume";
            this.btnCalculateAreaPCFooting.UseVisualStyleBackColor = true;
            this.btnCalculateAreaPCFooting.Click += new System.EventHandler(this.btnCalculateAreaPCfooting_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label12);
            this.groupBox7.Controls.Add(this.textBoxRCFootingVolume);
            this.groupBox7.Controls.Add(this.label4);
            this.groupBox7.Controls.Add(this.textBoxRCFootingHeight);
            this.groupBox7.Controls.Add(this.txtLayerRCFootingName);
            this.groupBox7.Controls.Add(this.label5);
            this.groupBox7.Controls.Add(this.btnCalculateAreaRCFooting);
            this.groupBox7.Location = new System.Drawing.Point(12, 192);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(744, 78);
            this.groupBox7.TabIndex = 5;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "RC Footings";
            this.groupBox7.Enter += new System.EventHandler(this.groupBox7_Enter);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(281, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Volume";
            // 
            // textBoxRCFootingVolume
            // 
            this.textBoxRCFootingVolume.Location = new System.Drawing.Point(329, 48);
            this.textBoxRCFootingVolume.Name = "textBoxRCFootingVolume";
            this.textBoxRCFootingVolume.Size = new System.Drawing.Size(100, 20);
            this.textBoxRCFootingVolume.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "height";
            // 
            // textBoxRCFootingHeight
            // 
            this.textBoxRCFootingHeight.Location = new System.Drawing.Point(88, 52);
            this.textBoxRCFootingHeight.Name = "textBoxRCFootingHeight";
            this.textBoxRCFootingHeight.Size = new System.Drawing.Size(100, 20);
            this.textBoxRCFootingHeight.TabIndex = 3;
            // 
            // txtLayerRCFootingName
            // 
            this.txtLayerRCFootingName.Location = new System.Drawing.Point(88, 19);
            this.txtLayerRCFootingName.Name = "txtLayerRCFootingName";
            this.txtLayerRCFootingName.Size = new System.Drawing.Size(100, 20);
            this.txtLayerRCFootingName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Layer Name";
            // 
            // btnCalculateAreaRCFooting
            // 
            this.btnCalculateAreaRCFooting.Location = new System.Drawing.Point(312, 18);
            this.btnCalculateAreaRCFooting.Name = "btnCalculateAreaRCFooting";
            this.btnCalculateAreaRCFooting.Size = new System.Drawing.Size(145, 20);
            this.btnCalculateAreaRCFooting.TabIndex = 0;
            this.btnCalculateAreaRCFooting.Text = "Caculate Volume";
            this.btnCalculateAreaRCFooting.UseVisualStyleBackColor = true;
            this.btnCalculateAreaRCFooting.Click += new System.EventHandler(this.btnCalculateAreaRCfooting_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label11);
            this.groupBox8.Controls.Add(this.textBoxBeamVolume);
            this.groupBox8.Controls.Add(this.label6);
            this.groupBox8.Controls.Add(this.textBoxBeamHeight);
            this.groupBox8.Controls.Add(this.txtLayerBeamName);
            this.groupBox8.Controls.Add(this.label7);
            this.groupBox8.Controls.Add(this.btnCalculateAreaBeam);
            this.groupBox8.Location = new System.Drawing.Point(12, 276);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(744, 78);
            this.groupBox8.TabIndex = 5;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Beams";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(281, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Volume";
            // 
            // textBoxBeamVolume
            // 
            this.textBoxBeamVolume.Location = new System.Drawing.Point(329, 52);
            this.textBoxBeamVolume.Name = "textBoxBeamVolume";
            this.textBoxBeamVolume.Size = new System.Drawing.Size(100, 20);
            this.textBoxBeamVolume.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "height";
            // 
            // textBoxBeamHeight
            // 
            this.textBoxBeamHeight.Location = new System.Drawing.Point(88, 52);
            this.textBoxBeamHeight.Name = "textBoxBeamHeight";
            this.textBoxBeamHeight.Size = new System.Drawing.Size(100, 20);
            this.textBoxBeamHeight.TabIndex = 3;
            // 
            // txtLayerBeamName
            // 
            this.txtLayerBeamName.Location = new System.Drawing.Point(88, 19);
            this.txtLayerBeamName.Name = "txtLayerBeamName";
            this.txtLayerBeamName.Size = new System.Drawing.Size(100, 20);
            this.txtLayerBeamName.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Layer Name";
            // 
            // btnCalculateAreaBeam
            // 
            this.btnCalculateAreaBeam.Location = new System.Drawing.Point(312, 18);
            this.btnCalculateAreaBeam.Name = "btnCalculateAreaBeam";
            this.btnCalculateAreaBeam.Size = new System.Drawing.Size(145, 20);
            this.btnCalculateAreaBeam.TabIndex = 0;
            this.btnCalculateAreaBeam.Text = "Caculate Volume";
            this.btnCalculateAreaBeam.UseVisualStyleBackColor = true;
            this.btnCalculateAreaBeam.Click += new System.EventHandler(this.btnCalculateAreaBeam_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.label10);
            this.groupBox9.Controls.Add(this.textBoxSlabVolume);
            this.groupBox9.Controls.Add(this.label8);
            this.groupBox9.Controls.Add(this.textBoxSlabHeight);
            this.groupBox9.Controls.Add(this.txtLayerSlabName);
            this.groupBox9.Controls.Add(this.label9);
            this.groupBox9.Controls.Add(this.btnCalculateAreaSlab);
            this.groupBox9.Location = new System.Drawing.Point(12, 360);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(744, 78);
            this.groupBox9.TabIndex = 5;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Slabs";
            this.groupBox9.Enter += new System.EventHandler(this.groupBox9_Enter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(281, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Volume";
            // 
            // textBoxSlabVolume
            // 
            this.textBoxSlabVolume.Location = new System.Drawing.Point(329, 48);
            this.textBoxSlabVolume.Name = "textBoxSlabVolume";
            this.textBoxSlabVolume.Size = new System.Drawing.Size(100, 20);
            this.textBoxSlabVolume.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "height";
            // 
            // textBoxSlabHeight
            // 
            this.textBoxSlabHeight.Location = new System.Drawing.Point(88, 52);
            this.textBoxSlabHeight.Name = "textBoxSlabHeight";
            this.textBoxSlabHeight.Size = new System.Drawing.Size(100, 20);
            this.textBoxSlabHeight.TabIndex = 3;
            // 
            // txtLayerSlabName
            // 
            this.txtLayerSlabName.Location = new System.Drawing.Point(88, 19);
            this.txtLayerSlabName.Name = "txtLayerSlabName";
            this.txtLayerSlabName.Size = new System.Drawing.Size(100, 20);
            this.txtLayerSlabName.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Layer Name";
            // 
            // btnCalculateAreaSlab
            // 
            this.btnCalculateAreaSlab.Location = new System.Drawing.Point(312, 18);
            this.btnCalculateAreaSlab.Name = "btnCalculateAreaSlab";
            this.btnCalculateAreaSlab.Size = new System.Drawing.Size(145, 20);
            this.btnCalculateAreaSlab.TabIndex = 0;
            this.btnCalculateAreaSlab.Text = "Caculate Volume";
            this.btnCalculateAreaSlab.UseVisualStyleBackColor = true;
            this.btnCalculateAreaSlab.Click += new System.EventHandler(this.btnCalculateAreaSlab_Click);
            // 
            // myForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox1);
            this.Name = "myForm";
            this.RightToLeftLayout = true;
            this.Text = "Structural QS Automator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalculateAreaColumn;
        private System.Windows.Forms.TextBox txtLayerColumnName;
        private System.Windows.Forms.Label lblTotalArea;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxColumnHeight;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxBeamHeight;
        private System.Windows.Forms.TextBox txtLayerBeamName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCalculateAreaBeam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxRCFootingHeight;
        private System.Windows.Forms.TextBox txtLayerRCFootingName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCalculateAreaRCFooting;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPCFootingHeight;
        private System.Windows.Forms.TextBox txtLayerPCFootingName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalculateAreaPCFooting;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxSlabHeight;
        private System.Windows.Forms.TextBox txtLayerSlabName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCalculateAreaSlab;
        private System.Windows.Forms.TextBox textBoxColumnVolume;
        private System.Windows.Forms.TextBox textBoxPCFootingVolume;
        private System.Windows.Forms.TextBox textBoxRCFootingVolume;
        private System.Windows.Forms.TextBox textBoxBeamVolume;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxSlabVolume;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
    }
}