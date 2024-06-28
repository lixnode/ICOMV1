using Ivi.Visa;
using Ivi.Visa.ConflictManager;
using System.Diagnostics;
using System.Reflection;

namespace ICOM_V1
{
#if NET5_0_OR_GREATER
    /// <summary>
    /// Class used to load .NET Framework assemblies located in GAC from .NET 5+
    /// Requred only for expiremental using VISA.NET library in .NET 5+
    /// </summary>
    public static class GacLoader
    {
        /// <summary>
        /// Load an assembly from the GAC.
        /// </summary>
        /// <param name="assemblyName"></param>
        /// <returns>Loaded assembly</returns>
        /// <exception cref="FileNotFoundException"></exception>
        public static Assembly Load(AssemblyName assemblyName)
        {
            var gacPaths = new[]
            {
               $"{Environment.GetFolderPath(Environment.SpecialFolder.Windows)}\\Microsoft.NET\\assembly\\GAC_MSIL\\{assemblyName.Name}",
               $"{Environment.GetFolderPath(Environment.SpecialFolder.Windows)}\\assembly\\GAC_MSIL\\{assemblyName.Name}",
            };

            foreach (var folder in gacPaths.Where(f => Directory.Exists(f)))
            {
                foreach (var subfolder in Directory.EnumerateDirectories(folder))
                {
                    if (subfolder.Contains(Convert.ToHexString(assemblyName.GetPublicKeyToken()), StringComparison.OrdinalIgnoreCase)
                        && subfolder.Contains(assemblyName.Version.ToString(), StringComparison.OrdinalIgnoreCase))
                    {
                        var assemblyPath = Path.Combine(subfolder, assemblyName.Name + ".dll");
                        if (File.Exists(assemblyPath))
                            return Assembly.LoadFrom(assemblyPath);
                    }
                }
            }
            throw new FileNotFoundException($"Assembly {assemblyName} not found.");
        }

        /// <summary>
        /// Preloading installed VISA implementation assemblies for NET 5+
        /// </summary>
        public static void LoadInstalledVisaAssemblies()
        {
            var installedVisas = new ConflictManager().GetInstalledVisas(ApiType.DotNet);
            foreach (var visaLibrary in installedVisas)
            {
                try
                {
                    var inst = Load(new AssemblyName(visaLibrary.Location.Substring(visaLibrary.Location.IndexOf(",") + 1)));
                }
                catch { }
            }
        }
    }
#endif

    public class Visa4Net
    {
        public static bool InitLibrary()
        {
            try
            {
                // Get VISA.NET Shared Components version.
                Version visaNetSharedComponentsVersion = typeof(GlobalResourceManager).Assembly.GetName().Version;
                // Check whether VISA Shared Components is installed before using VISA.NET.
                // If access VISA.NET without the visaConfMgr.dll library, an unhandled exception will
                // be thrown during termination process due to a bug in the implementation of the
                // VISA.NET Shared Components, and the application will crash.
                // Get an available version of the VISA Shared Components.
                FileVersionInfo visaSharedComponentsInfo = FileVersionInfo.GetVersionInfo(Path.Combine(Environment.SystemDirectory, "visaConfMgr.dll"));

#if NET5_0_OR_GREATER
                // Preloading installed VISA implementation assemblies for NET 5+
                GacLoader.LoadInstalledVisaAssemblies();
                return true;
#endif

                //TODO: Test device, Connect to the instrument.
                //var resourceName = "USB0::0x05E6::0x2110::8018280::INSTR";
                //using (IVisaSession resource = GlobalResourceManager.Open(resourceName, AccessModes.LoadConfig, 2000))
                //{
                //    if (resource is IMessageBasedSession session)
                //    {
                //        // Ensure termination character is enabled as here in example we use a SOCKET connection.
                //        session.TerminationCharacterEnabled = true;

                //        // Request information about an instrument.
                //        session.FormattedIO.WriteLine("*IDN?");
                //        string instrumentInfo = session.FormattedIO.ReadLine();
                //    }
                //}
            }
            catch { return false; }
        }
    }
}
