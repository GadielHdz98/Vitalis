namespace Vitalis
{
    partial class frmConsultasRecientes
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lblVitalisInicio = new Label();
            dgvConsultasRealizadas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvConsultasRealizadas).BeginInit();
            SuspendLayout();
            // 
            // lblVitalisInicio
            // 
            lblVitalisInicio.Anchor = AnchorStyles.Top;
            lblVitalisInicio.Font = new Font("Segoe UI", 38.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVitalisInicio.ForeColor = Color.FromArgb(23, 147, 209);
            lblVitalisInicio.Location = new Point(102, 9);
            lblVitalisInicio.Name = "lblVitalisInicio";
            lblVitalisInicio.Size = new Size(900, 68);
            lblVitalisInicio.TabIndex = 7;
            lblVitalisInicio.Text = "Consultas registradas recientemente";
            // 
            // dgvConsultasRealizadas
            // 
            dgvConsultasRealizadas.AllowUserToAddRows = false;
            dgvConsultasRealizadas.AllowUserToDeleteRows = false;
            dgvConsultasRealizadas.AllowUserToResizeColumns = false;
            dgvConsultasRealizadas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(239, 239, 239);
            dgvConsultasRealizadas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvConsultasRealizadas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvConsultasRealizadas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvConsultasRealizadas.BackgroundColor = Color.White;
            dgvConsultasRealizadas.BorderStyle = BorderStyle.None;
            dgvConsultasRealizadas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvConsultasRealizadas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(58, 154, 138);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(58, 154, 138);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvConsultasRealizadas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvConsultasRealizadas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultasRealizadas.EnableHeadersVisualStyles = false;
            dgvConsultasRealizadas.GridColor = Color.White;
            dgvConsultasRealizadas.Location = new Point(22, 91);
            dgvConsultasRealizadas.MultiSelect = false;
            dgvConsultasRealizadas.Name = "dgvConsultasRealizadas";
            dgvConsultasRealizadas.ReadOnly = true;
            dgvConsultasRealizadas.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = Color.White;
            dgvConsultasRealizadas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvConsultasRealizadas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvConsultasRealizadas.Size = new Size(1074, 448);
            dgvConsultasRealizadas.TabIndex = 10;
            // 
            // frmConsultasRecientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1117, 563);
            Controls.Add(dgvConsultasRealizadas);
            Controls.Add(lblVitalisInicio);
            Name = "frmConsultasRecientes";
            Text = "frmConsultasRecientes";
            ((System.ComponentModel.ISupportInitialize)dgvConsultasRealizadas).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lblVitalisInicio;
        private DataGridView dgvConsultasRealizadas;
    }
}