using System;
using System.Windows.Forms;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System.IO;
using NPOI.Util;
using SixLabors.Fonts;
using NPOI.OpenXmlFormats.Spreadsheet;

namespace NPOI
{
    public partial class OperatExcel : Form
    {
        public OperatExcel()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 添加一个工作本
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddWorkBook_Click(object sender, EventArgs e)
        {
            using (IWorkbook workbook = new XSSFWorkbook())
            {
                ISheet sheet = workbook.CreateSheet();
                IRow row = sheet.CreateRow(0);
                ICell cell = row.CreateCell(5);
                cell.SetCellValue("value");
                //ICellStyle cellStyle = workbook.CreateCellStyle();
                //IFont font = workbook.CreateFont();
                //font.IsItalic = true;
                //font.Color = (short)FontColor.Red;
                //cellStyle.SetFont(font);
                //cell.CellStyle= cellStyle;
                using (FileStream fs = new FileStream(@"D:\Test.xlsx", FileMode.Create, FileAccess.Write))
                {
                    workbook.Write(fs);
                }
            }
        }

        private void btnAddSheet_Click(object sender, EventArgs e)
        {

        }
        private void btnAddRow_Click(object sender, EventArgs e)
        {

        }

        private void btnAddColumn_Click(object sender, EventArgs e)
        {

        }

        private void btnAddCell_Click(object sender, EventArgs e)
        {

        }

        private void saveAsExcel_Click(object sender, EventArgs e)
        {

        }

        private void btnReadSheet_Click(object sender, EventArgs e)
        {
            var path = @"D:\Test.xlsx";
            IWorkbook wk = new XSSFWorkbook(path);
            ISheet st= wk.GetSheetAt(0);
            if (st != null)
            {
                var v=st.GetRow(0).GetCell(5).StringCellValue;
                st.GetRow(0).GetCell(5).SetCellValue("你好");
                IRow r = st.CreateRow(1);
                ICell c = r.CreateCell(7);
                c.SetCellValue("你好啊！");
            }
            wk.Dispose();
        }
    }
}
