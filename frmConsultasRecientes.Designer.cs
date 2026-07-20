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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
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
            lblVitalisInicio.Location = new Point(403, 9);
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
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(23, 147, 209);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvConsultasRealizadas.DefaultCellStyle = dataGridViewCellStyle3;
            dgvConsultasRealizadas.EnableHeadersVisualStyles = false;
            dgvConsultasRealizadas.GridColor = Color.White;
            dgvConsultasRealizadas.Location = new Point(95, 91);
            dgvConsultasRealizadas.MultiSelect = false;
            dgvConsultasRealizadas.Name = "dgvConsultasRealizadas";
            dgvConsultasRealizadas.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(23, 147, 209);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvConsultasRealizadas.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvConsultasRealizadas.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = Color.White;
            dgvConsultasRealizadas.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvConsultasRealizadas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvConsultasRealizadas.Size = new Size(1525, 807);
            dgvConsultasRealizadas.TabIndex = 10;
            // 
            // frmConsultasRecientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1719, 970);
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