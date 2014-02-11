using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data.Common;
using System.IO;

namespace HappyDay.SQLiteDemo
{
	public class DemoDAL
	{
		private static string dataSource = Path.Combine(Environment.CurrentDirectory, "sqliteTest.db");

		public DemoDAL()
		{
			if (File.Exists(dataSource)) {
				return;
			} else {
				SQLiteConnection.CreateFile(dataSource);
			}
		}

		public void Test()
		{
			var connStrBuilder = new SQLiteConnectionStringBuilder();
			connStrBuilder.DataSource = dataSource;

			using (var conn = new SQLiteConnection(connStrBuilder.ToString())) {
				conn.Open();

				var command = new SQLiteCommand();
				command.Connection = conn;
				var sqlStr = "CREATE TABLE test(username varchar(20),password varchar(20))";
				command.CommandText = sqlStr;
				command.ExecuteNonQuery();
			}
		}
	}
}
