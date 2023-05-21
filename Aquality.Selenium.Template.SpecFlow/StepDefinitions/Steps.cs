using Aquality.Selenium.Browsers;
using Aquality.Selenium.Template.Configurations;
using Aquality.Selenium.Template.Forms;
using NUnit.Framework;
using System.Text.RegularExpressions;
using System.Threading;
using TechTalk.SpecFlow;

namespace Aquality.Appium.Mobile.Template.SpecFlow.StepDefinitions
{
    [Binding]
    public class Steps
    {
        private int wait = 2000;

        private static MainPage MainPage = new();
        private static SearchResultsPage SearchResultsPage = new();
        private static OfferPage OfferPage = new();

        [When(@"I log in in Cian with email '(.*)' and password '(.*)'")]
        public void ILoginCian(string email, string password)
        {
            AqualityServices.Browser.GoTo(Configuration.StartUrl);
            AqualityServices.Browser.Maximize();

            MainPage.GeoLocation.Click();
            Thread.Sleep(wait);
            MainPage.Moscow.Click();
            Thread.Sleep(wait);
            MainPage.Choose.Click();
            Thread.Sleep(wait);

            MainPage.StartLogin.Click();
            Thread.Sleep(wait);
            MainPage.OtherWay.Click();
            Thread.Sleep(wait);
            MainPage.Email.SendKeys(email);
            MainPage.Continue.Click();
            Thread.Sleep(wait);
            MainPage.Password.SendKeys(password);
            Thread.Sleep(wait);
            MainPage.Continue.Click();
            Thread.Sleep(wait);
        }

        [When(@"I choose rent")]
        public void IChooseRent()
        {
            MainPage.Rent.Click();
            Thread.Sleep(wait);
        }

        [When(@"I fill in filters: house type - 'Комната'")]
        public void IFillInFilters()
        {
            MainPage.HouseType.Click();
            Thread.Sleep(wait);
            MainPage.RoomApartment.Check();
            Thread.Sleep(wait);
        }

        [When(@"I set price from '(.*)' to '(.*)' and set true owner check box")]
        public void IFillInPrice(string priceFrom, string priceTo)
        {
            MainPage.Price.Click();
            Thread.Sleep(wait);
            MainPage.PriceFrom.SendKeys(priceFrom);
            Thread.Sleep(wait);
            MainPage.PriceTo.SendKeys(priceTo);
            Thread.Sleep(wait);
            MainPage.Find.Click();
            Thread.Sleep(wait);
        }

        [When(@"I fill more filters: owner check box and house size: '(.*)'")]
        public void IFillMoreFilters(string houseSize)
        {
            SearchResultsPage.MoreFilters.Click();
            Thread.Sleep(wait);
            SearchResultsPage.FromOwner.Click();
            Thread.Sleep(wait);
            SearchResultsPage.ChooseHouseSize(houseSize).Click();
            Thread.Sleep(wait);
        }

        [When(@"I choose first offer")]
        public void IClickOffer()
        {
            SearchResultsPage.ShowObjects.Click();
            Thread.Sleep(wait);
            SearchResultsPage.FirstResult.Click();
            Thread.Sleep(wait);
            AqualityServices.Browser.Tabs().SwitchToLastTab(closeCurrent: true);
            Thread.Sleep(wait);
        }

        [Then(@"Expected owner indicator, house type '(.*)', price range '(.*)'-'(.*)' and house size '(.*)'")]
        public void CheckFilters(string houseType, string priceFrom, string priceTo, string houseSize)
        {
            var price = int.Parse(Regex.Replace(OfferPage.Price.Text.Replace("₽/мес.", string.Empty), "[^.0-9]", ""));

            StringAssert.Contains(houseType, OfferPage.Title.Text, "Тип объявления");
            Assert.GreaterOrEqual(price, int.Parse(priceFrom), "Цена от");
            Assert.LessOrEqual(price, int.Parse(priceTo), "Цена до");
            Assert.IsTrue(OfferPage.Owner.State.IsDisplayed, "От собственника?");
            Assert.AreEqual(houseSize, OfferPage.HouseSize.Text, "Количество комнат в квартире");
        }

        [When(@"I click to show phone")]
        public void ShowPhone()
        {
            OfferPage.CallPhone.Click();
            Thread.Sleep(wait);
        }
    }
}
