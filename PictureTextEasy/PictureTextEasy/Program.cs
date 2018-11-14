using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace PictureTextEasy
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Environment.CurrentDirectory;
            string[] files = Directory.GetFiles(path + @"\", "*.xls");
            Model model = new Model();
            model.dt = model.getExcelDataTable(files[0]);
            for (int i = 0; i < model.dt.Rows.Count; i++)
            {
                bool isFinish = model.AddWaterMark(path +"//"+ model.dt.Rows[i]["id"].ToString() + ".jpg", path+"//" + model.dt.Rows[i]["id"].ToString() + "完毕.jpg", model.dt.Rows[i]["content"].ToString());
                if (isFinish)
                {
                    Console.WriteLine(model.dt.Rows[i]["id"].ToString() + "操作成功");
                }
                else
                {
                    Console.WriteLine(model.dt.Rows[i]["id"].ToString() + "操作失败");
                }
            }
            Console.WriteLine("全部执行完毕");
        }
    }
}
