using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace MessageBirdBotFrameworkWhatsAppAdapter
{
    public class MessageBirdAdapterOptions
    {
        public MessageBirdAdapterOptions(IConfiguration configuration)
            : this(configuration["MessageBirdAccessKey"], configuration["MessageBirdSigningKey"], Convert.ToBoolean(configuration["MessageBirdDisableRequestVerification"]))
        { }

        public MessageBirdAdapterOptions(string accessKey, string signingKey, bool disableRequestVerification)
        {
            AccessKey = accessKey;
            SigningKey = signingKey;
            DisableRequestVerification = disableRequestVerification;
        }
        public string AccessKey { get; set; }
        public string SigningKey { get; set; }
        public bool DisableRequestVerification { get; set; }
    }
}
