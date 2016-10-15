using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace TechHidraulics_ERP_CRM
{
    //[Obsolete("Inutilizable para la estructuda de 3 capas")]
	public static class Conexion
	{
	    private const string Server = "localhost";
	    //private static string _Server_SQL = "DESKTOP-ADND2H2\\SQLEXPRESS,1433";
        private const string ServerSql = "DESKTOP-ADND2H2\\SQLEXPRESS";
        private const string Database = "TH";
		private const string UserId = "th_admin";
		private const string Password = "th_admin";

		public static XtraForm Parent;
        


        //	private static string _ConecctionString = string.Format("Data Source={0};Initial Catalog={1};User id={2};Password={3};", new object[]
        private static readonly string ConecctionString = string.Format("Data Source={0};Initial Catalog={1};Trusted_Connection=True", ServerSql, Database, UserId, Password);

		public static SqlConnection Conec = new SqlConnection(ConecctionString);

		private static SqlCommand _command;

		public static bool Is_Online()
		{
			Ping ping = new Ping();
		    try
			{
				PingReply pingReply = ping.Send(Server, 1000);
			    return pingReply != null && pingReply.Status == IPStatus.Success;
			}
			catch
			{
                return false;
			}
		}

		public static bool Exist_Row(string query)
		{
			bool result;
			try
			{
				_command = new SqlCommand(query, Conec);
				DataSet dataSet = new DataSet();
				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(Conexion._command);
				Conexion._command.Dispose();
				sqlDataAdapter.Fill(dataSet, "Table");
				sqlDataAdapter.Dispose();
				Conexion.Conec.Close();
				bool flag = dataSet.Tables[0].Rows.Count > 0;
				if (flag)
				{
					result = true;
				}
				else
				{
					result = false;
				}
			}
			catch (Exception ex)
			{
				bool flag2 = Conexion.Conec.State == ConnectionState.Open;
				if (flag2)
				{
					Conexion.Conec.Close();
				}
				MessageBox.Show(ex.ToString());
				result = false;
			}
			return result;
		}

		public static bool ExecuteNoQuery(string Query)
		{
			bool result;
			try
			{
				Conexion.Conec.Open();
				Conexion._command = new SqlCommand(Query, Conexion.Conec);
				Conexion._command.ExecuteNonQuery();
				Conexion.Conec.Close();
				result = true;
			}
			catch (Exception ex)
			{
				bool flag = Conexion.Conec.State == ConnectionState.Open;
				if (flag)
				{
					Conexion.Conec.Close();
				}
				MessageBox.Show(ex.ToString());
				result = false;
			}
			return result;
		}

		public static DataSet EjecutarQueryDataset(string Query)
		{
			DataSet result;
			try
			{
				Conexion.Conec.Open();
				Conexion._command = new SqlCommand(Query, Conexion.Conec);
				DataSet dataSet = new DataSet();
				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(Conexion._command);
				Conexion._command.Dispose();
				sqlDataAdapter.Fill(dataSet, "Table");
				sqlDataAdapter.Dispose();
				Conexion.Conec.Close();
				result = dataSet;
			}
			catch (Exception ex)
			{
				bool flag = Conexion.Conec.State == ConnectionState.Open;
				if (flag)
				{
					Conexion.Conec.Close();
				}
				MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				MessageBox.Show(Query, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				result = null;
			}
			return result;
		}

		public static string ExQy_One_Data(string Query)
		{
			string result;
			try
			{
				Conexion.Conec.Open();
				Conexion._command = new SqlCommand(Query, Conexion.Conec);
				DataSet dataSet = new DataSet();
				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(Conexion._command);
				Conexion._command.Dispose();
				sqlDataAdapter.Fill(dataSet);
				sqlDataAdapter.Dispose();
				Conexion.Conec.Close();
				string text = dataSet.Tables[0].Rows[0].ItemArray[0].ToString();
				result = text;
			}
			catch
			{
				bool flag = Conexion.Conec.State == ConnectionState.Open;
				if (flag)
				{
					Conexion.Conec.Close();
				}
				result = null;
			}
			return result;
		}

		public static bool Ejecutar_No_Query_Transaction(string Query)
		{
			Conexion.Conec.Open();
			bool result;
			try
			{
				string[] array = Query.Split(new char[]
				{
					';'
				});
				for (int i = 0; i < array.Length - 1; i++)
				{
					SqlCommand sqlCommand = new SqlCommand(array[i], Conexion.Conec);
					sqlCommand.ExecuteNonQuery();
				}
				Conexion.Conec.Close();
				result = true;
			}
			catch (Exception ex)
			{
				bool flag = Conexion.Conec.State == ConnectionState.Open;
				if (flag)
				{
					Conexion.Conec.Close();
				}
				MessageBox.Show("Error:" + ex.ToString());
				result = false;
			}
			return result;
		}
	}
}
