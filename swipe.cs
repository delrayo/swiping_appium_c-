/// this code works Following the W3C standards

using System.Threading;
using OpenQA.Selenium.Appium.MultiTouch;

float object1CoordinateX = 500;
float object1CoordinateY = 500;
float object2CoordinateX = 500;
float object2CoordinateY = 1000;

TouchAction actionOne = new TouchAction((OpenQA.Selenium.Appium.Interfaces.IPerformsTouchActions)TestData.driver);
actionOne.Press(object1CoordinateX, object1CoordinateY);
actionOne.MoveTo(object2CoordinateX, object2CoordinateY);
actionOne.Release();
actionOne.Perform();
Thread.Sleep(2500);
