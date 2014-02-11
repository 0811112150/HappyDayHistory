using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace Human.DAL
{
	public class OLESqlHelper
	{
		public bool IsExists(string sqlText, params OleDbParameter[] parameters)
		{
			using (var connection = new OleDbConnection(ConfigManagement.AccessConStr)) {
				connection.Open();
				using (var command = new OleDbCommand(sqlText, connection)) {
					foreach (var item in parameters) {
						command.Parameters.Add(item);
					}
					return (int)command.ExecuteScalar() > 0;
				}
			}
		}

		public int GetCount(string sqlText, params OleDbParameter[] parameters)
		{
			using (var connection = new OleDbConnection(ConfigManagement.AccessConStr)) {
				connection.Open();
				using (var command = new OleDbCommand(sqlText, connection)) {
					foreach (var item in parameters) {
						command.Parameters.Add(item);
					}
					return (int)command.ExecuteScalar();
				}
			}
		}

		public OleDbDataReader GetReader(string sqlText, OleDbConnection connection, params OleDbParameter[] parameters)
		{
			connection.Open();
			using (var command = new OleDbCommand(sqlText, connection)) {
				foreach (var item in parameters) {
					command.Parameters.Add(item);
				}
				return command.ExecuteReader();
			}
		}

		public bool ExecuteNoneQuery(string sqlText, params OleDbParameter[] parameters)
		{
			using (var connection = new OleDbConnection(ConfigManagement.AccessConStr)) {
				connection.Open();
				using (var command = new OleDbCommand(sqlText, connection)) {
					foreach (var item in parameters) {
						if (item.Value == null) {
							item.Value = System.DBNull.Value;
						}
						command.Parameters.Add(item);
					}
					return command.ExecuteNonQuery() > 0;
				}
			}
		}

		public DataTable GetTable(string sqlText, params OleDbParameter[] parameters)
		{
			using (var connection = new OleDbConnection(ConfigManagement.AccessConStr)) {
				connection.Open();
				using (var command = new OleDbCommand(sqlText, connection)) {
					foreach (var item in parameters) {
						command.Parameters.Add(item);
					}
					using (var adapter = new OleDbDataAdapter(command)) {
						var table = new DataTable();
						adapter.Fill(table);
						return table;
					}
				}
			}
		}
	}
}
