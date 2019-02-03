using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security;
using System.Security.Permissions;
using System.Security.Policy;
using System.Windows.Forms;

namespace ITVDN_HW_AppDomain_and_Services
{
    class SafeExecuter : MarshalByRefObject
    {
        private static PermissionSet permissionSet = new PermissionSet(PermissionState.None);

        public static AppDomain SafeRunExe(string filepath, string name)
        {
            var adSetup = new AppDomainSetup { ApplicationBase = Path.GetFullPath(Application.ExecutablePath) };



            
            var permSet = new PermissionSet(PermissionState.None);
            permSet.AddPermission(new SecurityPermission(SecurityPermissionFlag.Execution));
            permSet.AddPermission(new FileIOPermission(FileIOPermissionAccess.AllAccess, "c:\\"));
            permSet.AddPermission(new UIPermission(UIPermissionWindow.AllWindows, UIPermissionClipboard.AllClipboard));            

            var newDomain = AppDomain.CreateDomain("Sandbox", null, adSetup, permSet);

            newDomain.ExecuteAssembly(filepath);

            return null;

        }

        public static void AddPermission(IPermission perm)
        {
            permissionSet.AddPermission(perm);
        }


        public static string GetTypeOfDll(string path)
        {
            string info = string.Empty;

            var assembly = Assembly.LoadFile(path);

            foreach (var type in assembly.GetTypes())
            {
                info += $"Class {type.Name}:\t\t\t";
                info += $"Namespace: {type.Namespace}\t\t\t";
                info += $"Full name: {type.FullName}\t\t\t";

                Console.WriteLine($"  Methods:");
                foreach (var methodInfo in type.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
                {
                    info += $"    Method {methodInfo.Name}\t\t\t";

                    if (methodInfo.IsPublic)
                        info += $"Public\t\t\t";

                    if (methodInfo.IsFamily)
                        info += $"Protected\t\t\t";

                    if (methodInfo.IsAssembly)
                        info += $"Internal\t\t\t";

                    if (methodInfo.IsPrivate)
                        info += $"Private\t\t\t";

                    info += $"ReturnType {methodInfo.ReturnType}\t\t\t";
                    info += $"Arguments {string.Join(", ", methodInfo.GetParameters().Select(x => x.ParameterType))}\t\t\t";
                }               
            }

            return info;
        }
            

        
    }
}

//SecurityPermission
//FileIOPermission
//ReflectionPermission
//NetworkInformationPermission
//WebPermission
//SecurityPermission