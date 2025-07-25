using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Globalization;
using System.Reflection;
using System.Text;
using System.IO;
using NsgSoft.DataObjects;
using NsgSoft.Common;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("TechControl")]
[assembly: AssemblyDescription("Титан Контроль")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("NSG ©  2022")]
[assembly: AssemblyProduct("TechControl")]
[assembly: AssemblyCopyright("NSG ©  2022")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("6b96e818-0212-4542-90b3-d84d13a8d015")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Revision and Build Numbers 
// by using the '*' as shown below:
[assembly: AssemblyVersion("2025.7.24.2")]
[assembly: AssemblyFileVersion("2025.7.24.2")]
[assembly: NsgAssemblyAttribute(NsgAssemblyTypes.Configuration)]

namespace TechControl
{
    [NsgSoft.Common.NsgConfigurationClass()]
    public partial class Конфигурация : NsgConfiguration
	{
		#region Данные
		
        private Метаданные.Метаданные __Метаданные;
		#endregion //Данные

		#region Инициализация
		/// <summary>
		/// Инициализация
        /// </summary>
        private void InitializeComponent()
        {
            NsgSoft.DataObjects.NsgSettings.Regime = NsgSoft.Common.NsgViewTypes.Load;
            NsgService.AllowAccuracyChecks = false;
            ClearAllList();
            //NsgConfiguration
            	//NsgConfiguration
	IsLoadedFromDll = true;
	Prefics = "";
	Type = NsgSoft.DataObjects.NsgConfigurationTypes.Base;
	Guid = NsgService.StringToGuid("6b96e818-0212-4542-90b3-d84d13a8d015");
	DatabaseManagerNames = "";
	Name = "TechControl";
	Description = "Титан Контроль";
	Copyright = "NSG ©  2022";
	Version = "2025.7.24.2";
	MetaDataList = new NsgSoft.DataObjects.NsgMetaData[]{};
	

            
            __Метаданные = TechControl.Метаданные.Метаданные.Новый();
            AddMetaData(__Метаданные);
            NsgSoft.DataObjects.NsgSettings.Regime = NsgSoft.Common.NsgViewTypes.RunTime;
        }
		#endregion //Инициализация

		#region Свойства
		
        /// <summary>
        /// Метаданные
        /// </summary>
        public Метаданные.Метаданные Метаданные
        {
            get
            {
                return __Метаданные;
            }
        }
		#endregion //Свойства

		#region Методы
		#endregion //Методы
	}
}
