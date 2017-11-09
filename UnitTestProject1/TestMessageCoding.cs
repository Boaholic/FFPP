using System;
using AppLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestMessageCoding
{
    [TestClass]
    public class MessageTesting
    {
        [TestMethod]
        public void TestingEncodingDecoding()
        {
            MessageReadWrite _messageReadWrite = new MessageReadWrite();
            Message TestMessage = new Message(Message.messageType.JOIN, "PlayerName");
            byte[] EncodedMessage = _messageReadWrite.EncodeMessage(TestMessage);
            _messageReadWrite.DecodeMessage(EncodedMessage);

            Assert.AreEqual(TestMessage.thisMessageType, _messageReadWrite.targetMessage.thisMessageType);
            Assert.AreEqual(TestMessage.messageBody, _messageReadWrite.targetMessage.messageBody);
        }
    }
}
