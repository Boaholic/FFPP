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
            ReadWrite _ReadWrite = new ReadWrite();
            Message TestMessage = new Message(Message.messageType.JOIN, "PlayerName");
            byte[] EncodedMessage = _ReadWrite.EncodeMessage(TestMessage);
            _ReadWrite.DecodeMessage(EncodedMessage);

            Assert.AreEqual(TestMessage.thisMessageType, _ReadWrite.targetMessage.thisMessageType);
            Assert.AreEqual(TestMessage.messageBody, _ReadWrite.targetMessage.messageBody);
        }
    }
}
