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
        //https://www.codeproject.com/Articles/140911/log-net-Tutorial
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger
    (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
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

        public serverMessage( messageType inputMsgType, String inputMessageBody)
        {
            thisMessageType = inputMsgType;
            messageBody = inputMessageBody;
            log.Info("Input Message: " + inputMessageBody);
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
