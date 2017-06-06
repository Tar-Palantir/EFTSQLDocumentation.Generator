using System;

namespace EFTSQLDocumentation.Generator
{
    internal interface ISqlClient : IDisposable
    {
        void ConnectionOpen(string connStr);
        
        string GetTableDocumentation(string tableName);
        
        string GetColumnDocumentation(string tableName, string columnName);
    }
}