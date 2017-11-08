using System.IO;
using System.Runtime.Serialization.Json;


namespace AppLayer
{

    public class MessageReadWrite
    {
        //https://www.codeproject.com/Articles/140911/log-net-Tutorial
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(Message));
        Message targetMessage { get; set; }
        public void DecodeMessage(byte[] encodedMessage)
        {
            MemoryStream rawData = new MemoryStream(encodedMessage);
            log.Info("Received Byte Stream: " + rawData.ToString());
            BinaryReader readingStream = new BinaryReader(rawData);
            DataContractJsonSerializer messageReader = new DataContractJsonSerializer(typeof(Message));
            targetMessage = (Message)messageReader.ReadObject(rawData);
            log.Info("Extracted JSON: " + targetMessage.ToString());
        }

        public byte[] EncodeMessage()
        {
            MemoryStream writingStream = new MemoryStream();
            DataContractJsonSerializer messageWriter = new DataContractJsonSerializer(typeof(Message));
            log.Info("Message before encoding: " + targetMessage.ToString());
            messageWriter.WriteObject(writingStream, targetMessage);
            log.Info("Message after encoding: " + writingStream.GetBuffer());
            return writingStream.GetBuffer();
        }

        public byte[] EncodeMessage(Message inputMessage)
        {
            targetMessage = inputMessage;
            log.Info("Message before encoding: " + targetMessage.ToString());
            DataContractJsonSerializer messageWriter = new DataContractJsonSerializer(typeof(Message));
            MemoryStream writingStream = new MemoryStream();
            messageWriter.WriteObject(writingStream, inputMessage);
            log.Info("Message after encoding: " + writingStream.GetBuffer());
            return writingStream.GetBuffer();
        }
    }
}