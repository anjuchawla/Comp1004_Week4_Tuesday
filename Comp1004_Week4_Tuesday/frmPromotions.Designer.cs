namespace Comp1004_Week4_Tuesday
{
    partial class frmPromotions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPromotions));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lblName = new System.Windows.Forms.Label();
            this.lblMemberId = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.mskMemberId = new System.Windows.Forms.MaskedTextBox();
            this.grpDepartment = new System.Windows.Forms.GroupBox();
            this.radClothing = new System.Windows.Forms.RadioButton();
            this.radEquipmentAccessories = new System.Windows.Forms.RadioButton();
            this.radJuiceBar = new System.Windows.Forms.RadioButton();
            this.radMembership = new System.Windows.Forms.RadioButton();
            this.radPersonalTraining = new System.Windows.Forms.RadioButton();
            this.rtfWelcome = new System.Windows.Forms.RichTextBox();
            this.txtPromotion = new System.Windows.Forms.TextBox();
            this.picDepartment = new System.Windows.Forms.PictureBox();
            this.chkImageVisible = new System.Windows.Forms.CheckBox();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.printForm1 = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
            this.grpDepartment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDepartment)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 40);
            this.label1.TabIndex = 11;
            this.label1.Text = "Look Sharp Fitness Center";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(690, 605);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Anju Chawla";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(798, 631);
            this.shapeContainer1.TabIndex = 10;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = -1;
            this.lineShape1.X2 = 799;
            this.lineShape1.Y1 = 87;
            this.lineShape1.Y2 = 87;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(391, 167);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "&Name";
            // 
            // lblMemberId
            // 
            this.lblMemberId.AutoSize = true;
            this.lblMemberId.Location = new System.Drawing.Point(391, 213);
            this.lblMemberId.Name = "lblMemberId";
            this.lblMemberId.Size = new System.Drawing.Size(76, 17);
            this.lblMemberId.TabIndex = 2;
            this.lblMemberId.Text = "Member &ID";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(507, 164);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(264, 22);
            this.txtName.TabIndex = 1;
            // 
            // mskMemberId
            // 
            this.mskMemberId.Location = new System.Drawing.Point(507, 210);
            this.mskMemberId.Mask = "00000";
            this.mskMemberId.Name = "mskMemberId";
            this.mskMemberId.Size = new System.Drawing.Size(46, 22);
            this.mskMemberId.TabIndex = 3;
            this.mskMemberId.ValidatingType = typeof(int);
            // 
            // grpDepartment
            // 
            this.grpDepartment.Controls.Add(this.radPersonalTraining);
            this.grpDepartment.Controls.Add(this.radMembership);
            this.grpDepartment.Controls.Add(this.radJuiceBar);
            this.grpDepartment.Controls.Add(this.radEquipmentAccessories);
            this.grpDepartment.Controls.Add(this.radClothing);
            this.grpDepartment.Location = new System.Drawing.Point(34, 130);
            this.grpDepartment.Name = "grpDepartment";
            this.grpDepartment.Size = new System.Drawing.Size(275, 244);
            this.grpDepartment.TabIndex = 5;
            this.grpDepartment.TabStop = false;
            this.grpDepartment.Text = "Department";
            // 
            // radClothing
            // 
            this.radClothing.AutoSize = true;
            this.radClothing.Location = new System.Drawing.Point(27, 33);
            this.radClothing.Name = "radClothing";
            this.radClothing.Size = new System.Drawing.Size(80, 21);
            this.radClothing.TabIndex = 0;
            this.radClothing.TabStop = true;
            this.radClothing.Text = "&Clothing";
            this.radClothing.UseVisualStyleBackColor = true;
            this.radClothing.CheckedChanged += new System.EventHandler(this.radClothing_CheckedChanged);
            // 
            // radEquipmentAccessories
            // 
            this.radEquipmentAccessories.AutoSize = true;
            this.radEquipmentAccessories.Location = new System.Drawing.Point(27, 75);
            this.radEquipmentAccessories.Name = "radEquipmentAccessories";
            this.radEquipmentAccessories.Size = new System.Drawing.Size(176, 21);
            this.radEquipmentAccessories.TabIndex = 1;
            this.radEquipmentAccessories.TabStop = true;
            this.radEquipmentAccessories.Text = "E&quipment/Accessories";
            this.radEquipmentAccessories.UseVisualStyleBackColor = true;
            this.radEquipmentAccessories.CheckedChanged += new System.EventHandler(this.radEquipmentAccessories_CheckedChanged);
            // 
            // radJuiceBar
            // 
            this.radJuiceBar.AutoSize = true;
            this.radJuiceBar.Location = new System.Drawing.Point(27, 117);
            this.radJuiceBar.Name = "radJuiceBar";
            this.radJuiceBar.Size = new System.Drawing.Size(88, 21);
            this.radJuiceBar.TabIndex = 2;
            this.radJuiceBar.TabStop = true;
            this.radJuiceBar.Text = "&Juice Bar";
            this.radJuiceBar.UseVisualStyleBackColor = true;
            this.radJuiceBar.CheckedChanged += new System.EventHandler(this.radJuiceBar_CheckedChanged);
            // 
            // radMembership
            // 
            this.radMembership.AutoSize = true;
            this.radMembership.Location = new System.Drawing.Point(27, 159);
            this.radMembership.Name = "radMembership";
            this.radMembership.Size = new System.Drawing.Size(106, 21);
            this.radMembership.TabIndex = 3;
            this.radMembership.TabStop = true;
            this.radMembership.Text = "&Membership";
            this.radMembership.UseVisualStyleBackColor = true;
            this.radMembership.CheckedChanged += new System.EventHandler(this.radMembership_CheckedChanged);
            // 
            // radPersonalTraining
            // 
            this.radPersonalTraining.AutoSize = true;
            this.radPersonalTraining.Location = new System.Drawing.Point(27, 201);
            this.radPersonalTraining.Name = "radPersonalTraining";
            this.radPersonalTraining.Size = new System.Drawing.Size(141, 21);
            this.radPersonalTraining.TabIndex = 4;
            this.radPersonalTraining.TabStop = true;
            this.radPersonalTraining.Text = "Personal &Training";
            this.radPersonalTraining.UseVisualStyleBackColor = true;
            this.radPersonalTraining.CheckedChanged += new System.EventHandler(this.radPersonalTraining_CheckedChanged);
            // 
            // rtfWelcome
            // 
            this.rtfWelcome.Location = new System.Drawing.Point(394, 256);
            this.rtfWelcome.Name = "rtfWelcome";
            this.rtfWelcome.ReadOnly = true;
            this.rtfWelcome.Size = new System.Drawing.Size(377, 60);
            this.rtfWelcome.TabIndex = 13;
            this.rtfWelcome.TabStop = false;
            this.rtfWelcome.Text = "";
            // 
            // txtPromotion
            // 
            this.txtPromotion.Location = new System.Drawing.Point(394, 352);
            this.txtPromotion.Name = "txtPromotion";
            this.txtPromotion.ReadOnly = true;
            this.txtPromotion.Size = new System.Drawing.Size(377, 22);
            this.txtPromotion.TabIndex = 14;
            this.txtPromotion.TabStop = false;
            // 
            // picDepartment
            // 
            this.picDepartment.Location = new System.Drawing.Point(41, 404);
            this.picDepartment.Name = "picDepartment";
            this.picDepartment.Size = new System.Drawing.Size(268, 148);
            this.picDepartment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDepartment.TabIndex = 10;
            this.picDepartment.TabStop = false;
            // 
            // chkImageVisible
            // 
            this.chkImageVisible.AutoSize = true;
            this.chkImageVisible.Location = new System.Drawing.Point(41, 585);
            this.chkImageVisible.Name = "chkImageVisible";
            this.chkImageVisible.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkImageVisible.Size = new System.Drawing.Size(113, 21);
            this.chkImageVisible.TabIndex = 6;
            this.chkImageVisible.Text = "Image &Visible";
            this.chkImageVisible.UseVisualStyleBackColor = true;
            this.chkImageVisible.CheckedChanged += new System.EventHandler(this.chkImageVisible_CheckedChanged);
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(653, 392);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(118, 37);
            this.btnSignIn.TabIndex = 4;
            this.btnSignIn.Text = "&Sign In";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(653, 482);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(118, 37);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "&Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Location = new System.Drawing.Point(653, 437);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(118, 37);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(653, 527);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(118, 37);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // printForm1
            // 
            this.printForm1.DocumentName = "document";
            this.printForm1.Form = this;
            this.printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
            this.printForm1.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("printForm1.PrinterSettings")));
            this.printForm1.PrintFileName = null;
            // 
            // frmPromotions
            // 
            this.AcceptButton = this.btnSignIn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(798, 631);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.chkImageVisible);
            this.Controls.Add(this.picDepartment);
            this.Controls.Add(this.txtPromotion);
            this.Controls.Add(this.rtfWelcome);
            this.Controls.Add(this.grpDepartment);
            this.Controls.Add(this.mskMemberId);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblMemberId);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPromotions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Promotions";
            this.Load += new System.EventHandler(this.frmPromotions_Load);
            this.grpDepartment.ResumeLayout(false);
            this.grpDepartment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDepartment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblMemberId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.MaskedTextBox mskMemberId;
        private System.Windows.Forms.GroupBox grpDepartment;
        private System.Windows.Forms.RadioButton radPersonalTraining;
        private System.Windows.Forms.RadioButton radMembership;
        private System.Windows.Forms.RadioButton radJuiceBar;
        private System.Windows.Forms.RadioButton radEquipmentAccessories;
        private System.Windows.Forms.RadioButton radClothing;
        private System.Windows.Forms.RichTextBox rtfWelcome;
        private System.Windows.Forms.TextBox txtPromotion;
        private System.Windows.Forms.PictureBox picDepartment;
        private System.Windows.Forms.CheckBox chkImageVisible;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm printForm1;
    }
}

