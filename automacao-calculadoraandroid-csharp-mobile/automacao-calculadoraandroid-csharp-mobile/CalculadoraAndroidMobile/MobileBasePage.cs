using System;
using automacao_calculadoraandroid_csharp_mobile_CalculadoraAndroidMobile_CalculadoraAndroidMobile;
using automacao_calculadoraandroid_csharp_mobile_CalculadoraAndroidMobile_CalcMobileVariables;
using automacao_calculadoraandroid_csharp_mobile_CalculadoraAndroidMobile_MobileUtils;
using automacao_calculadoraandroid_csharp_mobile_CalculadoraAndroidMobile_GeradorPDF;
using OpenQA.Selenium.Appium.Android;
using System.Threading;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using SeleniumExtras.PageObjects;

namespace automacao_calculadoraandroid_csharp_mobile_CalculadoraAndroidMobile_MobileBasePage
{
    public class MobileBasePage : MobileDriver
    {
        public AndroidDriver<AndroidElement> _driver;
        public CalcMobileVariables calcMobileVariables;
        public MobileUtils mobileUtils;
        public GeradorPDF geradorPDF;

        public MobileBasePage(AndroidDriver<AndroidElement> driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
            calcMobileVariables = new CalcMobileVariables(_driver);
            mobileUtils = new MobileUtils(_driver);
            //geradorPDF = new GeradorPDF(_driver, "Evidencias MyStore Web_" + mobileUtils.GerarDataHoraFormatada(), "Realizar compra online");
        }

        public void Soma()
        {
            try
            {
                Thread.Sleep(3);
                Console.WriteLine("Soma");
                _driver.FindElementById("com.google.android.calculator:id/digit_2").Click();
        //mobileUtils.Clicar(calcMobileVariables.BtnDois);
        //mobileUtils.Clicar(calcMobileVariables.BtnSomar);
        //mobileUtils.Clicar(calcMobileVariables.BtnTres);
    }
            catch (Exception e)
            {
                Console.WriteLine("Erro lancado no metodo Soma: " + e.Message);
            }
        }

        public void Subtracao()
        {
            try
            {

            }
            catch (Exception e)
            {
                Console.WriteLine("Erro lancado no metodo Subtracao: " + e.Message);
            }
        }

        public void Multiplicacao()
        {
            try
            {

            }
            catch (Exception e)
            {
                Console.WriteLine("Erro lancado no metodo Multiplicacao: " + e.Message);
            }
        }

        public void Divisao()
        {
            try
            {

            }
            catch (Exception e)
            {
                Console.WriteLine("Erro lancado no metodo Divisao: " + e.Message);
            }
        }
    }
}
