namespace ConverterApp
{
    partial class frm_Main
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
            this.lbl_UofM = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.lbl_CM_TO_I = new System.Windows.Forms.Label();
            this.lbl_M_TO_FEET = new System.Windows.Forms.Label();
            this.lbl_CEL_TO_FAH = new System.Windows.Forms.Label();
            this.lbl_CM_TO_FEET = new System.Windows.Forms.Label();
            this.lbl_KM_TO_MILES = new System.Windows.Forms.Label();
            this.btn_ConvertAll = new System.Windows.Forms.Button();
            this.lb_Convert = new System.Windows.Forms.ListBox();
            this.tb_CM_to_Inches = new System.Windows.Forms.TextBox();
            this.tb_M_to_Feet = new System.Windows.Forms.TextBox();
            this.tb_Cel_to_Fah = new System.Windows.Forms.TextBox();
            this.tb_CM_to_Feet = new System.Windows.Forms.TextBox();
            this.tb_KM_to_Miles = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_UofM
            // 
            this.lbl_UofM.AutoSize = true;
            this.lbl_UofM.Location = new System.Drawing.Point(6, 9);
            this.lbl_UofM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_UofM.Name = "lbl_UofM";
            this.lbl_UofM.Size = new System.Drawing.Size(90, 13);
            this.lbl_UofM.TabIndex = 0;
            this.lbl_UofM.Text = "Units of Measure:";
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(322, 236);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(56, 24);
            this.btn_Exit.TabIndex = 4;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // lbl_CM_TO_I
            // 
            this.lbl_CM_TO_I.AutoSize = true;
            this.lbl_CM_TO_I.Location = new System.Drawing.Point(6, 33);
            this.lbl_CM_TO_I.Name = "lbl_CM_TO_I";
            this.lbl_CM_TO_I.Size = new System.Drawing.Size(109, 13);
            this.lbl_CM_TO_I.TabIndex = 11;
            this.lbl_CM_TO_I.Text = "Centimetres to Inches";
            // 
            // lbl_M_TO_FEET
            // 
            this.lbl_M_TO_FEET.AutoSize = true;
            this.lbl_M_TO_FEET.Location = new System.Drawing.Point(6, 55);
            this.lbl_M_TO_FEET.Name = "lbl_M_TO_FEET";
            this.lbl_M_TO_FEET.Size = new System.Drawing.Size(75, 13);
            this.lbl_M_TO_FEET.TabIndex = 12;
            this.lbl_M_TO_FEET.Text = "Metres to Feet";
            // 
            // lbl_CEL_TO_FAH
            // 
            this.lbl_CEL_TO_FAH.AutoSize = true;
            this.lbl_CEL_TO_FAH.Location = new System.Drawing.Point(6, 79);
            this.lbl_CEL_TO_FAH.Name = "lbl_CEL_TO_FAH";
            this.lbl_CEL_TO_FAH.Size = new System.Drawing.Size(106, 13);
            this.lbl_CEL_TO_FAH.TabIndex = 13;
            this.lbl_CEL_TO_FAH.Text = "Celcius to Fahrenheit";
            // 
            // lbl_CM_TO_FEET
            // 
            this.lbl_CM_TO_FEET.AutoSize = true;
            this.lbl_CM_TO_FEET.Location = new System.Drawing.Point(6, 103);
            this.lbl_CM_TO_FEET.Name = "lbl_CM_TO_FEET";
            this.lbl_CM_TO_FEET.Size = new System.Drawing.Size(98, 13);
            this.lbl_CM_TO_FEET.TabIndex = 14;
            this.lbl_CM_TO_FEET.Text = "Centimetres to Feet";
            // 
            // lbl_KM_TO_MILES
            // 
            this.lbl_KM_TO_MILES.AutoSize = true;
            this.lbl_KM_TO_MILES.Location = new System.Drawing.Point(6, 127);
            this.lbl_KM_TO_MILES.Name = "lbl_KM_TO_MILES";
            this.lbl_KM_TO_MILES.Size = new System.Drawing.Size(94, 13);
            this.lbl_KM_TO_MILES.TabIndex = 15;
            this.lbl_KM_TO_MILES.Text = "Kilometres to Miles";
            // 
            // btn_ConvertAll
            // 
            this.btn_ConvertAll.Location = new System.Drawing.Point(153, 237);
            this.btn_ConvertAll.Name = "btn_ConvertAll";
            this.btn_ConvertAll.Size = new System.Drawing.Size(75, 23);
            this.btn_ConvertAll.TabIndex = 21;
            this.btn_ConvertAll.Text = "Convert All";
            this.btn_ConvertAll.UseVisualStyleBackColor = true;
            this.btn_ConvertAll.Click += new System.EventHandler(this.btn_ConvertAll_Click);
            // 
            // lb_Convert
            // 
            this.lb_Convert.FormattingEnabled = true;
            this.lb_Convert.Location = new System.Drawing.Point(9, 149);
            this.lb_Convert.Name = "lb_Convert";
            this.lb_Convert.Size = new System.Drawing.Size(369, 82);
            this.lb_Convert.TabIndex = 22;
            // 
            // tb_CM_to_Inches
            // 
            this.tb_CM_to_Inches.Location = new System.Drawing.Point(120, 30);
            this.tb_CM_to_Inches.Margin = new System.Windows.Forms.Padding(2);
            this.tb_CM_to_Inches.Name = "tb_CM_to_Inches";
            this.tb_CM_to_Inches.Size = new System.Drawing.Size(207, 20);
            this.tb_CM_to_Inches.TabIndex = 23;
            // 
            // tb_M_to_Feet
            // 
            this.tb_M_to_Feet.Location = new System.Drawing.Point(120, 52);
            this.tb_M_to_Feet.Margin = new System.Windows.Forms.Padding(2);
            this.tb_M_to_Feet.Name = "tb_M_to_Feet";
            this.tb_M_to_Feet.Size = new System.Drawing.Size(207, 20);
            this.tb_M_to_Feet.TabIndex = 24;
            // 
            // tb_Cel_to_Fah
            // 
            this.tb_Cel_to_Fah.Location = new System.Drawing.Point(120, 76);
            this.tb_Cel_to_Fah.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Cel_to_Fah.Name = "tb_Cel_to_Fah";
            this.tb_Cel_to_Fah.Size = new System.Drawing.Size(207, 20);
            this.tb_Cel_to_Fah.TabIndex = 25;
            // 
            // tb_CM_to_Feet
            // 
            this.tb_CM_to_Feet.Location = new System.Drawing.Point(120, 100);
            this.tb_CM_to_Feet.Margin = new System.Windows.Forms.Padding(2);
            this.tb_CM_to_Feet.Name = "tb_CM_to_Feet";
            this.tb_CM_to_Feet.Size = new System.Drawing.Size(207, 20);
            this.tb_CM_to_Feet.TabIndex = 26;
            // 
            // tb_KM_to_Miles
            // 
            this.tb_KM_to_Miles.Location = new System.Drawing.Point(120, 124);
            this.tb_KM_to_Miles.Margin = new System.Windows.Forms.Padding(2);
            this.tb_KM_to_Miles.Name = "tb_KM_to_Miles";
            this.tb_KM_to_Miles.Size = new System.Drawing.Size(207, 20);
            this.tb_KM_to_Miles.TabIndex = 27;
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 264);
            this.Controls.Add(this.tb_KM_to_Miles);
            this.Controls.Add(this.tb_CM_to_Feet);
            this.Controls.Add(this.tb_Cel_to_Fah);
            this.Controls.Add(this.tb_M_to_Feet);
            this.Controls.Add(this.tb_CM_to_Inches);
            this.Controls.Add(this.lb_Convert);
            this.Controls.Add(this.btn_ConvertAll);
            this.Controls.Add(this.lbl_KM_TO_MILES);
            this.Controls.Add(this.lbl_CM_TO_FEET);
            this.Controls.Add(this.lbl_CEL_TO_FAH);
            this.Controls.Add(this.lbl_M_TO_FEET);
            this.Controls.Add(this.lbl_CM_TO_I);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.lbl_UofM);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_Main";
            this.Text = "ATCA Gas Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_UofM;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label lbl_CM_TO_I;
        private System.Windows.Forms.Label lbl_M_TO_FEET;
        private System.Windows.Forms.Label lbl_CEL_TO_FAH;
        private System.Windows.Forms.Label lbl_CM_TO_FEET;
        private System.Windows.Forms.Label lbl_KM_TO_MILES;
        private System.Windows.Forms.Button btn_ConvertAll;
        private System.Windows.Forms.ListBox lb_Convert;
        private System.Windows.Forms.TextBox tb_CM_to_Inches;
        private System.Windows.Forms.TextBox tb_M_to_Feet;
        private System.Windows.Forms.TextBox tb_Cel_to_Fah;
        private System.Windows.Forms.TextBox tb_CM_to_Feet;
        private System.Windows.Forms.TextBox tb_KM_to_Miles;
    }
}

