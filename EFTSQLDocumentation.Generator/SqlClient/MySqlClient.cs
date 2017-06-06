using MySql.Data.MySqlClient;

namespace EFTSQLDocumentation.Generator.SqlClient
{
    internal class MySqlClient : ISqlClient
    {
        public MySqlConnection Conn { get; set; }
        
        public void ConnectionOpen(string connStr)
        {
            Conn = new MySqlConnection(connStr);
            Conn.Open();
        }
        
        public string GetTableDocumentation(string tableName)
        {
            return string.Empty;
        }
        
        public string GetColumnDocumentation(string tableName, string columnName)
        {
            using (var command = new MySqlCommand(@"select COLUMN_COMMENT 
                                                        from INFORMATION_SCHEMA.Columns 
                                                        where TABLE_NAME=@TableName 
                                                            and COLUMN_NAME=@ColumnName", Conn))
            {
                command.Parameters.AddWithValue("TableName", tableName);
                command.Parameters.AddWithValue("ColumnName", columnName);

                return command.ExecuteScalar() as string;
            }
        }
        
        public void Dispose()
        {
            Conn.Dispose();
        }
    }
}
