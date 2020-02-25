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

        //배경화면 변경
        public static void mfnWallPaperSet(string p_paper, Style style)
        {

            //System.Drawing.Image img = Properties.Resources.login;
            string tempPath = p_paper;//Path.Combine(@"C:\Users\you\Desktop 2", "캡처.PNG");
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

        #region ini컨트롤

        /* .ini파일 쓰는 함수
         * string section : [section]
         * string key : 값의 키(val의 key)
         * string val : 키의 값(key의 val)
         * filePath : 쓸 ini 파일경로
         */
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        /* .ini파일 읽는 함수
         * string section : 가져올 값의 키가 속해있는 섹션이름
         * string key : 가져올 값의 키 이름
         * string def : 키의 값이 없을 경우 기본값(default)
         * StringBuilder retVal : 가져올 값
         * int size : 가져올 값의 길이
         * string filePath : 읽어올 ini 파일경로
         * 
         * return value : 읽어들여온 데이터 길이
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

        /* 정석사용예시 
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //ini 쓰기
            WritePrivateProfileString("LOGIN", "ID", "test", "C:\\login.ini");
            WritePrivateProfileString("LOGIN", "PW", "1234", "C:\\login.ini");
            StringBuilder retId = new StringBuilder();
            StringBuilder retPw = new StringBuilder();

            //ini 읽기
            GetPrivateProfileString("LOGIN", "ID", "(NONE)", retId, 32, "C:\\login.ini");
            GetPrivateProfileString("LOGIN", "PW", "(NONE)", retPw, 32, "C:\\login.ini");
          
            MessageBox.Show("ID :"+ retId.ToString()+",PW: "+ retPw.ToString());
        }
        */
        #endregion ini컨트롤_End
    }
}
