using System;

namespace EFTSQLDocumentation.Generator
{
    internal interface ISqlClient : IDisposable
    {
        /// <summary>
        /// 开启连接
        /// </summary>
        /// <param name="connStr">连接字符串</param>
        void ConnectionOpen(string connStr);

        /// <summary>获取表文档描述</summary>
        /// <param name="tableName">表名</param>
        /// <returns></returns>
        string GetTableDocumentation(string tableName);

        /// <summary>
        /// 获取指定表的指定列文档描述
        /// </summary>
        /// <param name="tableName">指定表</param>
        /// <param name="columnName">指定列</param>
        /// <returns></returns>
        string GetColumnDocumentation(string tableName, string columnName);
    }
}