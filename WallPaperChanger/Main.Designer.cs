namespace WallPaperChanger
{
    partial class Main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnExe = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPathChange = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.rdoTile = new System.Windows.Forms.RadioButton();
            this.rdoCenter = new System.Windows.Forms.RadioButton();
            this.rdoStretch = new System.Windows.Forms.RadioButton();
            this.rdoFit = new System.Windows.Forms.RadioButton();
            this.rdoFill = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnExe
            // 
            this.btnExe.Location = new System.Drawing.Point(114, 56);
            this.btnExe.Name = "btnExe";
            this.btnExe.Size = new System.Drawing.Size(62, 23);
            this.btnExe.TabIndex = 0;
            this.btnExe.Text = "실행";
            this.btnExe.UseVisualStyleBackColor = true;
            this.btnExe.Click += new System.EventHandler(this.btnExe_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(54, 26);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(190, 21);
            this.txtPath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "경로 : ";
            // 
            // btnPathChange
            // 
            this.btnPathChange.Location = new System.Drawing.Point(250, 25);
            this.btnPathChange.Name = "btnPathChange";
            this.btnPathChange.Size = new System.Drawing.Size(62, 23);
            this.btnPathChange.TabIndex = 3;
            this.btnPathChange.Text = "변경";
            this.btnPathChange.UseVisualStyleBackColor = true;
            this.btnPathChange.Click += new System.EventHandler(this.btnPathChange_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(182, 56);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(62, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(250, 56);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(62, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "종료";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(12, 56);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(21, 23);
            this.btnHelp.TabIndex = 6;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // rdoTile
            // 
            this.rdoTile.AutoSize = true;
            this.rdoTile.Location = new System.Drawing.Point(13, 6);
            this.rdoTile.Name = "rdoTile";
            this.rdoTile.Size = new System.Drawing.Size(44, 16);
            this.rdoTile.TabIndex = 7;
            this.rdoTile.TabStop = true;
            this.rdoTile.Text = "Tile";
            this.rdoTile.UseVisualStyleBackColor = true;
            // 
            // rdoCenter
            // 
            this.rdoCenter.AutoSize = true;
            this.rdoCenter.Location = new System.Drawing.Point(69, 6);
            this.rdoCenter.Name = "rdoCenter";
            this.rdoCenter.Size = new System.Drawing.Size(60, 16);
            this.rdoCenter.TabIndex = 8;
            this.rdoCenter.TabStop = true;
            this.rdoCenter.Text = "Center";
            this.rdoCenter.UseVisualStyleBackColor = true;
            // 
            // rdoStretch
            // 
            this.rdoStretch.AutoSize = true;
            this.rdoStretch.Location = new System.Drawing.Point(142, 6);
            this.rdoStretch.Name = "rdoStretch";
            this.rdoStretch.Size = new System.Drawing.Size(62, 16);
            this.rdoStretch.TabIndex = 9;
            this.rdoStretch.TabStop = true;
            this.rdoStretch.Text = "Stretch";
            this.rdoStretch.UseVisualStyleBackColor = true;
            // 
            // rdoFit
            // 
            this.rdoFit.AutoSize = true;
            this.rdoFit.Location = new System.Drawing.Point(217, 6);
            this.rdoFit.Name = "rdoFit";
            this.rdoFit.Size = new System.Drawing.Size(36, 16);
            this.rdoFit.TabIndex = 10;
            this.rdoFit.TabStop = true;
            this.rdoFit.Text = "Fit";
            this.rdoFit.UseVisualStyleBackColor = true;
            // 
            // rdoFill
            // 
            this.rdoFill.AutoSize = true;
            this.rdoFill.Location = new System.Drawing.Point(270, 6);
            this.rdoFill.Name = "rdoFill";
            this.rdoFill.Size = new System.Drawing.Size(39, 16);
            this.rdoFill.TabIndex = 11;
            this.rdoFill.TabStop = true;
            this.rdoFill.Text = "Fill";
            this.rdoFill.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 88);
            this.Controls.Add(this.rdoFill);
            this.Controls.Add(this.rdoFit);
            this.Controls.Add(this.rdoStretch);
            this.Controls.Add(this.rdoCenter);
            this.Controls.Add(this.rdoTile);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPathChange);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnExe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Main";
            this.Text = "WallPaperChanger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExe;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPathChange;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.RadioButton rdoTile;
        private System.Windows.Forms.RadioButton rdoCenter;
        private System.Windows.Forms.RadioButton rdoStretch;
        private System.Windows.Forms.RadioButton rdoFit;
        private System.Windows.Forms.RadioButton rdoFill;
    }
}

