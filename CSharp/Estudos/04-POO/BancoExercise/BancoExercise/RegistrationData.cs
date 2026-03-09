using System;
using account;

namespace register
{
    public class RegistrationData
    {
        public RegistrationData()
        {
        }
        public string Id { get; set; }
        private string _name;
        private int _numacc;

        public string Name
        {
            get => _name;
            set => _name = !string.IsNullOrEmpty(value) ? value : _name;
        }
        public int NumAcc
        {
            get => _numacc;
            set => _numacc = !int.IsNegative(value) ? value : _numacc;
        }
        public double Balance { get; set; } = 0;

        override
        public string ToString()
        {
            {
                return $"Conta {NumAcc}, Titular: {Name}, Saldo: R${Balance:F2}";
            }

        }

    }
}