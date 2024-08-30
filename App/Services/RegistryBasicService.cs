using App.Models;
using Microsoft.Win32;
using System;
using System.Runtime.InteropServices;

namespace App.Services
{
    public class RegistryBasicService
    {
        public RegistryBasic Get()
        {
            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Valores");

                //Se existir retorna os valores armazenados
                if (key != null)
                {
                    var v1 = key.GetValue("Valor1").ToString();
                    var v2 = key.GetValue("Valor2").ToString();
                    key.Close();

                    return new RegistryBasic(v1, v2);
                }
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }             
            
            return null;
        }

        public void Save(RegistryBasic registry)
        {
            try
            {
                RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Valores");

                //armazenando os valores
                key.SetValue("Valor1", registry.ValueOne);
                key.SetValue("Valor2", registry.ValueTwo);

                key.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
