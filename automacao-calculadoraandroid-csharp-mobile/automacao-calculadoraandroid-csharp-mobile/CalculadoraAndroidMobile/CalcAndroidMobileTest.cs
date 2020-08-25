using System;
using automacao_calculadoraandroid_csharp_mobile_CalculadoraAndroidMobile_CalculadoraAndroidMobile;
using automacao_calculadoraandroid_csharp_mobile_CalculadoraAndroidMobile_MobileBasePage;
using NUnit.Framework;

namespace automacao_calculadoraandroid_csharp_CalculadoraAndroidMobile_mobile_CalcAndroidMobileTest
{
    public class CalcAndroidMobileTest : MobileDriver
    {
        public MobileBasePage mobileBasePage;

        [SetUp]
        public void Setup()
        {
            CriarDriverAndroidMobile();
        }

        [Test]
        public void Test1_Soma()
        {
            mobileBasePage = new MobileBasePage(driver);
            mobileBasePage.Soma();
        }

        [TearDown]
        public void TearDown()
        {
            FecharDriverWeb();
        }
    }
}
