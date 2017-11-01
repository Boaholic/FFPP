using System;
// refer to : https://msdn.microsoft.com/en-us/library/system.runtime.serialization.json(v=vs.110).aspx
//            https://docs.microsoft.com/en-us/dotnet/api/system.runtime.serialization.json?view=netframework-4.7.1
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Json;

namespace AppLayer
{
    //construct a data contract here
    //https://docs.microsoft.com/en-us/dotnet/api/system.runtime.serialization.datacontractattribute?view=netframework-4.7.1
    [DataContract(Name = "serverMessage", Namespace = "serverMessage")]
    public class serverMessage : IExtensibleDataObject
    {
        public enum messageType
        {
           JOIN,
           ACK,
           HB,
           CHAT
        }
        [DataMember(Name = "thisMessageType")]
        public messageType thisMessageType;
        [DataMember(Name = "messageBody")]
        public String messageBody;
        [DataMember(Name = "sentAs")]
        public String sentAs;
        [DataMember(Name = "initiator")]
        public String initiator;

        public serverMessage( messageType inputMsgType, String inputMessageBody, 
                              String inputSentAs, String inputInitiator)
        {
            thisMessageType = inputMsgType;
            messageBody = inputMessageBody;
            sentAs = inputSentAs;
            initiator = inputInitiator;
        }

        private ExtensionDataObject messageDataValue;
        public ExtensionDataObject ExtensionData
        {
            get
            {
                return messageDataValue;
            }
            set
            {
                messageDataValue = value;
            }
        }
    }
}
