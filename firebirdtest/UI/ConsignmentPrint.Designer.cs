﻿using firebirdtest.DataSets;
namespace firebirdtest.UI
{
    partial class ConsignmentPrint
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsignmentPrint));
            this.SALEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new firebirdtest.DataSets.DataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SALETableAdapter = new firebirdtest.DataSets.DataSet1TableAdapters.SALETableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PrintBatch_CB = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.VendorNameSearch_txt = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ConsignmentNumberSearch_txt = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ConsignmentDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SALEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsignmentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SALEBindingSource
            // 
            this.SALEBindingSource.DataMember = "SALE";
            this.SALEBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SALEBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "firebirdtest.Reports.VendorConsignment.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(288, 30);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.PageCountMode = Microsoft.Reporting.WinForms.PageCountMode.Actual;
            this.reportViewer1.Size = new System.Drawing.Size(1056, 667);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ReportRefresh += new System.ComponentModel.CancelEventHandler(this.reportViewer1_ReportRefresh);
            this.reportViewer1.PrintingBegin += new Microsoft.Reporting.WinForms.ReportPrintEventHandler(this.reportViewer1_PrintingBegin);
            // 
            // SALETableAdapter
            // 
            this.SALETableAdapter.ClearBeforeFill = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(90)))));
            this.panel1.Controls.Add(this.PrintBatch_CB);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.VendorNameSearch_txt);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.ConsignmentNumberSearch_txt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ConsignmentDataGridView);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 667);
            this.panel1.TabIndex = 0;
            // 
            // PrintBatch_CB
            // 
            this.PrintBatch_CB.AutoSize = true;
            this.PrintBatch_CB.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PrintBatch_CB.ForeColor = System.Drawing.Color.Indigo;
            this.PrintBatch_CB.Location = new System.Drawing.Point(50, 90);
            this.PrintBatch_CB.Name = "PrintBatch_CB";
            this.PrintBatch_CB.Size = new System.Drawing.Size(78, 17);
            this.PrintBatch_CB.TabIndex = 40;
            this.PrintBatch_CB.Text = "Print Batch";
            this.PrintBatch_CB.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 39;
            this.button1.Text = "Print Selected";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // VendorNameSearch_txt
            // 
            this.VendorNameSearch_txt.FormattingEnabled = true;
            this.VendorNameSearch_txt.Location = new System.Drawing.Point(109, 36);
            this.VendorNameSearch_txt.Name = "VendorNameSearch_txt";
            this.VendorNameSearch_txt.Size = new System.Drawing.Size(121, 21);
            this.VendorNameSearch_txt.TabIndex = 0;
            this.VendorNameSearch_txt.TextChanged += new System.EventHandler(this.VendorNameSearch_txt_TextChanged);
            this.VendorNameSearch_txt.Enter += new System.EventHandler(this.VendorNameSearch_txt_Enter);
            this.VendorNameSearch_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VendorNameSearch_txt_KeyPress);
            this.VendorNameSearch_txt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.VendorNameSearch_txt_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.ForeColor = System.Drawing.Color.Indigo;
            this.label6.Location = new System.Drawing.Point(12, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Vendor";
            // 
            // ConsignmentNumberSearch_txt
            // 
            this.ConsignmentNumberSearch_txt.FormattingEnabled = true;
            this.ConsignmentNumberSearch_txt.Location = new System.Drawing.Point(109, 63);
            this.ConsignmentNumberSearch_txt.Name = "ConsignmentNumberSearch_txt";
            this.ConsignmentNumberSearch_txt.Size = new System.Drawing.Size(121, 21);
            this.ConsignmentNumberSearch_txt.TabIndex = 1;
            this.ConsignmentNumberSearch_txt.TextChanged += new System.EventHandler(this.ConsignmentNumberSearch_txt_TextChanged);
            this.ConsignmentNumberSearch_txt.Enter += new System.EventHandler(this.ConsignmentNumberSearch_txt_Enter);
            this.ConsignmentNumberSearch_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ConsignmentNumberSearch_txt_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(11, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "Search ";
            // 
            // ConsignmentDataGridView
            // 
            this.ConsignmentDataGridView.AllowUserToAddRows = false;
            this.ConsignmentDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(90)))));
            this.ConsignmentDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ConsignmentDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ConsignmentDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.ConsignmentDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.ConsignmentDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(90)))));
            this.ConsignmentDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ConsignmentDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.ConsignmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsignmentDataGridView.Location = new System.Drawing.Point(7, 116);
            this.ConsignmentDataGridView.Name = "ConsignmentDataGridView";
            this.ConsignmentDataGridView.ReadOnly = true;
            this.ConsignmentDataGridView.Size = new System.Drawing.Size(275, 548);
            this.ConsignmentDataGridView.TabIndex = 35;
            this.ConsignmentDataGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ConsignmentDataGridView_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Consignment #";
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 27);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ConsignmentPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(190)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1344, 724);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ConsignmentPrint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Print Consignment";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Shown += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ConsignmentPrint_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.SALEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsignmentDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SALEBindingSource;
        private DataSet1 DataSet1;
        private firebirdtest.DataSets.DataSet1TableAdapters.SALETableAdapter SALETableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox VendorNameSearch_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ConsignmentNumberSearch_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView ConsignmentDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox PrintBatch_CB;
        private System.Windows.Forms.Button button2;

    }
}