﻿using OpenQA.Selenium;
using System;
using System.Threading;

namespace Library
{
   public class UITextFiled//:Selenium
    {
     // Selenium selenium = new Selenium();
        public  static void EnterText(IWebDriver objDr,string txtTextField,string data)
        {
            try
            {
                Thread.Sleep(2000);
                Selenium.GetObject(objDr,txtTextField).SendKeys(data);
                Reporter.Report("Pass","value  "+"\""+data+"\""+" entered sucusessfully");



            }
            catch (Exception e)
            {
                Console.WriteLine("Exception : " + e.Message);
            }
        }


        public static string GetText(IWebDriver objDr,string txtTextField)
        {
            string strActText=null;

            try
            {
                Thread.Sleep(2000);
               strActText=Selenium.GetObject(objDr,txtTextField).GetAttribute("value");
               return strActText;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception : " + e.Message);
            }
           return strActText;
        }
    }
}
