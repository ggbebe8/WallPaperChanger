using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WallPaperChanger
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
            txtHelp.Text =  "##### 사용방법 #####" + Environment.NewLine;
            txtHelp.Text += "1. 기본적인 프로그램은 실행해서 배경화면 선택 후, '실행'을 누르면 배경화면 바뀜" + Environment.NewLine;
            txtHelp.Text += "2. 디자인 안띄우고 그냥 cmd에서 silence를 파라미터로 주면 바로 실행됨." + Environment.NewLine;
            txtHelp.Text += "3. setting.ini 에는 옵션정보가 들어가 있음. (참고로 실행파일이 여러 개더라도 한 폴더에 한 개만 있으면 됨)" + Environment.NewLine;
            txtHelp.Text += "4. 다른 프로그램에 적용시키려면, 실행 파일이름을 바꿔서 여러 개로 만듦.(setting.ini는 하나만 있으면 돼)" + Environment.NewLine;
            txtHelp.Text += "5. 설정의 저장은 파일이름으로 되니까 파일이름만 잘 조정해주고, 각 파일에 들어가서 경로를 설정해주자" + Environment.NewLine;
            txtHelp.Text += "6. 그리고 다른 프로그램에 연결~";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}