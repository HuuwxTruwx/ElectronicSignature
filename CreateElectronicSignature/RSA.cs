using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CreateElectronicSignature
{
    internal class RSA 
    {
        private static RSA instance = null;
        private static readonly object padlock = new object();

        public RSA() { }

        public static RSA Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new RSA();
                    }
                    return instance;
                }
            }
        }
        public static RSAParameters publicKey;
        private static RSAParameters privateKey;
        RSACryptoServiceProvider rsa= new RSACryptoServiceProvider(2048);
        //used for storing public and private key in xml format
        public string publicAndPrivateKey;

        public void GenerateKeys()
        {           
            //not storing in key container
                rsa.PersistKeyInCsp = false;
                publicKey = rsa.ExportParameters(true);
                privateKey = rsa.ExportParameters(true);
                publicAndPrivateKey = rsa.ToXmlString(true);     
        }  

        public byte[] GenarateSignature(byte[] data)
        {           
               byte[] signature =  rsa.SignData(data, "SHA512");
               return signature;          
        }

        public bool VerifySignature(byte[] data, byte[] signature )
        {        
                bool trust = rsa.VerifyData(data,"SHA512", signature);
                return trust;            
        }
        public void LoadKeyFromXML()
        {
            publicAndPrivateKey = File.ReadAllText(@"D:\RSA\Key.xml");
            rsa.FromXmlString(publicAndPrivateKey);
            publicKey = rsa.ExportParameters(true);
            privateKey = rsa.ExportParameters(true);

        }
        public RSAParameters GetPrivateKey()
        {
            return privateKey;
        }

        public string GetPublicKeyXML()
        {
            var sw = new StringWriter();
            var xs = new XmlSerializer(typeof(RSAParameters));
            xs.Serialize(sw,publicKey);
            return sw.ToString();
        }

        public string GetPrivateKeyXML()
        {
            var sw = new StringWriter();
            var xs = new XmlSerializer(typeof(RSAParameters));
            xs.Serialize(sw, privateKey);
            return sw.ToString();
        }
        public string GetPublicAndPrivateKey()
        {
            return publicAndPrivateKey;
        }

        public void SaveKeyToXML()
        {
            publicAndPrivateKey = rsa.ToXmlString(true);
            File.WriteAllText(@"D:\RSA\Key.xml", publicAndPrivateKey);
        }
        public void MakeCert()
        {         
            var req = new CertificateRequest("cn=NguyenHuuTru", rsa, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);
            var cert = req.CreateSelfSigned(DateTimeOffset.Now, DateTimeOffset.Now.AddYears(5));

            // Create PFX (PKCS #12) with private key
            File.WriteAllBytes(@"D:\RSA\mycert.pfx", cert.Export(X509ContentType.Pfx, "123456"));

            // Create Base 64 encoded CER (public key only)
            //File.WriteAllText("c:\\temp\\mycert.cer",
            //    "-----BEGIN CERTIFICATE-----\r\n"
            //    + Convert.ToBase64String(cert.Export(X509ContentType.Cert), Base64FormattingOptions.InsertLineBreaks)
            //    + "\r\n-----END CERTIFICATE-----");
        }


    }
}
