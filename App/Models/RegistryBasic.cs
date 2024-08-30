namespace App.Models
{
    public class RegistryBasic
    {
        public string ValueOne { get; set; }
        public string ValueTwo { get; set; }

        public RegistryBasic(string valueOne, string valueTwo)
        {
            ValueOne = valueOne;
            ValueTwo = valueTwo;
        }
    }
}
