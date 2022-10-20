using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBotWeb.Data
{
    public class ChatbotGroup
    {
        public string IntentGroup { get; set; } 

        public List<ChatbotText> Text { get; set; }
    }
}
