using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PictureTextEasy
{
    class Model
    {
        public  DataTable dt;
        #region 从Excel中获得数据表
        /// <summary>
        /// 从Excel中获得数据表
        /// </summary>
        /// <param name="path">Excel文件路径</param>
        /// <returns>获取的数据表</returns>
        public DataTable getExcelDataTable(string path)
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
        #region 给图片添加水印
        /// <summary>
        /// 添加水印
        /// </summary>
        /// <param name="imgPath">原图片地址</param>
        /// <param name="sImgPath">水印图片地址</param>
        /// <returns>resMsg[0] 成功,失败 </returns>
        public bool AddWaterMark(string imgPath, string sImgPath,string content)
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

                    Font crFont = new Font("微软雅黑", 120, FontStyle.Bold);
                    SizeF crSize = new SizeF();
                    crSize = g.MeasureString(content, crFont);

                    //背景位置(去掉了. 如果想用可以自己调一调 位置.)
                    //graphics.FillRectangle(new SolidBrush(Color.FromArgb(200, 255, 255, 255)), (width - crSize.Width) / 2, (height - crSize.Height) / 2, crSize.Width, crSize.Height);

                    SolidBrush semiTransBrush = new SolidBrush(Color.Red);

                    //将原点移动 到图片中点
                    g.TranslateTransform(width / 2, height / 2);
                    //以原点为中心 转 -45度
                    g.RotateTransform(-45);

                    g.DrawString(content, crFont, semiTransBrush, new PointF(0, 0));

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
    }
}
