namespace Assisgment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of Cellphone
            Cellphone myPhone = new Cellphone("Apple", "iPhone 13", 50);

            // Use the methods
            myPhone.PowerOn();
            myPhone.UsePhone(30); // Use the phone for 30 minutes
            myPhone.Charge(30);   // Charge the phone by 30%
            myPhone.PowerOff();
        }
    }
}