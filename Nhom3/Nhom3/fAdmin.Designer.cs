namespace Nhom3
{
	partial class fAdmin
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
			this.tcAdmin = new System.Windows.Forms.TabControl();
			this.tpBill = new System.Windows.Forms.TabPage();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnExel = new System.Windows.Forms.Button();
			this.btnViewBill = new System.Windows.Forms.Button();
			this.dtpkToDate = new System.Windows.Forms.DateTimePicker();
			this.dtpkFromDate = new System.Windows.Forms.DateTimePicker();
			this.panel1 = new System.Windows.Forms.Panel();
			this.txbPageBill = new System.Windows.Forms.TextBox();
			this.btnNextBillPage = new System.Windows.Forms.Button();
			this.btnPrevioursBillPage = new System.Windows.Forms.Button();
			this.btnLastBillPage = new System.Windows.Forms.Button();
			this.btnFristBillPage = new System.Windows.Forms.Button();
			this.dtgvBill = new System.Windows.Forms.DataGridView();
			this.tpFood = new System.Windows.Forms.TabPage();
			this.panel6 = new System.Windows.Forms.Panel();
			this.txbSearchFoodName = new System.Windows.Forms.TextBox();
			this.btnSearchFood = new System.Windows.Forms.Button();
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel10 = new System.Windows.Forms.Panel();
			this.nmFoodPrice = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.panel9 = new System.Windows.Forms.Panel();
			this.cbFoodCategory = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.panel8 = new System.Windows.Forms.Panel();
			this.txbFoodName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.panel7 = new System.Windows.Forms.Panel();
			this.txbFoodID = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnShowFood = new System.Windows.Forms.Button();
			this.btnEditFood = new System.Windows.Forms.Button();
			this.btnDeleteFood = new System.Windows.Forms.Button();
			this.btnAddFood = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.dtgvFood = new System.Windows.Forms.DataGridView();
			this.tpAccount = new System.Windows.Forms.TabPage();
			this.panel23 = new System.Windows.Forms.Panel();
			this.btnResetPassword = new System.Windows.Forms.Button();
			this.panel25 = new System.Windows.Forms.Panel();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.label11 = new System.Windows.Forms.Label();
			this.panel26 = new System.Windows.Forms.Panel();
			this.txbDisplayName = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.panel27 = new System.Windows.Forms.Panel();
			this.txbUserName = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.panel28 = new System.Windows.Forms.Panel();
			this.btnShowAccount = new System.Windows.Forms.Button();
			this.btnEditAccount = new System.Windows.Forms.Button();
			this.btnDeleteAccount = new System.Windows.Forms.Button();
			this.btnAddAccount = new System.Windows.Forms.Button();
			this.panel29 = new System.Windows.Forms.Panel();
			this.dtgvAccount = new System.Windows.Forms.DataGridView();
			this.label5 = new System.Windows.Forms.Label();
			this.tcAdmin.SuspendLayout();
			this.tpBill.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).BeginInit();
			this.tpFood.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel10.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nmFoodPrice)).BeginInit();
			this.panel9.SuspendLayout();
			this.panel8.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgvFood)).BeginInit();
			this.tpAccount.SuspendLayout();
			this.panel23.SuspendLayout();
			this.panel25.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.panel26.SuspendLayout();
			this.panel27.SuspendLayout();
			this.panel28.SuspendLayout();
			this.panel29.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).BeginInit();
			this.SuspendLayout();
			// 
			// tcAdmin
			// 
			this.tcAdmin.Controls.Add(this.tpBill);
			this.tcAdmin.Controls.Add(this.tpFood);
			this.tcAdmin.Controls.Add(this.tpAccount);
			this.tcAdmin.Location = new System.Drawing.Point(12, 12);
			this.tcAdmin.Name = "tcAdmin";
			this.tcAdmin.SelectedIndex = 0;
			this.tcAdmin.Size = new System.Drawing.Size(658, 439);
			this.tcAdmin.TabIndex = 0;
			// 
			// tpBill
			// 
			this.tpBill.Controls.Add(this.panel2);
			this.tpBill.Controls.Add(this.panel1);
			this.tpBill.Location = new System.Drawing.Point(4, 22);
			this.tpBill.Name = "tpBill";
			this.tpBill.Padding = new System.Windows.Forms.Padding(3);
			this.tpBill.Size = new System.Drawing.Size(650, 413);
			this.tpBill.TabIndex = 0;
			this.tpBill.Text = "Doanh thu";
			this.tpBill.UseVisualStyleBackColor = true;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.panel2.Controls.Add(this.btnExel);
			this.panel2.Controls.Add(this.btnViewBill);
			this.panel2.Controls.Add(this.dtpkToDate);
			this.panel2.Controls.Add(this.dtpkFromDate);
			this.panel2.Location = new System.Drawing.Point(6, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(638, 32);
			this.panel2.TabIndex = 1;
			// 
			// btnExel
			// 
			this.btnExel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExel.ForeColor = System.Drawing.Color.Red;
			this.btnExel.Location = new System.Drawing.Point(337, 3);
			this.btnExel.Name = "btnExel";
			this.btnExel.Size = new System.Drawing.Size(75, 23);
			this.btnExel.TabIndex = 3;
			this.btnExel.Text = "Exel";
			this.btnExel.UseVisualStyleBackColor = true;
			this.btnExel.Click += new System.EventHandler(this.btnExel_Click);
			// 
			// btnViewBill
			// 
			this.btnViewBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnViewBill.ForeColor = System.Drawing.Color.Red;
			this.btnViewBill.Location = new System.Drawing.Point(234, 3);
			this.btnViewBill.Name = "btnViewBill";
			this.btnViewBill.Size = new System.Drawing.Size(75, 23);
			this.btnViewBill.TabIndex = 2;
			this.btnViewBill.Text = "Thống kê";
			this.btnViewBill.UseVisualStyleBackColor = true;
			this.btnViewBill.Click += new System.EventHandler(this.btnViewBill_Click);
			// 
			// dtpkToDate
			// 
			this.dtpkToDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.dtpkToDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.dtpkToDate.Location = new System.Drawing.Point(435, 6);
			this.dtpkToDate.Name = "dtpkToDate";
			this.dtpkToDate.Size = new System.Drawing.Size(200, 20);
			this.dtpkToDate.TabIndex = 1;
			// 
			// dtpkFromDate
			// 
			this.dtpkFromDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.dtpkFromDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.dtpkFromDate.Location = new System.Drawing.Point(3, 6);
			this.dtpkFromDate.Name = "dtpkFromDate";
			this.dtpkFromDate.Size = new System.Drawing.Size(200, 20);
			this.dtpkFromDate.TabIndex = 0;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.panel1.Controls.Add(this.txbPageBill);
			this.panel1.Controls.Add(this.btnNextBillPage);
			this.panel1.Controls.Add(this.btnPrevioursBillPage);
			this.panel1.Controls.Add(this.btnLastBillPage);
			this.panel1.Controls.Add(this.btnFristBillPage);
			this.panel1.Controls.Add(this.dtgvBill);
			this.panel1.Location = new System.Drawing.Point(6, 38);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(638, 369);
			this.panel1.TabIndex = 0;
			// 
			// txbPageBill
			// 
			this.txbPageBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txbPageBill.Location = new System.Drawing.Point(282, 343);
			this.txbPageBill.Name = "txbPageBill";
			this.txbPageBill.ReadOnly = true;
			this.txbPageBill.Size = new System.Drawing.Size(75, 20);
			this.txbPageBill.TabIndex = 5;
			this.txbPageBill.Text = "1";
			this.txbPageBill.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txbPageBill.TextChanged += new System.EventHandler(this.txbPageBill_TextChanged);
			// 
			// btnNextBillPage
			// 
			this.btnNextBillPage.Location = new System.Drawing.Point(479, 343);
			this.btnNextBillPage.Name = "btnNextBillPage";
			this.btnNextBillPage.Size = new System.Drawing.Size(75, 23);
			this.btnNextBillPage.TabIndex = 4;
			this.btnNextBillPage.Text = "Trang Tiếp";
			this.btnNextBillPage.UseVisualStyleBackColor = true;
			this.btnNextBillPage.Click += new System.EventHandler(this.btnNextBillPage_Click);
			// 
			// btnPrevioursBillPage
			// 
			this.btnPrevioursBillPage.Location = new System.Drawing.Point(84, 343);
			this.btnPrevioursBillPage.Name = "btnPrevioursBillPage";
			this.btnPrevioursBillPage.Size = new System.Drawing.Size(75, 23);
			this.btnPrevioursBillPage.TabIndex = 3;
			this.btnPrevioursBillPage.Text = "Trang Trước";
			this.btnPrevioursBillPage.UseVisualStyleBackColor = true;
			this.btnPrevioursBillPage.Click += new System.EventHandler(this.btnPrevioursBillPage_Click);
			// 
			// btnLastBillPage
			// 
			this.btnLastBillPage.Location = new System.Drawing.Point(560, 344);
			this.btnLastBillPage.Name = "btnLastBillPage";
			this.btnLastBillPage.Size = new System.Drawing.Size(75, 23);
			this.btnLastBillPage.TabIndex = 2;
			this.btnLastBillPage.Text = "Trang Cuối";
			this.btnLastBillPage.UseVisualStyleBackColor = true;
			this.btnLastBillPage.Click += new System.EventHandler(this.btnLastBillPage_Click);
			// 
			// btnFristBillPage
			// 
			this.btnFristBillPage.Location = new System.Drawing.Point(3, 343);
			this.btnFristBillPage.Name = "btnFristBillPage";
			this.btnFristBillPage.Size = new System.Drawing.Size(75, 23);
			this.btnFristBillPage.TabIndex = 1;
			this.btnFristBillPage.Text = "Trang Đầu";
			this.btnFristBillPage.UseVisualStyleBackColor = true;
			this.btnFristBillPage.Click += new System.EventHandler(this.btnFristBillPage_Click);
			// 
			// dtgvBill
			// 
			this.dtgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dtgvBill.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.dtgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgvBill.Location = new System.Drawing.Point(3, 3);
			this.dtgvBill.Name = "dtgvBill";
			this.dtgvBill.Size = new System.Drawing.Size(632, 335);
			this.dtgvBill.TabIndex = 0;
			// 
			// tpFood
			// 
			this.tpFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.tpFood.Controls.Add(this.panel6);
			this.tpFood.Controls.Add(this.panel5);
			this.tpFood.Controls.Add(this.panel3);
			this.tpFood.Location = new System.Drawing.Point(4, 22);
			this.tpFood.Name = "tpFood";
			this.tpFood.Padding = new System.Windows.Forms.Padding(3);
			this.tpFood.Size = new System.Drawing.Size(650, 413);
			this.tpFood.TabIndex = 1;
			this.tpFood.Text = "Menu";
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.panel6.Controls.Add(this.label5);
			this.panel6.Controls.Add(this.txbSearchFoodName);
			this.panel6.Controls.Add(this.btnSearchFood);
			this.panel6.Location = new System.Drawing.Point(9, 6);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(637, 52);
			this.panel6.TabIndex = 3;
			// 
			// txbSearchFoodName
			// 
			this.txbSearchFoodName.Location = new System.Drawing.Point(84, 17);
			this.txbSearchFoodName.Name = "txbSearchFoodName";
			this.txbSearchFoodName.Size = new System.Drawing.Size(195, 20);
			this.txbSearchFoodName.TabIndex = 5;
			// 
			// btnSearchFood
			// 
			this.btnSearchFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSearchFood.ForeColor = System.Drawing.Color.Red;
			this.btnSearchFood.Location = new System.Drawing.Point(3, 10);
			this.btnSearchFood.Name = "btnSearchFood";
			this.btnSearchFood.Size = new System.Drawing.Size(75, 32);
			this.btnSearchFood.TabIndex = 4;
			this.btnSearchFood.Text = "Tìm";
			this.btnSearchFood.UseVisualStyleBackColor = true;
			this.btnSearchFood.Click += new System.EventHandler(this.btnSearchFood_Click);
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.panel5.Controls.Add(this.btnShowFood);
			this.panel5.Controls.Add(this.panel10);
			this.panel5.Controls.Add(this.btnEditFood);
			this.panel5.Controls.Add(this.panel9);
			this.panel5.Controls.Add(this.btnDeleteFood);
			this.panel5.Controls.Add(this.panel8);
			this.panel5.Controls.Add(this.btnAddFood);
			this.panel5.Controls.Add(this.panel7);
			this.panel5.Location = new System.Drawing.Point(9, 61);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(285, 346);
			this.panel5.TabIndex = 2;
			// 
			// panel10
			// 
			this.panel10.Controls.Add(this.nmFoodPrice);
			this.panel10.Controls.Add(this.label4);
			this.panel10.Location = new System.Drawing.Point(3, 153);
			this.panel10.Name = "panel10";
			this.panel10.Size = new System.Drawing.Size(279, 44);
			this.panel10.TabIndex = 4;
			// 
			// nmFoodPrice
			// 
			this.nmFoodPrice.Location = new System.Drawing.Point(91, 8);
			this.nmFoodPrice.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
			this.nmFoodPrice.Name = "nmFoodPrice";
			this.nmFoodPrice.Size = new System.Drawing.Size(185, 20);
			this.nmFoodPrice.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label4.Location = new System.Drawing.Point(3, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(40, 19);
			this.label4.TabIndex = 0;
			this.label4.Text = "Giá:";
			// 
			// panel9
			// 
			this.panel9.Controls.Add(this.cbFoodCategory);
			this.panel9.Controls.Add(this.label3);
			this.panel9.Location = new System.Drawing.Point(3, 103);
			this.panel9.Name = "panel9";
			this.panel9.Size = new System.Drawing.Size(279, 44);
			this.panel9.TabIndex = 3;
			// 
			// cbFoodCategory
			// 
			this.cbFoodCategory.FormattingEnabled = true;
			this.cbFoodCategory.Location = new System.Drawing.Point(91, 9);
			this.cbFoodCategory.Name = "cbFoodCategory";
			this.cbFoodCategory.Size = new System.Drawing.Size(185, 21);
			this.cbFoodCategory.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label3.Location = new System.Drawing.Point(3, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(93, 19);
			this.label3.TabIndex = 0;
			this.label3.Text = "Danh mục:";
			// 
			// panel8
			// 
			this.panel8.Controls.Add(this.txbFoodName);
			this.panel8.Controls.Add(this.label2);
			this.panel8.Location = new System.Drawing.Point(3, 53);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(279, 44);
			this.panel8.TabIndex = 2;
			// 
			// txbFoodName
			// 
			this.txbFoodName.Location = new System.Drawing.Point(91, 8);
			this.txbFoodName.Name = "txbFoodName";
			this.txbFoodName.Size = new System.Drawing.Size(185, 20);
			this.txbFoodName.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label2.Location = new System.Drawing.Point(3, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(82, 19);
			this.label2.TabIndex = 0;
			this.label2.Text = "Tên món:";
			// 
			// panel7
			// 
			this.panel7.Controls.Add(this.txbFoodID);
			this.panel7.Controls.Add(this.label1);
			this.panel7.Location = new System.Drawing.Point(3, 3);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(279, 44);
			this.panel7.TabIndex = 1;
			// 
			// txbFoodID
			// 
			this.txbFoodID.Location = new System.Drawing.Point(91, 8);
			this.txbFoodID.Name = "txbFoodID";
			this.txbFoodID.ReadOnly = true;
			this.txbFoodID.Size = new System.Drawing.Size(185, 20);
			this.txbFoodID.TabIndex = 1;
			this.txbFoodID.TextChanged += new System.EventHandler(this.txbFoodID_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label1.Location = new System.Drawing.Point(3, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(31, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "ID:";
			// 
			// btnShowFood
			// 
			this.btnShowFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnShowFood.Location = new System.Drawing.Point(204, 276);
			this.btnShowFood.Name = "btnShowFood";
			this.btnShowFood.Size = new System.Drawing.Size(75, 46);
			this.btnShowFood.TabIndex = 3;
			this.btnShowFood.Text = "Xem";
			this.btnShowFood.UseVisualStyleBackColor = true;
			this.btnShowFood.Click += new System.EventHandler(this.btnShowFood_Click);
			// 
			// btnEditFood
			// 
			this.btnEditFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEditFood.Location = new System.Drawing.Point(204, 203);
			this.btnEditFood.Name = "btnEditFood";
			this.btnEditFood.Size = new System.Drawing.Size(75, 46);
			this.btnEditFood.TabIndex = 2;
			this.btnEditFood.Text = "Sửa";
			this.btnEditFood.UseVisualStyleBackColor = true;
			this.btnEditFood.Click += new System.EventHandler(this.btnEditFood_Click);
			// 
			// btnDeleteFood
			// 
			this.btnDeleteFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDeleteFood.Location = new System.Drawing.Point(10, 276);
			this.btnDeleteFood.Name = "btnDeleteFood";
			this.btnDeleteFood.Size = new System.Drawing.Size(75, 46);
			this.btnDeleteFood.TabIndex = 1;
			this.btnDeleteFood.Text = "Xóa";
			this.btnDeleteFood.UseVisualStyleBackColor = true;
			this.btnDeleteFood.Click += new System.EventHandler(this.btnDeleteFood_Click);
			// 
			// btnAddFood
			// 
			this.btnAddFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddFood.Location = new System.Drawing.Point(10, 203);
			this.btnAddFood.Name = "btnAddFood";
			this.btnAddFood.Size = new System.Drawing.Size(75, 46);
			this.btnAddFood.TabIndex = 0;
			this.btnAddFood.Text = "Thêm";
			this.btnAddFood.UseVisualStyleBackColor = true;
			this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.dtgvFood);
			this.panel3.Location = new System.Drawing.Point(295, 61);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(349, 346);
			this.panel3.TabIndex = 0;
			// 
			// dtgvFood
			// 
			this.dtgvFood.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.dtgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgvFood.Location = new System.Drawing.Point(2, 0);
			this.dtgvFood.Name = "dtgvFood";
			this.dtgvFood.Size = new System.Drawing.Size(349, 346);
			this.dtgvFood.TabIndex = 0;
			// 
			// tpAccount
			// 
			this.tpAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.tpAccount.Controls.Add(this.panel23);
			this.tpAccount.Controls.Add(this.panel28);
			this.tpAccount.Controls.Add(this.panel29);
			this.tpAccount.Location = new System.Drawing.Point(4, 22);
			this.tpAccount.Name = "tpAccount";
			this.tpAccount.Padding = new System.Windows.Forms.Padding(3);
			this.tpAccount.Size = new System.Drawing.Size(650, 413);
			this.tpAccount.TabIndex = 4;
			this.tpAccount.Text = "Tài khoản";
			// 
			// panel23
			// 
			this.panel23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.panel23.Controls.Add(this.btnResetPassword);
			this.panel23.Controls.Add(this.panel25);
			this.panel23.Controls.Add(this.panel26);
			this.panel23.Controls.Add(this.panel27);
			this.panel23.Location = new System.Drawing.Point(360, 62);
			this.panel23.Name = "panel23";
			this.panel23.Size = new System.Drawing.Size(285, 346);
			this.panel23.TabIndex = 6;
			// 
			// btnResetPassword
			// 
			this.btnResetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnResetPassword.ForeColor = System.Drawing.Color.Red;
			this.btnResetPassword.Location = new System.Drawing.Point(168, 153);
			this.btnResetPassword.Name = "btnResetPassword";
			this.btnResetPassword.Size = new System.Drawing.Size(111, 46);
			this.btnResetPassword.TabIndex = 4;
			this.btnResetPassword.Text = "Đặt lại mật khẩu";
			this.btnResetPassword.UseVisualStyleBackColor = true;
			this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
			// 
			// panel25
			// 
			this.panel25.Controls.Add(this.numericUpDown1);
			this.panel25.Controls.Add(this.label11);
			this.panel25.Location = new System.Drawing.Point(3, 103);
			this.panel25.Name = "panel25";
			this.panel25.Size = new System.Drawing.Size(279, 44);
			this.panel25.TabIndex = 3;
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(127, 8);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(33, 20);
			this.numericUpDown1.TabIndex = 1;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label11.Location = new System.Drawing.Point(3, 9);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(116, 19);
			this.label11.TabIndex = 0;
			this.label11.Text = "Loại tài khoản";
			// 
			// panel26
			// 
			this.panel26.Controls.Add(this.txbDisplayName);
			this.panel26.Controls.Add(this.label12);
			this.panel26.Location = new System.Drawing.Point(3, 53);
			this.panel26.Name = "panel26";
			this.panel26.Size = new System.Drawing.Size(279, 44);
			this.panel26.TabIndex = 2;
			// 
			// txbDisplayName
			// 
			this.txbDisplayName.Location = new System.Drawing.Point(127, 8);
			this.txbDisplayName.Name = "txbDisplayName";
			this.txbDisplayName.Size = new System.Drawing.Size(149, 20);
			this.txbDisplayName.TabIndex = 1;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label12.Location = new System.Drawing.Point(3, 9);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(104, 19);
			this.label12.TabIndex = 0;
			this.label12.Text = "Tên hiển thị:";
			// 
			// panel27
			// 
			this.panel27.Controls.Add(this.txbUserName);
			this.panel27.Controls.Add(this.label13);
			this.panel27.Location = new System.Drawing.Point(3, 3);
			this.panel27.Name = "panel27";
			this.panel27.Size = new System.Drawing.Size(279, 44);
			this.panel27.TabIndex = 1;
			// 
			// txbUserName
			// 
			this.txbUserName.Location = new System.Drawing.Point(127, 8);
			this.txbUserName.Name = "txbUserName";
			this.txbUserName.Size = new System.Drawing.Size(149, 20);
			this.txbUserName.TabIndex = 1;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label13.Location = new System.Drawing.Point(3, 9);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(118, 19);
			this.label13.TabIndex = 0;
			this.label13.Text = "Tên tài khoản:";
			// 
			// panel28
			// 
			this.panel28.Controls.Add(this.btnShowAccount);
			this.panel28.Controls.Add(this.btnEditAccount);
			this.panel28.Controls.Add(this.btnDeleteAccount);
			this.panel28.Controls.Add(this.btnAddAccount);
			this.panel28.Location = new System.Drawing.Point(5, 4);
			this.panel28.Name = "panel28";
			this.panel28.Size = new System.Drawing.Size(349, 52);
			this.panel28.TabIndex = 5;
			// 
			// btnShowAccount
			// 
			this.btnShowAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnShowAccount.Location = new System.Drawing.Point(246, 3);
			this.btnShowAccount.Name = "btnShowAccount";
			this.btnShowAccount.Size = new System.Drawing.Size(75, 46);
			this.btnShowAccount.TabIndex = 3;
			this.btnShowAccount.Text = "Xem";
			this.btnShowAccount.UseVisualStyleBackColor = true;
			this.btnShowAccount.Click += new System.EventHandler(this.btnShowAccount_Click);
			// 
			// btnEditAccount
			// 
			this.btnEditAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEditAccount.Location = new System.Drawing.Point(165, 3);
			this.btnEditAccount.Name = "btnEditAccount";
			this.btnEditAccount.Size = new System.Drawing.Size(75, 46);
			this.btnEditAccount.TabIndex = 2;
			this.btnEditAccount.Text = "Sửa";
			this.btnEditAccount.UseVisualStyleBackColor = true;
			this.btnEditAccount.Click += new System.EventHandler(this.btnEditAccount_Click);
			// 
			// btnDeleteAccount
			// 
			this.btnDeleteAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDeleteAccount.Location = new System.Drawing.Point(84, 3);
			this.btnDeleteAccount.Name = "btnDeleteAccount";
			this.btnDeleteAccount.Size = new System.Drawing.Size(75, 46);
			this.btnDeleteAccount.TabIndex = 1;
			this.btnDeleteAccount.Text = "Xóa";
			this.btnDeleteAccount.UseVisualStyleBackColor = true;
			this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
			// 
			// btnAddAccount
			// 
			this.btnAddAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddAccount.Location = new System.Drawing.Point(3, 3);
			this.btnAddAccount.Name = "btnAddAccount";
			this.btnAddAccount.Size = new System.Drawing.Size(75, 46);
			this.btnAddAccount.TabIndex = 0;
			this.btnAddAccount.Text = "Thêm";
			this.btnAddAccount.UseVisualStyleBackColor = true;
			this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
			// 
			// panel29
			// 
			this.panel29.Controls.Add(this.dtgvAccount);
			this.panel29.Location = new System.Drawing.Point(5, 62);
			this.panel29.Name = "panel29";
			this.panel29.Size = new System.Drawing.Size(349, 346);
			this.panel29.TabIndex = 4;
			// 
			// dtgvAccount
			// 
			this.dtgvAccount.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.dtgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgvAccount.Location = new System.Drawing.Point(3, 3);
			this.dtgvAccount.Name = "dtgvAccount";
			this.dtgvAccount.Size = new System.Drawing.Size(343, 340);
			this.dtgvAccount.TabIndex = 0;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Red;
			this.label5.Location = new System.Drawing.Point(412, 10);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(98, 31);
			this.label5.TabIndex = 6;
			this.label5.Text = "MENU";
			// 
			// fAdmin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(674, 463);
			this.Controls.Add(this.tcAdmin);
			this.Name = "fAdmin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Admin";
			this.tcAdmin.ResumeLayout(false);
			this.tpBill.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).EndInit();
			this.tpFood.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.panel6.PerformLayout();
			this.panel5.ResumeLayout(false);
			this.panel10.ResumeLayout(false);
			this.panel10.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nmFoodPrice)).EndInit();
			this.panel9.ResumeLayout(false);
			this.panel9.PerformLayout();
			this.panel8.ResumeLayout(false);
			this.panel8.PerformLayout();
			this.panel7.ResumeLayout(false);
			this.panel7.PerformLayout();
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dtgvFood)).EndInit();
			this.tpAccount.ResumeLayout(false);
			this.panel23.ResumeLayout(false);
			this.panel25.ResumeLayout(false);
			this.panel25.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.panel26.ResumeLayout(false);
			this.panel26.PerformLayout();
			this.panel27.ResumeLayout(false);
			this.panel27.PerformLayout();
			this.panel28.ResumeLayout(false);
			this.panel29.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tcAdmin;
		private System.Windows.Forms.TabPage tpBill;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridView dtgvBill;
		private System.Windows.Forms.TabPage tpFood;
		private System.Windows.Forms.TabPage tpAccount;
		private System.Windows.Forms.Button btnViewBill;
		private System.Windows.Forms.DateTimePicker dtpkToDate;
		private System.Windows.Forms.DateTimePicker dtpkFromDate;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.TextBox txbSearchFoodName;
		private System.Windows.Forms.Button btnSearchFood;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Button btnShowFood;
		private System.Windows.Forms.Button btnEditFood;
		private System.Windows.Forms.Button btnDeleteFood;
		private System.Windows.Forms.Button btnAddFood;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.DataGridView dtgvFood;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.TextBox txbFoodName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.TextBox txbFoodID;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel10;
		private System.Windows.Forms.NumericUpDown nmFoodPrice;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel9;
		private System.Windows.Forms.ComboBox cbFoodCategory;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel23;
		private System.Windows.Forms.Button btnResetPassword;
		private System.Windows.Forms.Panel panel25;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Panel panel26;
		private System.Windows.Forms.TextBox txbDisplayName;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Panel panel27;
		private System.Windows.Forms.TextBox txbUserName;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Panel panel28;
		private System.Windows.Forms.Button btnShowAccount;
		private System.Windows.Forms.Button btnEditAccount;
		private System.Windows.Forms.Button btnDeleteAccount;
		private System.Windows.Forms.Button btnAddAccount;
		private System.Windows.Forms.Panel panel29;
		private System.Windows.Forms.DataGridView dtgvAccount;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.TextBox txbPageBill;
		private System.Windows.Forms.Button btnNextBillPage;
		private System.Windows.Forms.Button btnPrevioursBillPage;
		private System.Windows.Forms.Button btnLastBillPage;
		private System.Windows.Forms.Button btnFristBillPage;
		private System.Windows.Forms.Button btnExel;
		private System.Windows.Forms.Label label5;
	}
}