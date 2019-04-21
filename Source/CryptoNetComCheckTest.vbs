Option Explicit 

'Call SeedTest()

Call SeedCBCTest()


Sub SeedTest()

	Dim objCom, retVal
	Dim SEEDKEY, SEEDIV, strText, strEnc, strDec
	Dim outVal, ErrMsg
	

	SEEDKEY = "DevOpsFlux150!@"
	strText = "Test0987SeedCBCTest"

	Set objCom = CreateObject("CryptoNetCom.CryptLib")
	retVal = objCom.SeedEncrypt(SEEDKEY, strText, outVal, ErrMsg)
	strEnc = outVal
	msgBox "seedEncrypt : " & strEnc & " ____ " & ErrMsg

	retVal = objCom.SeedDecrypt(SEEDKEY, strEnc, outVal, ErrMsg)
	strDec = outVal
	msgBox "SeedDecrypt : " & strDec & " ____ " & ErrMsg
	
	Set objCom = Nothing 
	
End Sub

Sub SeedCBCTest()

	Dim objCom, retVal
	Dim SEEDKEY, SEEDIV, strText, strEnc, strDec
	Dim outVal, ErrMsg
	Dim strMsgBox
	

	SEEDKEY = "DevOpsFlux1580!@"
	SEEDIV = "2019GoodLuck1234"
	strText = "Test0987SeedCBCTest"

	strMsgBox = "strText : " & strText & vbCrLf

	Set objCom = CreateObject("CryptoNetCom.CryptLib")
	retVal = objCom.SeedCBCPADEncrypt(SEEDKEY, SEEDIV, strText, outVal, ErrMsg)
	strEnc = outVal
	'strMsgBox = strMsgBox & "seedEncrypt : " & strEnc & " ____ " & ErrMsg  & vbCrLf
	strMsgBox = strMsgBox & "seedEncrypt : " & strEnc & vbCrLf

	retVal = objCom.SeedCBCPADDecrypt(SEEDKEY, SEEDIV, strEnc, outVal, ErrMsg)
	strDec = outVal
	strMsgBox = strMsgBox & "SeedDecrypt : " & strDec & vbCrLf
	msgBox strMsgBox
	
	Set objCom = Nothing 
	
End Sub


