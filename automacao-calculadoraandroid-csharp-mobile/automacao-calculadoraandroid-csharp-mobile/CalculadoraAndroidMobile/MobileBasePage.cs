using System;
using automacao_calculadoraandroid_csharp_mobile_CalculadoraAndroidMobile_CalculadoraAndroidMobile;
using automacao_calculadoraandroid_csharp_mobile_CalculadoraAndroidMobile_CalcMobileVariables;
using automacao_calculadoraandroid_csharp_mobile_CalculadoraAndroidMobile_MobileUtils;
using automacao_calculadoraandroid_csharp_mobile_CalculadoraAndroidMobile_GeradorPDF;
using OpenQA.Selenium.Appium.Android;
using System.Threading;

namespace automacao_calculadoraandroid_csharp_mobile_CalculadoraAndroidMobile_MobileBasePage
{
    public class MobileBasePage : MobileDriver
    {
        public AndroidDriver<AndroidElement> _driver;
        public CalcMobileVariables calcMobileVariables;
        public MobileUtils mobileUtils;
        public GeradorPDF geradorPDF;

        public MobileBasePage(AndroidDriver<AndroidElement> driver, string cenario)
        {
            _driver = driver;
            calcMobileVariables = new CalcMobileVariables(_driver);
            mobileUtils = new MobileUtils(_driver);

            string nomeDaEvidencia = "Evidencias Calculadora Android_"+ cenario +"_"+ mobileUtils.GerarDataHoraFormatada();
            geradorPDF = new GeradorPDF(_driver, nomeDaEvidencia, cenario);
        }

        public void Soma()
        {
            try
            {
                Thread.Sleep(3);
                geradorPDF.evidenciaElemento("Digitar números");
                mobileUtils.Clicar(calcMobileVariables.BtnUm);
                mobileUtils.Clicar(calcMobileVariables.BtnCinco);
                mobileUtils.Clicar(calcMobileVariables.BtnNove);

                mobileUtils.Clicar(calcMobileVariables.BtnSomar);
                geradorPDF.evidenciaElemento("Clicar em somar");

                mobileUtils.Clicar(calcMobileVariables.BtnNove);
                mobileUtils.Clicar(calcMobileVariables.BtnSeis);
                mobileUtils.Clicar(calcMobileVariables.BtnTres);
                geradorPDF.evidenciaElemento("Clicar em igual");

                mobileUtils.Clicar(calcMobileVariables.BtnIgual);

                geradorPDF.evidenciaElemento("Validar resultado");
                mobileUtils.ValidarTextoDoElemento(calcMobileVariables.TxtResultado, "1122");
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro lancado no metodo Soma: " + e.Message);
            }
            geradorPDF.finishPdf();
        }

        public void Subtracao()
        {
            try
            {
                Thread.Sleep(3);
                geradorPDF.evidenciaElemento("Digitar números");
                mobileUtils.Clicar(calcMobileVariables.BtnDois);
                mobileUtils.Clicar(calcMobileVariables.BtnZero);
                mobileUtils.Clicar(calcMobileVariables.BtnDois);
                mobileUtils.Clicar(calcMobileVariables.BtnUm);

                mobileUtils.Clicar(calcMobileVariables.BtnSubtrair);
                geradorPDF.evidenciaElemento("Clicar em subtrair");

                mobileUtils.Clicar(calcMobileVariables.BtnUm);
                mobileUtils.Clicar(calcMobileVariables.BtnNove);
                mobileUtils.Clicar(calcMobileVariables.BtnOito);
                mobileUtils.Clicar(calcMobileVariables.BtnOito);
                geradorPDF.evidenciaElemento("Clicar em igual");

                mobileUtils.Clicar(calcMobileVariables.BtnIgual);

                geradorPDF.evidenciaElemento("Validar resultado");
                mobileUtils.ValidarTextoDoElemento(calcMobileVariables.TxtResultado, "33");
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro lancado no metodo Subtracao: " + e.Message);
            }
            geradorPDF.finishPdf();
        }

        public void Multiplicacao()
        {
            try
            {
                Thread.Sleep(3);
                geradorPDF.evidenciaElemento("Digitar números");
                mobileUtils.Clicar(calcMobileVariables.BtnUm);
                mobileUtils.Clicar(calcMobileVariables.BtnSeis);
                mobileUtils.Clicar(calcMobileVariables.BtnZero);

                mobileUtils.Clicar(calcMobileVariables.BtnMultiplicar);
                geradorPDF.evidenciaElemento("Clicar em multiplicar");

                mobileUtils.Clicar(calcMobileVariables.BtnCinco);
                mobileUtils.Clicar(calcMobileVariables.BtnSeis);
                mobileUtils.Clicar(calcMobileVariables.BtnZero);
                geradorPDF.evidenciaElemento("Clicar em igual");

                mobileUtils.Clicar(calcMobileVariables.BtnIgual);

                geradorPDF.evidenciaElemento("Validar resultado");
                mobileUtils.ValidarTextoDoElemento(calcMobileVariables.TxtResultado, "89600");
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro lancado no metodo Multiplicacao: " + e.Message);
            }
            geradorPDF.finishPdf();
        }

        public void Divisao()
        {
            try
            {
                Thread.Sleep(3);
                geradorPDF.evidenciaElemento("Digitar números");
                mobileUtils.Clicar(calcMobileVariables.BtnSete);
                mobileUtils.Clicar(calcMobileVariables.BtnDois);

                mobileUtils.Clicar(calcMobileVariables.BtnDividir);
                geradorPDF.evidenciaElemento("Clicar em dividir");

                mobileUtils.Clicar(calcMobileVariables.BtnDois);
                geradorPDF.evidenciaElemento("Clicar em igual");

                mobileUtils.Clicar(calcMobileVariables.BtnIgual);

                geradorPDF.evidenciaElemento("Validar resultado");
                mobileUtils.ValidarTextoDoElemento(calcMobileVariables.TxtResultado, "36");
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro lancado no metodo Divisao: " + e.Message);
            }
            geradorPDF.finishPdf();
        }
    }
}
