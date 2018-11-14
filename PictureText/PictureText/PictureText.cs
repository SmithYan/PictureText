using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PictureText
{
    public partial class PictureText : Form
    {
        #region 事件

        public PictureText()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            try
            {
                this.pCPicture.SplitterDistance = this.sCMain.Panel1.Height / 2;
            }
            catch (Exception)
            {
            }
        }
        /// <summary>
        /// 打开Excel文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tSBOpenExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog();
        }
        /// <summary>
        /// 移除选中工作项
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tSBDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dGVShow.SelectedRows)
            {
                dGVShow.Rows.Remove(item);
            }
        }
        /// <summary>
        /// 清除所有工作项
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tSBClear_Click(object sender, EventArgs e)
        {
            dGVShow.Rows.Clear();
        }
        /// <summary>
        /// 开始工作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tSBStart_Click(object sender, EventArgs e)
        {
            All.isRun = true;
            foreach (DataGridViewRow item in dGVShow.SelectedRows)
            {
                if (All.isRun)
                {
                    pBSource.Image = Image.FromFile(All.FilePath + item.Cells["id"].Value.ToString() + ".jpg");
                    bool isFinish = AddWaterMark(All.FilePath + item.Cells["id"].Value.ToString() + ".jpg", All.FilePath + item.Cells["id"].Value.ToString() + "完毕.jpg", item.Cells["content"].Value.ToString());
                    pBOutput.Image = Image.FromFile(All.FilePath + item.Cells["id"].Value.ToString() + "完毕.jpg");
                    if (isFinish)
                    {
                        item.Cells["state"].Value = "已完成";
                    }
                }
            }
        }
        /// <summary>
        /// 暂停工作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tSBPause_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 停止工作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tSBStop_Click(object sender, EventArgs e)
        {
            All.isRun = false;
        }
        /// <summary>
        /// 打开输出文件夹
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tSSShowFile_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(All.SavePath))
            {
                OpenFile(All.SavePath);
            }
            else
            {
                MessageBox.Show("请配置输出文件夹");
            }
        }
        /// <summary>
        /// 配置输出文件夹
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tSSFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择输出文件夹";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(dialog.SelectedPath))
                {
                    MessageBox.Show(this, "文件夹路径不能为空", "提示");
                    return;
                }
                All.SavePath = dialog.SelectedPath;
                tSSLFolder.Text = All.SavePath;
            }
            else
            {
                tSSLFolder.Text = "请配置输出文件夹";
            }
        }
        /// <summary>
        /// 配置字体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tSSLFont_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = fontDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                All.font = fontDialog.Font;
                tSSLFont.Text = All.font.ToString();
            }
        }
        /// <summary>
        /// 配置字体应用按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fontDialog_Apply(object sender, EventArgs e)
        {
            All.font = fontDialog.Font;
            tSSLFont.Text = All.font.ToString();
        }
        /// <summary>
        /// 配置水印位置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tSSLLocation_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region 给图片添加水印
        /// <summary>
        /// 给图片添加水印
        /// </summary>
        /// <param name="imgPath">原图片路径</param>
        /// <param name="sImgPath">输出路径</param>
        /// <param name="content">水印文字</param>
        /// <returns>操作结果</returns>
        public bool AddWaterMark(string imgPath, string sImgPath, string content)
        {
            using (Image image = Image.FromFile(imgPath))
            {
                try
                {
                    Bitmap bitmap = new Bitmap(image);

                    int width = bitmap.Width, height = bitmap.Height;
                    Graphics g = Graphics.FromImage(bitmap);
                    g.DrawImage(bitmap, 0, 0);
                    g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                    g.DrawImage(image, new Rectangle(0, 0, width, height), 0, 0, width, height, GraphicsUnit.Pixel);
                    SizeF crSize = new SizeF();
                    crSize = g.MeasureString(content, All.font);

                    //背景位置(去掉了. 如果想用可以自己调一调 位置.)
                    //graphics.FillRectangle(new SolidBrush(Color.FromArgb(200, 255, 255, 255)), (width - crSize.Width) / 2, (height - crSize.Height) / 2, crSize.Width, crSize.Height);

                    SolidBrush semiTransBrush = new SolidBrush(fontDialog.Color);

                    //将原点移动 到图片中点
                    g.TranslateTransform(width / 2, height / 2);
                    //以原点为中心 转 -45度
                    g.RotateTransform(-45);

                    g.DrawString(content, All.font, semiTransBrush, new PointF(0, 0));
                    //保存文件
                    bitmap.Save(sImgPath, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
                catch (Exception e)
                {
                    return false;
                }
            }
            return true;
        }
        #endregion

        #region 打开文件选择对话框
        /// <summary>
        /// 打开文件选择对话框
        /// </summary>
        private void OpenFileDialog()
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Excel(*.xls)|*.xls|Excel(*.xlsx)|*.xlsx";
            openFile.CheckFileExists = true;
            openFile.RestoreDirectory = true;
            openFile.Multiselect = false;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string safeFileName = openFile.SafeFileName;
                string fileName = openFile.FileName;
                All.FileName = fileName;
                All.FilePath = fileName.Substring(0, fileName.Length - safeFileName.Length);
                All.Table = getExcelDataTable(All.FileName);
                setDGV(dGVShow);
                getPicture(All.FilePath);
            }
        }
        #endregion

        #region 操作
        private void compose(string id, string content)
        {

        }
        #endregion

        #region 给DGV添加内容
        /// <summary>
        /// 给DGV添加内容
        /// </summary>
        /// <param name="dgv"></param>
        private void setDGV(DataGridView dgv)
        {
            for (int i = 0; i < All.Table.Rows.Count; i++)
            {
                dgv.Rows.Add();
                dgv.Rows[i].Cells["id"].Value = All.Table.Rows[i]["id"].ToString();
                dgv.Rows[i].Cells["content"].Value = All.Table.Rows[i]["content"].ToString();
                dgv.Rows[i].Cells["state"].Value = "尚未开始";
            }
        }
        #endregion

        #region 获取图片
        /// <summary>
        /// 获取图片
        /// </summary>
        /// <param name="path">文件夹路径</param>
        private void getPicture(string path)
        {
            string fileName;
            for (int i = 0; i < dGVShow.RowCount; i++)
            {
                fileName = path + dGVShow.Rows[i].Cells["id"].Value.ToString().Trim() + ".jpg";
            }
            OpenFile(path);
        }
        #endregion

        #region 打开文件夹
        /// <summary>
        /// 打开文件夹
        /// </summary>
        public void OpenFile(string path)
        {
            try
            {
                System.Diagnostics.Process.Start("explorer.exe", path);
            }
            catch { }
        }
        #endregion

        #region 从Excel中获得数据表
        /// <summary>
        /// 从Excel中获得数据表
        /// </summary>
        /// <param name="path">Excel文件路径</param>
        /// <returns>获取的数据表</returns>
        private DataTable getExcelDataTable(string path)
        {
            string strConn = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + path + ";" + "Extended Properties=Excel 8.0;";
            OleDbConnection conn = new OleDbConnection(strConn);
            conn.Open();
            DataTable oleDbSchemaTable = null;
            oleDbSchemaTable = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
            string item = "sheet1$";
            if (oleDbSchemaTable != null)
            {
                foreach (DataRow row in oleDbSchemaTable.Rows)
                {
                    item = row["TABLE_NAME"].ToString();
                }
            }
            string strExcel = "select * from [" + item + "]";
            OleDbDataAdapter myCommand = new OleDbDataAdapter(strExcel, strConn);
            DataTable ds = new DataTable();
            myCommand.Fill(ds);
            myCommand.Dispose();
            conn.Dispose();
            conn.Close();
            return ds;
        }
        #endregion

        private void PictureText_Resize(object sender, EventArgs e)
        {
            try
            {
                this.pCPicture.SplitterDistance = this.sCMain.Panel1.Height / 2;
            }
            catch (Exception)
            {
            }
        }
    }
}
