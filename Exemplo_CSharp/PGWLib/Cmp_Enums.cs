﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGWLib
{
    public class Enums
    {
        


        //==========================================================================================
        //  Tipos de evento retornados pelo PIN-pad
        //==========================================================================================

        public enum E_PWPPEVT : int
        {
            PWPPEVT_MAGSTRIPE = 0x01, 
            PWPPEVT_ICC = 0x02, 
            PWPPEVT_CTLS = 0x03, 
            PWPPEVT_KEYCONF = 0x11, 
            PWPPEVT_KEYBACKSP = 0x12, 
            PWPPEVT_KEYCANC = 0x13, 
            PWPPEVT_KEYF1 = 0x21, 
            PWPPEVT_KEYF2 = 0x22, 
            PWPPEVT_KEYF3 = 0x23, 
            PWPPEVT_KEYF4 = 0x24 
        }

     	//=========================================================================================
		// Tipos de evento a serem ativados para monitoração no PIN-pad
		//==========================================================================================
	
        public enum E_PWPPEVTIN : int
        {
		   PWPPEVTIN_KEYS  =   1,   
		   PWPPEVTIN_MAG   =   2,   
		   PWPPEVTIN_ICC   =   4,   
		   PWPPEVTIN_CTLS  =   8    
        } 


       //==========================================================================================
       //  Tabela de Códigos de retorno das transações
       //==========================================================================================   
        public enum E_PWOPER : int
        {
		   PWOPER_NULL = 0,         
		   PWOPER_INSTALL = 1,      
		   PWOPER_PARAMUPD = 2,     
		   PWOPER_REPRINT = 16,     
		   PWOPER_RPTTRUNC = 17,    
		   PWOPER_RPTDETAIL = 18,   
		   PWOPER_ADMIN = 32,       
		   PWOPER_SALE = 33,        
		   PWOPER_SALEVOID = 34,    
		   PWOPER_PREPAID = 35,     
		   PWOPER_CHECKINQ = 36,    
		   PWOPER_RETBALINQ = 37,   
		   PWOPER_CRDBALINQ = 38,   
		   PWOPER_INITIALIZ = 39,   
		   PWOPER_SETTLEMNT = 40,   
		   PWOPER_PREAUTH = 41,     
		   PWOPER_PREAUTVOID = 42,  
		   PWOPER_CASHWDRWL = 43,   
		   PWOPER_LOCALMAINT = 44,  
		   PWOPER_FINANCINQ = 45,   
		   PWOPER_ADDRVERIF = 46,   
		   PWOPER_SALEPRE = 47,     
		   PWOPER_LOYCREDIT = 48,   
		   PWOPER_LOYCREDVOID = 49, 
		   PWOPER_LOYDEBIT = 50,    
		   PWOPER_LOYDEBVOID = 51,  
		   PWOPER_VOID = 57,        
		   PWOPER_VERSION = 252,    
		   PWOPER_CONFIG = 253,     
		   PWOPER_MAINTENANCE = 254 
        }

        public enum E_PWCardTypes : int
        {
            naoDefinido = 0,
            credito = 1,
            debito = 2,
            voucher = 4,
            outros = 8
        }

        public enum E_PWFinancingTypes : int
        {
            naoDefinido = 0,
            aVista = 1,
            parceladoEmissor = 2,
            parceladoEstabelecimento = 4,
            preDatado = 8
        }

        //==========================================================================================
        //    Códigos de Confirmação de Transação
        //==========================================================================================
        public enum E_PWCNF : int
        {
			PWCNF_CNF_AUTO	    = 289,     
			PWCNF_CNF_MANU_AUT	= 12833,   
			PWCNF_REV_MANU_AUT	= 12849,   
			PWCNF_REV_PRN_AUT	= 78129,   
			PWCNF_REV_DISP_AUT	= 143665,  
			PWCNF_REV_COMM_AUT	= 209201,  
			PWCNF_REV_ABORT	    = 274737,  
			PWCNF_REV_OTHER_AUT = 471345,  
			PWCNF_REV_PWR_AUT	= 536881,  
			PWCNF_REV_FISC_AUT	= 602417,  
			/////////////////////////
			PWCNF_REV_AUTO_ABORT = 262449, 
        }

		//==========================================================================================
		//   Tipos de dados que podem ser informados pela Automação
		//==========================================================================================
        public enum E_PWINFO : int
        {
            PWINFO_OPERATION = 2,     
		    PWINFO_POSID = 17,        
		    PWINFO_AUTNAME = 21,      
		    PWINFO_AUTVER = 22,       
		    PWINFO_AUTDEV = 23,       
		    PWINFO_DESTTCPIP = 27,    
		    PWINFO_MERCHCNPJCPF = 28, 
		    PWINFO_AUTCAP = 36,       
		    PWINFO_TOTAMNT = 37,      
		    PWINFO_CURRENCY = 38,     
		    PWINFO_CURREXP = 39,      
		    PWINFO_FISCALREF = 40,    
		    PWINFO_CARDTYPE = 41,     
		    PWINFO_PRODUCTNAME = 42,  
		    PWINFO_DATETIME = 49,     
		    PWINFO_REQNUM = 50,       
		    PWINFO_AUTHSYST = 53,     
		    PWINFO_VIRTMERCH = 54,    
		    PWINFO_AUTMERCHID = 56,   
		    PWINFO_PHONEFULLNO = 58,  
		    PWINFO_FINTYPE = 59,      
		    PWINFO_INSTALLMENTS = 60, 
		    PWINFO_INSTALLMDATE = 61, 
		    PWINFO_PRODUCTID = 62,    
		    PWINFO_RESULTMSG = 66,    
		    PWINFO_CNFREQ = 67,       
		    PWINFO_AUTLOCREF = 68,    
		    PWINFO_AUTEXTREF = 69,    
		    PWINFO_AUTHCODE = 70,     
		    PWINFO_AUTRESPCODE = 71,  
		    PWINFO_AUTDATETIME = 72,  
		    PWINFO_DISCOUNTAMT = 73,  
		    PWINFO_CASHBACKAMT = 74,  
		    PWINFO_CARDNAME = 75,     
		    PWINFO_ONOFF = 76,        
		    PWINFO_BOARDINGTAX = 77,  
		    PWINFO_TIPAMOUNT = 78,    
		    PWINFO_INSTALLM1AMT = 79, 
		    PWINFO_INSTALLMAMNT = 80, 
		    PWINFO_RCPTFULL = 82,     
		    PWINFO_RCPTMERCH = 83,    
		    PWINFO_RCPTCHOLDER = 84,  
		    PWINFO_RCPTCHSHORT = 85,  
		    PWINFO_TRNORIGDATE = 87,  
		    PWINFO_TRNORIGNSU = 88,  
		    PWINFO_SALDOVOUCHER = 89, 
		    PWINFO_TRNORIGAMNT = 96,  
		    PWINFO_TRNORIGAUTH = 98,  
		    PWINFO_LANGUAGE = 108,    
		    PWINFO_PROCESSMSG = 111,  
		    PWINFO_TRNORIGREQNUM = 114, 
		    PWINFO_TRNORIGTIME = 115,   
		    PWINFO_CNCDSPMSG = 116,     
		    PWINFO_CNCPPMSG = 117,      
		    PWINFO_CARDENTMODE = 192,   
		    PWINFO_CARDFULLPAN = 193,   
		    PWINFO_CARDEXPDATE = 194,   
		    PWINFO_CARDNAMESTD = 196,   
		    PWINFO_CARDPARCPAN = 200,   
		    PWINFO_CHOLDVERIF = 207,    
		    PWINFO_AID = 216,           
		    PWINFO_BARCODENTMODE = 233, 
		    PWINFO_BARCODE = 234,       
		    PWINFO_MERCHADDDATA1 = 240, 
		    PWINFO_MERCHADDDATA2 = 241, 
		    PWINFO_MERCHADDDATA3 = 242, 
		    PWINFO_MERCHADDDATA4 = 243, 
		    PWINFO_RCPTPRN = 244,       
		    PWINFO_AUTHMNGTUSER = 245,  
		    PWINFO_AUTHTECHUSER = 246,  
		    PWINFO_PAYMNTTYPE = 7969,   
		    PWINFO_USINGPINPAD = 32513, 
		    PWINFO_PPCOMMPORT = 32514,  
		    PWINFO_IDLEPROCTIME = 32516, 
		    PWINFO_PNDAUTHSYST = 32517,  
		    PWINFO_PNDVIRTMERCH = 32518, 
		    PWINFO_PNDREQNUM = 32519,    
		    PWINFO_PNDAUTLOCREF = 32520, 
		    PWINFO_PNDAUTEXTREF = 32521, 
		    PWINFO_LOCALINFO1 = 32522,   
		    PWINFO_SERVERPND = 32523,  
		    PWINFO_PPINFO = 0x7F15,     
		    PWINFO_DUEAMNT = 0xBF06,   
		    PWINFO_READJUSTEDAMNT = 0xBF09 

        }

        //===========================================================
        //  Tabela de Códigos de Erro de Retorno da Biblioteca
        //===========================================================
        public enum E_PWRET
        {
	       PWRET_OK = 0,                        
  		   PWRET_FROMHOSTPENDTRN = -2599,       
		   PWRET_FROMHOSTPOSAUTHERR = -2598,    
		   PWRET_FROMHOSTUSRAUTHERR = -2597,    
		   PWRET_FROMHOST = -2596,              
		   PWRET_TLVERR = -2595,                
		   PWRET_SRVINVPARAM = -2594,           
		   PWRET_REQPARAM = -2593,              
		   PWRET_HOSTCONNUNK = -2592,           
		   PWRET_INTERNALERR = -2591,           
		   PWRET_BLOCKED = -2590,               
		   PWRET_FROMHOSTTRNNFOUND = -2589,     
		   PWRET_PARAMSFILEERR = -2588,         
		   PWRET_NOCARDENTMODE = -2587,         
		   PWRET_INVALIDVIRTMERCH = -2586,      
		   PWRET_HOSTTIMEOUT = -2585,           
		   PWRET_CONFIGREQUIRED = -2584,        
		   PWRET_HOSTCONNERR = -2583,           
		   PWRET_HOSTCONNLOST = -2582,          
		   PWRET_FILEERR = -2581,               
		   PWRET_PINPADERR = -2580,             
		   PWRET_MAGSTRIPEERR = -2579,          
		   PWRET_PPCRYPTERR = -2578,            
		   PWRET_SSLCERTERR = -2577,            
		   PWRET_SSLNCONN = -2576,              
		   PWRET_GPRSATTACHFAILED = -2575,      
		   PWRET_INVPARAM = -2499,              
		   PWRET_NOTINST = -2498,               
		   PWRET_MOREDATA = -2497,              
		   PWRET_NODATA = -2496,                
		   PWRET_DISPLAY = -2495,               
		   PWRET_INVCALL = -2494,               
		   PWRET_NOTHING = -2493,               
		   PWRET_BUFOVFLW = -2492,              
		   PWRET_CANCEL = -2491,                
		   PWRET_TIMEOUT = -2490,               
		   PWRET_PPNOTFOUND = -2489,            
		   PWRET_TRNNOTINIT = -2488,            
		   PWRET_DLLNOTINIT = -2487,            
		   PWRET_FALLBACK = -2486,              
		   PWRET_WRITERR = -2485,               
		   PWRET_PPCOMERR = -2484,              
		   PWRET_NOMANDATORY = -2483,           
		   PWRET_INVALIDTRN = -2482,            
		   PWRET_PPS_XXX = -2200,               
           // Erros específicos da biblioteca compartilhada de PIN-pad
           PWRET_PPS_MAX  =    -2100,
           PWRET_PPS_MIN  =    PWRET_PPS_MAX - 100        

        }

        public enum E_PWDAT
        {
   	       PWDAT_MENU         = 1,   
    	   PWDAT_TYPED        = 2,   
    	   PWDAT_CARDINF      = 3,   
    	   PWDAT_PPENTRY      = 5,   
    	   PWDAT_PPENCPIN     = 6,   
    	   PWDAT_CARDOFF      = 9,   
    	   PWDAT_CARDONL      = 10,  
    	   PWDAT_PPCONF       = 11,  
    	   PWDAT_BARCODE	  = 12,  
    	   PWDAT_PPREMCRD     = 13,  
    	   PWDAT_PPGENCMD     = 14,  
    	   PWDAT_PPDATAPOSCNF = 16,  
    	   PWDAT_USERAUTH     = 17,  
        }

        public enum E_PWUserDataMessages: int
        {

            DIGITE_O_DDD                     = 1,
            REDIGITE_O_DDD                   = 2,
            DIGITE_O_TELEFONE                = 3,
            REDIGITE_O_TELEFONE              = 4,
            DIGITE_DDD_TELEFONE              = 5,
            REDIGITE_DDD_TELEFONE            = 6,
            DIGITE_O_CPF                     = 7,
            REDIGITE_O_CPF                   = 8,
            DIGITE_O_RG                      = 9,
            REDIGITE_O_RG                    = 10,
            DIGITE_OS_4_ULTIMOS_DIGITOS      = 11,
            DIGITE_CODIGO_DE_SEGURANCA       = 12

        }
    }
}
