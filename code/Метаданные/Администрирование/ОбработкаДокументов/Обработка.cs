using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NsgSoft.DataObjects;

using NsgSoft.Forms;

using NsgSoft.Common;
using NsgSoft.Database;
using NsgSoft.ReportBuilder.Components;
using NsgSoft.ReportBuilder;
using NsgSoft.ReportBase.Drawing;
using TechControl.Метаданные.Сервис;
using NsgSoft.Tools;

namespace TechControl.Метаданные.Администрирование
{
    public partial class ОбработкаДокументовОбработка : NsgSoft.Forms.NsgReportForm
    {
        #region Данные класса
        // выбранная таб.часть
        private string selectedTab = string.Empty;
        private bool selectTab = true;
        protected List<string> m_list = new List<string>();
        protected string m_selectItem = string.Empty;
        protected string m_selectItemActions = string.Empty;
        protected Метаданные m_metadata = Метаданные.Новый();
        protected NsgCompare m_compare = new NsgCompare();
        protected string m_ChooseDoc = string.Empty;
        protected string ИмяСправочника; //Используется в групповом вводе значения (Только для справочников)
        private string fileName = null;
        #endregion

        #region Конструктор класса

        /// <summary>
        /// Конструктор класса.
        /// </summary>
        public ОбработкаДокументовОбработка()
        {
            InitializeComponent();

            nsgListViewTypes.IsCanMultiSelect = true;
            nsgListViewElems.IsCanMultiSelect = true;

            nsgListViewTypes.AllowDrop = true;
            nsgListViewTypes.Grid.DragOver +=new DragEventHandler(Grid_DragOverTypes);
            nsgListViewTypes.Grid.DragDrop += new DragEventHandler(Grid_DragDropTypes);

            nsgListViewTypes.CellRequestEdit += new NsgIGrid.NsgIGridCellEventHandler(nsgListViewTypes_CellRequestEdit);
            nsgListViewTypes.GetAvailableTools += new GetActionToolsEventHandler(nsgListViewTypes_GetAvailableTools);
            nsgListViewTypes.GetEnabledTools += new GetActionToolsEventHandler(nsgListViewTypes_GetEnabledTools);
            nsgListViewTypes.CellStartDrag += new NsgIGrid.NsgIGridCellEventHandler(nsgListViewTypes_CellStartDrag);
            nsgListViewTypes.DragEnter += new DragEventHandler(nsgListViewTypes_DragEnter);
            //nsgListViewTypes.DragDrop += new DragEventHandler(nsgListViewTypes_DragDrop);
            //nsgListViewTypes.DragOver += new DragEventHandler(nsgListViewTypes_DragOver);

            nsgListViewElems.AllowDrop = true;
            nsgListViewElems.Grid.DragOver += new DragEventHandler(Grid_DragOverElems);
            nsgListViewElems.Grid.DragDrop += new DragEventHandler(Grid_DragDropElems);

            nsgListViewElems.CellRequestEdit += new NsgIGrid.NsgIGridCellEventHandler(nsgListViewElems_CellRequestEdit);
            nsgListViewElems.GetAvailableTools += new GetActionToolsEventHandler(nsgListViewElems_GetAvailableTools);
            nsgListViewElems.GetEnabledTools += new GetActionToolsEventHandler(nsgListViewElems_GetEnabledTools);
            nsgListViewElems.CellStartDrag += new NsgIGrid.NsgIGridCellEventHandler(nsgListViewElems_CellStartDrag);
            nsgListViewElems.DragEnter += new DragEventHandler(nsgListViewElems_DragEnter);
            //nsgListViewElems.DragDrop += new DragEventHandler(nsgListViewElems_DragDrop);
            //nsgListViewElems.DragOver += new DragEventHandler(nsgListViewElems_DragOver);

            nsgVisualMultipleObject1.ReadOnly = false;
            nsgVisualMultipleObject.ReadOnly = false;
            // доступные группы
            comboBoxTypes.Items.AddRange(new object[] { "Документы", "Справочники", "Характеристики", "Регистры" });
            TabText = Text = "Обработка Объектов";
            DateTime begin = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            DateTime end = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 23, 59, 0);
            nsgPeriodPickerPeriod.Period = new NsgDateTimePeriod(begin, end);
            // задать картинки
            
            // состояние начальное
            setInitFormState(false);
            nsgProgressBar.ReportProgress(0, "");
            nsgPeriodPickerPeriod.Period = new NsgDateTimePeriod();
            tabControl1.SelectedTab = tabPage1;
            checkBoxBindedObjects.Checked = nsgDataExchangeService.ExportBindedObjects;
            checkBoxRehandle.Checked = true;
            comboBoxFormat.SelectedIndex = 0;
        }
        #endregion
        
        void nsgListViewElems_GetAvailableTools(object sender, ref NsgWorkPanelTools tools)
        {
            tools = NsgWorkPanelTools.SelectAll | NsgWorkPanelTools.UnSelectAll;
        }

        void nsgListViewTypes_GetAvailableTools(object sender, ref NsgWorkPanelTools tools)
        {
            tools = NsgWorkPanelTools.SelectAll | NsgWorkPanelTools.UnSelectAll;
        }

        void nsgListViewElems_GetEnabledTools(object sender, ref NsgWorkPanelTools tools)
        {
            tools = NsgWorkPanelTools.SelectAll | NsgWorkPanelTools.UnSelectAll;
        }

        void nsgListViewTypes_GetEnabledTools(object sender, ref NsgWorkPanelTools tools)
        {
            tools = NsgWorkPanelTools.SelectAll | NsgWorkPanelTools.UnSelectAll;
        }   
        
        #region Методы класса

        #region (OnSetFormObject)
        protected override void OnSetFormObject(NsgMultipleObject formObject)
        {
            comboBoxTypes.SelectedIndex = -1;

            base.OnSetFormObject(formObject);
            if (m_selectItemActions == "Групповой ввод значений в таблицу")
            {
                //удаляем перед добавлением, чтобы закладки следовали всегда в определенном порядке
                if (tabControl1.TabPages.Contains(tabPage4)) tabControl1.TabPages.Remove(tabPage4);
                if (tabControl1.TabPages.Contains(tabPage3)) tabControl1.TabPages.Remove(tabPage3);
                if (!tabControl1.TabPages.Contains(tabPage4)) tabControl1.TabPages.Add(tabPage4);
                if (!tabControl1.TabPages.Contains(tabPage3)) tabControl1.TabPages.Add(tabPage3);
                label3.Visible = true;
                comboBoxTable.Visible = true;
                label6.Visible = true;
            }
            else
            {
                if (tabControl1.TabPages.Contains(tabPage4)) tabControl1.TabPages.Remove(tabPage4);
                if (tabControl1.TabPages.Contains(tabPage3)) tabControl1.TabPages.Remove(tabPage3);
                label3.Visible = false;
                comboBoxTable.Visible = false;
                label6.Visible = false;
                comboBoxTable.Items.Clear();
            }
        }
        #endregion

        #region (setInitFormState)
        /// <summary>
        /// Метод установки начального состояния формы.
        /// </summary>
        /// <param name="state">Состояние.</param>
        private void setInitFormState(bool state)
        {
            tabPage2.Enabled = nsgShowObject.Enabled = nsgProcess.Enabled = false;

            label2.Enabled = comboBoxAction.Enabled =
            findTextBox.Enabled = nsgListViewTypes.Enabled =
            nsgFindTextBox1.Enabled = nsgListViewElems.Enabled =
            nsgButtonBackAll.Enabled = nsgButtonBackOne.Enabled =
            nsgButtonSetAll.Enabled = nsgButtonSetOne.Enabled = state;

        }
        #endregion

        #region (setWorkFormState)
        /// <summary>
        /// Метод установки рабочего состояния формы.
        /// </summary>
        /// <param name="state">Состояние.</param>
        private void setWorkFormState(bool state)
        {
            tabPage2.Enabled = nsgShowObject.Enabled = nsgProcess.Enabled = state;
        }
        #endregion

        #region (LoadObject)
        /// <summary>
        /// Метод загрузки списка типов по группе.
        /// </summary>
        /// <param name="nameGroup">Группа.</param>
        protected void LoadObject(string nameGroup)
        {
            nsgBackgroundFillTypes.Data = nameGroup;
            nsgBackgroundFillTypes.Run();
        }
        #endregion

        #region (ПолучениеЗначенийДляФильтра)
        /// <summary>
        /// Метод заполнения фильтра.
        /// </summary>
        protected void ПолучениеЗначенийДляФильтра()
        {
            var table = vmo2NsgListViewElem.Data.MemoryTable;
            setWorkFormState(table.Rows.Length>0);
            List<NsgMultipleObject> allMO = new List<NsgMultipleObject>();            
            foreach (var row in table.Rows)
            {
                var gid = (Guid)row[vmo2elem_Gid.Name].Value;
                var obj = dictDest[gid];
                if (obj != null) allMO.Add(obj);
            }
            
            nsgBackgroundGetFilter.Data = allMO;
            nsgBackgroundGetFilter.OwnerForm = this;
            nsgBackgroundGetFilter.Run();
        }
        #endregion

        #region (ПолучениеЗначенийТаблицыДляФильтра_Background)
        /// <summary>
        /// Метод заполнения фильтра - фоновое.
        /// </summary>
        /// <param name="allMO">Список MultipleObject.</param>
        /// <returns>Возвращает список колонок.</returns>
        private List<NsgColumnDescriptor> ПолучениеЗначенийТаблицыДляФильтра_Background(NsgMultipleObject MO)
        {
            if (selectTab)
            {
                // пройти по всем объектам списка и найти таблицу
                Invoke(new EventHandler(delegate { comboBoxTable.Items.Clear(); }));
                foreach (NsgSimpleObject so in MO.ObjectList.All)
                    if (so is NsgReference && so.MetaData.isDataTable((so as NsgReference).ReferentFullName))
                        //NsgMetaData.CompareTypes((so as NsgReference).ReferentType(), typeof(NsgDataTable)))
                        Invoke(new EventHandler(delegate { comboBoxTable.Items.Add(so.Name); }));
                Invoke(new EventHandler(delegate
                {   // выделить первый
                    if (comboBoxTable.Items.Count > 0)
                    {
                        comboBoxTable.SelectedIndexChanged -= new EventHandler(comboBoxTable_SelectedIndexChanged);
                        comboBoxTable.SelectedIndex = 0;
                        comboBoxTable.SelectedIndexChanged += new EventHandler(comboBoxTable_SelectedIndexChanged);
                        selectedTab = (string)comboBoxTable.SelectedItem;
                    }
                    // разблокировать выбор, если 2 и более
                    if (comboBoxTable.Items.Count > 1)
                        comboBoxTable.Enabled = true;
                    else
                        comboBoxTable.Enabled = false;
                }));
            }
            selectTab = true;
            return ПолучитьЗначенияКолонокДляВыбранойТаблицы(MO);
        }
        #endregion

