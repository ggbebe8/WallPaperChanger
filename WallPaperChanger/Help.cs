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
            txtHelp.Text =  "##### ����� #####" + Environment.NewLine;
            txtHelp.Text += "1. �⺻���� ���α׷��� �����ؼ� ���ȭ�� ���� ��, '����'�� ������ ���ȭ�� �ٲ�" + Environment.NewLine;
            txtHelp.Text += "2. ������ �ȶ��� �׳� cmd���� silence�� �Ķ���ͷ� �ָ� �ٷ� �����." + Environment.NewLine;
            txtHelp.Text += "3. setting.ini ���� �ɼ������� �� ����. (����� ���������� ���� ������ �� ������ �� ���� ������ ��)" + Environment.NewLine;
            txtHelp.Text += "4. �ٸ� ���α׷��� �����Ű����, ���� �����̸��� �ٲ㼭 ���� ���� ����.(setting.ini�� �ϳ��� ������ ��)" + Environment.NewLine;
            txtHelp.Text += "5. ������ ������ �����̸����� �Ǵϱ� �����̸��� �� �������ְ�, �� ���Ͽ� ���� ��θ� ����������" + Environment.NewLine;
            txtHelp.Text += "6. �׸��� �ٸ� ���α׷��� ����~";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}