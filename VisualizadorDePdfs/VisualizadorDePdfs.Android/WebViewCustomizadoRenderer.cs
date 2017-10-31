using System.Net;
using VisualizadorDePdfs.Customizados;
using VisualizadorDePdfs.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(WebViewCustomizado), typeof(WebViewCustomizadoRenderer))]
namespace VisualizadorDePdfs.Droid
{
    public class WebViewCustomizadoRenderer:WebViewRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<WebView> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                var customWebView = Element as WebViewCustomizado;
                Control.Settings.AllowUniversalAccessFromFileURLs = true;

                Control.LoadUrl(string.Format("file:///android_asset/pdfjs/web/viewer.html?file={0}",WebUtility.UrlEncode(customWebView.Uri)));

                //Control.LoadUrl(string.Format("file:///android_asset/pdfjs/web/viewer.html?file={0}",
                //    string.Format("file:///android_asset/Content/{0}",
                //    WebUtility.UrlEncode(customWebView.Uri))));
            }
        }
    }
}