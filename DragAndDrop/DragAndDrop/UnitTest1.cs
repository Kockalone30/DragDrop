using DragAndDrop.DropDownClass;
using DragAndDrop.WebDriver;

namespace DragAndDrop
{
    public class Tests
    {
        DragandDropPage dragAndDrop;

 
        [SetUp]
        public void Setup()
        {
            WebDriver.WebDriver.initialisation();
            dragAndDrop = new DragandDropPage();
        }

        [Test]
        public void Test1()
        {
            dragAndDrop.MoveObject();

         
        }
    }
}