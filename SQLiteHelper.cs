using System;
using ExamenApp.Models;
using SQLite;

namespace ExamenApp.Data
public class SQLiteHelper
{
	SQLiteAsyncConnection db;
	public SQLiteHelper(string dbPath)
	{
		db = new SQLiteAsyncConnection(dbPath);
		db.CreateTableAsync<Lugar>().Wait();
	}
}
