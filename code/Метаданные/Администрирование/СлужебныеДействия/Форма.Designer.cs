using NsgSoft.Forms;
using NsgSoft.DataObjects;
namespace TechControl.Метаданные.Администрирование

{
    
    public partial class СлужебныеДействияФорма:NsgSoft.Forms.NsgReportForm
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.nbУдалениеСотрудников = new NsgSoft.Design.NsgButton();
            this.nbУдалениеЛишнихДолжностей = new NsgSoft.Design.NsgButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.nsgButton1 = new NsgSoft.Design.NsgButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnCreateReport)).BeginInit();
            this.panelButtonReportForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formSettingsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementRightsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgVisualMultipleObject)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbУдалениеСотрудников)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbУдалениеЛишнихДолжностей)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateReport
            // 
            this.btnCreateReport.Size = new System.Drawing.Size(112, 30);
            // 
            // panelButtonReportForm
            // 
            this.panelButtonReportForm.Location = new System.Drawing.Point(0, 526);
            this.panelButtonReportForm.Size = new System.Drawing.Size(748, 30);
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(728, 0);
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
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(6, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(742, 507);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.nsgButton1);
            this.tabPage1.Controls.Add(this.nbУдалениеСотрудников);
            this.tabPage1.Controls.Add(this.nbУдалениеЛишнихДолжностей);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(734, 481);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // nbУдалениеСотрудников
            // 
            this.nbУдалениеСотрудников.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nbУдалениеСотрудников.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nbУдалениеСотрудников.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nbУдалениеСотрудников.Location = new System.Drawing.Point(6, 37);
            this.nbУдалениеСотрудников.Name = "nbУдалениеСотрудников";
            this.nbУдалениеСотрудников.Size = new System.Drawing.Size(212, 25);
            this.nbУдалениеСотрудников.StatesCollection = new NsgSoft.Design.NsgButton.StateCollectionElemnt[0];
            this.nbУдалениеСотрудников.TabIndex = 1;
            this.nbУдалениеСотрудников.Text = "Удаление лишних сотрудников";
            this.nbУдалениеСотрудников.TextPosition = System.Drawing.ContentAlignment.MiddleCenter;
            this.nbУдалениеСотрудников.AsyncClick += new System.ComponentModel.DoWorkEventHandler(this.nbУдалениеСотрудников_AsyncClick);
            // 
            // nbУдалениеЛишнихДолжностей
            // 
            this.nbУдалениеЛишнихДолжностей.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nbУдалениеЛишнихДолжностей.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nbУдалениеЛишнихДолжностей.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nbУдалениеЛишнихДолжностей.Location = new System.Drawing.Point(6, 6);
            this.nbУдалениеЛишнихДолжностей.Name = "nbУдалениеЛишнихДолжностей";
            this.nbУдалениеЛишнихДолжностей.Size = new System.Drawing.Size(212, 25);
            this.nbУдалениеЛишнихДолжностей.StatesCollection = new NsgSoft.Design.NsgButton.StateCollectionElemnt[0];
            this.nbУдалениеЛишнихДолжностей.TabIndex = 0;
            this.nbУдалениеЛишнихДолжностей.Text = "Удаление лишних должностей";
            this.nbУдалениеЛишнихДолжностей.TextPosition = System.Drawing.ContentAlignment.MiddleCenter;
            this.nbУдалениеЛишнихДолжностей.AsyncClick += new System.ComponentModel.DoWorkEventHandler(this.nbУдалениеЛишнихДолжностей_AsyncClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(734, 481);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // nsgButton1
            // 
            this.nsgButton1.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nsgButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nsgButton1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nsgButton1.Location = new System.Drawing.Point(6, 68);
            this.nsgButton1.Name = "nsgButton1";
            this.nsgButton1.Size = new System.Drawing.Size(212, 25);
            this.nsgButton1.StatesCollection = new NsgSoft.Design.NsgButton.StateCollectionElemnt[0];
            this.nsgButton1.TabIndex = 2;
            this.nsgButton1.Text = "Удаление лишних подразделений с заменой ссылок";
            this.nsgButton1.TextPosition = System.Drawing.ContentAlignment.MiddleCenter;
            this.nsgButton1.AsyncClick += new System.ComponentModel.DoWorkEventHandler(this.nsgButton1_AsyncClick);
            // 
            // СлужебныеДействияФорма
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(748, 576);
            this.Controls.Add(this.tabControl1);
            this.Name = "СлужебныеДействияФорма";
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
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nbУдалениеСотрудников)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbУдалениеЛишнихДолжностей)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        protected NsgSoft.Design.NsgButton nbУдалениеЛишнихДолжностей;
        protected NsgSoft.Design.NsgButton nbУдалениеСотрудников;
        protected NsgSoft.Design.NsgButton nsgButton1;
    }
}