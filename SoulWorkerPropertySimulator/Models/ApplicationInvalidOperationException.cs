using System;

namespace SoulWorkerPropertySimulator.Models
{
    internal class ApplicationInvalidOperationException : InvalidOperationException
    {
        public ApplicationInvalidOperationException(object data) => CustomData = data;
        internal object CustomData { get; }
    }
}