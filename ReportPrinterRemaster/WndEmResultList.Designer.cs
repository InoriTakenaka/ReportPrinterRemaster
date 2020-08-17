namespace ReportPrinterRemaster
{
    partial class WndEmResultList
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
            this.m_dgv = new System.Windows.Forms.DataGridView();
            this.jclsh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hphm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.method = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.m_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // m_dgv
            // 
            this.m_dgv.AllowUserToAddRows = false;
            this.m_dgv.AllowUserToDeleteRows = false;
            this.m_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jclsh,
            this.vin,
            this.hphm,
            this.startTime,
            this.endTime,
            this.status,
            this.method,
            this.result});
            this.m_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_dgv.Location = new System.Drawing.Point(0, 0);
            this.m_dgv.Name = "m_dgv";
            this.m_dgv.ReadOnly = true;
            this.m_dgv.Size = new System.Drawing.Size(864, 531);
            this.m_dgv.TabIndex = 0;
            // 
            // jclsh
            // 
            this.jclsh.DataPropertyName = "JCLSH";
            this.jclsh.Frozen = true;
            this.jclsh.HeaderText = "检测流水号";
            this.jclsh.Name = "jclsh";
            this.jclsh.ReadOnly = true;
            // 
            // vin
            // 
            this.vin.DataPropertyName = "VIN";
            this.vin.Frozen = true;
            this.vin.HeaderText = "VIN";
            this.vin.Name = "vin";
            this.vin.ReadOnly = true;
            // 
            // hphm
            // 
            this.hphm.DataPropertyName = "HPHM";
            this.hphm.Frozen = true;
            this.hphm.HeaderText = "号牌号码";
            this.hphm.Name = "hphm";
            this.hphm.ReadOnly = true;
            // 
            // startTime
            // 
            this.startTime.DataPropertyName = "startTime";
            this.startTime.Frozen = true;
            this.startTime.HeaderText = "上线时间";
            this.startTime.Name = "startTime";
            this.startTime.ReadOnly = true;
            // 
            // endTime
            // 
            this.endTime.DataPropertyName = "endTime";
            this.endTime.Frozen = true;
            this.endTime.HeaderText = "下线时间";
            this.endTime.Name = "endTime";
            this.endTime.ReadOnly = true;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.Frozen = true;
            this.status.HeaderText = "在线状态";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // method
            // 
            this.method.DataPropertyName = "method";
            this.method.Frozen = true;
            this.method.HeaderText = "检测方法";
            this.method.Name = "method";
            this.method.ReadOnly = true;
            // 
            // result
            // 
            this.result.DataPropertyName = "result";
            this.result.Frozen = true;
            this.result.HeaderText = "检验结果";
            this.result.Name = "result";
            this.result.ReadOnly = true;
            // 
            // WndEmResultList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 531);
            this.ControlBox = false;
            this.Controls.Add(this.m_dgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WndEmResultList";
            this.Text = "WndEmResultList";
            ((System.ComponentModel.ISupportInitialize)(this.m_dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView m_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn jclsh;
        private System.Windows.Forms.DataGridViewTextBoxColumn vin;
        private System.Windows.Forms.DataGridViewTextBoxColumn hphm;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn method;
        private System.Windows.Forms.DataGridViewTextBoxColumn result;
    }
}