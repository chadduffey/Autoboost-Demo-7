namespace Autoboost7
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Holding = new System.Windows.Forms.GroupBox();
            this.labellock1 = new System.Windows.Forms.Label();
            this.labelPri1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labellock2 = new System.Windows.Forms.Label();
            this.labelpri2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.labelpri3 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelaquireA = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.Holding.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Holding);
            this.groupBox1.Controls.Add(this.labelPri1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 275);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thread 1";
            // 
            // Holding
            // 
            this.Holding.Controls.Add(this.labellock1);
            this.Holding.Location = new System.Drawing.Point(12, 152);
            this.Holding.Name = "Holding";
            this.Holding.Size = new System.Drawing.Size(177, 80);
            this.Holding.TabIndex = 3;
            this.Holding.TabStop = false;
            this.Holding.Text = "Locks:";
            // 
            // labellock1
            // 
            this.labellock1.BackColor = System.Drawing.Color.Yellow;
            this.labellock1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labellock1.Location = new System.Drawing.Point(46, 27);
            this.labellock1.Name = "labellock1";
            this.labellock1.Size = new System.Drawing.Size(84, 41);
            this.labellock1.TabIndex = 2;
            this.labellock1.Text = "LOCK A";
            this.labellock1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPri1
            // 
            this.labelPri1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPri1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPri1.Location = new System.Drawing.Point(12, 77);
            this.labelPri1.Name = "labelPri1";
            this.labelPri1.Size = new System.Drawing.Size(177, 41);
            this.labelPri1.TabIndex = 1;
            this.labelPri1.Text = "priority 6";
            this.labelPri1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "ready";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.labelpri2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(242, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(199, 275);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thread 2";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.labelaquireA);
            this.groupBox4.Controls.Add(this.labellock2);
            this.groupBox4.Location = new System.Drawing.Point(6, 152);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(187, 80);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Locks:";
            // 
            // labellock2
            // 
            this.labellock2.BackColor = System.Drawing.Color.Yellow;
            this.labellock2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labellock2.Location = new System.Drawing.Point(50, 27);
            this.labellock2.Name = "labellock2";
            this.labellock2.Size = new System.Drawing.Size(87, 41);
            this.labellock2.TabIndex = 3;
            this.labellock2.Text = "LOCK A";
            this.labellock2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelpri2
            // 
            this.labelpri2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelpri2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpri2.Location = new System.Drawing.Point(6, 77);
            this.labelpri2.Name = "labelpri2";
            this.labelpri2.Size = new System.Drawing.Size(187, 41);
            this.labelpri2.TabIndex = 2;
            this.labelpri2.Text = "priority 6";
            this.labelpri2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "ready";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.labelpri3);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(447, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(199, 275);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thread 3";
            // 
            // groupBox5
            // 
            this.groupBox5.Location = new System.Drawing.Point(6, 152);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(187, 80);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Locks:";
            // 
            // labelpri3
            // 
            this.labelpri3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelpri3.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpri3.Location = new System.Drawing.Point(6, 77);
            this.labelpri3.Name = "labelpri3";
            this.labelpri3.Size = new System.Drawing.Size(187, 41);
            this.labelpri3.TabIndex = 2;
            this.labelpri3.Text = "priority 6";
            this.labelpri3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 41);
            this.label3.TabIndex = 1;
            this.label3.Text = "ready";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(658, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 47);
            this.button1.TabIndex = 3;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(658, 280);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelaquireA
            // 
            this.labelaquireA.AutoSize = true;
            this.labelaquireA.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelaquireA.ForeColor = System.Drawing.Color.Purple;
            this.labelaquireA.Location = new System.Drawing.Point(10, 37);
            this.labelaquireA.Name = "labelaquireA";
            this.labelaquireA.Size = new System.Drawing.Size(171, 19);
            this.labelaquireA.TabIndex = 4;
            this.labelaquireA.Text = "Aquiring Lock A...";
            this.labelaquireA.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 331);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Autoboost Example";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.Holding.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelPri1;
        private System.Windows.Forms.Label labelpri2;
        private System.Windows.Forms.Label labelpri3;
        private System.Windows.Forms.GroupBox Holding;
        private System.Windows.Forms.Label labellock1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label labellock2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label labelaquireA;
    }
}

