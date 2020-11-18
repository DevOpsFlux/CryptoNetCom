/*-------------------------------------------------------
'	프로그램명	: CryptoNetCom
'	작성자		: DevOpsFlux
'	작성일		: 2018-01-17
'	설명		: CryptUtil class
' -------------------------------------------------------*/
using System;
using System.Text;
using System.IO;

namespace CryptoNetCom
{
    class CryptUtil
    {
        public static string GetHexFromByte(byte[] bytes)
        {
            using (var stream = new MemoryStream(bytes))
            {
                using (var streamReader = new StreamReader(stream))
                {
                    return streamReader.ReadToEnd();
                }
            }
        }
        public static byte[] GetHexArray(string s)
        {
            byte[] rtnVal = Encoding.Default.GetBytes(s);

            return rtnVal;
        }

        private byte[] StringToByteArray(string str)
        {
            //use any encoding you want to
            //return System.Text.Encoding.ASCII.GetBytes(str);
            return System.Text.Encoding.Default.GetBytes(str);
        }

        private string ByteArrayToString(byte[] arr)
        {
            //use any encoding you want to
            //return System.Text.Encoding.ASCII.GetString(str);
            return System.Text.Encoding.Default.GetString(arr);
        }
    }
}
