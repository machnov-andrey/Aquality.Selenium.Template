using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace Aquality.Selenium.Template.Forms
{
    public class SearchResultsPage : Form
    {
        public IButton MoreFilters => ElementFactory.GetButton(By.XPath("//button[.//*[contains(text(),'Ещё фильтры')]]"), "Ещё фильтры");
        public ICheckBox FromOwner => ElementFactory.GetCheckBox(By.XPath("//span[contains(text(),'От собственника')]//preceding-sibling::span"), "От собственника");
        public IButton ShowObjects => ElementFactory.GetButton(By.XPath("//*[contains(text(), 'Показать объекты')]"), "Показать объекты");
        public IButton ChooseHouseSize(string size) => ElementFactory.GetButton(By.XPath($"//*[contains(text(),'Комнат в квартире')]//following-sibling::*//*[contains(text(), '{size}')]"), "Размер апартаментов");
        public IButton FirstResult => ElementFactory.GetButton(By.CssSelector("[data-testid=offer-card]"), "Первое объявление");
        
        public SearchResultsPage() : base(By.XPath("//*[contains(text(),'Разместить объявление')]"), "Страница результатов") { }


    }
}