        #region (ПолучитьЗначенияКолонокДляВыбранойТаблицы)
        private List<NsgColumnDescriptor> ПолучитьЗначенияКолонокДляВыбранойТаблицы(NsgMultipleObject MO)
        {
            var columns = new List<NsgColumnDescriptor>();
            NsgReferencedObject table = null;
            if (!String.IsNullOrEmpty(selectedTab))
                if (MO.ObjectList.Contains(selectedTab) && (MO.ObjectList[selectedTab] is NsgReference))
                    table = MO.ObjectList[selectedTab].ToReferent();

            if (table != null)
            {
                var soList = new Dictionary<string, NsgSimpleObject>();
                // пройти по всем объектам списка
                foreach (NsgSimpleObject simple in table.ObjectList)
                {

                    // фильтровать формы, индексы и таб.части
                    if (simple is NsgDataForm || simple is NsgDataTableReference
                     || simple is NsgDataIndex || simple is NsgDataGuid) continue;
                    // фильтровать по видимости
                    if (simple.EditorVisible == NsgDataObjectEditorAccess.Hidden) continue;
                    // добавить в список
                    if (!soList.ContainsKey(simple.Name))
                        soList.Add(simple.Name, simple);
                }
                // пройти по всем объектам списка для удаления лишних
                // собрать лишние поля
                var forDel = new List<string>();
                foreach (string field in soList.Keys)
                {
                    if (!table.ObjectList.Contains(field))
                        forDel.Add(field);
                }
                // удалить лишние
                foreach (string delField in forDel)
                {
                    if (soList.ContainsKey(delField))
                        soList.Remove(delField);
                }
                // создать колонки VMO
                nsgVisualMultipleObject1.Columns.Clear();
                columns.Add(nsgVisualMultipleObject1.Columns.CreateElement(table.GetReference(table.Name)));
                ИмяСправочника = table.Name;
                foreach (NsgSimpleObject simple in soList.Values)
                    columns.Add(nsgVisualMultipleObject1.Columns.CreateElement(simple));
            }

            // вернуть список колонок
            return columns;
        }
        #endregion

        #region (ПолучениеЗначенийДляФильтра_Background)
        /// <summary>
        /// Метод заполнения фильтра - фоновое.
        /// </summary>
        /// <param name="allMO">Список MultipleObject.</param>
        /// <returns>Возвращает список колонок.</returns>
        private List<NsgColumnDescriptor> ПолучениеЗначенийДляФильтра_Background(List<NsgMultipleObject> allMO)
        {
            // создать колонки VMO
            nsgVisualMultipleObject1.Columns.Clear();
            var columns = new Dictionary<string, NsgColumnDescriptor>(); 
            bool f = true;
            if (allMO.Count > 0)
            {
                if ((allMO.Count == 1) && (allMO[0] is NsgDataDictionary) && ((allMO[0] as NsgDataDictionary).MaxGroupLevel > 1))
                {
                    NsgColumnDescriptor cd = nsgVisualMultipleObject1.Columns.CreateElement(allMO[0].GetReference(allMO[0].Name));
                    cd.Name = "Идентификатор";
                    columns.Add("Идентификатор", cd);
                }
                    
//                columns.Add(allMO[0].Name, nsgVisualMultipleObject1.Columns.CreateElement(allMO[0].GetReference(allMO[0].Name)));

                foreach (NsgSimpleObject simple in allMO[0].ObjectList)
                {
                    // фильтровать формы, индексы и таб.части
                    if (simple is NsgDataForm || ((simple is NsgDataTableReference) && (allMO.Count != 1))
                     || simple is NsgDataIndex || simple is NsgDataGuid) continue; // || simple is NsgDataGuid
                    // фильтровать по видимости
                    if (simple.EditorVisible == NsgDataObjectEditorAccess.Hidden) continue;
                    // добавить в список
                    if (!columns.ContainsKey(simple.Name))
                    {
                        NsgColumnDescriptor desc = nsgVisualMultipleObject1.Columns.CreateElement(simple);
                        if (simple is NsgDataTableReference)
                        {
                            //desc.Caption = simple.FullName;
                            desc.Visible = false;
                            //desc.Name = simple.FullName;
                        }
                        columns.Add(desc.Name, desc);
                        
                        if (simple is NsgDataUntypedReference)
                        {
                            NsgDataUntypedReference refer = simple as NsgDataUntypedReference;
                            NsgColumnDescriptor.UntypedMultipleObject column = (columns[simple.Name] as NsgColumnDescriptor.UntypedMultipleObject);
                            column.ReferentFilter.FiltrationType = refer.ReferentFilter.FiltrationType;
                            column.ReferentFilter.Parameters = refer.ReferentFilter.Parameters;
                        }
                    }
                }

                if (m_selectItemActions == "Групповой ввод значений")
                {
                    ИмяСправочника = allMO[0].Name;
                    if (allMO.Count > 1)
                    {
                        f = false;
                        NsgSettings.MainForm.ShowMessage("в групповом вводе значений нельзя использовать более одного объекта.");
                        //nsgListViewElems.Grid.MultiSelectAll(true);
                        //nsgListViewElems.Grid.SetMultiselectIndex(0, false);
                        //MoveItems(nsgListViewElems, dictDest, nsgListViewTypes, dictSource, (mo) => { sourceTableAddRow(mo); });        
                    }
                }
                if (f)
                {
                    foreach (NsgMultipleObject obj in allMO)
                    {
                        foreach (NsgSimpleObject simple in obj.ObjectList)
                        {
                            // фильтровать формы, индексы и таб.части
                            if (simple is NsgDataForm || simple is NsgDataTableReference
                             || simple is NsgDataIndex || simple is NsgDataGuid) continue;
                            // фильтровать по видимости
                            if (simple.EditorVisible == NsgDataObjectEditorAccess.Hidden) continue;
                            // добавить в список
                            if (!columns.ContainsKey(simple.Name))
                                columns.Add(simple.Name, nsgVisualMultipleObject1.Columns.CreateElement(simple));
                            else if (simple is NsgDataUntypedReference)
                            {
                                NsgDataUntypedReference refer = simple as NsgDataUntypedReference;
                                NsgColumnDescriptor.UntypedMultipleObject column = (columns[simple.Name] as NsgColumnDescriptor.UntypedMultipleObject);
                                List<string> list1 = refer.ReferentFilter.GetAvailableObjectNames(obj.MetaData);
                                List<string> list2 = column.ReferentFilter.GetAvailableObjectNames(obj.MetaData);
                                List<string> list = new List<string>();
                                foreach (string name in list1)
                                    if (list2.Contains(name))
                                        list.Add(name);
                                column.ReferentFilter.FiltrationType = NsgFiltration.List;
                                column.ReferentFilter.Parameters = list;
                            }
                        }
                    }
                }
                List<string> del = new List<string>();
                foreach (string name in columns.Keys)
                    if ((columns[name] is NsgColumnDescriptor.UntypedMultipleObject) && ((columns[name] as NsgColumnDescriptor.UntypedMultipleObject).ReferentFilter.Parameters.Count == 0))
                        del.Add(name);
                foreach (string name in del)
                    columns.Remove(name);

            }
        
            return new List<NsgColumnDescriptor>(columns.Values);
            
            #region Backup 
            /*
            var soList = new Dictionary<string, NsgSimpleObject>();
            // пройти по всем объектам списка
            foreach (NsgMultipleObject obj in allMO)
            {
                foreach (NsgSimpleObject simple in obj.ObjectList)
                {

                    // фильтровать формы, индексы и таб.части
                    if (simple is NsgDataForm || simple is NsgDataTableReference
                     || simple is NsgDataIndex || simple is NsgDataGuid) continue;
                    // фильтровать по видимости
                    if (simple.EditorVisible == NsgDataObjectEditorAccess.Hidden) continue;
                    // добавить в список
                    if (!soList.ContainsKey(simple.Name))
                        soList.Add(simple.Name, simple);
                }
            }
            // пройти по всем объектам списка для удаления лишних
            foreach (NsgMultipleObject obj in allMO)
            {
                // собрать лишние поля
                List<string> forDel = new List<string>();
                foreach (string field in soList.Keys)
                    if (!obj.ObjectList.Contains(field))
                        forDel.Add(field);
                // удалить лишние
                foreach (string delField in forDel)
                    if (soList.ContainsKey(delField))
                        soList.Remove(delField);
            }
            var columns = new List<NsgColumnDescriptor>();
            // создать колонки VMO
            nsgVisualMultipleObject1.Columns.Clear();
            if (m_selectItemActions == "Групповой ввод значений")
            {
                if (allMO.Count > 0)
                {
                    columns.Add(nsgVisualMultipleObject1.Columns.CreateElement(allMO[0].GetReference(allMO[0].Name)));
                    ИмяСправочника = allMO[0].Name;
                    if (allMO.Count > 1)
                    {
                        NsgSettings.MainForm.ShowMessage("в групповом вводе значений нельзя использовать более одного справочника");
                    }
                }
            }
            foreach (NsgSimpleObject simple in soList.Values)
                columns.Add(nsgVisualMultipleObject1.Columns.CreateElement(simple));
            // вернуть список колонок
            return columns;
            */
            #endregion
        }
        #endregion

