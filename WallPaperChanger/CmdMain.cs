using System;
using System.Collections.Generic;
using System.Text;

namespace WallPaperChanger
{
    class CmdMain
    {
        public CmdMain(string p_Mod)
        {
            if (p_Mod.ToLower() == "silence")
            {
                string[] strLocation = System.Reflection.Assembly.GetExecutingAssembly().Location.Split('\\');
                string strPath = Utility.ReadIniFile(strLocation[strLocation.Length - 1], "PATH", @".\setting.ini");
                string strStyle = Utility.ReadIniFile(strLocation[strLocation.Length - 1], "STYLE", @".\setting.ini");
                Utility.Style St;
                switch (strStyle) 
                {
                    case "Tile":
                        St = Utility.Style.Tiled;
                        break;
                    case "Center":
                        St = Utility.Style.Centered;
                        break;
                    case "Stretch":
                        St = Utility.Style.Stretched;
                        break;
                    case "Fit":
                        St = Utility.Style.Fit;
                        break;
                    default :
                        St = Utility.Style.Fill;
                        break;

                }
                Utility.mfnWallPaperSet(strPath, St);
            }
        }
    }
}
