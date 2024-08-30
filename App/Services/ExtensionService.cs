using System;
using System.Security.Cryptography;
using Microsoft.Win32;

namespace App.Services
{
    public class ExtensionService
    {
        public void Install()
        {
            try
            {
                RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Policies\Google\Chrome\ExtensionInstallForcelist");
               
                if (key == null)
                {
                    Console.WriteLine("Extensao nao encontrada");

                    var _created = Create();
                    if (_created) Console.WriteLine("Extensao Instalada"); else Console.WriteLine("Erro ao instalar extensao");
                }
                else
                {
                    Console.WriteLine("Extensao existe");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);   
            }
        }

        private bool Create()
        {
            try
            {
                using (RegistryKey key = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Policies\Google\Chrome\ExtensionInstallForcelist"))
                {
                    key.SetValue("1", "bcjindcccaagfpapjjmafapmmgkkhgoa;https://clients2.google.com/service/update2/crx", RegistryValueKind.String);
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public void Uninstall()
        {
            try
            {
                RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Policies\Google\Chrome\ExtensionInstallForcelist");

                if (key == null)
                {
                    Console.WriteLine("Extensao nao encontrada");
                }
                else
                {
                    Console.WriteLine("Extensao existe");
                    var _removed = Remove();
                    if (_removed) Console.WriteLine("Extensao removida"); else Console.WriteLine("Erro ao remover extensao");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public bool Remove()
        {
            try
            {
                RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Policies\Google\Chrome\ExtensionInstallForcelist");
                   
                if (key == null)
                {
                    Console.WriteLine("Extensao nao encontrada");
                    return false;
                }
                else
                {
                    key.SetValue("1", "", RegistryValueKind.DWord);
                    key.Close();    
                }

                return true;
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