        #region (ПолучениеЗначенийДляФильтра_Finish)
        /// <summary>
        /// Метод заполнения фильтра - окончание.
        /// </summary>
        private void ПолучениеЗначенийДляФильтра_Finish(object[] col)
        {

            if (m_selectItemActions == "Групповой ввод значений")
            {
                    nsgListViewElems.Grid.MultiSelectAll(true);
                    nsgListViewElems.Grid.SetMultiselectIndex(1, false);
                    MoveItems(nsgListViewElems, dictDest, nsgListViewTypes, dictSource, (mo) => { sourceTableAddRow(mo); });
                    ///ПолучениеЗначенийДляФильтра();

           }


            var columns = col[0] as List<NsgColumnDescriptor>;
            var columns2 = col[1] as List<NsgColumnDescriptor>;
            // пересоздать колонки VMO
            nsgVisualMultipleObject1.Columns.Clear();
            nsgVisualMultipleObject1.Columns.AddRange(columns.ToArray());
            if (m_selectItemActions == "Групповой ввод значений")
            {
                if (columns.Count > 0)
                    columns.RemoveAt(0);
            }
            if (m_selectItemActions == "Групповой ввод значений в таблицу")
            {
                if (columns2.Count > 0)
                    columns2.RemoveAt(0);
                if (columns2.Count > 0)
                    columns2.RemoveAt(0);
                vmo_input.Columns.Clear();
                vmo_input.Columns.AddRange(columns2.ToArray());
                vmo_tableDoc.Columns.Clear();
                vmo_tableDoc.Columns.AddRange(columns2.ToArray());
            }
            else
            {
                vmo_tableDoc.Columns.Clear();
                vmo_input.Columns.Clear();
                vmo_input.Columns.AddRange(columns.ToArray());
            }

            // заполнить фильтры
            nsgObjectFilter.BeginUpdateStructure();
            nsgObjectFilter.Columns.Clear();
            nsgObjectFilter.getColumnsFromSourceObject();
            nsgObjectFilter.EndUpdateStructure(true);

            nsgInputFilter.BeginUpdateStructure();
            nsgInputFilter.Columns.Clear();
            nsgInputFilter.getColumnsFromSourceObject();
            nsgInputFilter.EndUpdateStructure(true);

            nsgInputFilterTableDoc.BeginUpdateStructure();
            nsgInputFilterTableDoc.Columns.Clear();
            nsgInputFilterTableDoc.getColumnsFromSourceObject();
            nsgInputFilterTableDoc.EndUpdateStructure(true);
            // заполнить группировку
            var groups = new List<string>();
            foreach (NsgColumnDescriptor desc in columns)
                groups.Add(desc.Name);
            nsgGroupsList.AddItemToGroupsList = groups;
            nsgGroupsList.Invalidate();
        }
        #endregion

        #region (ВыгрузкаВФайл)
        /// <summary>
        /// Метод выгрузки объектов в файл.
        /// </summary>
        private void ВыгрузкаВФайл()
        {
            // заполнить параметры выборки
            m_compare.Add(nsgObjectFilter.Compare);
            // получить список типов
            string description = "Выгрузка типов данных: ";
            List<NsgMultipleObject> objlist = new List<NsgMultipleObject>();
            bool isFirst = true;

            var table = vmo2NsgListViewElem.Data.MemoryTable;
            foreach (var row in table.Rows)
            {
                if (!isFirst)
                    description += ", ";
                
                var gid = (Guid)row[vmo2elem_Gid.Name].Value;
                var obj = dictDest[gid];
                NsgMultipleObject mo = obj;
                if (mo != null)
                {
                    objlist.Add(mo);
                    description += mo.FullName;
                    isFirst = false;
                }
            }
           
            // параметры
            description += "\nПараметры выгрузки: ";
            string cmpText = m_compare.ToString();
            if (!string.IsNullOrEmpty(cmpText))
                description += cmpText + ".";
            else
                description += "всё.";
            // выполнить выгрузку
            nsgDataExchangeService.ExportData(objlist.ToArray(), fileName, m_compare, description);
        }
        #endregion

