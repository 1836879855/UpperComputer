namespace NPOI
{
    partial class OperatExcel
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddSheet = new System.Windows.Forms.Button();
            this.btnAddColumn = new System.Windows.Forms.Button();
            this.btnAddCell = new System.Windows.Forms.Button();
            this.btnAddWorkBook = new System.Windows.Forms.Button();
            this.btnAddRow = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReadSheet = new System.Windows.Forms.Button();
            this.saveAsExcel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddSheet
            // 
            this.btnAddSheet.Location = new System.Drawing.Point(133, 52);
            this.btnAddSheet.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.btnAddSheet.Name = "btnAddSheet";
            this.btnAddSheet.Size = new System.Drawing.Size(117, 41);
            this.btnAddSheet.TabIndex = 0;
            this.btnAddSheet.Text = "添加一个表";
            this.btnAddSheet.UseVisualStyleBackColor = true;
            this.btnAddSheet.Click += new System.EventHandler(this.btnAddSheet_Click);
            // 
            // btnAddColumn
            // 
            this.btnAddColumn.Location = new System.Drawing.Point(393, 52);
            this.btnAddColumn.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.btnAddColumn.Name = "btnAddColumn";
            this.btnAddColumn.Size = new System.Drawing.Size(117, 41);
            this.btnAddColumn.TabIndex = 1;
            this.btnAddColumn.Text = "添加一列";
            this.btnAddColumn.UseVisualStyleBackColor = true;
            this.btnAddColumn.Click += new System.EventHandler(this.btnAddColumn_Click);
            // 
            // btnAddCell
            // 
            this.btnAddCell.Location = new System.Drawing.Point(521, 52);
            this.btnAddCell.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.btnAddCell.Name = "btnAddCell";
            this.btnAddCell.Size = new System.Drawing.Size(117, 41);
            this.btnAddCell.TabIndex = 2;
            this.btnAddCell.Text = "添加单元格";
            this.btnAddCell.UseVisualStyleBackColor = true;
            this.btnAddCell.Click += new System.EventHandler(this.btnAddCell_Click);
            // 
            // btnAddWorkBook
            // 
            this.btnAddWorkBook.Location = new System.Drawing.Point(5, 52);
            this.btnAddWorkBook.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.btnAddWorkBook.Name = "btnAddWorkBook";
            this.btnAddWorkBook.Size = new System.Drawing.Size(117, 41);
            this.btnAddWorkBook.TabIndex = 3;
            this.btnAddWorkBook.Text = "添加工作薄";
            this.btnAddWorkBook.UseVisualStyleBackColor = true;
            this.btnAddWorkBook.Click += new System.EventHandler(this.btnAddWorkBook_Click);
            // 
            // btnAddRow
            // 
            this.btnAddRow.Location = new System.Drawing.Point(261, 52);
            this.btnAddRow.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.btnAddRow.Name = "btnAddRow";
            this.btnAddRow.Size = new System.Drawing.Size(117, 41);
            this.btnAddRow.TabIndex = 4;
            this.btnAddRow.Text = "添加一行";
            this.btnAddRow.UseVisualStyleBackColor = true;
            this.btnAddRow.Click += new System.EventHandler(this.btnAddRow_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReadSheet);
            this.groupBox1.Controls.Add(this.saveAsExcel);
            this.groupBox1.Controls.Add(this.btnAddWorkBook);
            this.groupBox1.Controls.Add(this.btnAddSheet);
            this.groupBox1.Controls.Add(this.btnAddRow);
            this.groupBox1.Controls.Add(this.btnAddColumn);
            this.groupBox1.Controls.Add(this.btnAddCell);
            this.groupBox1.Location = new System.Drawing.Point(94, 466);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(948, 121);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // btnReadSheet
            // 
            this.btnReadSheet.Location = new System.Drawing.Point(767, 52);
            this.btnReadSheet.Name = "btnReadSheet";
            this.btnReadSheet.Size = new System.Drawing.Size(117, 41);
            this.btnReadSheet.TabIndex = 8;
            this.btnReadSheet.Text = "读取表";
            this.btnReadSheet.UseVisualStyleBackColor = true;
            this.btnReadSheet.Click += new System.EventHandler(this.btnReadSheet_Click);
            // 
            // saveAsExcel
            // 
            this.saveAsExcel.Location = new System.Drawing.Point(644, 52);
            this.saveAsExcel.Name = "saveAsExcel";
            this.saveAsExcel.Size = new System.Drawing.Size(117, 41);
            this.saveAsExcel.TabIndex = 7;
            this.saveAsExcel.Text = "保存表";
            this.saveAsExcel.UseVisualStyleBackColor = true;
            this.saveAsExcel.Click += new System.EventHandler(this.saveAsExcel_Click);
            // 
            // OperatExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 643);
            this.Controls.Add(this.groupBox1);
            this.Name = "OperatExcel";
            this.Text = "1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddSheet;
        private System.Windows.Forms.Button btnAddColumn;
        private System.Windows.Forms.Button btnAddCell;
        private System.Windows.Forms.Button btnAddWorkBook;
        private System.Windows.Forms.Button btnAddRow;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReadSheet;
        private System.Windows.Forms.Button saveAsExcel;
    }
}

