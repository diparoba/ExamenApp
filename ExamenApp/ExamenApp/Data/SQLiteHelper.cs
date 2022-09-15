using ExamenApp.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExamenApp.Data
{
    
    public class SQLiteHelper
    {
        SQLiteAsyncConnection db;
        public SQLiteHelper(string dbPath)
        {
            db = new SQLiteAsyncConnection(dbPath);
            db.CreateTableAsync<Lugar>().Wait();

        }
        internal Task<int> SaveLugarAsync(Lugar lugar)
        {
            if(lugar.Id == 0)
            {
                return db.InsertAsync(lugar);
            }
            else
            {
                return null;
            }
        }
        internal  Task<List<Lugar>> GetLugaresAsync()
        {
            return db.Table<Lugar>().ToListAsync();
        }

        internal Task GetLugarListAsync()
        {
            throw new NotImplementedException();
        }
        /*internal Task<List<Lugar>> GetLugaresByIdAsync(int idLugar)
{
   return db.Table<Lugar>().Where(a => a.Id == idLugar).FirstOrDefaultAsync();
}*/

    }
}
