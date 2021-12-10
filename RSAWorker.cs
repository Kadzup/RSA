using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace RSA
{
    class RSAWorker
    {
        public string pubKey;
        public string privKey;
        public RSACryptoServiceProvider csp;

        private RSAParameters privateKey;
        private RSAParameters publicKey;

        public RSAWorker()
        {
            csp = new RSACryptoServiceProvider(2048);
        }

        public string Encrypt(string text)
        {
            string retValue = "";

            //get a stream from the string
            var sr = new System.IO.StringReader(pubKey);
            //we need a deserializer
            var xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
            //get the object back from the stream
            //publicKey = (RSAParameters)xs.Deserialize(sr);

            csp = new RSACryptoServiceProvider();
            csp.ImportParameters(publicKey);

            //for encryption, always handle bytes...
            var bytesPlainTextData = System.Text.Encoding.Unicode.GetBytes(text);

            //apply pkcs#1.5 padding and encrypt our data 
            var bytesCypherText = csp.Encrypt(bytesPlainTextData, false);

            //we might want a string representation of our cypher text... base64 will do
            retValue = Convert.ToBase64String(bytesCypherText);

            return retValue;
        }

        public string Decrypt(string text)
        {
            string retValue = "";

            //get a stream from the string
            var sr = new System.IO.StringReader(privKey);
            //we need a deserializer
            var xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
            //get the object back from the stream
            //privateKey = (RSAParameters)xs.Deserialize(sr);

            csp = new RSACryptoServiceProvider();
            csp.ImportParameters(privateKey);

            //first, get our bytes back from the base64 string ...
            var bytesCypherText = Convert.FromBase64String(text);

            //we want to decrypt, therefore we need a csp and load our private key
            csp = new RSACryptoServiceProvider();
            csp.ImportParameters(privateKey);

            //decrypt and strip pkcs#1.5 padding
            var bytesPlainTextData = csp.Decrypt(bytesCypherText, false);

            //get our original plainText back...
            retValue = System.Text.Encoding.Unicode.GetString(bytesPlainTextData);

            return retValue;
        }

        public void CreateKeys()
        {
            privateKey = csp.ExportParameters(true);
            publicKey = csp.ExportParameters(false);

            // create pub key string and save it
            //we need some buffer
            var sw = new System.IO.StringWriter();
            //we need a serializer
            var xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
            //serialize the key into the stream
            xs.Serialize(sw, publicKey);
            //get the string from the stream
            var pubKeyString = sw.ToString();

            var rootElement = System.Xml.Linq.XElement.Parse(pubKeyString);
            pubKey = rootElement.Value;

            //////////////////////////////////////////////

            var sw1 = new System.IO.StringWriter();
            //we need a serializer
            var xs1 = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
            // create private key and save it
            xs1.Serialize(sw1, privateKey);
            //get the string from the stream
            var privKeyString = sw1.ToString();

            rootElement = System.Xml.Linq.XElement.Parse(privKeyString);
            privKey = rootElement.Value;
        }
    }
}
