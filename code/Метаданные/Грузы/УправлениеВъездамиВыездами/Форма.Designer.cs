using NsgSoft.Forms;
using NsgSoft.DataObjects;
namespace TechControl.Метаданные.Грузы

{
    
    public partial class УправлениеВъездамиВыездамиФорма:NsgSoft.Forms.NsgReportForm
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
            this.tpВъезд = new System.Windows.Forms.TabPage();
            this.tpВыезд = new System.Windows.Forms.TabPage();
            this.tpТехника = new System.Windows.Forms.TabPage();
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
            this.panelButtonReportForm.Location = new System.Drawing.Point(0, 404);
            this.panelButtonReportForm.Size = new System.Drawing.Size(643, 30);
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(623, 0);
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpВъезд);
            this.tabControl1.Controls.Add(this.tpВыезд);
            this.tabControl1.Controls.Add(this.tpТехника);
            this.tabControl1.Location = new System.Drawing.Point(6, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(625, 386);
            this.tabControl1.TabIndex = 9;
            // 
            // tpВъезд
            // 
            this.tpВъезд.Location = new System.Drawing.Point(4, 22);
            this.tpВъезд.Name = "tpВъезд";
            this.tpВъезд.Padding = new System.Windows.Forms.Padding(3);
            this.tpВъезд.Size = new System.Drawing.Size(617, 360);
            this.tpВъезд.TabIndex = 0;
            this.tpВъезд.Text = "Оформить въезд";
            this.tpВъезд.UseVisualStyleBackColor = true;
            // 
            // tpВыезд
            // 
            this.tpВыезд.Location = new System.Drawing.Point(4, 22);
            this.tpВыезд.Name = "tpВыезд";
            this.tpВыезд.Padding = new System.Windows.Forms.Padding(3);
            this.tpВыезд.Size = new System.Drawing.Size(617, 360);
            this.tpВыезд.TabIndex = 1;
            this.tpВыезд.Text = "Оформить выезд";
            this.tpВыезд.UseVisualStyleBackColor = true;
            // 
            // tpТехника
            // 
            this.tpТехника.Location = new System.Drawing.Point(4, 22);
            this.tpТехника.Name = "tpТехника";
            this.tpТехника.Size = new System.Drawing.Size(617, 360);
            this.tpТехника.TabIndex = 2;
            this.tpТехника.Text = "Обзор техники";
            this.tpТехника.UseVisualStyleBackColor = true;
            // 
            // УправлениеВъездамиВыездамиФорма
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(643, 454);
            this.Controls.Add(this.tabControl1);
            this.Name = "УправлениеВъездамиВыездамиФорма";
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
        private System.Windows.Forms.TabPage tpВъезд;
        private System.Windows.Forms.TabPage tpВыезд;
        private System.Windows.Forms.TabPage tpТехника;
    }
}