using Ryujinx.HLE.HOS.Services.Mii.Types;

namespace Ryujinx.HLE.HOS.Services.Mii
{
    class DatabaseSessionMetadata
    {
        public int  InterfaceVersion;
        public ulong UpdateCounter;

        public SpecialMiiKeyCode MiiKeyCode { get; private set; }

        public DatabaseSessionMetadata(ulong updateCounter, SpecialMiiKeyCode miiKeyCode)
        {
            InterfaceVersion = 0;
            UpdateCounter    = updateCounter;
            MiiKeyCode       = miiKeyCode;
        }

        public bool IsInterfaceVersionSupported(int interfaceVersion)
        {
            return InterfaceVersion >= interfaceVersion;
        }
    }
}
