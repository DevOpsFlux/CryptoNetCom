/*-------------------------------------------------------
'	프로그램명	: CryptoNetCom
'	작성자		: DevOpsFlux
'	작성일		: 2018-01-17
'	설명		: Crypto Library
' -------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.EnterpriseServices;

namespace CryptoNetCom
{
    [JustInTimeActivation(true)]
    [Transaction(TransactionOption.NotSupported)]
    public class CryptLib : ServicedComponent
    {
        public bool SeedEncrypt(string strKey, string strText, out string outVal, out string outErrMsg)
        {
            bool bResult = false;
            string strVal = string.Empty;

            try
            {
                CryptSeed seed = new CryptSeed();
                strVal = seed.seedEncryptString(strKey, strText);
                bResult = true;
                outErrMsg = "success";
            }
            catch (Exception ex)
            {
                bResult = false;
                outErrMsg = ex.ToString();
            }
            finally
            {
                outVal = strVal;
            }

            return bResult;
        }

        public bool SeedDecrypt(string strKey, string strEnc, out string outVal, out string outErrMsg)
        {
            bool bResult = false;
            string strVal = string.Empty;

            try {
                CryptSeed seed = new CryptSeed();
                strVal = seed.seedDecryptString(strKey, strEnc);
                bResult = true;
                outErrMsg = "success";
            }
            catch (Exception ex)
            {
                bResult = false;
                outErrMsg = ex.ToString();
            }
            finally
            {
                outVal = strVal;
            }

            return bResult;
        }

        public bool SeedECBEncrypt(string strKey, string strIV, string strText, out string outVal, out string outErrMsg)
        {
            bool bResult = false;
            string strVal = string.Empty;

            try
            {
                CryptSeed seed = new CryptSeed();
                strVal = seed.seedEncryptString(strKey, strIV, "ECB", "N", strText);
                bResult = true;
                outErrMsg = "success";
            }
            catch (Exception ex)
            {
                bResult = false;
                outErrMsg = ex.ToString();
            }
            finally
            {
                outVal = strVal;
            }

            return bResult;
        }

        public bool SeedECBDecrypt(string strKey, string strIV, string strEnc, out string outVal, out string outErrMsg)
        {
            bool bResult = false;
            string strVal = string.Empty;

            try
            {
                CryptSeed seed = new CryptSeed();
                strVal = seed.seedDecryptString(strKey, strIV, "ECB", "N", strEnc);
                bResult = true;
                outErrMsg = "success";
            }
            catch (Exception ex)
            {
                bResult = false;
                outErrMsg = ex.ToString();
            }
            finally
            {
                outVal = strVal;
            }

            return bResult;
        }

        public bool SeedECBPADEncrypt(string strKey, string strIV, string strText, out string outVal, out string outErrMsg)
        {
            bool bResult = false;
            string strVal = string.Empty;

            try
            {
                CryptSeed seed = new CryptSeed();
                strVal = seed.seedEncryptString(strKey, strIV, "ECB", "Y", strText);
                bResult = true;
                outErrMsg = "success";
            }
            catch (Exception ex)
            {
                bResult = false;
                outErrMsg = ex.ToString();
            }
            finally
            {
                outVal = strVal;
            }

            return bResult;
        }

        public bool SeedECBPADDecrypt(string strKey, string strIV, string strEnc, out string outVal, out string outErrMsg)
        {
            bool bResult = false;
            string strVal = string.Empty;

            try
            {
                CryptSeed seed = new CryptSeed();
                strVal = seed.seedDecryptString(strKey, strIV, "ECB", "Y", strEnc);
                bResult = true;
                outErrMsg = "success";
            }
            catch (Exception ex)
            {
                bResult = false;
                outErrMsg = ex.ToString();
            }
            finally
            {
                outVal = strVal;
            }

            return bResult;
        }

        public bool SeedCBCEncrypt(string strKey, string strIV, string strText, out string outVal, out string outErrMsg)
        {
            bool bResult = false;
            string strVal = string.Empty;

            try
            {
                CryptSeed seed = new CryptSeed();
                strVal = seed.seedEncryptString(strKey, strIV, "CBC", "N", strText);
                bResult = true;
                outErrMsg = "success";
            }
            catch (Exception ex)
            {
                bResult = false;
                outErrMsg = ex.ToString();
            }
            finally
            {
                outVal = strVal;
            }

            return bResult;
        }

        public bool SeedCBCDecrypt(string strKey, string strIV, string strEnc, out string outVal, out string outErrMsg)
        {
            bool bResult = false;
            string strVal = string.Empty;

            try
            {
                CryptSeed seed = new CryptSeed();
                strVal = seed.seedDecryptString(strKey, strIV, "CBC", "N", strEnc);
                bResult = true;
                outErrMsg = "success";
            }
            catch (Exception ex)
            {
                bResult = false;
                outErrMsg = ex.ToString();
            }
            finally
            {
                outVal = strVal;
            }

            return bResult;
        }

        public bool SeedCBCPADEncrypt(string strKey, string strIV, string strText, out string outVal, out string outErrMsg)
        {
            bool bResult = false;
            string strVal = string.Empty;

            try
            {
                CryptSeed seed = new CryptSeed();
                strVal = seed.seedEncryptString(strKey, strIV, "CBC", "Y", strText);
                bResult = true;
                outErrMsg = "success";
            }
            catch (Exception ex)
            {
                bResult = false;
                outErrMsg = ex.ToString();
            }
            finally
            {
                outVal = strVal;
            }

            return bResult;
        }

        public bool SeedCBCPADDecrypt(string strKey, string strIV, string strEnc, out string outVal, out string outErrMsg)
        {
            bool bResult = false;
            string strVal = string.Empty;

            try
            {
                CryptSeed seed = new CryptSeed();
                strVal = seed.seedDecryptString(strKey, strIV, "CBC", "Y", strEnc);
                bResult = true;
                outErrMsg = "success";
            }
            catch (Exception ex)
            {
                bResult = false;
                outErrMsg = ex.ToString();
            }
            finally
            {
                outVal = strVal;
            }

            return bResult;
        }
    }
}
