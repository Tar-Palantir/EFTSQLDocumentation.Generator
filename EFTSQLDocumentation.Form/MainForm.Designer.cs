namespace EFTSQLDocumentation.Form
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConnStr = new System.Windows.Forms.TextBox();
            this.txtEdmxSrc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEdmxDes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtXmlnsNameSpace = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbSqlClient = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.Location = new System.Drawing.Point(203, 299);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(179, 36);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Import";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "ConnectionString:";
            // 
            // txtConnStr
            // 
            this.txtConnStr.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtConnStr.Location = new System.Drawing.Point(177, 8);
            this.txtConnStr.Multiline = true;
            this.txtConnStr.Name = "txtConnStr";
            this.txtConnStr.Size = new System.Drawing.Size(395, 75);
            this.txtConnStr.TabIndex = 2;
            // 
            // txtEdmxSrc
            // 
            this.txtEdmxSrc.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtEdmxSrc.Location = new System.Drawing.Point(177, 95);
            this.txtEdmxSrc.Multiline = true;
            this.txtEdmxSrc.Name = "txtEdmxSrc";
            this.txtEdmxSrc.Size = new System.Drawing.Size(395, 30);
            this.txtEdmxSrc.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Source edmx file path:";
            // 
            // txtEdmxDes
            // 
            this.txtEdmxDes.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtEdmxDes.Location = new System.Drawing.Point(177, 139);
            this.txtEdmxDes.Multiline = true;
            this.txtEdmxDes.Name = "txtEdmxDes";
            this.txtEdmxDes.Size = new System.Drawing.Size(395, 32);
            this.txtEdmxDes.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(10, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Output edmx file path:";
            // 
            // txtXmlnsNameSpace
            // 
            this.txtXmlnsNameSpace.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtXmlnsNameSpace.Location = new System.Drawing.Point(177, 189);
            this.txtXmlnsNameSpace.Multiline = true;
            this.txtXmlnsNameSpace.Name = "txtXmlnsNameSpace";
            this.txtXmlnsNameSpace.Size = new System.Drawing.Size(395, 28);
            this.txtXmlnsNameSpace.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(10, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "Xmlns in edmx:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(12, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "Database Server:";
            // 
            // cbSqlClient
            // 
            this.cbSqlClient.AllowDrop = true;
            this.cbSqlClient.DisplayMember = "Key";
            this.cbSqlClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSqlClient.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbSqlClient.FormattingEnabled = true;
            this.cbSqlClient.ItemHeight = 12;
            this.cbSqlClient.Location = new System.Drawing.Point(177, 237);
            this.cbSqlClient.Name = "cbSqlClient";
            this.cbSqlClient.Size = new System.Drawing.Size(121, 20);
            this.cbSqlClient.TabIndex = 9;
            this.cbSqlClient.ValueMember = "Value";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(10, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 11);
            this.label6.TabIndex = 7;
            this.label6.Text = "(Mostly diff per version)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(10, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 11);
            this.label7.TabIndex = 7;
            this.label7.Text = "(Use source  path if empty)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.cbSqlClient);
            this.Controls.Add(this.txtXmlnsNameSpace);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEdmxDes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEdmxSrc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtConnStr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Import Comment Into EF Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConnStr;
        private System.Windows.Forms.TextBox txtEdmxSrc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEdmxDes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtXmlnsNameSpace;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbSqlClient;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

