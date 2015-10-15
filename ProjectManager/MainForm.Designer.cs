namespace ProjectManager
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonProjectInfo = new System.Windows.Forms.Button();
            this.buttonEditProject = new System.Windows.Forms.Button();
            this.buttonReport = new System.Windows.Forms.Button();
            this.buttonAddProject = new System.Windows.Forms.Button();
            this.listTasks = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.налаштуванняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.колірнаСхемаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редагуватиАкаунтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вийтиЗАкаунтаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonProjectInfo
            // 
            this.buttonProjectInfo.Location = new System.Drawing.Point(254, 208);
            this.buttonProjectInfo.Name = "buttonProjectInfo";
            this.buttonProjectInfo.Size = new System.Drawing.Size(141, 23);
            this.buttonProjectInfo.TabIndex = 22;
            this.buttonProjectInfo.Text = "Інформація про проект";
            this.buttonProjectInfo.UseVisualStyleBackColor = true;
            // 
            // buttonEditProject
            // 
            this.buttonEditProject.Location = new System.Drawing.Point(135, 208);
            this.buttonEditProject.Name = "buttonEditProject";
            this.buttonEditProject.Size = new System.Drawing.Size(113, 23);
            this.buttonEditProject.TabIndex = 21;
            this.buttonEditProject.Text = "Редагувати проект";
            this.buttonEditProject.UseVisualStyleBackColor = true;
            // 
            // buttonReport
            // 
            this.buttonReport.Location = new System.Drawing.Point(419, 198);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(130, 43);
            this.buttonReport.TabIndex = 20;
            this.buttonReport.Text = "Отчет\r\n(Для SCRUM-мастера)";
            this.buttonReport.UseVisualStyleBackColor = true;
            // 
            // buttonAddProject
            // 
            this.buttonAddProject.Location = new System.Drawing.Point(22, 208);
            this.buttonAddProject.Name = "buttonAddProject";
            this.buttonAddProject.Size = new System.Drawing.Size(107, 23);
            this.buttonAddProject.TabIndex = 19;
            this.buttonAddProject.Text = "Додати проект";
            this.buttonAddProject.UseVisualStyleBackColor = true;
            // 
            // listTasks
            // 
            this.listTasks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listTasks.FormattingEnabled = true;
            this.listTasks.Location = new System.Drawing.Point(12, 38);
            this.listTasks.Name = "listTasks";
            this.listTasks.Size = new System.Drawing.Size(576, 145);
            this.listTasks.TabIndex = 18;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(610, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.налаштуванняToolStripMenuItem,
            this.вийтиЗАкаунтаToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // налаштуванняToolStripMenuItem
            // 
            this.налаштуванняToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.колірнаСхемаToolStripMenuItem,
            this.редагуватиАкаунтToolStripMenuItem});
            this.налаштуванняToolStripMenuItem.Name = "налаштуванняToolStripMenuItem";
            this.налаштуванняToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.налаштуванняToolStripMenuItem.Text = "Настройки";
            // 
            // колірнаСхемаToolStripMenuItem
            // 
            this.колірнаСхемаToolStripMenuItem.Name = "колірнаСхемаToolStripMenuItem";
            this.колірнаСхемаToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.колірнаСхемаToolStripMenuItem.Text = "Колірна схема";
            // 
            // редагуватиАкаунтToolStripMenuItem
            // 
            this.редагуватиАкаунтToolStripMenuItem.Name = "редагуватиАкаунтToolStripMenuItem";
            this.редагуватиАкаунтToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.редагуватиАкаунтToolStripMenuItem.Text = "Редагувати акаунт";
            // 
            // вийтиЗАкаунтаToolStripMenuItem
            // 
            this.вийтиЗАкаунтаToolStripMenuItem.Name = "вийтиЗАкаунтаToolStripMenuItem";
            this.вийтиЗАкаунтаToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.вийтиЗАкаунтаToolStripMenuItem.Text = "Вийти з акаунта";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 257);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.buttonProjectInfo);
            this.Controls.Add(this.buttonEditProject);
            this.Controls.Add(this.buttonReport);
            this.Controls.Add(this.buttonAddProject);
            this.Controls.Add(this.listTasks);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonProjectInfo;
        private System.Windows.Forms.Button buttonEditProject;
        private System.Windows.Forms.Button buttonReport;
        private System.Windows.Forms.Button buttonAddProject;
        private System.Windows.Forms.ListBox listTasks;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem налаштуванняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem колірнаСхемаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редагуватиАкаунтToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вийтиЗАкаунтаToolStripMenuItem;
    }
}

