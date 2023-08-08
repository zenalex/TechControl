using NsgSoft.Forms;
using NsgSoft.DataObjects;
namespace TechControl.Метаданные.УчетИнструмента

{
    
    public partial class КонтрольИнструментаФорма:NsgSoft.Forms.NsgReportForm
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpВыдача = new System.Windows.Forms.TabPage();
            this.tpПриемка = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.btnCreateReport)).BeginInit();
            this.panelButtonReportForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formSettingsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementRightsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgVisualMultipleObject)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateReport
            // 
            this.btnCreateReport.Size = new System.Drawing.Size(112, 30);
            // 
            // panelButtonReportForm
            // 
            this.panelButtonReportForm.Location = new System.Drawing.Point(0, 498);
            this.panelButtonReportForm.Size = new System.Drawing.Size(923, 30);
            // 
            // printButton
            // 
            this.printButton.IsActive = false;
            this.printButton.Location = new System.Drawing.Point(903, 0);
            this.printButton.Size = new System.Drawing.Size(20, 30);
            // 
            // formSettingsButton
            // 
            this.formSettingsButton.Size = new System.Drawing.Size(28, 30);
            // 
            // elementRightsButton
            // 
            this.elementRightsButton.Size = new System.Drawing.Size(88, 30);
            // 
            // nsgVisualMultipleObject
            // 
            this.nsgVisualMultipleObject.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpВыдача);
            this.tabControl1.Controls.Add(this.tpПриемка);
            this.tabControl1.Location = new System.Drawing.Point(6, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(917, 480);
            this.tabControl1.TabIndex = 9;
            // 
            // tpВыдача
            // 
            this.tpВыдача.Location = new System.Drawing.Point(4, 22);
            this.tpВыдача.Name = "tpВыдача";
            this.tpВыдача.Padding = new System.Windows.Forms.Padding(3);
            this.tpВыдача.Size = new System.Drawing.Size(909, 454);
            this.tpВыдача.TabIndex = 0;
            this.tpВыдача.Text = "Выдача";
            this.tpВыдача.UseVisualStyleBackColor = true;
            // 
            // tpПриемка
            // 
            this.tpПриемка.Location = new System.Drawing.Point(4, 22);
            this.tpПриемка.Name = "tpПриемка";
            this.tpПриемка.Padding = new System.Windows.Forms.Padding(3);
            this.tpПриемка.Size = new System.Drawing.Size(909, 454);
            this.tpПриемка.TabIndex = 1;
            this.tpПриемка.Text = "Приемка";
            this.tpПриемка.UseVisualStyleBackColor = true;
            // 
            // КонтрольИнструментаФорма
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(923, 548);
            this.Controls.Add(this.tabControl1);
            this.Name = "КонтрольИнструментаФорма";
            this.UseDefaultButtons = false;
            this.Controls.SetChildIndex(this.panelButtonReportForm, 0);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.btnCreateReport)).EndInit();
            this.panelButtonReportForm.ResumeLayout(false);
            this.panelButtonReportForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formSettingsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementRightsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgVisualMultipleObject)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpВыдача;
        private System.Windows.Forms.TabPage tpПриемка;
    }
}