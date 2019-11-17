using System;
using System.IO;
using SQLite;

namespace localdb
{
    public class ItemDatabase
    {
        private static ItemDatabase _database;
        public static ItemDatabase Database =>
            _database ?? (_database = new ItemDatabase(
                Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                    "TodoSQLite.db3")));

        public ItemDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<TodoItem>().Wait();
        }
    }
}
