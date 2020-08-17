namespace ReportPrinterRemaster
{
    partial class WndOutfitInspectionResultList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WndOutfitInspectionResultList));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.btnRecord = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.jclsh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ajlsh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ajjccs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hphm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jyxm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colYJXM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.btnRecord);
            this.Panel1.Controls.Add(this.btnNext);
            this.Panel1.Controls.Add(this.btnLast);
            this.Panel1.Controls.Add(this.btnSearch);
            this.Panel1.Controls.Add(this.textBox1);
            this.Panel1.Controls.Add(this.label1);
            this.Panel1.Location = new System.Drawing.Point(2, 1);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1100, 65);
            this.Panel1.TabIndex = 0;
            // 
            // btnRecord
            // 
            this.btnRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRecord.Location = new System.Drawing.Point(397, 12);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(90, 33);
            this.btnRecord.TabIndex = 5;
            this.btnRecord.Text = "存档";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnNext.Location = new System.Drawing.Point(589, 12);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(90, 33);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "下一页";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLast.Location = new System.Drawing.Point(493, 12);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(90, 33);
            this.btnLast.TabIndex = 3;
            this.btnLast.Text = "上一页";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSearch.Location = new System.Drawing.Point(301, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 33);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "检索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(117, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 32);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(10, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "号牌号码";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jclsh,
            this.ajlsh,
            this.ajjccs,
            this.colVIN,
            this.hphm,
            this.jyxm,
            this.colYJXM});
            this.dataGridView1.Location = new System.Drawing.Point(2, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1100, 493);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // jclsh
            // 
            this.jclsh.DataPropertyName = "JCLSH";
            this.jclsh.HeaderText = "检测流水号";
            this.jclsh.Name = "jclsh";
            // 
            // ajlsh
            // 
            this.ajlsh.DataPropertyName = "AJLSH";
            this.ajlsh.HeaderText = "安检流水号";
            this.ajlsh.Name = "ajlsh";
            // 
            // ajjccs
            // 
            this.ajjccs.DataPropertyName = "AJJCCS";
            this.ajjccs.HeaderText = "安检检测次数";
            this.ajjccs.Name = "ajjccs";
            // 
            // colVIN
            // 
            this.colVIN.DataPropertyName = "VIN";
            this.colVIN.HeaderText = "VIN";
            this.colVIN.Name = "colVIN";
            // 
            // hphm
            // 
            this.hphm.DataPropertyName = "HPHM";
            this.hphm.HeaderText = "号牌号码";
            this.hphm.Name = "hphm";
            // 
            // jyxm
            // 
            this.jyxm.DataPropertyName = "JYXM";
            this.jyxm.HeaderText = "检验项目";
            this.jyxm.Name = "jyxm";
            // 
            // colYJXM
            // 
            this.colYJXM.DataPropertyName = "YJXM";
            this.colYJXM.HeaderText = "已检项目";
            this.colYJXM.Name = "colYJXM";
            // 
            // WndOutfitInspectionResultList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 568);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WndOutfitInspectionResultList";
            this.Text = "人工检验打印";
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.DataGridViewTextBoxColumn jclsh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ajlsh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ajjccs;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn hphm;
        private System.Windows.Forms.DataGridViewTextBoxColumn jyxm;
        private System.Windows.Forms.DataGridViewTextBoxColumn colYJXM;
    }
}

