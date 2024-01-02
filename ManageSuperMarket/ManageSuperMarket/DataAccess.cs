using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;

namespace ManageSuperMarket
{
    public class DataAccess
    {
        public string strConnection = @"Data Source=DESKTOP-KN8R2E4;Initial Catalog=QLST;Integrated Security=True";
        public SqlConnection objConnection;
        public DataAccess()
        {
            string strConnection = @"Data Source=DESKTOP-KN8R2E4;Initial Catalog=QLST;Integrated Security=True";

            objConnection = new SqlConnection(strConnection);

        }

        public void UpdateData(string i_updateCommand)
        {
            try
            {
                objConnection = new SqlConnection(strConnection);
                objConnection.Open();
                SqlCommand cmd = new SqlCommand(i_updateCommand, objConnection);
                cmd.ExecuteNonQuery();
                objConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Data Failed\n" + ex.Message);
            }
            finally
            {

                if (objConnection != null)
                    objConnection.Close();
            }
        }
        
        public void InsertAccount(string i_boolCmd,string i_insertCmd)
        {
            int i = 0;
            objConnection = new SqlConnection(strConnection);
            objConnection.Open();
            SqlCommand cmd = new SqlCommand(i_boolCmd, objConnection);

            i = (int)cmd.ExecuteScalar();

            if(i != 0)
            {
                MessageBox.Show("Tài khoản đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand(i_insertCmd, objConnection);
                    sqlCommand.ExecuteNonQuery();

                    if (MessageBox.Show("Tạo tài khoản thành công!\n Đăng nhập ngay?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        DangNhap dangNhap = new DangNhap();
                        dangNhap.Show();
                        DangKy dangKy = new DangKy();
                        dangKy.Show();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if(objConnection != null)
                    {
                        objConnection.Close();
                    }
                }
            }
        }
        public DataTable GetDataTable(string i_selectCommand)
        {
            DataTable dt = new DataTable();
            try
            {
                objConnection = new SqlConnection(strConnection);
                objConnection.Open();
                SqlDataAdapter objAdapter = new SqlDataAdapter(i_selectCommand, objConnection);

                objAdapter.Fill(dt);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {

                if (objConnection != null)
                    objConnection.Close();
            }

            return dt;
        }

        public SqlDataReader ShowText(string sql)
        {
            SqlDataReader read = null;
            try
            {
                objConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(sql, objConnection);
                read = sqlCommand.ExecuteReader();
                objConnection.Close();
            }
            catch (Exception ex)
            { MessageBox.Show("Lỗi kết nối!\n" + ex.Message); }
            return read;
        }

        public void LoadData(string i_selectCommand, DataGridView dataGV)
        {
            try
            {

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(i_selectCommand, objConnection);
                DataTable dataTable = new DataTable();
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
                sqlDataAdapter.Fill(dataTable);
                dataGV.DataSource = dataTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể kết nối " + ex, "Thông báo ! ");

            }
        }

       
        public void UpdateDataBill(string i_sqlCommand)
        {
            try
            {
                objConnection = new SqlConnection(strConnection);
                objConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(i_sqlCommand, objConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                objConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error không thể tạo hóa đơn" + e);
            }

        }
    }
}
