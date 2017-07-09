using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;

namespace TongjiAssessment.HttpHelper
{
    public static class Helper
    {
        public static bool isTongjiUser(string username, string password)
        {
            string postData = "Ecom_User_ID=" + username + "&Ecom_Password=" + password;
            byte[] byteArray = Encoding.UTF8.GetBytes(postData); // 转化
            HttpWebRequest webRequest2 = (HttpWebRequest)WebRequest.Create(new Uri("https://ids.tongji.edu.cn:8443/nidp/app?sid=2"));
            webRequest2.Method = "POST";
            webRequest2.ContentType = "application/x-www-form-urlencoded";
            webRequest2.ContentLength = byteArray.Length;
            Stream newStream = webRequest2.GetRequestStream();
            newStream.Write(byteArray, 0, byteArray.Length);    //写入参数
            newStream.Close();
            HttpWebResponse response2 = (HttpWebResponse)webRequest2.GetResponse();
            StreamReader sr2 = new StreamReader(response2.GetResponseStream(), Encoding.Default);
            string text2 = sr2.ReadToEnd();
            Console.Write(text2);
            if (text2.IndexOf("top.location.href") != -1)
            {
                return true;
            }
            return false;
        }
    }
}