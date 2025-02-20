using System;
using UnityEngine;

namespace MornFlag
{
    [Serializable]
    public abstract class MornFlagBase
    {
        [SerializeField] private string _key;
        public string Key => _key;
    }
}