using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Json;

namespace AppLayer
{

    public class serverMessageReadWrite
    {
        serverMessage targetMessage;
        public serverMessageReadWrite(byte[] encodedMessage)
        {
            MemoryStream rawData = new MemoryStream(encodedMessage);
            BinaryReader readingStream = new BinaryReader(rawData);
            DataContractJsonSerializer messageReader = new DataContractJsonSerializer(typeof(serverMessage));
            targetMessage = (serverMessage)messageReader.ReadObject(rawData);
        }

        byte[] EncodeMessage()
        {
            MemoryStream writingStream = new MemoryStream();
            DataContractJsonSerializer messageWriter = new DataContractJsonSerializer(typeof(serverMessage));
            messageWriter.WriteObject(writingStream, targetMessage);
            return writingStream.GetBuffer();
        }
    }
}