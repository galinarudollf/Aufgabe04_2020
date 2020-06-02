using System;
using System.Data;

namespace Aufgabe3
{
    public enum State
    {
        off, on, unknown
    }
    public enum Connectivity
    {
        connected, offline
    }

    public abstract class Smartphone
    {
        public string PhoneNumber { get; set; }
        protected State PhoneState { get; set; }
        protected Connectivity ConnectionState { get; set; }

        public Smartphone(string number) { }
        public void makeACall(string phoneNumber) { }

        public void receiveACall(string incommingNumber) { }

        public abstract string getOS();
    }

    public interface IAppStore
    {
        void BuyAppFromAppStore(string AppName);
    }
    public class ApplePhone : Smartphone, IAppStore
    {
        public string AppleID { get; set; }
        public ApplePhone(string number):base(number)
        {

        }

        public void BuyAppFromAppStore(string AppName) { }

        public override string getOS() { return "Apple"; }

        public void LocalizeMyApplePhone() { }

    }
    public abstract class AndroidPhone : Smartphone, IAppStore
    {
        public string GoogleUserAccount { get; set; }
        public AndroidPhone(string number): base(number) { }

        public void BuyAppFromAppStore(string AppName) { }
        public abstract void RunVendorSpecificLocalization();
        public override string getOS() { return "Android"; }
    }

    public class SamsungPhone : AndroidPhone
    {
        public SamsungPhone(string number): base(number) { }
        public override void RunVendorSpecificLocalization() { }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ApplePhone MyApple = new ApplePhone("0123-2324");
            SamsungPhone MySamsung = new SamsungPhone("0049-3242-234");
        }
    }
}
