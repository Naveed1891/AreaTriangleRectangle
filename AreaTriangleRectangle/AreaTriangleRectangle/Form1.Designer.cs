
namespace AreaTriangleRectangle
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
            this.txtX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbRectangle = new System.Windows.Forms.RadioButton();
            this.rdbTriangle = new System.Windows.Forms.RadioButton();
            this.txtY = new System.Windows.Forms.TextBox();
            this.lblRecTri = new System.Windows.Forms.Label();
            this.lblRecTri1 = new System.Windows.Forms.Label();
            this.lblRecTri2 = new System.Windows.Forms.Label();
            this.txtz = new System.Windows.Forms.TextBox();
            this.btnCalRec = new System.Windows.Forms.Button();
            this.btnCalTri = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPeri = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(262, 116);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 20);
            this.txtX.TabIndex = 0;
            this.txtX.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(88, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select the Shape:";
            // 
            // rdbRectangle
            // 
            this.rdbRectangle.AutoSize = true;
            this.rdbRectangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbRectangle.Location = new System.Drawing.Point(139, 51);
            this.rdbRectangle.Name = "rdbRectangle";
            this.rdbRectangle.Size = new System.Drawing.Size(97, 20);
            this.rdbRectangle.TabIndex = 3;
            this.rdbRectangle.TabStop = true;
            this.rdbRectangle.Text = "Rectangle";
            this.rdbRectangle.UseVisualStyleBackColor = true;
            this.rdbRectangle.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdbTriangle
            // 
            this.rdbTriangle.AutoSize = true;
            this.rdbTriangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTriangle.Location = new System.Drawing.Point(321, 51);
            this.rdbTriangle.Name = "rdbTriangle";
            this.rdbTriangle.Size = new System.Drawing.Size(84, 20);
            this.rdbTriangle.TabIndex = 4;
            this.rdbTriangle.TabStop = true;
            this.rdbTriangle.Text = "Triangle";
            this.rdbTriangle.UseVisualStyleBackColor = true;
            this.rdbTriangle.CheckedChanged += new System.EventHandler(this.rdbTriangle_CheckedChanged);
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(262, 170);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(100, 20);
            this.txtY.TabIndex = 5;
            this.txtY.Visible = false;
            // 
            // lblRecTri
            // 
            this.lblRecTri.AutoSize = true;
            this.lblRecTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecTri.Location = new System.Drawing.Point(136, 117);
            this.lblRecTri.Name = "lblRecTri";
            this.lblRecTri.Size = new System.Drawing.Size(58, 15);
            this.lblRecTri.TabIndex = 6;
            this.lblRecTri.Text = "Enter  X";
            this.lblRecTri.Visible = false;
            // 
            // lblRecTri1
            // 
            this.lblRecTri1.AutoSize = true;
            this.lblRecTri1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecTri1.Location = new System.Drawing.Point(136, 170);
            this.lblRecTri1.Name = "lblRecTri1";
            this.lblRecTri1.Size = new System.Drawing.Size(57, 15);
            this.lblRecTri1.TabIndex = 7;
            this.lblRecTri1.Text = "Enter  Y";
            this.lblRecTri1.Visible = false;
            // 
            // lblRecTri2
            // 
            this.lblRecTri2.AutoSize = true;
            this.lblRecTri2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecTri2.Location = new System.Drawing.Point(136, 238);
            this.lblRecTri2.Name = "lblRecTri2";
            this.lblRecTri2.Size = new System.Drawing.Size(57, 15);
            this.lblRecTri2.TabIndex = 8;
            this.lblRecTri2.Text = "Enter  Z";
            this.lblRecTri2.Visible = false;
            // 
            // txtz
            // 
            this.txtz.Location = new System.Drawing.Point(262, 237);
            this.txtz.Name = "txtz";
            this.txtz.Size = new System.Drawing.Size(100, 20);
            this.txtz.TabIndex = 9;
            this.txtz.Visible = false;
            // 
            // btnCalRec
            // 
            this.btnCalRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalRec.Location = new System.Drawing.Point(218, 276);
            this.btnCalRec.Name = "btnCalRec";
            this.btnCalRec.Size = new System.Drawing.Size(89, 23);
            this.btnCalRec.TabIndex = 10;
            this.btnCalRec.Text = "Calculate";
            this.btnCalRec.UseVisualStyleBackColor = true;
            this.btnCalRec.Visible = false;
            this.btnCalRec.Click += new System.EventHandler(this.btnCalRec_Click);
            // 
            // btnCalTri
            // 
            this.btnCalTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalTri.Location = new System.Drawing.Point(313, 276);
            this.btnCalTri.Name = "btnCalTri";
            this.btnCalTri.Size = new System.Drawing.Size(89, 23);
            this.btnCalTri.TabIndex = 11;
            this.btnCalTri.Text = "Calculate";
            this.btnCalTri.UseVisualStyleBackColor = true;
            this.btnCalTri.Visible = false;
            this.btnCalTri.Click += new System.EventHandler(this.btnCalTri_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(484, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Answer: ";
            this.label2.Visible = false;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(518, 139);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(0, 15);
            this.lblArea.TabIndex = 13;
            this.lblArea.Visible = false;
            // 
            // lblPeri
            // 
            this.lblPeri.AutoSize = true;
            this.lblPeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeri.Location = new System.Drawing.Point(518, 171);
            this.lblPeri.Name = "lblPeri";
            this.lblPeri.Size = new System.Drawing.Size(0, 15);
            this.lblPeri.TabIndex = 14;
            this.lblPeri.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 561);
            this.Controls.Add(this.lblPeri);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCalTri);
            this.Controls.Add(this.btnCalRec);
            this.Controls.Add(this.txtz);
            this.Controls.Add(this.lblRecTri2);
            this.Controls.Add(this.lblRecTri1);
            this.Controls.Add(this.lblRecTri);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.rdbTriangle);
            this.Controls.Add(this.rdbRectangle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtX);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbRectangle;
        private System.Windows.Forms.RadioButton rdbTriangle;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Label lblRecTri;
        private System.Windows.Forms.Label lblRecTri1;
        private System.Windows.Forms.Label lblRecTri2;
        private System.Windows.Forms.TextBox txtz;
        private System.Windows.Forms.Button btnCalRec;
        private System.Windows.Forms.Button btnCalTri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPeri;
    }
}

