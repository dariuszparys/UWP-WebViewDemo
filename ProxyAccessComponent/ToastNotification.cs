using System;
using System.Threading.Tasks;
using Windows.Data.Xml.Dom;
using Windows.UI.Notifications;

namespace ProxyAccessComponent
{
    [Windows.Foundation.Metadata.AllowForWeb]
    public sealed class Proxy
    {
        public async void ShowMessage(string message, int delay)
        {
            ToastTemplateType template = ToastTemplateType.ToastText01;
            XmlDocument xml = ToastNotificationManager.GetTemplateContent(template);

            XmlNodeList elements = xml.GetElementsByTagName("text");
            elements[0].AppendChild(xml.CreateTextNode(message));
            ToastNotification toast = new ToastNotification(xml);

            await Task.Delay(delay);
            ToastNotificationManager.CreateToastNotifier().Show(toast);
        }
    }
}

