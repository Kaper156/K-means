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
            this.lbl_centroids = new System.Windows.Forms.Label();
            this.lbl_dots = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dgv_elements = new System.Windows.Forms.DataGridView();
            this.dgv_groups = new System.Windows.Forms.DataGridView();
            this.btn_csv_save = new System.Windows.Forms.Button();
            this.btn_csv_add = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.canvas);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lbl_centroids);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_dots);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.numericUpDown1);
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.Controls.Add(this.btn_csv_save);
            this.splitContainer1.Panel2.Controls.Add(this.btn_csv_add);
            this.splitContainer1.Panel2.Controls.Add(this.button3);
            this.splitContainer1.Panel2.Controls.Add(this.btn_start);
            this.splitContainer1.Size = new System.Drawing.Size(984, 641);
            this.splitContainer1.SplitterDistance = 656;
            this.splitContainer1.TabIndex = 0;
            // 
            // canvas
            // 
            this.canvas.Location = new System.Drawing.Point(0, 0);
            this.canvas.MaximumSize = new System.Drawing.Size(650, 650);
            this.canvas.MinimumSize = new System.Drawing.Size(650, 650);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(650, 650);
            this.canvas.TabIndex = 0;
            this.canvas.TabStop = false;
            this.canvas.WaitOnLoad = true;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            this.canvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseClick);
            // 
            // lbl_centroids
            // 
            this.lbl_centroids.AutoSize = true;
            this.lbl_centroids.Location = new System.Drawing.Point(79, 72);
            this.lbl_centroids.Name = "lbl_centroids";
            this.lbl_centroids.Size = new System.Drawing.Size(68, 13);
            this.lbl_centroids.TabIndex = 5;
            this.lbl_centroids.Text = "Центроид: 0";
            // 
            // lbl_dots
            // 
            this.lbl_dots.AutoSize = true;
            this.lbl_dots.Location = new System.Drawing.Point(9, 72);
            this.lbl_dots.Name = "lbl_dots";
            this.lbl_dots.Size = new System.Drawing.Size(49, 13);
            this.lbl_dots.TabIndex = 5;
            this.lbl_dots.Text = "Точек: 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Погрешность";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 4;
            this.numericUpDown1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            262144});
            this.numericUpDown1.Location = new System.Drawing.Point(255, 70);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(57, 20);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.Location = new System.Drawing.Point(3, 96);
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
            this.splitContainer2.Size = new System.Drawing.Size(318, 551);
            this.splitContainer2.SplitterDistance = 272;
            this.splitContainer2.TabIndex = 2;
            // 
            // dgv_elements
            // 
            this.dgv_elements.AllowUserToOrderColumns = true;
            this.dgv_elements.AllowUserToResizeColumns = false;
            this.dgv_elements.AllowUserToResizeRows = false;
            this.dgv_elements.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_elements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_elements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_elements.Location = new System.Drawing.Point(0, 0);
            this.dgv_elements.Name = "dgv_elements";
            this.dgv_elements.Size = new System.Drawing.Size(318, 272);
            this.dgv_elements.TabIndex = 0;
            this.dgv_elements.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_groups_CellValueChanged);
            // 
            // dgv_groups
            // 
            this.dgv_groups.AllowUserToOrderColumns = true;
            this.dgv_groups.AllowUserToResizeColumns = false;
            this.dgv_groups.AllowUserToResizeRows = false;
            this.dgv_groups.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_groups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_groups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_groups.Location = new System.Drawing.Point(0, 0);
            this.dgv_groups.Name = "dgv_groups";
            this.dgv_groups.Size = new System.Drawing.Size(318, 275);
            this.dgv_groups.TabIndex = 0;
            this.dgv_groups.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_groups_CellValueChanged);
            // 
            // btn_csv_save
            // 
            this.btn_csv_save.Location = new System.Drawing.Point(12, 41);
            this.btn_csv_save.Name = "btn_csv_save";
            this.btn_csv_save.Size = new System.Drawing.Size(123, 23);
            this.btn_csv_save.TabIndex = 1;
            this.btn_csv_save.Text = "Сохранить результат";
            this.btn_csv_save.UseVisualStyleBackColor = true;
            this.btn_csv_save.Click += new System.EventHandler(this.btn_csv_save_Click);
            // 
            // btn_csv_add
            // 
            this.btn_csv_add.Location = new System.Drawing.Point(12, 12);
            this.btn_csv_add.Name = "btn_csv_add";
            this.btn_csv_add.Size = new System.Drawing.Size(123, 23);
            this.btn_csv_add.TabIndex = 1;
            this.btn_csv_add.Text = "Добавить данные";
            this.btn_csv_add.UseVisualStyleBackColor = true;
            this.btn_csv_add.Click += new System.EventHandler(this.btn_csv_add_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(183, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "На шаг вперед";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btn_step_Click);
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(183, 41);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(123, 23);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "Расчёт";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 641);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 700);
            this.MinimumSize = new System.Drawing.Size(16, 38);
            this.Name = "Form1";
            this.Text = "K-means";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dgv_groups;
        private System.Windows.Forms.Button btn_csv_save;
        private System.Windows.Forms.Button btn_csv_add;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_centroids;
        private System.Windows.Forms.Label lbl_dots;
    }
}

