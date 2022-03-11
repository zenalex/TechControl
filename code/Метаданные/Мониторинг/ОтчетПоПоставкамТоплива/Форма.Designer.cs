using NsgSoft.Forms;
using NsgSoft.DataObjects;
namespace TechControl.Метаданные.Мониторинг

{
    
    public partial class ОтчетПоПоставкамТопливаФорма:NsgSoft.Forms.NsgReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ОтчетПоПоставкамТопливаФорма));
            this.NsgPeriodPicker = new NsgSoft.Forms.NsgPeriodPicker();
            this.NsgGroupsList = new NsgSoft.ReportBuilder.NsgGroupsList();
            this.NsgObjectFilter = new NsgSoft.Forms.NsgIGridView.NsgObjectFilter();
            ((System.ComponentModel.ISupportInitialize)(this.btnCreateReport)).BeginInit();
            this.panelButtonReportForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formSettingsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgVisualMultipleObject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NsgGroupsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NsgObjectFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateReport
            // 
            this.btnCreateReport.Size = new System.Drawing.Size(112, 30);
            // 
            // panelButtonReportForm
            // 
            this.panelButtonReportForm.Location = new System.Drawing.Point(0, 416);
            this.panelButtonReportForm.Size = new System.Drawing.Size(984, 30);
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(964, 0);
            this.printButton.Size = new System.Drawing.Size(20, 30);
            // 
            // formSettingsButton
            // 
            this.formSettingsButton.Size = new System.Drawing.Size(28, 30);
            // 
            // NsgPeriodPicker
            // 
            this.NsgPeriodPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NsgPeriodPicker.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.NsgPeriodPicker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NsgPeriodPicker.Location = new System.Drawing.Point(684, 0);
            this.NsgPeriodPicker.MinimumSize = new System.Drawing.Size(2, 4);
            this.NsgPeriodPicker.Name = "NsgPeriodPicker";
            this.NsgPeriodPicker.Size = new System.Drawing.Size(300, 27);
            this.NsgPeriodPicker.TabIndex = 15;
            // 
            // NsgGroupsList
            // 
            this.NsgGroupsList.AllowDrop = true;
            this.NsgGroupsList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NsgGroupsList.BackColor = System.Drawing.SystemColors.Control;
            this.NsgGroupsList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NsgGroupsList.DisableComponents = ((System.Collections.Generic.List<string>)(resources.GetObject("NsgGroupsList.DisableComponents")));
            this.NsgGroupsList.Location = new System.Drawing.Point(684, 33);
            this.NsgGroupsList.MinimumSize = new System.Drawing.Size(290, 150);
            this.NsgGroupsList.Name = "NsgGroupsList";
            this.NsgGroupsList.NsgRemoveMasterComponent = true;
            this.NsgGroupsList.SetReport = null;
            this.NsgGroupsList.SetTitle = "Группировка";
            this.NsgGroupsList.Size = new System.Drawing.Size(300, 363);
            this.NsgGroupsList.TabIndex = 13;
            // 
            // NsgObjectFilter
            // 
            this.NsgObjectFilter.AllowDrop = true;
            this.NsgObjectFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NsgObjectFilter.AutoSetCompare = true;
            this.NsgObjectFilter.BackColor = System.Drawing.SystemColors.Control;
            this.NsgObjectFilter.FilterTypeCaption = "Тип Фильтра";
            this.NsgObjectFilter.Grouping = false;
            this.NsgObjectFilter.IsModify = true;
            this.NsgObjectFilter.LineHeight = 20;
            this.NsgObjectFilter.Location = new System.Drawing.Point(0, 0);
            this.NsgObjectFilter.LockAdditionalColumns = false;
            this.NsgObjectFilter.LockUpdateColumnsFromSourceObject = false;
            this.NsgObjectFilter.Name = "NsgObjectFilter";
            this.NsgObjectFilter.ReadOnly = false;
            this.NsgObjectFilter.Regime = NsgSoft.Forms.NsgIGridView.NsgObjectFilter.Regimes.Filter;
            this.NsgObjectFilter.RekvisitCaption = "Имя Фильтра";
            this.NsgObjectFilter.SaveSettings = true;
            this.NsgObjectFilter.Size = new System.Drawing.Size(678, 396);
            this.NsgObjectFilter.SourceObject = null;
            this.NsgObjectFilter.TabIndex = 14;
            this.NsgObjectFilter.ValueCaption = "Фильтр";
            // 
            // ОтчетПоПоставкамТопливаФорма
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(984, 446);
            this.Controls.Add(this.NsgPeriodPicker);
            this.Controls.Add(this.NsgGroupsList);
            this.Controls.Add(this.NsgObjectFilter);
            this.Name = "ОтчетПоПоставкамТопливаФорма";
            this.Controls.SetChildIndex(this.panelButtonReportForm, 0);
            this.Controls.SetChildIndex(this.NsgObjectFilter, 0);
            this.Controls.SetChildIndex(this.NsgGroupsList, 0);
            this.Controls.SetChildIndex(this.NsgPeriodPicker, 0);
            ((System.ComponentModel.ISupportInitialize)(this.btnCreateReport)).EndInit();
            this.panelButtonReportForm.ResumeLayout(false);
            this.panelButtonReportForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formSettingsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgVisualMultipleObject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NsgGroupsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NsgObjectFilter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected NsgPeriodPicker NsgPeriodPicker;
        private NsgSoft.ReportBuilder.NsgGroupsList NsgGroupsList;
        protected NsgSoft.Forms.NsgIGridView.NsgObjectFilter NsgObjectFilter;
    }
}