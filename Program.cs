using System.Collections.ObjectModel;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

var driver = new ChromeDriver();

driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(500);

driver.Navigate().GoToUrl("https://www.imdb.com/chart/top");

var title = driver.Title;
Console.WriteLine(title);

ReadOnlyCollection<IWebElement> filmes = driver
    .FindElement(By.ClassName("ipc-page-grid"))
    .FindElements(By.TagName("li"));

foreach (var filme in filmes)
{
    try
    {
        var name = filme.FindElement(By.TagName("h3")).Text;
        Console.WriteLine(name);
    }
    catch (System.Exception)
    {
      
    }
}






driver.Quit();