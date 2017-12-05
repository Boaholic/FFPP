using System;
using AppLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FFPPCommunication;

namespace TestMessageCoding
{
    [TestClass]
    public class MessageTesting
    {
        [TestMethod]
        public void TestingEncodingDecoding()
        {
            ReadWrite _messageReadWrite = new ReadWrite();
            Message TestMessage = new Message(MessageType.JOIN, "PlayerName");
            byte[] EncodedMessage = _messageReadWrite.EncodeMessage(TestMessage);
            _messageReadWrite.DecodeMessage(EncodedMessage);

            Assert.AreEqual(TestMessage.thisMessageType, _ReadWrite.targetMessage.thisMessageType);
            Assert.AreEqual(TestMessage.messageBody, _ReadWrite.targetMessage.messageBody);
        }
    }
}
