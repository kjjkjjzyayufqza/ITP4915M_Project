using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;//Trace.WriteLine
using System.Net;
using System.Threading;

namespace DarkDemo
{
    public partial class EGG : Form
    {
        private String[] link = { "https://pic2.zhimg.com/v2-b765593ca02730856f35fe36339baee9_r.jpg", 
            "https://pic4.zhimg.com/v2-0c43b96426fb7fff7476a9291d819273_r.jpg", "https://pic3.zhimg.com/80/v2-d010d463773f2914444ddd981393f596_720w.jpg",
            "https://i.redd.it/cuvhajvjlwn51.png" ,"https://cdn.unwire.hk/wp-content/uploads/2016/09/itdog-1280x800.png"
            ,"https://code-love.com/wp-content/uploads/2019/04/latsyqzaqnq21.jpg"
            ,"https://external-preview.redd.it/Jy6TzYfcPAaa9QQ4zUIQNhs14DlmOy5LwZlHXSRz1G4.jpg?auto=webp&s=00db864d7ea4edece24511e3cc43366ac923ad31"
            ,"https://i.pinimg.com/originals/4f/82/8d/4f828d05f82b8b7aedfe8be6a7d9d2a3.png","https://pbs.twimg.com/media/ERdshUnU0AATwud.jpg","https://memeprod.sgp1.digitaloceanspaces.com/user-wtf/1619274590863.jpg"
        ,"https://memeprod.sgp1.digitaloceanspaces.com/user-wtf/1605238506098.jpg","https://pic1.zhimg.com/50/v2-62b77ef19edd67ecb90a1d24f47580c3_hd.jpg?source=1940ef5c",
        "https://media1.tenor.com/images/c9cc4b5e02fda35172506eab265f4451/tenor.gif","https://images3.memedroid.com/images/UPLOADED793/5b4f049b3a976.jpeg","https://programming-memes.com/wp-content/uploads/2020/12/4pj8us.jpg",
        "https://pbs.twimg.com/media/D5UF1prWsAA-kBy.jpg","https://memeprod.sgp1.digitaloceanspaces.com/user-wtf/1623230830773.jpg","https://memeprod.sgp1.digitaloceanspaces.com/user-wtf/1623149214083.jpg",
        "https://memeprod.sgp1.digitaloceanspaces.com/user-wtf/1623216732028.jpg","https://pbs.twimg.com/media/EnBPnYjXcAAk3jn?format=jpg&name=small",
        "https://preview.redd.it/520hz0cgh8471.jpg?width=960&crop=smart&auto=webp&s=21d5bc1f6450d645c7b8914506eef04204b50752","https://i.redd.it/h1r41wmwt1371.png",
        "https://pbs.twimg.com/media/EhEDgkhX0AEFkaq?format=jpg&name=large","https://i.pinimg.com/564x/ef/fb/34/effb3483f895c061c6cbab64eccfa13a.jpg","https://i.pinimg.com/564x/a6/44/36/a64436cd22370daabbc1fd526b912f45.jpg",
        "https://nimg.ws.126.net/?url=http%3A%2F%2Fdingyue.ws.126.net%2F2021%2F0605%2F48dc522dj00qu7uo50019c000ng00s7c.jpg&thumbnail=650x2147483647&quality=80&type=jpg","https://pic2.zhimg.com/v2-28b40189e48ac6ee156aca3c53a04ef2_720w.jpg?source=172ae18b",
        "http://inews.gtimg.com/newsapp_match/0/13552073386/0"};

        public EGG()
        {
            InitializeComponent();
        }

        private void EGG_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int max = 0;
            for (int i = 0; i < link.Length; i++)
            {
                max = i;

            }

            int num = r.Next(0, max);
            //MessageBox.Show("now is "+ num);
            Encoding encode = Encoding.GetEncoding("utf-8");
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(new Uri(link[num]));
            req.Method = "GET";
            req.UserAgent = " Mozilla/5.0 (Windows NT 6.3; Trident/7.0; rv:11.0) like Gecko";
            //req.ContentType = "application/x-www-form-urlencoded";
            req.Accept = "image/png, image/svg+xml, image/*;q=0.8, */*;q=0.5";
            req.Headers.Add("X-HttpWatch-RID", " 46990-10314");
            req.Headers.Add("Accept-Language", "zh-Hans-CN,zh-Hans;q=0.8,en-US;q=0.5,en;q=0.3");

            HttpWebResponse ress = (HttpWebResponse)req.GetResponse();
            Stream sstreamRes = ress.GetResponseStream();
            pictureBox1.Image = System.Drawing.Image.FromStream(sstreamRes);
        }

            private void button1_Click_1(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "/../../../image/1.jpg");
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(PlayThread));
            thread.Start();

        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {

            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                Thread thread = new Thread(new ThreadStart(PlayThread));
                thread.Start();
            }

        }
        private void PlayThread()
        {
            //axWindowsMediaPlayer1.URL = (Application.StartupPath + "music\\1.mp3");
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        public static void CreateFixedSizeFile(string fileName, long fileSize)
        {
            //验证参数 
            if (string.IsNullOrEmpty(fileName) || new[] { Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar }.Contains(
                fileName[fileName.Length - 1]))
                throw new ArgumentException("fileName");
            if (fileSize < 0) throw new ArgumentException("fileSize");
            //创建目录 
            string dir = Path.GetDirectoryName(fileName);
            if (!string.IsNullOrEmpty(dir) && !Directory.Exists(dir))
                Directory.CreateDirectory(dir);
            //创建文件 
            FileStream fs = null;
            try
            {
                fs = new FileStream(fileName, FileMode.Create);
                fs.SetLength(fileSize); //设置文件大小 
            }
            catch
            {
                if (fs != null)
                {
                    fs.Close();
                    File.Delete(fileName); //注意，若由fs.SetLength方法产生了异常，同样会执行删除命令，请慎用overwrite:true参数，或者修改删除文件代码。 
                }
                throw;
            }
            finally
            {
                if (fs != null) fs.Close();
            }
        }

    }
}
