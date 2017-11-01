using System.IO;
using System.Runtime.Serialization.Json;

namespace AppLayer
{

    public class messageReadWrite
    {
        serverMessage targetMessage { get; set; }
        public void DecodeMessage(byte[] encodedMessage)
        {
            MemoryStream rawData = new MemoryStream(encodedMessage);
            BinaryReader readingStream = new BinaryReader(rawData);
            DataContractJsonSerializer messageReader = new DataContractJsonSerializer(typeof(serverMessage));
            targetMessage = (serverMessage)messageReader.ReadObject(rawData);
        }

        public byte[] EncodeMessage()
        {
            MemoryStream writingStream = new MemoryStream();
            DataContractJsonSerializer messageWriter = new DataContractJsonSerializer(typeof(serverMessage));
            messageWriter.WriteObject(writingStream, targetMessage);
            return writingStream.GetBuffer();
        }

        public byte[] EncodeMessage(serverMessage inputMessage)
        {
            targetMessage = inputMessage;
            MemoryStream writingStream = new MemoryStream();
            DataContractJsonSerializer messageWriter = new DataContractJsonSerializer(typeof(serverMessage));
            messageWriter.WriteObject(writingStream, inputMessage);
            return writingStream.GetBuffer();
        }
    }
}