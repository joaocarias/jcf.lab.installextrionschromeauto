using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using App.Models;
using App.Services;

namespace App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string valueOne = tbValorUm.Text;
            string valueTwo = tbValorDois.Text;

            var registry = new RegistryBasic(valueOne, valueTwo);

            RegistryBasicService registryBasicService = new RegistryBasicService();
            registryBasicService.Save(registry); 
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            RegistryBasicService registryBasicService = new RegistryBasicService();
            var registry = registryBasicService.Get();

            lbTexto.Text = $"Valores: {registry.ValueOne} e {registry.ValueTwo}";
        }

        private void InstallExtension_Click(object sender, EventArgs e)
        {
            ExtensionService es = new ExtensionService();
            es.Install();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ExtensionService es = new ExtensionService();
            es.Uninstall(); 
        }
    }
}
