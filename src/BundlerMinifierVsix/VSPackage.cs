namespace BundlerMinifierVsix
{
    using System;
    
    /// <summary>
    /// Helper class that exposes all GUIDs used across VS Package.
    /// </summary>
    internal sealed partial class GuidList
    {
        public const string guidBundlerPackageString = "67411f3b-36b3-4df0-84e8-5748f8a541ac";
        public const string guidBundlerCmdSetString = "7b10be0c-81e1-4817-abda-e08788679bd5";
        public static Guid guidBundlerPackage = new Guid(guidBundlerPackageString);
        public static Guid guidBundlerCmdSet = new Guid(guidBundlerCmdSetString);
    }
    /// <summary>
    /// Helper class that encapsulates all CommandIDs uses across VS Package.
    /// </summary>
    internal sealed partial class PackageCommands
    {
        public const int MyMenuGroup = 0x1020;
        public const int CreateBundleId = 0x0100;
        public const int UpdateBundle = 0x0200;
        public const int MinifyFile = 0x0300;
        public const int BundleOnBuild = 0x0400;
        public const int RemoveBundle = 0x0500;
    }
}
