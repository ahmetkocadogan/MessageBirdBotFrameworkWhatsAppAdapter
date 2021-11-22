using MessageBird;
using MessageBird.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace MessageBirdBotFrameworkWhatsAppAdapter
{
    public class MessageBirdRequestAuthorization
    {
        public bool Verify(string _messageBirdSignature, string _signingKey, string _timeStampt, string _requestBody)
        {
            byte[] _requestBodyByte = Encoding.ASCII.GetBytes(_requestBody);

            var requestSigner = new RequestSigner(Encoding.ASCII.GetBytes(_signingKey));

            var request = new Request(_timeStampt, "", _requestBodyByte);

            return requestSigner.IsMatch(_messageBirdSignature, request);

            //return true;
        }
    }
}
