using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using xNet;
using System.IO;

namespace Kiseleva
{
    class Class1
    {
        public int Chislo = 0;
        public string __APPID;// = "3ca2edc65bd68b6db1cb43176ddb4d1e62281308";  //ключ
        private const string __FNSAPIURL = "https://api-fns.ru/api/check?req=";  //Ссылка для запросов

        public dynamic GetInformation(string INN)  //Получение заданной информации о пользователе с заданным ID 
        {
            StreamReader ControlInf = new StreamReader("Key.txt");//создаем переменную чтения файла с токеном
            __APPID = ControlInf.ReadLine();//присваиваем значение токена переменной
            ControlInf.Close();//закрываем файл
            HttpRequest GetInformation = new HttpRequest();
        //https://api-fns.ru/api/check?req=1027739471517&key=<Ваш ключ>
            string Result = GetInformation.Get(__FNSAPIURL + INN + "&key=" + __APPID).ToString();
            Result = Result.Substring(16, Result.Length - 19);
            dynamic Dict = JsonConvert.DeserializeObject(Result);
            return Dict;
        }
    }
}
