using System.ComponentModel;
using System.Linq;

namespace SoulWorkerPropertySimulator.Extensions
{
    public static class DescriptionExtensions
    {
        public static string GetDescription(this object self) =>
            (self.GetType()
                .GetField(self.ToString()!)
                ?.GetCustomAttributes(typeof(DescriptionAttribute), false)
                .FirstOrDefault() as DescriptionAttribute)?.Description ??
            string.Empty;
    }
}