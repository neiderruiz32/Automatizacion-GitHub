# Automatizacion-GitHub-Csharp
Automatización desarrollada en C# basado en la Programación Orientada a Objetos (POO), todo de manera Standalone.

El código está basado en Programación Orientada a Objetos (POO). El código define una clase llamada "Program" que contiene un método estático "Main".
Además, se utilizan objetos de las clases "ChromeOptions" y "ChromeDriver" para interactuar con el controlador de Chrome y el navegador web.

El código se considera "Standalone" ya que no depende de ninguna otra aplicación o sistema externo. 
Puede ejecutarse de forma independiente sin requerir ninguna configuración adicional.

El código está escrito en C#. Se utiliza la sintaxis de C# para definir clases, métodos, variables y realizar operaciones. 
También se utilizan las bibliotecas Selenium y OpenQA.Selenium.Chrome, que son bibliotecas de automatización de pruebas específicas de C#.

## Dependencias

- OpenQA.Selenium: La biblioteca Selenium WebDriver para interactuar con los navegadores web.
- OpenQA.Selenium.Chrome: La implementación de ChromeDriver para controlar el navegador Chrome.

## Instalación

1. Asegúrate de tener el navegador Chrome instalado en tu sistema.
2. Descarga el ejecutable ChromeDriver desde el sitio web oficial de Selenium: [https://sites.google.com/a/chromium.org/chromedriver/](https://sites.google.com/a/chromium.org/chromedriver/)
3. Extrae el ejecutable ChromeDriver descargado en una ubicación de tu sistema (por ejemplo, "C:\WebDrivers\chromedriver_win32\chromedriver.exe").
4. Establece la variable `chromeDriverPath` en el código con la ruta donde hayas extraído el ejecutable ChromeDriver.

## Uso

1. Ejecuta el programa utilizando un compilador de C# o un entorno de desarrollo integrado (IDE) que admita C#.
2. El programa abrirá el navegador Chrome y maximizará la ventana.
3. Navegará a "https://github.com/".
4. Luego, navegará a "https://github.com/search" para realizar una búsqueda.
5. Se ingresará el término de búsqueda "Selenium" en el cuadro de búsqueda y se enviará la búsqueda.
6. El programa esperará a que se cargue la página de resultados de búsqueda (ajusta el tiempo de espera implícito si es necesario).
7. Abrirá el cuarto elemento de la lista de resultados de búsqueda.
8. El programa capturará la descripción del proyecto desde la página.
9. La descripción se mostrará en la salida de la consola.

## Nota

- Asegúrate de que el ejecutable ChromeDriver coincida con la versión del navegador Chrome instalado en tu sistema.
- Es posible que debas actualizar la variable `chromeDriverPath` si extraes el ejecutable ChromeDriver a una ubicación diferente.
