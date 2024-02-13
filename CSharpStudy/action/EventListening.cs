using System;
using System.Collections.Generic;


namespace EventTest
{
    public static class EventTestClass
    {
        public static void Foo()
        {
            var manager = new UIManager();
            var button = new Button();
            manager.Initialize();

            button.Click();
            button.Click();
            button.Click();

            //GameObject.Destroy
            manager.Dispose();
            manager.Initialize();

            button.Click();
            button.Click();
            button.Click();
        }
    }

    public class UIManager : IDisposable
    {
        private class Logger
        {
            public void Logging()
            {
                Console.WriteLine("OnButtonClick");
            }
        }

        private Logger LoggerInstance;

        public void Initialize()
        {
            LoggerInstance = new Logger();

            //List구조에 추가됨
            Button.onClick += OnButtonClick;

            //다지워지고 얘만들어감, 대신 event 예약어가 있다면 사용불가
            //Button.onClick = null 이랑 같음 (대입연산)
            //Button.onClick = OnButtonClick;
        }

        private void OnButtonClick()
        {
            LoggerInstance.Logging();
        }

        public void Dispose()
        {
            Button.onClick -= OnButtonClick;
            LoggerInstance = null;
        }
    }


    public class Button
    {
        public static event Action onClick;

        public void Click()
        {
            onClick?.Invoke();
        }

        public void Clear()
        {
        }
    }

}