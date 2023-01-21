namespace WinFormsApp1
{
    partial class CarsListItem
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.IdLbl = new System.Windows.Forms.Label();
            this.ModelLbl = new System.Windows.Forms.Label();
            this.NarxLbl = new System.Windows.Forms.Label();
            this.YiliLbl = new System.Windows.Forms.Label();
            this.EditBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.Controls.Add(this.IdLbl, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ModelLbl, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.NarxLbl, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.YiliLbl, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.EditBtn, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.DeleteBtn, 7, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1300, 60);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // IdLbl
            // 
            this.IdLbl.AutoSize = true;
            this.IdLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IdLbl.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IdLbl.Location = new System.Drawing.Point(23, 5);
            this.IdLbl.Name = "IdLbl";
            this.IdLbl.Size = new System.Drawing.Size(44, 50);
            this.IdLbl.TabIndex = 0;
            this.IdLbl.Text = "1";
            this.IdLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ModelLbl
            // 
            this.ModelLbl.AutoSize = true;
            this.ModelLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ModelLbl.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ModelLbl.Location = new System.Drawing.Point(73, 5);
            this.ModelLbl.Name = "ModelLbl";
            this.ModelLbl.Size = new System.Drawing.Size(504, 50);
            this.ModelLbl.TabIndex = 1;
            this.ModelLbl.Text = "label2";
            this.ModelLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NarxLbl
            // 
            this.NarxLbl.AutoSize = true;
            this.NarxLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NarxLbl.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NarxLbl.Location = new System.Drawing.Point(583, 5);
            this.NarxLbl.Name = "NarxLbl";
            this.NarxLbl.Size = new System.Drawing.Size(194, 50);
            this.NarxLbl.TabIndex = 2;
            this.NarxLbl.Text = "label3";
            this.NarxLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // YiliLbl
            // 
            this.YiliLbl.AutoSize = true;
            this.YiliLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.YiliLbl.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.YiliLbl.Location = new System.Drawing.Point(783, 5);
            this.YiliLbl.Name = "YiliLbl";
            this.YiliLbl.Size = new System.Drawing.Size(194, 50);
            this.YiliLbl.TabIndex = 3;
            this.YiliLbl.Text = "label4";
            this.YiliLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EditBtn
            // 
            this.EditBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditBtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EditBtn.Location = new System.Drawing.Point(1003, 8);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(144, 44);
            this.EditBtn.TabIndex = 4;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteBtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteBtn.Location = new System.Drawing.Point(1153, 8);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(144, 44);
            this.DeleteBtn.TabIndex = 5;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // CarsListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CarsListItem";
            this.Size = new System.Drawing.Size(1300, 60);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label IdLbl;
        private Label ModelLbl;
        private Label NarxLbl;
        private Label YiliLbl;
        private Button EditBtn;
        private Button DeleteBtn;
    }
}
