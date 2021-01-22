using SoulWorkerPropertySimulator.Types;

namespace SoulWorkerPropertySimulator.Extensions
{
    public static class PropertyExtensions
    {
        public static bool IsPercent(this Property self) => self.ToString("G").Contains("Rate");
    }
}