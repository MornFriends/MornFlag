using System.Collections.Generic;

namespace MornFlag
{
    public sealed class MornFlagCore : IMornFlagSetter, IMornFlagGetter
    {
        private readonly Dictionary<string, bool> _flags = new();

        void IMornFlagSetter.FlagOn(string key)
        {
            _flags[key] = true;
        }

        void IMornFlagSetter.FlagOff(string key)
        {
            _flags[key] = false;
        }

        bool IMornFlagGetter.GetFlag(string key)
        {
            return _flags.TryGetValue(key, out var value) && value;
        }
    }
}