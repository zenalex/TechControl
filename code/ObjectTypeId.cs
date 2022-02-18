using System;

namespace TechControl
{
    public static class ObjectTypeId
	{
		/// <summary>
		/// Терминал
		/// </summary>
		public static Guid Therminal => new Guid("0783BE26-6398-480C-A88F-871438A01C36");
		/// <summary>
		/// Транспортное средство
		/// </summary>
		public static Guid Vehicle => new Guid("0F1E3A4A-88F5-4166-9BE8-76033DD85D08");
		/// <summary>
		/// Профиль терминала
		/// </summary>
		public static Guid TherminalProfile => new Guid("54E3C5C5-7EFE-49B9-AE0E-F8C44D52FA36");
	}
}