
namespace WindowsFormsApp24
{
    partial class Form5
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
            this.chkMeal = new System.Windows.Forms.CheckBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTCost = new System.Windows.Forms.TextBox();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.dtCIn = new System.Windows.Forms.DateTimePicker();
            this.nuPax = new System.Windows.Forms.NumericUpDown();
            this.nuNoR = new System.Windows.Forms.NumericUpDown();
            this.dtCOut = new System.Windows.Forms.DateTimePicker();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nuPax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuNoR)).BeginInit();
            this.SuspendLayout();
            // 
            // chkMeal
            // 
            this.chkMeal.AutoSize = true;
            this.chkMeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMeal.Location = new System.Drawing.Point(220, 455);
            this.chkMeal.Name = "chkMeal";
            this.chkMeal.Size = new System.Drawing.Size(86, 36);
            this.chkMeal.TabIndex = 25;
            this.chkMeal.Text = "Yes";
            this.chkMeal.UseVisualStyleBackColor = true;
            // 
            // cmbType
            // 
            this.cmbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Standard",
            "Luxury",
            "Deluxe"});
            this.cmbType.Location = new System.Drawing.Point(220, 193);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(270, 39);
            this.cmbType.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 32);
            this.label6.TabIndex = 21;
            this.label6.Text = "No of Rooms";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 32);
            this.label5.TabIndex = 19;
            this.label5.Text = "Room Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 32);
            this.label4.TabIndex = 18;
            this.label4.Text = "No of Pax";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 32);
            this.label3.TabIndex = 17;
            this.label3.Text = "Country";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 32);
            this.label1.TabIndex = 16;
            this.label1.Text = "Guest ID";
            // 
            // txtGID
            // 
            this.txtGID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGID.Location = new System.Drawing.Point(220, 21);
            this.txtGID.Name = "txtGID";
            this.txtGID.Size = new System.Drawing.Size(168, 38);
            this.txtGID.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 32);
            this.label2.TabIndex = 27;
            this.label2.Text = "Check In Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 455);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 32);
            this.label7.TabIndex = 29;
            this.label7.Text = "Meal Plan";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 384);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(215, 32);
            this.label8.TabIndex = 31;
            this.label8.Text = "Check Out Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(30, 544);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 32);
            this.label9.TabIndex = 33;
            this.label9.Text = "Tour Cost";
            // 
            // txtTCost
            // 
            this.txtTCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTCost.Location = new System.Drawing.Point(220, 541);
            this.txtTCost.Name = "txtTCost";
            this.txtTCost.ReadOnly = true;
            this.txtTCost.Size = new System.Drawing.Size(272, 38);
            this.txtTCost.TabIndex = 32;
            // 
            // cmbCountry
            // 
            this.cmbCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Items.AddRange(new object[] {
            "Sri Lanka",
            "India",
            "China",
            "Australia",
            "England",
            "Bangladesh",
            "Pakistan"});
            this.cmbCountry.Location = new System.Drawing.Point(220, 79);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(270, 39);
            this.cmbCountry.TabIndex = 34;
            // 
            // dtCIn
            // 
            this.dtCIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtCIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCIn.Location = new System.Drawing.Point(261, 317);
            this.dtCIn.Name = "dtCIn";
            this.dtCIn.Size = new System.Drawing.Size(272, 38);
            this.dtCIn.TabIndex = 36;
            // 
            // nuPax
            // 
            this.nuPax.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuPax.Location = new System.Drawing.Point(220, 137);
            this.nuPax.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nuPax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuPax.Name = "nuPax";
            this.nuPax.Size = new System.Drawing.Size(291, 38);
            this.nuPax.TabIndex = 35;
            this.nuPax.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nuNoR
            // 
            this.nuNoR.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuNoR.Location = new System.Drawing.Point(220, 256);
            this.nuNoR.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nuNoR.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuNoR.Name = "nuNoR";
            this.nuNoR.Size = new System.Drawing.Size(291, 38);
            this.nuNoR.TabIndex = 37;
            this.nuNoR.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dtCOut
            // 
            this.dtCOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtCOut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCOut.Location = new System.Drawing.Point(261, 378);
            this.dtCOut.Name = "dtCOut";
            this.dtCOut.Size = new System.Drawing.Size(272, 38);
            this.dtCOut.TabIndex = 38;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(36, 609);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(230, 47);
            this.btnCalculate.TabIndex = 39;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(294, 609);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(230, 47);
            this.btnClose.TabIndex = 40;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 680);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dtCOut);
            this.Controls.Add(this.nuNoR);
            this.Controls.Add(this.dtCIn);
            this.Controls.Add(this.nuPax);
            this.Controls.Add(this.cmbCountry);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTCost);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkMeal);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGID);
            this.Name = "Form5";
            this.Text = "Calculate Tour Cost";
            ((System.ComponentModel.ISupportInitialize)(this.nuPax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuNoR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkMeal;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTCost;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.DateTimePicker dtCIn;
        private System.Windows.Forms.NumericUpDown nuPax;
        private System.Windows.Forms.NumericUpDown nuNoR;
        private System.Windows.Forms.DateTimePicker dtCOut;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClose;
    }
}