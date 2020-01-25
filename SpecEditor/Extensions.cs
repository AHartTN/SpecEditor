using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Microsoft.VisualBasic.FileIO;
using SpecEditor.Models;

namespace SpecEditor
{
	public static class Extensions
	{
		public const BindingFlags BindFlags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static;
		public static readonly BindingFlags[] BindFlagsArray = { BindingFlags.Instance, BindingFlags.Public, BindingFlags.NonPublic, BindingFlags.Static };
		public static readonly object[] BindFlagsObjectArray = BindFlagsArray.Cast<object>().ToArray();

		#region Object Extensions

		#region Property Extensions

		public static IEnumerable<PropertyInfo> GetProperties(this object source) => source?.GetType().GetProperties();

		public static PropertyInfo GetProperty(this object source, string name) => source?.GetType().GetProperty(name, BindFlags);

		public static object GetPropertyValue(this object source, PropertyInfo property) { return property?.GetValue(source); }

		public static object GetPropertyValue(this object source, string name) { return source?.GetPropertyValue(source.GetProperty(name)); }

		public static void SetPropertyValue(this object source, string name, object value)
		{
			PropertyInfo property = source?.GetProperty(name);
			property?.SetValue(source, value.GetSafeValue());
		}

		#endregion Property Extensions

		#region Field Extensions

		public static FieldInfo GetField(this object source, string name) => source?.GetType().GetField(name, BindFlags);

		public static object GetFieldValue(this object source, FieldInfo Field) => Field?.GetValue(source);

		public static object GetFieldValue(this object source, string name) => source?.GetFieldValue(source.GetField(name));

		public static void SetFieldValue(this object source, string name, object value)
		{
			source?.GetField(name)?.SetValue(source, value);
		}

		#endregion Field Extensions

		public static int GetCustomHashCode(this object source)
		{
			int offset = 7;
			int result = 13;
			foreach (PropertyInfo property in source.GetProperties())
			{
				object value = property.GetValue(source);
				result = result * offset + value?.GetHashCode() ?? 0;
			}
			return result;
		}

		public static object GetSafeValue(this object source)
		{
			return Convert.ChangeType(source,
				Nullable.GetUnderlyingType(source.GetType()) ?? source.GetType(),
				CultureInfo.InvariantCulture);
		}

		public static IEnumerable<T> GetAttributes<T>(this object source) where T : Attribute
		{
			return source.GetType().GetCustomAttributes<T>();
		}

		public static IEnumerable<PropertyInfo> GetKeyProperties(this object source)
		{
			return source.GetProperties().Where(w => w.GetAttributes<KeyAttribute>().Any());
		}

		#endregion Object Extensions

		#region Display Attribute Extensions

		#region Display Attribute Extensions

		public static DisplayAttribute GetDisplayAttribute<T>(this T source)
		{
			Type type = typeof(T);
			FieldInfo field = type.GetField(source.ToString());
			if (!(field.GetCustomAttributes(typeof(DisplayAttribute), false) is DisplayAttribute[] result))
				throw new ArgumentNullException($"{source} has no display attribute!");
			return result[0];
		}

		public static string GetShortName<T>(this T source) where T : struct, IComparable, IConvertible, IFormattable
		{
			DisplayAttribute attribute = GetDisplayAttribute(source);

			return attribute == null || attribute.ShortName.IsNullOrWhiteSpace()
				? null
				: attribute.ShortName;
		}

		public static string GetName<T>(this T source) where T : struct, IComparable, IConvertible, IFormattable
		{
			DisplayAttribute attribute = GetDisplayAttribute(source);

			return attribute == null || attribute.Name.IsNullOrWhiteSpace()
				? null
				: attribute.Name;
		}

		public static string GetDescription<T>(this T source) where T : struct, IComparable, IConvertible, IFormattable
		{
			DisplayAttribute attribute = GetDisplayAttribute(source);

			return attribute == null || attribute.Description.IsNullOrWhiteSpace()
				? null
				: attribute.Description;
		}

		public static string GetGroupName<T>(this T source) where T : struct, IComparable, IConvertible, IFormattable
		{
			DisplayAttribute attribute = GetDisplayAttribute(source);

			return attribute == null || attribute.GroupName.IsNullOrWhiteSpace()
				? null
				: attribute.GroupName;
		}

		public static string GetPrompt<T>(this T source) where T : struct, IComparable, IConvertible, IFormattable
		{
			DisplayAttribute attribute = GetDisplayAttribute(source);

			return attribute == null || attribute.Prompt.IsNullOrWhiteSpace()
				? null
				: attribute.Prompt;
		}

