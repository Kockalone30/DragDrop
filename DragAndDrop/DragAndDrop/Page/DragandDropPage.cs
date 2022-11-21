using DragAndDrop.WebDriver;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragAndDrop.DropDownClass
{
    internal class DragandDropPage
    {
        private IWebDriver driver = WebDriver.WebDriver.Instance;

        public IWebElement Drag => driver.FindElement(By.Id("draggable"));
        public IWebElement Drop => driver.FindElement(By.Id("droppable"));

        public void MoveObject()
        {
            var builded = new Actions(driver);
            var dragAndDrop = builded.ClickAndHold(Drag).MoveToElement(Drop).Release(Drag).Build();
            dragAndDrop.Perform();
        }


    }
}
