using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace OOP_example.Test
{
    public static class ApplicationDomains
    {
        public static void DomainTest()
        {
            AppDomain secondaryDomain = AppDomain.CreateDomain("Secondary domain");
            // событие загрузки сборки
            secondaryDomain.AssemblyLoad += Domain_AssemblyLoad;
            // событие выгрузки домена
            secondaryDomain.DomainUnload += SecondaryDomain_DomainUnload;


            Console.WriteLine("Домен: {0}", secondaryDomain.FriendlyName);

            secondaryDomain.Load(new AssemblyName("Microsoft.Practices.Unity"));
            Assembly[] assemblies = secondaryDomain.GetAssemblies();
            foreach (Assembly asm in assemblies)
                Console.WriteLine(asm.GetName().Name);
            // выгрузка домена
            AppDomain.Unload(secondaryDomain);
            Console.Read();
        }

        private static void SecondaryDomain_DomainUnload(object sender, EventArgs e)
        {
            Console.WriteLine("Домен выгружен из процесса");
        }

        private static void Domain_AssemblyLoad(object sender, AssemblyLoadEventArgs args)
        {
            Console.WriteLine("Сборка загружена");
        }

    }
}
