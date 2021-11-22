using MessageBird.Objects.Conversations;
using System;
using System.Collections.Generic;
using System.Text;

namespace MessageBirdBotFrameworkWhatsAppAdapter.Models
{
    public class MessageBirdSendMessagePayload
    {
        public string conversationId { get; set; }
        public ConversationMessageSendRequest conversationMessageRequest { get; set; }
    }
}
