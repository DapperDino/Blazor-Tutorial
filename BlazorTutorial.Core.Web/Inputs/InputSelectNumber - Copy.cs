using Microsoft.AspNetCore.Components.Forms;

namespace BlazorTutorial.Core.Web.Inputs
{
    public class InputSelectNullableNumber<T> : InputSelect<T>
    {
        protected override bool TryParseValueFromString(string value, out T result, out string validationErrorMessage)
        {
            if (typeof(T) == typeof(int?))
            {
                if (int.TryParse(value, out int resultInt))
                {
                    result = (T)(object)resultInt;
                }
                else
                {
                    result = default;
                }

                validationErrorMessage = null;
                return true;
            }
            else
            {
                return base.TryParseValueFromString(value, out result, out validationErrorMessage);
            }
        }
    }
}