using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace Aquality.Selenium.Template.Forms
{
    public class OfferPage : Form
    {
        private static By CommonLocator = By.CssSelector("[data-name=OfferTitle]");

        public ILabel Title => ElementFactory.GetLabel(CommonLocator, "Название объявления");
        public ILabel Price => ElementFactory.GetLabel(By.CssSelector("[itemprop=price]"), "Цена");
        public ILabel HouseSize => ElementFactory.GetLabel(By.XPath("//span[contains(text(),'Всего комнат в квартире')]//following-sibling::*"), "Размер апартаментов");
        public ILabel Owner => ElementFactory.GetLabel(By.XPath("//h2[text()='Собственник']"), "Собственник");
        public IButton CallPhone => ElementFactory.GetButton(By.XPath("//*[contains(@data-name,'OfferContactsAside')]//button"), "Телефон");

        public OfferPage() : base(CommonLocator, "Объявление") { }
    }
}