		public static int GetOrder<T>(this T source) where T : struct, IComparable, IConvertible, IFormattable
		{
			DisplayAttribute attribute = GetDisplayAttribute(source);

			if (attribute == null)
				return 0;

			int? order = attribute.GetOrder();

			if (order == null || attribute.Order <= 0)
			{
				attribute.Order = 0;
			}

			return attribute.Order;
		}

		public static T SetShortName<T>(this T source, string value)
			where T : struct, IComparable, IConvertible, IFormattable
		{
			DisplayAttribute attribute = GetDisplayAttribute(source);
			attribute.ShortName = value;
			return source;
		}

		public static T SetName<T>(this T source, string value)
			where T : struct, IComparable, IConvertible, IFormattable
		{
			DisplayAttribute attribute = GetDisplayAttribute(source);
			attribute.Name = value;
			return source;
		}

		public static T SetDescription<T>(this T source, string value)
			where T : struct, IComparable, IConvertible, IFormattable
		{
			DisplayAttribute attribute = GetDisplayAttribute(source);
			attribute.Description = value;
			return source;
		}

		public static T SetGroupName<T>(this T source, string value)
			where T : struct, IComparable, IConvertible, IFormattable
		{
			DisplayAttribute attribute = GetDisplayAttribute(source);
			attribute.GroupName = value;
			return source;
		}

		public static T SetPrompt<T>(this T source, string value)
			where T : struct, IComparable, IConvertible, IFormattable
		{
			DisplayAttribute attribute = GetDisplayAttribute(source);
			attribute.Prompt = value;
			return source;
		}

		public static T SetOrder<T>(this T source, int value) where T : struct, IComparable, IConvertible, IFormattable
		{
			DisplayAttribute attribute = GetDisplayAttribute(source);
			attribute.Order = value;
			return source;
		}

		#endregion Display Attribute Extensions

		#region Display Attribute Property Extensions

		public static DisplayAttribute GetDisplayAttribute<T>(this T source, string name)
		{
			if (source == null)
				return null;

			return typeof(T).GetProperty(name, BindFlags)?.GetCustomAttribute<DisplayAttribute>()
				   ?? typeof(T).GetField(name, BindFlags)?.GetCustomAttribute<DisplayAttribute>();
		}

		public static string GetGroupName<T>(this T source, string name) => source?.GetDisplayAttribute(name)?.GroupName;

		public static T SetGroupName<T>(this T source, string name, string value)
		{
			source.GetDisplayAttribute(name).GroupName = value;
			return source;
		}

		public static string GetName<T>(this T source, string name) => source?.GetDisplayAttribute(name)?.Name;

		public static T SetName<T>(this T source, string name, string value)
		{
			source.GetDisplayAttribute(name).Name = value;
			return source;
		}

		public static string GetDescription<T>(this T source, string name) => source?.GetDisplayAttribute(name)?.Description;

		public static T SetDescription<T>(this T source, string name, string value)
		{
			source.GetDisplayAttribute(name).Description = value;
			return source;
		}

		public static int? GetOrder<T>(this T source, string name) => source?.GetDisplayAttribute(name)?.Order;

		public static T SetOrder<T>(this T source, string name, int value)
		{
			source.GetDisplayAttribute(name).Order = value;
			return source;
		}

		public static string GetPrompt<T>(this T source, string name) => source?.GetDisplayAttribute(name)?.Prompt;

		public static T SetPrompt<T>(this T source, string name, string value)
		{
			source.GetDisplayAttribute(name).Prompt = value;
			return source;
		}

		public static string GetShortName<T>(this T source, string name) => source?.GetDisplayAttribute(name)?.ShortName;

		public static T SetShortName<T>(this T source, string name, string value)
		{
			source.GetDisplayAttribute(name).ShortName = value;
			return source;
		}

		#endregion Display Attribute Property Extensions

		#endregion Display Attribute Extensions

		#region String Extensions

		/// <summary>
		/// Returns whether or not the string is null, empty, or contains only whitespace
		/// </summary>
		/// <param name="source">The source string</param>
		/// <returns>True or False</returns>
		public static bool IsNullOrWhiteSpace(this string source)
		{
			return string.IsNullOrWhiteSpace(source);
		}

		/// <summary>
		///     Returns a replacement string if the source string is null, empty, or contains nothing but whtiespace characters
		/// </summary>
		/// <param name="source">The source string to check against</param>
		/// <param name="replacement">The replacement string should the check come back true</param>
		/// <returns>The replacement string if true, otherwise the source string</returns>
		public static string IfNullOrWhiteSpace(this string source, string replacement)
		{
			return !source.IsNullOrWhiteSpace() ? source : replacement;
		}

