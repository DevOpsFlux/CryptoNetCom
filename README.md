# CryptoNetCom Com+ 
SEED ECB/CBC MODE Encrypt/Decrypt Component

## 1. 프로젝트 정보 및 버젼

### *[ CryptoNetCom Solution ]	
### *[ CryptoNetCom.csproj ]	

| 프로젝트 | 설명 | .NET버젼 | AdoToFormats버젼 |
| -------- | -------- | -------- | -------- |
| CryptoNetCom | SEED Encrypt/Decrypt 1.0	| .NET 3.5	| CryptoNetCom 1.0.0.0 |

## 프로젝트 정보 및 버젼
- SEED 암/복호화 모듈 ECB/CBC MODE
> CryptoNetCom.dll 1.0.0.0
> System.EnterpriseServices

# 프로그램 환경 설정
* CryptoNetCom.dll 컴포넌트 등록

* CryptLib Class :
```
public bool SeedEncrypt(string strKey, string strText, out string outVal, out string outErrMsg)
public bool SeedDecrypt(string strKey, string strEnc, out string outVal, out string outErrMsg)
public bool SeedECBEncrypt(string strKey, string strIV, string strText, out string outVal, out string outErrMsg)
public bool SeedECBDecrypt(string strKey, string strIV, string strEnc, out string outVal, out string outErrMsg)
public bool SeedECBPADEncrypt(string strKey, string strIV, string strText, out string outVal, out string outErrMsg)
public bool SeedECBPADDecrypt(string strKey, string strIV, string strEnc, out string outVal, out string outErrMsg)
public bool SeedCBCEncrypt(string strKey, string strIV, string strText, out string outVal, out string outErrMsg)
public bool SeedCBCDecrypt(string strKey, string strIV, string strEnc, out string outVal, out string outErrMsg)
public bool SeedCBCPADEncrypt(string strKey, string strIV, string strText, out string outVal, out string outErrMsg)
public bool SeedCBCPADDecrypt(string strKey, string strIV, string strEnc, out string outVal, out string outErrMsg)
```

## 프로젝트 설정 및 사용 메뉴얼

- /Doc/CryptoNetCom모듈.xls

## 프로그램 사용 샘플
```
Option Explicit 

Call SeedCBCTest()

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

```
