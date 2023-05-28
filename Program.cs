using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomatedProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Establecer la ubicación del archivo ChromeDriver
            string chromeDriverPath = "C:\\WebDrivers\\chromedriver_win32\\chromedriver.exe";
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized");

            // Crear una instancia del controlador de Chrome
            IWebDriver driver = new ChromeDriver(chromeDriverPath, options);

            try
            {
                // Navegar a la URL proporcionada
                driver.Navigate().GoToUrl("https://github.com/");

                // Navegar a la URL de búsqueda
                driver.Navigate().GoToUrl("https://github.com/search");

                // Buscar la palabra "Selenium"
                IWebElement searchBox = driver.FindElement(By.Name("q"));
                searchBox.SendKeys("Selenium");
                searchBox.Submit();

                // Esperar a que se cargue la página de resultados
                // Puedes ajustar el tiempo de espera según sea necesario
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

                // Abrir el cuarto ítem de la lista de búsqueda
                IWebElement fourthItem = driver.FindElement(By.CssSelector(".repo-list-item:nth-child(4) a"));
                fourthItem.Click();

                // Capturar la descripción del proyecto
                IWebElement projectDescription = driver.FindElement(By.CssSelector(".repository-description"));
                string description = projectDescription.Text;

                // Mostrar la descripción en la consola
                Console.WriteLine(description);
            }
            finally
            {
                // Cerrar el navegador y finalizar la sesión
                driver.Quit();
            }
        }
    }
}
