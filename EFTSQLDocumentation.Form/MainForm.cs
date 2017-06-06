using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Threading;
using System.Windows.Forms;
using EFTSQLDocumentation.Form.Properties;
using EFTSQLDocumentation.Generator;
using EFTSQLDocumentation.Generator.Enums;

namespace EFTSQLDocumentation.Form
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        private NameValueCollection _appSettings;
        public NameValueCollection AppSettings => _appSettings ?? (_appSettings = ConfigurationManager.AppSettings);

        private ConnectionStringSettingsCollection _connectionStrings;
        public ConnectionStringSettingsCollection ConnectionStrings => _connectionStrings ?? (_connectionStrings = ConfigurationManager.ConnectionStrings);

        public MainForm()
        {
            InitializeComponent();
            cbSqlClient.DataSource = new List<KeyValuePair<string, EnumSqlClient>>
            {
                new KeyValuePair<string, EnumSqlClient>("SqlServer",EnumSqlClient.SqlServer),
                new KeyValuePair<string, EnumSqlClient>("MySql",EnumSqlClient.MySql)
            };


            if (AppSettings != null && AppSettings.Count > 0)
            {
                txtEdmxSrc.Text = AppSettings["InputFileName"];
                txtEdmxDes.Text = AppSettings["OutputFileName"];
                txtXmlnsNameSpace.Text = AppSettings["Xmlns"];
                cbSqlClient.SelectedIndex = int.Parse(AppSettings["SqlClient"]);
            }
            if (ConnectionStrings != null && ConnectionStrings.Count > 0)
            {
                txtConnStr.Text = ConnectionStrings["ConnStr"]?.ConnectionString;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var connStr = txtConnStr.Text.Trim();
            var inputFileName = txtEdmxSrc.Text.Trim();
            var outputFileName = txtEdmxDes.Text.Trim();
            var xmlns = txtXmlnsNameSpace.Text.Trim();
            if (string.IsNullOrEmpty(connStr))
            {
                MessageBox.Show(Resources.connStr_Empty);
                return;
            }
            if (string.IsNullOrEmpty(inputFileName))
            {
                MessageBox.Show(Resources.inputFileName_Empty);
                return;
            }
            if (string.IsNullOrEmpty(outputFileName))
            {
                outputFileName = inputFileName;
            }
            if (string.IsNullOrEmpty(xmlns))
            {
                MessageBox.Show(Resources.xmlns_Empty);
                return;
            }

            var creator = new Sql2EfDoc(connStr, inputFileName, outputFileName, xmlns,
                (EnumSqlClient)cbSqlClient.SelectedValue);
            creator.OnFinish += () =>
            {
                MessageBox.Show(Resources.success);
                btnSave.Enabled = true;
                btnSave.Text = Resources.btnSave_Import;
            };
            creator.OnException += (ex) => MessageBox.Show(ex.Message, Resources.errorMsgBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);

            Thread thread = new Thread(creator.CreateDocumentation) { IsBackground = true };
            thread.Start();

            btnSave.Enabled = false;
            btnSave.Text = Resources.btnSave_Importing;
        }
    }
}
