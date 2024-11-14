using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assisgment4
{
    public class Cellphone
    {
        // Private member variables
        private string _brand;
        private string _model;
        private bool _isOn;
        private int _batteryLevel;

        // Constructor to initialize the cellphone object
        public Cellphone(string brand, string model, int batteryLevel)
        {
            _brand = brand;
            _model = model;
            _isOn = false; // Initially, the phone is off
            _batteryLevel = batteryLevel; // Battery level should be between 0 and 100
        }

        // Private method to simulate charging the phone
        private void ChargeBattery(int amount)
        {
            _batteryLevel += amount;
            if (_batteryLevel > 100) _batteryLevel = 100; // Cap battery level at 100
        }

        // Public method to turn on the phone
        public void PowerOn()
        {
            if (!_isOn && _batteryLevel > 0)
            {
                _isOn = true;
                Console.WriteLine($"{_brand} {_model} is now ON.");
            }
            else if (_isOn)
            {
                Console.WriteLine($"{_brand} {_model} is already ON.");
            }
            else
            {
                Console.WriteLine($"{_brand} {_model} cannot be turned ON. Battery is empty.");
            }
        }

        // Public method to turn off the phone
        public void PowerOff()
        {
            if (_isOn)
            {
                _isOn = false;
                Console.WriteLine($"{_brand} {_model} is now OFF.");
            }
            else
            {
                Console.WriteLine($"{_brand} {_model} is already OFF.");
            }
        }

        // Public method to use the phone (drains battery)
        public void UsePhone(int usageTime)
        {
            if (_isOn)
            {
                int batteryDrain = usageTime; // Assume 1% battery per minute
                _batteryLevel -= batteryDrain;
                if (_batteryLevel < 0) _batteryLevel = 0;

                Console.WriteLine($"{_brand} {_model} used for {usageTime} minutes. Battery level: {_batteryLevel}%");
                if (_batteryLevel == 0) PowerOff(); // Automatically turn off if battery is empty
            }
            else
            {
                Console.WriteLine($"{_brand} {_model} is OFF. Please turn it ON to use.");
            }
        }

        // Public method to charge the phone
        public void Charge(int amount)
        {
            Console.WriteLine($"Charging {_brand} {_model}...");
            ChargeBattery(amount);
            Console.WriteLine($"Battery level: {_batteryLevel}%");
        }
    }
}
