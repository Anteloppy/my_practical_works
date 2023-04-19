
namespace Pr2
{
    partial class Form1
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.poU = new System.Windows.Forms.Button();
            this.poV = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 53);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(390, 214);
            this.dgv.TabIndex = 0;
            // 
            // tb
            // 
            this.tb.Location = new System.Drawing.Point(12, 26);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(139, 20);
            this.tb.TabIndex = 1;
            this.tb.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Поиск по автору";
            // 
            // poU
            // 
            this.poU.Location = new System.Drawing.Point(190, 23);
            this.poU.Name = "poU";
            this.poU.Size = new System.Drawing.Size(103, 23);
            this.poU.TabIndex = 3;
            this.poU.Text = "По убыванию";
            this.poU.UseVisualStyleBackColor = true;
            this.poU.Click += new System.EventHandler(this.poU_Click);
            // 
            // poV
            // 
            this.poV.Location = new System.Drawing.Point(299, 24);
            this.poV.Name = "poV";
            this.poV.Size = new System.Drawing.Size(103, 23);
            this.poV.TabIndex = 4;
            this.poV.Text = "По возрастанию";
            this.poV.UseVisualStyleBackColor = true;
            this.poV.Click += new System.EventHandler(this.poV_click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "По количеству страниц";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(153, 270);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Сброс значений";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 295);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.poV);
            this.Controls.Add(this.poU);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.dgv);
            this.Name = "Form1";
            this.Text = "Bibliobookza";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button poU;
        private System.Windows.Forms.Button poV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
    }
}

