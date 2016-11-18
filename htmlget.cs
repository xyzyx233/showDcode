using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace codedecode
{
    class htmlget
    {
        private string html;
        private string web;
        public string Html
        {
            get { return html; }
        }
        public htmlget(string web)
        {
            this.web = web;
            getinfo();
        }
        private void getinfo()
        {
            WebClient MyWebClient = new WebClient();


            MyWebClient.Credentials = CredentialCache.DefaultCredentials;//获取或设置用于向Internet资源的请求进行身份验证的网络凭据

            Byte[] pageData = MyWebClient.DownloadData(web); //从指定网站下载数据

            //string pageHtml = Encoding.Default.GetString(pageData);  //如果获取网站页面采用的是GB2312，则使用这句            

            html = Encoding.UTF8.GetString(pageData); //如果获取网站页面采用的是UTF-8，则使用这句

        }
    }
}
