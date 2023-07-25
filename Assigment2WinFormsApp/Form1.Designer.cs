namespace Assigment2WinFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblCustomerName = new Label();
            txtCustomerName = new TextBox();
            txtAddress = new TextBox();
            lblAddress = new Label();
            txtCity = new TextBox();
            lblCity = new Label();
            txtProvinceCode = new TextBox();
            lblProvince = new Label();
            txtHomePhone = new TextBox();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtPostalCode = new TextBox();
            lblPostalCode = new Label();
            txtCellPhone = new TextBox();
            lblHomePhone = new Label();
            lblCellPhone = new Label();
            lblMakeAndModel = new Label();
            lblYear = new Label();
            txtMakeAndModel = new TextBox();
            txtYear = new TextBox();
            btnReset = new Button();
            btnClose = new Button();
            btnPreFill = new Button();
            btnBook = new Button();
            label1 = new Label();
            rtbInput = new RichTextBox();
            dtpAppoiment = new DateTimePicker();
            lblMessages = new Label();
            SuspendLayout();
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Location = new Point(31, 20);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(142, 25);
            lblCustomerName.TabIndex = 0;
            lblCustomerName.Text = "Customer name:";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(186, 20);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(150, 31);
            txtCustomerName.TabIndex = 1;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(186, 98);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(150, 31);
            txtAddress.TabIndex = 3;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(31, 98);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(81, 25);
            lblAddress.TabIndex = 2;
            lblAddress.Text = "Address:";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(186, 183);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(150, 31);
            txtCity.TabIndex = 5;
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(31, 172);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(46, 25);
            lblCity.TabIndex = 4;
            lblCity.Text = "City:";
            // 
            // txtProvinceCode
            // 
            txtProvinceCode.Location = new Point(186, 266);
            txtProvinceCode.Name = "txtProvinceCode";
            txtProvinceCode.Size = new Size(150, 31);
            txtProvinceCode.TabIndex = 7;
            // 
            // lblProvince
            // 
            lblProvince.AutoSize = true;
            lblProvince.Location = new Point(31, 269);
            lblProvince.Name = "lblProvince";
            lblProvince.Size = new Size(83, 25);
            lblProvince.TabIndex = 6;
            lblProvince.Text = "Province:";
            // 
            // txtHomePhone
            // 
            txtHomePhone.Location = new Point(186, 437);
            txtHomePhone.Name = "txtHomePhone";
            txtHomePhone.Size = new Size(150, 31);
            txtHomePhone.TabIndex = 13;
            txtHomePhone.TextChanged += txtHomePhone_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(186, 597);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(150, 31);
            txtEmail.TabIndex = 11;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(31, 597);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(58, 25);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "Email:";
            // 
            // txtPostalCode
            // 
            txtPostalCode.Location = new Point(186, 349);
            txtPostalCode.Name = "txtPostalCode";
            txtPostalCode.Size = new Size(150, 31);
            txtPostalCode.TabIndex = 9;
            // 
            // lblPostalCode
            // 
            lblPostalCode.AutoSize = true;
            lblPostalCode.Location = new Point(31, 352);
            lblPostalCode.Name = "lblPostalCode";
            lblPostalCode.Size = new Size(107, 25);
            lblPostalCode.TabIndex = 8;
            lblPostalCode.Text = "Postal code:";
            // 
            // txtCellPhone
            // 
            txtCellPhone.Location = new Point(186, 515);
            txtCellPhone.Name = "txtCellPhone";
            txtCellPhone.Size = new Size(150, 31);
            txtCellPhone.TabIndex = 16;
            // 
            // lblHomePhone
            // 
            lblHomePhone.AutoSize = true;
            lblHomePhone.Location = new Point(31, 437);
            lblHomePhone.Name = "lblHomePhone";
            lblHomePhone.Size = new Size(121, 25);
            lblHomePhone.TabIndex = 17;
            lblHomePhone.Text = "Home phone:";
            // 
            // lblCellPhone
            // 
            lblCellPhone.AutoSize = true;
            lblCellPhone.Location = new Point(31, 515);
            lblCellPhone.Name = "lblCellPhone";
            lblCellPhone.Size = new Size(100, 25);
            lblCellPhone.TabIndex = 18;
            lblCellPhone.Text = "Cell phone:";
            lblCellPhone.Click += label9_Click;
            // 
            // lblMakeAndModel
            // 
            lblMakeAndModel.AutoSize = true;
            lblMakeAndModel.Location = new Point(685, 26);
            lblMakeAndModel.Name = "lblMakeAndModel";
            lblMakeAndModel.Size = new Size(120, 25);
            lblMakeAndModel.TabIndex = 19;
            lblMakeAndModel.Text = "Make & Model:";
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Location = new Point(685, 107);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(48, 25);
            lblYear.TabIndex = 20;
            lblYear.Text = "Year:";
            // 
            // txtMakeAndModel
            // 
            txtMakeAndModel.Location = new Point(871, 26);
            txtMakeAndModel.Name = "txtMakeAndModel";
            txtMakeAndModel.Size = new Size(150, 31);
            txtMakeAndModel.TabIndex = 21;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(871, 107);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(150, 31);
            txtYear.TabIndex = 22;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(980, 492);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(112, 34);
            btnReset.TabIndex = 23;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(1139, 492);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(112, 34);
            btnClose.TabIndex = 24;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnPreFill
            // 
            btnPreFill.Location = new Point(1296, 492);
            btnPreFill.Name = "btnPreFill";
            btnPreFill.Size = new Size(112, 34);
            btnPreFill.TabIndex = 25;
            btnPreFill.Text = "Pre-fill";
            btnPreFill.UseVisualStyleBackColor = true;
            btnPreFill.Click += btnPreFill_Click;
            // 
            // btnBook
            // 
            btnBook.Location = new Point(625, 492);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(285, 34);
            btnBook.TabIndex = 26;
            btnBook.Text = "Book an appointment";
            btnBook.UseVisualStyleBackColor = true;
            btnBook.Click += btnBook_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(685, 212);
            label1.Name = "label1";
            label1.Size = new Size(162, 25);
            label1.TabIndex = 27;
            label1.Text = "Appointment date:";
            // 
            // rtbInput
            // 
            rtbInput.Location = new Point(668, 307);
            rtbInput.Name = "rtbInput";
            rtbInput.Size = new Size(701, 155);
            rtbInput.TabIndex = 29;
            rtbInput.Text = "";
            // 
            // dtpAppoiment
            // 
            dtpAppoiment.Location = new Point(871, 212);
            dtpAppoiment.Name = "dtpAppoiment";
            dtpAppoiment.Size = new Size(300, 31);
            dtpAppoiment.TabIndex = 30;
            dtpAppoiment.ValueChanged += dtpAppoiment_ValueChanged;
            // 
            // lblMessages
            // 
            lblMessages.AutoSize = true;
            lblMessages.Location = new Point(186, 715);
            lblMessages.Name = "lblMessages";
            lblMessages.Size = new Size(182, 25);
            lblMessages.TabIndex = 31;
            lblMessages.Text = "Placeholder for errors";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1506, 921);
            Controls.Add(lblMessages);
            Controls.Add(dtpAppoiment);
            Controls.Add(rtbInput);
            Controls.Add(label1);
            Controls.Add(btnBook);
            Controls.Add(btnPreFill);
            Controls.Add(btnClose);
            Controls.Add(btnReset);
            Controls.Add(txtYear);
            Controls.Add(txtMakeAndModel);
            Controls.Add(lblYear);
            Controls.Add(lblMakeAndModel);
            Controls.Add(lblCellPhone);
            Controls.Add(lblHomePhone);
            Controls.Add(txtCellPhone);
            Controls.Add(txtHomePhone);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtPostalCode);
            Controls.Add(lblPostalCode);
            Controls.Add(txtProvinceCode);
            Controls.Add(lblProvince);
            Controls.Add(txtCity);
            Controls.Add(lblCity);
            Controls.Add(txtAddress);
            Controls.Add(lblAddress);
            Controls.Add(txtCustomerName);
            Controls.Add(lblCustomerName);
            Name = "Form1";
            Text = "Book car maintence";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label lblCustomerName;
        private TextBox txtCustomerName;
        private TextBox txtAddress;
        private Label lblAddress;
        private TextBox txtCity;
        private Label lblCity;
        private TextBox txtProvinceCode;
        private Label lblProvince;
        private TextBox txtHomePhone;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtPostalCode;
        private Label lblPostalCode;
        private TextBox txtCellPhone;
        private Label lblHomePhone;
        private Label lblCellPhone;
        private Label lblMakeAndModel;
        private Label lblYear;
        private TextBox txtMakeAndModel;
        private TextBox txtYear;
        private Button btnReset;
        private Button btnClose;
        private Button btnPreFill;
        private Button btnBook;
        private Label label1;
        private RichTextBox rtbInput;
        private DateTimePicker dtpAppoiment;
        private Label lblMessages;
    }
}