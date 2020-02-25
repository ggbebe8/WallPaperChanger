using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;



namespace WallPaperChanger
{
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();
            mfnInitCon();
        }



        #region 함수


        //컨트롤 초기화
        private void mfnInitCon()
        {
            string[] strLocation = System.Reflection.Assembly.GetExecutingAssembly().Location.Split('\\');
            txtPath.Text = Utility.ReadIniFile(strLocation[strLocation.Length - 1], "PATH", @".\setting.ini");
            string strStyle = Utility.ReadIniFile(strLocation[strLocation.Length - 1], "STYLE", @".\setting.ini");
            switch (strStyle) 
            {
                case "Tile":
                    rdoTile.Checked = true;
                    break;
                case "Center":
                    rdoCenter.Checked = true;
                    break;
                case "Stretch":
                    rdoStretch.Checked = true;
                    break;
                case "Fit":
                    rdoFit.Checked = true;
                    break;
                default :
                    rdoFill.Checked = true;
                    break;

            }
        }
        #endregion 함수_End

        #region 이벤트
        private void btnExe_Click(object sender, EventArgs e)
        {
            Utility.Style St = rdoTile.Checked ? Utility.Style.Tiled
                                : rdoCenter.Checked ? Utility.Style.Centered
                                : rdoStretch.Checked ? Utility.Style.Stretched
                                : rdoFit.Checked ? Utility.Style.Fit : Utility.Style.Fill;
            Utility.mfnWallPaperSet(txtPath.Text, St);
        }

        private void btnPathChange_Click(object sender, EventArgs e)
        {
            OpenFileDialog OF = new OpenFileDialog();
            OF.InitialDirectory = txtPath.Text;
            OF.Filter = "그림파일|*.jpeg;*.png;*.gif;*.jpg";
            //OF.InitialDirectory = @"C:\";
            if (OF.ShowDialog() == DialogResult.OK)
            {
                txtPath.Clear();
                txtPath.Text = OF.FileName;
            }
        }

        //경로저장
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string[] strLocation = System.Reflection.Assembly.GetExecutingAssembly().Location.Split('\\');
                Utility.WriteIniFile(strLocation[strLocation.Length - 1], "PATH", txtPath.Text, @".\setting.ini");
                Utility.WriteIniFile(strLocation[strLocation.Length - 1], "STYLE", rdoTile.Checked ? "Tile" 
                                                                                : rdoCenter.Checked ? "Center"
                                                                                : rdoStretch.Checked ? "Stretch"
                                                                                : rdoFit.Checked ? "Fit" : "Fill", @".\setting.ini");
                MessageBox.Show("저장완료");
            }
            catch(Exception exc)
            {
                MessageBox.Show("저장실패 : " + exc.Message);
            }
        }

        //종료
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //헬프창 열기
        private void btnHelp_Click(object sender, EventArgs e)
        {
            Help HE = new Help();
            HE.StartPosition = FormStartPosition.CenterParent;
            HE.ShowDialog();
        }

        #endregion 이벤트_End





    }

    






}