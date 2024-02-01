using Nhom3.DAO;
using Nhom3.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom3
{
	public partial class fAdmin : Form
	{
		BindingSource foodList = new BindingSource();

		BindingSource accountList = new BindingSource();

		BindingSource categoryList = new BindingSource();

		public Account loginAccount;
		public fAdmin()
		{
			InitializeComponent();
			Load();
		}

		#region methods

		List<Food> SearchFoodByName(string name)
		{
			List<Food> listFood = FoodDAO.Instance.SearchFoodByName(name);

			return listFood;
		}
		void Load()
		{
			dtgvFood.DataSource = foodList;
			dtgvAccount.DataSource = accountList;


			LoadDateTimePickerBill();
			LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
			LoadListFood();
			LoadAccount();
			LoadCategoryIntoCombobox(cbFoodCategory);
			AddFoodBinding();
			AddAccountBinding();
		}

		void AddAccountBinding()
		{
			txbUserName.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "UserName", true, DataSourceUpdateMode.Never));
			txbDisplayName.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "DisplayName", true, DataSourceUpdateMode.Never));
			numericUpDown1.DataBindings.Add(new Binding("Value", dtgvAccount.DataSource, "Type", true, DataSourceUpdateMode.Never));
		}

		void LoadAccount()
		{
			accountList.DataSource = AccountDAO.Instance.GetListAccount();
		}
		void LoadDateTimePickerBill()
		{
			DateTime today = DateTime.Now;
			dtpkFromDate.Value = new DateTime(today.Year, today.Month, 1);
			dtpkToDate.Value = dtpkFromDate.Value.AddMonths(1).AddDays(-1);
		}
		void LoadListBillByDate(DateTime checkIn, DateTime checkOut)
		{
			dtgvBill.DataSource = BillDAO.Instance.GetBillListByDate(checkIn, checkOut);
		}

		void AddFoodBinding()
		{
			txbFoodName.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "Name", true, DataSourceUpdateMode.Never));
			txbFoodID.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "ID", true, DataSourceUpdateMode.Never));
			nmFoodPrice.DataBindings.Add(new Binding("Value", dtgvFood.DataSource, "Price", true, DataSourceUpdateMode.Never));
		}

		void LoadCategoryIntoCombobox(ComboBox cb)
		{
			cb.DataSource = CategoryDAO.Instance.GetListCategory();
			cb.DisplayMember = "Name";
		}
		void LoadListFood()
		{
			foodList.DataSource = FoodDAO.Instance.GetListFood();
		}

		void AddAccount(string userName, string displayName, int type)
		{
			if (AccountDAO.Instance.InsertAccount(userName, displayName, type))
			{
				MessageBox.Show("Thêm tài khoản thành công");
			}
			else
			{
				MessageBox.Show("Thêm tài khoản thất bại");
			}

			LoadAccount();
		}

		void EditAccount(string userName, string displayName, int type)
		{
			if (AccountDAO.Instance.UpdateAccount(userName, displayName, type))
			{
				MessageBox.Show("Cập nhật tài khoản thành công");
			}
			else
			{
				MessageBox.Show("Cập nhật tài khoản thất bại");
			}

			LoadAccount();
		}

		void DeleteAccount(string userName)
		{
			if (loginAccount.UserName.Equals(userName))
			{
				MessageBox.Show("Vui lòng đừng xóa chính bạn chứ");
				return;
			}
			if (AccountDAO.Instance.DeleteAccount(userName))
			{
				MessageBox.Show("Xóa tài khoản thành công");
			}
			else
			{
				MessageBox.Show("Xóa tài khoản thất bại");
			}
			
			LoadAccount();
		}

		void ResetPass(string userName)
		{
			if (AccountDAO.Instance.ResetPassword(userName))
			{
				MessageBox.Show("Đặt lại mật khẩu thành công");
			}
			else
			{
				MessageBox.Show("Đặt lại mật khẩu thất bại");
			}
		}
		#endregion

		#region events
		private void btnAddAccount_Click(object sender, EventArgs e)
		{
			string userName = txbUserName.Text;
			string displayName = txbDisplayName.Text;
			int type = (int)numericUpDown1.Value;

			AddAccount(userName, displayName, type);
		}

		private void btnDeleteAccount_Click(object sender, EventArgs e)
		{
			string userName = txbUserName.Text;

			DeleteAccount(userName);
		}

		private void btnEditAccount_Click(object sender, EventArgs e)
		{
			string userName = txbUserName.Text;
			string displayName = txbDisplayName.Text;
			int type = (int)numericUpDown1.Value;

			EditAccount(userName, displayName, type);
		}


		private void btnResetPassword_Click(object sender, EventArgs e)
		{
			string userName = txbUserName.Text;

			ResetPass(userName);
		}


		private void btnShowAccount_Click(object sender, EventArgs e)
		{
			LoadAccount();
		}


		private void btnSearchFood_Click(object sender, EventArgs e)
		{
			foodList.DataSource = SearchFoodByName(txbSearchFoodName.Text);
		}
		private void txbFoodID_TextChanged(object sender, EventArgs e)
		{
			try
			{
				if (dtgvFood.SelectedCells.Count > 0)
				{
					int id = (int)dtgvFood.SelectedCells[0].OwningRow.Cells["CategoryID"].Value;

					Category cateogory = CategoryDAO.Instance.GetCategoryByID(id);

					cbFoodCategory.SelectedItem = cateogory;

					int index = -1;
					int i = 0;
					foreach (Category item in cbFoodCategory.Items)
					{
						if (item.ID == cateogory.ID)
						{
							index = i;
							break;
						}
						i++;
					}

					cbFoodCategory.SelectedIndex = index;
				}
			}
			catch { }
		}

		private void btnAddFood_Click(object sender, EventArgs e)
		{
			string name = txbFoodName.Text;
			int categoryID = (cbFoodCategory.SelectedItem as Category).ID;
			float price = (float)nmFoodPrice.Value;

			if (FoodDAO.Instance.InsertFood(name, categoryID, price))
			{
				MessageBox.Show("Thêm món thành công");
				LoadListFood();
				if (insertFood != null)
					insertFood(this, new EventArgs());
			}
			else
			{
				MessageBox.Show("Có lỗi khi thêm thức ăn");
			}
		}

		private void btnEditFood_Click(object sender, EventArgs e)
		{
			string name = txbFoodName.Text;
			int categoryID = (cbFoodCategory.SelectedItem as Category).ID;
			float price = (float)nmFoodPrice.Value;
			int id = Convert.ToInt32(txbFoodID.Text);

			if (FoodDAO.Instance.UpdateFood(id, name, categoryID, price))
			{
				MessageBox.Show("Sửa món thành công");
				LoadListFood();
				if (updateFood != null)
					updateFood(this, new EventArgs());
			}
			else
			{
				MessageBox.Show("Có lỗi khi sửa thức ăn");
			}
		}

		private void btnDeleteFood_Click(object sender, EventArgs e)
		{
			int id = Convert.ToInt32(txbFoodID.Text);

			if (FoodDAO.Instance.DeleteFood(id))
			{
				MessageBox.Show("Xóa món thành công");
				LoadListFood();
				if (deleteFood != null)
					deleteFood(this, new EventArgs());
			}
			else
			{
				MessageBox.Show("Có lỗi khi xóa thức ăn");
			}
		}
		private void btnShowFood_Click(object sender, EventArgs e)
		{
			LoadListFood();
		}

		private void btnViewBill_Click(object sender, EventArgs e)
		{
			LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
		}

		private event EventHandler insertFood;
		public event EventHandler InsertFood
		{
			add { insertFood += value; }
			remove { insertFood -= value; }
		}

		private event EventHandler deleteFood;
		public event EventHandler DeleteFood
		{
			add { deleteFood += value; }
			remove { deleteFood -= value; }
		}

		private event EventHandler updateFood;
		public event EventHandler UpdateFood
		{
			add { updateFood += value; }
			remove { updateFood -= value; }
		}

		#endregion

		private void btnFristBillPage_Click(object sender, EventArgs e)
		{
			txbPageBill.Text = "1";
		}

		private void btnLastBillPage_Click(object sender, EventArgs e)
		{
			int sumRecord = BillDAO.Instance.GetNumBillListByDate(dtpkFromDate.Value, dtpkToDate.Value);

			int lastPage = sumRecord / 10;

			if (sumRecord % 10 != 0)
				lastPage++;

			txbPageBill.Text = lastPage.ToString();
		}

		private void txbPageBill_TextChanged(object sender, EventArgs e)
		{
			dtgvBill.DataSource = BillDAO.Instance.GetBillListByDateAndPage(dtpkFromDate.Value, dtpkToDate.Value, Convert.ToInt32(txbPageBill.Text));
		}

		private void btnPrevioursBillPage_Click(object sender, EventArgs e)
		{
			int page = Convert.ToInt32(txbPageBill.Text);

			if (page > 1)
				page--;

			txbPageBill.Text = page.ToString();
		}

		private void btnNextBillPage_Click(object sender, EventArgs e)
		{
			int page = Convert.ToInt32(txbPageBill.Text);
			int sumRecord = BillDAO.Instance.GetNumBillListByDate(dtpkFromDate.Value, dtpkToDate.Value);

			if (page < sumRecord)
				page++;

			txbPageBill.Text = page.ToString();
		}
		public void ExportFile(DataTable dataTable, string sheetName, string title)
		{
			//Tạo các đối tượng Excel

			Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();

			Microsoft.Office.Interop.Excel.Workbooks oBooks;

			Microsoft.Office.Interop.Excel.Sheets oSheets;

			Microsoft.Office.Interop.Excel.Workbook oBook;

			Microsoft.Office.Interop.Excel.Worksheet oSheet;

			//Tạo mới một Excel WorkBook 

			oExcel.Visible = true;

			oExcel.DisplayAlerts = false;

			oExcel.Application.SheetsInNewWorkbook = 1;

			oBooks = oExcel.Workbooks;

			Microsoft.Office.Interop.Excel.Workbook workbook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));
			oBook = workbook;

			oSheets = oBook.Worksheets;

			oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);

			oSheet.Name = sheetName;

			// Tạo phần Tiêu đề
			Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "E1");

			head.MergeCells = true;

			head.Value2 = title;

			head.Font.Bold = true;

			head.Font.Name = "Times New Roman";

			head.Font.Size = "20";

			head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

			// Tạo tiêu đề cột 

			Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");

			cl1.Value2 = "Tên Bàn";

			cl1.ColumnWidth = 12;

			Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");

			cl2.Value2 = "Tổng Tiền";

			cl2.ColumnWidth = 15.0;

			Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");

			cl3.Value2 = "Ngày Vào";
			cl3.ColumnWidth = 25.0;

			Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");

			cl4.Value2 = "Ngày Ra";

			cl4.ColumnWidth = 25.0;

			Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");

			cl5.Value2 = "Giảm Giá";

			cl5.ColumnWidth = 15.0;


			Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "E3");

			rowHead.Font.Bold = true;

			// Kẻ viền

			rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

			// Thiết lập màu nền

			rowHead.Interior.ColorIndex = 6;

			rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

			// Tạo mảng theo datatable

			object[,] arr = new object[dataTable.Rows.Count, dataTable.Columns.Count];

			//Chuyển dữ liệu từ DataTable vào mảng đối tượng

			for (int row = 0; row < dataTable.Rows.Count; row++)
			{
				DataRow dataRow = dataTable.Rows[row];

				for (int col = 0; col < dataTable.Columns.Count; col++)
				{
					arr[row, col] = dataRow[col];
				}
			}

			//Thiết lập vùng điền dữ liệu

			int rowStart = 4;

			int columnStart = 1;

			int rowEnd = rowStart + dataTable.Rows.Count - 2;

			int columnEnd = dataTable.Columns.Count;

			// Ô bắt đầu điền dữ liệu

			Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];

			// Ô kết thúc điền dữ liệu

			Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

			// Lấy về vùng điền dữ liệu

			Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);

			//Điền dữ liệu vào vùng đã thiết lập

			range.Value2 = arr;

			// Kẻ viền

			range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

			// Căn giữa cột mã nhân viên

			//Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnStart];

			//Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1, c3);

			//Căn giữa cả bảng 
			oSheet.get_Range(c1, c2).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
		}

		private void btnExel_Click(object sender, EventArgs e)
		{
			DataTable dataTable = new DataTable();
			DataColumn col1 = new DataColumn("idTable");
			DataColumn col2 = new DataColumn("totalPrice");
			DataColumn col3 = new DataColumn("DateCheckIn");
			DataColumn col4 = new DataColumn("DateCheckOut");
			DataColumn col5 = new DataColumn("discount");

			dataTable.Columns.Add(col1);
			dataTable.Columns.Add(col2);
			dataTable.Columns.Add(col3);
			dataTable.Columns.Add(col4);
			dataTable.Columns.Add(col5);

            foreach (DataGridViewRow dtgvRow in dtgvBill.Rows)
            {
                DataRow dtrow = dataTable.NewRow();

				dtrow[0] = dtgvRow.Cells[0].Value;
				dtrow[1] = dtgvRow.Cells[1].Value;
				dtrow[2] = dtgvRow.Cells[2].Value;
				dtrow[3] = dtgvRow.Cells[3].Value;
				dtrow[4] = dtgvRow.Cells[4].Value;
				
				dataTable.Rows.Add(dtrow);
			}
			ExportFile(dataTable, "Doanh Thu", "Thống Kê Hóa Đơn Bán");
		}
	}
}
