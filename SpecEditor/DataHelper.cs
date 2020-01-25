using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Design.PluralizationServices;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpecEditor.Models.View;

namespace SpecEditor
{
	public class DataHelper
	{
		public static PluralizationService Pluralizer => PluralizationService.CreateService(CultureInfo.CurrentCulture);

		public static readonly string[] BooleanTrueArray = { "1", "t", "y", "true", "yes" };
		public static readonly string[] BooleanFalseArray = { "0", "f", "n", "false", "no" };
		public static string[] BooleanArray = BooleanTrueArray.Union(BooleanFalseArray).OrderBy(o => o).ToArray();

		public static Type[] NumericTypes =
		{
			typeof (sbyte), typeof (short), typeof (ushort), typeof (int), typeof (uint),
			typeof (long), typeof (ulong)
		};

		public static Type[] PrecisionNumericTypes = { typeof(float), typeof(double), typeof(decimal) };
	}
}
