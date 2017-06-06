using System;
using System.IO;
using System.Xml.Linq;
using EFTSQLDocumentation.Generator.Enums;
using EFTSQLDocumentation.Generator.SqlClient;

namespace EFTSQLDocumentation.Generator
{
    public class Sql2EfDoc : IDisposable
    {
        internal string ConnStr { get; set; }
        
        internal string InputFileName { get; set; }
        
        internal string OutputFileName { get; set; }

        internal ISqlClient SqlClient { get; set; }
        
        internal string XmlnsNameSpace { get; set; }

        public Action OnFinish;
        public Action<Exception> OnException;

        public Sql2EfDoc(string connStr, string inputFileName, string outputFileName, string xmlnsNameSpace, EnumSqlClient clientType)
        {
            ConnStr = connStr;
            InputFileName = inputFileName;
            OutputFileName = outputFileName;
            XmlnsNameSpace = xmlnsNameSpace;
            SqlClient = GetSqlCLient(clientType);
        }

        public void Dispose()
        {
            SqlClient?.Dispose();
        }
        
        public void CreateDocumentation()
        {
            try
            {
                SqlClient.ConnectionOpen(ConnStr);
                var doc = XDocument.Load(InputFileName);
                var entityTypeElements = doc.Descendants("{" + XmlnsNameSpace + "}EntityType");
                foreach (var entityTypeElement in entityTypeElements)
                {
                    var tableName = entityTypeElement.Attribute("Name").Value;
                    var propertyElements = entityTypeElement.Descendants("{" + XmlnsNameSpace + "}Property");
                    AddNodeDocumentation(entityTypeElement, SqlClient.GetTableDocumentation(tableName));
                    foreach (var propertyElement in propertyElements)
                    {
                        var columnName = propertyElement.Attribute("Name").Value;
                        AddNodeDocumentation(propertyElement, SqlClient.GetColumnDocumentation(tableName, columnName));
                    }
                }
                if (File.Exists(OutputFileName))
                {
                    File.Delete(OutputFileName);
                }
                doc.Save(OutputFileName);

                OnFinish?.BeginInvoke(null, null);

            }
            catch (Exception ex)
            {
                OnException?.BeginInvoke(ex, null, null);
            }
            finally
            {
                Dispose();
            }
        }

        private void AddNodeDocumentation(XElement element, string documentation)
        {
            if (string.IsNullOrEmpty(documentation))
            {
                return;
            }
            element.Descendants("{" + XmlnsNameSpace + "}Documentation").Remove();
            element.AddFirst(new XElement("{" + XmlnsNameSpace + "}Documentation", new XElement("{" + XmlnsNameSpace + "}Summary", documentation)));
        }

        private ISqlClient GetSqlCLient(EnumSqlClient clientType)
        {
            switch (clientType)
            {
                case EnumSqlClient.SqlServer:
                    return new SqlServerClient();
                case EnumSqlClient.MySql:
                    return new MySqlClient();
                default:
                    return null;
            }
        }
    }
}
