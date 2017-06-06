using System;
using System.IO;
using System.Xml.Linq;
using EFTSQLDocumentation.Generator.Enums;
using EFTSQLDocumentation.Generator.SqlClient;

namespace EFTSQLDocumentation.Generator
{
    /// <summary>修改数据库映射到EF edmx文件，为其添加数据库表、列注释</summary>
    public class Sql2EfDoc : IDisposable
    {
        /// <summary>数据库连接字符串</summary>
        internal string ConnStr { get; set; }

        /// <summary>输入文件（绝对路径）</summary>
        internal string InputFileName { get; set; }

        /// <summary>输出文件（绝对路径）</summary>
        internal string OutputFileName { get; set; }

        internal ISqlClient SqlClient { get; set; }

        /// <summary>Xmlns命名空间</summary>
        internal string XmlnsNameSpace { get; set; }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="connStr"></param>
        /// <param name="inputFileName"></param>
        /// <param name="outputFileName"></param>
        /// <param name="xmlnsNameSpace"></param>
        /// <param name="clientType"></param>
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

        /// <summary>创建注释文本</summary>
        public void CreateDocumentation()
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
        }
        /// <summary>
        /// 给指定的Xml节点添加文档说明
        /// </summary>
        /// <param name="element"></param>
        /// <param name="documentation"></param>
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