		/// <summary>
		///     Returns a replacement string if the source string is null, empty, or contains nothing but whtiespace characters
		/// </summary>
		/// <param name="source">The source string to check against</param>
		/// <param name="replacement">The replacement string should the check come back true</param>
		/// <returns>The replacement string if true, otherwise the source string</returns>
		public static string IfNotNullOrWhiteSpace(this string source, string replacement)
		{
			return source.IsNullOrWhiteSpace() ? source : replacement;
		}

		/// <summary>
		///     Returns a replacement string if the source string is equal to any of the specified strings
		/// </summary>
		/// <param name="source">The source string to check against</param>
		/// <param name="replacement">The replacement string should the check come back true</param>
		/// <param name="input">The values to compare the source string against</param>
		/// <returns>The replacement string if the source string equals any of the input strings, otherwise the source string</returns>
		public static string IfEquals(this string source, string[] input, string replacement)
		{
			return input.Any(a => a.Equals(source)) ? replacement : source;
		}

		/// <summary>
		///     Converts a string into a nullable integer
		/// </summary>
		/// <param name="source">The source string containing the number</param>
		/// <returns>An integer representing the source string</returns>
		public static int? ToNullableInt(this string source)
		{
			int? result;
			if (string.IsNullOrWhiteSpace(source))
			{
				result = null;
			}
			else
			{
				if (int.TryParse(source, out int j))
					result = j;
				else
					result = null;
			}

			return result;
		}

		/// <summary>
		///     Converts a string into a nullable decimal
		/// </summary>
		/// <param name="source">The source string containing the number</param>
		/// <returns>A decimal representing the source string</returns>
		public static decimal? ToNullableDecimal(this string source)
		{
			decimal? result;
			if (string.IsNullOrWhiteSpace(source))
			{
				result = null;
			}
			else
			{
				if (decimal.TryParse(source, out decimal j))
					result = j;
				else
					result = null;
			}

			return result;
		}

		public static IEnumerable<string> SplitCSV(this string source, params string[] delimiters)
		{
			if (delimiters == null || !delimiters.Any())
				delimiters = new[] { ConfigurationManager.AppSettings["DefaultDelimiter"].IfNullOrWhiteSpace(",") };

			using (
				TextFieldParser parser = new TextFieldParser(new StringReader(source))
				{
					HasFieldsEnclosedInQuotes = true,
					TextFieldType = FieldType.Delimited,
					Delimiters = delimiters,
					TrimWhiteSpace = true
				})
			{
				parser.SetDelimiters(delimiters);

				while (!parser.EndOfData)
				{
					string[] fields = parser.ReadFields();

					if (fields == null || !fields.Any())
						continue;

					foreach (string field in fields)
						yield return field.Trim();
				}

				parser.Close();
			}
		}

		public static bool IsBoolean(this string source)
		{
			return DataHelper.BooleanArray.Contains(source.ToLower());
		}

		public static bool ToBoolean(this string source)
		{
			return source.IsBoolean() && DataHelper.BooleanTrueArray.Contains(source.ToLower());
		}

		public static string FormatWith(this string source, params object[] args)
		{
			return string.Format(source, args);
		}

		#endregion String Extensions

		#region Generic Extensions

		#region Enum Extensions

		public static IEnumerable<T> GetEnums<T>(this T source)
		{
			Type type = typeof(T);
			return type.IsEnum ? Enum.GetValues(type).Cast<T>() : null;
		}

		#endregion Enum Extensions

		#region DataTable Extensions

		public static IEnumerable<T> PopulateCollection<T>(this DataTable source)
		{
			foreach (DataRow row in source.Rows.Cast<DataRow>())
			{
				object instance = Activator.CreateInstance(typeof(T));
				foreach (DataColumn column in source.Columns)
				{
					object value = row[column];
					PropertyInfo property = instance.GetProperty(column.ColumnName);

					if (property?.PropertyType == typeof(bool))
						value = Convert.ToString(value).ToBoolean();

					property?.SetValue(instance, value is DBNull ? null : value.GetSafeValue());
				}

				yield return (T)instance;
			}
		}

		#endregion DataTable Extensions

		#region DbContext Extensions

		public static void AddRecords<T>(this DbContext db, IReadOnlyCollection<T> records, bool saveChanges = false) where T : class
		{
			db.Set<T>().AddOrUpdate(records.ToArray());

			if (saveChanges)
				db.SaveChanges();
		}

		#endregion DbContextExtensions

		#endregion Generic Extensions
	}
}
