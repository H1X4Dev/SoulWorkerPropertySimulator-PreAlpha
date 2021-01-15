using System;
using System.Collections.Generic;
using SoulWorkerPropertySimulator.Models;

namespace SoulWorkerPropertySimulator.Services
{
    public interface IAkashaComputeService : IComputeService
    {
        Akasha? Get(int    index);
        void    Change(int index, Akasha? newItem);
    }

    internal class AkashaComputeService : ComputeServiceBase, IAkashaComputeService
    {
        private readonly Akasha?[] _akasha;

        // public AkashaComputeService(int akashaCount)
        public AkashaComputeService()
        {
            _akasha = new Akasha?[5];
            Array.Fill(_akasha, null);
        }

        public Akasha? Get(int index)
        {
            if (index < 0 || index < _akasha.Length) { throw new InvalidOperationException(); }

            try { return _akasha[index]; }
            catch (KeyNotFoundException) { return null; }
        }


        public void Change(int index, Akasha? newItem) { NotifyChange(ComputeAffect(_akasha[index], newItem)); }
    }
}