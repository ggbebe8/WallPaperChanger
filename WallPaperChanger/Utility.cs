using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.IO;
namespace WallPaperChanger
{
    class Utility
    {
        const int SPI_SETDESKWALLPAPER = 20;
        const int SPIF_UPDATEINIFILE = 0x01;
        const int SPIF_SENDWININICHANGE = 0x02;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

        public enum Style : int
        {
            Tiled,
            Centered,
            Stretched,
            Fit,
            Fill
        }

        //���ȭ�� ����
        public static void mfnWallPaperSet(string p_paper, Style style)
        {

            //System.Drawing.Image img = Properties.Resources.login;
            string tempPath = p_paper;//Path.Combine(@"C:\Users\you\Desktop 2", "ĸó.PNG");
            //img.Save(tempPath, System.Drawing.Imaging.ImageFormat.Bmp);

            Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop", true);
            if (style == Style.Stretched)
            {
                key.SetValue(@"WallpaperStyle", 2.ToString());
                key.SetValue(@"TileWallpaper", 0.ToString());
            }
            if (style == Style.Centered)
            {
                key.SetValue(@"WallpaperStyle", 1.ToString());
                key.SetValue(@"TileWallpaper", 0.ToString());
            }
            if (style == Style.Tiled)
            {
                key.SetValue(@"WallpaperStyle", 1.ToString());
                key.SetValue(@"TileWallpaper", 1.ToString());
            }
            if (style == Style.Fit)
            {
                key.SetValue(@"WallpaperStyle", 6.ToString());
                key.SetValue(@"TileWallpaper", 0.ToString());
            }
            if (style == Style.Fill)
            {
                key.SetValue(@"WallpaperStyle", 10.ToString());
                key.SetValue(@"TileWallpaper", 0.ToString());
            }
            try
            {
                SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, tempPath, SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);
            }
            catch (Exception e)
            { }
        }

        #region ini��Ʈ��

        /* .ini���� ���� �Լ�
         * string section : [section]
         * string key : ���� Ű(val�� key)
         * string val : Ű�� ��(key�� val)
         * filePath : �� ini ���ϰ��
         */
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        /* .ini���� �д� �Լ�
         * string section : ������ ���� Ű�� �����ִ� �����̸�
         * string key : ������ ���� Ű �̸�
         * string def : Ű�� ���� ���� ��� �⺻��(default)
         * StringBuilder retVal : ������ ��
         * int size : ������ ���� ����
         * string filePath : �о�� ini ���ϰ��
         * 
         * return value : �о�鿩�� ������ ����
         */
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);


        public static void WriteIniFile(string section, string key, string value, string path)
        {
            WritePrivateProfileString(section, key, value, path);
        }

        public static string ReadIniFile(string section, string key, string path)
        {
            StringBuilder sb = new StringBuilder(255);
            GetPrivateProfileString(section, key, "", sb, sb.Capacity, path);
            return sb.ToString();
        }

        /* ������뿹�� 
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //ini ����
            WritePrivateProfileString("LOGIN", "ID", "test", "C:\\login.ini");
            WritePrivateProfileString("LOGIN", "PW", "1234", "C:\\login.ini");
            StringBuilder retId = new StringBuilder();
            StringBuilder retPw = new StringBuilder();

            //ini �б�
            GetPrivateProfileString("LOGIN", "ID", "(NONE)", retId, 32, "C:\\login.ini");
            GetPrivateProfileString("LOGIN", "PW", "(NONE)", retPw, 32, "C:\\login.ini");
          
            MessageBox.Show("ID :"+ retId.ToString()+",PW: "+ retPw.ToString());
        }
        */
        #endregion ini��Ʈ��_End
    }
}
