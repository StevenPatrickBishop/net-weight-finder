namespace Net_Weight_Finder
{
    partial class frmCycleCounter
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
            this.lblKG2 = new System.Windows.Forms.Label();
            this.txt_Net_Weight_Value = new System.Windows.Forms.TextBox();
            this.lbl_Net_Weight = new System.Windows.Forms.Label();
            this.btn_Reset_Form = new System.Windows.Forms.Button();
            this.btn_Calculate_Net_Weight = new System.Windows.Forms.Button();
            this.chk_Use_Custom_Tare = new System.Windows.Forms.CheckBox();
            this.pnl_Custom_Tare = new System.Windows.Forms.Panel();
            this.rad_Pounds = new System.Windows.Forms.RadioButton();
            this.rad_Kilos = new System.Windows.Forms.RadioButton();
            this.txt_Custom_Tare_Value = new System.Windows.Forms.TextBox();
            this.lbl_Custom_Tare = new System.Windows.Forms.Label();
            this.pnl_ContainerList = new System.Windows.Forms.Panel();
            this.lbl_Container_1 = new System.Windows.Forms.Label();
            this.cbo_Container_List_Value = new System.Windows.Forms.ComboBox();
            this.lbl_KG = new System.Windows.Forms.Label();
            this.txt_Gross_Weight_Value = new System.Windows.Forms.TextBox();
            this.lbl_Gross_Weight = new System.Windows.Forms.Label();
            this.pnl_ContainerList2 = new System.Windows.Forms.Panel();
            this.lbl_Container_2 = new System.Windows.Forms.Label();
            this.cbo_Container_List_2_Value = new System.Windows.Forms.ComboBox();
            this.pnl_Containers = new System.Windows.Forms.Panel();
            this.pnl_Custom_Tare.SuspendLayout();
            this.pnl_ContainerList.SuspendLayout();
            this.pnl_ContainerList2.SuspendLayout();
            this.pnl_Containers.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblKG2
            // 
            this.lblKG2.AutoSize = true;
            this.lblKG2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKG2.Location = new System.Drawing.Point(430, 678);
            this.lblKG2.Name = "lblKG2";
            this.lblKG2.Size = new System.Drawing.Size(35, 25);
            this.lblKG2.TabIndex = 23;
            this.lblKG2.Text = "kg";
            // 
            // txt_Net_Weight_Value
            // 
            this.txt_Net_Weight_Value.CausesValidation = false;
            this.txt_Net_Weight_Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Net_Weight_Value.Location = new System.Drawing.Point(335, 672);
            this.txt_Net_Weight_Value.Name = "txt_Net_Weight_Value";
            this.txt_Net_Weight_Value.ReadOnly = true;
            this.txt_Net_Weight_Value.Size = new System.Drawing.Size(89, 31);
            this.txt_Net_Weight_Value.TabIndex = 22;
            this.txt_Net_Weight_Value.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_Net_Weight
            // 
            this.lbl_Net_Weight.AutoSize = true;
            this.lbl_Net_Weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Net_Weight.Location = new System.Drawing.Point(205, 675);
            this.lbl_Net_Weight.Name = "lbl_Net_Weight";
            this.lbl_Net_Weight.Size = new System.Drawing.Size(130, 25);
            this.lbl_Net_Weight.TabIndex = 21;
            this.lbl_Net_Weight.Text = "Net Weight: ";
            // 
            // btn_Reset_Form
            // 
            this.btn_Reset_Form.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset_Form.Location = new System.Drawing.Point(361, 578);
            this.btn_Reset_Form.Name = "btn_Reset_Form";
            this.btn_Reset_Form.Size = new System.Drawing.Size(191, 36);
            this.btn_Reset_Form.TabIndex = 20;
            this.btn_Reset_Form.Text = "Reset Form";
            this.btn_Reset_Form.UseVisualStyleBackColor = true;
            this.btn_Reset_Form.Click += new System.EventHandler(this.btn_Reset_Form_Click);
            // 
            // btn_Calculate_Net_Weight
            // 
            this.btn_Calculate_Net_Weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calculate_Net_Weight.Location = new System.Drawing.Point(133, 578);
            this.btn_Calculate_Net_Weight.Name = "btn_Calculate_Net_Weight";
            this.btn_Calculate_Net_Weight.Size = new System.Drawing.Size(197, 36);
            this.btn_Calculate_Net_Weight.TabIndex = 19;
            this.btn_Calculate_Net_Weight.Text = "Calculate Net";
            this.btn_Calculate_Net_Weight.UseVisualStyleBackColor = true;
            this.btn_Calculate_Net_Weight.Click += new System.EventHandler(this.btn_Calculate_Net_Weight_Click);
            // 
            // chk_Use_Custom_Tare
            // 
            this.chk_Use_Custom_Tare.AutoSize = true;
            this.chk_Use_Custom_Tare.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Use_Custom_Tare.Location = new System.Drawing.Point(41, 440);
            this.chk_Use_Custom_Tare.Name = "chk_Use_Custom_Tare";
            this.chk_Use_Custom_Tare.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chk_Use_Custom_Tare.Size = new System.Drawing.Size(198, 29);
            this.chk_Use_Custom_Tare.TabIndex = 18;
            this.chk_Use_Custom_Tare.Text = "Use Custom Tare";
            this.chk_Use_Custom_Tare.UseVisualStyleBackColor = true;
            this.chk_Use_Custom_Tare.CheckedChanged += new System.EventHandler(this.chk_Use_Custom_Tare_CheckedChanged);
            // 
            // pnl_Custom_Tare
            // 
            this.pnl_Custom_Tare.Controls.Add(this.rad_Pounds);
            this.pnl_Custom_Tare.Controls.Add(this.rad_Kilos);
            this.pnl_Custom_Tare.Controls.Add(this.txt_Custom_Tare_Value);
            this.pnl_Custom_Tare.Controls.Add(this.lbl_Custom_Tare);
            this.pnl_Custom_Tare.Enabled = false;
            this.pnl_Custom_Tare.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_Custom_Tare.Location = new System.Drawing.Point(257, 411);
            this.pnl_Custom_Tare.Name = "pnl_Custom_Tare";
            this.pnl_Custom_Tare.Size = new System.Drawing.Size(398, 116);
            this.pnl_Custom_Tare.TabIndex = 17;
            // 
            // rad_Pounds
            // 
            this.rad_Pounds.AutoSize = true;
            this.rad_Pounds.Location = new System.Drawing.Point(283, 75);
            this.rad_Pounds.Name = "rad_Pounds";
            this.rad_Pounds.Size = new System.Drawing.Size(47, 29);
            this.rad_Pounds.TabIndex = 6;
            this.rad_Pounds.TabStop = true;
            this.rad_Pounds.Text = "lb";
            this.rad_Pounds.UseVisualStyleBackColor = true;
            // 
            // rad_Kilos
            // 
            this.rad_Kilos.AutoSize = true;
            this.rad_Kilos.Checked = true;
            this.rad_Kilos.Location = new System.Drawing.Point(218, 75);
            this.rad_Kilos.Name = "rad_Kilos";
            this.rad_Kilos.Size = new System.Drawing.Size(53, 29);
            this.rad_Kilos.TabIndex = 5;
            this.rad_Kilos.TabStop = true;
            this.rad_Kilos.Text = "kg";
            this.rad_Kilos.UseVisualStyleBackColor = true;
            // 
            // txt_Custom_Tare_Value
            // 
            this.txt_Custom_Tare_Value.CausesValidation = false;
            this.txt_Custom_Tare_Value.Location = new System.Drawing.Point(218, 28);
            this.txt_Custom_Tare_Value.Name = "txt_Custom_Tare_Value";
            this.txt_Custom_Tare_Value.Size = new System.Drawing.Size(112, 31);
            this.txt_Custom_Tare_Value.TabIndex = 4;
            // 
            // lbl_Custom_Tare
            // 
            this.lbl_Custom_Tare.AutoSize = true;
            this.lbl_Custom_Tare.Location = new System.Drawing.Point(26, 31);
            this.lbl_Custom_Tare.Name = "lbl_Custom_Tare";
            this.lbl_Custom_Tare.Size = new System.Drawing.Size(186, 25);
            this.lbl_Custom_Tare.TabIndex = 3;
            this.lbl_Custom_Tare.Text = "Enter Tare Weight";
            // 
            // pnl_ContainerList
            // 
            this.pnl_ContainerList.Controls.Add(this.lbl_Container_1);
            this.pnl_ContainerList.Controls.Add(this.cbo_Container_List_Value);
            this.pnl_ContainerList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_ContainerList.Location = new System.Drawing.Point(14, 15);
            this.pnl_ContainerList.Name = "pnl_ContainerList";
            this.pnl_ContainerList.Size = new System.Drawing.Size(614, 100);
            this.pnl_ContainerList.TabIndex = 16;
            // 
            // lbl_Container_1
            // 
            this.lbl_Container_1.AutoSize = true;
            this.lbl_Container_1.Location = new System.Drawing.Point(3, 13);
            this.lbl_Container_1.Name = "lbl_Container_1";
            this.lbl_Container_1.Size = new System.Drawing.Size(171, 25);
            this.lbl_Container_1.TabIndex = 4;
            this.lbl_Container_1.Text = "Select Container";
            // 
            // cbo_Container_List_Value
            // 
            this.cbo_Container_List_Value.FormattingEnabled = true;
            this.cbo_Container_List_Value.Location = new System.Drawing.Point(8, 54);
            this.cbo_Container_List_Value.Name = "cbo_Container_List_Value";
            this.cbo_Container_List_Value.Size = new System.Drawing.Size(587, 33);
            this.cbo_Container_List_Value.TabIndex = 3;
            this.cbo_Container_List_Value.Text = "None";
            // 
            // lbl_KG
            // 
            this.lbl_KG.AutoSize = true;
            this.lbl_KG.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_KG.Location = new System.Drawing.Point(482, 29);
            this.lbl_KG.Name = "lbl_KG";
            this.lbl_KG.Size = new System.Drawing.Size(35, 25);
            this.lbl_KG.TabIndex = 15;
            this.lbl_KG.Text = "kg";
            // 
            // txt_Gross_Weight_Value
            // 
            this.txt_Gross_Weight_Value.CausesValidation = false;
            this.txt_Gross_Weight_Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Gross_Weight_Value.Location = new System.Drawing.Point(335, 24);
            this.txt_Gross_Weight_Value.Name = "txt_Gross_Weight_Value";
            this.txt_Gross_Weight_Value.Size = new System.Drawing.Size(139, 31);
            this.txt_Gross_Weight_Value.TabIndex = 14;
            // 
            // lbl_Gross_Weight
            // 
            this.lbl_Gross_Weight.AutoSize = true;
            this.lbl_Gross_Weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gross_Weight.Location = new System.Drawing.Point(128, 28);
            this.lbl_Gross_Weight.Name = "lbl_Gross_Weight";
            this.lbl_Gross_Weight.Size = new System.Drawing.Size(199, 25);
            this.lbl_Gross_Weight.TabIndex = 13;
            this.lbl_Gross_Weight.Text = "Enter Gross Weight";
            // 
            // pnl_ContainerList2
            // 
            this.pnl_ContainerList2.Controls.Add(this.lbl_Container_2);
            this.pnl_ContainerList2.Controls.Add(this.cbo_Container_List_2_Value);
            this.pnl_ContainerList2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_ContainerList2.Location = new System.Drawing.Point(14, 156);
            this.pnl_ContainerList2.Name = "pnl_ContainerList2";
            this.pnl_ContainerList2.Size = new System.Drawing.Size(614, 100);
            this.pnl_ContainerList2.TabIndex = 24;
            // 
            // lbl_Container_2
            // 
            this.lbl_Container_2.AutoSize = true;
            this.lbl_Container_2.Location = new System.Drawing.Point(3, 13);
            this.lbl_Container_2.Name = "lbl_Container_2";
            this.lbl_Container_2.Size = new System.Drawing.Size(189, 25);
            this.lbl_Container_2.TabIndex = 4;
            this.lbl_Container_2.Text = "Select Container 2";
            // 
            // cbo_Container_List_2_Value
            // 
            this.cbo_Container_List_2_Value.FormattingEnabled = true;
            this.cbo_Container_List_2_Value.Location = new System.Drawing.Point(8, 54);
            this.cbo_Container_List_2_Value.Name = "cbo_Container_List_2_Value";
            this.cbo_Container_List_2_Value.Size = new System.Drawing.Size(587, 33);
            this.cbo_Container_List_2_Value.TabIndex = 3;
            this.cbo_Container_List_2_Value.Text = "None";
            // 
            // pnl_Containers
            // 
            this.pnl_Containers.Controls.Add(this.pnl_ContainerList);
            this.pnl_Containers.Controls.Add(this.pnl_ContainerList2);
            this.pnl_Containers.Location = new System.Drawing.Point(27, 72);
            this.pnl_Containers.Name = "pnl_Containers";
            this.pnl_Containers.Size = new System.Drawing.Size(640, 273);
            this.pnl_Containers.TabIndex = 25;
            // 
            // frmCycleCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 757);
            this.Controls.Add(this.pnl_Containers);
            this.Controls.Add(this.lblKG2);
            this.Controls.Add(this.txt_Net_Weight_Value);
            this.Controls.Add(this.lbl_Net_Weight);
            this.Controls.Add(this.btn_Reset_Form);
            this.Controls.Add(this.btn_Calculate_Net_Weight);
            this.Controls.Add(this.chk_Use_Custom_Tare);
            this.Controls.Add(this.pnl_Custom_Tare);
            this.Controls.Add(this.lbl_KG);
            this.Controls.Add(this.txt_Gross_Weight_Value);
            this.Controls.Add(this.lbl_Gross_Weight);
            this.Name = "frmCycleCounter";
            this.Text = "Cycle Count Pro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl_Custom_Tare.ResumeLayout(false);
            this.pnl_Custom_Tare.PerformLayout();
            this.pnl_ContainerList.ResumeLayout(false);
            this.pnl_ContainerList.PerformLayout();
            this.pnl_ContainerList2.ResumeLayout(false);
            this.pnl_ContainerList2.PerformLayout();
            this.pnl_Containers.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKG2;
        private System.Windows.Forms.TextBox txt_Net_Weight_Value;
        private System.Windows.Forms.Label lbl_Net_Weight;
        private System.Windows.Forms.Button btn_Reset_Form;
        private System.Windows.Forms.Button btn_Calculate_Net_Weight;
        private System.Windows.Forms.CheckBox chk_Use_Custom_Tare;
        private System.Windows.Forms.Panel pnl_Custom_Tare;
        private System.Windows.Forms.RadioButton rad_Pounds;
        private System.Windows.Forms.RadioButton rad_Kilos;
        private System.Windows.Forms.TextBox txt_Custom_Tare_Value;
        private System.Windows.Forms.Label lbl_Custom_Tare;
        private System.Windows.Forms.Panel pnl_ContainerList;
        private System.Windows.Forms.Label lbl_Container_1;
        private System.Windows.Forms.ComboBox cbo_Container_List_Value;
        private System.Windows.Forms.Label lbl_KG;
        private System.Windows.Forms.TextBox txt_Gross_Weight_Value;
        private System.Windows.Forms.Label lbl_Gross_Weight;
        private System.Windows.Forms.Panel pnl_ContainerList2;
        private System.Windows.Forms.Label lbl_Container_2;
        private System.Windows.Forms.ComboBox cbo_Container_List_2_Value;
        private System.Windows.Forms.Panel pnl_Containers;
    }
}

