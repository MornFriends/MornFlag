using System.Collections.Generic;
using MornGlobal;
using UnityEngine;

namespace MornFlag
{
    public abstract class MornFlagGlobalBase : MornGlobalBase<MornFlagGlobalBase>
    {
        [SerializeField] private List<string> _flags = new();
        internal List<string> Flags => _flags;
    }
}