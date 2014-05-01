using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace FileAware
{
    class SQLiteDatabaseHelper
    {
        
        private SQLiteCommand insertCommand;
        private SQLiteCommand updateCommand;
        private SQLiteCommand deleteCommand;
        private SQLiteCommand selectCommand;
        private SQLiteConnection dbConnection;
        private SQLiteDataAdapter dbAdapter;
        private DataSet currentDataSet;
        private string connectionString;
        
        
        public SQLiteDatabaseHelper(string connectionString)
        {
            this.connectionString = connectionString;
            dbAdapter = new SQLiteDataAdapter();
            selectCommand = new SQLiteCommand(dbConnection);
            insertCommand = new SQLiteCommand(this.connectionString);
            updateCommand = new SQLiteCommand(this.connectionString);
            deleteCommand = new SQLiteCommand(this.connectionString);
            

        }

        public DataSet GetTable(string tableName)
        {
            
            return currentDataSet;
        }

        public DataSet Insert(string tableName, DataRow insertRow)
        {
            currentDataSet.Tables[currentDataSet.Tables.IndexOf(tableName)].Rows.Add(insertRow);
            return currentDataSet;
        }
    }
}