        #region (ОбработкаОбъектов)
        /// <summary>
        /// Метод обработки списка объектов.
        /// </summary>
        private void ОбработкаОбъектов()
        {
            #region Проведение
            //проведение документов с помощью общего журнала 
            if (m_selectItemActions == "Провести" && m_selectItem == "Документы")
            {
                NsgCompare filter = nsgObjectFilter.Compare.Clone;
                filter.InsertParametersPrefix(ОбщийЖурнал.Names.Наследник + ".");
                NsgCompare periodCompare = m_compare.Clone;
                m_compare.Add(filter);
                //m_compare.InsertParametersPrefix(ОбщийЖурнал.Names.Наследник + ".");
                ОбщийЖурнал журнал = ОбщийЖурнал.Новый();
                // фильтр по типам документов(справочника) операция or
                List<NsgCompareParam> parG = new List<NsgCompareParam>();
                List<NsgDataDocument> документыБезЖернала = new List<NsgDataDocument>();

                var table = vmo2NsgListViewElem.Data.MemoryTable;
                foreach (var row in table.Rows)
                {
                    var gid = (Guid)row[vmo2elem_Gid.Name].Value;
                    var mo = dictDest[gid] as NsgDataDocument;
                    if (mo != null)
                    {
                        if (mo.UseCommonJournal)
                            parG.Add(new NsgCompareParam(ОбщийЖурнал.Names.Наследник, mo, NsgComparison.TypeEqual));
                        else
                            документыБезЖернала.Add(mo);
                    }
                }
                #region Проведение по общему журналу
                if (parG.Count > 0)
                {
                    NsgCompare com = new NsgCompare(parG.ToArray());
                    com.LogicalOperator = NsgLogicalOperator.Or;
                    NsgCompare comAll = new NsgCompare();// объединяем compare
                    #region TODO: Порядок условий НЕ МЕНЯТЬ !!!
                    comAll.Add(m_compare);
                    comAll.Add(com);
                    // TODO: Данные строки в настоящий момент просто "убивают" sql-server
                    //    comAll.Add(ОбщийЖурнал.Names.Наследник + "." + ОбщийЖурнал.Names.СостояниеДокумента, СостоянияОбъекта.Проведен);
                    //    comAll.Add(ОбщийЖурнал.Names.Наследник + "." + ОбщийЖурнал.Names.СостояниеДокумента, СостоянияОбъекта.Удален, NsgComparison.NotEqual);
                    if (checkBoxRehandle.Checked)
                    {
                        // только перепроведение
                        comAll.Add(ОбщийЖурнал.Names.СостояниеДокумента, СостоянияОбъекта.Проведен);
                    }
                    else
                    {
                        comAll.Add(ОбщийЖурнал.Names.СостояниеДокумента, СостоянияОбъекта.Удален, NsgComparison.NotEqual);
                    }

                    #endregion TODO: Порядок условий НЕ МЕНЯТЬ !!!
                    NsgVirtualCursor<NsgMultipleObject> obj = журнал.GetNewVirtualCursor<NsgMultipleObject>();
                    obj.Comparison = comAll;
                    obj.Sorting = new NsgSorting(new NsgSortingParam(ОбщийЖурнал.Names.ДатаДокумента));
                    //считывает по NsgSettings.MaxRowsToFetch объектов NsgMultipleObject 
                    int count = obj.CountRow;
                    if (count == 0) return;
                    int counter = 0;
                    do
                    {
                        NsgMultipleObject o = obj.Next;
                        if (o != null)
                        {
                            counter++;
                            //TODO:Убрать после исправления фильтра по ObjectState интерфейса
                            NsgDataDocument doc = (o as ОбщийЖурнал).Наследник as NsgDataDocument;

                            int curProc = (int)(counter * 100 / count);
                            nsgBackgroundProcessing.ReportProgress(curProc, "Текущий документ: '" + doc + "'");

                            if (doc.ObjectState != NsgObjectStates.Empty)
                            {
                                try
                                {
                                    // если еще не проведен
                                    if (doc.State != NsgDataDocState.Handled || checkBoxRehandle.Checked)
                                    {
                                        //if (doc is Документы.РасходнаяНакладная)
                                        //    (doc as Документы.РасходнаяНакладная).ОтменаКонтроляСостоянияЗаказов = true;
                                        //if (doc is Документы.ЗаявкиПокупателей)
                                        //    (doc as Документы.ЗаявкиПокупателей).ОтменаКонтроляСостоянияЗаказов = true;
                                        doc.Handle();
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Exception showEx = new Exception("Ошибка проведения документа '" + doc + "'", ex);
                                    NsgSettings.MainForm.ShowMessage(showEx);
                                }
                            }
                        }
                        else
                            break;
                    }
                    while (true);// цикл 
                }
                #endregion

                #region Проведение документов, не входящих в общий журнал
                foreach (var currentDoc in документыБезЖернала)
                {
                    NsgVirtualCursor<NsgDataDocument> obj = currentDoc.GetNewVirtualCursor<NsgDataDocument>();
                    obj.Comparison = nsgObjectFilter.Compare.Clone;
                    obj.Comparison.Add(periodCompare);
                    obj.Sorting = new NsgSorting(new NsgSortingParam(ОбщийЖурнал.Names.ДатаДокумента));
                    //считывает по NsgSettings.MaxRowsToFetch объектов NsgMultipleObject 
                    int count = obj.CountRow;
                    if (count == 0) return;
                    int counter = 0;
                    do
                    {
                        NsgDataDocument doc = obj.Next;
                        if (doc != null)
                        {
                            counter++;

                            int curProc = (int)(counter * 100 / count);
                            nsgBackgroundProcessing.ReportProgress(curProc, "Текущий документ: '" + doc + "'");

                            if (doc.ObjectState != NsgObjectStates.Empty)
                            {
                                try
                                {
                                    // если еще не проведен
                                    if (doc.State != NsgDataDocState.Handled || checkBoxRehandle.Checked)
                                    {
                                        //if (doc is Документы.РасходнаяНакладная)
                                        //    (doc as Документы.РасходнаяНакладная).ОтменаКонтроляСостоянияЗаказов = true;
                                        //if (doc is Документы.ЗаявкиПокупателей)
                                        //    (doc as Документы.ЗаявкиПокупателей).ОтменаКонтроляСостоянияЗаказов = true;
                                        doc.Handle();
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Exception showEx = new Exception("Ошибка проведения документа '" + doc + "'", ex);
                                    NsgSettings.MainForm.ShowMessage(showEx);
                                }
                            }
                        }
                        else
                            break;
                    }
                    while (true);
                }
                #endregion
                return;
            }
            #endregion
            #region Пометки на удаление, отмена проведения, перезапись
            
            int typeCount = dictDest.Count;
            int typeCounter = 0;
            float procPerCicle = (float)100 / (float)typeCount;

            var enm = dictDest.GetEnumerator();
            while(enm.MoveNext())
            {

                int initProcent = (int)(typeCounter * 100 / typeCount);
                List<NsgMultipleObject> objlist = new List<NsgMultipleObject>();
                NsgMultipleObject MO = enm.Current.Value;
                NsgVirtualCursor<NsgMultipleObject> obj = MO.GetNewVirtualCursor<NsgMultipleObject>();
                Dictionary<string, NsgMultipleObject> МасКодов = new Dictionary<string, NsgMultipleObject>();
                m_compare.Add(nsgObjectFilter.Compare);
                if (m_selectItem == "Справочники" && (m_selectItemActions == "Групповой ввод значений" || m_selectItemActions == "Групповой ввод значений в таблицу") && ИмяСправочника != null)
                {
                    m_compare.Add(nsgObjectFilter.GetCompare(ИмяСправочника, "Идентификатор"));
                }
                if (m_selectItem == "Справочники" && m_selectItemActions == "Пометить на удаление")
                    m_compare.Add(NsgDataFixedFields._State, Сервис.СостоянияОбъекта.Предопределенный, NsgComparison.NotEqual);
                obj.Comparison = m_compare;
                int rowCount = obj.CountRow;
                int rowCounter = 0;
                //считывает по NsgSettings.MaxRowsToFetch объектов NsgMultipleObject 
                NsgMultipleObject objectRead = null;
                do
                {
                    objectRead = obj.Next;
                    rowCounter++;
                    if (objectRead != null)
                        objlist.Add(objectRead);
                    // обработать список объектов
                    if ((objlist.Count == NsgSettings.MaxRowsToFetch || objectRead == null) && objlist.Count > 0)
                    {
                        // прогресс
                        int curProc = initProcent + (int)(rowCounter * procPerCicle / rowCount);
                        nsgBackgroundProcessing.ReportProgress(curProc, "Обрабатываются объекты типа '" +
                            MO.FullName + "' " + (rowCounter - objlist.Count) + " - " + rowCounter + " из " + rowCount);
                        // обработка
                        if (m_selectItemActions == "Пометить на удаление")
                        {
                            //Заменил на штучное удаление, т.к. массовое почему-то не работает
                            //foreach (NsgMultipleObject mo in objlist)
                            //    mo.SetDeleteMark();
                            MO.SetDeleteMark(objlist.ToArray());
                        }
                        if (m_selectItemActions == "Снять пометку удаления")
                        {
                            MO.UnSetDeleteMark(objlist.ToArray());
                        }
                        if (m_selectItemActions == "Отменить проведение" && m_selectItem == "Документы")
                        {
                            foreach (NsgDataDocument objec in objlist)
                            {
                                try
                                {
                                    // прогресс
                                    nsgBackgroundProcessing.ReportProgress(curProc, "Отмена проведения документа: '" + objec + "'");
                                    // отмена проведения
                                    objec.Unhandle();
                                }
                                catch (Exception ex)
                                {
                                    Exception showEx = new Exception("Ошибка при отмене проведения документа '" + objec + "'", ex);
                                    NsgSettings.MainForm.ShowMessage(showEx);
                                }
                            }
                        }
                        if (m_selectItemActions == "Перезаписать")
                        {
                            foreach (NsgMultipleObject objec in objlist)
                            {
                                try
                                {
                                    // прогресс
                                    nsgBackgroundProcessing.ReportProgress(curProc, "Перезапись объекта: '" + objec + "'");
                                    //перезаписать
                                    objec.Edit();
                                    objec.IsModify = true;
                                    objec.Post();
                                }
                                catch (Exception ex)
                                {
                                    Exception showEx = new Exception("Ошибка при перезаписи объекта '" + objec + "'", ex);
                                    NsgSettings.MainForm.ShowMessage(showEx);
                                }
                            }
                        }
                        if (m_selectItemActions == "Перенумерация кодов")
                        {
                            foreach (NsgMultipleObject objec in objlist)
                            {
                                try
                                {
                                    if (!МасКодов.ContainsKey(objec[NsgDataFixedFields._Code].ToString()))
                                    {
                                        МасКодов.Add(objec[NsgDataFixedFields._Code].ToString(), objec);
                                    }
                                    else
                                    {
                                        string before = objec[NsgDataFixedFields._Code].ToString();
                                        objec.Edit();
                                        objec.IsModify = true;
                                        objec[NsgDataFixedFields._CodeNumber].Value = 0;
                                        objec.Post();
                                        var str = "код " + before.ToString() + " элемента \"" + objec[NsgDataFixedFields._Naimenovanie].ToString() + "\" изменен на ";
                                        str += objec[NsgDataFixedFields._Code].ToString();
                                        NsgSettings.MainForm.ShowMessage(str);

                                    }
                                    nsgBackgroundProcessing.ReportProgress(curProc, "Чтение объекта: '" + objec + "'");
                                }
                                catch (Exception ex)
                                {
                                    Exception showEx = new Exception("Ошибка при переномерации объекта '" + objec + "'", ex);
                                    NsgSettings.MainForm.ShowMessage(showEx);
                                }
                            }
                        }
                        if (m_selectItemActions == "Групповой ввод значений")
                        {
                            List<String> List = new List<String>();
                            foreach (var col in nsgInputFilter.SourceObject.Data.MemoryTable.ObjectList.All)
                            {
                                if (!nsgInputFilter.GetCompare(col.Name).IsEmpty)
                                    List.Add(col.Name);
                            }
                            foreach (NsgMultipleObject objec in objlist)
                            {
                                try
                                {
                                    objec.Edit();
                                    foreach (String col in List)
                                    {
                                        object ParamValue = nsgInputFilter.GetCompare(col).Parameters[0].ParameterValue;
                                        while (ParamValue is NsgCompare) ParamValue = (ParamValue as NsgCompare).Parameters[0].ParameterValue;
                                        objec[col].Value = ParamValue;
                                    }
                                    if (checkBoxRehandle.Checked && objec is NsgDataDocument && objec.State == NsgDataDocState.Handled)
                                        (objec as NsgDataDocument).Handle();
                                    else
                                        objec.Post();
                                    
                                    nsgBackgroundProcessing.ReportProgress(curProc, "Обновление объекта: '" + objec + "'");
                                }
                                catch (Exception ex)
                                {
                                    Exception showEx = new Exception("Ошибка при изменении объекта '" + objec + "'", ex);
                                    NsgSettings.MainForm.ShowMessage(showEx);
                                }
                            }
                        }
                        if (m_selectItemActions == "Групповой ввод значений в таблицу")
                        {
                            var List = new List<String>();
                            foreach (var col in nsgInputFilter.SourceObject.Data.MemoryTable.ObjectList.All)
                            {
                                if (!nsgInputFilter.GetCompare(col.Name).IsEmpty)
                                    List.Add(col.Name);
                            }
                            foreach (NsgMultipleObject objec in objlist)
                            {
                                try
                                {
                                    NsgReferencedObject refTable = null;
                                    if (!String.IsNullOrEmpty(selectedTab))
                                        refTable = objec.ObjectList[selectedTab].ToReferent();
                                    var table = refTable as NsgDataTable;
                                    if (table == null) continue;
                                    
                                    //предварительный поиск
                                    NsgDataTableRow[] rows = table.FindRows(nsgInputFilterTableDoc.Compare);

                                    if (rows.Length > 0)
                                    {
                                        objec.Edit();
                                        // поиск для изменений (не удалять !!!, т.к. поиск до Edit и последущие изменение этих строк бесполезно по определению)
                                        refTable = objec.ObjectList[selectedTab].ToReferent();
                                        table = refTable as NsgDataTable;
                                        rows = table.FindRows(nsgInputFilterTableDoc.Compare);

                                        foreach (NsgDataTableRow row in rows)
                                        {
                                            row.Edit();
                                            foreach (String col in List)
                                            {
                                                object ParamValue =
                                                    nsgInputFilter.GetCompare(col).Parameters[0].ParameterValue;
                                                while (ParamValue is NsgCompare)
                                                    ParamValue = (ParamValue as NsgCompare).Parameters[0].ParameterValue;
                                                row[col].Value = ParamValue;
                                            }
                                            row.Post();
                                        }
                                        if (objec is NsgDataDocument && objec.State == NsgDataDocState.Handled)
                                            (objec as NsgDataDocument).Handle();
                                        else
                                            objec.Post();
                                    }

                                    nsgBackgroundProcessing.ReportProgress(curProc, "Обновление объекта: '" + objec + "'");
                                }
                                catch (Exception ex)
                                {
                                    Exception showEx = new Exception("Ошибка при изменении объекта '" + objec + "'", ex);
                                    NsgSettings.MainForm.ShowMessage(showEx);
                                }
                            }
                        }
                        objlist.Clear();
                    }
                }
             
                while (objectRead != null);// цикл 
                typeCounter++;             
            }            
              
            #endregion
        }
        #endregion

        #region (ПроверкаВводимыхЗначений)
        private bool ПроверкаВводимыхЗначений()
        {
            bool result = false;
            //bool свНом = true;// Константы.КонстантыОбщие.ДляВсехПользователей.ИспользоватьСвойстваНоменклатуры;
            //bool хаНом = Константы.КонстантыОбщие.ДляВсехПользователей.ИспользоватьХарактеристикиНоменклатуры;
            var ListVal = new List<String>();
            foreach (var col in nsgInputFilter.SourceObject.Data.MemoryTable.ObjectList.All)
            {
                if (!nsgInputFilter.GetCompare(col.Name).IsEmpty)
                    ListVal.Add(col.Name);
            }
            foreach (String colVal in ListVal)
            {
                string strOwner = nsgInputFilter.GetCompare(colVal).Parameters[0].ParameterName;
                foreach (var col in nsgInputFilter.SourceObject.Data.MemoryTable.ObjectList.All)
                {
                    if (nsgInputFilter.GetCompare(col.Name).IsEmpty)
                    {
                        if (col is NsgReference)
                        {
                            var refObj = col as NsgReference;
                            //if (!свНом)
                            //{
                            //    if (refObj.ToReferent().Name == СлужебныеСправочники.ДополнительныеСвойстваНоменклатуры.Новый().Name)
                            //        continue;
                            //}
                            //if (!хаНом)
                            //{
                            //    if (refObj.ToReferent().Name == Справочники.ХарактеристикиНоменклатуры.Новый().Name)
                            //        continue;
                            //}
                            if (refObj.OwnerName == strOwner)
                            {
                                NsgSettings.MainForm.ShowMessage("В фильтре вводимые значения не заданы подчиненные значения: " + refObj.Presentation, MessageBoxIcon.Error);
                                result = true;
                            }
                        }
                    }
                }
            }
            return result;
        }
        #endregion

        #region (createReport)
        /// <summary>
        /// Метод вывода отчета - реестр документов.
        /// </summary>
        /// <param name="cmp">Параметры выборки.</param>
        /// <param name="objects">Список объектов.</param>
        protected void createReport(NsgCompare cmp, NsgMultipleObject[] objects)
        {
            nsgОтчет.Data.MemoryTable.Clear();
            NsgMemoryTableRow row = null;
            foreach (NsgMultipleObject moObj in objects)
            {
                if (moObj != null)
                {
                    NsgMultipleObject mo = moObj;
                    // для характеристик - подменить на табл.движений
                    if (moObj is NsgDataCharacteristics)
                        mo = (moObj as NsgDataCharacteristics).MovementTable;
                    NsgVirtualCursor<NsgMultipleObject> curs = mo.GetNewVirtualCursor<NsgMultipleObject>();
                    curs.Comparison = m_compare;
                    curs.Sorting = moObj.DefaultSorting;
                    //считывает по NsgSettings.MaxRowsToFetch объектов NsgMultipleObject 
                    do
                    {
                        NsgMultipleObject o = curs.Next;
                        if (o == null)
                            break;
                        row = nsgОтчет.Data.MemoryTable.NewRow();
                        row[ЛюбойДокумент.Name].Value = o;
                    }
                    while (true);
                }
            }
            //------end
            List<string> CheckItem = new List<string>();
            CheckItem.Clear();
            CheckItem.AddRange(nsgGroupsList.GetCheckItems());
            //    nsgReport1.RegData(nsgReportDataSource1.Name, nsgReportDataSource1.UserData);
            List<string> list = new List<string>(nsgReport1.ReferencedAssemblies);
            //list.Add("Торговля.exe");
            //list.Add("NsgSoft.DataObjects.dll");
            //list.Add("NsgSoft.Design.dll");
            nsgReport1.LoadReport();
            nsgReport1.ReferencedAssemblies = list.ToArray();
            //Создаем список компонентов и располагаем их на листе в нужном порядке 
            //но сначала удаляем их из страницы
            StiComponentsCollection colec = nsgReport1.GetComponents();
            StiPagesCollection page = nsgReport1.Pages;
            StiHeaderBand headerBand = new StiHeaderBand();
            StiDataBand dataBend = new StiDataBand();
            headerBand = colec["ЗаголовокДанных1"] as StiHeaderBand;
            dataBend = colec["Данные1"] as StiDataBand;
            headerBand.SelectAll();
            headerBand.RemoveAllSelected();
            dataBend.SelectAll();
            dataBend.RemoveAllSelected();
            //---
            StiText dataText2 = new StiText(new RectangleD(0, 0, 6, 0.6));
            dataText2.Text = "Документ";
            dataText2.Height = 0.6;
            dataText2.Width = 6;
            dataText2.HorAlignment = StiTextHorAlignment.Center;
            dataText2.VertAlignment = StiVertAlignment.Center;
            dataText2.Name = "DataText" + "HederFirst" + "1";
            dataText2.Border.Color = Color.Black;
            dataText2.Border.Style = StiPenStyle.Solid;
            dataText2.Border.Side = StiBorderSides.All;
            dataText2.Border.ShadowSize = 6;
            headerBand.Components.Add(dataText2);
            double i = 9;
            foreach (string datastring in CheckItem)
            {
                StiText dataText = new StiText(new RectangleD(i - 3, 0, i, 0.6));
                dataText.Text = datastring;
                dataText.Height = 0.6;
                dataText.Width = 3;
                dataText.HorAlignment = StiTextHorAlignment.Center;
                dataText.VertAlignment = StiVertAlignment.Center;
                dataText.Name = "DataText" + datastring + "1";
                dataText.Border.Color = Color.Black;
                dataText.Border.Style = StiPenStyle.Solid;
                dataText.Border.Side = StiBorderSides.All;
                dataText.Border.ShadowSize = 3;
                headerBand.Components.Add(dataText);
                i += 3;
            }
            StiText dataText1 = new StiText(new RectangleD(0, 0, 6, 0.4));
            dataText1.Height = 0.4;
            dataText1.Width = 6;
            dataText1.HorAlignment = StiTextHorAlignment.Left;
            dataText1.VertAlignment = StiVertAlignment.Center;
            //  dataText1.t
            dataText1.Name = "Data" + "First" + "1";
            dataText1.Text = "{nsgReportDataSource1." + ЛюбойДокумент.Name + "}";
            dataText1.Border.Color = Color.Black;
            dataText1.Border.Style = StiPenStyle.Solid;
            dataText1.Border.Side = StiBorderSides.All;
            dataText1.Border.ShadowSize = 3;
            dataText1.TextOptions = new NsgSoft.ReportBase.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            dataText1.CanGrow = true;
            dataBend.Components.Add(dataText1);
            double j = 9;
            foreach (string datastring in CheckItem)
            {
                StiText dataText = new StiText(new RectangleD(j - 3, 0, j, 0.4));
                dataText.Height = 0.4;
                dataText.Width = 3;
                dataText.HorAlignment = StiTextHorAlignment.Center;
                dataText.VertAlignment = StiVertAlignment.Center;
                dataText.Name = "Data" + datastring + "1";
                dataText.Text = "{nsgReportDataSource1." + ЛюбойДокумент.Name + "[\"" + datastring + "\"]" + "}";
                dataText.Border.Color = Color.Black;
                dataText.Border.Style = StiPenStyle.Solid;
                dataText.Border.Side = StiBorderSides.All;
                dataText.Border.ShadowSize = 3;
                dataText.GrowToHeight = true;
                dataBend.Components.Add(dataText);
                j += 3;
            }
            nsgReport1.ShowReport(null);
        }
        #endregion

        #endregion

        #region Обработка событий формы

        #region Обработка Drag & Drop

        void Grid_DragDropTypes(object sender, DragEventArgs e)
        {
            nsgListViewTypes_DragDrop(sender, e);
        }

        void Grid_DragOverTypes(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        void Grid_DragDropElems(object sender, DragEventArgs e)
        {
            nsgListViewElems_DragDrop(sender, e);
        }

        void Grid_DragOverElems(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        void nsgListViewElems_CellRequestEdit(object sender, NsgIGrid.NsgIGridCellEventArgs e)
        {
            e.Cancel = true;
        }

        void nsgListViewTypes_CellRequestEdit(object sender, NsgIGrid.NsgIGridCellEventArgs e)
        {
            e.Cancel = true;
        }

     

        #region (nsgListViewTypes_DragDrop)
        protected void nsgListViewTypes_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(List<NsgMultipleObject>)))
            {
                vmo2NsgListViewElem.Data.BeginUpdateData();
                nsgVisualMultipleObject2.Data.BeginUpdateData();

                var list = e.Data.GetData(typeof(List<NsgMultipleObject>)) as List<NsgMultipleObject>;
                var table = vmo2NsgListViewElem.Data.MemoryTable;

                foreach (var mo in list)
                {
                    var guid = mo.Guid;
                    if (dictSource.ContainsKey(guid)) continue;

                    sourceTableAddRow(mo);
                    dictDest.Remove(mo.Guid);
                    foreach (var row in table.Rows)
                        if ((Guid)row[vmo2elem_Gid.Name].Value == mo.Guid)
                        {
                            table.DeleteRow(row);
                            break;
                        }
                }
                vmo2NsgListViewElem.Data.UpdateDataSync(this);
                nsgVisualMultipleObject2.Data.UpdateDataSync(this);

                ПолучениеЗначенийДляФильтра();
            }
        }
        #endregion

        #region (nsgListViewTypes_DragEnter)
        protected void nsgListViewTypes_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(List<NsgMultipleObject>)))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }
        #endregion

        #region (nsgListViewTypes_CellStartDrag)
        void nsgListViewTypes_CellStartDrag(object sender, NsgIGrid.NsgIGridCellEventArgs e)
        {           
            var rowDrag = e.RowObject;
            var selGuid = (Guid)rowDrag[vmo2_Gid.Name].Value;
            var isSelect = false;

            var items = new List<NsgMultipleObject>();
            var selected = nsgListViewTypes.Grid.MultiSelectData.GetResultSelectedIndexesZeroBased();
            var table = nsgVisualMultipleObject2.Data.MemoryTable;
            for (int i = 0, c = selected.Length; i < c; i++)
            {
                var index = selected[i];
                if (index < 0) continue;
                var row = table.Rows[index];
                var gid = (Guid)row[vmo2_Gid.Name].Value;
                if (gid == selGuid) isSelect = true;
                var mo = dictSource[gid]; 
                if (mo != null) items.Add(mo);
            }
            if (isSelect == false)
            {
                items.Clear();
                var mo = dictSource[selGuid];
                items.Add(mo);
            }
            if (items.Count > 0)
                nsgListViewTypes.DoDragDrop(items, DragDropEffects.All);
            else
                e.Cancel = true;
        }
        #endregion

        #region (nsgListViewElems_CellStartDrag)
        void nsgListViewElems_CellStartDrag(object sender, NsgIGrid.NsgIGridCellEventArgs e)
        {
            var rowDrag = e.RowObject;
            var selGuid = (Guid)rowDrag[vmo2elem_Gid.Name].Value;
            var isSelect = false;

            var items = new List<NsgMultipleObject>();
            var selected = nsgListViewElems.Grid.MultiSelectData.GetResultSelectedIndexesZeroBased();
            var table = vmo2NsgListViewElem.Data.MemoryTable;
            for (int i = 0, c = selected.Length; i < c; i++)
            {
                var index = selected[i];
                if (index < 0) continue;
                var row = table.Rows[index];
                var gid = (Guid)row[vmo2elem_Gid.Name].Value;
                if (gid == selGuid) isSelect = true;
                var mo = dictDest[gid];
                if (mo != null) items.Add(mo);
            }
            if (isSelect == false)
            {
                items.Clear();
                var mo = dictDest[selGuid];
                items.Add(mo);
            }
            if (items.Count > 0)
                nsgListViewElems.DoDragDrop(items, DragDropEffects.All);
            else
                e.Cancel = true;
        }
        #endregion

        #region (nsgListViewElems_DragDrop)
        protected void nsgListViewElems_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(List<NsgMultipleObject>)))
            {
                vmo2NsgListViewElem.Data.BeginUpdateData();
                nsgVisualMultipleObject2.Data.BeginUpdateData();
            
                var list = e.Data.GetData(typeof(List<NsgMultipleObject>)) as List<NsgMultipleObject>;
                var table = nsgVisualMultipleObject2.Data.MemoryTable;

                foreach (var mo in list)
                {
                    var guid = mo.Guid;
                    if (dictDest.ContainsKey(guid)) continue;

                    destTableAddRow(mo);
                    dictSource.Remove(mo.Guid);                    
                    foreach(var row in table.Rows)
                        if ((Guid)row[vmo2_Gid.Name].Value == mo.Guid) {
                            table.DeleteRow(row);
                            break;
                        }
                }
                vmo2NsgListViewElem.Data.UpdateDataSync(this);
                nsgVisualMultipleObject2.Data.UpdateDataSync(this);

                ПолучениеЗначенийДляФильтра();
            }
        }
        #endregion

        #region (nsgListViewElems_DragEnter)
        protected void nsgListViewElems_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(List<NsgMultipleObject>)))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }
        #endregion

        /*
        void nsgListViewTypes_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;            
        }
         
        void nsgListViewElems_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;            
        }
        */
        #endregion

        #region (comboBoxActions_SelectedValueChanged)
        /// <summary>
        /// Обработчик изменения типа обработки.
        /// </summary>
        protected void comboBoxActions_SelectedValueChanged(object sender, EventArgs e)
        {
            // TODO: временно, пока нет выгрузки в 1С
            labelFormat.Enabled = comboBoxFormat.Enabled = false;
            m_selectItemActions = comboBoxAction.SelectedItem.ToString();
            if (m_selectItemActions == "Выгрузить в файл")
            {
                groupBoxChars.Enabled = /*labelFormat.Enabled = comboBoxFormat.Enabled = */
                    checkBoxBindedObjects.Enabled = true;
            }
            else
            {
                groupBoxChars.Enabled = labelFormat.Enabled = comboBoxFormat.Enabled =
                    checkBoxBindedObjects.Enabled = false;
            }
            checkBoxRehandle.Enabled = (m_selectItemActions == "Провести" || (m_selectItemActions == "Групповой ввод значений" && m_selectItem == "Документы"));
            if (m_selectItemActions == "Групповой ввод значений")
            {
                if (!tabControl1.TabPages.Contains(tabPage3))
                    tabControl1.TabPages.Add(tabPage3);
            }
            else if (m_selectItemActions == "Групповой ввод значений в таблицу")
            {
                //удаляем перед добавлением, чтобы закладки следовали всегда в определенном порядке
                if (tabControl1.TabPages.Contains(tabPage4))
                    tabControl1.TabPages.Remove(tabPage4);
                if (tabControl1.TabPages.Contains(tabPage3))
                    tabControl1.TabPages.Remove(tabPage3);
                if (!tabControl1.TabPages.Contains(tabPage4))
                    tabControl1.TabPages.Add(tabPage4);
                if (!tabControl1.TabPages.Contains(tabPage3))
                    tabControl1.TabPages.Add(tabPage3);
                label3.Visible = true;
                comboBoxTable.Visible = true;
                label6.Visible = true;
            }
            else
            {
                if (tabControl1.TabPages.Contains(tabPage4))
                    tabControl1.TabPages.Remove(tabPage4);
                if (tabControl1.TabPages.Contains(tabPage3))
                    tabControl1.TabPages.Remove(tabPage3);
                label3.Visible = false;
                comboBoxTable.Visible = false;
                label6.Visible = false;
                comboBoxTable.Items.Clear();
            }
            ПолучениеЗначенийДляФильтра();
        }
        #endregion

        #region (comboBoxTypes_SelectedValueChanged)
        /// <summary>
        /// Обработчик изменения типа объектов.
        /// </summary>
        protected void comboBoxTypes_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBoxTypes.SelectedItem == null)
            {
                m_selectItem = "";
                return;
            }
            string selectedNew = comboBoxTypes.SelectedItem.ToString();
            if (selectedNew == m_selectItem) return;

            // --- 
            NsgCompare compare = nsgVisualMultipleObject2.Data.GetComparison(this);
            compare.ClearList();
            // текущая кнопка
            string str = "";                                   
            // --- 

            // состояние начальное
            setInitFormState(true);
            setWorkFormState(false);
            // выбранная группа
            m_selectItem = selectedNew;
            // очистить списки
            
            vmo2NsgListViewElem.Data.BeginUpdateData();
            vmo2NsgListViewElem.Data.MemoryTable.DeleteAll();
            dictDest.Clear();
            vmo2NsgListViewElem.Data.UpdateDataSync(this);
            

            nsgObjectFilter.BeginUpdateStructure();
            nsgObjectFilter.Columns.Clear();
            nsgObjectFilter.EndUpdateStructure(true);

            if (m_selectItem == "Документы")
            {
                //---
                str = typeof(NsgDataDocument).Name;
                //---
                // включить период для документов
                label4.Enabled = nsgPeriodPickerPeriod.Enabled = true;
                checkBoxRehandle.Enabled = true;
                // добавить доступные действия
                comboBoxAction.Items.Clear();
                m_list.Clear();
                m_list.Add("");
                m_list.Add("Провести");
                m_list.Add("Отменить проведение");
                m_list.Add("Пометить на удаление");
                m_list.Add("Снять пометку удаления");
                m_list.Add("Перезаписать");
                m_list.Add("Выгрузить в файл");
                m_list.Add("Групповой ввод значений");
                m_list.Add("Групповой ввод значений в таблицу");
                comboBoxAction.Items.AddRange(m_list.ToArray());
                m_ChooseDoc = m_selectItem;
            }
            else if (m_selectItem == "Справочники")
            {
                //---
                 str = typeof(NsgDataDictionary).Name;
                //---
                // отключить период для справочников
                label4.Enabled = nsgPeriodPickerPeriod.Enabled = false;
                checkBoxRehandle.Enabled = false;
                // добавить доступные действия
                comboBoxAction.Items.Clear();
                m_list.Clear();
                m_list.Add("");
                m_list.Add("Пометить на удаление");
                m_list.Add("Снять пометку удаления");
                m_list.Add("Перезаписать");
                m_list.Add("Выгрузить в файл");
                m_list.Add("Перенумерация кодов");
                m_list.Add("Групповой ввод значений");
                m_list.Add("Групповой ввод значений в таблицу");
                comboBoxAction.Items.AddRange(m_list.ToArray());
                m_ChooseDoc = m_selectItem;
            }
            else if (m_selectItem == "Характеристики")
            {
                //---
                 str = typeof(NsgDataCharacteristics).Name;
                //---
                // включить период для Характеристики
                label4.Enabled = nsgPeriodPickerPeriod.Enabled = true;
                checkBoxRehandle.Enabled = false;
                // добавить доступные действия
                comboBoxAction.Items.Clear();
                m_list.Clear();
                m_list.Add("");
                m_list.Add("Выгрузить в файл");
                comboBoxAction.Items.AddRange(m_list.ToArray());
                m_ChooseDoc = m_selectItem;
            }
            else if (m_selectItem == "Регистры")
            {
                //---
                str = typeof(NsgDataRegister).Name;
                //---
               
                // включить период для Характеристики
                label4.Enabled = nsgPeriodPickerPeriod.Enabled = true;
                checkBoxRehandle.Enabled = false;
                // добавить доступные действия
                comboBoxAction.Items.Clear();
                m_list.Clear();
                m_list.Add("");
                m_list.Add("Выгрузить в файл");
                comboBoxAction.Items.AddRange(m_list.ToArray());
                m_ChooseDoc = m_selectItem;
            }
            //---
            // если заданы типы на фильтрацию
            //if (!string.IsNullOrEmpty(str)) compare.Add(new NsgCompareParam(CATEGORY, str));
            //vmo2NsgListViewTypes.Data.UpdateDataAsync(this);
            //---

            comboBoxAction.SelectedIndex = 0;
            // загрузить типы
            LoadObject(m_selectItem);
        }
        #endregion

        #region (nsgClose_Click)
        /// <summary>
        /// Обработчик кнопки ЗАКРЫТЬ.
        /// </summary>
        protected void nsgClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region (nsgShowObject_Click)
        /// <summary>
        /// Обработчик кнопки РЕЕСТР ДОКУМЕНТОВ.
        /// </summary>
        protected void nsgShowObject_Click(object sender, EventArgs e)
        {
            m_compare.ClearList();
            if (m_selectItem == "Документы")
            {
                //по наложеным фильтрам вывести все документы 
                NsgCompareParam par1 = new NsgCompareParam(NsgDataFixedFields._Date,
                    nsgPeriodPickerPeriod.Period.End, NsgComparison.LessOrEqual);
                par1.Name = "От";
                NsgCompareParam par2 = new NsgCompareParam(NsgDataFixedFields._Date,
                    nsgPeriodPickerPeriod.Period.Begin, NsgComparison.GreaterOrEqual);
                par2.Name = "До";
                m_compare.Add(par1);
                m_compare.Add(par2);
            }
            if (m_selectItem == "Характеристики" || m_selectItem == "Регистры")
            {
                //по наложеным фильтрам вывести все документы 
                NsgCompareParam par1 = new NsgCompareParam(NsgDataFixedFields._Date,
                    nsgPeriodPickerPeriod.Period.End, NsgComparison.LessOrEqual);
                par1.Name = "От";
                NsgCompareParam par2 = new NsgCompareParam(NsgDataFixedFields._DateEnd,
                    nsgPeriodPickerPeriod.Period.Begin, NsgComparison.Greater);
                par2.Name = "До";
                m_compare.Add(par1);
                m_compare.Add(par2);
            }
            
            m_compare.Add(nsgObjectFilter.Compare);
            // получить список

            NsgMultipleObject[] list = new NsgMultipleObject[dictDest.Count];
            dictDest.Values.CopyTo(list, 0);
            
            object[] parameters = new object[] { m_compare, list };
            // вывести отчет
            nsgBackgroundReport.Data = parameters;
            nsgBackgroundReport.OwnerForm = this;
            nsgBackgroundReport.Run();
        }
        #endregion

        #region (nsgProcess_Click)
        /// <summary>
        /// Обработчик кнопки ОБРАБОТКА.
        /// </summary>
        protected void nsgProcess_Click(object sender, EventArgs e)
        {
            if (m_selectItemActions == string.Empty)
            {
                MessageBox.Show("действие не выбрано", "операция не возможна", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            else if (dictDest.Count == 0)
            {
                MessageBox.Show("не выбраны элементы", "операция не возможна", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            
            // задать источник для прогресса
            if (m_selectItemActions == "Выгрузить в файл")
            {
                // выбрать файл
                if (saveFileDialogExport.ShowDialog(this) == DialogResult.OK)
                {
                    fileName = saveFileDialogExport.FileName;
                    nsgProgressBar.ProgressProvider = nsgDataExchangeService;
                }
                else
                    return;
            }
            else
                nsgProgressBar.ProgressProvider = nsgBackgroundProcessing;
            // задать параметры сравнения
            m_compare.ClearList();
            if (m_selectItem == "Документы")
            {
                //по наложеным фильтрам вывести все документы 
                NsgCompareParam par1 = new NsgCompareParam(NsgDataFixedFields._Date, nsgPeriodPickerPeriod.Period.Begin, NsgComparison.GreaterOrEqual);
                par1.Name = "От";
                nsgDataExchangeService.DateBeginExport = nsgPeriodPickerPeriod.Period.Begin;
                NsgCompareParam par2 = new NsgCompareParam(NsgDataFixedFields._Date, nsgPeriodPickerPeriod.Period.End, NsgComparison.LessOrEqual);
                par2.Name = "До";
                nsgDataExchangeService.DateEndExport = nsgPeriodPickerPeriod.Period.End;
                m_compare.Add(par1);
                m_compare.Add(par2);
            }
            if (m_selectItem == "Характеристики")
            {
                //по наложеным фильтрам
                if (radioButtonCharActive.Checked)
                {
                    NsgCompareParam par1 = new NsgCompareParam(NsgDataFixedFields._DateEnd,
                        nsgPeriodPickerPeriod.Period.Begin, NsgComparison.Greater);
                    par1.Name = "От";
                    nsgDataExchangeService.DateBeginExport = nsgPeriodPickerPeriod.Period.Begin;
                    NsgCompareParam par2 = new NsgCompareParam(NsgDataFixedFields._Date,
                        nsgPeriodPickerPeriod.Period.End, NsgComparison.LessOrEqual);
                    par2.Name = "До";
                    nsgDataExchangeService.DateEndExport = nsgPeriodPickerPeriod.Period.End;
                    m_compare.Add(par1);
                    m_compare.Add(par2);
                }
                else
                {
                    NsgCompareParam par1 = new NsgCompareParam(NsgDataFixedFields._Date,
                        nsgPeriodPickerPeriod.Period.Begin, NsgComparison.GreaterOrEqual);
                    par1.Name = "От";
                    nsgDataExchangeService.DateBeginExport = nsgPeriodPickerPeriod.Period.Begin;
                    NsgCompareParam par2 = new NsgCompareParam(NsgDataFixedFields._Date,
                        nsgPeriodPickerPeriod.Period.End, NsgComparison.LessOrEqual);
                    par2.Name = "До";
                    nsgDataExchangeService.DateEndExport = nsgPeriodPickerPeriod.Period.End;
                    m_compare.Add(par1);
                    m_compare.Add(par2);
                }
            }
            else if (m_selectItem == "Регистры")
            {
                NsgCompareParam par1 = new NsgCompareParam("ДатаДокумента", nsgPeriodPickerPeriod.Period.Begin, NsgComparison.GreaterOrEqual);
                par1.Name = "От";
                nsgDataExchangeService.DateBeginExport = nsgPeriodPickerPeriod.Period.Begin;
                NsgCompareParam par2 = new NsgCompareParam("ДатаДокумента", nsgPeriodPickerPeriod.Period.End, NsgComparison.LessOrEqual);
                par2.Name = "До";
                nsgDataExchangeService.DateEndExport = nsgPeriodPickerPeriod.Period.End;
                m_compare.Add(par1);
                m_compare.Add(par2);
            }
            // задать транзакцию, если нужно
            if (checkBoxTransaction.Checked == true)
                NsgSettings.BeginTransaction();
            // запустить исполнение потока обработки
            nsgProgressBar.Refresh();
            nsgBackgroundProcessing.OwnerForm = this;
            nsgBackgroundProcessing.Run();
        }
        #endregion

        List<NsgMultipleObject> GetSelectedItems(NsgIGrid grid, Dictionary<Guid, NsgMultipleObject> dict)
        {
            List<NsgMultipleObject> result = new List<NsgMultipleObject>();
            //var hasSelected = false;
            var sel = grid.Grid.SelectedCells;
            var hasSelected = false;// ((sel != null && sel.Count > 0)); //if ((sel != null && sel.Count > 0)) hasSelected = true;

            var isSelect = false;
            var gidCol = grid.SourceObject.Columns[0];

            var selGuid = Guid.Empty;
            //if (hasSelected)
            //{
            //    var indexRow = sel[0].RowIndex - 1;
            //    if (indexRow < 0) return result;
            //    var selRow = grid.SourceObject.Data.MemoryTable.Rows[indexRow];
            //    selGuid = (Guid)selRow[gidCol.Name].Value;
            //}

            var selected = grid.Grid.MultiSelectData.GetResultSelectedIndexesZeroBased();
            var table = grid.SourceObject.Data.MemoryTable;
            
            for (int i = 0, c = selected.Length; i < c; i++)
            {
                var index = selected[i];
                if (index < 0) continue;
                var row = table.Rows[index];
                var gid = (Guid)row[gidCol.Name].Value;
                if (gid == selGuid) isSelect = true;
                var mo = dict[gid];
                if (mo != null) result.Add(mo);
            }
            if (hasSelected && isSelect == false)
            {
                result.Clear();
                var mo = dict[selGuid];
                result.Add(mo);
            }
            return result;
        }

        void MoveItems(
            NsgIGrid gridFrom, 
            Dictionary<Guid, NsgMultipleObject> dictFrom,
            NsgIGrid gridTo,
            Dictionary<Guid, NsgMultipleObject> dictTo,
            Action<NsgMultipleObject> addToDesct) 
        {
            
            gridFrom.SourceObject.Data.BeginUpdateData();
            gridTo.SourceObject.Data.BeginUpdateData();
            var colGid = gridFrom.SourceObject.Columns[0];
            var moList = GetSelectedItems(gridFrom, dictFrom);
            foreach (var mo in moList)
            {
                addToDesct(mo);
                dictFrom.Remove(mo.Guid);
                foreach (var row in gridFrom.SourceObject.Data.MemoryTable.Rows) { 
                    var gid = (Guid)row[colGid.Name].Value;
                    if (gid == mo.Guid) {
                        gridFrom.SourceObject.Data.MemoryTable.DeleteRow(row);
                        break;
                    }
                }
            }
            gridFrom.SourceObject.Data.UpdateDataSync(this);
            gridTo.SourceObject.Data.UpdateDataSync(this);            
        }
        #region (nsgButtonBackOne_Click)
        /// <summary>
        /// Кнопка - ВЫДЕЛЕННЫЕ ЭЛЕМЕНТЫ НАЗАД.
        /// </summary>
        private void nsgButtonBackOne_Click(object sender, EventArgs e)
        {
            MoveItems(nsgListViewElems, dictDest, nsgListViewTypes, dictSource, (mo) => { sourceTableAddRow(mo); });        
            ПолучениеЗначенийДляФильтра();
        }
        #endregion

        #region (nsgButtonSetOne_Click)
        /// <summary>
        /// Кнопка - ВЫДЕЛЕННЫЕ ЭЛЕМЕНТЫ УСТАНОВИТЬ.
        /// </summary>
        private void nsgButtonSetOne_Click(object sender, EventArgs e)
        {
            MoveItems(nsgListViewTypes, dictSource, nsgListViewElems, dictDest, (mo) => { destTableAddRow(mo); });
            ПолучениеЗначенийДляФильтра();
        }
        #endregion

        #region (nsgButtonBackAll_Click)
        /// <summary>
        /// Кнопка - ВСЕ ЭЛЕМЕНТЫ НАЗАД.
        /// </summary>
        private void nsgButtonBackAll_Click(object sender, EventArgs e)
        {
            var table = vmo2NsgListViewElem.Data.MemoryTable;

            nsgVisualMultipleObject2.Data.BeginUpdateData();
          //  nsgVisualMultipleObject2.Data.MemoryTable.DeleteAll();
            foreach (var row in table.Rows)
            {
                var gid = (Guid)row[vmo2elem_Gid.Name].Value;
                var mo = dictDest[gid];
                if (mo != null) sourceTableAddRow(mo);
            }
            nsgVisualMultipleObject2.Data.UpdateDataSync(this);

            vmo2NsgListViewElem.Data.BeginUpdateData();
            vmo2NsgListViewElem.Data.MemoryTable.DeleteAll();
            vmo2NsgListViewElem.Data.UpdateDataSync(this);
            dictDest.Clear();

            ПолучениеЗначенийДляФильтра();
        }
        #endregion

        #region (nsgButtonSetAll_Click)
        /// <summary>
        /// Кнопка - ВСЕ ЭЛЕМЕНТЫ УСТАНОВИТЬ.
        /// </summary>
        private void nsgButtonSetAll_Click(object sender, EventArgs e)
        {
            var table = nsgVisualMultipleObject2.Data.MemoryTable;

            vmo2NsgListViewElem.Data.BeginUpdateData();
            vmo2NsgListViewElem.Data.MemoryTable.DeleteAll();
            foreach (var row in table.Rows) {
                var gid = (Guid)row[vmo2_Gid.Name].Value;
                var mo = dictSource[gid];
                if (mo != null) destTableAddRow(mo);
            }
            vmo2NsgListViewElem.Data.UpdateDataSync(this);
            
            nsgVisualMultipleObject2.Data.BeginUpdateData();
            nsgVisualMultipleObject2.Data.MemoryTable.DeleteAll();
            nsgVisualMultipleObject2.Data.UpdateDataSync(this);
            dictSource.Clear();

            ПолучениеЗначенийДляФильтра();
        }
        #endregion

        #region (nsgListViewTypes_MouseDoubleClick)
        /// <summary>
        /// обработка двойного клика в списке типов.
        /// </summary>
        protected void nsgListViewTypes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            nsgButtonSetOne.PerformClick();
        }
        #endregion

        #region (nsgListViewElems_MouseDoubleClick)
        /// <summary>
        /// обработка двойного клика в списке элементов.
        /// </summary>
        protected void nsgListViewElems_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            nsgButtonBackOne.PerformClick();
        }
        #endregion

        #region (nsgBackgroundFillTypes_DoWork)
        /// <summary>
        /// Обработчик фонового заполнения типов.
        /// </summary>
        private void nsgBackgroundFillTypes_DoWork(object sender, DoWorkEventArgs e)
        {
            string nameGroup = e.Argument as string;
            NsgDataObjectTreeNode node = new NsgDataObjectTreeNode(m_metadata, null);
            node.ShowInvisible = true;
            if (nameGroup == "Документы")
            {
                node.FillTree(NsgDataObjectTreeNodeType.MultipleObjectList, new Type[] { typeof(NsgDataDocument), typeof(NsgDataTypedReference) });
            }
            else if (nameGroup == "Справочники")
            {
                node.FillTree(NsgDataObjectTreeNodeType.MultipleObjectList, new Type[] { typeof(NsgDataDictionary), typeof(NsgDataTypedReference) });
            }
            else if (nameGroup == "Характеристики")
            {
                node.FillTree(NsgDataObjectTreeNodeType.MultipleObjectList, new Type[] { typeof(NsgDataCharacteristics), typeof(NsgDataTypedReference) });
            }
            else if (nameGroup == "Регистры")
            {
                node.FillTree(NsgDataObjectTreeNodeType.MultipleObjectList, new Type[] { typeof(NsgDataRegister), typeof(NsgDataTypedReference) });
            }
            node.ShowInvisible = false;
            e.Result = node;
        }
        #endregion

        void destTableAddRow(NsgMultipleObject mo)
        {
            if (mo != null)
            {
                var row = vmo2NsgListViewElem.Data.MemoryTable.NewRow();
                row.Edit();
                row[vmo2elem_Gid.Name].Value = mo.Guid;
                row[vmo2elem_Name.Name].Value = mo.Name;
                //row[vmo2elem_Obj.Name].Value = mo;
                row.Post();
                dictDest[mo.Guid] = mo;
            }
        }
        void sourceTableAddRow(NsgMultipleObject mo)
        {
            if (mo != null)
            {
                var row = nsgVisualMultipleObject2.Data.MemoryTable.NewRow();
                row.Edit();
                row[vmo2_Gid.Name].Value = mo.Guid;
                row[vmo2_Name.Name].Value = mo.Name;
                //row[vmo2_Объект1.Name].Value = mo;
                row.Post();
                dictSource[mo.Guid] = mo;
            }
        }
        Dictionary<Guid, NsgMultipleObject> dictSource = new Dictionary<Guid, NsgMultipleObject>();
        Dictionary<Guid, NsgMultipleObject> dictDest = new Dictionary<Guid, NsgMultipleObject>();

        #region (nsgBackgroundFillTypes_RunWorkerCompleted)        
        /// <summary>
        /// Обработчик окончания фонового заполнения типов.
        /// </summary>
        private void nsgBackgroundFillTypes_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled && e.Error == null)         
            {
                // Очищаем список выбранных
                dictDest.Clear();
                vmo2NsgListViewElem.Data.BeginUpdateData();
                vmo2NsgListViewElem.Data.MemoryTable.DeleteAll();
                vmo2NsgListViewElem.Data.UpdateDataSync(this);

                // Загружаем список нужных
                dictSource.Clear();
                nsgVisualMultipleObject2.Data.BeginUpdateData();
                nsgVisualMultipleObject2.Data.MemoryTable.DeleteAll();

                // заполнить список типов
                NsgDataObjectTreeNode node = e.Result as NsgDataObjectTreeNode;
                foreach (TreeNode nodeGroup in node.Nodes) {
                    var mo = node.Tag as NsgMultipleObject;
                    if (mo != null)
                    {
                        try
                        {
                            sourceTableAddRow(mo);
                        }
                        catch { 
                            
                        }

                    }
                    foreach (TreeNode subNode in nodeGroup.Nodes)
                    {
                        var mosub = subNode.Tag as NsgMultipleObject;
                        if (!(mosub is NsgInterfacedObject) || ((mosub as NsgInterfacedObject) != null && (mosub as NsgInterfacedObject).EntityType != NsgInterfacedObject.EntityTypes.Interface))
                        {
                            try
                            {
                                sourceTableAddRow(mosub);
                            }
                            catch { 
                            
                            }
                        }
                    }                   
                }
                nsgVisualMultipleObject2.Data.UpdateDataSync(this);
            }
        }
        #endregion

        #region (nsgBackgroundGetFilter_DoWork)
        /// <summary>
        /// Обработчик фонового заполнения фильтра.
        /// </summary>
        private void nsgBackgroundGetFilter_DoWork(object sender, DoWorkEventArgs e)
        {
            var allMO = e.Argument as List<NsgMultipleObject>;
            if (allMO == null || allMO.Count == 0)
                e.Result = new object[] { new List<NsgColumnDescriptor>(0), new List<NsgColumnDescriptor>(0) };
            else
                e.Result = new object[] { ПолучениеЗначенийДляФильтра_Background(allMO), ПолучениеЗначенийТаблицыДляФильтра_Background(allMO[0]) };
        }
        #endregion

        #region (nsgBackgroundGetFilter_RunWorkerCompleted)
        /// <summary>
        /// Обработчик окончания фонового заполнения фильтра.
        /// </summary>
        private void nsgBackgroundGetFilter_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled && e.Error == null && e.Result != null)
                ПолучениеЗначенийДляФильтра_Finish(e.Result as object[]);
        }
        #endregion

        #region (nsgBackgroundProcessing_DoWork)
        /// <summary>
        /// Фоновый обработчик формы.
        /// </summary>
        protected void nsgBackgroundProcessing_DoWork(object sender, EventArgs e)
        {
            if (m_selectItemActions == "Групповой ввод значений в таблицу")
            {
                if (ПроверкаВводимыхЗначений())
                    throw new NsgLoggedException("Операция обработка объектов прервана");
            }
            NsgSettings.MainForm.ShowMessage("Операция обработка объектов начата.", MessageBoxIcon.Information);
            if (m_selectItemActions == "Выгрузить в файл")
                ВыгрузкаВФайл();
            else
                ОбработкаОбъектов();
        }
        #endregion

        #region (nsgBackgroundProcessing_RunWorkerCompleted)
        /// <summary>
        /// Фоновый обработчик формы - окончание.
        /// </summary>
        protected void nsgBackgroundProcessing_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                // завершить транзакцию, если нужно
                if (checkBoxTransaction.Checked == true)
                    NsgSettings.RollbackTransaction();
                NsgSettings.MainForm.ShowMessage("Операция обработка объектов прервана пользователем.",
                    MessageBoxIcon.Error);
            }
            else if (e.Error != null)
            {
                // завершить транзакцию, если нужно
                if (checkBoxTransaction.Checked == true)
                    NsgSettings.RollbackTransaction();
                NsgSettings.MainForm.ShowMessage(e.Error);
                NsgSettings.MainForm.ShowMessage("Операция обработка объектов прервана по ошибке.",
                    MessageBoxIcon.Error);
            }
            else
            {
                // завершить транзакцию, если нужно
                if (checkBoxTransaction.Checked == true)
                    NsgSettings.CommitTransaction();
                NsgSettings.MainForm.ShowMessage("Операция обработка объектов успешно завершена.",
                    MessageBoxIcon.Information);
            }
            nsgProgressBar.ReportProgress(0, "");
        }
        #endregion

        #region (nsgBackgroundReport_DoWork)
        /// <summary>
        /// Фоновый обработчик создания отчета.
        /// </summary>
        private void nsgBackgroundReport_DoWork(object sender, DoWorkEventArgs e)
        {
            object[] parameters = e.Argument as object[];
            NsgCompare compare = parameters[0] as NsgCompare;
            NsgMultipleObject[] list = parameters[1] as NsgMultipleObject[];
            // запустить формирование отчета
            createReport(compare, list);
        }
        #endregion

        #region (checkBoxBindedObjects_CheckedChanged)
        /// <summary>
        /// Флаг выгрузки связанных объектов.
        /// </summary>
        private void checkBoxBindedObjects_CheckedChanged(object sender, EventArgs e)
        {
            nsgDataExchangeService.ExportBindedObjects = checkBoxBindedObjects.Checked;
        }
        #endregion

        #region (comboBoxFormat_SelectedIndexChanged)
        /// <summary>
        /// Изменение формата выгрузки.
        /// </summary>
        private void comboBoxFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFormat.SelectedIndex == 0)
                nsgDataExchangeService.ExportFormat = NsgDataExportFormat.NsgSoft_v1_0;
            else if (comboBoxFormat.SelectedIndex == 1)
                nsgDataExchangeService.ExportFormat = NsgDataExportFormat.C1_v2_0;
        }
        #endregion

        #region (OnCreateReport)
        protected override void OnCreateReport(NsgBackgroundWorker sender, DoWorkEventArgs e)
        {
            object[] parameters = e.Argument as object[];
            NsgCompare compare = parameters[0] as NsgCompare;
            NsgMultipleObject[] list = parameters[1] as NsgMultipleObject[];
            createReport(compare, list);
        }
        #endregion

        #endregion

        #region (ОбработкаДокументовОбработка_Activated)
        private void ОбработкаДокументовОбработка_Activated(object sender, EventArgs e)
        {
            //TODO: !
            //nsgListViewTypes.RefreshList();
            //nsgListViewElems.RefreshList();
        }
        #endregion

        #region (comboBoxTable_SelectedIndexChanged)
        private void comboBoxTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTab = (string)comboBoxTable.SelectedItem;
            selectTab = false;
            ПолучениеЗначенийДляФильтра();
            //selectTab = true;
        }
        #endregion

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nsgListViewTypes_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void nsgListViewTypes_AfterAction(object sender, NsgIGrid.NsgIGridCellEventArgs e, NsgSoft.Design.NsgWorkToolPanel.InvokeToolProcessingEventArgs args)
        {

        }

        private void nsgListViewTypes_CellActivated(object sender, NsgIGrid.NsgIGridCellEventArgs e)
        {

        }

        private void nsgListViewTypes_MouseClick_1(object sender, MouseEventArgs e)
        {

        }

    }
}