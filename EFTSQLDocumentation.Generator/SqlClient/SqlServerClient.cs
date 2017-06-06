using System.Data;
using System.Data.SqlClient;

namespace EFTSQLDocumentation.Generator.SqlClient
{
    internal class SqlServerClient : ISqlClient
    {
        internal SqlConnection Conn { get; set; }
        
        public void ConnectionOpen(string connStr)
        {
            Conn = new SqlConnection(connStr);
            Conn.Open();
        }
        
        public string GetTableDocumentation(string tableName)
        {
            using (var command = new SqlCommand(@"SELECT [value] 
                                                          FROM fn_listextendedproperty (
                                                                'MS_Description', 
                                                                'schema', 'dbo', 
                                                                'table',  @TableName, 
                                                                null, null)", Conn))
            {
                command.Parameters.AddWithValue("@TableName", tableName);
                return command.ExecuteScalar() as string;
            }
        }
        
        public string GetColumnDocumentation(string tableName, string columnName)
        {
            using (var command = new SqlCommand(@"SELECT [value] 
                                                         FROM fn_listextendedproperty (
                                                                'MS_Description', 
                                                                'schema', 'dbo', 
                                                                'table', @TableName, 
                                                                'column', @columnName)", Conn))
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