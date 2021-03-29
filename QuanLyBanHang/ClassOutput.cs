using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;
using System.Windows.Forms;
namespace QuanLyBanHang
{
    class ClassOutput
    {
        public void  OutputExcel(DataGridView data,String duongdan,String tentep)
        {
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;
            for(int i=1;i<data.Columns.Count;i++)
            {
                obj.Cells[1, i] = data.Columns[i - 1].HeaderText;
            }
            for(int i=0;i<data.Rows.Count;i++)
            {
                for(int j=0;j<data.Columns.Count;j++)
                {
                    if(data.Rows[i].Cells[j].Value!= null)
                    {
                        obj.Cells[i + 2, j + 1] = data.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            obj.ActiveWorkbook.SaveCopyAs(duongdan + tentep + ".xlsx");
            obj.ActiveWorkbook.Saved = true;
        }
    }
}
