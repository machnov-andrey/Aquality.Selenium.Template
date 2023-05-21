using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace Aquality.Selenium.Template.Forms
{
    public class MainPage : Form
    {
        public IButton StartLogin => ElementFactory.GetButton(By.XPath("//*[contains(text(),'Войти')]"), "Войти");
        public IButton OtherWay => ElementFactory.GetButton(By.XPath("//*[contains(@data-name,'SwitchToEmailAuthBtn')]"), "Другим способом");
        public ITextBox Email => ElementFactory.GetTextBox(By.CssSelector("[name=username]"), "Email");
        public ITextBox Password => ElementFactory.GetTextBox(By.CssSelector("[name=password]"), "Password");
        public IButton Continue => ElementFactory.GetButton(By.CssSelector("[data-name=ContinueAuthBtn]"), "Продолжить");
        public ITextBox PriceFrom => ElementFactory.GetTextBox(By.CssSelector("[placeholder=от]"), "Цена от");
        public ITextBox PriceTo => ElementFactory.GetTextBox(By.CssSelector("[placeholder=до]"), "Цена до");
        public IButton Rent => ElementFactory.GetButton(By.XPath("//*[contains(text(),'Снять')]"), "Снять");
        public IButton HouseType => ElementFactory.GetButton(By.CssSelector("[title=Квартиру]"), "Тип апартаментов");
        public IButton HouseSize => ElementFactory.GetButton(By.CssSelector("[title=1, 2 комн.]"), "Размер апартаментов");
        public ICheckBox HouseApartment => ElementFactory.GetCheckBox(By.XPath("//span[contains(text(),'Квартира')]//preceding-sibling::*"), "Чек-бок 'Квартира'");
        public ICheckBox RoomApartment => ElementFactory.GetCheckBox(By.XPath("//span[contains(text(),'Комната')]//preceding-sibling::*"), "Чек-бок 'Квартира'");
        public IButton Price => ElementFactory.GetButton(By.XPath("//button[contains(text(),'Цена')]"), "Цена");
        public IButton Find => ElementFactory.GetButton(By.XPath("//a[contains(text(),'Найти')]"), "Найти");
        public IButton GeoLocation => ElementFactory.GetButton(By.CssSelector("[data-name=GeoSwitcher] > button"), "Геолокация");
        public IButton Moscow => ElementFactory.GetButton(By.XPath("//*[contains(@data-name,'GeoSwitcherBody')]//button"), "Москва");
        public IButton Choose => ElementFactory.GetButton(By.XPath("//button//*[contains(text(),'Выбрать')]"), "Выбрать");

        public MainPage() : base(By.XPath("//*[contains(text(),'Разместить объявление')]"), "Главная страница") { }
    }
}
