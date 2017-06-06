using MySql.Data.MySqlClient;

namespace EFTSQLDocumentation.Generator.SqlClient
{
    internal class MySqlClient : ISqlClient
    {
        /// <summary>数据库连接</summary>
        public MySqlConnection Conn { get; set; }

        /// <summary>
        /// 开启连接
        /// </summary>
        /// <param name="connStr">连接字符串</param>
        public void ConnectionOpen(string connStr)
        {
            Conn = new MySqlConnection(connStr);
            Conn.Open();
        }

        /// <summary>获取表文档描述</summary>
        /// <param name="tableName">表名</param>
        /// <returns></returns>
        public string GetTableDocumentation(string tableName)
        {
            return string.Empty;
        }

        /// <summary>
        /// 获取指定表的指定列文档描述
        /// </summary>
        /// <param name="tableName">指定表</param>
        /// <param name="columnName">指定列</param>
        /// <returns></returns>
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

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            Conn.Dispose();
        }
    }
}
