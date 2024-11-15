using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AutoCreateContourSPEC.Model
{
    class SqlConnect_10_118_11_111
    {
        public static bool Error = false;
        public static string ErrorMessage = "";
        static SqlConnection _SqlConnection = new SqlConnection();

        /*---------------------------- Các phương thức kết nối tới cơ sở dữ liệu ----------------------------*/

        #region Các phương thức kết nối tới cơ sở dữ liệu
        /// <summary>
        /// Xâu kết nối
        /// </summary>
        public static string ConnectionString
        {
            get { return _SqlConnection.ConnectionString; }
            set
            {
                Error = false;
                try
                {
                    _SqlConnection = new SqlConnection(value);
                    _SqlConnection.Open();
                    _SqlConnection.Close();
                }
                catch (Exception ex)
                {
                    Error = true;
                    ErrorMessage = ex.Message;
                }
            }
        }

        /// <summary>
        /// Thiết lập kết nối sử dụng Window Authentication Mode
        /// </summary>
        /// <param name="DataSource">Server Name</param>
        /// <param name="InitialCatalog">Database Name</param>
        /// <param name="ConnectTimeout">Timeout</param>
        public static void SetConnection(string DataSource, string InitialCatalog, string UserId, string Password)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = DataSource;
            builder.InitialCatalog = InitialCatalog;
            builder.UserID = UserId;
            builder.Password = Password;
            ConnectionString = builder.ConnectionString;
        }
        #endregion
        /*---------------------------------------------------------------------------------------------------*/


        /*------------------ Các phương thức trả về một DataTable từ một câu lệnh truy vấn ------------------*/

        #region Các phương thức trả về một DataTable từ một câu lệnh truy vấn
        /// <summary>
        /// Phương thức thực thi câu lệnh truy vấn trả về kết quả là một DataTable
        /// </summary>
        /// <param name="TruyVan">Câu lệnh truy vấn</param>
        /// <returns>DataTable chứa kết quả truy vấn</returns>
        public static DataTable GetData(string Query)
        {
            Error = false;
            DataTable tbl = new DataTable();
            try
            {
                _SqlConnection.Open();
                SqlDataAdapter adp = new SqlDataAdapter(Query, _SqlConnection);
                adp.Fill(tbl);
                adp.Dispose();
            }
            catch (Exception ex)
            {
                Error = true;
                ErrorMessage = ex.Message;
            }
            finally
            {
                if (_SqlConnection.State != ConnectionState.Closed)
                    _SqlConnection.Close();
            }
            return tbl;
        }
        #endregion
        /*---------------------------------------------------------------------------------------------------*/


        /*---------------------------------- Các phương thức xử lý dữ liệu ----------------------------------*/

        #region Các phương thức xử lý dữ liệu
        /// <summary>
        /// Phương thức cho phép thực thi một câu lệnh sửa đổi dữ liệu
        /// </summary>
        /// <param name="Query">Câu lệnh Insert, Update hoặc Delete</param>
        public static void ExecuteQuery(string Query)
        {
            Error = false;
            try
            {
                _SqlConnection.Open();
                SqlCommand command = new SqlCommand(Query);
                command.Connection = _SqlConnection;
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Error = true;
                ErrorMessage = ex.Message;
            }
            finally
            {
                if (_SqlConnection.State != ConnectionState.Closed)
                    _SqlConnection.Close();
            }
        }
        public static void ExecuteQueryUsingTran(List<string> queries, int materialType,PropertyInfo[] properties, IData data)
        {
            _SqlConnection.Open();

            SqlTransaction transaction = _SqlConnection.BeginTransaction();

            try
            {
                using (SqlCommand command = _SqlConnection.CreateCommand())
                {
                    command.Transaction = transaction;
                    foreach (string queryString in queries)
                    {
                        command.CommandText = queryString;
                        command.CommandType = CommandType.Text;

                        switch (materialType)
                        {
                            case 1:
                                break;
                            case 2:
                                break;
                            case 3:
                            case 4:


                                break;
                        }

                        command.ExecuteNonQuery();
                    }
                    transaction.Commit();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                try
                {
                    transaction.Rollback();
                }
                catch (Exception rollbackEx)
                {
                    Console.WriteLine("Rollback Failed: " + rollbackEx.Message);
                }
            }
            _SqlConnection.Close();
        }

        public static void ExecuteQueryUsingTran(List<string> queries)
        {
            _SqlConnection.Open();

            SqlTransaction transaction = _SqlConnection.BeginTransaction();

            try
            {
                using (SqlCommand command = _SqlConnection.CreateCommand())
                {
                    command.Transaction = transaction;
                    foreach (string queryString in queries)
                    {
                        command.CommandText = queryString;
                        command.CommandType = CommandType.Text;

                        command.ExecuteNonQuery();
                    }
                    transaction.Commit();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                try
                {
                    transaction.Rollback();
                }
                catch (Exception rollbackEx)
                {
                    Console.WriteLine("Rollback Failed: " + rollbackEx.Message);
                }
            }
            _SqlConnection.Close();
        }
        public static void UpdateByte(string Table, string ImageColumn, byte[] Value, string Condition)
        {
            Error = false;
            try
            {
                if (_SqlConnection.State == ConnectionState.Closed) _SqlConnection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = _SqlConnection;
                command.CommandType = CommandType.Text;
                if (Condition == "")
                    command.CommandText = "update " + Table + " set " + ImageColumn + " = @part";
                else
                    command.CommandText = "update " + Table + " set " + ImageColumn + " = @part" + " where " + Condition;
                command.Parameters.AddWithValue("@part", Value);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Error = true;
                ErrorMessage = ex.Message;
            }
            finally
            {
                if (_SqlConnection.State != ConnectionState.Closed)
                    _SqlConnection.Close();
            }
        }

        /// <summary>
        /// Phương thức thực thi một câu lệnh truy vấn sử dụng TRANSACTION
        /// </summary>
        /// <param name="Query">Câu lệnh Insert, Update hoặc Delete</param>
        public static void ExecuteQueryUsingTran(string Query)
        {
            ExecuteQuery("BEGIN TRANSACTION;" + Query + "; COMMIT;");
        }

        /// <summary>
        /// Phương thức thực thi một câu lệnh truy lấy dữ liệu
        /// </summary>
        /// <param name="Query">Câu lệnh truy vấn</param>
        /// <returns>Số bản ghi của bảng</returns>
        public static bool CheckExist(string Query)
        {
            DataTable tbl = new DataTable();
            tbl = GetData(Query);
            return (tbl.Rows.Count > 0);
        }

        /// <summary>
        /// Thực hiện truy vấn đếm số bản ghi trong bảng, thường dùng để kiểm tra tồn tại của mã đối tượng
        /// </summary>
        /// <param name="queryString">Chuỗi truy vấn</param>
        /// <returns>Số bản ghi thỏa mãn điều kiện</returns>
        public static int RowCount(string Query)
        {
            int numRows = -1;
            try
            {
                _SqlConnection.Open();
                SqlCommand command = new SqlCommand(Query, _SqlConnection);
                numRows = (int)command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Error = true;
                ErrorMessage = ex.Message;
            }
            finally
            {
                if (_SqlConnection.State != ConnectionState.Closed)
                    _SqlConnection.Close();
            }
            return numRows;
        }
        #endregion
        /*---------------------------------------------------------------------------------------------------*/
    }
}
