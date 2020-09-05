using System;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;

namespace automacao_calculadoraandroid_csharp_mobile_CalculadoraAndroidMobile_CalculadoraAndroidMobile
{
    public class MobileDriver
    {
        public AndroidDriver<AndroidElement> driver;
        public AppiumOptions capabilities = new AppiumOptions();

        public void CriarDriverAndroidMobile()
        {
            capabilities.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
            capabilities.AddAdditionalCapability(MobileCapabilityType.PlatformVersion, "7.0");
            capabilities.AddAdditionalCapability(MobileCapabilityType.DeviceName, "LGM2504SUKK7S4QC7H");
            capabilities.AddAdditionalCapability("appPackage", "com.google.android.calculator");
            capabilities.AddAdditionalCapability("appActivity", "com.android.calculator2.Calculator");

            driver = new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4723/wd/hub"), capabilities);
            Console.WriteLine("Driver inicializado com sucesso!");
        }

        public void FecharDriverWeb()
        {
            driver.Quit();
            Console.WriteLine("Driver finalizado com sucesso!");
        }
    }
}