using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.OleDb;

namespace Master.MasterClass
{
    public class SqlServerClass
    {
        #region properties

        private DBConnectionClass objConnection;
        private SqlDataAdapter da;
        private DataTable dt;
        public SqlCommand cmd;  // public karena bisa menggunakan parameter

        #endregion

        #region function

        //get Data
        /// <summary>
        /// Menjalankan Select query dan mengisi data yang didapat dari tabel ke datatable
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public DataTable Filldatatable(string query)
        {
            try
            {
                this.objConnection.OpenConnection();
                da = new SqlDataAdapter(query, this.objConnection.con);
                dt = new DataTable();
                da.Fill(dt);
                da.Dispose();
                return dt;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                this.objConnection.CloseConnection();
            }
        }

        /// <summary>
        /// Menjalankan perintah select untuk mengambil data di kolom pertama baris pertama , hanya mengembalikan 1 nilai (TOP 1)
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public string ExecuteScalar(string query)
        {
            try
            {
                this.objConnection.OpenConnection();
                cmd = new SqlCommand(query, this.objConnection.con);
                object scalar = cmd.ExecuteScalar();
                if (scalar == null)
                    return "";
                else
                    return cmd.ExecuteScalar().ToString();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                this.objConnection.CloseConnection();
            }
        }

        /// <summary>
        /// Menjalankan perintah select untuk mengambil data dan dikembalikan dalam bentuk SqlDatareader
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public SqlDataReader ExecuteReader(string query)
        {
            try
            {
                this.objConnection.OpenConnection();
                cmd = new SqlCommand(query, this.objConnection.con);
                return cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        #endregion

        #region Constructor
        /// <summary>
        /// Constructor Kosong
        /// </summary>
        public SqlServerClass() { }

        public SqlServerClass(DBConnectionClass ObjConnection)
        {
            objConnection = ObjConnection;
        }

        #endregion

    }
}
