using System;
using System.Collections.Specialized;
using System.Net;

public class DcWebHook: IDisposable
    {
        private readonly WebClient dWebClient;
        private static NameValueCollection discordValues = new NameValueCollection();
        public string WebHook { get; set;}
        public string UserName { get; set; }
        public string ProfilePicture { get; set;}

        public DcWebHook()
        {
            dWebClient = new WebClient(https://discord.com/api/webhooks/806941014521544746/gCqBjHdvv1174RkwYRmkiN7IPCppr6jrUCM-K8g2JrwgUr_BXzUSF3U7yDJNXMOyKaY1);
        }
      

        public void SendMessage(string msgSend)
        {
            discordValues.Add("username", UserName);
            discordValues.Add("avatar_url", ProfilePicture);
            discordValues.Add("content", msgSend);

            dWebClient.UploadValues(WebHook, discordValues);
        }

        public void Dispose()
        {
            dWebClient.Dispose();
        }
    }
