using CefSharp;
using CefSharp.WinForms;
using System.Windows.Forms;

namespace CefSharpSimpleDemo
{
    public partial class WebPage : Form
    {
        public WebPage()
        {
            InitializeComponent();
            GetWebPage();
        }
        public void GetWebPage()
        {
            CefSettings settings = new CefSettings();
            Cef.Initialize(settings);
            ChromiumWebBrowser webbrowser = new ChromiumWebBrowser("https://www.baidu.com/")
            { Dock = DockStyle.Fill };
            this.Controls.Add(webbrowser);
            webbrowser.Dock = DockStyle.Fill;
        }
    }

}
