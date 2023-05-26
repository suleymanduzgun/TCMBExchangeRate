using System.ComponentModel;
using System.Reflection;

namespace TCMBExchangeRate.Helpers;

public static class TCMBExchangeRateHelper
{
	public static string GetTCMBEnumDescription(this Enum enumValue)
	{
		FieldInfo? fieldInfo = enumValue?.GetType().GetField(enumValue.ToString());
		if (fieldInfo == null)
			return enumValue.ToString();

		var descriptionAttributes = (DescriptionAttribute?[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);
		return descriptionAttributes?.Length > 0 ? descriptionAttributes[0].Description : enumValue.ToString();
	}
}