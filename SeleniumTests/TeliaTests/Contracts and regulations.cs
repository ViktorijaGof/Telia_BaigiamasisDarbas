using NUnit.Framework;
using SeleniumFramework.Pages;
using SeleniumFramework;

namespace SeleniumTests.TeliaTests
{
    public class Contracts_and_regulations : BaseTest
    {
        [SetUp]

        public void Open()
        {
            Buttons.Open();
        }

       // [Test]

       // public void OpenContractsAndRegulationsWindow()
       // {
            //string expectedResult = "Interneto paslaugų taisyklės";
           // Buttons.clickPagalba();
           // Buttons.clickSutartysIrSaskaitos();                     
           // Buttons.ClickPaslauguTeikimoDokumentai();
           // Buttons.GaliojantysNamuInternetoPaslauguTeikimoDokumentai();
           // Buttons.clickFirstHyperlinkBelowPaslauguteikimoDokumentai();
           // string actualResult = TextBox.GetDocumentHeading();
           // Assert.AreEqual(expectedResult, actualResult);
       // }        
    }
}
