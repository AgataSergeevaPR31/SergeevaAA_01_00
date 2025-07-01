namespace SergeevaAA_01_00
{
    partial class SergeevaAA_01_00
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbWidth = new System.Windows.Forms.TextBox();
            this.tbLength = new System.Windows.Forms.TextBox();
            this.tbMass = new System.Windows.Forms.TextBox();
            this.tbMonth = new System.Windows.Forms.TextBox();
            this.width = new System.Windows.Forms.Label();
            this.length = new System.Windows.Forms.Label();
            this.mass = new System.Windows.Forms.Label();
            this.month = new System.Windows.Forms.Label();
            this.RoadWorkList = new System.Windows.Forms.ListBox();
            this.AddBaseWork = new System.Windows.Forms.Button();
            this.AddSeasonWork = new System.Windows.Forms.Button();
            this.baseInfo = new System.Windows.Forms.Label();
            this.childInfo = new System.Windows.Forms.Label();
            this.SeasonWorkList = new System.Windows.Forms.ListBox();
            this.removeBase = new System.Windows.Forms.Button();
            this.removeChild = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbWidth
            // 
            this.tbWidth.Location = new System.Drawing.Point(128, 16);
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(100, 22);
            this.tbWidth.TabIndex = 0;
            // 
            // tbLength
            // 
            this.tbLength.Location = new System.Drawing.Point(128, 44);
            this.tbLength.Name = "tbLength";
            this.tbLength.Size = new System.Drawing.Size(100, 22);
            this.tbLength.TabIndex = 1;
            // 
            // tbMass
            // 
            this.tbMass.Location = new System.Drawing.Point(232, 77);
            this.tbMass.Name = "tbMass";
            this.tbMass.Size = new System.Drawing.Size(100, 22);
            this.tbMass.TabIndex = 2;
            // 
            // tbMonth
            // 
            this.tbMonth.Location = new System.Drawing.Point(128, 152);
            this.tbMonth.Name = "tbMonth";
            this.tbMonth.Size = new System.Drawing.Size(100, 22);
            this.tbMonth.TabIndex = 3;
            // 
            // width
            // 
            this.width.AutoSize = true;
            this.width.Location = new System.Drawing.Point(12, 19);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(110, 16);
            this.width.TabIndex = 4;
            this.width.Text = "Ширина дороги:";
            // 
            // length
            // 
            this.length.AutoSize = true;
            this.length.Location = new System.Drawing.Point(12, 48);
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(100, 16);
            this.length.TabIndex = 5;
            this.length.Text = "Длина дороги:";
            // 
            // mass
            // 
            this.mass.AutoSize = true;
            this.mass.Location = new System.Drawing.Point(13, 80);
            this.mass.Name = "mass";
            this.mass.Size = new System.Drawing.Size(190, 16);
            this.mass.TabIndex = 6;
            this.mass.Text = "Масса дорожного покрытия:";
            // 
            // month
            // 
            this.month.AutoSize = true;
            this.month.Location = new System.Drawing.Point(13, 155);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(103, 16);
            this.month.TabIndex = 7;
            this.month.Text = "Номер месяца:";
            // 
            // RoadWorkList
            // 
            this.RoadWorkList.FormattingEnabled = true;
            this.RoadWorkList.ItemHeight = 16;
            this.RoadWorkList.Location = new System.Drawing.Point(358, 19);
            this.RoadWorkList.Name = "RoadWorkList";
            this.RoadWorkList.Size = new System.Drawing.Size(929, 164);
            this.RoadWorkList.TabIndex = 8;
            // 
            // AddBaseWork
            // 
            this.AddBaseWork.Location = new System.Drawing.Point(35, 116);
            this.AddBaseWork.Name = "AddBaseWork";
            this.AddBaseWork.Size = new System.Drawing.Size(259, 23);
            this.AddBaseWork.TabIndex = 9;
            this.AddBaseWork.Text = "Добавление базового объекта";
            this.AddBaseWork.UseVisualStyleBackColor = true;
            this.AddBaseWork.Click += new System.EventHandler(this.AddBaseWork_Click);
            // 
            // AddSeasonWork
            // 
            this.AddSeasonWork.Location = new System.Drawing.Point(16, 190);
            this.AddSeasonWork.Name = "AddSeasonWork";
            this.AddSeasonWork.Size = new System.Drawing.Size(259, 23);
            this.AddSeasonWork.TabIndex = 10;
            this.AddSeasonWork.Text = "Добавление сезонного объекта";
            this.AddSeasonWork.UseVisualStyleBackColor = true;
            this.AddSeasonWork.Click += new System.EventHandler(this.AddSeasonWork_Click);
            // 
            // baseInfo
            // 
            this.baseInfo.AutoSize = true;
            this.baseInfo.Location = new System.Drawing.Point(9, 397);
            this.baseInfo.Name = "baseInfo";
            this.baseInfo.Size = new System.Drawing.Size(59, 16);
            this.baseInfo.TabIndex = 11;
            this.baseInfo.Text = "baseInfo";
            // 
            // childInfo
            // 
            this.childInfo.AutoSize = true;
            this.childInfo.Location = new System.Drawing.Point(9, 425);
            this.childInfo.Name = "childInfo";
            this.childInfo.Size = new System.Drawing.Size(56, 16);
            this.childInfo.TabIndex = 12;
            this.childInfo.Text = "childInfo";
            // 
            // SeasonWorkList
            // 
            this.SeasonWorkList.FormattingEnabled = true;
            this.SeasonWorkList.ItemHeight = 16;
            this.SeasonWorkList.Location = new System.Drawing.Point(358, 218);
            this.SeasonWorkList.Name = "SeasonWorkList";
            this.SeasonWorkList.Size = new System.Drawing.Size(929, 164);
            this.SeasonWorkList.TabIndex = 13;
            // 
            // removeBase
            // 
            this.removeBase.Location = new System.Drawing.Point(1139, 189);
            this.removeBase.Name = "removeBase";
            this.removeBase.Size = new System.Drawing.Size(148, 23);
            this.removeBase.TabIndex = 14;
            this.removeBase.Text = "Удалить базовый ";
            this.removeBase.UseVisualStyleBackColor = true;
            this.removeBase.Click += new System.EventHandler(this.removeBase_Click);
            // 
            // removeChild
            // 
            this.removeChild.Location = new System.Drawing.Point(1139, 394);
            this.removeChild.Name = "removeChild";
            this.removeChild.Size = new System.Drawing.Size(148, 23);
            this.removeChild.TabIndex = 15;
            this.removeChild.Text = "Удалить сезонный";
            this.removeChild.UseVisualStyleBackColor = true;
            this.removeChild.Click += new System.EventHandler(this.removeChild_Click);
            // 
            // SergeevaAA_01_00
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 450);
            this.Controls.Add(this.removeChild);
            this.Controls.Add(this.removeBase);
            this.Controls.Add(this.SeasonWorkList);
            this.Controls.Add(this.childInfo);
            this.Controls.Add(this.baseInfo);
            this.Controls.Add(this.AddSeasonWork);
            this.Controls.Add(this.AddBaseWork);
            this.Controls.Add(this.RoadWorkList);
            this.Controls.Add(this.month);
            this.Controls.Add(this.mass);
            this.Controls.Add(this.length);
            this.Controls.Add(this.width);
            this.Controls.Add(this.tbMonth);
            this.Controls.Add(this.tbMass);
            this.Controls.Add(this.tbLength);
            this.Controls.Add(this.tbWidth);
            this.Name = "SergeevaAA_01_00";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbWidth;
        private System.Windows.Forms.TextBox tbLength;
        private System.Windows.Forms.TextBox tbMass;
        private System.Windows.Forms.TextBox tbMonth;
        private System.Windows.Forms.Label width;
        private System.Windows.Forms.Label length;
        private System.Windows.Forms.Label mass;
        private System.Windows.Forms.Label month;
        private System.Windows.Forms.ListBox RoadWorkList;
        private System.Windows.Forms.Button AddBaseWork;
        private System.Windows.Forms.Button AddSeasonWork;
        private System.Windows.Forms.Label baseInfo;
        private System.Windows.Forms.Label childInfo;
        private System.Windows.Forms.ListBox SeasonWorkList;
        private System.Windows.Forms.Button removeBase;
        private System.Windows.Forms.Button removeChild;
    }
}

