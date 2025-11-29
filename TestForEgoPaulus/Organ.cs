using System.Runtime.InteropServices;

namespace TestForEgoPaulus
{

    //THIS IS AN INSTRUMENT NOT A HUMAN ORGAN.
    public class Organ
    {
        private string _name { get; set; }
        private int _manualsCount { get; set; }
        private bool _areFootPedalsPresent { get; set; }
        private bool _isDigital { get; set; }
        private int _yearManufactured { get; set; }

        public Organ(string name, int manualsCount, bool areFootPedalsPresent, bool isDigital, int yearManufactured)
        {
            _name = name;
            _manualsCount = manualsCount;
            _areFootPedalsPresent = areFootPedalsPresent;
            _isDigital = isDigital;
            _yearManufactured = yearManufactured;
        }

        public string Name { get { return _name; } }
        public int ManualsCount { get { return _manualsCount; } }
        public bool AreFootPedalsPresent { get { return _areFootPedalsPresent; } }
        public bool IsDigital { get { return _isDigital; } }
        public int YearManufactured { get { return _yearManufactured; } }
    }
}
