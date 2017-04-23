namespace Kmeans
{
    partial class Form1
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.canvas = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьCsvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьCsvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dgv_elements = new System.Windows.Forms.DataGridView();
            this.column_x = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_groups = new System.Windows.Forms.DataGridView();
            this.column_group_x = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_group_y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_color = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btn_start = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_elements)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_groups)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.canvas);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.Controls.Add(this.btn_start);
            this.splitContainer1.Size = new System.Drawing.Size(779, 362);
            this.splitContainer1.SplitterDistance = 520;
            this.splitContainer1.TabIndex = 0;
            // 
            // canvas
            // 
            this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas.Location = new System.Drawing.Point(0, 24);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(520, 338);
            this.canvas.TabIndex = 0;
            this.canvas.TabStop = false;
            this.canvas.WaitOnLoad = true;
            this.canvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(520, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьCsvToolStripMenuItem,
            this.сохранитьCsvToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьCsvToolStripMenuItem
            // 
            this.открытьCsvToolStripMenuItem.Name = "открытьCsvToolStripMenuItem";
            this.открытьCsvToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.открытьCsvToolStripMenuItem.Text = "Открыть набор данных";
            this.открытьCsvToolStripMenuItem.Click += new System.EventHandler(this.открытьCsvToolStripMenuItem_Click);
            // 
            // сохранитьCsvToolStripMenuItem
            // 
            this.сохранитьCsvToolStripMenuItem.Name = "сохранитьCsvToolStripMenuItem";
            this.сохранитьCsvToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.сохранитьCsvToolStripMenuItem.Text = "Сохранить результат";
            this.сохранитьCsvToolStripMenuItem.Click += new System.EventHandler(this.сохранитьCsvToolStripMenuItem_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Location = new System.Drawing.Point(3, 32);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dgv_elements);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dgv_groups);
            this.splitContainer2.Size = new System.Drawing.Size(249, 327);
            this.splitContainer2.SplitterDistance = 216;
            this.splitContainer2.TabIndex = 2;
            // 
            // dgv_elements
            // 
            this.dgv_elements.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_elements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_elements.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column_x,
            this.column_y,
            this.column_group});
            this.dgv_elements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_elements.Location = new System.Drawing.Point(0, 0);
            this.dgv_elements.Name = "dgv_elements";
            this.dgv_elements.Size = new System.Drawing.Size(249, 216);
            this.dgv_elements.TabIndex = 0;
            // 
            // column_x
            // 
            this.column_x.HeaderText = "X";
            this.column_x.Name = "column_x";
            // 
            // column_y
            // 
            this.column_y.HeaderText = "Y";
            this.column_y.Name = "column_y";
            // 
            // column_group
            // 
            this.column_group.HeaderText = "Group";
            this.column_group.Name = "column_group";
            this.column_group.ReadOnly = true;
            // 
            // dgv_groups
            // 
            this.dgv_groups.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_groups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_groups.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column_group_x,
            this.column_group_y,
            this.column_color});
            this.dgv_groups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_groups.Location = new System.Drawing.Point(0, 0);
            this.dgv_groups.Name = "dgv_groups";
            this.dgv_groups.Size = new System.Drawing.Size(249, 107);
            this.dgv_groups.TabIndex = 0;
            // 
            // column_group_x
            // 
            this.column_group_x.HeaderText = "X";
            this.column_group_x.Name = "column_group_x";
            // 
            // column_group_y
            // 
            this.column_group_y.HeaderText = "Y";
            this.column_group_y.Name = "column_group_y";
            // 
            // column_color
            // 
            this.column_color.HeaderText = "Color";
            this.column_color.Name = "column_color";
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(3, 3);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 362);
            this.Controls.Add(this.splitContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(795, 400);
            this.Name = "Form1";
            this.Text = "K-means";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.Move += new System.EventHandler(this.Form1_Move);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_elements)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_groups)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.DataGridView dgv_elements;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_x;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_y;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_group;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьCsvToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьCsvToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dgv_groups;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_group_x;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_group_y;
        private System.Windows.Forms.DataGridViewComboBoxColumn column_color;
    }
}

