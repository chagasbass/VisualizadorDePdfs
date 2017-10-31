using Xamarin.Forms;

namespace VisualizadorDePdfs.Customizados
{
    /// <summary>
    /// WebView customizado
    /// </summary>
    public class WebViewCustomizado:WebView
    {
        public static readonly BindableProperty UriProperty = BindableProperty.Create(propertyName: "Uri",
            returnType: typeof(string),
            declaringType: typeof(WebViewCustomizado),
            defaultValue: default(string));

        public string Uri
        {
            get { return (string)GetValue(UriProperty); }
            set { SetValue(UriProperty, value); }
        }
    }
}
