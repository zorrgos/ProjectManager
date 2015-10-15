namespace ProjectManager
{
    partial class TasksForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.налаштуванняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вийтиЗАкаунтаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonDeletePerformer = new System.Windows.Forms.Button();
            this.ButtonAddPerformer = new System.Windows.Forms.Button();
            this.TasksDataGridView = new System.Windows.Forms.DataGridView();
            this.ColumnPerformer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProgress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTerm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.колірнаСхемаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редагуватиАкаунтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TasksDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(868, 24);
            this.menuStrip1.TabIndex = 18;
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
            // вийтиЗАкаунтаToolStripMenuItem
            // 
            this.вийтиЗАкаунтаToolStripMenuItem.Name = "вийтиЗАкаунтаToolStripMenuItem";
            this.вийтиЗАкаунтаToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.вийтиЗАкаунтаToolStripMenuItem.Text = "Вийти з акаунта";
            // 
            // ButtonDeletePerformer
            // 
            this.ButtonDeletePerformer.Location = new System.Drawing.Point(206, 265);
            this.ButtonDeletePerformer.Name = "ButtonDeletePerformer";
            this.ButtonDeletePerformer.Size = new System.Drawing.Size(75, 23);
            this.ButtonDeletePerformer.TabIndex = 21;
            this.ButtonDeletePerformer.Text = "Видалити";
            this.ButtonDeletePerformer.UseVisualStyleBackColor = true;
            // 
            // ButtonAddPerformer
            // 
            this.ButtonAddPerformer.Location = new System.Drawing.Point(44, 265);
            this.ButtonAddPerformer.Name = "ButtonAddPerformer";
            this.ButtonAddPerformer.Size = new System.Drawing.Size(75, 23);
            this.ButtonAddPerformer.TabIndex = 20;
            this.ButtonAddPerformer.Text = "Додати";
            this.ButtonAddPerformer.UseVisualStyleBackColor = true;
            // 
            // TasksDataGridView
            // 
            this.TasksDataGridView.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.TasksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TasksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnPerformer,
            this.ColumnPost,
            this.ColumnTask,
            this.ColumnProgress,
            this.ColumnTime,
            this.ColumnTerm});
            this.TasksDataGridView.Location = new System.Drawing.Point(13, 42);
            this.TasksDataGridView.Name = "TasksDataGridView";
            this.TasksDataGridView.Size = new System.Drawing.Size(843, 204);
            this.TasksDataGridView.TabIndex = 19;
            // 
            // ColumnPerformer
            // 
            this.ColumnPerformer.HeaderText = "Виконавець";
            this.ColumnPerformer.Name = "ColumnPerformer";
            this.ColumnPerformer.Width = 200;
            // 
            // ColumnPost
            // 
            this.ColumnPost.HeaderText = "Посада";
            this.ColumnPost.Name = "ColumnPost";
            this.ColumnPost.Width = 150;
            // 
            // ColumnTask
            // 
            this.ColumnTask.HeaderText = "Задача";
            this.ColumnTask.Name = "ColumnTask";
            this.ColumnTask.Width = 150;
            // 
            // ColumnProgress
            // 
            this.ColumnProgress.HeaderText = "Прогрес";
            this.ColumnProgress.Name = "ColumnProgress";
            // 
            // ColumnTime
            // 
            this.ColumnTime.HeaderText = "Час";
            this.ColumnTime.Name = "ColumnTime";
            // 
            // ColumnTerm
            // 
            this.ColumnTerm.HeaderText = "Срок сдачі";
            this.ColumnTerm.Name = "ColumnTerm";
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(125, 265);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 22;
            this.buttonEdit.Text = "Редагувати";
            this.buttonEdit.UseVisualStyleBackColor = true;
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
            // TasksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 302);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.ButtonDeletePerformer);
            this.Controls.Add(this.ButtonAddPerformer);
            this.Controls.Add(this.TasksDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.Name = "TasksForm";
            this.Text = "TasksForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TasksDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem налаштуванняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вийтиЗАкаунтаToolStripMenuItem;
        private System.Windows.Forms.Button ButtonDeletePerformer;
        private System.Windows.Forms.Button ButtonAddPerformer;
        private System.Windows.Forms.DataGridView TasksDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPerformer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPost;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProgress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTerm;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.ToolStripMenuItem колірнаСхемаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редагуватиАкаунтToolStripMenuItem;
    }
}