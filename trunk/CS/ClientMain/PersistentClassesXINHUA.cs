
using System;
using DevExpress.Xpo;
namespace XINHUA
{
    public class VIEW_JT_J_DWXX : XPLiteObject
    {
        string fDWSXMC;
        [Size(80)]
        public string DWSXMC
        {
            get { return fDWSXMC; }
            set { SetPropertyValue<string>("DWSXMC", ref fDWSXMC, value); }
        }
        string fGYSLXMC;
        [Size(80)]
        public string GYSLXMC
        {
            get { return fGYSLXMC; }
            set { SetPropertyValue<string>("GYSLXMC", ref fGYSLXMC, value); }
        }
        string fKHLXMC;
        [Size(80)]
        public string KHLXMC
        {
            get { return fKHLXMC; }
            set { SetPropertyValue<string>("KHLXMC", ref fKHLXMC, value); }
        }
        string fCBSLXMC;
        [Size(80)]
        public string CBSLXMC
        {
            get { return fCBSLXMC; }
            set { SetPropertyValue<string>("CBSLXMC", ref fCBSLXMC, value); }
        }
        string fSFID;
        [Size(16)]
        public string SFID
        {
            get { return fSFID; }
            set { SetPropertyValue<string>("SFID", ref fSFID, value); }
        }
        string fDQID;
        [Size(16)]
        public string DQID
        {
            get { return fDQID; }
            set { SetPropertyValue<string>("DQID", ref fDQID, value); }
        }
        string fYZBM;
        [Size(20)]
        public string YZBM
        {
            get { return fYZBM; }
            set { SetPropertyValue<string>("YZBM", ref fYZBM, value); }
        }
        string fTXDZ;
        public string TXDZ
        {
            get { return fTXDZ; }
            set { SetPropertyValue<string>("TXDZ", ref fTXDZ, value); }
        }
        string fDH;
        [Size(40)]
        public string DH
        {
            get { return fDH; }
            set { SetPropertyValue<string>("DH", ref fDH, value); }
        }
        string fCZ;
        [Size(40)]
        public string CZ
        {
            get { return fCZ; }
            set { SetPropertyValue<string>("CZ", ref fCZ, value); }
        }
        string fLXR;
        [Size(20)]
        public string LXR
        {
            get { return fLXR; }
            set { SetPropertyValue<string>("LXR", ref fLXR, value); }
        }
        string fKHYH;
        public string KHYH
        {
            get { return fKHYH; }
            set { SetPropertyValue<string>("KHYH", ref fKHYH, value); }
        }
        string fZH;
        public string ZH
        {
            get { return fZH; }
            set { SetPropertyValue<string>("ZH", ref fZH, value); }
        }
        string fSH;
        public string SH
        {
            get { return fSH; }
            set { SetPropertyValue<string>("SH", ref fSH, value); }
        }
        string fEMAIL;
        public string EMAIL
        {
            get { return fEMAIL; }
            set { SetPropertyValue<string>("EMAIL", ref fEMAIL, value); }
        }
        string fWZ;
        public string WZ
        {
            get { return fWZ; }
            set { SetPropertyValue<string>("WZ", ref fWZ, value); }
        }
        string fJSFSID;
        [Size(16)]
        public string JSFSID
        {
            get { return fJSFSID; }
            set { SetPropertyValue<string>("JSFSID", ref fJSFSID, value); }
        }
        decimal fTSSX;
        public decimal TSSX
        {
            get { return fTSSX; }
            set { SetPropertyValue<decimal>("TSSX", ref fTSSX, value); }
        }
        decimal fTSXX;
        public decimal TSXX
        {
            get { return fTSXX; }
            set { SetPropertyValue<decimal>("TSXX", ref fTSXX, value); }
        }
        decimal fSDSX;
        public decimal SDSX
        {
            get { return fSDSX; }
            set { SetPropertyValue<decimal>("SDSX", ref fSDSX, value); }
        }
        decimal fSDXX;
        public decimal SDXX
        {
            get { return fSDXX; }
            set { SetPropertyValue<decimal>("SDXX", ref fSDXX, value); }
        }
        decimal fZKSX;
        public decimal ZKSX
        {
            get { return fZKSX; }
            set { SetPropertyValue<decimal>("ZKSX", ref fZKSX, value); }
        }
        decimal fZKXX;
        public decimal ZKXX
        {
            get { return fZKXX; }
            set { SetPropertyValue<decimal>("ZKXX", ref fZKXX, value); }
        }
        string fJSDWID;
        [Size(16)]
        public string JSDWID
        {
            get { return fJSDWID; }
            set { SetPropertyValue<string>("JSDWID", ref fJSDWID, value); }
        }
        string fDJSDBZ;
        [Size(5)]
        public string DJSDBZ
        {
            get { return fDJSDBZ; }
            set { SetPropertyValue<string>("DJSDBZ", ref fDJSDBZ, value); }
        }
        string fTSJSDBZ;
        [Size(5)]
        public string TSJSDBZ
        {
            get { return fTSJSDBZ; }
            set { SetPropertyValue<string>("TSJSDBZ", ref fTSJSDBZ, value); }
        }
        decimal fKHZZYFBZ;
        public decimal KHZZYFBZ
        {
            get { return fKHZZYFBZ; }
            set { SetPropertyValue<decimal>("KHZZYFBZ", ref fKHZZYFBZ, value); }
        }
        decimal fKHZZBZFBZ;
        public decimal KHZZBZFBZ
        {
            get { return fKHZZBZFBZ; }
            set { SetPropertyValue<decimal>("KHZZBZFBZ", ref fKHZZBZFBZ, value); }
        }
        decimal fKHZZQTFYBZ;
        public decimal KHZZQTFYBZ
        {
            get { return fKHZZQTFYBZ; }
            set { SetPropertyValue<decimal>("KHZZQTFYBZ", ref fKHZZQTFYBZ, value); }
        }
        long fCGJSZQ;
        public long CGJSZQ
        {
            get { return fCGJSZQ; }
            set { SetPropertyValue<long>("CGJSZQ", ref fCGJSZQ, value); }
        }
        long fTSJSZQ;
        public long TSJSZQ
        {
            get { return fTSJSZQ; }
            set { SetPropertyValue<long>("TSJSZQ", ref fTSJSZQ, value); }
        }
        string fSHDZ;
        public string SHDZ
        {
            get { return fSHDZ; }
            set { SetPropertyValue<string>("SHDZ", ref fSHDZ, value); }
        }
        string fKJDZ;
        public string KJDZ
        {
            get { return fKJDZ; }
            set { SetPropertyValue<string>("KJDZ", ref fKJDZ, value); }
        }
        string fMJDZ;
        public string MJDZ
        {
            get { return fMJDZ; }
            set { SetPropertyValue<string>("MJDZ", ref fMJDZ, value); }
        }
        string fYSFSID;
        [Size(16)]
        public string YSFSID
        {
            get { return fYSFSID; }
            set { SetPropertyValue<string>("YSFSID", ref fYSFSID, value); }
        }
        string fYSFXID;
        [Size(16)]
        public string YSFXID
        {
            get { return fYSFXID; }
            set { SetPropertyValue<string>("YSFXID", ref fYSFXID, value); }
        }
        string fZZDBZ;
        [Size(5)]
        public string ZZDBZ
        {
            get { return fZZDBZ; }
            set { SetPropertyValue<string>("ZZDBZ", ref fZZDBZ, value); }
        }
        string fYZDBH;
        [Size(16)]
        public string YZDBH
        {
            get { return fYZDBH; }
            set { SetPropertyValue<string>("YZDBH", ref fYZDBH, value); }
        }
        string fEZDBH;
        [Size(16)]
        public string EZDBH
        {
            get { return fEZDBH; }
            set { SetPropertyValue<string>("EZDBH", ref fEZDBH, value); }
        }
        string fKFDZ;
        public string KFDZ
        {
            get { return fKFDZ; }
            set { SetPropertyValue<string>("KFDZ", ref fKFDZ, value); }
        }
        long fTDYZS;
        public long TDYZS
        {
            get { return fTDYZS; }
            set { SetPropertyValue<long>("TDYZS", ref fTDYZS, value); }
        }
        string fDWTJBH;
        public string DWTJBH
        {
            get { return fDWTJBH; }
            set { SetPropertyValue<string>("DWTJBH", ref fDWTJBH, value); }
        }
        short fCGJSYXJB;
        public short CGJSYXJB
        {
            get { return fCGJSYXJB; }
            set { SetPropertyValue<short>("CGJSYXJB", ref fCGJSYXJB, value); }
        }
        short fXSJSYXJB;
        public short XSJSYXJB
        {
            get { return fXSJSYXJB; }
            set { SetPropertyValue<short>("XSJSYXJB", ref fXSJSYXJB, value); }
        }
        short fPHYXJB;
        public short PHYXJB
        {
            get { return fPHYXJB; }
            set { SetPropertyValue<short>("PHYXJB", ref fPHYXJB, value); }
        }
        short fXTYXJB;
        public short XTYXJB
        {
            get { return fXTYXJB; }
            set { SetPropertyValue<short>("XTYXJB", ref fXTYXJB, value); }
        }
        short fJTYXJB;
        public short JTYXJB
        {
            get { return fJTYXJB; }
            set { SetPropertyValue<short>("JTYXJB", ref fJTYXJB, value); }
        }
        short fCGYXJB;
        public short CGYXJB
        {
            get { return fCGYXJB; }
            set { SetPropertyValue<short>("CGYXJB", ref fCGYXJB, value); }
        }
        string fWEBYH;
        [Size(20)]
        public string WEBYH
        {
            get { return fWEBYH; }
            set { SetPropertyValue<string>("WEBYH", ref fWEBYH, value); }
        }
        string fWEBMM;
        [Size(16)]
        public string WEBMM
        {
            get { return fWEBMM; }
            set { SetPropertyValue<string>("WEBMM", ref fWEBMM, value); }
        }
        string fZT;
        [Size(4)]
        public string ZT
        {
            get { return fZT; }
            set { SetPropertyValue<string>("ZT", ref fZT, value); }
        }
        string fCJR;
        [Size(10)]
        public string CJR
        {
            get { return fCJR; }
            set { SetPropertyValue<string>("CJR", ref fCJR, value); }
        }
        string fTYR;
        [Size(10)]
        public string TYR
        {
            get { return fTYR; }
            set { SetPropertyValue<string>("TYR", ref fTYR, value); }
        }
        DateTime fCZRQ;
        public DateTime CZRQ
        {
            get { return fCZRQ; }
            set { SetPropertyValue<DateTime>("CZRQ", ref fCZRQ, value); }
        }
        string fBZ;
        public string BZ
        {
            get { return fBZ; }
            set { SetPropertyValue<string>("BZ", ref fBZ, value); }
        }
        string fSFZT;
        [Size(5)]
        public string SFZT
        {
            get { return fSFZT; }
            set { SetPropertyValue<string>("SFZT", ref fSFZT, value); }
        }
        string fCWXTID;
        [Size(16)]
        public string CWXTID
        {
            get { return fCWXTID; }
            set { SetPropertyValue<string>("CWXTID", ref fCWXTID, value); }
        }
        string fDWID;
        [Key]
        [Size(16)]
        public string DWID
        {
            get { return fDWID; }
            set { SetPropertyValue<string>("DWID", ref fDWID, value); }
        }
        string fDWBH;
        [Size(16)]
        public string DWBH
        {
            get { return fDWBH; }
            set { SetPropertyValue<string>("DWBH", ref fDWBH, value); }
        }
        string fDWMC;
        public string DWMC
        {
            get { return fDWMC; }
            set { SetPropertyValue<string>("DWMC", ref fDWMC, value); }
        }
        string fDWJC;
        [Size(20)]
        public string DWJC
        {
            get { return fDWJC; }
            set { SetPropertyValue<string>("DWJC", ref fDWJC, value); }
        }
        string fZJM;
        [Size(10)]
        public string ZJM
        {
            get { return fZJM; }
            set { SetPropertyValue<string>("ZJM", ref fZJM, value); }
        }
        string fSJDWID;
        [Size(16)]
        public string SJDWID
        {
            get { return fSJDWID; }
            set { SetPropertyValue<string>("SJDWID", ref fSJDWID, value); }
        }
        string fDWSX;
        [Size(5)]
        public string DWSX
        {
            get { return fDWSX; }
            set { SetPropertyValue<string>("DWSX", ref fDWSX, value); }
        }
        string fBMLXID;
        [Size(16)]
        public string BMLXID
        {
            get { return fBMLXID; }
            set { SetPropertyValue<string>("BMLXID", ref fBMLXID, value); }
        }
        string fGYSLXID;
        [Size(16)]
        public string GYSLXID
        {
            get { return fGYSLXID; }
            set { SetPropertyValue<string>("GYSLXID", ref fGYSLXID, value); }
        }
        string fKHLXID;
        [Size(16)]
        public string KHLXID
        {
            get { return fKHLXID; }
            set { SetPropertyValue<string>("KHLXID", ref fKHLXID, value); }
        }
        string fKFLXID;
        [Size(16)]
        public string KFLXID
        {
            get { return fKFLXID; }
            set { SetPropertyValue<string>("KFLXID", ref fKFLXID, value); }
        }
        string fYINSDWLXID;
        [Size(16)]
        public string YINSDWLXID
        {
            get { return fYINSDWLXID; }
            set { SetPropertyValue<string>("YINSDWLXID", ref fYINSDWLXID, value); }
        }
        string fCBSLXID;
        [Size(16)]
        public string CBSLXID
        {
            get { return fCBSLXID; }
            set { SetPropertyValue<string>("CBSLXID", ref fCBSLXID, value); }
        }
        string fYSDWLXID;
        [Size(16)]
        public string YSDWLXID
        {
            get { return fYSDWLXID; }
            set { SetPropertyValue<string>("YSDWLXID", ref fYSDWLXID, value); }
        }
        string fBMZTID;
        [Size(16)]
        public string BMZTID
        {
            get { return fBMZTID; }
            set { SetPropertyValue<string>("BMZTID", ref fBMZTID, value); }
        }
        string fGZLID;
        [Size(16)]
        public string GZLID
        {
            get { return fGZLID; }
            set { SetPropertyValue<string>("GZLID", ref fGZLID, value); }
        }
        short fDWJB;
        public short DWJB
        {
            get { return fDWJB; }
            set { SetPropertyValue<short>("DWJB", ref fDWJB, value); }
        }
        string fDWFR;
        [Size(10)]
        public string DWFR
        {
            get { return fDWFR; }
            set { SetPropertyValue<string>("DWFR", ref fDWFR, value); }
        }
        public VIEW_JT_J_DWXX(Session session) : base(session) { }
        public VIEW_JT_J_DWXX() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class JT_J_ZTBM : XPLiteObject
    {
        string fZTID;
        [Key]
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }
        string fZTBH;
        [Size(16)]
        public string ZTBH
        {
            get { return fZTBH; }
            set { SetPropertyValue<string>("ZTBH", ref fZTBH, value); }
        }
        string fZTMC;
        [Size(40)]
        public string ZTMC
        {
            get { return fZTMC; }
            set { SetPropertyValue<string>("ZTMC", ref fZTMC, value); }
        }
        string fZTPY;
        [Size(20)]
        public string ZTPY
        {
            get { return fZTPY; }
            set { SetPropertyValue<string>("ZTPY", ref fZTPY, value); }
        }
        string fBZ;
        public string BZ
        {
            get { return fBZ; }
            set { SetPropertyValue<string>("BZ", ref fBZ, value); }
        }
        string fFLAG;
        [Size(4)]
        public string FLAG
        {
            get { return fFLAG; }
            set { SetPropertyValue<string>("FLAG", ref fFLAG, value); }
        }
        string fZT;
        [Size(4)]
        public string ZT
        {
            get { return fZT; }
            set { SetPropertyValue<string>("ZT", ref fZT, value); }
        }
        string fCJR;
        [Size(10)]
        public string CJR
        {
            get { return fCJR; }
            set { SetPropertyValue<string>("CJR", ref fCJR, value); }
        }
        string fTYR;
        [Size(10)]
        public string TYR
        {
            get { return fTYR; }
            set { SetPropertyValue<string>("TYR", ref fTYR, value); }
        }
        DateTime fCZRQ;
        public DateTime CZRQ
        {
            get { return fCZRQ; }
            set { SetPropertyValue<DateTime>("CZRQ", ref fCZRQ, value); }
        }
        string fDWID;
        [Size(16)]
        public string DWID
        {
            get { return fDWID; }
            set { SetPropertyValue<string>("DWID", ref fDWID, value); }
        }
        string fCOMPANY;
        [Size(16)]
        public string COMPANY
        {
            get { return fCOMPANY; }
            set { SetPropertyValue<string>("COMPANY", ref fCOMPANY, value); }
        }
        string fCOMPANYNAME;
        public string COMPANYNAME
        {
            get { return fCOMPANYNAME; }
            set { SetPropertyValue<string>("COMPANYNAME", ref fCOMPANYNAME, value); }
        }
        public JT_J_ZTBM(Session session) : base(session) { }
        public JT_J_ZTBM() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class VIEW_BASE_OPERATOR : XPLiteObject
    {
        string fOPERATORID;
        [Key]
        [Size(16)]
        public string OPERATORID
        {
            get { return fOPERATORID; }
            set { SetPropertyValue<string>("OPERATORID", ref fOPERATORID, value); }
        }
        string fOPERATORNO;
        [Size(10)]
        public string OPERATORNO
        {
            get { return fOPERATORNO; }
            set { SetPropertyValue<string>("OPERATORNO", ref fOPERATORNO, value); }
        }
        string fOPERATORNAME;
        [Size(16)]
        public string OPERATORNAME
        {
            get { return fOPERATORNAME; }
            set { SetPropertyValue<string>("OPERATORNAME", ref fOPERATORNAME, value); }
        }
        string fFASTCODE;
        [Size(10)]
        public string FASTCODE
        {
            get { return fFASTCODE; }
            set { SetPropertyValue<string>("FASTCODE", ref fFASTCODE, value); }
        }
        string fSEX;
        [Size(2)]
        public string SEX
        {
            get { return fSEX; }
            set { SetPropertyValue<string>("SEX", ref fSEX, value); }
        }
        DateTime fBIRTHDAY;
        public DateTime BIRTHDAY
        {
            get { return fBIRTHDAY; }
            set { SetPropertyValue<DateTime>("BIRTHDAY", ref fBIRTHDAY, value); }
        }
        string fEMAIL;
        [Size(50)]
        public string EMAIL
        {
            get { return fEMAIL; }
            set { SetPropertyValue<string>("EMAIL", ref fEMAIL, value); }
        }
        string fCONTACTADDRESS;
        public string CONTACTADDRESS
        {
            get { return fCONTACTADDRESS; }
            set { SetPropertyValue<string>("CONTACTADDRESS", ref fCONTACTADDRESS, value); }
        }
        string fTELEPHONE;
        [Size(15)]
        public string TELEPHONE
        {
            get { return fTELEPHONE; }
            set { SetPropertyValue<string>("TELEPHONE", ref fTELEPHONE, value); }
        }
        string fMOBILETELEPHONE;
        [Size(15)]
        public string MOBILETELEPHONE
        {
            get { return fMOBILETELEPHONE; }
            set { SetPropertyValue<string>("MOBILETELEPHONE", ref fMOBILETELEPHONE, value); }
        }
        string fDEPARTID;
        [Size(16)]
        public string DEPARTID
        {
            get { return fDEPARTID; }
            set { SetPropertyValue<string>("DEPARTID", ref fDEPARTID, value); }
        }
        string fBMMC;
        [Size(100)]
        public string BMMC
        {
            get { return fBMMC; }
            set { SetPropertyValue<string>("BMMC", ref fBMMC, value); }
        }
        public VIEW_BASE_OPERATOR(Session session) : base(session) { }
        public VIEW_BASE_OPERATOR() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class SYS_EMPLOYEES : XPLiteObject
    {
        string fEMPLOYEEID;
        [Key]
        [Size(16)]
        public string EMPLOYEEID
        {
            get { return fEMPLOYEEID; }
            set { SetPropertyValue<string>("EMPLOYEEID", ref fEMPLOYEEID, value); }
        }
        string fEMPLOYEENO;
        [Size(10)]
        public string EMPLOYEENO
        {
            get { return fEMPLOYEENO; }
            set { SetPropertyValue<string>("EMPLOYEENO", ref fEMPLOYEENO, value); }
        }
        string fNAME;
        [Size(16)]
        public string NAME
        {
            get { return fNAME; }
            set { SetPropertyValue<string>("NAME", ref fNAME, value); }
        }
        string fFASTCODE;
        [Size(10)]
        public string FASTCODE
        {
            get { return fFASTCODE; }
            set { SetPropertyValue<string>("FASTCODE", ref fFASTCODE, value); }
        }
        string fSEX;
        [Size(2)]
        public string SEX
        {
            get { return fSEX; }
            set { SetPropertyValue<string>("SEX", ref fSEX, value); }
        }
        DateTime fBIRTHDAY;
        public DateTime BIRTHDAY
        {
            get { return fBIRTHDAY; }
            set { SetPropertyValue<DateTime>("BIRTHDAY", ref fBIRTHDAY, value); }
        }
        string fEMAIL;
        [Size(50)]
        public string EMAIL
        {
            get { return fEMAIL; }
            set { SetPropertyValue<string>("EMAIL", ref fEMAIL, value); }
        }
        string fTXDZ;
        public string TXDZ
        {
            get { return fTXDZ; }
            set { SetPropertyValue<string>("TXDZ", ref fTXDZ, value); }
        }
        string fTELEPHONE;
        [Size(15)]
        public string TELEPHONE
        {
            get { return fTELEPHONE; }
            set { SetPropertyValue<string>("TELEPHONE", ref fTELEPHONE, value); }
        }
        string fMOBILETELEPHONE;
        [Size(15)]
        public string MOBILETELEPHONE
        {
            get { return fMOBILETELEPHONE; }
            set { SetPropertyValue<string>("MOBILETELEPHONE", ref fMOBILETELEPHONE, value); }
        }
        string fSJDWID;
        [Size(16)]
        public string SJDWID
        {
            get { return fSJDWID; }
            set { SetPropertyValue<string>("SJDWID", ref fSJDWID, value); }
        }
        string fJCJCNO;
        [Size(16)]
        public string JCJCNO
        {
            get { return fJCJCNO; }
            set { SetPropertyValue<string>("JCJCNO", ref fJCJCNO, value); }
        }
        string fKHDNO;
        [Size(16)]
        public string KHDNO
        {
            get { return fKHDNO; }
            set { SetPropertyValue<string>("KHDNO", ref fKHDNO, value); }
        }
        public SYS_EMPLOYEES(Session session) : base(session) { }
        public SYS_EMPLOYEES() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class VIEW_SYS_DEPARTMENT : XPLiteObject
    {
        string fDWJC;
        public string DWJC
        {
            get { return fDWJC; }
            set { SetPropertyValue<string>("DWJC", ref fDWJC, value); }
        }
        string fKHYH;
        public string KHYH
        {
            get { return fKHYH; }
            set { SetPropertyValue<string>("KHYH", ref fKHYH, value); }
        }
        string fSH;
        public string SH
        {
            get { return fSH; }
            set { SetPropertyValue<string>("SH", ref fSH, value); }
        }
        string fZH;
        public string ZH
        {
            get { return fZH; }
            set { SetPropertyValue<string>("ZH", ref fZH, value); }
        }
        string fDEPARTMENTID;
        [Key]
        [Size(16)]
        public string DEPARTMENTID
        {
            get { return fDEPARTMENTID; }
            set { SetPropertyValue<string>("DEPARTMENTID", ref fDEPARTMENTID, value); }
        }
        string fDEPARTMENTNAME;
        [Size(64)]
        public string DEPARTMENTNAME
        {
            get { return fDEPARTMENTNAME; }
            set { SetPropertyValue<string>("DEPARTMENTNAME", ref fDEPARTMENTNAME, value); }
        }
        string fDESCRIPTION;
        [Size(120)]
        public string DESCRIPTION
        {
            get { return fDESCRIPTION; }
            set { SetPropertyValue<string>("DESCRIPTION", ref fDESCRIPTION, value); }
        }
        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }
        string fZTMC;
        [Size(100)]
        public string ZTMC
        {
            get { return fZTMC; }
            set { SetPropertyValue<string>("ZTMC", ref fZTMC, value); }
        }
        string fDH;
        [Size(36)]
        public string DH
        {
            get { return fDH; }
            set { SetPropertyValue<string>("DH", ref fDH, value); }
        }
        string fZJM;
        [Size(100)]
        public string ZJM
        {
            get { return fZJM; }
            set { SetPropertyValue<string>("ZJM", ref fZJM, value); }
        }
        string fDEPARTMENTNO;
        [Size(16)]
        public string DEPARTMENTNO
        {
            get { return fDEPARTMENTNO; }
            set { SetPropertyValue<string>("DEPARTMENTNO", ref fDEPARTMENTNO, value); }
        }
        string fSFZT;
        [Size(2)]
        public string SFZT
        {
            get { return fSFZT; }
            set { SetPropertyValue<string>("SFZT", ref fSFZT, value); }
        }
        string fSJDWID;
        [Size(16)]
        public string SJDWID
        {
            get { return fSJDWID; }
            set { SetPropertyValue<string>("SJDWID", ref fSJDWID, value); }
        }
        string fDWSX;
        [Size(5)]
        public string DWSX
        {
            get { return fDWSX; }
            set { SetPropertyValue<string>("DWSX", ref fDWSX, value); }
        }
        string fBMLXID;
        [Size(16)]
        public string BMLXID
        {
            get { return fBMLXID; }
            set { SetPropertyValue<string>("BMLXID", ref fBMLXID, value); }
        }
        string fKHLXID;
        [Size(16)]
        public string KHLXID
        {
            get { return fKHLXID; }
            set { SetPropertyValue<string>("KHLXID", ref fKHLXID, value); }
        }
        string fKFLXID;
        [Size(16)]
        public string KFLXID
        {
            get { return fKFLXID; }
            set { SetPropertyValue<string>("KFLXID", ref fKFLXID, value); }
        }
        string fGYSLXID;
        [Size(16)]
        public string GYSLXID
        {
            get { return fGYSLXID; }
            set { SetPropertyValue<string>("GYSLXID", ref fGYSLXID, value); }
        }
        string fCBSLXID;
        [Size(16)]
        public string CBSLXID
        {
            get { return fCBSLXID; }
            set { SetPropertyValue<string>("CBSLXID", ref fCBSLXID, value); }
        }
        string fYSCLXID;
        [Size(16)]
        public string YSCLXID
        {
            get { return fYSCLXID; }
            set { SetPropertyValue<string>("YSCLXID", ref fYSCLXID, value); }
        }
        string fYSBMLXID;
        [Size(16)]
        public string YSBMLXID
        {
            get { return fYSBMLXID; }
            set { SetPropertyValue<string>("YSBMLXID", ref fYSBMLXID, value); }
        }
        string fKHDNO;
        [Size(16)]
        public string KHDNO
        {
            get { return fKHDNO; }
            set { SetPropertyValue<string>("KHDNO", ref fKHDNO, value); }
        }
        string fJCJCNO;
        [Size(16)]
        public string JCJCNO
        {
            get { return fJCJCNO; }
            set { SetPropertyValue<string>("JCJCNO", ref fJCJCNO, value); }
        }
        string fYTHNO;
        [Size(16)]
        public string YTHNO
        {
            get { return fYTHNO; }
            set { SetPropertyValue<string>("YTHNO", ref fYTHNO, value); }
        }
        public VIEW_SYS_DEPARTMENT(Session session) : base(session) { }
        public VIEW_SYS_DEPARTMENT() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class VIEW_JC_C_CGTSDMX : XPLiteObject
    {
        string fCGTSDMXID;
        [Key]
        [Size(16)]
        public string CGTSDMXID
        {
            get { return fCGTSDMXID; }
            set { SetPropertyValue<string>("CGTSDMXID", ref fCGTSDMXID, value); }
        }
        string fCGTSDID;
        [Size(16)]
        public string CGTSDID
        {
            get { return fCGTSDID; }
            set { SetPropertyValue<string>("CGTSDID", ref fCGTSDID, value); }
        }
        string fCGTSDH;
        [Size(22)]
        public string CGTSDH
        {
            get { return fCGTSDH; }
            set { SetPropertyValue<string>("CGTSDH", ref fCGTSDH, value); }
        }
        string fCGJSDID;
        [Size(16)]
        public string CGJSDID
        {
            get { return fCGJSDID; }
            set { SetPropertyValue<string>("CGJSDID", ref fCGJSDID, value); }
        }
        long fSL;
        public long SL
        {
            get { return fSL; }
            set { SetPropertyValue<long>("SL", ref fSL, value); }
        }
        decimal fWSJE;
        public decimal WSJE
        {
            get { return fWSJE; }
            set { SetPropertyValue<decimal>("WSJE", ref fWSJE, value); }
        }
        decimal fSE;
        public decimal SE
        {
            get { return fSE; }
            set { SetPropertyValue<decimal>("SE", ref fSE, value); }
        }
        decimal fJSHJ;
        public decimal JSHJ
        {
            get { return fJSHJ; }
            set { SetPropertyValue<decimal>("JSHJ", ref fJSHJ, value); }
        }
        string fBZ;
        public string BZ
        {
            get { return fBZ; }
            set { SetPropertyValue<string>("BZ", ref fBZ, value); }
        }
        string fCGJSDH;
        [Size(22)]
        public string CGJSDH
        {
            get { return fCGJSDH; }
            set { SetPropertyValue<string>("CGJSDH", ref fCGJSDH, value); }
        }
        long fSHL;
        public long SHL
        {
            get { return fSHL; }
            set { SetPropertyValue<long>("SHL", ref fSHL, value); }
        }
        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }
        public VIEW_JC_C_CGTSDMX(Session session) : base(session) { }
        public VIEW_JC_C_CGTSDMX() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class VIEW_JC_C_CGTSD : XPLiteObject
    {
        string fSTATUSMC;
        [Size(16)]
        public string STATUSMC
        {
            get { return fSTATUSMC; }
            set { SetPropertyValue<string>("STATUSMC", ref fSTATUSMC, value); }
        }
        string fCGTSDID;
        [Key]
        [Size(16)]
        public string CGTSDID
        {
            get { return fCGTSDID; }
            set { SetPropertyValue<string>("CGTSDID", ref fCGTSDID, value); }
        }
        string fCGTSDH;
        [Size(22)]
        public string CGTSDH
        {
            get { return fCGTSDH; }
            set { SetPropertyValue<string>("CGTSDH", ref fCGTSDH, value); }
        }
        string fYWBMID;
        [Size(16)]
        public string YWBMID
        {
            get { return fYWBMID; }
            set { SetPropertyValue<string>("YWBMID", ref fYWBMID, value); }
        }
        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }
        string fGYSID;
        [Size(16)]
        public string GYSID
        {
            get { return fGYSID; }
            set { SetPropertyValue<string>("GYSID", ref fGYSID, value); }
        }
        decimal fTSJE;
        public decimal TSJE
        {
            get { return fTSJE; }
            set { SetPropertyValue<decimal>("TSJE", ref fTSJE, value); }
        }
        string fGYSMC;
        [Size(80)]
        public string GYSMC
        {
            get { return fGYSMC; }
            set { SetPropertyValue<string>("GYSMC", ref fGYSMC, value); }
        }
        string fKXNRID;
        [Size(16)]
        public string KXNRID
        {
            get { return fKXNRID; }
            set { SetPropertyValue<string>("KXNRID", ref fKXNRID, value); }
        }
        string fTSPJMCID;
        [Size(16)]
        public string TSPJMCID
        {
            get { return fTSPJMCID; }
            set { SetPropertyValue<string>("TSPJMCID", ref fTSPJMCID, value); }
        }
        string fSPFYQKID;
        [Size(16)]
        public string SPFYQKID
        {
            get { return fSPFYQKID; }
            set { SetPropertyValue<string>("SPFYQKID", ref fSPFYQKID, value); }
        }
        string fXSHTID;
        [Size(16)]
        public string XSHTID
        {
            get { return fXSHTID; }
            set { SetPropertyValue<string>("XSHTID", ref fXSHTID, value); }
        }
        string fZDRXM;
        [Size(16)]
        public string ZDRXM
        {
            get { return fZDRXM; }
            set { SetPropertyValue<string>("ZDRXM", ref fZDRXM, value); }
        }
        string fZDRID;
        [Size(16)]
        public string ZDRID
        {
            get { return fZDRID; }
            set { SetPropertyValue<string>("ZDRID", ref fZDRID, value); }
        }
        DateTime fZDRQ;
        public DateTime ZDRQ
        {
            get { return fZDRQ; }
            set { SetPropertyValue<DateTime>("ZDRQ", ref fZDRQ, value); }
        }
        string fCZYID;
        [Size(16)]
        public string CZYID
        {
            get { return fCZYID; }
            set { SetPropertyValue<string>("CZYID", ref fCZYID, value); }
        }
        DateTime fCZRQ;
        public DateTime CZRQ
        {
            get { return fCZRQ; }
            set { SetPropertyValue<DateTime>("CZRQ", ref fCZRQ, value); }
        }
        string fZT;
        [Size(4)]
        public string ZT
        {
            get { return fZT; }
            set { SetPropertyValue<string>("ZT", ref fZT, value); }
        }
        string fYZT;
        [Size(4)]
        public string YZT
        {
            get { return fYZT; }
            set { SetPropertyValue<string>("YZT", ref fYZT, value); }
        }
        string fBZ;
        public string BZ
        {
            get { return fBZ; }
            set { SetPropertyValue<string>("BZ", ref fBZ, value); }
        }
        string fCGFPID;
        [Size(16)]
        public string CGFPID
        {
            get { return fCGFPID; }
            set { SetPropertyValue<string>("CGFPID", ref fCGFPID, value); }
        }
        public VIEW_JC_C_CGTSD(Session session) : base(session) { }
        public VIEW_JC_C_CGTSD() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class VIEW_JT_C_SYD_CCDMX : XPLiteObject
    {
        string fCCDMXID;
        [Key]
        [Size(16)]
        public string CCDMXID
        {
            get { return fCCDMXID; }
            set { SetPropertyValue<string>("CCDMXID", ref fCCDMXID, value); }
        }
        string fCCDID;
        [Size(16)]
        public string CCDID
        {
            get { return fCCDID; }
            set { SetPropertyValue<string>("CCDID", ref fCCDID, value); }
        }
        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }
        string fSPXXID;
        [Size(16)]
        public string SPXXID
        {
            get { return fSPXXID; }
            set { SetPropertyValue<string>("SPXXID", ref fSPXXID, value); }
        }
        string fCCDH;
        [Size(22)]
        public string CCDH
        {
            get { return fCCDH; }
            set { SetPropertyValue<string>("CCDH", ref fCCDH, value); }
        }
        string fSPBH;
        [Size(16)]
        public string SPBH
        {
            get { return fSPBH; }
            set { SetPropertyValue<string>("SPBH", ref fSPBH, value); }
        }
        string fPM;
        [Size(100)]
        public string PM
        {
            get { return fPM; }
            set { SetPropertyValue<string>("PM", ref fPM, value); }
        }
        string fZDDM;
        [Size(15)]
        public string ZDDM
        {
            get { return fZDDM; }
            set { SetPropertyValue<string>("ZDDM", ref fZDDM, value); }
        }
        decimal fDJ;
        public decimal DJ
        {
            get { return fDJ; }
            set { SetPropertyValue<decimal>("DJ", ref fDJ, value); }
        }
        decimal fSJ;
        public decimal SJ
        {
            get { return fSJ; }
            set { SetPropertyValue<decimal>("SJ", ref fSJ, value); }
        }
        decimal fZK;
        public decimal ZK
        {
            get { return fZK; }
            set { SetPropertyValue<decimal>("ZK", ref fZK, value); }
        }
        long fCCSL;
        public long CCSL
        {
            get { return fCCSL; }
            set { SetPropertyValue<long>("CCSL", ref fCCSL, value); }
        }
        decimal fCCSY;
        public decimal CCSY
        {
            get { return fCCSY; }
            set { SetPropertyValue<decimal>("CCSY", ref fCCSY, value); }
        }
        decimal fCCMY;
        public decimal CCMY
        {
            get { return fCCMY; }
            set { SetPropertyValue<decimal>("CCMY", ref fCCMY, value); }
        }
        string fLYDJBID;
        [Size(16)]
        public string LYDJBID
        {
            get { return fLYDJBID; }
            set { SetPropertyValue<string>("LYDJBID", ref fLYDJBID, value); }
        }
        string fLYDJID;
        [Size(16)]
        public string LYDJID
        {
            get { return fLYDJID; }
            set { SetPropertyValue<string>("LYDJID", ref fLYDJID, value); }
        }
        string fLYBMID;
        [Size(16)]
        public string LYBMID
        {
            get { return fLYBMID; }
            set { SetPropertyValue<string>("LYBMID", ref fLYBMID, value); }
        }
        string fLYDJMXID;
        [Size(16)]
        public string LYDJMXID
        {
            get { return fLYDJMXID; }
            set { SetPropertyValue<string>("LYDJMXID", ref fLYDJMXID, value); }
        }
        string fZT;
        [Size(4)]
        public string ZT
        {
            get { return fZT; }
            set { SetPropertyValue<string>("ZT", ref fZT, value); }
        }
        string fYZT;
        [Size(4)]
        public string YZT
        {
            get { return fYZT; }
            set { SetPropertyValue<string>("YZT", ref fYZT, value); }
        }
        string fCCYY;
        [Size(500)]
        public string CCYY
        {
            get { return fCCYY; }
            set { SetPropertyValue<string>("CCYY", ref fCCYY, value); }
        }
        public VIEW_JT_C_SYD_CCDMX(Session session) : base(session) { }
        public VIEW_JT_C_SYD_CCDMX() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class VIEW_JT_C_DBD_CCDMX : XPLiteObject
    {
        string fCCDMXID;
        [Key]
        [Size(16)]
        public string CCDMXID
        {
            get { return fCCDMXID; }
            set { SetPropertyValue<string>("CCDMXID", ref fCCDMXID, value); }
        }
        string fCCDID;
        [Size(16)]
        public string CCDID
        {
            get { return fCCDID; }
            set { SetPropertyValue<string>("CCDID", ref fCCDID, value); }
        }
        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }
        string fSPXXID;
        [Size(16)]
        public string SPXXID
        {
            get { return fSPXXID; }
            set { SetPropertyValue<string>("SPXXID", ref fSPXXID, value); }
        }
        string fCCDH;
        [Size(22)]
        public string CCDH
        {
            get { return fCCDH; }
            set { SetPropertyValue<string>("CCDH", ref fCCDH, value); }
        }
        string fSPBH;
        [Size(16)]
        public string SPBH
        {
            get { return fSPBH; }
            set { SetPropertyValue<string>("SPBH", ref fSPBH, value); }
        }
        string fPM;
        [Size(100)]
        public string PM
        {
            get { return fPM; }
            set { SetPropertyValue<string>("PM", ref fPM, value); }
        }
        string fZDDM;
        [Size(15)]
        public string ZDDM
        {
            get { return fZDDM; }
            set { SetPropertyValue<string>("ZDDM", ref fZDDM, value); }
        }
        decimal fDJ;
        public decimal DJ
        {
            get { return fDJ; }
            set { SetPropertyValue<decimal>("DJ", ref fDJ, value); }
        }
        decimal fSJ;
        public decimal SJ
        {
            get { return fSJ; }
            set { SetPropertyValue<decimal>("SJ", ref fSJ, value); }
        }
        decimal fZK;
        public decimal ZK
        {
            get { return fZK; }
            set { SetPropertyValue<decimal>("ZK", ref fZK, value); }
        }
        long fCCSL;
        public long CCSL
        {
            get { return fCCSL; }
            set { SetPropertyValue<long>("CCSL", ref fCCSL, value); }
        }
        decimal fCCSY;
        public decimal CCSY
        {
            get { return fCCSY; }
            set { SetPropertyValue<decimal>("CCSY", ref fCCSY, value); }
        }
        decimal fCCMY;
        public decimal CCMY
        {
            get { return fCCMY; }
            set { SetPropertyValue<decimal>("CCMY", ref fCCMY, value); }
        }
        string fCCYY;
        [Size(500)]
        public string CCYY
        {
            get { return fCCYY; }
            set { SetPropertyValue<string>("CCYY", ref fCCYY, value); }
        }
        string fLYDJBID;
        [Size(16)]
        public string LYDJBID
        {
            get { return fLYDJBID; }
            set { SetPropertyValue<string>("LYDJBID", ref fLYDJBID, value); }
        }
        string fLYDJID;
        [Size(16)]
        public string LYDJID
        {
            get { return fLYDJID; }
            set { SetPropertyValue<string>("LYDJID", ref fLYDJID, value); }
        }
        string fLYBMID;
        [Size(16)]
        public string LYBMID
        {
            get { return fLYBMID; }
            set { SetPropertyValue<string>("LYBMID", ref fLYBMID, value); }
        }
        string fLYDJMXID;
        [Size(16)]
        public string LYDJMXID
        {
            get { return fLYDJMXID; }
            set { SetPropertyValue<string>("LYDJMXID", ref fLYDJMXID, value); }
        }
        string fZT;
        [Size(4)]
        public string ZT
        {
            get { return fZT; }
            set { SetPropertyValue<string>("ZT", ref fZT, value); }
        }
        string fYZT;
        [Size(4)]
        public string YZT
        {
            get { return fYZT; }
            set { SetPropertyValue<string>("YZT", ref fYZT, value); }
        }
        public VIEW_JT_C_DBD_CCDMX(Session session) : base(session) { }
        public VIEW_JT_C_DBD_CCDMX() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class VIEW_JT_C_SYDMX : XPLiteObject
    {
        string fSYDH;
        [Size(22)]
        public string SYDH
        {
            get { return fSYDH; }
            set { SetPropertyValue<string>("SYDH", ref fSYDH, value); }
        }
        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }
        string fPM;
        [Size(100)]
        public string PM
        {
            get { return fPM; }
            set { SetPropertyValue<string>("PM", ref fPM, value); }
        }
        decimal fDJ;
        public decimal DJ
        {
            get { return fDJ; }
            set { SetPropertyValue<decimal>("DJ", ref fDJ, value); }
        }
        string fSPBH;
        [Size(16)]
        public string SPBH
        {
            get { return fSPBH; }
            set { SetPropertyValue<string>("SPBH", ref fSPBH, value); }
        }
        string fSYDMXID;
        [Key]
        [Size(16)]
        public string SYDMXID
        {
            get { return fSYDMXID; }
            set { SetPropertyValue<string>("SYDMXID", ref fSYDMXID, value); }
        }
        string fSYDID;
        [Size(16)]
        public string SYDID
        {
            get { return fSYDID; }
            set { SetPropertyValue<string>("SYDID", ref fSYDID, value); }
        }
        string fSPXXID;
        [Size(16)]
        public string SPXXID
        {
            get { return fSPXXID; }
            set { SetPropertyValue<string>("SPXXID", ref fSPXXID, value); }
        }
        long fYKCS;
        public long YKCS
        {
            get { return fYKCS; }
            set { SetPropertyValue<long>("YKCS", ref fYKCS, value); }
        }
        decimal fYKMY;
        public decimal YKMY
        {
            get { return fYKMY; }
            set { SetPropertyValue<decimal>("YKMY", ref fYKMY, value); }
        }
        decimal fYKSY;
        public decimal YKSY
        {
            get { return fYKSY; }
            set { SetPropertyValue<decimal>("YKSY", ref fYKSY, value); }
        }
        string fLYDJBID;
        [Size(16)]
        public string LYDJBID
        {
            get { return fLYDJBID; }
            set { SetPropertyValue<string>("LYDJBID", ref fLYDJBID, value); }
        }
        string fLYDJID;
        [Size(16)]
        public string LYDJID
        {
            get { return fLYDJID; }
            set { SetPropertyValue<string>("LYDJID", ref fLYDJID, value); }
        }
        string fLYDJMXID;
        [Size(16)]
        public string LYDJMXID
        {
            get { return fLYDJMXID; }
            set { SetPropertyValue<string>("LYDJMXID", ref fLYDJMXID, value); }
        }
        string fLYBMID;
        [Size(16)]
        public string LYBMID
        {
            get { return fLYBMID; }
            set { SetPropertyValue<string>("LYBMID", ref fLYBMID, value); }
        }
        string fYSDJMXID;
        [Size(16)]
        public string YSDJMXID
        {
            get { return fYSDJMXID; }
            set { SetPropertyValue<string>("YSDJMXID", ref fYSDJMXID, value); }
        }
        string fYSDLXID;
        [Size(16)]
        public string YSDLXID
        {
            get { return fYSDLXID; }
            set { SetPropertyValue<string>("YSDLXID", ref fYSDLXID, value); }
        }
        string fBMSPKFMXID;
        [Size(16)]
        public string BMSPKFMXID
        {
            get { return fBMSPKFMXID; }
            set { SetPropertyValue<string>("BMSPKFMXID", ref fBMSPKFMXID, value); }
        }
        string fBZ;
        public string BZ
        {
            get { return fBZ; }
            set { SetPropertyValue<string>("BZ", ref fBZ, value); }
        }
        public VIEW_JT_C_SYDMX(Session session) : base(session) { }
        public VIEW_JT_C_SYDMX() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class VIEW_JT_C_DBD : XPLiteObject
    {
        string fSTATUSMC;
        [Size(16)]
        public string STATUSMC
        {
            get { return fSTATUSMC; }
            set { SetPropertyValue<string>("STATUSMC", ref fSTATUSMC, value); }
        }
        string fDBDID;
        [Key]
        [Size(16)]
        public string DBDID
        {
            get { return fDBDID; }
            set { SetPropertyValue<string>("DBDID", ref fDBDID, value); }
        }
        string fDBDH;
        [Size(22)]
        public string DBDH
        {
            get { return fDBDH; }
            set { SetPropertyValue<string>("DBDH", ref fDBDH, value); }
        }
        string fDCBMMC;
        [Size(100)]
        public string DCBMMC
        {
            get { return fDCBMMC; }
            set { SetPropertyValue<string>("DCBMMC", ref fDCBMMC, value); }
        }
        string fDRBMMC;
        [Size(100)]
        public string DRBMMC
        {
            get { return fDRBMMC; }
            set { SetPropertyValue<string>("DRBMMC", ref fDRBMMC, value); }
        }
        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }
        string fDCBMID;
        [Size(16)]
        public string DCBMID
        {
            get { return fDCBMID; }
            set { SetPropertyValue<string>("DCBMID", ref fDCBMID, value); }
        }
        string fDRBMID;
        [Size(16)]
        public string DRBMID
        {
            get { return fDRBMID; }
            set { SetPropertyValue<string>("DRBMID", ref fDRBMID, value); }
        }
        long fSL;
        public long SL
        {
            get { return fSL; }
            set { SetPropertyValue<long>("SL", ref fSL, value); }
        }
        DateTime fZDRQ;
        public DateTime ZDRQ
        {
            get { return fZDRQ; }
            set { SetPropertyValue<DateTime>("ZDRQ", ref fZDRQ, value); }
        }
        string fDCWLBMID;
        [Size(16)]
        public string DCWLBMID
        {
            get { return fDCWLBMID; }
            set { SetPropertyValue<string>("DCWLBMID", ref fDCWLBMID, value); }
        }
        string fDRWLBMID;
        [Size(16)]
        public string DRWLBMID
        {
            get { return fDRWLBMID; }
            set { SetPropertyValue<string>("DRWLBMID", ref fDRWLBMID, value); }
        }
        long fDBPZS;
        public long DBPZS
        {
            get { return fDBPZS; }
            set { SetPropertyValue<long>("DBPZS", ref fDBPZS, value); }
        }
        long fDBSL;
        public long DBSL
        {
            get { return fDBSL; }
            set { SetPropertyValue<long>("DBSL", ref fDBSL, value); }
        }
        decimal fDBSY;
        public decimal DBSY
        {
            get { return fDBSY; }
            set { SetPropertyValue<decimal>("DBSY", ref fDBSY, value); }
        }
        decimal fDBMY;
        public decimal DBMY
        {
            get { return fDBMY; }
            set { SetPropertyValue<decimal>("DBMY", ref fDBMY, value); }
        }
        string fDBPZH;
        [Size(22)]
        public string DBPZH
        {
            get { return fDBPZH; }
            set { SetPropertyValue<string>("DBPZH", ref fDBPZH, value); }
        }
        DateTime fDBPZRQ;
        public DateTime DBPZRQ
        {
            get { return fDBPZRQ; }
            set { SetPropertyValue<DateTime>("DBPZRQ", ref fDBPZRQ, value); }
        }
        string fDBPZID;
        [Size(16)]
        public string DBPZID
        {
            get { return fDBPZID; }
            set { SetPropertyValue<string>("DBPZID", ref fDBPZID, value); }
        }
        string fCZYID;
        [Size(16)]
        public string CZYID
        {
            get { return fCZYID; }
            set { SetPropertyValue<string>("CZYID", ref fCZYID, value); }
        }
        DateTime fCZRQ;
        public DateTime CZRQ
        {
            get { return fCZRQ; }
            set { SetPropertyValue<DateTime>("CZRQ", ref fCZRQ, value); }
        }
        string fZT;
        [Size(4)]
        public string ZT
        {
            get { return fZT; }
            set { SetPropertyValue<string>("ZT", ref fZT, value); }
        }
        string fYZT;
        [Size(4)]
        public string YZT
        {
            get { return fYZT; }
            set { SetPropertyValue<string>("YZT", ref fYZT, value); }
        }
        string fBZ;
        public string BZ
        {
            get { return fBZ; }
            set { SetPropertyValue<string>("BZ", ref fBZ, value); }
        }
        string fCZYXM;
        [Size(16)]
        public string CZYXM
        {
            get { return fCZYXM; }
            set { SetPropertyValue<string>("CZYXM", ref fCZYXM, value); }
        }
        public VIEW_JT_C_DBD(Session session) : base(session) { }
        public VIEW_JT_C_DBD() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class VIEW_JT_C_SYD_CCD : XPLiteObject
    {
        string fCCDID;
        [Key]
        [Size(16)]
        public string CCDID
        {
            get { return fCCDID; }
            set { SetPropertyValue<string>("CCDID", ref fCCDID, value); }
        }
        string fCCDH;
        [Size(22)]
        public string CCDH
        {
            get { return fCCDH; }
            set { SetPropertyValue<string>("CCDH", ref fCCDH, value); }
        }
        string fBMID;
        [Size(16)]
        public string BMID
        {
            get { return fBMID; }
            set { SetPropertyValue<string>("BMID", ref fBMID, value); }
        }
        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }
        DateTime fZDRQ;
        public DateTime ZDRQ
        {
            get { return fZDRQ; }
            set { SetPropertyValue<DateTime>("ZDRQ", ref fZDRQ, value); }
        }
        string fCZYID;
        [Size(16)]
        public string CZYID
        {
            get { return fCZYID; }
            set { SetPropertyValue<string>("CZYID", ref fCZYID, value); }
        }
        DateTime fCZRQ;
        public DateTime CZRQ
        {
            get { return fCZRQ; }
            set { SetPropertyValue<DateTime>("CZRQ", ref fCZRQ, value); }
        }
        long fCCSL;
        public long CCSL
        {
            get { return fCCSL; }
            set { SetPropertyValue<long>("CCSL", ref fCCSL, value); }
        }
        decimal fCCSY;
        public decimal CCSY
        {
            get { return fCCSY; }
            set { SetPropertyValue<decimal>("CCSY", ref fCCSY, value); }
        }
        decimal fCCMY;
        public decimal CCMY
        {
            get { return fCCMY; }
            set { SetPropertyValue<decimal>("CCMY", ref fCCMY, value); }
        }
        long fCCPZ;
        public long CCPZ
        {
            get { return fCCPZ; }
            set { SetPropertyValue<long>("CCPZ", ref fCCPZ, value); }
        }
        string fZT;
        [Size(4)]
        public string ZT
        {
            get { return fZT; }
            set { SetPropertyValue<string>("ZT", ref fZT, value); }
        }
        string fYZT;
        [Size(4)]
        public string YZT
        {
            get { return fYZT; }
            set { SetPropertyValue<string>("YZT", ref fYZT, value); }
        }
        string fSYBMMC;
        [Size(100)]
        public string SYBMMC
        {
            get { return fSYBMMC; }
            set { SetPropertyValue<string>("SYBMMC", ref fSYBMMC, value); }
        }
        string fWLBMMC;
        [Size(100)]
        public string WLBMMC
        {
            get { return fWLBMMC; }
            set { SetPropertyValue<string>("WLBMMC", ref fWLBMMC, value); }
        }
        string fSTATUSMC;
        [Size(16)]
        public string STATUSMC
        {
            get { return fSTATUSMC; }
            set { SetPropertyValue<string>("STATUSMC", ref fSTATUSMC, value); }
        }
        public VIEW_JT_C_SYD_CCD(Session session) : base(session) { }
        public VIEW_JT_C_SYD_CCD() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class VIEW_JT_C_DBDMX : XPLiteObject
    {
        string fDBDH;
        [Size(22)]
        public string DBDH
        {
            get { return fDBDH; }
            set { SetPropertyValue<string>("DBDH", ref fDBDH, value); }
        }
        string fPM;
        [Size(100)]
        public string PM
        {
            get { return fPM; }
            set { SetPropertyValue<string>("PM", ref fPM, value); }
        }
        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }
        string fDBDMXID;
        [Key]
        [Size(16)]
        public string DBDMXID
        {
            get { return fDBDMXID; }
            set { SetPropertyValue<string>("DBDMXID", ref fDBDMXID, value); }
        }
        string fDBDID;
        [Size(16)]
        public string DBDID
        {
            get { return fDBDID; }
            set { SetPropertyValue<string>("DBDID", ref fDBDID, value); }
        }
        string fSPXXID;
        [Size(16)]
        public string SPXXID
        {
            get { return fSPXXID; }
            set { SetPropertyValue<string>("SPXXID", ref fSPXXID, value); }
        }
        string fZDDM;
        [Size(15)]
        public string ZDDM
        {
            get { return fZDDM; }
            set { SetPropertyValue<string>("ZDDM", ref fZDDM, value); }
        }
        long fDBSL;
        public long DBSL
        {
            get { return fDBSL; }
            set { SetPropertyValue<long>("DBSL", ref fDBSL, value); }
        }
        decimal fDBSY;
        public decimal DBSY
        {
            get { return fDBSY; }
            set { SetPropertyValue<decimal>("DBSY", ref fDBSY, value); }
        }
        decimal fDBMY;
        public decimal DBMY
        {
            get { return fDBMY; }
            set { SetPropertyValue<decimal>("DBMY", ref fDBMY, value); }
        }
        decimal fDJ;
        public decimal DJ
        {
            get { return fDJ; }
            set { SetPropertyValue<decimal>("DJ", ref fDJ, value); }
        }
        string fBZ;
        public string BZ
        {
            get { return fBZ; }
            set { SetPropertyValue<string>("BZ", ref fBZ, value); }
        }
        decimal fJJ;
        public decimal JJ
        {
            get { return fJJ; }
            set { SetPropertyValue<decimal>("JJ", ref fJJ, value); }
        }
        decimal fJZ;
        public decimal JZ
        {
            get { return fJZ; }
            set { SetPropertyValue<decimal>("JZ", ref fJZ, value); }
        }
        byte fSL;
        public byte SL
        {
            get { return fSL; }
            set { SetPropertyValue<byte>("SL", ref fSL, value); }
        }
        string fLYDJBID;
        [Size(16)]
        public string LYDJBID
        {
            get { return fLYDJBID; }
            set { SetPropertyValue<string>("LYDJBID", ref fLYDJBID, value); }
        }
        string fLYDJID;
        [Size(16)]
        public string LYDJID
        {
            get { return fLYDJID; }
            set { SetPropertyValue<string>("LYDJID", ref fLYDJID, value); }
        }
        string fLYBMID;
        [Size(16)]
        public string LYBMID
        {
            get { return fLYBMID; }
            set { SetPropertyValue<string>("LYBMID", ref fLYBMID, value); }
        }
        string fLYDJMXID;
        [Size(16)]
        public string LYDJMXID
        {
            get { return fLYDJMXID; }
            set { SetPropertyValue<string>("LYDJMXID", ref fLYDJMXID, value); }
        }
        string fZT;
        [Size(4)]
        public string ZT
        {
            get { return fZT; }
            set { SetPropertyValue<string>("ZT", ref fZT, value); }
        }
        string fYZT;
        [Size(4)]
        public string YZT
        {
            get { return fYZT; }
            set { SetPropertyValue<string>("YZT", ref fYZT, value); }
        }
        string fDRBMSPKFMXID;
        [Size(16)]
        public string DRBMSPKFMXID
        {
            get { return fDRBMSPKFMXID; }
            set { SetPropertyValue<string>("DRBMSPKFMXID", ref fDRBMSPKFMXID, value); }
        }
        string fDCBMSPKFMXID;
        [Size(16)]
        public string DCBMSPKFMXID
        {
            get { return fDCBMSPKFMXID; }
            set { SetPropertyValue<string>("DCBMSPKFMXID", ref fDCBMSPKFMXID, value); }
        }
        string fCZYXM;
        [Size(16)]
        public string CZYXM
        {
            get { return fCZYXM; }
            set { SetPropertyValue<string>("CZYXM", ref fCZYXM, value); }
        }
        public VIEW_JT_C_DBDMX(Session session) : base(session) { }
        public VIEW_JT_C_DBDMX() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class VIEW_JT_C_SYD : XPLiteObject
    {
        string fSTATUSMC;
        [Size(16)]
        public string STATUSMC
        {
            get { return fSTATUSMC; }
            set { SetPropertyValue<string>("STATUSMC", ref fSTATUSMC, value); }
        }
        string fSYDID;
        [Key]
        [Size(16)]
        public string SYDID
        {
            get { return fSYDID; }
            set { SetPropertyValue<string>("SYDID", ref fSYDID, value); }
        }
        string fSYDH;
        [Size(22)]
        public string SYDH
        {
            get { return fSYDH; }
            set { SetPropertyValue<string>("SYDH", ref fSYDH, value); }
        }
        string fSYLX;
        [Size(16)]
        public string SYLX
        {
            get { return fSYLX; }
            set { SetPropertyValue<string>("SYLX", ref fSYLX, value); }
        }
        string fSYLXMC;
        [Size(40)]
        public string SYLXMC
        {
            get { return fSYLXMC; }
            set { SetPropertyValue<string>("SYLXMC", ref fSYLXMC, value); }
        }
        string fSYBMMC;
        [Size(100)]
        public string SYBMMC
        {
            get { return fSYBMMC; }
            set { SetPropertyValue<string>("SYBMMC", ref fSYBMMC, value); }
        }
        string fZTMC;
        [Size(100)]
        public string ZTMC
        {
            get { return fZTMC; }
            set { SetPropertyValue<string>("ZTMC", ref fZTMC, value); }
        }
        string fWLBMMC;
        [Size(100)]
        public string WLBMMC
        {
            get { return fWLBMMC; }
            set { SetPropertyValue<string>("WLBMMC", ref fWLBMMC, value); }
        }
        string fPZH;
        [Size(22)]
        public string PZH
        {
            get { return fPZH; }
            set { SetPropertyValue<string>("PZH", ref fPZH, value); }
        }
        string fSYBMID;
        [Size(16)]
        public string SYBMID
        {
            get { return fSYBMID; }
            set { SetPropertyValue<string>("SYBMID", ref fSYBMID, value); }
        }
        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }
        string fWLBMID;
        [Size(16)]
        public string WLBMID
        {
            get { return fWLBMID; }
            set { SetPropertyValue<string>("WLBMID", ref fWLBMID, value); }
        }
        long fZPZ;
        public long ZPZ
        {
            get { return fZPZ; }
            set { SetPropertyValue<long>("ZPZ", ref fZPZ, value); }
        }
        long fZSL;
        public long ZSL
        {
            get { return fZSL; }
            set { SetPropertyValue<long>("ZSL", ref fZSL, value); }
        }
        decimal fZMY;
        public decimal ZMY
        {
            get { return fZMY; }
            set { SetPropertyValue<decimal>("ZMY", ref fZMY, value); }
        }
        decimal fZSY;
        public decimal ZSY
        {
            get { return fZSY; }
            set { SetPropertyValue<decimal>("ZSY", ref fZSY, value); }
        }
        string fZT;
        [Size(4)]
        public string ZT
        {
            get { return fZT; }
            set { SetPropertyValue<string>("ZT", ref fZT, value); }
        }
        string fYZT;
        [Size(4)]
        public string YZT
        {
            get { return fYZT; }
            set { SetPropertyValue<string>("YZT", ref fYZT, value); }
        }
        string fBZ;
        [Size(400)]
        public string BZ
        {
            get { return fBZ; }
            set { SetPropertyValue<string>("BZ", ref fBZ, value); }
        }
        DateTime fZDRQ;
        public DateTime ZDRQ
        {
            get { return fZDRQ; }
            set { SetPropertyValue<DateTime>("ZDRQ", ref fZDRQ, value); }
        }
        DateTime fCZRQ;
        public DateTime CZRQ
        {
            get { return fCZRQ; }
            set { SetPropertyValue<DateTime>("CZRQ", ref fCZRQ, value); }
        }
        string fCZYID;
        [Size(16)]
        public string CZYID
        {
            get { return fCZYID; }
            set { SetPropertyValue<string>("CZYID", ref fCZYID, value); }
        }
        string fPZID;
        [Size(16)]
        public string PZID
        {
            get { return fPZID; }
            set { SetPropertyValue<string>("PZID", ref fPZID, value); }
        }
        DateTime fPZRQ;
        public DateTime PZRQ
        {
            get { return fPZRQ; }
            set { SetPropertyValue<DateTime>("PZRQ", ref fPZRQ, value); }
        }
        string fCZYXM;
        [Size(16)]
        public string CZYXM
        {
            get { return fCZYXM; }
            set { SetPropertyValue<string>("CZYXM", ref fCZYXM, value); }
        }
        public VIEW_JT_C_SYD(Session session) : base(session) { }
        public VIEW_JT_C_SYD() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class VIEW_JT_C_DBD_CCD : XPLiteObject
    {
        string fCCDID;
        [Key]
        [Size(16)]
        public string CCDID
        {
            get { return fCCDID; }
            set { SetPropertyValue<string>("CCDID", ref fCCDID, value); }
        }
        string fCCDH;
        [Size(22)]
        public string CCDH
        {
            get { return fCCDH; }
            set { SetPropertyValue<string>("CCDH", ref fCCDH, value); }
        }
        string fBMID;
        [Size(16)]
        public string BMID
        {
            get { return fBMID; }
            set { SetPropertyValue<string>("BMID", ref fBMID, value); }
        }
        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }
        DateTime fZDRQ;
        public DateTime ZDRQ
        {
            get { return fZDRQ; }
            set { SetPropertyValue<DateTime>("ZDRQ", ref fZDRQ, value); }
        }
        string fCZYID;
        [Size(16)]
        public string CZYID
        {
            get { return fCZYID; }
            set { SetPropertyValue<string>("CZYID", ref fCZYID, value); }
        }
        DateTime fCZRQ;
        public DateTime CZRQ
        {
            get { return fCZRQ; }
            set { SetPropertyValue<DateTime>("CZRQ", ref fCZRQ, value); }
        }
        long fCCSL;
        public long CCSL
        {
            get { return fCCSL; }
            set { SetPropertyValue<long>("CCSL", ref fCCSL, value); }
        }
        decimal fCCSY;
        public decimal CCSY
        {
            get { return fCCSY; }
            set { SetPropertyValue<decimal>("CCSY", ref fCCSY, value); }
        }
        decimal fCCMY;
        public decimal CCMY
        {
            get { return fCCMY; }
            set { SetPropertyValue<decimal>("CCMY", ref fCCMY, value); }
        }
        long fCCPZ;
        public long CCPZ
        {
            get { return fCCPZ; }
            set { SetPropertyValue<long>("CCPZ", ref fCCPZ, value); }
        }
        string fZT;
        [Size(4)]
        public string ZT
        {
            get { return fZT; }
            set { SetPropertyValue<string>("ZT", ref fZT, value); }
        }
        string fYZT;
        [Size(4)]
        public string YZT
        {
            get { return fYZT; }
            set { SetPropertyValue<string>("YZT", ref fYZT, value); }
        }
        string fDRBMMC;
        [Size(100)]
        public string DRBMMC
        {
            get { return fDRBMMC; }
            set { SetPropertyValue<string>("DRBMMC", ref fDRBMMC, value); }
        }
        string fDCBMMC;
        [Size(100)]
        public string DCBMMC
        {
            get { return fDCBMMC; }
            set { SetPropertyValue<string>("DCBMMC", ref fDCBMMC, value); }
        }
        string fSTATUSMC;
        [Size(16)]
        public string STATUSMC
        {
            get { return fSTATUSMC; }
            set { SetPropertyValue<string>("STATUSMC", ref fSTATUSMC, value); }
        }
        public VIEW_JT_C_DBD_CCD(Session session) : base(session) { }
        public VIEW_JT_C_DBD_CCD() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class VIEW_JT_G_CGSH : XPLiteObject
    {
        string fCGSHID;
        [Key]
        [Size(16)]
        public string CGSHID
        {
            get { return fCGSHID; }
            set { SetPropertyValue<string>("CGSHID", ref fCGSHID, value); }
        }
        string fCGSHDH;
        [Size(22)]
        public string CGSHDH
        {
            get { return fCGSHDH; }
            set { SetPropertyValue<string>("CGSHDH", ref fCGSHDH, value); }
        }
        string fYSDH;
        [Size(40)]
        public string YSDH
        {
            get { return fYSDH; }
            set { SetPropertyValue<string>("YSDH", ref fYSDH, value); }
        }
        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }
        string fCGBMID;
        [Size(16)]
        public string CGBMID
        {
            get { return fCGBMID; }
            set { SetPropertyValue<string>("CGBMID", ref fCGBMID, value); }
        }
        string fGYSID;
        [Size(16)]
        public string GYSID
        {
            get { return fGYSID; }
            set { SetPropertyValue<string>("GYSID", ref fGYSID, value); }
        }
        string fSHRID;
        [Size(16)]
        public string SHRID
        {
            get { return fSHRID; }
            set { SetPropertyValue<string>("SHRID", ref fSHRID, value); }
        }
        DateTime fSHRQ;
        public DateTime SHRQ
        {
            get { return fSHRQ; }
            set { SetPropertyValue<DateTime>("SHRQ", ref fSHRQ, value); }
        }
        string fSHBMID;
        [Size(16)]
        public string SHBMID
        {
            get { return fSHBMID; }
            set { SetPropertyValue<string>("SHBMID", ref fSHBMID, value); }
        }
        string fCZYID;
        [Size(16)]
        public string CZYID
        {
            get { return fCZYID; }
            set { SetPropertyValue<string>("CZYID", ref fCZYID, value); }
        }
        DateTime fCZRQ;
        public DateTime CZRQ
        {
            get { return fCZRQ; }
            set { SetPropertyValue<DateTime>("CZRQ", ref fCZRQ, value); }
        }
        DateTime fZDRQ;
        public DateTime ZDRQ
        {
            get { return fZDRQ; }
            set { SetPropertyValue<DateTime>("ZDRQ", ref fZDRQ, value); }
        }
        int fYDZPZ;
        public int YDZPZ
        {
            get { return fYDZPZ; }
            set { SetPropertyValue<int>("YDZPZ", ref fYDZPZ, value); }
        }
        long fYDZSL;
        public long YDZSL
        {
            get { return fYDZSL; }
            set { SetPropertyValue<long>("YDZSL", ref fYDZSL, value); }
        }
        decimal fYDZSY;
        public decimal YDZSY
        {
            get { return fYDZSY; }
            set { SetPropertyValue<decimal>("YDZSY", ref fYDZSY, value); }
        }
        decimal fYDZMY;
        public decimal YDZMY
        {
            get { return fYDZMY; }
            set { SetPropertyValue<decimal>("YDZMY", ref fYDZMY, value); }
        }
        int fSSZPZ;
        public int SSZPZ
        {
            get { return fSSZPZ; }
            set { SetPropertyValue<int>("SSZPZ", ref fSSZPZ, value); }
        }
        long fSSZSL;
        public long SSZSL
        {
            get { return fSSZSL; }
            set { SetPropertyValue<long>("SSZSL", ref fSSZSL, value); }
        }
        decimal fSSZSY;
        public decimal SSZSY
        {
            get { return fSSZSY; }
            set { SetPropertyValue<decimal>("SSZSY", ref fSSZSY, value); }
        }
        decimal fSSZMY;
        public decimal SSZMY
        {
            get { return fSSZMY; }
            set { SetPropertyValue<decimal>("SSZMY", ref fSSZMY, value); }
        }
        long fZPZSL;
        public long ZPZSL
        {
            get { return fZPZSL; }
            set { SetPropertyValue<long>("ZPZSL", ref fZPZSL, value); }
        }
        decimal fZPZSY;
        public decimal ZPZSY
        {
            get { return fZPZSY; }
            set { SetPropertyValue<decimal>("ZPZSY", ref fZPZSY, value); }
        }
        decimal fZPZMY;
        public decimal ZPZMY
        {
            get { return fZPZMY; }
            set { SetPropertyValue<decimal>("ZPZMY", ref fZPZMY, value); }
        }
        string fYHRID;
        [Size(16)]
        public string YHRID
        {
            get { return fYHRID; }
            set { SetPropertyValue<string>("YHRID", ref fYHRID, value); }
        }
        DateTime fYHRQ;
        public DateTime YHRQ
        {
            get { return fYHRQ; }
            set { SetPropertyValue<DateTime>("YHRQ", ref fYHRQ, value); }
        }
        short fSL;
        public short SL
        {
            get { return fSL; }
            set { SetPropertyValue<short>("SL", ref fSL, value); }
        }
        string fYSFSID;
        [Size(16)]
        public string YSFSID
        {
            get { return fYSFSID; }
            set { SetPropertyValue<string>("YSFSID", ref fYSFSID, value); }
        }
        decimal fJSHJ;
        public decimal JSHJ
        {
            get { return fJSHJ; }
            set { SetPropertyValue<decimal>("JSHJ", ref fJSHJ, value); }
        }
        decimal fZKE;
        public decimal ZKE
        {
            get { return fZKE; }
            set { SetPropertyValue<decimal>("ZKE", ref fZKE, value); }
        }
        decimal fSE;
        public decimal SE
        {
            get { return fSE; }
            set { SetPropertyValue<decimal>("SE", ref fSE, value); }
        }
        decimal fWSJE;
        public decimal WSJE
        {
            get { return fWSJE; }
            set { SetPropertyValue<decimal>("WSJE", ref fWSJE, value); }
        }
        long fZZSL;
        public long ZZSL
        {
            get { return fZZSL; }
            set { SetPropertyValue<long>("ZZSL", ref fZZSL, value); }
        }
        decimal fZZSY;
        public decimal ZZSY
        {
            get { return fZZSY; }
            set { SetPropertyValue<decimal>("ZZSY", ref fZZSY, value); }
        }
        decimal fZZMY;
        public decimal ZZMY
        {
            get { return fZZMY; }
            set { SetPropertyValue<decimal>("ZZMY", ref fZZMY, value); }
        }
        long fYFSL;
        public long YFSL
        {
            get { return fYFSL; }
            set { SetPropertyValue<long>("YFSL", ref fYFSL, value); }
        }
        decimal fYFMY;
        public decimal YFMY
        {
            get { return fYFMY; }
            set { SetPropertyValue<decimal>("YFMY", ref fYFMY, value); }
        }
        decimal fYFSY;
        public decimal YFSY
        {
            get { return fYFSY; }
            set { SetPropertyValue<decimal>("YFSY", ref fYFSY, value); }
        }
        string fZT;
        [Size(4)]
        public string ZT
        {
            get { return fZT; }
            set { SetPropertyValue<string>("ZT", ref fZT, value); }
        }
        string fYZT;
        [Size(4)]
        public string YZT
        {
            get { return fYZT; }
            set { SetPropertyValue<string>("YZT", ref fYZT, value); }
        }
        string fBZ;
        public string BZ
        {
            get { return fBZ; }
            set { SetPropertyValue<string>("BZ", ref fBZ, value); }
        }
        string fJHFSID;
        [Size(16)]
        public string JHFSID
        {
            get { return fJHFSID; }
            set { SetPropertyValue<string>("JHFSID", ref fJHFSID, value); }
        }
        string fSHPZID;
        [Size(16)]
        public string SHPZID
        {
            get { return fSHPZID; }
            set { SetPropertyValue<string>("SHPZID", ref fSHPZID, value); }
        }
        DateTime fSHHZRQ;
        public DateTime SHHZRQ
        {
            get { return fSHHZRQ; }
            set { SetPropertyValue<DateTime>("SHHZRQ", ref fSHHZRQ, value); }
        }
        string fSHHZDID;
        [Size(16)]
        public string SHHZDID
        {
            get { return fSHHZDID; }
            set { SetPropertyValue<string>("SHHZDID", ref fSHHZDID, value); }
        }
        DateTime fSHPZRQ;
        public DateTime SHPZRQ
        {
            get { return fSHPZRQ; }
            set { SetPropertyValue<DateTime>("SHPZRQ", ref fSHPZRQ, value); }
        }

        string fZTMC;
        [Size(100)]
        public string ZTMC
        {
            get { return fZTMC; }
            set { SetPropertyValue<string>("ZTMC", ref fZTMC, value); }
        }

        string fGYSMC;
        [Size(100)]
        public string GYSMC
        {
            get { return fGYSMC; }
            set { SetPropertyValue<string>("GYSMC", ref fGYSMC, value); }
        }

        string fCGBMMC;
        [Size(100)]
        public string CGBMMC
        {
            get { return fCGBMMC; }
            set { SetPropertyValue<string>("CGBMMC", ref fCGBMMC, value); }
        }

        string fSHBMMC;
        [Size(100)]
        public string SHBMMC
        {
            get { return fSHBMMC; }
            set { SetPropertyValue<string>("SHBMMC", ref fSHBMMC, value); }
        }

        string fSHRXM;
        [Size(16)]
        public string SHRXM
        {
            get { return fSHRXM; }
            set { SetPropertyValue<string>("SHRXM", ref fSHRXM, value); }
        }

        string fCZYXM;
        [Size(16)]
        public string CZYXM
        {
            get { return fCZYXM; }
            set { SetPropertyValue<string>("CZYXM", ref fCZYXM, value); }
        }

        string fSHHZDH;
        [Size(22)]
        public string SHHZDH
        {
            get { return fSHHZDH; }
            set { SetPropertyValue<string>("SHHZDH", ref fSHHZDH, value); }
        }

        string fSHPZDH;
        [Size(22)]
        public string SHPZDH
        {
            get { return fSHPZDH; }
            set { SetPropertyValue<string>("SHPZDH", ref fSHPZDH, value); }
        }

        string fSTATUSMC;
        [Size(16)]
        public string STATUSMC
        {
            get { return fSTATUSMC; }
            set { SetPropertyValue<string>("STATUSMC", ref fSTATUSMC, value); }
        }

        public VIEW_JT_G_CGSH(Session session) : base(session) { }
        public VIEW_JT_G_CGSH() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class VIEW_JT_G_CGSHMX : XPLiteObject
    {
        string fCGSHMXID;
        [Key]
        [Size(16)]
        public string CGSHMXID
        {
            get { return fCGSHMXID; }
            set { SetPropertyValue<string>("CGSHMXID", ref fCGSHMXID, value); }
        }
        string fCGSHID;
        [Size(16)]
        public string CGSHID
        {
            get { return fCGSHID; }
            set { SetPropertyValue<string>("CGSHID", ref fCGSHID, value); }
        }
        string fCGMXDID;
        [Size(16)]
        public string CGMXDID
        {
            get { return fCGMXDID; }
            set { SetPropertyValue<string>("CGMXDID", ref fCGMXDID, value); }
        }
        string fJHFSID;
        [Size(16)]
        public string JHFSID
        {
            get { return fJHFSID; }
            set { SetPropertyValue<string>("JHFSID", ref fJHFSID, value); }
        }
        string fZDDM;
        [Size(15)]
        public string ZDDM
        {
            get { return fZDDM; }
            set { SetPropertyValue<string>("ZDDM", ref fZDDM, value); }
        }
        string fSPXXID;
        [Size(16)]
        public string SPXXID
        {
            get { return fSPXXID; }
            set { SetPropertyValue<string>("SPXXID", ref fSPXXID, value); }
        }
        decimal fJJ;
        public decimal JJ
        {
            get { return fJJ; }
            set { SetPropertyValue<decimal>("JJ", ref fJJ, value); }
        }
        decimal fJZ;
        public decimal JZ
        {
            get { return fJZ; }
            set { SetPropertyValue<decimal>("JZ", ref fJZ, value); }
        }
        long fYDSL;
        public long YDSL
        {
            get { return fYDSL; }
            set { SetPropertyValue<long>("YDSL", ref fYDSL, value); }
        }
        decimal fYDSY;
        public decimal YDSY
        {
            get { return fYDSY; }
            set { SetPropertyValue<decimal>("YDSY", ref fYDSY, value); }
        }
        decimal fYDMY;
        public decimal YDMY
        {
            get { return fYDMY; }
            set { SetPropertyValue<decimal>("YDMY", ref fYDMY, value); }
        }
        long fSSSL;
        public long SSSL
        {
            get { return fSSSL; }
            set { SetPropertyValue<long>("SSSL", ref fSSSL, value); }
        }
        decimal fSSSY;
        public decimal SSSY
        {
            get { return fSSSY; }
            set { SetPropertyValue<decimal>("SSSY", ref fSSSY, value); }
        }
        decimal fSSMY;
        public decimal SSMY
        {
            get { return fSSMY; }
            set { SetPropertyValue<decimal>("SSMY", ref fSSMY, value); }
        }
        long fZPSL;
        public long ZPSL
        {
            get { return fZPSL; }
            set { SetPropertyValue<long>("ZPSL", ref fZPSL, value); }
        }
        decimal fZPSY;
        public decimal ZPSY
        {
            get { return fZPSY; }
            set { SetPropertyValue<decimal>("ZPSY", ref fZPSY, value); }
        }
        decimal fZPMY;
        public decimal ZPMY
        {
            get { return fZPMY; }
            set { SetPropertyValue<decimal>("ZPMY", ref fZPMY, value); }
        }
        long fZZSL;
        public long ZZSL
        {
            get { return fZZSL; }
            set { SetPropertyValue<long>("ZZSL", ref fZZSL, value); }
        }
        decimal fZZSY;
        public decimal ZZSY
        {
            get { return fZZSY; }
            set { SetPropertyValue<decimal>("ZZSY", ref fZZSY, value); }
        }
        decimal fZZMY;
        public decimal ZZMY
        {
            get { return fZZMY; }
            set { SetPropertyValue<decimal>("ZZMY", ref fZZMY, value); }
        }
        DateTime fQSZZRQ;
        public DateTime QSZZRQ
        {
            get { return fQSZZRQ; }
            set { SetPropertyValue<DateTime>("QSZZRQ", ref fQSZZRQ, value); }
        }
        DateTime fZHZZRQ;
        public DateTime ZHZZRQ
        {
            get { return fZHZZRQ; }
            set { SetPropertyValue<DateTime>("ZHZZRQ", ref fZHZZRQ, value); }
        }
        long fYFSL;
        public long YFSL
        {
            get { return fYFSL; }
            set { SetPropertyValue<long>("YFSL", ref fYFSL, value); }
        }
        decimal fYFMY;
        public decimal YFMY
        {
            get { return fYFMY; }
            set { SetPropertyValue<decimal>("YFMY", ref fYFMY, value); }
        }
        decimal fYFSY;
        public decimal YFSY
        {
            get { return fYFSY; }
            set { SetPropertyValue<decimal>("YFSY", ref fYFSY, value); }
        }
        DateTime fQSFKRQ;
        public DateTime QSFKRQ
        {
            get { return fQSFKRQ; }
            set { SetPropertyValue<DateTime>("QSFKRQ", ref fQSFKRQ, value); }
        }
        DateTime fZHFKRQ;
        public DateTime ZHFKRQ
        {
            get { return fZHFKRQ; }
            set { SetPropertyValue<DateTime>("ZHFKRQ", ref fZHFKRQ, value); }
        }
        string fLYDJBID;
        [Size(16)]
        public string LYDJBID
        {
            get { return fLYDJBID; }
            set { SetPropertyValue<string>("LYDJBID", ref fLYDJBID, value); }
        }
        string fLYDJID;
        [Size(16)]
        public string LYDJID
        {
            get { return fLYDJID; }
            set { SetPropertyValue<string>("LYDJID", ref fLYDJID, value); }
        }
        string fLYDJMXID;
        [Size(16)]
        public string LYDJMXID
        {
            get { return fLYDJMXID; }
            set { SetPropertyValue<string>("LYDJMXID", ref fLYDJMXID, value); }
        }
        string fLYBMID;
        [Size(16)]
        public string LYBMID
        {
            get { return fLYBMID; }
            set { SetPropertyValue<string>("LYBMID", ref fLYBMID, value); }
        }
        string fSHTZMXID;
        [Size(16)]
        public string SHTZMXID
        {
            get { return fSHTZMXID; }
            set { SetPropertyValue<string>("SHTZMXID", ref fSHTZMXID, value); }
        }
        decimal fJSHJ;
        public decimal JSHJ
        {
            get { return fJSHJ; }
            set { SetPropertyValue<decimal>("JSHJ", ref fJSHJ, value); }
        }
        decimal fZKE;
        public decimal ZKE
        {
            get { return fZKE; }
            set { SetPropertyValue<decimal>("ZKE", ref fZKE, value); }
        }
        decimal fSE;
        public decimal SE
        {
            get { return fSE; }
            set { SetPropertyValue<decimal>("SE", ref fSE, value); }
        }
        decimal fWSJE;
        public decimal WSJE
        {
            get { return fWSJE; }
            set { SetPropertyValue<decimal>("WSJE", ref fWSJE, value); }
        }
        string fZT;
        [Size(4)]
        public string ZT
        {
            get { return fZT; }
            set { SetPropertyValue<string>("ZT", ref fZT, value); }
        }
        string fYZT;
        [Size(4)]
        public string YZT
        {
            get { return fYZT; }
            set { SetPropertyValue<string>("YZT", ref fYZT, value); }
        }
        string fBZ;
        [Size(50)]
        public string BZ
        {
            get { return fBZ; }
            set { SetPropertyValue<string>("BZ", ref fBZ, value); }
        }
        decimal fDJ;
        public decimal DJ
        {
            get { return fDJ; }
            set { SetPropertyValue<decimal>("DJ", ref fDJ, value); }
        }
        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }

        string fCGSHDH;
        [Size(22)]
        public string CGSHDH
        {
            get { return fCGSHDH; }
            set { SetPropertyValue<string>("CGSHDH", ref fCGSHDH, value); }
        }

        string fPM;
        [Size(100)]
        public string PM
        {
            get { return fPM; }
            set { SetPropertyValue<string>("PM", ref fPM, value); }
        }

        string fSPBH;
        [Size(16)]
        public string SPBH
        {
            get { return fSPBH; }
            set { SetPropertyValue<string>("SPBH", ref fSPBH, value); }
        }

        public VIEW_JT_G_CGSHMX(Session session) : base(session) { }
        public VIEW_JT_G_CGSHMX() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class VIEW_JT_G_CGSH_CCDMX : XPLiteObject
    {
        string fCCDMXID;
        [Key]
        [Size(16)]
        public string CCDMXID
        {
            get { return fCCDMXID; }
            set { SetPropertyValue<string>("CCDMXID", ref fCCDMXID, value); }
        }
        string fCCDH;
        [Size(22)]
        public string CCDH
        {
            get { return fCCDH; }
            set { SetPropertyValue<string>("CCDH", ref fCCDH, value); }
        }
        string fSPBH;
        [Size(16)]
        public string SPBH
        {
            get { return fSPBH; }
            set { SetPropertyValue<string>("SPBH", ref fSPBH, value); }
        }
        string fPM;
        [Size(100)]
        public string PM
        {
            get { return fPM; }
            set { SetPropertyValue<string>("PM", ref fPM, value); }
        }
        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }
        string fCCDID;
        [Size(16)]
        public string CCDID
        {
            get { return fCCDID; }
            set { SetPropertyValue<string>("CCDID", ref fCCDID, value); }
        }
        string fSPXXID;
        [Size(16)]
        public string SPXXID
        {
            get { return fSPXXID; }
            set { SetPropertyValue<string>("SPXXID", ref fSPXXID, value); }
        }
        string fZDDM;
        [Size(15)]
        public string ZDDM
        {
            get { return fZDDM; }
            set { SetPropertyValue<string>("ZDDM", ref fZDDM, value); }
        }
        decimal fDJ;
        public decimal DJ
        {
            get { return fDJ; }
            set { SetPropertyValue<decimal>("DJ", ref fDJ, value); }
        }
        decimal fSJ;
        public decimal SJ
        {
            get { return fSJ; }
            set { SetPropertyValue<decimal>("SJ", ref fSJ, value); }
        }
        decimal fZK;
        public decimal ZK
        {
            get { return fZK; }
            set { SetPropertyValue<decimal>("ZK", ref fZK, value); }
        }
        long fCCSL;
        public long CCSL
        {
            get { return fCCSL; }
            set { SetPropertyValue<long>("CCSL", ref fCCSL, value); }
        }
        decimal fCCSY;
        public decimal CCSY
        {
            get { return fCCSY; }
            set { SetPropertyValue<decimal>("CCSY", ref fCCSY, value); }
        }
        decimal fCCMY;
        public decimal CCMY
        {
            get { return fCCMY; }
            set { SetPropertyValue<decimal>("CCMY", ref fCCMY, value); }
        }
        string fLYDJBID;
        [Size(16)]
        public string LYDJBID
        {
            get { return fLYDJBID; }
            set { SetPropertyValue<string>("LYDJBID", ref fLYDJBID, value); }
        }
        string fLYDJID;
        [Size(16)]
        public string LYDJID
        {
            get { return fLYDJID; }
            set { SetPropertyValue<string>("LYDJID", ref fLYDJID, value); }
        }
        string fLYBMID;
        [Size(16)]
        public string LYBMID
        {
            get { return fLYBMID; }
            set { SetPropertyValue<string>("LYBMID", ref fLYBMID, value); }
        }
        string fLYDJMXID;
        [Size(16)]
        public string LYDJMXID
        {
            get { return fLYDJMXID; }
            set { SetPropertyValue<string>("LYDJMXID", ref fLYDJMXID, value); }
        }
        string fZT;
        [Size(4)]
        public string ZT
        {
            get { return fZT; }
            set { SetPropertyValue<string>("ZT", ref fZT, value); }
        }
        string fYZT;
        [Size(4)]
        public string YZT
        {
            get { return fYZT; }
            set { SetPropertyValue<string>("YZT", ref fYZT, value); }
        }
        string fCCYY;
        [Size(500)]
        public string CCYY
        {
            get { return fCCYY; }
            set { SetPropertyValue<string>("CCYY", ref fCCYY, value); }
        }
        public VIEW_JT_G_CGSH_CCDMX(Session session) : base(session) { }
        public VIEW_JT_G_CGSH_CCDMX() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class VIEW_JT_C_SHHZD : XPLiteObject
    {
        string fSHHZDID;
        [Key]
        [Size(16)]
        public string SHHZDID
        {
            get { return fSHHZDID; }
            set { SetPropertyValue<string>("SHHZDID", ref fSHHZDID, value); }
        }
        string fSTATUSMC;
        [Size(16)]
        public string STATUSMC
        {
            get { return fSTATUSMC; }
            set { SetPropertyValue<string>("STATUSMC", ref fSTATUSMC, value); }
        }
        string fSHHZDH;
        [Size(22)]
        public string SHHZDH
        {
            get { return fSHHZDH; }
            set { SetPropertyValue<string>("SHHZDH", ref fSHHZDH, value); }
        }
        string fCGBMMC;
        [Size(100)]
        public string CGBMMC
        {
            get { return fCGBMMC; }
            set { SetPropertyValue<string>("CGBMMC", ref fCGBMMC, value); }
        }
        string fYWBMID;
        [Size(16)]
        public string YWBMID
        {
            get { return fYWBMID; }
            set { SetPropertyValue<string>("YWBMID", ref fYWBMID, value); }
        }
        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }
        long fFXFLSL1;
        public long FXFLSL1
        {
            get { return fFXFLSL1; }
            set { SetPropertyValue<long>("FXFLSL1", ref fFXFLSL1, value); }
        }
        decimal fFXFLJE1;
        public decimal FXFLJE1
        {
            get { return fFXFLJE1; }
            set { SetPropertyValue<decimal>("FXFLJE1", ref fFXFLJE1, value); }
        }
        long fFXFLSL2;
        public long FXFLSL2
        {
            get { return fFXFLSL2; }
            set { SetPropertyValue<long>("FXFLSL2", ref fFXFLSL2, value); }
        }
        decimal fFXFLJE2;
        public decimal FXFLJE2
        {
            get { return fFXFLJE2; }
            set { SetPropertyValue<decimal>("FXFLJE2", ref fFXFLJE2, value); }
        }
        long fFXFLSL3;
        public long FXFLSL3
        {
            get { return fFXFLSL3; }
            set { SetPropertyValue<long>("FXFLSL3", ref fFXFLSL3, value); }
        }
        decimal fFXFLJE3;
        public decimal FXFLJE3
        {
            get { return fFXFLJE3; }
            set { SetPropertyValue<decimal>("FXFLJE3", ref fFXFLJE3, value); }
        }
        long fFXFLSL4;
        public long FXFLSL4
        {
            get { return fFXFLSL4; }
            set { SetPropertyValue<long>("FXFLSL4", ref fFXFLSL4, value); }
        }
        decimal fFXFLJE4;
        public decimal FXFLJE4
        {
            get { return fFXFLJE4; }
            set { SetPropertyValue<decimal>("FXFLJE4", ref fFXFLJE4, value); }
        }
        long fFXFLSL5;
        public long FXFLSL5
        {
            get { return fFXFLSL5; }
            set { SetPropertyValue<long>("FXFLSL5", ref fFXFLSL5, value); }
        }
        decimal fFXFLJE5;
        public decimal FXFLJE5
        {
            get { return fFXFLJE5; }
            set { SetPropertyValue<decimal>("FXFLJE5", ref fFXFLJE5, value); }
        }
        long fFXFLSL6;
        public long FXFLSL6
        {
            get { return fFXFLSL6; }
            set { SetPropertyValue<long>("FXFLSL6", ref fFXFLSL6, value); }
        }
        decimal fFXFLJE6;
        public decimal FXFLJE6
        {
            get { return fFXFLJE6; }
            set { SetPropertyValue<decimal>("FXFLJE6", ref fFXFLJE6, value); }
        }
        long fFXFLSL7;
        public long FXFLSL7
        {
            get { return fFXFLSL7; }
            set { SetPropertyValue<long>("FXFLSL7", ref fFXFLSL7, value); }
        }
        decimal fFXFLJE7;
        public decimal FXFLJE7
        {
            get { return fFXFLJE7; }
            set { SetPropertyValue<decimal>("FXFLJE7", ref fFXFLJE7, value); }
        }
        long fFXFLSL8;
        public long FXFLSL8
        {
            get { return fFXFLSL8; }
            set { SetPropertyValue<long>("FXFLSL8", ref fFXFLSL8, value); }
        }
        decimal fFXFLJE8;
        public decimal FXFLJE8
        {
            get { return fFXFLJE8; }
            set { SetPropertyValue<decimal>("FXFLJE8", ref fFXFLJE8, value); }
        }
        long fFXFLSL9;
        public long FXFLSL9
        {
            get { return fFXFLSL9; }
            set { SetPropertyValue<long>("FXFLSL9", ref fFXFLSL9, value); }
        }
        decimal fFXFLJE9;
        public decimal FXFLJE9
        {
            get { return fFXFLJE9; }
            set { SetPropertyValue<decimal>("FXFLJE9", ref fFXFLJE9, value); }
        }
        long fFXFLSL10;
        public long FXFLSL10
        {
            get { return fFXFLSL10; }
            set { SetPropertyValue<long>("FXFLSL10", ref fFXFLSL10, value); }
        }
        decimal fFXFLJE10;
        public decimal FXFLJE10
        {
            get { return fFXFLJE10; }
            set { SetPropertyValue<decimal>("FXFLJE10", ref fFXFLJE10, value); }
        }
        long fHJSL;
        public long HJSL
        {
            get { return fHJSL; }
            set { SetPropertyValue<long>("HJSL", ref fHJSL, value); }
        }
        decimal fHJJE;
        public decimal HJJE
        {
            get { return fHJJE; }
            set { SetPropertyValue<decimal>("HJJE", ref fHJJE, value); }
        }
        long fJXCAJSL;
        public long JXCAJSL
        {
            get { return fJXCAJSL; }
            set { SetPropertyValue<long>("JXCAJSL", ref fJXCAJSL, value); }
        }
        decimal fJXCJJE;
        public decimal JXCJJE
        {
            get { return fJXCJJE; }
            set { SetPropertyValue<decimal>("JXCJJE", ref fJXCJJE, value); }
        }
        decimal fJSHJ;
        public decimal JSHJ
        {
            get { return fJSHJ; }
            set { SetPropertyValue<decimal>("JSHJ", ref fJSHJ, value); }
        }
        decimal fWSJE;
        public decimal WSJE
        {
            get { return fWSJE; }
            set { SetPropertyValue<decimal>("WSJE", ref fWSJE, value); }
        }
        decimal fSE;
        public decimal SE
        {
            get { return fSE; }
            set { SetPropertyValue<decimal>("SE", ref fSE, value); }
        }
        DateTime fZDRQ;
        public DateTime ZDRQ
        {
            get { return fZDRQ; }
            set { SetPropertyValue<DateTime>("ZDRQ", ref fZDRQ, value); }
        }
        DateTime fJSQSRQ;
        public DateTime JSQSRQ
        {
            get { return fJSQSRQ; }
            set { SetPropertyValue<DateTime>("JSQSRQ", ref fJSQSRQ, value); }
        }
        DateTime fJSZHRQ;
        public DateTime JSZHRQ
        {
            get { return fJSZHRQ; }
            set { SetPropertyValue<DateTime>("JSZHRQ", ref fJSZHRQ, value); }
        }
        string fZT;
        [Size(4)]
        public string ZT
        {
            get { return fZT; }
            set { SetPropertyValue<string>("ZT", ref fZT, value); }
        }
        string fYZT;
        [Size(4)]
        public string YZT
        {
            get { return fYZT; }
            set { SetPropertyValue<string>("YZT", ref fYZT, value); }
        }
        string fBZ;
        public string BZ
        {
            get { return fBZ; }
            set { SetPropertyValue<string>("BZ", ref fBZ, value); }
        }
        DateTime fCZRQ;
        public DateTime CZRQ
        {
            get { return fCZRQ; }
            set { SetPropertyValue<DateTime>("CZRQ", ref fCZRQ, value); }
        }
        string fCZYID;
        [Size(16)]
        public string CZYID
        {
            get { return fCZYID; }
            set { SetPropertyValue<string>("CZYID", ref fCZYID, value); }
        }
        string fCZYXM;
        [Size(16)]
        public string CZYXM
        {
            get { return fCZYXM; }
            set { SetPropertyValue<string>("CZYXM", ref fCZYXM, value); }
        }
        public VIEW_JT_C_SHHZD(Session session) : base(session) { }
        public VIEW_JT_C_SHHZD() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class VIEW_JT_C_SHHZDMX : XPLiteObject
    {
        string fSHHZDMXID;
        [Key]
        [Size(16)]
        public string SHHZDMXID
        {
            get { return fSHHZDMXID; }
            set { SetPropertyValue<string>("SHHZDMXID", ref fSHHZDMXID, value); }
        }
        string fSHHZDID;
        [Size(16)]
        public string SHHZDID
        {
            get { return fSHHZDID; }
            set { SetPropertyValue<string>("SHHZDID", ref fSHHZDID, value); }
        }
        string fCGJSDID;
        [Size(16)]
        public string CGJSDID
        {
            get { return fCGJSDID; }
            set { SetPropertyValue<string>("CGJSDID", ref fCGJSDID, value); }
        }
        string fSHHZDH;
        [Size(22)]
        public string SHHZDH
        {
            get { return fSHHZDH; }
            set { SetPropertyValue<string>("SHHZDH", ref fSHHZDH, value); }
        }
        string fCGSHDH;
        [Size(22)]
        public string CGSHDH
        {
            get { return fCGSHDH; }
            set { SetPropertyValue<string>("CGSHDH", ref fCGSHDH, value); }
        }
        long fFXFLSL1;
        public long FXFLSL1
        {
            get { return fFXFLSL1; }
            set { SetPropertyValue<long>("FXFLSL1", ref fFXFLSL1, value); }
        }
        decimal fFXFLJE1;
        public decimal FXFLJE1
        {
            get { return fFXFLJE1; }
            set { SetPropertyValue<decimal>("FXFLJE1", ref fFXFLJE1, value); }
        }
        long fFXFLSL2;
        public long FXFLSL2
        {
            get { return fFXFLSL2; }
            set { SetPropertyValue<long>("FXFLSL2", ref fFXFLSL2, value); }
        }
        decimal fFXFLJE2;
        public decimal FXFLJE2
        {
            get { return fFXFLJE2; }
            set { SetPropertyValue<decimal>("FXFLJE2", ref fFXFLJE2, value); }
        }
        long fFXFLSL3;
        public long FXFLSL3
        {
            get { return fFXFLSL3; }
            set { SetPropertyValue<long>("FXFLSL3", ref fFXFLSL3, value); }
        }
        decimal fFXFLJE3;
        public decimal FXFLJE3
        {
            get { return fFXFLJE3; }
            set { SetPropertyValue<decimal>("FXFLJE3", ref fFXFLJE3, value); }
        }
        long fFXFLSL4;
        public long FXFLSL4
        {
            get { return fFXFLSL4; }
            set { SetPropertyValue<long>("FXFLSL4", ref fFXFLSL4, value); }
        }
        decimal fFXFLJE4;
        public decimal FXFLJE4
        {
            get { return fFXFLJE4; }
            set { SetPropertyValue<decimal>("FXFLJE4", ref fFXFLJE4, value); }
        }
        long fFXFLSL5;
        public long FXFLSL5
        {
            get { return fFXFLSL5; }
            set { SetPropertyValue<long>("FXFLSL5", ref fFXFLSL5, value); }
        }
        decimal fFXFLJE5;
        public decimal FXFLJE5
        {
            get { return fFXFLJE5; }
            set { SetPropertyValue<decimal>("FXFLJE5", ref fFXFLJE5, value); }
        }
        long fFXFLSL6;
        public long FXFLSL6
        {
            get { return fFXFLSL6; }
            set { SetPropertyValue<long>("FXFLSL6", ref fFXFLSL6, value); }
        }
        decimal fFXFLJE6;
        public decimal FXFLJE6
        {
            get { return fFXFLJE6; }
            set { SetPropertyValue<decimal>("FXFLJE6", ref fFXFLJE6, value); }
        }
        long fFXFLSL7;
        public long FXFLSL7
        {
            get { return fFXFLSL7; }
            set { SetPropertyValue<long>("FXFLSL7", ref fFXFLSL7, value); }
        }
        decimal fFXFLJE7;
        public decimal FXFLJE7
        {
            get { return fFXFLJE7; }
            set { SetPropertyValue<decimal>("FXFLJE7", ref fFXFLJE7, value); }
        }
        long fFXFLSL8;
        public long FXFLSL8
        {
            get { return fFXFLSL8; }
            set { SetPropertyValue<long>("FXFLSL8", ref fFXFLSL8, value); }
        }
        decimal fFXFLJE8;
        public decimal FXFLJE8
        {
            get { return fFXFLJE8; }
            set { SetPropertyValue<decimal>("FXFLJE8", ref fFXFLJE8, value); }
        }
        long fFXFLSL9;
        public long FXFLSL9
        {
            get { return fFXFLSL9; }
            set { SetPropertyValue<long>("FXFLSL9", ref fFXFLSL9, value); }
        }
        decimal fFXFLJE9;
        public decimal FXFLJE9
        {
            get { return fFXFLJE9; }
            set { SetPropertyValue<decimal>("FXFLJE9", ref fFXFLJE9, value); }
        }
        long fFXFLSL10;
        public long FXFLSL10
        {
            get { return fFXFLSL10; }
            set { SetPropertyValue<long>("FXFLSL10", ref fFXFLSL10, value); }
        }
        decimal fFXFLJE10;
        public decimal FXFLJE10
        {
            get { return fFXFLJE10; }
            set { SetPropertyValue<decimal>("FXFLJE10", ref fFXFLJE10, value); }
        }
        long fHJSL;
        public long HJSL
        {
            get { return fHJSL; }
            set { SetPropertyValue<long>("HJSL", ref fHJSL, value); }
        }
        decimal fHJJE;
        public decimal HJJE
        {
            get { return fHJJE; }
            set { SetPropertyValue<decimal>("HJJE", ref fHJJE, value); }
        }
        long fJXCAJSL;
        public long JXCAJSL
        {
            get { return fJXCAJSL; }
            set { SetPropertyValue<long>("JXCAJSL", ref fJXCAJSL, value); }
        }
        decimal fJXCJJE;
        public decimal JXCJJE
        {
            get { return fJXCJJE; }
            set { SetPropertyValue<decimal>("JXCJJE", ref fJXCJJE, value); }
        }
        decimal fJSHJ;
        public decimal JSHJ
        {
            get { return fJSHJ; }
            set { SetPropertyValue<decimal>("JSHJ", ref fJSHJ, value); }
        }
        decimal fWSJE;
        public decimal WSJE
        {
            get { return fWSJE; }
            set { SetPropertyValue<decimal>("WSJE", ref fWSJE, value); }
        }
        decimal fSE;
        public decimal SE
        {
            get { return fSE; }
            set { SetPropertyValue<decimal>("SE", ref fSE, value); }
        }
        DateTime fZDRQ;
        public DateTime ZDRQ
        {
            get { return fZDRQ; }
            set { SetPropertyValue<DateTime>("ZDRQ", ref fZDRQ, value); }
        }
        string fBZ;
        public string BZ
        {
            get { return fBZ; }
            set { SetPropertyValue<string>("BZ", ref fBZ, value); }
        }
        string fCGSHID;
        [Size(16)]
        public string CGSHID
        {
            get { return fCGSHID; }
            set { SetPropertyValue<string>("CGSHID", ref fCGSHID, value); }
        }
        string fSJLX;
        [Size(4)]
        public string SJLX
        {
            get { return fSJLX; }
            set { SetPropertyValue<string>("SJLX", ref fSJLX, value); }
        }
        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }
        public VIEW_JT_C_SHHZDMX(Session session) : base(session) { }
        public VIEW_JT_C_SHHZDMX() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class VIEW_JC_C_SHHZD : XPLiteObject
    {
        string fSHHZDID;
        [Key]
        [Size(16)]
        public string SHHZDID
        {
            get { return fSHHZDID; }
            set { SetPropertyValue<string>("SHHZDID", ref fSHHZDID, value); }
        }
        string fSTATUSMC;
        [Size(16)]
        public string STATUSMC
        {
            get { return fSTATUSMC; }
            set { SetPropertyValue<string>("STATUSMC", ref fSTATUSMC, value); }
        }
        string fSHHZDH;
        [Size(22)]
        public string SHHZDH
        {
            get { return fSHHZDH; }
            set { SetPropertyValue<string>("SHHZDH", ref fSHHZDH, value); }
        }
        string fCGBMMC;
        [Size(100)]
        public string CGBMMC
        {
            get { return fCGBMMC; }
            set { SetPropertyValue<string>("CGBMMC", ref fCGBMMC, value); }
        }
        string fYWBMID;
        [Size(16)]
        public string YWBMID
        {
            get { return fYWBMID; }
            set { SetPropertyValue<string>("YWBMID", ref fYWBMID, value); }
        }
        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }
        long fFXFLSL1;
        public long FXFLSL1
        {
            get { return fFXFLSL1; }
            set { SetPropertyValue<long>("FXFLSL1", ref fFXFLSL1, value); }
        }
        decimal fFXFLJE1;
        public decimal FXFLJE1
        {
            get { return fFXFLJE1; }
            set { SetPropertyValue<decimal>("FXFLJE1", ref fFXFLJE1, value); }
        }
        long fFXFLSL2;
        public long FXFLSL2
        {
            get { return fFXFLSL2; }
            set { SetPropertyValue<long>("FXFLSL2", ref fFXFLSL2, value); }
        }
        decimal fFXFLJE2;
        public decimal FXFLJE2
        {
            get { return fFXFLJE2; }
            set { SetPropertyValue<decimal>("FXFLJE2", ref fFXFLJE2, value); }
        }
        long fFXFLSL3;
        public long FXFLSL3
        {
            get { return fFXFLSL3; }
            set { SetPropertyValue<long>("FXFLSL3", ref fFXFLSL3, value); }
        }
        decimal fFXFLJE3;
        public decimal FXFLJE3
        {
            get { return fFXFLJE3; }
            set { SetPropertyValue<decimal>("FXFLJE3", ref fFXFLJE3, value); }
        }
        long fFXFLSL4;
        public long FXFLSL4
        {
            get { return fFXFLSL4; }
            set { SetPropertyValue<long>("FXFLSL4", ref fFXFLSL4, value); }
        }
        decimal fFXFLJE4;
        public decimal FXFLJE4
        {
            get { return fFXFLJE4; }
            set { SetPropertyValue<decimal>("FXFLJE4", ref fFXFLJE4, value); }
        }
        long fFXFLSL5;
        public long FXFLSL5
        {
            get { return fFXFLSL5; }
            set { SetPropertyValue<long>("FXFLSL5", ref fFXFLSL5, value); }
        }
        decimal fFXFLJE5;
        public decimal FXFLJE5
        {
            get { return fFXFLJE5; }
            set { SetPropertyValue<decimal>("FXFLJE5", ref fFXFLJE5, value); }
        }
        long fFXFLSL6;
        public long FXFLSL6
        {
            get { return fFXFLSL6; }
            set { SetPropertyValue<long>("FXFLSL6", ref fFXFLSL6, value); }
        }
        decimal fFXFLJE6;
        public decimal FXFLJE6
        {
            get { return fFXFLJE6; }
            set { SetPropertyValue<decimal>("FXFLJE6", ref fFXFLJE6, value); }
        }
        long fFXFLSL7;
        public long FXFLSL7
        {
            get { return fFXFLSL7; }
            set { SetPropertyValue<long>("FXFLSL7", ref fFXFLSL7, value); }
        }
        decimal fFXFLJE7;
        public decimal FXFLJE7
        {
            get { return fFXFLJE7; }
            set { SetPropertyValue<decimal>("FXFLJE7", ref fFXFLJE7, value); }
        }
        long fFXFLSL8;
        public long FXFLSL8
        {
            get { return fFXFLSL8; }
            set { SetPropertyValue<long>("FXFLSL8", ref fFXFLSL8, value); }
        }
        decimal fFXFLJE8;
        public decimal FXFLJE8
        {
            get { return fFXFLJE8; }
            set { SetPropertyValue<decimal>("FXFLJE8", ref fFXFLJE8, value); }
        }
        long fFXFLSL9;
        public long FXFLSL9
        {
            get { return fFXFLSL9; }
            set { SetPropertyValue<long>("FXFLSL9", ref fFXFLSL9, value); }
        }
        decimal fFXFLJE9;
        public decimal FXFLJE9
        {
            get { return fFXFLJE9; }
            set { SetPropertyValue<decimal>("FXFLJE9", ref fFXFLJE9, value); }
        }
        long fFXFLSL10;
        public long FXFLSL10
        {
            get { return fFXFLSL10; }
            set { SetPropertyValue<long>("FXFLSL10", ref fFXFLSL10, value); }
        }
        decimal fFXFLJE10;
        public decimal FXFLJE10
        {
            get { return fFXFLJE10; }
            set { SetPropertyValue<decimal>("FXFLJE10", ref fFXFLJE10, value); }
        }
        long fHJSL;
        public long HJSL
        {
            get { return fHJSL; }
            set { SetPropertyValue<long>("HJSL", ref fHJSL, value); }
        }
        decimal fHJJE;
        public decimal HJJE
        {
            get { return fHJJE; }
            set { SetPropertyValue<decimal>("HJJE", ref fHJJE, value); }
        }
        long fJXCAJSL;
        public long JXCAJSL
        {
            get { return fJXCAJSL; }
            set { SetPropertyValue<long>("JXCAJSL", ref fJXCAJSL, value); }
        }
        decimal fJXCJJE;
        public decimal JXCJJE
        {
            get { return fJXCJJE; }
            set { SetPropertyValue<decimal>("JXCJJE", ref fJXCJJE, value); }
        }
        decimal fJSHJ;
        public decimal JSHJ
        {
            get { return fJSHJ; }
            set { SetPropertyValue<decimal>("JSHJ", ref fJSHJ, value); }
        }
        decimal fWSJE;
        public decimal WSJE
        {
            get { return fWSJE; }
            set { SetPropertyValue<decimal>("WSJE", ref fWSJE, value); }
        }
        decimal fSE;
        public decimal SE
        {
            get { return fSE; }
            set { SetPropertyValue<decimal>("SE", ref fSE, value); }
        }
        DateTime fZDRQ;
        public DateTime ZDRQ
        {
            get { return fZDRQ; }
            set { SetPropertyValue<DateTime>("ZDRQ", ref fZDRQ, value); }
        }
        DateTime fJSQSRQ;
        public DateTime JSQSRQ
        {
            get { return fJSQSRQ; }
            set { SetPropertyValue<DateTime>("JSQSRQ", ref fJSQSRQ, value); }
        }
        DateTime fJSZHRQ;
        public DateTime JSZHRQ
        {
            get { return fJSZHRQ; }
            set { SetPropertyValue<DateTime>("JSZHRQ", ref fJSZHRQ, value); }
        }
        string fZT;
        [Size(4)]
        public string ZT
        {
            get { return fZT; }
            set { SetPropertyValue<string>("ZT", ref fZT, value); }
        }
        string fYZT;
        [Size(4)]
        public string YZT
        {
            get { return fYZT; }
            set { SetPropertyValue<string>("YZT", ref fYZT, value); }
        }
        string fBZ;
        public string BZ
        {
            get { return fBZ; }
            set { SetPropertyValue<string>("BZ", ref fBZ, value); }
        }
        DateTime fCZRQ;
        public DateTime CZRQ
        {
            get { return fCZRQ; }
            set { SetPropertyValue<DateTime>("CZRQ", ref fCZRQ, value); }
        }
        string fCZYID;
        [Size(16)]
        public string CZYID
        {
            get { return fCZYID; }
            set { SetPropertyValue<string>("CZYID", ref fCZYID, value); }
        }
        string fCZYXM;
        [Size(16)]
        public string CZYXM
        {
            get { return fCZYXM; }
            set { SetPropertyValue<string>("CZYXM", ref fCZYXM, value); }
        }
        public VIEW_JC_C_SHHZD(Session session) : base(session) { }
        public VIEW_JC_C_SHHZD() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class VIEW_JC_C_SHHZDMX : XPLiteObject
    {
        string fSHHZDMXID;
        [Key]
        [Size(16)]
        public string SHHZDMXID
        {
            get { return fSHHZDMXID; }
            set { SetPropertyValue<string>("SHHZDMXID", ref fSHHZDMXID, value); }
        }
        string fSHHZDID;
        [Size(16)]
        public string SHHZDID
        {
            get { return fSHHZDID; }
            set { SetPropertyValue<string>("SHHZDID", ref fSHHZDID, value); }
        }
        string fCGJSDID;
        [Size(16)]
        public string CGJSDID
        {
            get { return fCGJSDID; }
            set { SetPropertyValue<string>("CGJSDID", ref fCGJSDID, value); }
        }
        string fSHHZDH;
        [Size(22)]
        public string SHHZDH
        {
            get { return fSHHZDH; }
            set { SetPropertyValue<string>("SHHZDH", ref fSHHZDH, value); }
        }
        string fCGSHDH;
        [Size(22)]
        public string CGSHDH
        {
            get { return fCGSHDH; }
            set { SetPropertyValue<string>("CGSHDH", ref fCGSHDH, value); }
        }
        long fFXFLSL1;
        public long FXFLSL1
        {
            get { return fFXFLSL1; }
            set { SetPropertyValue<long>("FXFLSL1", ref fFXFLSL1, value); }
        }
        decimal fFXFLJE1;
        public decimal FXFLJE1
        {
            get { return fFXFLJE1; }
            set { SetPropertyValue<decimal>("FXFLJE1", ref fFXFLJE1, value); }
        }
        long fFXFLSL2;
        public long FXFLSL2
        {
            get { return fFXFLSL2; }
            set { SetPropertyValue<long>("FXFLSL2", ref fFXFLSL2, value); }
        }
        decimal fFXFLJE2;
        public decimal FXFLJE2
        {
            get { return fFXFLJE2; }
            set { SetPropertyValue<decimal>("FXFLJE2", ref fFXFLJE2, value); }
        }
        long fFXFLSL3;
        public long FXFLSL3
        {
            get { return fFXFLSL3; }
            set { SetPropertyValue<long>("FXFLSL3", ref fFXFLSL3, value); }
        }
        decimal fFXFLJE3;
        public decimal FXFLJE3
        {
            get { return fFXFLJE3; }
            set { SetPropertyValue<decimal>("FXFLJE3", ref fFXFLJE3, value); }
        }
        long fFXFLSL4;
        public long FXFLSL4
        {
            get { return fFXFLSL4; }
            set { SetPropertyValue<long>("FXFLSL4", ref fFXFLSL4, value); }
        }
        decimal fFXFLJE4;
        public decimal FXFLJE4
        {
            get { return fFXFLJE4; }
            set { SetPropertyValue<decimal>("FXFLJE4", ref fFXFLJE4, value); }
        }
        long fFXFLSL5;
        public long FXFLSL5
        {
            get { return fFXFLSL5; }
            set { SetPropertyValue<long>("FXFLSL5", ref fFXFLSL5, value); }
        }
        decimal fFXFLJE5;
        public decimal FXFLJE5
        {
            get { return fFXFLJE5; }
            set { SetPropertyValue<decimal>("FXFLJE5", ref fFXFLJE5, value); }
        }
        long fFXFLSL6;
        public long FXFLSL6
        {
            get { return fFXFLSL6; }
            set { SetPropertyValue<long>("FXFLSL6", ref fFXFLSL6, value); }
        }
        decimal fFXFLJE6;
        public decimal FXFLJE6
        {
            get { return fFXFLJE6; }
            set { SetPropertyValue<decimal>("FXFLJE6", ref fFXFLJE6, value); }
        }
        long fFXFLSL7;
        public long FXFLSL7
        {
            get { return fFXFLSL7; }
            set { SetPropertyValue<long>("FXFLSL7", ref fFXFLSL7, value); }
        }
        decimal fFXFLJE7;
        public decimal FXFLJE7
        {
            get { return fFXFLJE7; }
            set { SetPropertyValue<decimal>("FXFLJE7", ref fFXFLJE7, value); }
        }
        long fFXFLSL8;
        public long FXFLSL8
        {
            get { return fFXFLSL8; }
            set { SetPropertyValue<long>("FXFLSL8", ref fFXFLSL8, value); }
        }
        decimal fFXFLJE8;
        public decimal FXFLJE8
        {
            get { return fFXFLJE8; }
            set { SetPropertyValue<decimal>("FXFLJE8", ref fFXFLJE8, value); }
        }
        long fFXFLSL9;
        public long FXFLSL9
        {
            get { return fFXFLSL9; }
            set { SetPropertyValue<long>("FXFLSL9", ref fFXFLSL9, value); }
        }
        decimal fFXFLJE9;
        public decimal FXFLJE9
        {
            get { return fFXFLJE9; }
            set { SetPropertyValue<decimal>("FXFLJE9", ref fFXFLJE9, value); }
        }
        long fFXFLSL10;
        public long FXFLSL10
        {
            get { return fFXFLSL10; }
            set { SetPropertyValue<long>("FXFLSL10", ref fFXFLSL10, value); }
        }
        decimal fFXFLJE10;
        public decimal FXFLJE10
        {
            get { return fFXFLJE10; }
            set { SetPropertyValue<decimal>("FXFLJE10", ref fFXFLJE10, value); }
        }
        long fHJSL;
        public long HJSL
        {
            get { return fHJSL; }
            set { SetPropertyValue<long>("HJSL", ref fHJSL, value); }
        }
        decimal fHJJE;
        public decimal HJJE
        {
            get { return fHJJE; }
            set { SetPropertyValue<decimal>("HJJE", ref fHJJE, value); }
        }
        long fJXCAJSL;
        public long JXCAJSL
        {
            get { return fJXCAJSL; }
            set { SetPropertyValue<long>("JXCAJSL", ref fJXCAJSL, value); }
        }
        decimal fJXCJJE;
        public decimal JXCJJE
        {
            get { return fJXCJJE; }
            set { SetPropertyValue<decimal>("JXCJJE", ref fJXCJJE, value); }
        }
        decimal fJSHJ;
        public decimal JSHJ
        {
            get { return fJSHJ; }
            set { SetPropertyValue<decimal>("JSHJ", ref fJSHJ, value); }
        }
        decimal fWSJE;
        public decimal WSJE
        {
            get { return fWSJE; }
            set { SetPropertyValue<decimal>("WSJE", ref fWSJE, value); }
        }
        decimal fSE;
        public decimal SE
        {
            get { return fSE; }
            set { SetPropertyValue<decimal>("SE", ref fSE, value); }
        }
        DateTime fZDRQ;
        public DateTime ZDRQ
        {
            get { return fZDRQ; }
            set { SetPropertyValue<DateTime>("ZDRQ", ref fZDRQ, value); }
        }
        string fBZ;
        public string BZ
        {
            get { return fBZ; }
            set { SetPropertyValue<string>("BZ", ref fBZ, value); }
        }
        string fCGSHID;
        [Size(16)]
        public string CGSHID
        {
            get { return fCGSHID; }
            set { SetPropertyValue<string>("CGSHID", ref fCGSHID, value); }
        }
        string fSJLX;
        [Size(4)]
        public string SJLX
        {
            get { return fSJLX; }
            set { SetPropertyValue<string>("SJLX", ref fSJLX, value); }
        }
        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }
        public VIEW_JC_C_SHHZDMX(Session session) : base(session) { }
        public VIEW_JC_C_SHHZDMX() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class VIEW_JT_G_CGSH_CCD : XPLiteObject
    {
        decimal fCCSY;
        public decimal CCSY
        {
            get { return fCCSY; }
            set { SetPropertyValue<decimal>("CCSY", ref fCCSY, value); }
        }
        decimal fCCMY;
        public decimal CCMY
        {
            get { return fCCMY; }
            set { SetPropertyValue<decimal>("CCMY", ref fCCMY, value); }
        }
        long fCCPZ;
        public long CCPZ
        {
            get { return fCCPZ; }
            set { SetPropertyValue<long>("CCPZ", ref fCCPZ, value); }
        }
        string fZT;
        [Size(4)]
        public string ZT
        {
            get { return fZT; }
            set { SetPropertyValue<string>("ZT", ref fZT, value); }
        }
        string fYZT;
        [Size(4)]
        public string YZT
        {
            get { return fYZT; }
            set { SetPropertyValue<string>("YZT", ref fYZT, value); }
        }
        string fCCDID;
        [Key]
        [Size(16)]
        public string CCDID
        {
            get { return fCCDID; }
            set { SetPropertyValue<string>("CCDID", ref fCCDID, value); }
        }
        string fCCDH;
        [Size(22)]
        public string CCDH
        {
            get { return fCCDH; }
            set { SetPropertyValue<string>("CCDH", ref fCCDH, value); }
        }
        string fBMID;
        [Size(16)]
        public string BMID
        {
            get { return fBMID; }
            set { SetPropertyValue<string>("BMID", ref fBMID, value); }
        }
        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }
        DateTime fZDRQ;
        public DateTime ZDRQ
        {
            get { return fZDRQ; }
            set { SetPropertyValue<DateTime>("ZDRQ", ref fZDRQ, value); }
        }
        string fCZYID;
        [Size(16)]
        public string CZYID
        {
            get { return fCZYID; }
            set { SetPropertyValue<string>("CZYID", ref fCZYID, value); }
        }
        DateTime fCZRQ;
        public DateTime CZRQ
        {
            get { return fCZRQ; }
            set { SetPropertyValue<DateTime>("CZRQ", ref fCZRQ, value); }
        }
        long fCCSL;
        public long CCSL
        {
            get { return fCCSL; }
            set { SetPropertyValue<long>("CCSL", ref fCCSL, value); }
        }
        string fGYSMC;
        [Size(100)]
        public string GYSMC
        {
            get { return fGYSMC; }
            set { SetPropertyValue<string>("GYSMC", ref fGYSMC, value); }
        }
        string fSTATUSMC;
        [Size(16)]
        public string STATUSMC
        {
            get { return fSTATUSMC; }
            set { SetPropertyValue<string>("STATUSMC", ref fSTATUSMC, value); }
        }
        public VIEW_JT_G_CGSH_CCD(Session session) : base(session) { }
        public VIEW_JT_G_CGSH_CCD() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class VIEW_JT_G_JTDMX : XPLiteObject
    {
        string fJTDMXID;
        [Key]
        [Size(16)]
        public string JTDMXID
        {
            get { return fJTDMXID; }
            set { SetPropertyValue<string>("JTDMXID", ref fJTDMXID, value); }
        }
        string fJTDID;
        [Size(16)]
        public string JTDID
        {
            get { return fJTDID; }
            set { SetPropertyValue<string>("JTDID", ref fJTDID, value); }
        }
        string fJTDH;
        [Size(22)]
        public string JTDH
        {
            get { return fJTDH; }
            set { SetPropertyValue<string>("JTDH", ref fJTDH, value); }
        }
        string fJHFSID;
        [Size(16)]
        public string JHFSID
        {
            get { return fJHFSID; }
            set { SetPropertyValue<string>("JHFSID", ref fJHFSID, value); }
        }
        string fSPXXID;
        [Size(16)]
        public string SPXXID
        {
            get { return fSPXXID; }
            set { SetPropertyValue<string>("SPXXID", ref fSPXXID, value); }
        }

        string fPM;
        [Size(100)]
        public string PM
        {
            get { return fPM; }
            set { SetPropertyValue<string>("PM", ref fPM, value); }
        }

        string fSPBH;
        [Size(16)]
        public string SPBH
        {
            get { return fSPBH; }
            set { SetPropertyValue<string>("SPBH", ref fSPBH, value); }
        }
        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }
        decimal fJZ;
        public decimal JZ
        {
            get { return fJZ; }
            set { SetPropertyValue<decimal>("JZ", ref fJZ, value); }
        }
        decimal fJJ;
        public decimal JJ
        {
            get { return fJJ; }
            set { SetPropertyValue<decimal>("JJ", ref fJJ, value); }
        }
        long fJTSL;
        public long JTSL
        {
            get { return fJTSL; }
            set { SetPropertyValue<long>("JTSL", ref fJTSL, value); }
        }
        decimal fJTSY;
        public decimal JTSY
        {
            get { return fJTSY; }
            set { SetPropertyValue<decimal>("JTSY", ref fJTSY, value); }
        }
        decimal fJTMY;
        public decimal JTMY
        {
            get { return fJTMY; }
            set { SetPropertyValue<decimal>("JTMY", ref fJTMY, value); }
        }
        string fLYDJBID;
        [Size(16)]
        public string LYDJBID
        {
            get { return fLYDJBID; }
            set { SetPropertyValue<string>("LYDJBID", ref fLYDJBID, value); }
        }
        string fLYDJID;
        [Size(16)]
        public string LYDJID
        {
            get { return fLYDJID; }
            set { SetPropertyValue<string>("LYDJID", ref fLYDJID, value); }
        }
        string fLYDJMXID;
        [Size(16)]
        public string LYDJMXID
        {
            get { return fLYDJMXID; }
            set { SetPropertyValue<string>("LYDJMXID", ref fLYDJMXID, value); }
        }
        string fLYBMID;
        [Size(16)]
        public string LYBMID
        {
            get { return fLYBMID; }
            set { SetPropertyValue<string>("LYBMID", ref fLYBMID, value); }
        }
        long fYFSL;
        public long YFSL
        {
            get { return fYFSL; }
            set { SetPropertyValue<long>("YFSL", ref fYFSL, value); }
        }
        decimal fYFSY;
        public decimal YFSY
        {
            get { return fYFSY; }
            set { SetPropertyValue<decimal>("YFSY", ref fYFSY, value); }
        }
        decimal fYFMY;
        public decimal YFMY
        {
            get { return fYFMY; }
            set { SetPropertyValue<decimal>("YFMY", ref fYFMY, value); }
        }
        long fZZSL;
        public long ZZSL
        {
            get { return fZZSL; }
            set { SetPropertyValue<long>("ZZSL", ref fZZSL, value); }
        }
        decimal fZZSY;
        public decimal ZZSY
        {
            get { return fZZSY; }
            set { SetPropertyValue<decimal>("ZZSY", ref fZZSY, value); }
        }
        decimal fZZMY;
        public decimal ZZMY
        {
            get { return fZZMY; }
            set { SetPropertyValue<decimal>("ZZMY", ref fZZMY, value); }
        }
        DateTime fQSZZRQ;
        public DateTime QSZZRQ
        {
            get { return fQSZZRQ; }
            set { SetPropertyValue<DateTime>("QSZZRQ", ref fQSZZRQ, value); }
        }
        DateTime fZHZZRQ;
        public DateTime ZHZZRQ
        {
            get { return fZHZZRQ; }
            set { SetPropertyValue<DateTime>("ZHZZRQ", ref fZHZZRQ, value); }
        }
        DateTime fQSFKRQ;
        public DateTime QSFKRQ
        {
            get { return fQSFKRQ; }
            set { SetPropertyValue<DateTime>("QSFKRQ", ref fQSFKRQ, value); }
        }
        DateTime fZHFKRQ;
        public DateTime ZHFKRQ
        {
            get { return fZHFKRQ; }
            set { SetPropertyValue<DateTime>("ZHFKRQ", ref fZHFKRQ, value); }
        }
        string fBMSPKFMXID;
        [Size(16)]
        public string BMSPKFMXID
        {
            get { return fBMSPKFMXID; }
            set { SetPropertyValue<string>("BMSPKFMXID", ref fBMSPKFMXID, value); }
        }
        string fGYSSPMXID;
        [Size(16)]
        public string GYSSPMXID
        {
            get { return fGYSSPMXID; }
            set { SetPropertyValue<string>("GYSSPMXID", ref fGYSSPMXID, value); }
        }
        string fZDDM;
        [Size(15)]
        public string ZDDM
        {
            get { return fZDDM; }
            set { SetPropertyValue<string>("ZDDM", ref fZDDM, value); }
        }
        decimal fJSHJ;
        public decimal JSHJ
        {
            get { return fJSHJ; }
            set { SetPropertyValue<decimal>("JSHJ", ref fJSHJ, value); }
        }
        decimal fZKE;
        public decimal ZKE
        {
            get { return fZKE; }
            set { SetPropertyValue<decimal>("ZKE", ref fZKE, value); }
        }
        decimal fSE;
        public decimal SE
        {
            get { return fSE; }
            set { SetPropertyValue<decimal>("SE", ref fSE, value); }
        }
        decimal fWSJE;
        public decimal WSJE
        {
            get { return fWSJE; }
            set { SetPropertyValue<decimal>("WSJE", ref fWSJE, value); }
        }
        string fZT;
        [Size(4)]
        public string ZT
        {
            get { return fZT; }
            set { SetPropertyValue<string>("ZT", ref fZT, value); }
        }
        string fYZT;
        [Size(16)]
        public string YZT
        {
            get { return fYZT; }
            set { SetPropertyValue<string>("YZT", ref fYZT, value); }
        }
        string fBZ;
        public string BZ
        {
            get { return fBZ; }
            set { SetPropertyValue<string>("BZ", ref fBZ, value); }
        }
        decimal fDJ;
        public decimal DJ
        {
            get { return fDJ; }
            set { SetPropertyValue<decimal>("DJ", ref fDJ, value); }
        }
        public VIEW_JT_G_JTDMX(Session session) : base(session) { }
        public VIEW_JT_G_JTDMX() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class VIEW_JT_G_JTD : XPLiteObject
    {
        string fJTDID;
        [Key]
        [Size(16)]
        public string JTDID
        {
            get { return fJTDID; }
            set { SetPropertyValue<string>("JTDID", ref fJTDID, value); }
        }
        string fSTATUSMC;
        [Size(16)]
        public string STATUSMC
        {
            get { return fSTATUSMC; }
            set { SetPropertyValue<string>("STATUSMC", ref fSTATUSMC, value); }
        }
        string fJTDH;
        [Size(22)]
        public string JTDH
        {
            get { return fJTDH; }
            set { SetPropertyValue<string>("JTDH", ref fJTDH, value); }
        }
        string fBZ;
        public string BZ
        {
            get { return fBZ; }
            set { SetPropertyValue<string>("BZ", ref fBZ, value); }
        }
        string fGYSID;
        [Size(16)]
        public string GYSID
        {
            get { return fGYSID; }
            set { SetPropertyValue<string>("GYSID", ref fGYSID, value); }
        }
        string fGYSMC;
        [Size(100)]
        public string GYSMC
        {
            get { return fGYSMC; }
            set { SetPropertyValue<string>("GYSMC", ref fGYSMC, value); }
        }
        string fJTBMID;
        [Size(16)]
        public string JTBMID
        {
            get { return fJTBMID; }
            set { SetPropertyValue<string>("JTBMID", ref fJTBMID, value); }
        }
        string fJTBMMC;
        [Size(100)]
        public string JTBMMC
        {
            get { return fJTBMMC; }
            set { SetPropertyValue<string>("JTBMMC", ref fJTBMMC, value); }
        }
        string fYWYID;
        [Size(16)]
        public string YWYID
        {
            get { return fYWYID; }
            set { SetPropertyValue<string>("YWYID", ref fYWYID, value); }
        }
        string fYWYXM;
        [Size(16)]
        public string YWYXM
        {
            get { return fYWYXM; }
            set { SetPropertyValue<string>("YWYXM", ref fYWYXM, value); }
        }
        string fSHHZDH;
        [Size(22)]
        public string SHHZDH
        {
            get { return fSHHZDH; }
            set { SetPropertyValue<string>("SHHZDH", ref fSHHZDH, value); }
        }
        DateTime fSHHZRQ;
        public DateTime SHHZRQ
        {
            get { return fSHHZRQ; }
            set { SetPropertyValue<DateTime>("SHHZRQ", ref fSHHZRQ, value); }
        }
        string fSHPZDH;
        [Size(22)]
        public string SHPZDH
        {
            get { return fSHPZDH; }
            set { SetPropertyValue<string>("SHPZDH", ref fSHPZDH, value); }
        }
        string fSHPZID;
        [Size(16)]
        public string SHPZID
        {
            get { return fSHPZID; }
            set { SetPropertyValue<string>("SHPZID", ref fSHPZID, value); }
        }

        string fSHHZDID;
        [Size(16)]
        public string SHHZDID
        {
            get { return fSHHZDID; }
            set { SetPropertyValue<string>("SHHZDID", ref fSHHZDID, value); }
        }
        DateTime fSHPZRQ;
        public DateTime SHPZRQ
        {
            get { return fSHPZRQ; }
            set { SetPropertyValue<DateTime>("SHPZRQ", ref fSHPZRQ, value); }
        }
        DateTime fZDRQ;
        public DateTime ZDRQ
        {
            get { return fZDRQ; }
            set { SetPropertyValue<DateTime>("ZDRQ", ref fZDRQ, value); }
        }
        string fYSFSID;
        [Size(16)]
        public string YSFSID
        {
            get { return fYSFSID; }
            set { SetPropertyValue<string>("YSFSID", ref fYSFSID, value); }
        }
        string fFHDWID;
        [Size(16)]
        public string FHDWID
        {
            get { return fFHDWID; }
            set { SetPropertyValue<string>("FHDWID", ref fFHDWID, value); }
        }
        string fFHDWMC;
        [Size(100)]
        public string FHDWMC
        {
            get { return fFHDWMC; }
            set { SetPropertyValue<string>("FHDWMC", ref fFHDWMC, value); }
        }
        DateTime fCZRQ;
        public DateTime CZRQ
        {
            get { return fCZRQ; }
            set { SetPropertyValue<DateTime>("CZRQ", ref fCZRQ, value); }
        }
        string fCZYID;
        [Size(16)]
        public string CZYID
        {
            get { return fCZYID; }
            set { SetPropertyValue<string>("CZYID", ref fCZYID, value); }
        }
        string fCZYXM;
        [Size(16)]
        public string CZYXM
        {
            get { return fCZYXM; }
            set { SetPropertyValue<string>("CZYXM", ref fCZYXM, value); }
        }
        long fJTPZS;
        public long JTPZS
        {
            get { return fJTPZS; }
            set { SetPropertyValue<long>("JTPZS", ref fJTPZS, value); }
        }
        long fJTZSL;
        public long JTZSL
        {
            get { return fJTZSL; }
            set { SetPropertyValue<long>("JTZSL", ref fJTZSL, value); }
        }
        decimal fJTZMY;
        public decimal JTZMY
        {
            get { return fJTZMY; }
            set { SetPropertyValue<decimal>("JTZMY", ref fJTZMY, value); }
        }
        decimal fJTZSY;
        public decimal JTZSY
        {
            get { return fJTZSY; }
            set { SetPropertyValue<decimal>("JTZSY", ref fJTZSY, value); }
        }
        long fYFSL;
        public long YFSL
        {
            get { return fYFSL; }
            set { SetPropertyValue<long>("YFSL", ref fYFSL, value); }
        }
        decimal fYFSY;
        public decimal YFSY
        {
            get { return fYFSY; }
            set { SetPropertyValue<decimal>("YFSY", ref fYFSY, value); }
        }
        decimal fYFMY;
        public decimal YFMY
        {
            get { return fYFMY; }
            set { SetPropertyValue<decimal>("YFMY", ref fYFMY, value); }
        }
        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }
        int fSL;
        public int SL
        {
            get { return fSL; }
            set { SetPropertyValue<int>("SL", ref fSL, value); }
        }
        long fZZSL;
        public long ZZSL
        {
            get { return fZZSL; }
            set { SetPropertyValue<long>("ZZSL", ref fZZSL, value); }
        }
        decimal fZZSY;
        public decimal ZZSY
        {
            get { return fZZSY; }
            set { SetPropertyValue<decimal>("ZZSY", ref fZZSY, value); }
        }
        decimal fZZMY;
        public decimal ZZMY
        {
            get { return fZZMY; }
            set { SetPropertyValue<decimal>("ZZMY", ref fZZMY, value); }
        }
        decimal fJSHJ;
        public decimal JSHJ
        {
            get { return fJSHJ; }
            set { SetPropertyValue<decimal>("JSHJ", ref fJSHJ, value); }
        }
        decimal fZKE;
        public decimal ZKE
        {
            get { return fZKE; }
            set { SetPropertyValue<decimal>("ZKE", ref fZKE, value); }
        }
        decimal fSE;
        public decimal SE
        {
            get { return fSE; }
            set { SetPropertyValue<decimal>("SE", ref fSE, value); }
        }
        decimal fWSJE;
        public decimal WSJE
        {
            get { return fWSJE; }
            set { SetPropertyValue<decimal>("WSJE", ref fWSJE, value); }
        }
        string fZT;
        [Size(4)]
        public string ZT
        {
            get { return fZT; }
            set { SetPropertyValue<string>("ZT", ref fZT, value); }
        }
        string fYZT;
        [Size(4)]
        public string YZT
        {
            get { return fYZT; }
            set { SetPropertyValue<string>("YZT", ref fYZT, value); }
        }

        string fZTMC;
        [Size(100)]
        public string ZTMC
        {
            get { return fZTMC; }
            set { SetPropertyValue<string>("ZTMC", ref fZTMC, value); }
        }
        public VIEW_JT_G_JTD(Session session) : base(session) { }
        public VIEW_JT_G_JTD() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class VIEW_JC_G_JTDMX : XPLiteObject
    {
        string fJTDMXID;
        [Key]
        [Size(16)]
        public string JTDMXID
        {
            get { return fJTDMXID; }
            set { SetPropertyValue<string>("JTDMXID", ref fJTDMXID, value); }
        }
        string fJTDID;
        [Size(16)]
        public string JTDID
        {
            get { return fJTDID; }
            set { SetPropertyValue<string>("JTDID", ref fJTDID, value); }
        }
        string fJTDH;
        [Size(22)]
        public string JTDH
        {
            get { return fJTDH; }
            set { SetPropertyValue<string>("JTDH", ref fJTDH, value); }
        }
        string fJHFSID;
        [Size(16)]
        public string JHFSID
        {
            get { return fJHFSID; }
            set { SetPropertyValue<string>("JHFSID", ref fJHFSID, value); }
        }
        string fSPXXID;
        [Size(16)]
        public string SPXXID
        {
            get { return fSPXXID; }
            set { SetPropertyValue<string>("SPXXID", ref fSPXXID, value); }
        }

        string fPM;
        [Size(100)]
        public string PM
        {
            get { return fPM; }
            set { SetPropertyValue<string>("PM", ref fPM, value); }
        }

        string fSPBH;
        [Size(16)]
        public string SPBH
        {
            get { return fSPBH; }
            set { SetPropertyValue<string>("SPBH", ref fSPBH, value); }
        }
        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }
        decimal fJZ;
        public decimal JZ
        {
            get { return fJZ; }
            set { SetPropertyValue<decimal>("JZ", ref fJZ, value); }
        }
        decimal fJJ;
        public decimal JJ
        {
            get { return fJJ; }
            set { SetPropertyValue<decimal>("JJ", ref fJJ, value); }
        }
        long fJTSL;
        public long JTSL
        {
            get { return fJTSL; }
            set { SetPropertyValue<long>("JTSL", ref fJTSL, value); }
        }
        decimal fJTSY;
        public decimal JTSY
        {
            get { return fJTSY; }
            set { SetPropertyValue<decimal>("JTSY", ref fJTSY, value); }
        }
        decimal fJTMY;
        public decimal JTMY
        {
            get { return fJTMY; }
            set { SetPropertyValue<decimal>("JTMY", ref fJTMY, value); }
        }        
        string fLYDJMXID;
        [Size(16)]
        public string LYDJMXID
        {
            get { return fLYDJMXID; }
            set { SetPropertyValue<string>("LYDJMXID", ref fLYDJMXID, value); }
        }
        string fBMSPKFMXID;
        [Size(16)]
        public string BMSPKFMXID
        {
            get { return fBMSPKFMXID; }
            set { SetPropertyValue<string>("BMSPKFMXID", ref fBMSPKFMXID, value); }
        }
        string fGYSSPMXID;
        [Size(16)]
        public string GYSSPMXID
        {
            get { return fGYSSPMXID; }
            set { SetPropertyValue<string>("GYSSPMXID", ref fGYSSPMXID, value); }
        }
        string fERPXSDMXID;
        [Size(15)]
        public string ERPXSDMXID
        {
            get { return fERPXSDMXID; }
            set { SetPropertyValue<string>("ERPXSDMXID", ref fERPXSDMXID, value); }
        }
        string fZT;
        [Size(4)]
        public string ZT
        {
            get { return fZT; }
            set { SetPropertyValue<string>("ZT", ref fZT, value); }
        }
        string fYZT;
        [Size(16)]
        public string YZT
        {
            get { return fYZT; }
            set { SetPropertyValue<string>("YZT", ref fYZT, value); }
        }
        string fBZ;
        public string BZ
        {
            get { return fBZ; }
            set { SetPropertyValue<string>("BZ", ref fBZ, value); }
        }
        decimal fDJ;
        public decimal DJ
        {
            get { return fDJ; }
            set { SetPropertyValue<decimal>("DJ", ref fDJ, value); }
        }
        public VIEW_JC_G_JTDMX(Session session) : base(session) { }
        public VIEW_JC_G_JTDMX() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class VIEW_JC_G_JTD : XPLiteObject
    {
        string fJTDID;
        [Key]
        [Size(16)]
        public string JTDID
        {
            get { return fJTDID; }
            set { SetPropertyValue<string>("JTDID", ref fJTDID, value); }
        }
        string fSTATUSMC;
        [Size(16)]
        public string STATUSMC
        {
            get { return fSTATUSMC; }
            set { SetPropertyValue<string>("STATUSMC", ref fSTATUSMC, value); }
        }
        string fJTDH;
        [Size(22)]
        public string JTDH
        {
            get { return fJTDH; }
            set { SetPropertyValue<string>("JTDH", ref fJTDH, value); }
        }
        string fBZ;
        public string BZ
        {
            get { return fBZ; }
            set { SetPropertyValue<string>("BZ", ref fBZ, value); }
        }
        string fGYSID;
        [Size(16)]
        public string GYSID
        {
            get { return fGYSID; }
            set { SetPropertyValue<string>("GYSID", ref fGYSID, value); }
        }
        string fGYSMC;
        [Size(100)]
        public string GYSMC
        {
            get { return fGYSMC; }
            set { SetPropertyValue<string>("GYSMC", ref fGYSMC, value); }
        }
        string fJTBMID;
        [Size(16)]
        public string JTBMID
        {
            get { return fJTBMID; }
            set { SetPropertyValue<string>("JTBMID", ref fJTBMID, value); }
        }
        string fJTBMMC;
        [Size(100)]
        public string JTBMMC
        {
            get { return fJTBMMC; }
            set { SetPropertyValue<string>("JTBMMC", ref fJTBMMC, value); }
        }             
        DateTime fCZRQ;
        public DateTime CZRQ
        {
            get { return fCZRQ; }
            set { SetPropertyValue<DateTime>("CZRQ", ref fCZRQ, value); }
        }
        string fCZYID;
        [Size(16)]
        public string CZYID
        {
            get { return fCZYID; }
            set { SetPropertyValue<string>("CZYID", ref fCZYID, value); }
        }
        string fCZYXM;
        [Size(16)]
        public string CZYXM
        {
            get { return fCZYXM; }
            set { SetPropertyValue<string>("CZYXM", ref fCZYXM, value); }
        }
        long fJTPZS;
        public long JTPZS
        {
            get { return fJTPZS; }
            set { SetPropertyValue<long>("JTPZS", ref fJTPZS, value); }
        }
        long fJTZSL;
        public long JTZSL
        {
            get { return fJTZSL; }
            set { SetPropertyValue<long>("JTZSL", ref fJTZSL, value); }
        }
        decimal fJTZMY;
        public decimal JTZMY
        {
            get { return fJTZMY; }
            set { SetPropertyValue<decimal>("JTZMY", ref fJTZMY, value); }
        }
        decimal fJTZSY;
        public decimal JTZSY
        {
            get { return fJTZSY; }
            set { SetPropertyValue<decimal>("JTZSY", ref fJTZSY, value); }
        }
        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }
        int fSL;
        public int SL
        {
            get { return fSL; }
            set { SetPropertyValue<int>("SL", ref fSL, value); }
        }
        string fZT;
        [Size(4)]
        public string ZT
        {
            get { return fZT; }
            set { SetPropertyValue<string>("ZT", ref fZT, value); }
        }
        string fYZT;
        [Size(4)]
        public string YZT
        {
            get { return fYZT; }
            set { SetPropertyValue<string>("YZT", ref fYZT, value); }
        }

        string fZTMC;
        [Size(100)]
        public string ZTMC
        {
            get { return fZTMC; }
            set { SetPropertyValue<string>("ZTMC", ref fZTMC, value); }
        }
        public VIEW_JC_G_JTD(Session session) : base(session) { }
        public VIEW_JC_G_JTD() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class VIEW_JT_G_JTD_CCDMX : XPLiteObject
    {
        string fCCDMXID;
        [Key]
        [Size(16)]
        public string CCDMXID
        {
            get { return fCCDMXID; }
            set { SetPropertyValue<string>("CCDMXID", ref fCCDMXID, value); }
        }
        string fCCDID;
        [Size(16)]
        public string CCDID
        {
            get { return fCCDID; }
            set { SetPropertyValue<string>("CCDID", ref fCCDID, value); }
        }
        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }
        string fSPXXID;
        [Size(16)]
        public string SPXXID
        {
            get { return fSPXXID; }
            set { SetPropertyValue<string>("SPXXID", ref fSPXXID, value); }
        }
        string fCCDH;
        [Size(22)]
        public string CCDH
        {
            get { return fCCDH; }
            set { SetPropertyValue<string>("CCDH", ref fCCDH, value); }
        }
        string fSPBH;
        [Size(16)]
        public string SPBH
        {
            get { return fSPBH; }
            set { SetPropertyValue<string>("SPBH", ref fSPBH, value); }
        }
        string fPM;
        [Size(100)]
        public string PM
        {
            get { return fPM; }
            set { SetPropertyValue<string>("PM", ref fPM, value); }
        }
        string fZDDM;
        [Size(15)]
        public string ZDDM
        {
            get { return fZDDM; }
            set { SetPropertyValue<string>("ZDDM", ref fZDDM, value); }
        }
        decimal fDJ;
        public decimal DJ
        {
            get { return fDJ; }
            set { SetPropertyValue<decimal>("DJ", ref fDJ, value); }
        }
        decimal fSJ;
        public decimal SJ
        {
            get { return fSJ; }
            set { SetPropertyValue<decimal>("SJ", ref fSJ, value); }
        }
        decimal fZK;
        public decimal ZK
        {
            get { return fZK; }
            set { SetPropertyValue<decimal>("ZK", ref fZK, value); }
        }
        long fCCSL;
        public long CCSL
        {
            get { return fCCSL; }
            set { SetPropertyValue<long>("CCSL", ref fCCSL, value); }
        }
        decimal fCCSY;
        public decimal CCSY
        {
            get { return fCCSY; }
            set { SetPropertyValue<decimal>("CCSY", ref fCCSY, value); }
        }
        decimal fCCMY;
        public decimal CCMY
        {
            get { return fCCMY; }
            set { SetPropertyValue<decimal>("CCMY", ref fCCMY, value); }
        }
        string fLYDJBID;
        [Size(16)]
        public string LYDJBID
        {
            get { return fLYDJBID; }
            set { SetPropertyValue<string>("LYDJBID", ref fLYDJBID, value); }
        }
        string fLYDJID;
        [Size(16)]
        public string LYDJID
        {
            get { return fLYDJID; }
            set { SetPropertyValue<string>("LYDJID", ref fLYDJID, value); }
        }
        string fLYBMID;
        [Size(16)]
        public string LYBMID
        {
            get { return fLYBMID; }
            set { SetPropertyValue<string>("LYBMID", ref fLYBMID, value); }
        }
        string fLYDJMXID;
        [Size(16)]
        public string LYDJMXID
        {
            get { return fLYDJMXID; }
            set { SetPropertyValue<string>("LYDJMXID", ref fLYDJMXID, value); }
        }
        string fZT;
        [Size(4)]
        public string ZT
        {
            get { return fZT; }
            set { SetPropertyValue<string>("ZT", ref fZT, value); }
        }
        string fYZT;
        [Size(4)]
        public string YZT
        {
            get { return fYZT; }
            set { SetPropertyValue<string>("YZT", ref fYZT, value); }
        }
        string fCCYY;
        [Size(500)]
        public string CCYY
        {
            get { return fCCYY; }
            set { SetPropertyValue<string>("CCYY", ref fCCYY, value); }
        }
        public VIEW_JT_G_JTD_CCDMX(Session session) : base(session) { }
        public VIEW_JT_G_JTD_CCDMX() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class VIEW_JT_G_JTD_CCD : XPLiteObject
    {
        DateTime fZDRQ;
        public DateTime ZDRQ
        {
            get { return fZDRQ; }
            set { SetPropertyValue<DateTime>("ZDRQ", ref fZDRQ, value); }
        }
        string fCZYID;
        [Size(16)]
        public string CZYID
        {
            get { return fCZYID; }
            set { SetPropertyValue<string>("CZYID", ref fCZYID, value); }
        }
        DateTime fCZRQ;
        public DateTime CZRQ
        {
            get { return fCZRQ; }
            set { SetPropertyValue<DateTime>("CZRQ", ref fCZRQ, value); }
        }
        long fCCSL;
        public long CCSL
        {
            get { return fCCSL; }
            set { SetPropertyValue<long>("CCSL", ref fCCSL, value); }
        }
        decimal fCCSY;
        public decimal CCSY
        {
            get { return fCCSY; }
            set { SetPropertyValue<decimal>("CCSY", ref fCCSY, value); }
        }
        decimal fCCMY;
        public decimal CCMY
        {
            get { return fCCMY; }
            set { SetPropertyValue<decimal>("CCMY", ref fCCMY, value); }
        }
        long fCCPZ;
        public long CCPZ
        {
            get { return fCCPZ; }
            set { SetPropertyValue<long>("CCPZ", ref fCCPZ, value); }
        }
        string fZT;
        [Size(4)]
        public string ZT
        {
            get { return fZT; }
            set { SetPropertyValue<string>("ZT", ref fZT, value); }
        }
        string fYZT;
        [Size(4)]
        public string YZT
        {
            get { return fYZT; }
            set { SetPropertyValue<string>("YZT", ref fYZT, value); }
        }
        string fCCDID;
        [Key]
        [Size(16)]
        public string CCDID
        {
            get { return fCCDID; }
            set { SetPropertyValue<string>("CCDID", ref fCCDID, value); }
        }
        string fCCDH;
        [Size(22)]
        public string CCDH
        {
            get { return fCCDH; }
            set { SetPropertyValue<string>("CCDH", ref fCCDH, value); }
        }
        string fBMID;
        [Size(16)]
        public string BMID
        {
            get { return fBMID; }
            set { SetPropertyValue<string>("BMID", ref fBMID, value); }
        }
        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }
        string fGYSMC;
        [Size(100)]
        public string GYSMC
        {
            get { return fGYSMC; }
            set { SetPropertyValue<string>("GYSMC", ref fGYSMC, value); }
        }
        string fJTBMMC;
        [Size(100)]
        public string JTBMMC
        {
            get { return fJTBMMC; }
            set { SetPropertyValue<string>("JTBMMC", ref fJTBMMC, value); }
        }
        string fSTATUSMC;
        [Size(16)]
        public string STATUSMC
        {
            get { return fSTATUSMC; }
            set { SetPropertyValue<string>("STATUSMC", ref fSTATUSMC, value); }
        }
        public VIEW_JT_G_JTD_CCD(Session session) : base(session) { }
        public VIEW_JT_G_JTD_CCD() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class VIEW_JT_C_XSHZD : XPLiteObject
    {
        string fSTATUSMC;
        [Size(16)]
        public string STATUSMC
        {
            get { return fSTATUSMC; }
            set { SetPropertyValue<string>("STATUSMC", ref fSTATUSMC, value); }
        }
        string fXSHZDID;
        [Key]
        [Size(16)]
        public string XSHZDID
        {
            get { return fXSHZDID; }
            set { SetPropertyValue<string>("XSHZDID", ref fXSHZDID, value); }
        }
        string fXSHZDH;
        [Size(22)]
        public string XSHZDH
        {
            get { return fXSHZDH; }
            set { SetPropertyValue<string>("XSHZDH", ref fXSHZDH, value); }
        }
        string fYWBMID;
        [Size(16)]
        public string YWBMID
        {
            get { return fYWBMID; }
            set { SetPropertyValue<string>("YWBMID", ref fYWBMID, value); }
        }
        string fYWBMMC;
        [Size(100)]
        public string YWBMMC
        {
            get { return fYWBMMC; }
            set { SetPropertyValue<string>("YWBMMC", ref fYWBMMC, value); }
        }
        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }
        long fFXFLSL1;
        public long FXFLSL1
        {
            get { return fFXFLSL1; }
            set { SetPropertyValue<long>("FXFLSL1", ref fFXFLSL1, value); }
        }
        decimal fFXFLJE1;
        public decimal FXFLJE1
        {
            get { return fFXFLJE1; }
            set { SetPropertyValue<decimal>("FXFLJE1", ref fFXFLJE1, value); }
        }
        long fFXFLSL2;
        public long FXFLSL2
        {
            get { return fFXFLSL2; }
            set { SetPropertyValue<long>("FXFLSL2", ref fFXFLSL2, value); }
        }
        decimal fFXFLJE2;
        public decimal FXFLJE2
        {
            get { return fFXFLJE2; }
            set { SetPropertyValue<decimal>("FXFLJE2", ref fFXFLJE2, value); }
        }
        long fFXFLSL3;
        public long FXFLSL3
        {
            get { return fFXFLSL3; }
            set { SetPropertyValue<long>("FXFLSL3", ref fFXFLSL3, value); }
        }
        decimal fFXFLJE3;
        public decimal FXFLJE3
        {
            get { return fFXFLJE3; }
            set { SetPropertyValue<decimal>("FXFLJE3", ref fFXFLJE3, value); }
        }
        long fFXFLSL4;
        public long FXFLSL4
        {
            get { return fFXFLSL4; }
            set { SetPropertyValue<long>("FXFLSL4", ref fFXFLSL4, value); }
        }
        decimal fFXFLJE4;
        public decimal FXFLJE4
        {
            get { return fFXFLJE4; }
            set { SetPropertyValue<decimal>("FXFLJE4", ref fFXFLJE4, value); }
        }
        long fFXFLSL5;
        public long FXFLSL5
        {
            get { return fFXFLSL5; }
            set { SetPropertyValue<long>("FXFLSL5", ref fFXFLSL5, value); }
        }
        decimal fFXFLJE5;
        public decimal FXFLJE5
        {
            get { return fFXFLJE5; }
            set { SetPropertyValue<decimal>("FXFLJE5", ref fFXFLJE5, value); }
        }
        long fFXFLSL6;
        public long FXFLSL6
        {
            get { return fFXFLSL6; }
            set { SetPropertyValue<long>("FXFLSL6", ref fFXFLSL6, value); }
        }
        decimal fFXFLJE6;
        public decimal FXFLJE6
        {
            get { return fFXFLJE6; }
            set { SetPropertyValue<decimal>("FXFLJE6", ref fFXFLJE6, value); }
        }
        long fFXFLSL7;
        public long FXFLSL7
        {
            get { return fFXFLSL7; }
            set { SetPropertyValue<long>("FXFLSL7", ref fFXFLSL7, value); }
        }
        decimal fFXFLJE7;
        public decimal FXFLJE7
        {
            get { return fFXFLJE7; }
            set { SetPropertyValue<decimal>("FXFLJE7", ref fFXFLJE7, value); }
        }
        long fFXFLSL8;
        public long FXFLSL8
        {
            get { return fFXFLSL8; }
            set { SetPropertyValue<long>("FXFLSL8", ref fFXFLSL8, value); }
        }
        decimal fFXFLJE8;
        public decimal FXFLJE8
        {
            get { return fFXFLJE8; }
            set { SetPropertyValue<decimal>("FXFLJE8", ref fFXFLJE8, value); }
        }
        long fFXFLSL9;
        public long FXFLSL9
        {
            get { return fFXFLSL9; }
            set { SetPropertyValue<long>("FXFLSL9", ref fFXFLSL9, value); }
        }
        decimal fFXFLJE9;
        public decimal FXFLJE9
        {
            get { return fFXFLJE9; }
            set { SetPropertyValue<decimal>("FXFLJE9", ref fFXFLJE9, value); }
        }
        long fFXFLSL10;
        public long FXFLSL10
        {
            get { return fFXFLSL10; }
            set { SetPropertyValue<long>("FXFLSL10", ref fFXFLSL10, value); }
        }
        decimal fFXFLJE10;
        public decimal FXFLJE10
        {
            get { return fFXFLJE10; }
            set { SetPropertyValue<decimal>("FXFLJE10", ref fFXFLJE10, value); }
        }
        long fHJSL;
        public long HJSL
        {
            get { return fHJSL; }
            set { SetPropertyValue<long>("HJSL", ref fHJSL, value); }
        }
        decimal fHJJE;
        public decimal HJJE
        {
            get { return fHJJE; }
            set { SetPropertyValue<decimal>("HJJE", ref fHJJE, value); }
        }
        long fXSZKSL;
        public long XSZKSL
        {
            get { return fXSZKSL; }
            set { SetPropertyValue<long>("XSZKSL", ref fXSZKSL, value); }
        }
        decimal fXSZKJE;
        public decimal XSZKJE
        {
            get { return fXSZKJE; }
            set { SetPropertyValue<decimal>("XSZKJE", ref fXSZKJE, value); }
        }
        decimal fJSHJ;
        public decimal JSHJ
        {
            get { return fJSHJ; }
            set { SetPropertyValue<decimal>("JSHJ", ref fJSHJ, value); }
        }
        decimal fWSJE;
        public decimal WSJE
        {
            get { return fWSJE; }
            set { SetPropertyValue<decimal>("WSJE", ref fWSJE, value); }
        }
        decimal fSE;
        public decimal SE
        {
            get { return fSE; }
            set { SetPropertyValue<decimal>("SE", ref fSE, value); }
        }
        DateTime fZDRQ;
        public DateTime ZDRQ
        {
            get { return fZDRQ; }
            set { SetPropertyValue<DateTime>("ZDRQ", ref fZDRQ, value); }
        }
        DateTime fJSQSRQ;
        public DateTime JSQSRQ
        {
            get { return fJSQSRQ; }
            set { SetPropertyValue<DateTime>("JSQSRQ", ref fJSQSRQ, value); }
        }
        DateTime fJSZHRQ;
        public DateTime JSZHRQ
        {
            get { return fJSZHRQ; }
            set { SetPropertyValue<DateTime>("JSZHRQ", ref fJSZHRQ, value); }
        }
        string fZT;
        [Size(4)]
        public string ZT
        {
            get { return fZT; }
            set { SetPropertyValue<string>("ZT", ref fZT, value); }
        }
        string fYZT;
        [Size(4)]
        public string YZT
        {
            get { return fYZT; }
            set { SetPropertyValue<string>("YZT", ref fYZT, value); }
        }
        string fBZ;
        public string BZ
        {
            get { return fBZ; }
            set { SetPropertyValue<string>("BZ", ref fBZ, value); }
        }
        DateTime fCZRQ;
        public DateTime CZRQ
        {
            get { return fCZRQ; }
            set { SetPropertyValue<DateTime>("CZRQ", ref fCZRQ, value); }
        }
        string fCZYID;
        [Size(16)]
        public string CZYID
        {
            get { return fCZYID; }
            set { SetPropertyValue<string>("CZYID", ref fCZYID, value); }
        }
        string fCZYXM;
        [Size(16)]
        public string CZYXM
        {
            get { return fCZYXM; }
            set { SetPropertyValue<string>("CZYXM", ref fCZYXM, value); }
        }
        public VIEW_JT_C_XSHZD(Session session) : base(session) { }
        public VIEW_JT_C_XSHZD() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class VIEW_JC_C_XSHZD : XPLiteObject
    {
        string fSTATUSMC;
        [Size(16)]
        public string STATUSMC
        {
            get { return fSTATUSMC; }
            set { SetPropertyValue<string>("STATUSMC", ref fSTATUSMC, value); }
        }
        string fXSHZDID;
        [Key]
        [Size(16)]
        public string XSHZDID
        {
            get { return fXSHZDID; }
            set { SetPropertyValue<string>("XSHZDID", ref fXSHZDID, value); }
        }
        string fXSHZDH;
        [Size(22)]
        public string XSHZDH
        {
            get { return fXSHZDH; }
            set { SetPropertyValue<string>("XSHZDH", ref fXSHZDH, value); }
        }
        string fYWBMID;
        [Size(16)]
        public string YWBMID
        {
            get { return fYWBMID; }
            set { SetPropertyValue<string>("YWBMID", ref fYWBMID, value); }
        }
        string fYWBMMC;
        [Size(100)]
        public string YWBMMC
        {
            get { return fYWBMMC; }
            set { SetPropertyValue<string>("YWBMMC", ref fYWBMMC, value); }
        }
        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }
        long fFXFLSL1;
        public long FXFLSL1
        {
            get { return fFXFLSL1; }
            set { SetPropertyValue<long>("FXFLSL1", ref fFXFLSL1, value); }
        }
        decimal fFXFLJE1;
        public decimal FXFLJE1
        {
            get { return fFXFLJE1; }
            set { SetPropertyValue<decimal>("FXFLJE1", ref fFXFLJE1, value); }
        }
        long fFXFLSL2;
        public long FXFLSL2
        {
            get { return fFXFLSL2; }
            set { SetPropertyValue<long>("FXFLSL2", ref fFXFLSL2, value); }
        }
        decimal fFXFLJE2;
        public decimal FXFLJE2
        {
            get { return fFXFLJE2; }
            set { SetPropertyValue<decimal>("FXFLJE2", ref fFXFLJE2, value); }
        }
        long fFXFLSL3;
        public long FXFLSL3
        {
            get { return fFXFLSL3; }
            set { SetPropertyValue<long>("FXFLSL3", ref fFXFLSL3, value); }
        }
        decimal fFXFLJE3;
        public decimal FXFLJE3
        {
            get { return fFXFLJE3; }
            set { SetPropertyValue<decimal>("FXFLJE3", ref fFXFLJE3, value); }
        }
        long fFXFLSL4;
        public long FXFLSL4
        {
            get { return fFXFLSL4; }
            set { SetPropertyValue<long>("FXFLSL4", ref fFXFLSL4, value); }
        }
        decimal fFXFLJE4;
        public decimal FXFLJE4
        {
            get { return fFXFLJE4; }
            set { SetPropertyValue<decimal>("FXFLJE4", ref fFXFLJE4, value); }
        }
        long fFXFLSL5;
        public long FXFLSL5
        {
            get { return fFXFLSL5; }
            set { SetPropertyValue<long>("FXFLSL5", ref fFXFLSL5, value); }
        }
        decimal fFXFLJE5;
        public decimal FXFLJE5
        {
            get { return fFXFLJE5; }
            set { SetPropertyValue<decimal>("FXFLJE5", ref fFXFLJE5, value); }
        }
        long fFXFLSL6;
        public long FXFLSL6
        {
            get { return fFXFLSL6; }
            set { SetPropertyValue<long>("FXFLSL6", ref fFXFLSL6, value); }
        }
        decimal fFXFLJE6;
        public decimal FXFLJE6
        {
            get { return fFXFLJE6; }
            set { SetPropertyValue<decimal>("FXFLJE6", ref fFXFLJE6, value); }
        }
        long fFXFLSL7;
        public long FXFLSL7
        {
            get { return fFXFLSL7; }
            set { SetPropertyValue<long>("FXFLSL7", ref fFXFLSL7, value); }
        }
        decimal fFXFLJE7;
        public decimal FXFLJE7
        {
            get { return fFXFLJE7; }
            set { SetPropertyValue<decimal>("FXFLJE7", ref fFXFLJE7, value); }
        }
        long fFXFLSL8;
        public long FXFLSL8
        {
            get { return fFXFLSL8; }
            set { SetPropertyValue<long>("FXFLSL8", ref fFXFLSL8, value); }
        }
        decimal fFXFLJE8;
        public decimal FXFLJE8
        {
            get { return fFXFLJE8; }
            set { SetPropertyValue<decimal>("FXFLJE8", ref fFXFLJE8, value); }
        }
        long fFXFLSL9;
        public long FXFLSL9
        {
            get { return fFXFLSL9; }
            set { SetPropertyValue<long>("FXFLSL9", ref fFXFLSL9, value); }
        }
        decimal fFXFLJE9;
        public decimal FXFLJE9
        {
            get { return fFXFLJE9; }
            set { SetPropertyValue<decimal>("FXFLJE9", ref fFXFLJE9, value); }
        }
        long fFXFLSL10;
        public long FXFLSL10
        {
            get { return fFXFLSL10; }
            set { SetPropertyValue<long>("FXFLSL10", ref fFXFLSL10, value); }
        }
        decimal fFXFLJE10;
        public decimal FXFLJE10
        {
            get { return fFXFLJE10; }
            set { SetPropertyValue<decimal>("FXFLJE10", ref fFXFLJE10, value); }
        }
        long fHJSL;
        public long HJSL
        {
            get { return fHJSL; }
            set { SetPropertyValue<long>("HJSL", ref fHJSL, value); }
        }
        decimal fHJJE;
        public decimal HJJE
        {
            get { return fHJJE; }
            set { SetPropertyValue<decimal>("HJJE", ref fHJJE, value); }
        }
        long fXSZKSL;
        public long XSZKSL
        {
            get { return fXSZKSL; }
            set { SetPropertyValue<long>("XSZKSL", ref fXSZKSL, value); }
        }
        decimal fXSZKJE;
        public decimal XSZKJE
        {
            get { return fXSZKJE; }
            set { SetPropertyValue<decimal>("XSZKJE", ref fXSZKJE, value); }
        }
        decimal fJSHJ;
        public decimal JSHJ
        {
            get { return fJSHJ; }
            set { SetPropertyValue<decimal>("JSHJ", ref fJSHJ, value); }
        }
        decimal fWSJE;
        public decimal WSJE
        {
            get { return fWSJE; }
            set { SetPropertyValue<decimal>("WSJE", ref fWSJE, value); }
        }
        decimal fSE;
        public decimal SE
        {
            get { return fSE; }
            set { SetPropertyValue<decimal>("SE", ref fSE, value); }
        }
        DateTime fZDRQ;
        public DateTime ZDRQ
        {
            get { return fZDRQ; }
            set { SetPropertyValue<DateTime>("ZDRQ", ref fZDRQ, value); }
        }
        DateTime fJSQSRQ;
        public DateTime JSQSRQ
        {
            get { return fJSQSRQ; }
            set { SetPropertyValue<DateTime>("JSQSRQ", ref fJSQSRQ, value); }
        }
        DateTime fJSZHRQ;
        public DateTime JSZHRQ
        {
            get { return fJSZHRQ; }
            set { SetPropertyValue<DateTime>("JSZHRQ", ref fJSZHRQ, value); }
        }
        string fZT;
        [Size(4)]
        public string ZT
        {
            get { return fZT; }
            set { SetPropertyValue<string>("ZT", ref fZT, value); }
        }
        string fYZT;
        [Size(4)]
        public string YZT
        {
            get { return fYZT; }
            set { SetPropertyValue<string>("YZT", ref fYZT, value); }
        }
        string fBZ;
        public string BZ
        {
            get { return fBZ; }
            set { SetPropertyValue<string>("BZ", ref fBZ, value); }
        }
        DateTime fCZRQ;
        public DateTime CZRQ
        {
            get { return fCZRQ; }
            set { SetPropertyValue<DateTime>("CZRQ", ref fCZRQ, value); }
        }
        string fCZYID;
        [Size(16)]
        public string CZYID
        {
            get { return fCZYID; }
            set { SetPropertyValue<string>("CZYID", ref fCZYID, value); }
        }
        string fCZYXM;
        [Size(16)]
        public string CZYXM
        {
            get { return fCZYXM; }
            set { SetPropertyValue<string>("CZYXM", ref fCZYXM, value); }
        }
        public VIEW_JC_C_XSHZD(Session session) : base(session) { }
        public VIEW_JC_C_XSHZD() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class VIEW_JT_X_XSD : XPLiteObject
    {
        string fXSDID;
        [Key]
        [Size(16)]
        public string XSDID
        {
            get { return fXSDID; }
            set { SetPropertyValue<string>("XSDID", ref fXSDID, value); }
        }
        string fSTATUSMC;
        [Size(16)]
        public string STATUSMC
        {
            get { return fSTATUSMC; }
            set { SetPropertyValue<string>("STATUSMC", ref fSTATUSMC, value); }
        }
        string fXSDH;
        [Size(22)]
        public string XSDH
        {
            get { return fXSDH; }
            set { SetPropertyValue<string>("XSDH", ref fXSDH, value); }
        }
        string fXSBMID;
        [Size(16)]
        public string XSBMID
        {
            get { return fXSBMID; }
            set { SetPropertyValue<string>("XSBMID", ref fXSBMID, value); }
        }
        string fXSBMMC;
        [Size(100)]
        public string XSBMMC
        {
            get { return fXSBMMC; }
            set { SetPropertyValue<string>("XSBMMC", ref fXSBMMC, value); }
        }
        string fWLBMMC;
        [Size(100)]
        public string WLBMMC
        {
            get { return fWLBMMC; }
            set { SetPropertyValue<string>("WLBMMC", ref fWLBMMC, value); }
        }
        string fKHMC;
        [Size(100)]
        public string KHMC
        {
            get { return fKHMC; }
            set { SetPropertyValue<string>("KHMC", ref fKHMC, value); }
        }
        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }
        string fKHID;
        [Size(16)]
        public string KHID
        {
            get { return fKHID; }
            set { SetPropertyValue<string>("KHID", ref fKHID, value); }
        }
        string fFHBMID;
        [Size(16)]
        public string FHBMID
        {
            get { return fFHBMID; }
            set { SetPropertyValue<string>("FHBMID", ref fFHBMID, value); }
        }
        string fYSFSID;
        [Size(16)]
        public string YSFSID
        {
            get { return fYSFSID; }
            set { SetPropertyValue<string>("YSFSID", ref fYSFSID, value); }
        }
        string fJSFSID;
        [Size(16)]
        public string JSFSID
        {
            get { return fJSFSID; }
            set { SetPropertyValue<string>("JSFSID", ref fJSFSID, value); }
        }
        DateTime fZDRQ;
        public DateTime ZDRQ
        {
            get { return fZDRQ; }
            set { SetPropertyValue<DateTime>("ZDRQ", ref fZDRQ, value); }
        }
        string fJSFSMC;
        [Size(80)]
        public string JSFSMC
        {
            get { return fJSFSMC; }
            set { SetPropertyValue<string>("JSFSMC", ref fJSFSMC, value); }
        }
        string fXSHZDH;
        [Size(22)]
        public string XSHZDH
        {
            get { return fXSHZDH; }
            set { SetPropertyValue<string>("XSHZDH", ref fXSHZDH, value); }
        }
        string fFHPZH;
        [Size(22)]
        public string FHPZH
        {
            get { return fFHPZH; }
            set { SetPropertyValue<string>("FHPZH", ref fFHPZH, value); }
        }
        string fCZYID;
        [Size(16)]
        public string CZYID
        {
            get { return fCZYID; }
            set { SetPropertyValue<string>("CZYID", ref fCZYID, value); }
        }
        DateTime fCZRQ;
        public DateTime CZRQ
        {
            get { return fCZRQ; }
            set { SetPropertyValue<DateTime>("CZRQ", ref fCZRQ, value); }
        }
        byte fSL;
        public byte SL
        {
            get { return fSL; }
            set { SetPropertyValue<byte>("SL", ref fSL, value); }
        }
        string fYDH;
        [Size(22)]
        public string YDH
        {
            get { return fYDH; }
            set { SetPropertyValue<string>("YDH", ref fYDH, value); }
        }
        string fSHDZ;
        [Size(80)]
        public string SHDZ
        {
            get { return fSHDZ; }
            set { SetPropertyValue<string>("SHDZ", ref fSHDZ, value); }
        }
        long fBJS;
        public long BJS
        {
            get { return fBJS; }
            set { SetPropertyValue<long>("BJS", ref fBJS, value); }
        }
        long fPZS;
        public long PZS
        {
            get { return fPZS; }
            set { SetPropertyValue<long>("PZS", ref fPZS, value); }
        }
        long fXSSL;
        public long XSSL
        {
            get { return fXSSL; }
            set { SetPropertyValue<long>("XSSL", ref fXSSL, value); }
        }
        decimal fXSSY;
        public decimal XSSY
        {
            get { return fXSSY; }
            set { SetPropertyValue<decimal>("XSSY", ref fXSSY, value); }
        }
        decimal fXSMY;
        public decimal XSMY
        {
            get { return fXSMY; }
            set { SetPropertyValue<decimal>("XSMY", ref fXSMY, value); }
        }
        decimal fJSHJ;
        public decimal JSHJ
        {
            get { return fJSHJ; }
            set { SetPropertyValue<decimal>("JSHJ", ref fJSHJ, value); }
        }
        decimal fZKE;
        public decimal ZKE
        {
            get { return fZKE; }
            set { SetPropertyValue<decimal>("ZKE", ref fZKE, value); }
        }
        decimal fSE;
        public decimal SE
        {
            get { return fSE; }
            set { SetPropertyValue<decimal>("SE", ref fSE, value); }
        }
        decimal fWSJE;
        public decimal WSJE
        {
            get { return fWSJE; }
            set { SetPropertyValue<decimal>("WSJE", ref fWSJE, value); }
        }
        long fZZSL;
        public long ZZSL
        {
            get { return fZZSL; }
            set { SetPropertyValue<long>("ZZSL", ref fZZSL, value); }
        }
        decimal fZZSY;
        public decimal ZZSY
        {
            get { return fZZSY; }
            set { SetPropertyValue<decimal>("ZZSY", ref fZZSY, value); }
        }
        decimal fZZMY;
        public decimal ZZMY
        {
            get { return fZZMY; }
            set { SetPropertyValue<decimal>("ZZMY", ref fZZMY, value); }
        }
        long fYSSL;
        public long YSSL
        {
            get { return fYSSL; }
            set { SetPropertyValue<long>("YSSL", ref fYSSL, value); }
        }
        decimal fYSSY;
        public decimal YSSY
        {
            get { return fYSSY; }
            set { SetPropertyValue<decimal>("YSSY", ref fYSSY, value); }
        }
        decimal fYSMY;
        public decimal YSMY
        {
            get { return fYSMY; }
            set { SetPropertyValue<decimal>("YSMY", ref fYSMY, value); }
        }
        string fZT;
        [Size(4)]
        public string ZT
        {
            get { return fZT; }
            set { SetPropertyValue<string>("ZT", ref fZT, value); }
        }
        string fYZT;
        [Size(4)]
        public string YZT
        {
            get { return fYZT; }
            set { SetPropertyValue<string>("YZT", ref fYZT, value); }
        }
        string fBZ;
        public string BZ
        {
            get { return fBZ; }
            set { SetPropertyValue<string>("BZ", ref fBZ, value); }
        }
        string fXSFSID;
        [Size(16)]
        public string XSFSID
        {
            get { return fXSFSID; }
            set { SetPropertyValue<string>("XSFSID", ref fXSFSID, value); }
        }
        string fGZDID;
        [Size(16)]
        public string GZDID
        {
            get { return fGZDID; }
            set { SetPropertyValue<string>("GZDID", ref fGZDID, value); }
        }
        string fFHDZ;
        [Size(80)]
        public string FHDZ
        {
            get { return fFHDZ; }
            set { SetPropertyValue<string>("FHDZ", ref fFHDZ, value); }
        }
        string fFHPZID;
        [Size(16)]
        public string FHPZID
        {
            get { return fFHPZID; }
            set { SetPropertyValue<string>("FHPZID", ref fFHPZID, value); }
        }
        DateTime fXSHZRQ;
        public DateTime XSHZRQ
        {
            get { return fXSHZRQ; }
            set { SetPropertyValue<DateTime>("XSHZRQ", ref fXSHZRQ, value); }
        }
        string fXSHZDID;
        [Size(16)]
        public string XSHZDID
        {
            get { return fXSHZDID; }
            set { SetPropertyValue<string>("XSHZDID", ref fXSHZDID, value); }
        }
        DateTime fFHPZRQ;
        public DateTime FHPZRQ
        {
            get { return fFHPZRQ; }
            set { SetPropertyValue<DateTime>("FHPZRQ", ref fFHPZRQ, value); }
        }
        string fZTMC;
        [Size(100)]
        public string ZTMC
        {
            get { return fZTMC; }
            set { SetPropertyValue<string>("ZTMC", ref fZTMC, value); }
        }
        string fCZYXM;
        [Size(16)]
        public string CZYXM
        {
            get { return fCZYXM; }
            set { SetPropertyValue<string>("CZYXM", ref fCZYXM, value); }
        }
        public VIEW_JT_X_XSD(Session session) : base(session) { }
        public VIEW_JT_X_XSD() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class VIEW_JT_C_XSHZDMX : XPLiteObject
    {
        string fXSHZDH;
        [Size(22)]
        public string XSHZDH
        {
            get { return fXSHZDH; }
            set { SetPropertyValue<string>("XSHZDH", ref fXSHZDH, value); }
        }
        string fXSDH;
        [Size(22)]
        public string XSDH
        {
            get { return fXSDH; }
            set { SetPropertyValue<string>("XSDH", ref fXSDH, value); }
        }
        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }
        long fFXFLSL1;
        public long FXFLSL1
        {
            get { return fFXFLSL1; }
            set { SetPropertyValue<long>("FXFLSL1", ref fFXFLSL1, value); }
        }
        decimal fFXFLJE1;
        public decimal FXFLJE1
        {
            get { return fFXFLJE1; }
            set { SetPropertyValue<decimal>("FXFLJE1", ref fFXFLJE1, value); }
        }
        long fFXFLSL2;
        public long FXFLSL2
        {
            get { return fFXFLSL2; }
            set { SetPropertyValue<long>("FXFLSL2", ref fFXFLSL2, value); }
        }
        decimal fFXFLJE2;
        public decimal FXFLJE2
        {
            get { return fFXFLJE2; }
            set { SetPropertyValue<decimal>("FXFLJE2", ref fFXFLJE2, value); }
        }
        long fFXFLSL3;
        public long FXFLSL3
        {
            get { return fFXFLSL3; }
            set { SetPropertyValue<long>("FXFLSL3", ref fFXFLSL3, value); }
        }
        decimal fFXFLJE3;
        public decimal FXFLJE3
        {
            get { return fFXFLJE3; }
            set { SetPropertyValue<decimal>("FXFLJE3", ref fFXFLJE3, value); }
        }
        long fFXFLSL4;
        public long FXFLSL4
        {
            get { return fFXFLSL4; }
            set { SetPropertyValue<long>("FXFLSL4", ref fFXFLSL4, value); }
        }
        decimal fFXFLJE4;
        public decimal FXFLJE4
        {
            get { return fFXFLJE4; }
            set { SetPropertyValue<decimal>("FXFLJE4", ref fFXFLJE4, value); }
        }
        long fFXFLSL5;
        public long FXFLSL5
        {
            get { return fFXFLSL5; }
            set { SetPropertyValue<long>("FXFLSL5", ref fFXFLSL5, value); }
        }
        decimal fFXFLJE5;
        public decimal FXFLJE5
        {
            get { return fFXFLJE5; }
            set { SetPropertyValue<decimal>("FXFLJE5", ref fFXFLJE5, value); }
        }
        long fFXFLSL6;
        public long FXFLSL6
        {
            get { return fFXFLSL6; }
            set { SetPropertyValue<long>("FXFLSL6", ref fFXFLSL6, value); }
        }
        decimal fFXFLJE6;
        public decimal FXFLJE6
        {
            get { return fFXFLJE6; }
            set { SetPropertyValue<decimal>("FXFLJE6", ref fFXFLJE6, value); }
        }
        long fFXFLSL7;
        public long FXFLSL7
        {
            get { return fFXFLSL7; }
            set { SetPropertyValue<long>("FXFLSL7", ref fFXFLSL7, value); }
        }
        decimal fFXFLJE7;
        public decimal FXFLJE7
        {
            get { return fFXFLJE7; }
            set { SetPropertyValue<decimal>("FXFLJE7", ref fFXFLJE7, value); }
        }
        long fFXFLSL8;
        public long FXFLSL8
        {
            get { return fFXFLSL8; }
            set { SetPropertyValue<long>("FXFLSL8", ref fFXFLSL8, value); }
        }
        decimal fFXFLJE8;
        public decimal FXFLJE8
        {
            get { return fFXFLJE8; }
            set { SetPropertyValue<decimal>("FXFLJE8", ref fFXFLJE8, value); }
        }
        long fFXFLSL9;
        public long FXFLSL9
        {
            get { return fFXFLSL9; }
            set { SetPropertyValue<long>("FXFLSL9", ref fFXFLSL9, value); }
        }
        decimal fFXFLJE9;
        public decimal FXFLJE9
        {
            get { return fFXFLJE9; }
            set { SetPropertyValue<decimal>("FXFLJE9", ref fFXFLJE9, value); }
        }
        long fFXFLSL10;
        public long FXFLSL10
        {
            get { return fFXFLSL10; }
            set { SetPropertyValue<long>("FXFLSL10", ref fFXFLSL10, value); }
        }
        decimal fFXFLJE10;
        public decimal FXFLJE10
        {
            get { return fFXFLJE10; }
            set { SetPropertyValue<decimal>("FXFLJE10", ref fFXFLJE10, value); }
        }
        long fHJSL;
        public long HJSL
        {
            get { return fHJSL; }
            set { SetPropertyValue<long>("HJSL", ref fHJSL, value); }
        }
        decimal fHJJE;
        public decimal HJJE
        {
            get { return fHJJE; }
            set { SetPropertyValue<decimal>("HJJE", ref fHJJE, value); }
        }
        long fXSZKSL;
        public long XSZKSL
        {
            get { return fXSZKSL; }
            set { SetPropertyValue<long>("XSZKSL", ref fXSZKSL, value); }
        }
        decimal fXSZKJE;
        public decimal XSZKJE
        {
            get { return fXSZKJE; }
            set { SetPropertyValue<decimal>("XSZKJE", ref fXSZKJE, value); }
        }
        decimal fJSHJ;
        public decimal JSHJ
        {
            get { return fJSHJ; }
            set { SetPropertyValue<decimal>("JSHJ", ref fJSHJ, value); }
        }
        decimal fWSJE;
        public decimal WSJE
        {
            get { return fWSJE; }
            set { SetPropertyValue<decimal>("WSJE", ref fWSJE, value); }
        }
        decimal fSE;
        public decimal SE
        {
            get { return fSE; }
            set { SetPropertyValue<decimal>("SE", ref fSE, value); }
        }
        DateTime fZDRQ;
        public DateTime ZDRQ
        {
            get { return fZDRQ; }
            set { SetPropertyValue<DateTime>("ZDRQ", ref fZDRQ, value); }
        }
        string fBZ;
        public string BZ
        {
            get { return fBZ; }
            set { SetPropertyValue<string>("BZ", ref fBZ, value); }
        }
        string fXSDID;
        [Size(16)]
        public string XSDID
        {
            get { return fXSDID; }
            set { SetPropertyValue<string>("XSDID", ref fXSDID, value); }
        }
        string fSJLX;
        [Size(4)]
        public string SJLX
        {
            get { return fSJLX; }
            set { SetPropertyValue<string>("SJLX", ref fSJLX, value); }
        }
        string fXSHZDMXID;
        [Key]
        [Size(16)]
        public string XSHZDMXID
        {
            get { return fXSHZDMXID; }
            set { SetPropertyValue<string>("XSHZDMXID", ref fXSHZDMXID, value); }
        }
        string fXSHZDID;
        [Size(16)]
        public string XSHZDID
        {
            get { return fXSHZDID; }
            set { SetPropertyValue<string>("XSHZDID", ref fXSHZDID, value); }
        }
        string fXSJSDID;
        [Size(16)]
        public string XSJSDID
        {
            get { return fXSJSDID; }
            set { SetPropertyValue<string>("XSJSDID", ref fXSJSDID, value); }
        }
        public VIEW_JT_C_XSHZDMX(Session session) : base(session) { }
        public VIEW_JT_C_XSHZDMX() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class VIEW_JC_C_XSHZDMX : XPLiteObject
    {
        string fXSHZDH;
        [Size(22)]
        public string XSHZDH
        {
            get { return fXSHZDH; }
            set { SetPropertyValue<string>("XSHZDH", ref fXSHZDH, value); }
        }
        string fXSDH;
        [Size(22)]
        public string XSDH
        {
            get { return fXSDH; }
            set { SetPropertyValue<string>("XSDH", ref fXSDH, value); }
        }
        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }
        long fFXFLSL1;
        public long FXFLSL1
        {
            get { return fFXFLSL1; }
            set { SetPropertyValue<long>("FXFLSL1", ref fFXFLSL1, value); }
        }
        decimal fFXFLJE1;
        public decimal FXFLJE1
        {
            get { return fFXFLJE1; }
            set { SetPropertyValue<decimal>("FXFLJE1", ref fFXFLJE1, value); }
        }
        long fFXFLSL2;
        public long FXFLSL2
        {
            get { return fFXFLSL2; }
            set { SetPropertyValue<long>("FXFLSL2", ref fFXFLSL2, value); }
        }
        decimal fFXFLJE2;
        public decimal FXFLJE2
        {
            get { return fFXFLJE2; }
            set { SetPropertyValue<decimal>("FXFLJE2", ref fFXFLJE2, value); }
        }
        long fFXFLSL3;
        public long FXFLSL3
        {
            get { return fFXFLSL3; }
            set { SetPropertyValue<long>("FXFLSL3", ref fFXFLSL3, value); }
        }
        decimal fFXFLJE3;
        public decimal FXFLJE3
        {
            get { return fFXFLJE3; }
            set { SetPropertyValue<decimal>("FXFLJE3", ref fFXFLJE3, value); }
        }
        long fFXFLSL4;
        public long FXFLSL4
        {
            get { return fFXFLSL4; }
            set { SetPropertyValue<long>("FXFLSL4", ref fFXFLSL4, value); }
        }
        decimal fFXFLJE4;
        public decimal FXFLJE4
        {
            get { return fFXFLJE4; }
            set { SetPropertyValue<decimal>("FXFLJE4", ref fFXFLJE4, value); }
        }
        long fFXFLSL5;
        public long FXFLSL5
        {
            get { return fFXFLSL5; }
            set { SetPropertyValue<long>("FXFLSL5", ref fFXFLSL5, value); }
        }
        decimal fFXFLJE5;
        public decimal FXFLJE5
        {
            get { return fFXFLJE5; }
            set { SetPropertyValue<decimal>("FXFLJE5", ref fFXFLJE5, value); }
        }
        long fFXFLSL6;
        public long FXFLSL6
        {
            get { return fFXFLSL6; }
            set { SetPropertyValue<long>("FXFLSL6", ref fFXFLSL6, value); }
        }
        decimal fFXFLJE6;
        public decimal FXFLJE6
        {
            get { return fFXFLJE6; }
            set { SetPropertyValue<decimal>("FXFLJE6", ref fFXFLJE6, value); }
        }
        long fFXFLSL7;
        public long FXFLSL7
        {
            get { return fFXFLSL7; }
            set { SetPropertyValue<long>("FXFLSL7", ref fFXFLSL7, value); }
        }
        decimal fFXFLJE7;
        public decimal FXFLJE7
        {
            get { return fFXFLJE7; }
            set { SetPropertyValue<decimal>("FXFLJE7", ref fFXFLJE7, value); }
        }
        long fFXFLSL8;
        public long FXFLSL8
        {
            get { return fFXFLSL8; }
            set { SetPropertyValue<long>("FXFLSL8", ref fFXFLSL8, value); }
        }
        decimal fFXFLJE8;
        public decimal FXFLJE8
        {
            get { return fFXFLJE8; }
            set { SetPropertyValue<decimal>("FXFLJE8", ref fFXFLJE8, value); }
        }
        long fFXFLSL9;
        public long FXFLSL9
        {
            get { return fFXFLSL9; }
            set { SetPropertyValue<long>("FXFLSL9", ref fFXFLSL9, value); }
        }
        decimal fFXFLJE9;
        public decimal FXFLJE9
        {
            get { return fFXFLJE9; }
            set { SetPropertyValue<decimal>("FXFLJE9", ref fFXFLJE9, value); }
        }
        long fFXFLSL10;
        public long FXFLSL10
        {
            get { return fFXFLSL10; }
            set { SetPropertyValue<long>("FXFLSL10", ref fFXFLSL10, value); }
        }
        decimal fFXFLJE10;
        public decimal FXFLJE10
        {
            get { return fFXFLJE10; }
            set { SetPropertyValue<decimal>("FXFLJE10", ref fFXFLJE10, value); }
        }
        long fHJSL;
        public long HJSL
        {
            get { return fHJSL; }
            set { SetPropertyValue<long>("HJSL", ref fHJSL, value); }
        }
        decimal fHJJE;
        public decimal HJJE
        {
            get { return fHJJE; }
            set { SetPropertyValue<decimal>("HJJE", ref fHJJE, value); }
        }
        long fXSZKSL;
        public long XSZKSL
        {
            get { return fXSZKSL; }
            set { SetPropertyValue<long>("XSZKSL", ref fXSZKSL, value); }
        }
        decimal fXSZKJE;
        public decimal XSZKJE
        {
            get { return fXSZKJE; }
            set { SetPropertyValue<decimal>("XSZKJE", ref fXSZKJE, value); }
        }
        decimal fJSHJ;
        public decimal JSHJ
        {
            get { return fJSHJ; }
            set { SetPropertyValue<decimal>("JSHJ", ref fJSHJ, value); }
        }
        decimal fWSJE;
        public decimal WSJE
        {
            get { return fWSJE; }
            set { SetPropertyValue<decimal>("WSJE", ref fWSJE, value); }
        }
        decimal fSE;
        public decimal SE
        {
            get { return fSE; }
            set { SetPropertyValue<decimal>("SE", ref fSE, value); }
        }
        DateTime fZDRQ;
        public DateTime ZDRQ
        {
            get { return fZDRQ; }
            set { SetPropertyValue<DateTime>("ZDRQ", ref fZDRQ, value); }
        }
        string fBZ;
        public string BZ
        {
            get { return fBZ; }
            set { SetPropertyValue<string>("BZ", ref fBZ, value); }
        }
        string fXSDID;
        [Size(16)]
        public string XSDID
        {
            get { return fXSDID; }
            set { SetPropertyValue<string>("XSDID", ref fXSDID, value); }
        }
        string fSJLX;
        [Size(4)]
        public string SJLX
        {
            get { return fSJLX; }
            set { SetPropertyValue<string>("SJLX", ref fSJLX, value); }
        }
        string fXSHZDMXID;
        [Key]
        [Size(16)]
        public string XSHZDMXID
        {
            get { return fXSHZDMXID; }
            set { SetPropertyValue<string>("XSHZDMXID", ref fXSHZDMXID, value); }
        }
        string fXSHZDID;
        [Size(16)]
        public string XSHZDID
        {
            get { return fXSHZDID; }
            set { SetPropertyValue<string>("XSHZDID", ref fXSHZDID, value); }
        }
        string fXSJSDID;
        [Size(16)]
        public string XSJSDID
        {
            get { return fXSJSDID; }
            set { SetPropertyValue<string>("XSJSDID", ref fXSJSDID, value); }
        }
        public VIEW_JC_C_XSHZDMX(Session session) : base(session) { }
        public VIEW_JC_C_XSHZDMX() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class VIEW_JT_X_XSDMX : XPLiteObject
    {
        string fXSDH;
        [Size(22)]
        public string XSDH
        {
            get { return fXSDH; }
            set { SetPropertyValue<string>("XSDH", ref fXSDH, value); }
        }
        string fPM;
        [Size(100)]
        public string PM
        {
            get { return fPM; }
            set { SetPropertyValue<string>("PM", ref fPM, value); }
        }

        string fSPBH;
        [Size(16)]
        public string SPBH
        {
            get { return fSPBH; }
            set { SetPropertyValue<string>("SPBH", ref fSPBH, value); }
        }
        string fBZ;
        public string BZ
        {
            get { return fBZ; }
            set { SetPropertyValue<string>("BZ", ref fBZ, value); }
        }
        string fBJQDH;
        [Size(16)]
        public string BJQDH
        {
            get { return fBJQDH; }
            set { SetPropertyValue<string>("BJQDH", ref fBJQDH, value); }
        }
        string fKHDDMXID;
        [Size(16)]
        public string KHDDMXID
        {
            get { return fKHDDMXID; }
            set { SetPropertyValue<string>("KHDDMXID", ref fKHDDMXID, value); }
        }
        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }
        string fPFDMXID;
        [Size(16)]
        public string PFDMXID
        {
            get { return fPFDMXID; }
            set { SetPropertyValue<string>("PFDMXID", ref fPFDMXID, value); }
        }
        string fJSFSMC;
        [Size(80)]
        public string JSFSMC
        {
            get { return fJSFSMC; }
            set { SetPropertyValue<string>("JSFSMC", ref fJSFSMC, value); }
        }
        string fKHMC;
        [Size(100)]
        public string KHMC
        {
            get { return fKHMC; }
            set { SetPropertyValue<string>("KHMC", ref fKHMC, value); }
        }
        decimal fJSHJ;
        public decimal JSHJ
        {
            get { return fJSHJ; }
            set { SetPropertyValue<decimal>("JSHJ", ref fJSHJ, value); }
        }
        decimal fZKE;
        public decimal ZKE
        {
            get { return fZKE; }
            set { SetPropertyValue<decimal>("ZKE", ref fZKE, value); }
        }
        decimal fSE;
        public decimal SE
        {
            get { return fSE; }
            set { SetPropertyValue<decimal>("SE", ref fSE, value); }
        }
        decimal fWSJE;
        public decimal WSJE
        {
            get { return fWSJE; }
            set { SetPropertyValue<decimal>("WSJE", ref fWSJE, value); }
        }
        string fXSDMXID;
        [Key]
        [Size(16)]
        public string XSDMXID
        {
            get { return fXSDMXID; }
            set { SetPropertyValue<string>("XSDMXID", ref fXSDMXID, value); }
        }
        string fXSDID;
        [Size(16)]
        public string XSDID
        {
            get { return fXSDID; }
            set { SetPropertyValue<string>("XSDID", ref fXSDID, value); }
        }
        string fBMSPKFMXID;
        [Size(16)]
        public string BMSPKFMXID
        {
            get { return fBMSPKFMXID; }
            set { SetPropertyValue<string>("BMSPKFMXID", ref fBMSPKFMXID, value); }
        }
        string fSPXXID;
        [Size(16)]
        public string SPXXID
        {
            get { return fSPXXID; }
            set { SetPropertyValue<string>("SPXXID", ref fSPXXID, value); }
        }
        string fZDDM;
        [Size(15)]
        public string ZDDM
        {
            get { return fZDDM; }
            set { SetPropertyValue<string>("ZDDM", ref fZDDM, value); }
        }
        string fXSFSID;
        [Size(16)]
        public string XSFSID
        {
            get { return fXSFSID; }
            set { SetPropertyValue<string>("XSFSID", ref fXSFSID, value); }
        }
        decimal fDJ;
        public decimal DJ
        {
            get { return fDJ; }
            set { SetPropertyValue<decimal>("DJ", ref fDJ, value); }
        }
        decimal fXJ;
        public decimal XJ
        {
            get { return fXJ; }
            set { SetPropertyValue<decimal>("XJ", ref fXJ, value); }
        }
        decimal fXZ;
        public decimal XZ
        {
            get { return fXZ; }
            set { SetPropertyValue<decimal>("XZ", ref fXZ, value); }
        }
        byte fSL;
        public byte SL
        {
            get { return fSL; }
            set { SetPropertyValue<byte>("SL", ref fSL, value); }
        }
        long fXSSL;
        public long XSSL
        {
            get { return fXSSL; }
            set { SetPropertyValue<long>("XSSL", ref fXSSL, value); }
        }
        decimal fXSSY;
        public decimal XSSY
        {
            get { return fXSSY; }
            set { SetPropertyValue<decimal>("XSSY", ref fXSSY, value); }
        }
        decimal fXSMY;
        public decimal XSMY
        {
            get { return fXSMY; }
            set { SetPropertyValue<decimal>("XSMY", ref fXSMY, value); }
        }
        long fZZSL;
        public long ZZSL
        {
            get { return fZZSL; }
            set { SetPropertyValue<long>("ZZSL", ref fZZSL, value); }
        }
        decimal fZZSY;
        public decimal ZZSY
        {
            get { return fZZSY; }
            set { SetPropertyValue<decimal>("ZZSY", ref fZZSY, value); }
        }
        decimal fZZMY;
        public decimal ZZMY
        {
            get { return fZZMY; }
            set { SetPropertyValue<decimal>("ZZMY", ref fZZMY, value); }
        }
        long fYSSL;
        public long YSSL
        {
            get { return fYSSL; }
            set { SetPropertyValue<long>("YSSL", ref fYSSL, value); }
        }
        decimal fYSSY;
        public decimal YSSY
        {
            get { return fYSSY; }
            set { SetPropertyValue<decimal>("YSSY", ref fYSSY, value); }
        }
        decimal fYSMY;
        public decimal YSMY
        {
            get { return fYSMY; }
            set { SetPropertyValue<decimal>("YSMY", ref fYSMY, value); }
        }
        string fLYDJBID;
        [Size(16)]
        public string LYDJBID
        {
            get { return fLYDJBID; }
            set { SetPropertyValue<string>("LYDJBID", ref fLYDJBID, value); }
        }
        string fLYDJID;
        [Size(16)]
        public string LYDJID
        {
            get { return fLYDJID; }
            set { SetPropertyValue<string>("LYDJID", ref fLYDJID, value); }
        }
        string fLYBMID;
        [Size(16)]
        public string LYBMID
        {
            get { return fLYBMID; }
            set { SetPropertyValue<string>("LYBMID", ref fLYBMID, value); }
        }
        string fLYDJMXID;
        [Size(16)]
        public string LYDJMXID
        {
            get { return fLYDJMXID; }
            set { SetPropertyValue<string>("LYDJMXID", ref fLYDJMXID, value); }
        }
        string fZT;
        [Size(4)]
        public string ZT
        {
            get { return fZT; }
            set { SetPropertyValue<string>("ZT", ref fZT, value); }
        }
        string fYZT;
        [Size(4)]
        public string YZT
        {
            get { return fYZT; }
            set { SetPropertyValue<string>("YZT", ref fYZT, value); }
        }
        string fFHDZ;
        [Size(80)]
        public string FHDZ
        {
            get { return fFHDZ; }
            set { SetPropertyValue<string>("FHDZ", ref fFHDZ, value); }
        }
        string fCZYXM;
        [Size(16)]
        public string CZYXM
        {
            get { return fCZYXM; }
            set { SetPropertyValue<string>("CZYXM", ref fCZYXM, value); }
        }
        public VIEW_JT_X_XSDMX(Session session) : base(session) { }
        public VIEW_JT_X_XSDMX() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class VIEW_JT_X_XTD_CCDMX : XPLiteObject
    {
        string fCCDH;
        [Size(22)]
        public string CCDH
        {
            get { return fCCDH; }
            set { SetPropertyValue<string>("CCDH", ref fCCDH, value); }
        }
        string fSPBH;
        [Size(16)]
        public string SPBH
        {
            get { return fSPBH; }
            set { SetPropertyValue<string>("SPBH", ref fSPBH, value); }
        }
        string fPM;
        [Size(100)]
        public string PM
        {
            get { return fPM; }
            set { SetPropertyValue<string>("PM", ref fPM, value); }
        }
        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }
        decimal fZK;
        public decimal ZK
        {
            get { return fZK; }
            set { SetPropertyValue<decimal>("ZK", ref fZK, value); }
        }
        long fCCSL;
        public long CCSL
        {
            get { return fCCSL; }
            set { SetPropertyValue<long>("CCSL", ref fCCSL, value); }
        }
        decimal fCCSY;
        public decimal CCSY
        {
            get { return fCCSY; }
            set { SetPropertyValue<decimal>("CCSY", ref fCCSY, value); }
        }
        decimal fCCMY;
        public decimal CCMY
        {
            get { return fCCMY; }
            set { SetPropertyValue<decimal>("CCMY", ref fCCMY, value); }
        }
        string fLYDJBID;
        [Size(16)]
        public string LYDJBID
        {
            get { return fLYDJBID; }
            set { SetPropertyValue<string>("LYDJBID", ref fLYDJBID, value); }
        }
        string fLYDJID;
        [Size(16)]
        public string LYDJID
        {
            get { return fLYDJID; }
            set { SetPropertyValue<string>("LYDJID", ref fLYDJID, value); }
        }
        string fLYBMID;
        [Size(16)]
        public string LYBMID
        {
            get { return fLYBMID; }
            set { SetPropertyValue<string>("LYBMID", ref fLYBMID, value); }
        }
        string fLYDJMXID;
        [Size(16)]
        public string LYDJMXID
        {
            get { return fLYDJMXID; }
            set { SetPropertyValue<string>("LYDJMXID", ref fLYDJMXID, value); }
        }
        string fZT;
        [Size(4)]
        public string ZT
        {
            get { return fZT; }
            set { SetPropertyValue<string>("ZT", ref fZT, value); }
        }
        string fYZT;
        [Size(4)]
        public string YZT
        {
            get { return fYZT; }
            set { SetPropertyValue<string>("YZT", ref fYZT, value); }
        }
        string fCCYY;
        [Size(500)]
        public string CCYY
        {
            get { return fCCYY; }
            set { SetPropertyValue<string>("CCYY", ref fCCYY, value); }
        }
        string fCCDMXID;
        [Key]
        [Size(16)]
        public string CCDMXID
        {
            get { return fCCDMXID; }
            set { SetPropertyValue<string>("CCDMXID", ref fCCDMXID, value); }
        }
        string fCCDID;
        [Size(16)]
        public string CCDID
        {
            get { return fCCDID; }
            set { SetPropertyValue<string>("CCDID", ref fCCDID, value); }
        }
        string fSPXXID;
        [Size(16)]
        public string SPXXID
        {
            get { return fSPXXID; }
            set { SetPropertyValue<string>("SPXXID", ref fSPXXID, value); }
        }
        string fZDDM;
        [Size(15)]
        public string ZDDM
        {
            get { return fZDDM; }
            set { SetPropertyValue<string>("ZDDM", ref fZDDM, value); }
        }
        decimal fDJ;
        public decimal DJ
        {
            get { return fDJ; }
            set { SetPropertyValue<decimal>("DJ", ref fDJ, value); }
        }
        decimal fSJ;
        public decimal SJ
        {
            get { return fSJ; }
            set { SetPropertyValue<decimal>("SJ", ref fSJ, value); }
        }
        public VIEW_JT_X_XTD_CCDMX(Session session) : base(session) { }
        public VIEW_JT_X_XTD_CCDMX() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class VIEW_JT_X_XTD : XPLiteObject
    {
        string fSTATUSMC;
        [Size(16)]
        public string STATUSMC
        {
            get { return fSTATUSMC; }
            set { SetPropertyValue<string>("STATUSMC", ref fSTATUSMC, value); }
        }
        string fXTDID;
        [Key]
        [Size(16)]
        public string XTDID
        {
            get { return fXTDID; }
            set { SetPropertyValue<string>("XTDID", ref fXTDID, value); }
        }
        string fXTDH;
        [Size(22)]
        public string XTDH
        {
            get { return fXTDH; }
            set { SetPropertyValue<string>("XTDH", ref fXTDH, value); }
        }
        string fXSBMID;
        [Size(16)]
        public string XSBMID
        {
            get { return fXSBMID; }
            set { SetPropertyValue<string>("XSBMID", ref fXSBMID, value); }
        }
        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }
        string fKHID;
        [Size(16)]
        public string KHID
        {
            get { return fKHID; }
            set { SetPropertyValue<string>("KHID", ref fKHID, value); }
        }
        string fSHBMID;
        [Size(16)]
        public string SHBMID
        {
            get { return fSHBMID; }
            set { SetPropertyValue<string>("SHBMID", ref fSHBMID, value); }
        }
        string fYSFSID;
        [Size(16)]
        public string YSFSID
        {
            get { return fYSFSID; }
            set { SetPropertyValue<string>("YSFSID", ref fYSFSID, value); }
        }
        string fJSFSID;
        [Size(16)]
        public string JSFSID
        {
            get { return fJSFSID; }
            set { SetPropertyValue<string>("JSFSID", ref fJSFSID, value); }
        }
        DateTime fZDRQ;
        public DateTime ZDRQ
        {
            get { return fZDRQ; }
            set { SetPropertyValue<DateTime>("ZDRQ", ref fZDRQ, value); }
        }
        string fCZYID;
        [Size(16)]
        public string CZYID
        {
            get { return fCZYID; }
            set { SetPropertyValue<string>("CZYID", ref fCZYID, value); }
        }
        DateTime fCZRQ;
        public DateTime CZRQ
        {
            get { return fCZRQ; }
            set { SetPropertyValue<DateTime>("CZRQ", ref fCZRQ, value); }
        }
        byte fSL;
        public byte SL
        {
            get { return fSL; }
            set { SetPropertyValue<byte>("SL", ref fSL, value); }
        }
        string fYDH;
        [Size(22)]
        public string YDH
        {
            get { return fYDH; }
            set { SetPropertyValue<string>("YDH", ref fYDH, value); }
        }
        string fSHDWID;
        [Size(80)]
        public string SHDWID
        {
            get { return fSHDWID; }
            set { SetPropertyValue<string>("SHDWID", ref fSHDWID, value); }
        }
        long fBJS;
        public long BJS
        {
            get { return fBJS; }
            set { SetPropertyValue<long>("BJS", ref fBJS, value); }
        }
        long fPZS;
        public long PZS
        {
            get { return fPZS; }
            set { SetPropertyValue<long>("PZS", ref fPZS, value); }
        }
        long fXTSL;
        public long XTSL
        {
            get { return fXTSL; }
            set { SetPropertyValue<long>("XTSL", ref fXTSL, value); }
        }
        decimal fXTSY;
        public decimal XTSY
        {
            get { return fXTSY; }
            set { SetPropertyValue<decimal>("XTSY", ref fXTSY, value); }
        }
        decimal fXTMY;
        public decimal XTMY
        {
            get { return fXTMY; }
            set { SetPropertyValue<decimal>("XTMY", ref fXTMY, value); }
        }
        decimal fJSHJ;
        public decimal JSHJ
        {
            get { return fJSHJ; }
            set { SetPropertyValue<decimal>("JSHJ", ref fJSHJ, value); }
        }
        decimal fZKE;
        public decimal ZKE
        {
            get { return fZKE; }
            set { SetPropertyValue<decimal>("ZKE", ref fZKE, value); }
        }
        decimal fSE;
        public decimal SE
        {
            get { return fSE; }
            set { SetPropertyValue<decimal>("SE", ref fSE, value); }
        }
        decimal fWSJE;
        public decimal WSJE
        {
            get { return fWSJE; }
            set { SetPropertyValue<decimal>("WSJE", ref fWSJE, value); }
        }
        long fZZSL;
        public long ZZSL
        {
            get { return fZZSL; }
            set { SetPropertyValue<long>("ZZSL", ref fZZSL, value); }
        }
        decimal fZZSY;
        public decimal ZZSY
        {
            get { return fZZSY; }
            set { SetPropertyValue<decimal>("ZZSY", ref fZZSY, value); }
        }
        decimal fZZMY;
        public decimal ZZMY
        {
            get { return fZZMY; }
            set { SetPropertyValue<decimal>("ZZMY", ref fZZMY, value); }
        }
        long fYSSL;
        public long YSSL
        {
            get { return fYSSL; }
            set { SetPropertyValue<long>("YSSL", ref fYSSL, value); }
        }
        decimal fYSSY;
        public decimal YSSY
        {
            get { return fYSSY; }
            set { SetPropertyValue<decimal>("YSSY", ref fYSSY, value); }
        }
        decimal fYSMY;
        public decimal YSMY
        {
            get { return fYSMY; }
            set { SetPropertyValue<decimal>("YSMY", ref fYSMY, value); }
        }
        string fKHMC;
        [Size(100)]
        public string KHMC
        {
            get { return fKHMC; }
            set { SetPropertyValue<string>("KHMC", ref fKHMC, value); }
        }
        string fXSBMMC;
        [Size(100)]
        public string XSBMMC
        {
            get { return fXSBMMC; }
            set { SetPropertyValue<string>("XSBMMC", ref fXSBMMC, value); }
        }
        string fWLMC;
        [Size(100)]
        public string WLMC
        {
            get { return fWLMC; }
            set { SetPropertyValue<string>("WLMC", ref fWLMC, value); }
        }
        string fZTMC;
        [Size(100)]
        public string ZTMC
        {
            get { return fZTMC; }
            set { SetPropertyValue<string>("ZTMC", ref fZTMC, value); }
        }
        string fJSFSMC;
        [Size(80)]
        public string JSFSMC
        {
            get { return fJSFSMC; }
            set { SetPropertyValue<string>("JSFSMC", ref fJSFSMC, value); }
        }
        string fXSHZDH;
        [Size(22)]
        public string XSHZDH
        {
            get { return fXSHZDH; }
            set { SetPropertyValue<string>("XSHZDH", ref fXSHZDH, value); }
        }
        string fFHPZH;
        [Size(22)]
        public string FHPZH
        {
            get { return fFHPZH; }
            set { SetPropertyValue<string>("FHPZH", ref fFHPZH, value); }
        }

        string fCZYXM;
        [Size(16)]
        public string CZYXM
        {
            get { return fCZYXM; }
            set { SetPropertyValue<string>("CZYXM", ref fCZYXM, value); }
        }

        string fZT;
        [Size(4)]
        public string ZT
        {
            get { return fZT; }
            set { SetPropertyValue<string>("ZT", ref fZT, value); }
        }
        string fYZT;
        [Size(4)]
        public string YZT
        {
            get { return fYZT; }
            set { SetPropertyValue<string>("YZT", ref fYZT, value); }
        }
        string fBZ;
        public string BZ
        {
            get { return fBZ; }
            set { SetPropertyValue<string>("BZ", ref fBZ, value); }
        }
        string fXSFSID;
        [Size(16)]
        public string XSFSID
        {
            get { return fXSFSID; }
            set { SetPropertyValue<string>("XSFSID", ref fXSFSID, value); }
        }
        string fFHPZID;
        [Size(16)]
        public string FHPZID
        {
            get { return fFHPZID; }
            set { SetPropertyValue<string>("FHPZID", ref fFHPZID, value); }
        }
        DateTime fXSHZRQ;
        public DateTime XSHZRQ
        {
            get { return fXSHZRQ; }
            set { SetPropertyValue<DateTime>("XSHZRQ", ref fXSHZRQ, value); }
        }
        string fXSHZDID;
        [Size(16)]
        public string XSHZDID
        {
            get { return fXSHZDID; }
            set { SetPropertyValue<string>("XSHZDID", ref fXSHZDID, value); }
        }
        DateTime fFHPZRQ;
        public DateTime FHPZRQ
        {
            get { return fFHPZRQ; }
            set { SetPropertyValue<DateTime>("FHPZRQ", ref fFHPZRQ, value); }
        }
        public VIEW_JT_X_XTD(Session session) : base(session) { }
        public VIEW_JT_X_XTD() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class VIEW_JT_X_XSD_CCDMX : XPLiteObject
    {
        string fCCDMXID;
        [Key]
        [Size(16)]
        public string CCDMXID
        {
            get { return fCCDMXID; }
            set { SetPropertyValue<string>("CCDMXID", ref fCCDMXID, value); }
        }
        string fCCDH;
        [Size(22)]
        public string CCDH
        {
            get { return fCCDH; }
            set { SetPropertyValue<string>("CCDH", ref fCCDH, value); }
        }
        string fSPBH;
        [Size(16)]
        public string SPBH
        {
            get { return fSPBH; }
            set { SetPropertyValue<string>("SPBH", ref fSPBH, value); }
        }
        string fPM;
        [Size(100)]
        public string PM
        {
            get { return fPM; }
            set { SetPropertyValue<string>("PM", ref fPM, value); }
        }
        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }
        string fCCDID;
        [Size(16)]
        public string CCDID
        {
            get { return fCCDID; }
            set { SetPropertyValue<string>("CCDID", ref fCCDID, value); }
        }
        string fSPXXID;
        [Size(16)]
        public string SPXXID
        {
            get { return fSPXXID; }
            set { SetPropertyValue<string>("SPXXID", ref fSPXXID, value); }
        }
        string fZDDM;
        [Size(15)]
        public string ZDDM
        {
            get { return fZDDM; }
            set { SetPropertyValue<string>("ZDDM", ref fZDDM, value); }
        }
        decimal fDJ;
        public decimal DJ
        {
            get { return fDJ; }
            set { SetPropertyValue<decimal>("DJ", ref fDJ, value); }
        }
        decimal fSJ;
        public decimal SJ
        {
            get { return fSJ; }
            set { SetPropertyValue<decimal>("SJ", ref fSJ, value); }
        }
        decimal fZK;
        public decimal ZK
        {
            get { return fZK; }
            set { SetPropertyValue<decimal>("ZK", ref fZK, value); }
        }
        long fCCSL;
        public long CCSL
        {
            get { return fCCSL; }
            set { SetPropertyValue<long>("CCSL", ref fCCSL, value); }
        }
        decimal fCCSY;
        public decimal CCSY
        {
            get { return fCCSY; }
            set { SetPropertyValue<decimal>("CCSY", ref fCCSY, value); }
        }
        decimal fCCMY;
        public decimal CCMY
        {
            get { return fCCMY; }
            set { SetPropertyValue<decimal>("CCMY", ref fCCMY, value); }
        }
        string fLYDJBID;
        [Size(16)]
        public string LYDJBID
        {
            get { return fLYDJBID; }
            set { SetPropertyValue<string>("LYDJBID", ref fLYDJBID, value); }
        }
        string fLYDJID;
        [Size(16)]
        public string LYDJID
        {
            get { return fLYDJID; }
            set { SetPropertyValue<string>("LYDJID", ref fLYDJID, value); }
        }
        string fLYBMID;
        [Size(16)]
        public string LYBMID
        {
            get { return fLYBMID; }
            set { SetPropertyValue<string>("LYBMID", ref fLYBMID, value); }
        }
        string fLYDJMXID;
        [Size(16)]
        public string LYDJMXID
        {
            get { return fLYDJMXID; }
            set { SetPropertyValue<string>("LYDJMXID", ref fLYDJMXID, value); }
        }
        string fZT;
        [Size(4)]
        public string ZT
        {
            get { return fZT; }
            set { SetPropertyValue<string>("ZT", ref fZT, value); }
        }
        string fYZT;
        [Size(4)]
        public string YZT
        {
            get { return fYZT; }
            set { SetPropertyValue<string>("YZT", ref fYZT, value); }
        }
        string fCCYY;
        [Size(500)]
        public string CCYY
        {
            get { return fCCYY; }
            set { SetPropertyValue<string>("CCYY", ref fCCYY, value); }
        }
        public VIEW_JT_X_XSD_CCDMX(Session session) : base(session) { }
        public VIEW_JT_X_XSD_CCDMX() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class VIEW_JT_X_XTD_CCD : XPLiteObject
    {
        string fCCDID;
        [Key]
        [Size(16)]
        public string CCDID
        {
            get { return fCCDID; }
            set { SetPropertyValue<string>("CCDID", ref fCCDID, value); }
        }
        string fCCDH;
        [Size(22)]
        public string CCDH
        {
            get { return fCCDH; }
            set { SetPropertyValue<string>("CCDH", ref fCCDH, value); }
        }
        string fBMID;
        [Size(16)]
        public string BMID
        {
            get { return fBMID; }
            set { SetPropertyValue<string>("BMID", ref fBMID, value); }
        }
        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }
        DateTime fZDRQ;
        public DateTime ZDRQ
        {
            get { return fZDRQ; }
            set { SetPropertyValue<DateTime>("ZDRQ", ref fZDRQ, value); }
        }
        string fCZYID;
        [Size(16)]
        public string CZYID
        {
            get { return fCZYID; }
            set { SetPropertyValue<string>("CZYID", ref fCZYID, value); }
        }
        DateTime fCZRQ;
        public DateTime CZRQ
        {
            get { return fCZRQ; }
            set { SetPropertyValue<DateTime>("CZRQ", ref fCZRQ, value); }
        }
        long fCCSL;
        public long CCSL
        {
            get { return fCCSL; }
            set { SetPropertyValue<long>("CCSL", ref fCCSL, value); }
        }
        decimal fCCSY;
        public decimal CCSY
        {
            get { return fCCSY; }
            set { SetPropertyValue<decimal>("CCSY", ref fCCSY, value); }
        }
        decimal fCCMY;
        public decimal CCMY
        {
            get { return fCCMY; }
            set { SetPropertyValue<decimal>("CCMY", ref fCCMY, value); }
        }
        long fCCPZ;
        public long CCPZ
        {
            get { return fCCPZ; }
            set { SetPropertyValue<long>("CCPZ", ref fCCPZ, value); }
        }
        string fZT;
        [Size(4)]
        public string ZT
        {
            get { return fZT; }
            set { SetPropertyValue<string>("ZT", ref fZT, value); }
        }
        string fYZT;
        [Size(4)]
        public string YZT
        {
            get { return fYZT; }
            set { SetPropertyValue<string>("YZT", ref fYZT, value); }
        }
        string fKHMC;
        [Size(100)]
        public string KHMC
        {
            get { return fKHMC; }
            set { SetPropertyValue<string>("KHMC", ref fKHMC, value); }
        }
        string fSTATUSMC;
        [Size(16)]
        public string STATUSMC
        {
            get { return fSTATUSMC; }
            set { SetPropertyValue<string>("STATUSMC", ref fSTATUSMC, value); }
        }
        public VIEW_JT_X_XTD_CCD(Session session) : base(session) { }
        public VIEW_JT_X_XTD_CCD() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class VIEW_JT_C_CGSHPZ : XPLiteObject
    {
        string fSTATUSMC;
        [Size(16)]
        public string STATUSMC
        {
            get { return fSTATUSMC; }
            set { SetPropertyValue<string>("STATUSMC", ref fSTATUSMC, value); }
        }
        string fVOUCHERID;
        [Key]
        [Size(16)]
        public string VOUCHERID
        {
            get { return fVOUCHERID; }
            set { SetPropertyValue<string>("VOUCHERID", ref fVOUCHERID, value); }
        }
        string fVOUCHER_ID;
        [Size(22)]
        public string VOUCHER_ID
        {
            get { return fVOUCHER_ID; }
            set { SetPropertyValue<string>("VOUCHER_ID", ref fVOUCHER_ID, value); }
        }
        string fDWBH;
        [Size(100)]
        public string DWBH
        {
            get { return fDWBH; }
            set { SetPropertyValue<string>("DWBH", ref fDWBH, value); }
        }
        string fPZLXID;
        [Size(16)]
        public string PZLXID
        {
            get { return fPZLXID; }
            set { SetPropertyValue<string>("PZLXID", ref fPZLXID, value); }
        }
        string fCOMPANY;
        [Size(16)]
        public string COMPANY
        {
            get { return fCOMPANY; }
            set { SetPropertyValue<string>("COMPANY", ref fCOMPANY, value); }
        }
        string fVOUCHER_TYPE;
        [Size(16)]
        public string VOUCHER_TYPE
        {
            get { return fVOUCHER_TYPE; }
            set { SetPropertyValue<string>("VOUCHER_TYPE", ref fVOUCHER_TYPE, value); }
        }
        string fFISCAL_YEAR;
        [Size(4)]
        public string FISCAL_YEAR
        {
            get { return fFISCAL_YEAR; }
            set { SetPropertyValue<string>("FISCAL_YEAR", ref fFISCAL_YEAR, value); }
        }
        string fACCOUNTING_PERIOD;
        [Size(2)]
        public string ACCOUNTING_PERIOD
        {
            get { return fACCOUNTING_PERIOD; }
            set { SetPropertyValue<string>("ACCOUNTING_PERIOD", ref fACCOUNTING_PERIOD, value); }
        }
        long fATTACHMENT_NUMBER;
        public long ATTACHMENT_NUMBER
        {
            get { return fATTACHMENT_NUMBER; }
            set { SetPropertyValue<long>("ATTACHMENT_NUMBER", ref fATTACHMENT_NUMBER, value); }
        }
        DateTime fPREPAREDDATE;
        public DateTime PREPAREDDATE
        {
            get { return fPREPAREDDATE; }
            set { SetPropertyValue<DateTime>("PREPAREDDATE", ref fPREPAREDDATE, value); }
        }
        string fENTER;
        [Size(16)]
        public string ENTER
        {
            get { return fENTER; }
            set { SetPropertyValue<string>("ENTER", ref fENTER, value); }
        }
        string fZDRXM;
        [Size(16)]
        public string ZDRXM
        {
            get { return fZDRXM; }
            set { SetPropertyValue<string>("ZDRXM", ref fZDRXM, value); }
        }
        string fSHRXM;
        [Size(16)]
        public string SHRXM
        {
            get { return fSHRXM; }
            set { SetPropertyValue<string>("SHRXM", ref fSHRXM, value); }
        }
        string fJZRXM;
        [Size(16)]
        public string JZRXM
        {
            get { return fJZRXM; }
            set { SetPropertyValue<string>("JZRXM", ref fJZRXM, value); }
        }
        string fCNXM;
        [Size(16)]
        public string CNXM
        {
            get { return fCNXM; }
            set { SetPropertyValue<string>("CNXM", ref fCNXM, value); }
        }
        string fCASHIER;
        [Size(16)]
        public string CASHIER
        {
            get { return fCASHIER; }
            set { SetPropertyValue<string>("CASHIER", ref fCASHIER, value); }
        }
        string fSIGNATURE;
        [Size(2)]
        public string SIGNATURE
        {
            get { return fSIGNATURE; }
            set { SetPropertyValue<string>("SIGNATURE", ref fSIGNATURE, value); }
        }
        string fCHECKER;
        [Size(16)]
        public string CHECKER
        {
            get { return fCHECKER; }
            set { SetPropertyValue<string>("CHECKER", ref fCHECKER, value); }
        }
        DateTime fPOSTING_DATE;
        public DateTime POSTING_DATE
        {
            get { return fPOSTING_DATE; }
            set { SetPropertyValue<DateTime>("POSTING_DATE", ref fPOSTING_DATE, value); }
        }
        string fPOSTING_PERSON;
        [Size(16)]
        public string POSTING_PERSON
        {
            get { return fPOSTING_PERSON; }
            set { SetPropertyValue<string>("POSTING_PERSON", ref fPOSTING_PERSON, value); }
        }
        string fVOUCHER_MAKING_SYSTEM;
        [Size(16)]
        public string VOUCHER_MAKING_SYSTEM
        {
            get { return fVOUCHER_MAKING_SYSTEM; }
            set { SetPropertyValue<string>("VOUCHER_MAKING_SYSTEM", ref fVOUCHER_MAKING_SYSTEM, value); }
        }
        string fMEMO1;
        [Size(10)]
        public string MEMO1
        {
            get { return fMEMO1; }
            set { SetPropertyValue<string>("MEMO1", ref fMEMO1, value); }
        }
        string fMEMO2;
        [Size(10)]
        public string MEMO2
        {
            get { return fMEMO2; }
            set { SetPropertyValue<string>("MEMO2", ref fMEMO2, value); }
        }
        string fRESERVE1;
        [Size(10)]
        public string RESERVE1
        {
            get { return fRESERVE1; }
            set { SetPropertyValue<string>("RESERVE1", ref fRESERVE1, value); }
        }
        string fRESERVE2;
        [Size(10)]
        public string RESERVE2
        {
            get { return fRESERVE2; }
            set { SetPropertyValue<string>("RESERVE2", ref fRESERVE2, value); }
        }
        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }
        DateTime fCZRQ;
        public DateTime CZRQ
        {
            get { return fCZRQ; }
            set { SetPropertyValue<DateTime>("CZRQ", ref fCZRQ, value); }
        }
        string fZT;
        [Size(4)]
        public string ZT
        {
            get { return fZT; }
            set { SetPropertyValue<string>("ZT", ref fZT, value); }
        }
        string fYZT;
        [Size(4)]
        public string YZT
        {
            get { return fYZT; }
            set { SetPropertyValue<string>("YZT", ref fYZT, value); }
        }
        string fORISTATUSMC;
        [Size(16)]
        public string ORISTATUSMC
        {
            get { return fORISTATUSMC; }
            set { SetPropertyValue<string>("ORISTATUSMC", ref fORISTATUSMC, value); }
        }
        string fBZ;
        public string BZ
        {
            get { return fBZ; }
            set { SetPropertyValue<string>("BZ", ref fBZ, value); }
        }
        string fZTMC;
        [Size(40)]
        public string ZTMC
        {
            get { return fZTMC; }
            set { SetPropertyValue<string>("ZTMC", ref fZTMC, value); }
        }
        public VIEW_JT_C_CGSHPZ(Session session) : base(session) { }
        public VIEW_JT_C_CGSHPZ() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class VIEW_JT_C_FKPZ : XPLiteObject
    {
        string fSTATUSMC;
        [Size(16)]
        public string STATUSMC
        {
            get { return fSTATUSMC; }
            set { SetPropertyValue<string>("STATUSMC", ref fSTATUSMC, value); }
        }
        string fVOUCHERID;
        [Key]
        [Size(16)]
        public string VOUCHERID
        {
            get { return fVOUCHERID; }
            set { SetPropertyValue<string>("VOUCHERID", ref fVOUCHERID, value); }
        }
        string fVOUCHER_ID;
        [Size(22)]
        public string VOUCHER_ID
        {
            get { return fVOUCHER_ID; }
            set { SetPropertyValue<string>("VOUCHER_ID", ref fVOUCHER_ID, value); }
        }
        string fDWBH;
        [Size(100)]
        public string DWBH
        {
            get { return fDWBH; }
            set { SetPropertyValue<string>("DWBH", ref fDWBH, value); }
        }
        string fPZLXID;
        [Size(16)]
        public string PZLXID
        {
            get { return fPZLXID; }
            set { SetPropertyValue<string>("PZLXID", ref fPZLXID, value); }
        }
        string fCOMPANY;
        [Size(16)]
        public string COMPANY
        {
            get { return fCOMPANY; }
            set { SetPropertyValue<string>("COMPANY", ref fCOMPANY, value); }
        }
        string fVOUCHER_TYPE;
        [Size(16)]
        public string VOUCHER_TYPE
        {
            get { return fVOUCHER_TYPE; }
            set { SetPropertyValue<string>("VOUCHER_TYPE", ref fVOUCHER_TYPE, value); }
        }
        string fFISCAL_YEAR;
        [Size(4)]
        public string FISCAL_YEAR
        {
            get { return fFISCAL_YEAR; }
            set { SetPropertyValue<string>("FISCAL_YEAR", ref fFISCAL_YEAR, value); }
        }
        string fACCOUNTING_PERIOD;
        [Size(2)]
        public string ACCOUNTING_PERIOD
        {
            get { return fACCOUNTING_PERIOD; }
            set { SetPropertyValue<string>("ACCOUNTING_PERIOD", ref fACCOUNTING_PERIOD, value); }
        }
        long fATTACHMENT_NUMBER;
        public long ATTACHMENT_NUMBER
        {
            get { return fATTACHMENT_NUMBER; }
            set { SetPropertyValue<long>("ATTACHMENT_NUMBER", ref fATTACHMENT_NUMBER, value); }
        }
        DateTime fPREPAREDDATE;
        public DateTime PREPAREDDATE
        {
            get { return fPREPAREDDATE; }
            set { SetPropertyValue<DateTime>("PREPAREDDATE", ref fPREPAREDDATE, value); }
        }
        string fENTER;
        [Size(16)]
        public string ENTER
        {
            get { return fENTER; }
            set { SetPropertyValue<string>("ENTER", ref fENTER, value); }
        }
        string fZDRXM;
        [Size(16)]
        public string ZDRXM
        {
            get { return fZDRXM; }
            set { SetPropertyValue<string>("ZDRXM", ref fZDRXM, value); }
        }
        string fSHRXM;
        [Size(16)]
        public string SHRXM
        {
            get { return fSHRXM; }
            set { SetPropertyValue<string>("SHRXM", ref fSHRXM, value); }
        }
        string fJZRXM;
        [Size(16)]
        public string JZRXM
        {
            get { return fJZRXM; }
            set { SetPropertyValue<string>("JZRXM", ref fJZRXM, value); }
        }
        string fCNXM;
        [Size(16)]
        public string CNXM
        {
            get { return fCNXM; }
            set { SetPropertyValue<string>("CNXM", ref fCNXM, value); }
        }
        string fCASHIER;
        [Size(16)]
        public string CASHIER
        {
            get { return fCASHIER; }
            set { SetPropertyValue<string>("CASHIER", ref fCASHIER, value); }
        }
        string fSIGNATURE;
        [Size(2)]
        public string SIGNATURE
        {
            get { return fSIGNATURE; }
            set { SetPropertyValue<string>("SIGNATURE", ref fSIGNATURE, value); }
        }
        string fCHECKER;
        [Size(16)]
        public string CHECKER
        {
            get { return fCHECKER; }
            set { SetPropertyValue<string>("CHECKER", ref fCHECKER, value); }
        }
        DateTime fPOSTING_DATE;
        public DateTime POSTING_DATE
        {
            get { return fPOSTING_DATE; }
            set { SetPropertyValue<DateTime>("POSTING_DATE", ref fPOSTING_DATE, value); }
        }
        string fPOSTING_PERSON;
        [Size(16)]
        public string POSTING_PERSON
        {
            get { return fPOSTING_PERSON; }
            set { SetPropertyValue<string>("POSTING_PERSON", ref fPOSTING_PERSON, value); }
        }
        string fVOUCHER_MAKING_SYSTEM;
        [Size(16)]
        public string VOUCHER_MAKING_SYSTEM
        {
            get { return fVOUCHER_MAKING_SYSTEM; }
            set { SetPropertyValue<string>("VOUCHER_MAKING_SYSTEM", ref fVOUCHER_MAKING_SYSTEM, value); }
        }
        string fMEMO1;
        [Size(10)]
        public string MEMO1
        {
            get { return fMEMO1; }
            set { SetPropertyValue<string>("MEMO1", ref fMEMO1, value); }
        }
        string fMEMO2;
        [Size(10)]
        public string MEMO2
        {
            get { return fMEMO2; }
            set { SetPropertyValue<string>("MEMO2", ref fMEMO2, value); }
        }
        string fRESERVE1;
        [Size(10)]
        public string RESERVE1
        {
            get { return fRESERVE1; }
            set { SetPropertyValue<string>("RESERVE1", ref fRESERVE1, value); }
        }
        string fRESERVE2;
        [Size(10)]
        public string RESERVE2
        {
            get { return fRESERVE2; }
            set { SetPropertyValue<string>("RESERVE2", ref fRESERVE2, value); }
        }
        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }
        DateTime fCZRQ;
        public DateTime CZRQ
        {
            get { return fCZRQ; }
            set { SetPropertyValue<DateTime>("CZRQ", ref fCZRQ, value); }
        }
        string fZT;
        [Size(4)]
        public string ZT
        {
            get { return fZT; }
            set { SetPropertyValue<string>("ZT", ref fZT, value); }
        }
        string fYZT;
        [Size(4)]
        public string YZT
        {
            get { return fYZT; }
            set { SetPropertyValue<string>("YZT", ref fYZT, value); }
        }
        string fORISTATUSMC;
        [Size(16)]
        public string ORISTATUSMC
        {
            get { return fORISTATUSMC; }
            set { SetPropertyValue<string>("ORISTATUSMC", ref fORISTATUSMC, value); }
        }
        string fBZ;
        public string BZ
        {
            get { return fBZ; }
            set { SetPropertyValue<string>("BZ", ref fBZ, value); }
        }
        string fZTMC;
        [Size(40)]
        public string ZTMC
        {
            get { return fZTMC; }
            set { SetPropertyValue<string>("ZTMC", ref fZTMC, value); }
        }
        public VIEW_JT_C_FKPZ(Session session) : base(session) { }
        public VIEW_JT_C_FKPZ() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class VIEW_JT_C_FHPZ : XPLiteObject
    {
        string fSTATUSMC;
        [Size(16)]
        public string STATUSMC
        {
            get { return fSTATUSMC; }
            set { SetPropertyValue<string>("STATUSMC", ref fSTATUSMC, value); }
        }
        string fVOUCHERID;
        [Key]
        [Size(16)]
        public string VOUCHERID
        {
            get { return fVOUCHERID; }
            set { SetPropertyValue<string>("VOUCHERID", ref fVOUCHERID, value); }
        }
        string fVOUCHER_ID;
        [Size(22)]
        public string VOUCHER_ID
        {
            get { return fVOUCHER_ID; }
            set { SetPropertyValue<string>("VOUCHER_ID", ref fVOUCHER_ID, value); }
        }
        string fDWBH;
        [Size(100)]
        public string DWBH
        {
            get { return fDWBH; }
            set { SetPropertyValue<string>("DWBH", ref fDWBH, value); }
        }
        string fPZLXID;
        [Size(16)]
        public string PZLXID
        {
            get { return fPZLXID; }
            set { SetPropertyValue<string>("PZLXID", ref fPZLXID, value); }
        }
        string fCOMPANY;
        [Size(16)]
        public string COMPANY
        {
            get { return fCOMPANY; }
            set { SetPropertyValue<string>("COMPANY", ref fCOMPANY, value); }
        }
        string fVOUCHER_TYPE;
        [Size(16)]
        public string VOUCHER_TYPE
        {
            get { return fVOUCHER_TYPE; }
            set { SetPropertyValue<string>("VOUCHER_TYPE", ref fVOUCHER_TYPE, value); }
        }
        string fFISCAL_YEAR;
        [Size(4)]
        public string FISCAL_YEAR
        {
            get { return fFISCAL_YEAR; }
            set { SetPropertyValue<string>("FISCAL_YEAR", ref fFISCAL_YEAR, value); }
        }
        string fACCOUNTING_PERIOD;
        [Size(2)]
        public string ACCOUNTING_PERIOD
        {
            get { return fACCOUNTING_PERIOD; }
            set { SetPropertyValue<string>("ACCOUNTING_PERIOD", ref fACCOUNTING_PERIOD, value); }
        }
        long fATTACHMENT_NUMBER;
        public long ATTACHMENT_NUMBER
        {
            get { return fATTACHMENT_NUMBER; }
            set { SetPropertyValue<long>("ATTACHMENT_NUMBER", ref fATTACHMENT_NUMBER, value); }
        }
        DateTime fPREPAREDDATE;
        public DateTime PREPAREDDATE
        {
            get { return fPREPAREDDATE; }
            set { SetPropertyValue<DateTime>("PREPAREDDATE", ref fPREPAREDDATE, value); }
        }
        string fENTER;
        [Size(16)]
        public string ENTER
        {
            get { return fENTER; }
            set { SetPropertyValue<string>("ENTER", ref fENTER, value); }
        }
        string fZDRXM;
        [Size(16)]
        public string ZDRXM
        {
            get { return fZDRXM; }
            set { SetPropertyValue<string>("ZDRXM", ref fZDRXM, value); }
        }
        string fSHRXM;
        [Size(16)]
        public string SHRXM
        {
            get { return fSHRXM; }
            set { SetPropertyValue<string>("SHRXM", ref fSHRXM, value); }
        }
        string fJZRXM;
        [Size(16)]
        public string JZRXM
        {
            get { return fJZRXM; }
            set { SetPropertyValue<string>("JZRXM", ref fJZRXM, value); }
        }
        string fCNXM;
        [Size(16)]
        public string CNXM
        {
            get { return fCNXM; }
            set { SetPropertyValue<string>("CNXM", ref fCNXM, value); }
        }
        string fCASHIER;
        [Size(16)]
        public string CASHIER
        {
            get { return fCASHIER; }
            set { SetPropertyValue<string>("CASHIER", ref fCASHIER, value); }
        }
        string fSIGNATURE;
        [Size(2)]
        public string SIGNATURE
        {
            get { return fSIGNATURE; }
            set { SetPropertyValue<string>("SIGNATURE", ref fSIGNATURE, value); }
        }
        string fCHECKER;
        [Size(16)]
        public string CHECKER
        {
            get { return fCHECKER; }
            set { SetPropertyValue<string>("CHECKER", ref fCHECKER, value); }
        }
        DateTime fPOSTING_DATE;
        public DateTime POSTING_DATE
        {
            get { return fPOSTING_DATE; }
            set { SetPropertyValue<DateTime>("POSTING_DATE", ref fPOSTING_DATE, value); }
        }
        string fPOSTING_PERSON;
        [Size(16)]
        public string POSTING_PERSON
        {
            get { return fPOSTING_PERSON; }
            set { SetPropertyValue<string>("POSTING_PERSON", ref fPOSTING_PERSON, value); }
        }
        string fVOUCHER_MAKING_SYSTEM;
        [Size(16)]
        public string VOUCHER_MAKING_SYSTEM
        {
            get { return fVOUCHER_MAKING_SYSTEM; }
            set { SetPropertyValue<string>("VOUCHER_MAKING_SYSTEM", ref fVOUCHER_MAKING_SYSTEM, value); }
        }
        string fMEMO1;
        [Size(10)]
        public string MEMO1
        {
            get { return fMEMO1; }
            set { SetPropertyValue<string>("MEMO1", ref fMEMO1, value); }
        }
        string fMEMO2;
        [Size(10)]
        public string MEMO2
        {
            get { return fMEMO2; }
            set { SetPropertyValue<string>("MEMO2", ref fMEMO2, value); }
        }
        string fRESERVE1;
        [Size(10)]
        public string RESERVE1
        {
            get { return fRESERVE1; }
            set { SetPropertyValue<string>("RESERVE1", ref fRESERVE1, value); }
        }
        string fRESERVE2;
        [Size(10)]
        public string RESERVE2
        {
            get { return fRESERVE2; }
            set { SetPropertyValue<string>("RESERVE2", ref fRESERVE2, value); }
        }
        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }
        DateTime fCZRQ;
        public DateTime CZRQ
        {
            get { return fCZRQ; }
            set { SetPropertyValue<DateTime>("CZRQ", ref fCZRQ, value); }
        }
        string fZT;
        [Size(4)]
        public string ZT
        {
            get { return fZT; }
            set { SetPropertyValue<string>("ZT", ref fZT, value); }
        }
        string fYZT;
        [Size(4)]
        public string YZT
        {
            get { return fYZT; }
            set { SetPropertyValue<string>("YZT", ref fYZT, value); }
        }
        string fORISTATUSMC;
        [Size(16)]
        public string ORISTATUSMC
        {
            get { return fORISTATUSMC; }
            set { SetPropertyValue<string>("ORISTATUSMC", ref fORISTATUSMC, value); }
        }
        string fBZ;
        public string BZ
        {
            get { return fBZ; }
            set { SetPropertyValue<string>("BZ", ref fBZ, value); }
        }
        string fZTMC;
        [Size(40)]
        public string ZTMC
        {
            get { return fZTMC; }
            set { SetPropertyValue<string>("ZTMC", ref fZTMC, value); }
        }
        public VIEW_JT_C_FHPZ(Session session) : base(session) { }
        public VIEW_JT_C_FHPZ() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class VIEW_JT_C_YSPZ : XPLiteObject
    {
        string fSTATUSMC;
        [Size(16)]
        public string STATUSMC
        {
            get { return fSTATUSMC; }
            set { SetPropertyValue<string>("STATUSMC", ref fSTATUSMC, value); }
        }
        string fVOUCHERID;
        [Key]
        [Size(16)]
        public string VOUCHERID
        {
            get { return fVOUCHERID; }
            set { SetPropertyValue<string>("VOUCHERID", ref fVOUCHERID, value); }
        }
        string fVOUCHER_ID;
        [Size(22)]
        public string VOUCHER_ID
        {
            get { return fVOUCHER_ID; }
            set { SetPropertyValue<string>("VOUCHER_ID", ref fVOUCHER_ID, value); }
        }
        string fDWBH;
        [Size(100)]
        public string DWBH
        {
            get { return fDWBH; }
            set { SetPropertyValue<string>("DWBH", ref fDWBH, value); }
        }
        string fPZLXID;
        [Size(16)]
        public string PZLXID
        {
            get { return fPZLXID; }
            set { SetPropertyValue<string>("PZLXID", ref fPZLXID, value); }
        }
        string fCOMPANY;
        [Size(16)]
        public string COMPANY
        {
            get { return fCOMPANY; }
            set { SetPropertyValue<string>("COMPANY", ref fCOMPANY, value); }
        }
        string fVOUCHER_TYPE;
        [Size(16)]
        public string VOUCHER_TYPE
        {
            get { return fVOUCHER_TYPE; }
            set { SetPropertyValue<string>("VOUCHER_TYPE", ref fVOUCHER_TYPE, value); }
        }
        string fFISCAL_YEAR;
        [Size(4)]
        public string FISCAL_YEAR
        {
            get { return fFISCAL_YEAR; }
            set { SetPropertyValue<string>("FISCAL_YEAR", ref fFISCAL_YEAR, value); }
        }
        string fACCOUNTING_PERIOD;
        [Size(2)]
        public string ACCOUNTING_PERIOD
        {
            get { return fACCOUNTING_PERIOD; }
            set { SetPropertyValue<string>("ACCOUNTING_PERIOD", ref fACCOUNTING_PERIOD, value); }
        }
        long fATTACHMENT_NUMBER;
        public long ATTACHMENT_NUMBER
        {
            get { return fATTACHMENT_NUMBER; }
            set { SetPropertyValue<long>("ATTACHMENT_NUMBER", ref fATTACHMENT_NUMBER, value); }
        }
        DateTime fPREPAREDDATE;
        public DateTime PREPAREDDATE
        {
            get { return fPREPAREDDATE; }
            set { SetPropertyValue<DateTime>("PREPAREDDATE", ref fPREPAREDDATE, value); }
        }
        string fENTER;
        [Size(16)]
        public string ENTER
        {
            get { return fENTER; }
            set { SetPropertyValue<string>("ENTER", ref fENTER, value); }
        }
        string fZDRXM;
        [Size(16)]
        public string ZDRXM
        {
            get { return fZDRXM; }
            set { SetPropertyValue<string>("ZDRXM", ref fZDRXM, value); }
        }
        string fSHRXM;
        [Size(16)]
        public string SHRXM
        {
            get { return fSHRXM; }
            set { SetPropertyValue<string>("SHRXM", ref fSHRXM, value); }
        }
        string fJZRXM;
        [Size(16)]
        public string JZRXM
        {
            get { return fJZRXM; }
            set { SetPropertyValue<string>("JZRXM", ref fJZRXM, value); }
        }
        string fCNXM;
        [Size(16)]
        public string CNXM
        {
            get { return fCNXM; }
            set { SetPropertyValue<string>("CNXM", ref fCNXM, value); }
        }
        string fCASHIER;
        [Size(16)]
        public string CASHIER
        {
            get { return fCASHIER; }
            set { SetPropertyValue<string>("CASHIER", ref fCASHIER, value); }
        }
        string fSIGNATURE;
        [Size(2)]
        public string SIGNATURE
        {
            get { return fSIGNATURE; }
            set { SetPropertyValue<string>("SIGNATURE", ref fSIGNATURE, value); }
        }
        string fCHECKER;
        [Size(16)]
        public string CHECKER
        {
            get { return fCHECKER; }
            set { SetPropertyValue<string>("CHECKER", ref fCHECKER, value); }
        }
        DateTime fPOSTING_DATE;
        public DateTime POSTING_DATE
        {
            get { return fPOSTING_DATE; }
            set { SetPropertyValue<DateTime>("POSTING_DATE", ref fPOSTING_DATE, value); }
        }
        string fPOSTING_PERSON;
        [Size(16)]
        public string POSTING_PERSON
        {
            get { return fPOSTING_PERSON; }
            set { SetPropertyValue<string>("POSTING_PERSON", ref fPOSTING_PERSON, value); }
        }
        string fVOUCHER_MAKING_SYSTEM;
        [Size(16)]
        public string VOUCHER_MAKING_SYSTEM
        {
            get { return fVOUCHER_MAKING_SYSTEM; }
            set { SetPropertyValue<string>("VOUCHER_MAKING_SYSTEM", ref fVOUCHER_MAKING_SYSTEM, value); }
        }
        string fMEMO1;
        [Size(10)]
        public string MEMO1
        {
            get { return fMEMO1; }
            set { SetPropertyValue<string>("MEMO1", ref fMEMO1, value); }
        }
        string fMEMO2;
        [Size(10)]
        public string MEMO2
        {
            get { return fMEMO2; }
            set { SetPropertyValue<string>("MEMO2", ref fMEMO2, value); }
        }
        string fRESERVE1;
        [Size(10)]
        public string RESERVE1
        {
            get { return fRESERVE1; }
            set { SetPropertyValue<string>("RESERVE1", ref fRESERVE1, value); }
        }
        string fRESERVE2;
        [Size(10)]
        public string RESERVE2
        {
            get { return fRESERVE2; }
            set { SetPropertyValue<string>("RESERVE2", ref fRESERVE2, value); }
        }
        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }
        DateTime fCZRQ;
        public DateTime CZRQ
        {
            get { return fCZRQ; }
            set { SetPropertyValue<DateTime>("CZRQ", ref fCZRQ, value); }
        }
        string fZT;
        [Size(4)]
        public string ZT
        {
            get { return fZT; }
            set { SetPropertyValue<string>("ZT", ref fZT, value); }
        }
        string fYZT;
        [Size(4)]
        public string YZT
        {
            get { return fYZT; }
            set { SetPropertyValue<string>("YZT", ref fYZT, value); }
        }
        string fORISTATUSMC;
        [Size(16)]
        public string ORISTATUSMC
        {
            get { return fORISTATUSMC; }
            set { SetPropertyValue<string>("ORISTATUSMC", ref fORISTATUSMC, value); }
        }
        string fBZ;
        public string BZ
        {
            get { return fBZ; }
            set { SetPropertyValue<string>("BZ", ref fBZ, value); }
        }
        string fZTMC;
        [Size(40)]
        public string ZTMC
        {
            get { return fZTMC; }
            set { SetPropertyValue<string>("ZTMC", ref fZTMC, value); }
        }
        public VIEW_JT_C_YSPZ(Session session) : base(session) { }
        public VIEW_JT_C_YSPZ() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class VIEW_JT_C_SKPZ : XPLiteObject
    {
        string fSTATUSMC;
        [Size(16)]
        public string STATUSMC
        {
            get { return fSTATUSMC; }
            set { SetPropertyValue<string>("STATUSMC", ref fSTATUSMC, value); }
        }
        string fVOUCHERID;
        [Key]
        [Size(16)]
        public string VOUCHERID
        {
            get { return fVOUCHERID; }
            set { SetPropertyValue<string>("VOUCHERID", ref fVOUCHERID, value); }
        }
        string fVOUCHER_ID;
        [Size(22)]
        public string VOUCHER_ID
        {
            get { return fVOUCHER_ID; }
            set { SetPropertyValue<string>("VOUCHER_ID", ref fVOUCHER_ID, value); }
        }
        string fDWBH;
        [Size(100)]
        public string DWBH
        {
            get { return fDWBH; }
            set { SetPropertyValue<string>("DWBH", ref fDWBH, value); }
        }
        string fPZLXID;
        [Size(16)]
        public string PZLXID
        {
            get { return fPZLXID; }
            set { SetPropertyValue<string>("PZLXID", ref fPZLXID, value); }
        }
        string fCOMPANY;
        [Size(16)]
        public string COMPANY
        {
            get { return fCOMPANY; }
            set { SetPropertyValue<string>("COMPANY", ref fCOMPANY, value); }
        }
        string fVOUCHER_TYPE;
        [Size(16)]
        public string VOUCHER_TYPE
        {
            get { return fVOUCHER_TYPE; }
            set { SetPropertyValue<string>("VOUCHER_TYPE", ref fVOUCHER_TYPE, value); }
        }
        string fFISCAL_YEAR;
        [Size(4)]
        public string FISCAL_YEAR
        {
            get { return fFISCAL_YEAR; }
            set { SetPropertyValue<string>("FISCAL_YEAR", ref fFISCAL_YEAR, value); }
        }
        string fACCOUNTING_PERIOD;
        [Size(2)]
        public string ACCOUNTING_PERIOD
        {
            get { return fACCOUNTING_PERIOD; }
            set { SetPropertyValue<string>("ACCOUNTING_PERIOD", ref fACCOUNTING_PERIOD, value); }
        }
        long fATTACHMENT_NUMBER;
        public long ATTACHMENT_NUMBER
        {
            get { return fATTACHMENT_NUMBER; }
            set { SetPropertyValue<long>("ATTACHMENT_NUMBER", ref fATTACHMENT_NUMBER, value); }
        }
        DateTime fPREPAREDDATE;
        public DateTime PREPAREDDATE
        {
            get { return fPREPAREDDATE; }
            set { SetPropertyValue<DateTime>("PREPAREDDATE", ref fPREPAREDDATE, value); }
        }
        string fENTER;
        [Size(16)]
        public string ENTER
        {
            get { return fENTER; }
            set { SetPropertyValue<string>("ENTER", ref fENTER, value); }
        }
        string fZDRXM;
        [Size(16)]
        public string ZDRXM
        {
            get { return fZDRXM; }
            set { SetPropertyValue<string>("ZDRXM", ref fZDRXM, value); }
        }
        string fSHRXM;
        [Size(16)]
        public string SHRXM
        {
            get { return fSHRXM; }
            set { SetPropertyValue<string>("SHRXM", ref fSHRXM, value); }
        }
        string fJZRXM;
        [Size(16)]
        public string JZRXM
        {
            get { return fJZRXM; }
            set { SetPropertyValue<string>("JZRXM", ref fJZRXM, value); }
        }
        string fCNXM;
        [Size(16)]
        public string CNXM
        {
            get { return fCNXM; }
            set { SetPropertyValue<string>("CNXM", ref fCNXM, value); }
        }
        string fCASHIER;
        [Size(16)]
        public string CASHIER
        {
            get { return fCASHIER; }
            set { SetPropertyValue<string>("CASHIER", ref fCASHIER, value); }
        }
        string fSIGNATURE;
        [Size(2)]
        public string SIGNATURE
        {
            get { return fSIGNATURE; }
            set { SetPropertyValue<string>("SIGNATURE", ref fSIGNATURE, value); }
        }
        string fCHECKER;
        [Size(16)]
        public string CHECKER
        {
            get { return fCHECKER; }
            set { SetPropertyValue<string>("CHECKER", ref fCHECKER, value); }
        }
        DateTime fPOSTING_DATE;
        public DateTime POSTING_DATE
        {
            get { return fPOSTING_DATE; }
            set { SetPropertyValue<DateTime>("POSTING_DATE", ref fPOSTING_DATE, value); }
        }
        string fPOSTING_PERSON;
        [Size(16)]
        public string POSTING_PERSON
        {
            get { return fPOSTING_PERSON; }
            set { SetPropertyValue<string>("POSTING_PERSON", ref fPOSTING_PERSON, value); }
        }
        string fVOUCHER_MAKING_SYSTEM;
        [Size(16)]
        public string VOUCHER_MAKING_SYSTEM
        {
            get { return fVOUCHER_MAKING_SYSTEM; }
            set { SetPropertyValue<string>("VOUCHER_MAKING_SYSTEM", ref fVOUCHER_MAKING_SYSTEM, value); }
        }
        string fMEMO1;
        [Size(10)]
        public string MEMO1
        {
            get { return fMEMO1; }
            set { SetPropertyValue<string>("MEMO1", ref fMEMO1, value); }
        }
        string fMEMO2;
        [Size(10)]
        public string MEMO2
        {
            get { return fMEMO2; }
            set { SetPropertyValue<string>("MEMO2", ref fMEMO2, value); }
        }
        string fRESERVE1;
        [Size(10)]
        public string RESERVE1
        {
            get { return fRESERVE1; }
            set { SetPropertyValue<string>("RESERVE1", ref fRESERVE1, value); }
        }
        string fRESERVE2;
        [Size(10)]
        public string RESERVE2
        {
            get { return fRESERVE2; }
            set { SetPropertyValue<string>("RESERVE2", ref fRESERVE2, value); }
        }
        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }
        DateTime fCZRQ;
        public DateTime CZRQ
        {
            get { return fCZRQ; }
            set { SetPropertyValue<DateTime>("CZRQ", ref fCZRQ, value); }
        }
        string fZT;
        [Size(4)]
        public string ZT
        {
            get { return fZT; }
            set { SetPropertyValue<string>("ZT", ref fZT, value); }
        }
        string fYZT;
        [Size(4)]
        public string YZT
        {
            get { return fYZT; }
            set { SetPropertyValue<string>("YZT", ref fYZT, value); }
        }
        string fORISTATUSMC;
        [Size(16)]
        public string ORISTATUSMC
        {
            get { return fORISTATUSMC; }
            set { SetPropertyValue<string>("ORISTATUSMC", ref fORISTATUSMC, value); }
        }
        string fBZ;
        public string BZ
        {
            get { return fBZ; }
            set { SetPropertyValue<string>("BZ", ref fBZ, value); }
        }
        string fZTMC;
        [Size(40)]
        public string ZTMC
        {
            get { return fZTMC; }
            set { SetPropertyValue<string>("ZTMC", ref fZTMC, value); }
        }
        public VIEW_JT_C_SKPZ(Session session) : base(session) { }
        public VIEW_JT_C_SKPZ() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class VIEW_JT_C_DBPZ : XPLiteObject
    {
        string fSTATUSMC;
        [Size(16)]
        public string STATUSMC
        {
            get { return fSTATUSMC; }
            set { SetPropertyValue<string>("STATUSMC", ref fSTATUSMC, value); }
        }
        string fVOUCHERID;
        [Key]
        [Size(16)]
        public string VOUCHERID
        {
            get { return fVOUCHERID; }
            set { SetPropertyValue<string>("VOUCHERID", ref fVOUCHERID, value); }
        }
        string fVOUCHER_ID;
        [Size(22)]
        public string VOUCHER_ID
        {
            get { return fVOUCHER_ID; }
            set { SetPropertyValue<string>("VOUCHER_ID", ref fVOUCHER_ID, value); }
        }
        string fDWBH;
        [Size(100)]
        public string DWBH
        {
            get { return fDWBH; }
            set { SetPropertyValue<string>("DWBH", ref fDWBH, value); }
        }
        string fPZLXID;
        [Size(16)]
        public string PZLXID
        {
            get { return fPZLXID; }
            set { SetPropertyValue<string>("PZLXID", ref fPZLXID, value); }
        }
        string fCOMPANY;
        [Size(16)]
        public string COMPANY
        {
            get { return fCOMPANY; }
            set { SetPropertyValue<string>("COMPANY", ref fCOMPANY, value); }
        }
        string fVOUCHER_TYPE;
        [Size(16)]
        public string VOUCHER_TYPE
        {
            get { return fVOUCHER_TYPE; }
            set { SetPropertyValue<string>("VOUCHER_TYPE", ref fVOUCHER_TYPE, value); }
        }
        string fFISCAL_YEAR;
        [Size(4)]
        public string FISCAL_YEAR
        {
            get { return fFISCAL_YEAR; }
            set { SetPropertyValue<string>("FISCAL_YEAR", ref fFISCAL_YEAR, value); }
        }
        string fACCOUNTING_PERIOD;
        [Size(2)]
        public string ACCOUNTING_PERIOD
        {
            get { return fACCOUNTING_PERIOD; }
            set { SetPropertyValue<string>("ACCOUNTING_PERIOD", ref fACCOUNTING_PERIOD, value); }
        }
        long fATTACHMENT_NUMBER;
        public long ATTACHMENT_NUMBER
        {
            get { return fATTACHMENT_NUMBER; }
            set { SetPropertyValue<long>("ATTACHMENT_NUMBER", ref fATTACHMENT_NUMBER, value); }
        }
        DateTime fPREPAREDDATE;
        public DateTime PREPAREDDATE
        {
            get { return fPREPAREDDATE; }
            set { SetPropertyValue<DateTime>("PREPAREDDATE", ref fPREPAREDDATE, value); }
        }
        string fENTER;
        [Size(16)]
        public string ENTER
        {
            get { return fENTER; }
            set { SetPropertyValue<string>("ENTER", ref fENTER, value); }
        }
        string fZDRXM;
        [Size(16)]
        public string ZDRXM
        {
            get { return fZDRXM; }
            set { SetPropertyValue<string>("ZDRXM", ref fZDRXM, value); }
        }
        string fSHRXM;
        [Size(16)]
        public string SHRXM
        {
            get { return fSHRXM; }
            set { SetPropertyValue<string>("SHRXM", ref fSHRXM, value); }
        }
        string fJZRXM;
        [Size(16)]
        public string JZRXM
        {
            get { return fJZRXM; }
            set { SetPropertyValue<string>("JZRXM", ref fJZRXM, value); }
        }
        string fCNXM;
        [Size(16)]
        public string CNXM
        {
            get { return fCNXM; }
            set { SetPropertyValue<string>("CNXM", ref fCNXM, value); }
        }
        string fCASHIER;
        [Size(16)]
        public string CASHIER
        {
            get { return fCASHIER; }
            set { SetPropertyValue<string>("CASHIER", ref fCASHIER, value); }
        }
        string fSIGNATURE;
        [Size(2)]
        public string SIGNATURE
        {
            get { return fSIGNATURE; }
            set { SetPropertyValue<string>("SIGNATURE", ref fSIGNATURE, value); }
        }
        string fCHECKER;
        [Size(16)]
        public string CHECKER
        {
            get { return fCHECKER; }
            set { SetPropertyValue<string>("CHECKER", ref fCHECKER, value); }
        }
        DateTime fPOSTING_DATE;
        public DateTime POSTING_DATE
        {
            get { return fPOSTING_DATE; }
            set { SetPropertyValue<DateTime>("POSTING_DATE", ref fPOSTING_DATE, value); }
        }
        string fPOSTING_PERSON;
        [Size(16)]
        public string POSTING_PERSON
        {
            get { return fPOSTING_PERSON; }
            set { SetPropertyValue<string>("POSTING_PERSON", ref fPOSTING_PERSON, value); }
        }
        string fVOUCHER_MAKING_SYSTEM;
        [Size(16)]
        public string VOUCHER_MAKING_SYSTEM
        {
            get { return fVOUCHER_MAKING_SYSTEM; }
            set { SetPropertyValue<string>("VOUCHER_MAKING_SYSTEM", ref fVOUCHER_MAKING_SYSTEM, value); }
        }
        string fMEMO1;
        [Size(10)]
        public string MEMO1
        {
            get { return fMEMO1; }
            set { SetPropertyValue<string>("MEMO1", ref fMEMO1, value); }
        }
        string fMEMO2;
        [Size(10)]
        public string MEMO2
        {
            get { return fMEMO2; }
            set { SetPropertyValue<string>("MEMO2", ref fMEMO2, value); }
        }
        string fRESERVE1;
        [Size(10)]
        public string RESERVE1
        {
            get { return fRESERVE1; }
            set { SetPropertyValue<string>("RESERVE1", ref fRESERVE1, value); }
        }
        string fRESERVE2;
        [Size(10)]
        public string RESERVE2
        {
            get { return fRESERVE2; }
            set { SetPropertyValue<string>("RESERVE2", ref fRESERVE2, value); }
        }
        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }
        DateTime fCZRQ;
        public DateTime CZRQ
        {
            get { return fCZRQ; }
            set { SetPropertyValue<DateTime>("CZRQ", ref fCZRQ, value); }
        }
        string fZT;
        [Size(4)]
        public string ZT
        {
            get { return fZT; }
            set { SetPropertyValue<string>("ZT", ref fZT, value); }
        }
        string fYZT;
        [Size(4)]
        public string YZT
        {
            get { return fYZT; }
            set { SetPropertyValue<string>("YZT", ref fYZT, value); }
        }
        string fORISTATUSMC;
        [Size(16)]
        public string ORISTATUSMC
        {
            get { return fORISTATUSMC; }
            set { SetPropertyValue<string>("ORISTATUSMC", ref fORISTATUSMC, value); }
        }
        string fZTMC;
        [Size(40)]
        public string ZTMC
        {
            get { return fZTMC; }
            set { SetPropertyValue<string>("ZTMC", ref fZTMC, value); }
        }
        public VIEW_JT_C_DBPZ(Session session) : base(session) { }
        public VIEW_JT_C_DBPZ() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class VIEW_JT_C_BFPZ : XPLiteObject
    {
        string fSTATUSMC;
        [Size(16)]
        public string STATUSMC
        {
            get { return fSTATUSMC; }
            set { SetPropertyValue<string>("STATUSMC", ref fSTATUSMC, value); }
        }
        string fVOUCHERID;
        [Key]
        [Size(16)]
        public string VOUCHERID
        {
            get { return fVOUCHERID; }
            set { SetPropertyValue<string>("VOUCHERID", ref fVOUCHERID, value); }
        }
        string fVOUCHER_ID;
        [Size(22)]
        public string VOUCHER_ID
        {
            get { return fVOUCHER_ID; }
            set { SetPropertyValue<string>("VOUCHER_ID", ref fVOUCHER_ID, value); }
        }
        string fDWBH;
        [Size(100)]
        public string DWBH
        {
            get { return fDWBH; }
            set { SetPropertyValue<string>("DWBH", ref fDWBH, value); }
        }
        string fPZLXID;
        [Size(16)]
        public string PZLXID
        {
            get { return fPZLXID; }
            set { SetPropertyValue<string>("PZLXID", ref fPZLXID, value); }
        }
        string fCOMPANY;
        [Size(16)]
        public string COMPANY
        {
            get { return fCOMPANY; }
            set { SetPropertyValue<string>("COMPANY", ref fCOMPANY, value); }
        }
        string fVOUCHER_TYPE;
        [Size(16)]
        public string VOUCHER_TYPE
        {
            get { return fVOUCHER_TYPE; }
            set { SetPropertyValue<string>("VOUCHER_TYPE", ref fVOUCHER_TYPE, value); }
        }
        string fFISCAL_YEAR;
        [Size(4)]
        public string FISCAL_YEAR
        {
            get { return fFISCAL_YEAR; }
            set { SetPropertyValue<string>("FISCAL_YEAR", ref fFISCAL_YEAR, value); }
        }
        string fACCOUNTING_PERIOD;
        [Size(2)]
        public string ACCOUNTING_PERIOD
        {
            get { return fACCOUNTING_PERIOD; }
            set { SetPropertyValue<string>("ACCOUNTING_PERIOD", ref fACCOUNTING_PERIOD, value); }
        }
        long fATTACHMENT_NUMBER;
        public long ATTACHMENT_NUMBER
        {
            get { return fATTACHMENT_NUMBER; }
            set { SetPropertyValue<long>("ATTACHMENT_NUMBER", ref fATTACHMENT_NUMBER, value); }
        }
        DateTime fPREPAREDDATE;
        public DateTime PREPAREDDATE
        {
            get { return fPREPAREDDATE; }
            set { SetPropertyValue<DateTime>("PREPAREDDATE", ref fPREPAREDDATE, value); }
        }
        string fENTER;
        [Size(16)]
        public string ENTER
        {
            get { return fENTER; }
            set { SetPropertyValue<string>("ENTER", ref fENTER, value); }
        }
        string fZDRXM;
        [Size(16)]
        public string ZDRXM
        {
            get { return fZDRXM; }
            set { SetPropertyValue<string>("ZDRXM", ref fZDRXM, value); }
        }
        string fSHRXM;
        [Size(16)]
        public string SHRXM
        {
            get { return fSHRXM; }
            set { SetPropertyValue<string>("SHRXM", ref fSHRXM, value); }
        }
        string fJZRXM;
        [Size(16)]
        public string JZRXM
        {
            get { return fJZRXM; }
            set { SetPropertyValue<string>("JZRXM", ref fJZRXM, value); }
        }
        string fCNXM;
        [Size(16)]
        public string CNXM
        {
            get { return fCNXM; }
            set { SetPropertyValue<string>("CNXM", ref fCNXM, value); }
        }
        string fCASHIER;
        [Size(16)]
        public string CASHIER
        {
            get { return fCASHIER; }
            set { SetPropertyValue<string>("CASHIER", ref fCASHIER, value); }
        }
        string fSIGNATURE;
        [Size(2)]
        public string SIGNATURE
        {
            get { return fSIGNATURE; }
            set { SetPropertyValue<string>("SIGNATURE", ref fSIGNATURE, value); }
        }
        string fCHECKER;
        [Size(16)]
        public string CHECKER
        {
            get { return fCHECKER; }
            set { SetPropertyValue<string>("CHECKER", ref fCHECKER, value); }
        }
        DateTime fPOSTING_DATE;
        public DateTime POSTING_DATE
        {
            get { return fPOSTING_DATE; }
            set { SetPropertyValue<DateTime>("POSTING_DATE", ref fPOSTING_DATE, value); }
        }
        string fPOSTING_PERSON;
        [Size(16)]
        public string POSTING_PERSON
        {
            get { return fPOSTING_PERSON; }
            set { SetPropertyValue<string>("POSTING_PERSON", ref fPOSTING_PERSON, value); }
        }
        string fVOUCHER_MAKING_SYSTEM;
        [Size(16)]
        public string VOUCHER_MAKING_SYSTEM
        {
            get { return fVOUCHER_MAKING_SYSTEM; }
            set { SetPropertyValue<string>("VOUCHER_MAKING_SYSTEM", ref fVOUCHER_MAKING_SYSTEM, value); }
        }
        string fMEMO1;
        [Size(10)]
        public string MEMO1
        {
            get { return fMEMO1; }
            set { SetPropertyValue<string>("MEMO1", ref fMEMO1, value); }
        }
        string fMEMO2;
        [Size(10)]
        public string MEMO2
        {
            get { return fMEMO2; }
            set { SetPropertyValue<string>("MEMO2", ref fMEMO2, value); }
        }
        string fRESERVE1;
        [Size(10)]
        public string RESERVE1
        {
            get { return fRESERVE1; }
            set { SetPropertyValue<string>("RESERVE1", ref fRESERVE1, value); }
        }
        string fRESERVE2;
        [Size(10)]
        public string RESERVE2
        {
            get { return fRESERVE2; }
            set { SetPropertyValue<string>("RESERVE2", ref fRESERVE2, value); }
        }
        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }
        DateTime fCZRQ;
        public DateTime CZRQ
        {
            get { return fCZRQ; }
            set { SetPropertyValue<DateTime>("CZRQ", ref fCZRQ, value); }
        }
        string fZT;
        [Size(4)]
        public string ZT
        {
            get { return fZT; }
            set { SetPropertyValue<string>("ZT", ref fZT, value); }
        }
        string fYZT;
        [Size(4)]
        public string YZT
        {
            get { return fYZT; }
            set { SetPropertyValue<string>("YZT", ref fYZT, value); }
        }
        string fORISTATUSMC;
        [Size(16)]
        public string ORISTATUSMC
        {
            get { return fORISTATUSMC; }
            set { SetPropertyValue<string>("ORISTATUSMC", ref fORISTATUSMC, value); }
        }
        string fZTMC;
        [Size(40)]
        public string ZTMC
        {
            get { return fZTMC; }
            set { SetPropertyValue<string>("ZTMC", ref fZTMC, value); }
        }
        public VIEW_JT_C_BFPZ(Session session) : base(session) { }
        public VIEW_JT_C_BFPZ() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class VIEW_JT_C_PDYKPZ : XPLiteObject
    {
        string fSTATUSMC;
        [Size(16)]
        public string STATUSMC
        {
            get { return fSTATUSMC; }
            set { SetPropertyValue<string>("STATUSMC", ref fSTATUSMC, value); }
        }
        string fVOUCHERID;
        [Key]
        [Size(16)]
        public string VOUCHERID
        {
            get { return fVOUCHERID; }
            set { SetPropertyValue<string>("VOUCHERID", ref fVOUCHERID, value); }
        }
        string fVOUCHER_ID;
        [Size(22)]
        public string VOUCHER_ID
        {
            get { return fVOUCHER_ID; }
            set { SetPropertyValue<string>("VOUCHER_ID", ref fVOUCHER_ID, value); }
        }
        string fDWBH;
        [Size(100)]
        public string DWBH
        {
            get { return fDWBH; }
            set { SetPropertyValue<string>("DWBH", ref fDWBH, value); }
        }
        string fPZLXID;
        [Size(16)]
        public string PZLXID
        {
            get { return fPZLXID; }
            set { SetPropertyValue<string>("PZLXID", ref fPZLXID, value); }
        }
        string fCOMPANY;
        [Size(16)]
        public string COMPANY
        {
            get { return fCOMPANY; }
            set { SetPropertyValue<string>("COMPANY", ref fCOMPANY, value); }
        }
        string fVOUCHER_TYPE;
        [Size(16)]
        public string VOUCHER_TYPE
        {
            get { return fVOUCHER_TYPE; }
            set { SetPropertyValue<string>("VOUCHER_TYPE", ref fVOUCHER_TYPE, value); }
        }
        string fFISCAL_YEAR;
        [Size(4)]
        public string FISCAL_YEAR
        {
            get { return fFISCAL_YEAR; }
            set { SetPropertyValue<string>("FISCAL_YEAR", ref fFISCAL_YEAR, value); }
        }
        string fACCOUNTING_PERIOD;
        [Size(2)]
        public string ACCOUNTING_PERIOD
        {
            get { return fACCOUNTING_PERIOD; }
            set { SetPropertyValue<string>("ACCOUNTING_PERIOD", ref fACCOUNTING_PERIOD, value); }
        }
        long fATTACHMENT_NUMBER;
        public long ATTACHMENT_NUMBER
        {
            get { return fATTACHMENT_NUMBER; }
            set { SetPropertyValue<long>("ATTACHMENT_NUMBER", ref fATTACHMENT_NUMBER, value); }
        }
        DateTime fPREPAREDDATE;
        public DateTime PREPAREDDATE
        {
            get { return fPREPAREDDATE; }
            set { SetPropertyValue<DateTime>("PREPAREDDATE", ref fPREPAREDDATE, value); }
        }
        string fENTER;
        [Size(16)]
        public string ENTER
        {
            get { return fENTER; }
            set { SetPropertyValue<string>("ENTER", ref fENTER, value); }
        }
        string fZDRXM;
        [Size(16)]
        public string ZDRXM
        {
            get { return fZDRXM; }
            set { SetPropertyValue<string>("ZDRXM", ref fZDRXM, value); }
        }
        string fSHRXM;
        [Size(16)]
        public string SHRXM
        {
            get { return fSHRXM; }
            set { SetPropertyValue<string>("SHRXM", ref fSHRXM, value); }
        }
        string fJZRXM;
        [Size(16)]
        public string JZRXM
        {
            get { return fJZRXM; }
            set { SetPropertyValue<string>("JZRXM", ref fJZRXM, value); }
        }
        string fCNXM;
        [Size(16)]
        public string CNXM
        {
            get { return fCNXM; }
            set { SetPropertyValue<string>("CNXM", ref fCNXM, value); }
        }
        string fCASHIER;
        [Size(16)]
        public string CASHIER
        {
            get { return fCASHIER; }
            set { SetPropertyValue<string>("CASHIER", ref fCASHIER, value); }
        }
        string fSIGNATURE;
        [Size(2)]
        public string SIGNATURE
        {
            get { return fSIGNATURE; }
            set { SetPropertyValue<string>("SIGNATURE", ref fSIGNATURE, value); }
        }
        string fCHECKER;
        [Size(16)]
        public string CHECKER
        {
            get { return fCHECKER; }
            set { SetPropertyValue<string>("CHECKER", ref fCHECKER, value); }
        }
        DateTime fPOSTING_DATE;
        public DateTime POSTING_DATE
        {
            get { return fPOSTING_DATE; }
            set { SetPropertyValue<DateTime>("POSTING_DATE", ref fPOSTING_DATE, value); }
        }
        string fPOSTING_PERSON;
        [Size(16)]
        public string POSTING_PERSON
        {
            get { return fPOSTING_PERSON; }
            set { SetPropertyValue<string>("POSTING_PERSON", ref fPOSTING_PERSON, value); }
        }
        string fVOUCHER_MAKING_SYSTEM;
        [Size(16)]
        public string VOUCHER_MAKING_SYSTEM
        {
            get { return fVOUCHER_MAKING_SYSTEM; }
            set { SetPropertyValue<string>("VOUCHER_MAKING_SYSTEM", ref fVOUCHER_MAKING_SYSTEM, value); }
        }
        string fMEMO1;
        [Size(10)]
        public string MEMO1
        {
            get { return fMEMO1; }
            set { SetPropertyValue<string>("MEMO1", ref fMEMO1, value); }
        }
        string fMEMO2;
        [Size(10)]
        public string MEMO2
        {
            get { return fMEMO2; }
            set { SetPropertyValue<string>("MEMO2", ref fMEMO2, value); }
        }
        string fRESERVE1;
        [Size(10)]
        public string RESERVE1
        {
            get { return fRESERVE1; }
            set { SetPropertyValue<string>("RESERVE1", ref fRESERVE1, value); }
        }
        string fRESERVE2;
        [Size(10)]
        public string RESERVE2
        {
            get { return fRESERVE2; }
            set { SetPropertyValue<string>("RESERVE2", ref fRESERVE2, value); }
        }
        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }
        DateTime fCZRQ;
        public DateTime CZRQ
        {
            get { return fCZRQ; }
            set { SetPropertyValue<DateTime>("CZRQ", ref fCZRQ, value); }
        }
        string fZT;
        [Size(4)]
        public string ZT
        {
            get { return fZT; }
            set { SetPropertyValue<string>("ZT", ref fZT, value); }
        }
        string fYZT;
        [Size(4)]
        public string YZT
        {
            get { return fYZT; }
            set { SetPropertyValue<string>("YZT", ref fYZT, value); }
        }
        string fORISTATUSMC;
        [Size(16)]
        public string ORISTATUSMC
        {
            get { return fORISTATUSMC; }
            set { SetPropertyValue<string>("ORISTATUSMC", ref fORISTATUSMC, value); }
        }
        string fZTMC;
        [Size(40)]
        public string ZTMC
        {
            get { return fZTMC; }
            set { SetPropertyValue<string>("ZTMC", ref fZTMC, value); }
        }
        public VIEW_JT_C_PDYKPZ(Session session) : base(session) { }
        public VIEW_JT_C_PDYKPZ() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class VIEW_JT_C_JZCBPZ : XPLiteObject
    {
        string fSTATUSMC;
        [Size(16)]
        public string STATUSMC
        {
            get { return fSTATUSMC; }
            set { SetPropertyValue<string>("STATUSMC", ref fSTATUSMC, value); }
        }
        string fVOUCHERID;
        [Key]
        [Size(16)]
        public string VOUCHERID
        {
            get { return fVOUCHERID; }
            set { SetPropertyValue<string>("VOUCHERID", ref fVOUCHERID, value); }
        }
        string fVOUCHER_ID;
        [Size(22)]
        public string VOUCHER_ID
        {
            get { return fVOUCHER_ID; }
            set { SetPropertyValue<string>("VOUCHER_ID", ref fVOUCHER_ID, value); }
        }
        string fDWBH;
        [Size(100)]
        public string DWBH
        {
            get { return fDWBH; }
            set { SetPropertyValue<string>("DWBH", ref fDWBH, value); }
        }
        string fPZLXID;
        [Size(16)]
        public string PZLXID
        {
            get { return fPZLXID; }
            set { SetPropertyValue<string>("PZLXID", ref fPZLXID, value); }
        }
        string fCOMPANY;
        [Size(16)]
        public string COMPANY
        {
            get { return fCOMPANY; }
            set { SetPropertyValue<string>("COMPANY", ref fCOMPANY, value); }
        }
        string fVOUCHER_TYPE;
        [Size(16)]
        public string VOUCHER_TYPE
        {
            get { return fVOUCHER_TYPE; }
            set { SetPropertyValue<string>("VOUCHER_TYPE", ref fVOUCHER_TYPE, value); }
        }
        string fFISCAL_YEAR;
        [Size(4)]
        public string FISCAL_YEAR
        {
            get { return fFISCAL_YEAR; }
            set { SetPropertyValue<string>("FISCAL_YEAR", ref fFISCAL_YEAR, value); }
        }
        string fACCOUNTING_PERIOD;
        [Size(2)]
        public string ACCOUNTING_PERIOD
        {
            get { return fACCOUNTING_PERIOD; }
            set { SetPropertyValue<string>("ACCOUNTING_PERIOD", ref fACCOUNTING_PERIOD, value); }
        }
        long fATTACHMENT_NUMBER;
        public long ATTACHMENT_NUMBER
        {
            get { return fATTACHMENT_NUMBER; }
            set { SetPropertyValue<long>("ATTACHMENT_NUMBER", ref fATTACHMENT_NUMBER, value); }
        }
        DateTime fPREPAREDDATE;
        public DateTime PREPAREDDATE
        {
            get { return fPREPAREDDATE; }
            set { SetPropertyValue<DateTime>("PREPAREDDATE", ref fPREPAREDDATE, value); }
        }
        string fENTER;
        [Size(16)]
        public string ENTER
        {
            get { return fENTER; }
            set { SetPropertyValue<string>("ENTER", ref fENTER, value); }
        }
        string fZDRXM;
        [Size(16)]
        public string ZDRXM
        {
            get { return fZDRXM; }
            set { SetPropertyValue<string>("ZDRXM", ref fZDRXM, value); }
        }
        string fSHRXM;
        [Size(16)]
        public string SHRXM
        {
            get { return fSHRXM; }
            set { SetPropertyValue<string>("SHRXM", ref fSHRXM, value); }
        }
        string fJZRXM;
        [Size(16)]
        public string JZRXM
        {
            get { return fJZRXM; }
            set { SetPropertyValue<string>("JZRXM", ref fJZRXM, value); }
        }
        string fCNXM;
        [Size(16)]
        public string CNXM
        {
            get { return fCNXM; }
            set { SetPropertyValue<string>("CNXM", ref fCNXM, value); }
        }
        string fCASHIER;
        [Size(16)]
        public string CASHIER
        {
            get { return fCASHIER; }
            set { SetPropertyValue<string>("CASHIER", ref fCASHIER, value); }
        }
        string fSIGNATURE;
        [Size(2)]
        public string SIGNATURE
        {
            get { return fSIGNATURE; }
            set { SetPropertyValue<string>("SIGNATURE", ref fSIGNATURE, value); }
        }
        string fCHECKER;
        [Size(16)]
        public string CHECKER
        {
            get { return fCHECKER; }
            set { SetPropertyValue<string>("CHECKER", ref fCHECKER, value); }
        }
        DateTime fPOSTING_DATE;
        public DateTime POSTING_DATE
        {
            get { return fPOSTING_DATE; }
            set { SetPropertyValue<DateTime>("POSTING_DATE", ref fPOSTING_DATE, value); }
        }
        string fPOSTING_PERSON;
        [Size(16)]
        public string POSTING_PERSON
        {
            get { return fPOSTING_PERSON; }
            set { SetPropertyValue<string>("POSTING_PERSON", ref fPOSTING_PERSON, value); }
        }
        string fVOUCHER_MAKING_SYSTEM;
        [Size(16)]
        public string VOUCHER_MAKING_SYSTEM
        {
            get { return fVOUCHER_MAKING_SYSTEM; }
            set { SetPropertyValue<string>("VOUCHER_MAKING_SYSTEM", ref fVOUCHER_MAKING_SYSTEM, value); }
        }
        string fMEMO1;
        [Size(10)]
        public string MEMO1
        {
            get { return fMEMO1; }
            set { SetPropertyValue<string>("MEMO1", ref fMEMO1, value); }
        }
        string fMEMO2;
        [Size(10)]
        public string MEMO2
        {
            get { return fMEMO2; }
            set { SetPropertyValue<string>("MEMO2", ref fMEMO2, value); }
        }
        string fRESERVE1;
        [Size(10)]
        public string RESERVE1
        {
            get { return fRESERVE1; }
            set { SetPropertyValue<string>("RESERVE1", ref fRESERVE1, value); }
        }
        string fRESERVE2;
        [Size(10)]
        public string RESERVE2
        {
            get { return fRESERVE2; }
            set { SetPropertyValue<string>("RESERVE2", ref fRESERVE2, value); }
        }
        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }
        DateTime fCZRQ;
        public DateTime CZRQ
        {
            get { return fCZRQ; }
            set { SetPropertyValue<DateTime>("CZRQ", ref fCZRQ, value); }
        }
        string fZT;
        [Size(4)]
        public string ZT
        {
            get { return fZT; }
            set { SetPropertyValue<string>("ZT", ref fZT, value); }
        }
        string fYZT;
        [Size(4)]
        public string YZT
        {
            get { return fYZT; }
            set { SetPropertyValue<string>("YZT", ref fYZT, value); }
        }
        string fORISTATUSMC;
        [Size(16)]
        public string ORISTATUSMC
        {
            get { return fORISTATUSMC; }
            set { SetPropertyValue<string>("ORISTATUSMC", ref fORISTATUSMC, value); }
        }
        string fBZ;
        public string BZ
        {
            get { return fBZ; }
            set { SetPropertyValue<string>("BZ", ref fBZ, value); }
        }
        string fZTMC;
        [Size(40)]
        public string ZTMC
        {
            get { return fZTMC; }
            set { SetPropertyValue<string>("ZTMC", ref fZTMC, value); }
        }
        public VIEW_JT_C_JZCBPZ(Session session) : base(session) { }
        public VIEW_JT_C_JZCBPZ() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class VIEW_JT_X_XTDMX : XPLiteObject
    {
        string fXTDH;
        [Size(22)]
        public string XTDH
        {
            get { return fXTDH; }
            set { SetPropertyValue<string>("XTDH", ref fXTDH, value); }
        }
        string fKHMC;
        [Size(100)]
        public string KHMC
        {
            get { return fKHMC; }
            set { SetPropertyValue<string>("KHMC", ref fKHMC, value); }
        }
        string fPM;
        [Size(100)]
        public string PM
        {
            get { return fPM; }
            set { SetPropertyValue<string>("PM", ref fPM, value); }
        }

        string fSPBH;
        [Size(16)]
        public string SPBH
        {
            get { return fSPBH; }
            set { SetPropertyValue<string>("SPBH", ref fSPBH, value); }
        }
        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }
        string fXTDMXID;
        [Key]
        [Size(16)]
        public string XTDMXID
        {
            get { return fXTDMXID; }
            set { SetPropertyValue<string>("XTDMXID", ref fXTDMXID, value); }
        }
        string fXTDID;
        [Size(16)]
        public string XTDID
        {
            get { return fXTDID; }
            set { SetPropertyValue<string>("XTDID", ref fXTDID, value); }
        }
        string fBMSPKFMXID;
        [Size(16)]
        public string BMSPKFMXID
        {
            get { return fBMSPKFMXID; }
            set { SetPropertyValue<string>("BMSPKFMXID", ref fBMSPKFMXID, value); }
        }
        string fKHSPMXID;
        [Size(16)]
        public string KHSPMXID
        {
            get { return fKHSPMXID; }
            set { SetPropertyValue<string>("KHSPMXID", ref fKHSPMXID, value); }
        }
        string fSPXXID;
        [Size(16)]
        public string SPXXID
        {
            get { return fSPXXID; }
            set { SetPropertyValue<string>("SPXXID", ref fSPXXID, value); }
        }
        string fZDDM;
        [Size(15)]
        public string ZDDM
        {
            get { return fZDDM; }
            set { SetPropertyValue<string>("ZDDM", ref fZDDM, value); }
        }
        string fXSFSID;
        [Size(16)]
        public string XSFSID
        {
            get { return fXSFSID; }
            set { SetPropertyValue<string>("XSFSID", ref fXSFSID, value); }
        }
        decimal fDJ;
        public decimal DJ
        {
            get { return fDJ; }
            set { SetPropertyValue<decimal>("DJ", ref fDJ, value); }
        }
        decimal fXJ;
        public decimal XJ
        {
            get { return fXJ; }
            set { SetPropertyValue<decimal>("XJ", ref fXJ, value); }
        }
        decimal fXZ;
        public decimal XZ
        {
            get { return fXZ; }
            set { SetPropertyValue<decimal>("XZ", ref fXZ, value); }
        }
        byte fSL;
        public byte SL
        {
            get { return fSL; }
            set { SetPropertyValue<byte>("SL", ref fSL, value); }
        }
        long fXTSL;
        public long XTSL
        {
            get { return fXTSL; }
            set { SetPropertyValue<long>("XTSL", ref fXTSL, value); }
        }
        decimal fXTSY;
        public decimal XTSY
        {
            get { return fXTSY; }
            set { SetPropertyValue<decimal>("XTSY", ref fXTSY, value); }
        }
        decimal fXTMY;
        public decimal XTMY
        {
            get { return fXTMY; }
            set { SetPropertyValue<decimal>("XTMY", ref fXTMY, value); }
        }
        long fZZSL;
        public long ZZSL
        {
            get { return fZZSL; }
            set { SetPropertyValue<long>("ZZSL", ref fZZSL, value); }
        }
        decimal fZZSY;
        public decimal ZZSY
        {
            get { return fZZSY; }
            set { SetPropertyValue<decimal>("ZZSY", ref fZZSY, value); }
        }
        decimal fZZMY;
        public decimal ZZMY
        {
            get { return fZZMY; }
            set { SetPropertyValue<decimal>("ZZMY", ref fZZMY, value); }
        }
        long fYSSL;
        public long YSSL
        {
            get { return fYSSL; }
            set { SetPropertyValue<long>("YSSL", ref fYSSL, value); }
        }
        decimal fYSSY;
        public decimal YSSY
        {
            get { return fYSSY; }
            set { SetPropertyValue<decimal>("YSSY", ref fYSSY, value); }
        }
        decimal fYSMY;
        public decimal YSMY
        {
            get { return fYSMY; }
            set { SetPropertyValue<decimal>("YSMY", ref fYSMY, value); }
        }
        string fLYDJBID;
        [Size(16)]
        public string LYDJBID
        {
            get { return fLYDJBID; }
            set { SetPropertyValue<string>("LYDJBID", ref fLYDJBID, value); }
        }
        string fLYDJID;
        [Size(16)]
        public string LYDJID
        {
            get { return fLYDJID; }
            set { SetPropertyValue<string>("LYDJID", ref fLYDJID, value); }
        }
        string fLYBMID;
        [Size(16)]
        public string LYBMID
        {
            get { return fLYBMID; }
            set { SetPropertyValue<string>("LYBMID", ref fLYBMID, value); }
        }
        string fLYDJMXID;
        [Size(16)]
        public string LYDJMXID
        {
            get { return fLYDJMXID; }
            set { SetPropertyValue<string>("LYDJMXID", ref fLYDJMXID, value); }
        }
        string fZT;
        [Size(4)]
        public string ZT
        {
            get { return fZT; }
            set { SetPropertyValue<string>("ZT", ref fZT, value); }
        }
        string fYZT;
        [Size(4)]
        public string YZT
        {
            get { return fYZT; }
            set { SetPropertyValue<string>("YZT", ref fYZT, value); }
        }
        string fBZ;
        public string BZ
        {
            get { return fBZ; }
            set { SetPropertyValue<string>("BZ", ref fBZ, value); }
        }
        string fBJQDH;
        [Size(16)]
        public string BJQDH
        {
            get { return fBJQDH; }
            set { SetPropertyValue<string>("BJQDH", ref fBJQDH, value); }
        }
        decimal fJSHJ;
        public decimal JSHJ
        {
            get { return fJSHJ; }
            set { SetPropertyValue<decimal>("JSHJ", ref fJSHJ, value); }
        }
        decimal fZKE;
        public decimal ZKE
        {
            get { return fZKE; }
            set { SetPropertyValue<decimal>("ZKE", ref fZKE, value); }
        }
        DateTime fZDRQ;
        public DateTime ZDRQ
        {
            get { return fZDRQ; }
            set { SetPropertyValue<DateTime>("ZDRQ", ref fZDRQ, value); }
        }
        decimal fSE;
        public decimal SE
        {
            get { return fSE; }
            set { SetPropertyValue<decimal>("SE", ref fSE, value); }
        }
        decimal fWSJE;
        public decimal WSJE
        {
            get { return fWSJE; }
            set { SetPropertyValue<decimal>("WSJE", ref fWSJE, value); }
        }
        public VIEW_JT_X_XTDMX(Session session) : base(session) { }
        public VIEW_JT_X_XTDMX() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class VIEW_JT_C_CGSHPZMX : XPLiteObject
    {
        string fENTRY_ID;
        [Size(16)]
        public string ENTRY_ID
        {
            get { return fENTRY_ID; }
            set { SetPropertyValue<string>("ENTRY_ID", ref fENTRY_ID, value); }
        }
        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }
        string fKMMC;
        [Size(80)]
        public string KMMC
        {
            get { return fKMMC; }
            set { SetPropertyValue<string>("KMMC", ref fKMMC, value); }
        }        
        string fPZDMXID;
        [Key]
        [Size(16)]
        public string PZDMXID
        {
            get { return fPZDMXID; }
            set { SetPropertyValue<string>("PZDMXID", ref fPZDMXID, value); }
        }
        string fVOUCHERID;
        [Size(16)]
        public string VOUCHERID
        {
            get { return fVOUCHERID; }
            set { SetPropertyValue<string>("VOUCHERID", ref fVOUCHERID, value); }
        }    
        string fACCOUNT_CODE;
        [Size(16)]
        public string ACCOUNT_CODE
        {
            get { return fACCOUNT_CODE; }
            set { SetPropertyValue<string>("ACCOUNT_CODE", ref fACCOUNT_CODE, value); }
        }
        string fABSTRACT;
        [Size(200)]
        public string ABSTRACT
        {
            get { return fABSTRACT; }
            set { SetPropertyValue<string>("ABSTRACT", ref fABSTRACT, value); }
        }
        string fSETTLEMENT;
        [Size(22)]
        public string SETTLEMENT
        {
            get { return fSETTLEMENT; }
            set { SetPropertyValue<string>("SETTLEMENT", ref fSETTLEMENT, value); }
        }
        string fDOCUMENT_ID;
        [Size(22)]
        public string DOCUMENT_ID
        {
            get { return fDOCUMENT_ID; }
            set { SetPropertyValue<string>("DOCUMENT_ID", ref fDOCUMENT_ID, value); }
        }
        DateTime fDOCUMENT_DATE;
        public DateTime DOCUMENT_DATE
        {
            get { return fDOCUMENT_DATE; }
            set { SetPropertyValue<DateTime>("DOCUMENT_DATE", ref fDOCUMENT_DATE, value); }
        }
        string fCURRENCY;
        [Size(10)]
        public string CURRENCY
        {
            get { return fCURRENCY; }
            set { SetPropertyValue<string>("CURRENCY", ref fCURRENCY, value); }
        }
        decimal fUNIT_PRICE;
        public decimal UNIT_PRICE
        {
            get { return fUNIT_PRICE; }
            set { SetPropertyValue<decimal>("UNIT_PRICE", ref fUNIT_PRICE, value); }
        }
        decimal fEXCHANGE_RATE1;
        public decimal EXCHANGE_RATE1
        {
            get { return fEXCHANGE_RATE1; }
            set { SetPropertyValue<decimal>("EXCHANGE_RATE1", ref fEXCHANGE_RATE1, value); }
        }
        decimal fEXCHANGE_RATE2;
        public decimal EXCHANGE_RATE2
        {
            get { return fEXCHANGE_RATE2; }
            set { SetPropertyValue<decimal>("EXCHANGE_RATE2", ref fEXCHANGE_RATE2, value); }
        }
        long fDEBIT_QUANTITY;
        public long DEBIT_QUANTITY
        {
            get { return fDEBIT_QUANTITY; }
            set { SetPropertyValue<long>("DEBIT_QUANTITY", ref fDEBIT_QUANTITY, value); }
        }
        decimal fPRIMARY_DEBIT_AMOUNT;
        public decimal PRIMARY_DEBIT_AMOUNT
        {
            get { return fPRIMARY_DEBIT_AMOUNT; }
            set { SetPropertyValue<decimal>("PRIMARY_DEBIT_AMOUNT", ref fPRIMARY_DEBIT_AMOUNT, value); }
        }
        decimal fSECONDARY_DEBIT_AMOUNT;
        public decimal SECONDARY_DEBIT_AMOUNT
        {
            get { return fSECONDARY_DEBIT_AMOUNT; }
            set { SetPropertyValue<decimal>("SECONDARY_DEBIT_AMOUNT", ref fSECONDARY_DEBIT_AMOUNT, value); }
        }
        decimal fNATURAL_DEBIT_CURRENCY;
        public decimal NATURAL_DEBIT_CURRENCY
        {
            get { return fNATURAL_DEBIT_CURRENCY; }
            set { SetPropertyValue<decimal>("NATURAL_DEBIT_CURRENCY", ref fNATURAL_DEBIT_CURRENCY, value); }
        }
        long fCREDIT_QUANTITY;
        public long CREDIT_QUANTITY
        {
            get { return fCREDIT_QUANTITY; }
            set { SetPropertyValue<long>("CREDIT_QUANTITY", ref fCREDIT_QUANTITY, value); }
        }
        decimal fPRIMARY_CREDIT_AMOUNT;
        public decimal PRIMARY_CREDIT_AMOUNT
        {
            get { return fPRIMARY_CREDIT_AMOUNT; }
            set { SetPropertyValue<decimal>("PRIMARY_CREDIT_AMOUNT", ref fPRIMARY_CREDIT_AMOUNT, value); }
        }
        decimal fSECONDARY_CREDIT_AMOUNT;
        public decimal SECONDARY_CREDIT_AMOUNT
        {
            get { return fSECONDARY_CREDIT_AMOUNT; }
            set { SetPropertyValue<decimal>("SECONDARY_CREDIT_AMOUNT", ref fSECONDARY_CREDIT_AMOUNT, value); }
        }
        decimal fNATURAL_CREDIT_CURRENCY;
        public decimal NATURAL_CREDIT_CURRENCY
        {
            get { return fNATURAL_CREDIT_CURRENCY; }
            set { SetPropertyValue<decimal>("NATURAL_CREDIT_CURRENCY", ref fNATURAL_CREDIT_CURRENCY, value); }
        }
        string fBILL_TYPE;
        [Size(16)]
        public string BILL_TYPE
        {
            get { return fBILL_TYPE; }
            set { SetPropertyValue<string>("BILL_TYPE", ref fBILL_TYPE, value); }
        }
        string fBILL_ID;
        [Size(16)]
        public string BILL_ID
        {
            get { return fBILL_ID; }
            set { SetPropertyValue<string>("BILL_ID", ref fBILL_ID, value); }
        }
        DateTime fBILL_DATE;
        public DateTime BILL_DATE
        {
            get { return fBILL_DATE; }
            set { SetPropertyValue<DateTime>("BILL_DATE", ref fBILL_DATE, value); }
        }
        string fAUXILIARY_ACCOUNTING_ITEM1;
        [Size(60)]
        public string AUXILIARY_ACCOUNTING_ITEM1
        {
            get { return fAUXILIARY_ACCOUNTING_ITEM1; }
            set { SetPropertyValue<string>("AUXILIARY_ACCOUNTING_ITEM1", ref fAUXILIARY_ACCOUNTING_ITEM1, value); }
        }
        string fAUXILIARY_ACCOUNTING_ITEM2;
        [Size(60)]
        public string AUXILIARY_ACCOUNTING_ITEM2
        {
            get { return fAUXILIARY_ACCOUNTING_ITEM2; }
            set { SetPropertyValue<string>("AUXILIARY_ACCOUNTING_ITEM2", ref fAUXILIARY_ACCOUNTING_ITEM2, value); }
        }
        string fAUXILIARY_ACCOUNTING_ITEM3;
        [Size(60)]
        public string AUXILIARY_ACCOUNTING_ITEM3
        {
            get { return fAUXILIARY_ACCOUNTING_ITEM3; }
            set { SetPropertyValue<string>("AUXILIARY_ACCOUNTING_ITEM3", ref fAUXILIARY_ACCOUNTING_ITEM3, value); }
        }
        string fAUXILIARY_ACCOUNTING_ITEM4;
        [Size(60)]
        public string AUXILIARY_ACCOUNTING_ITEM4
        {
            get { return fAUXILIARY_ACCOUNTING_ITEM4; }
            set { SetPropertyValue<string>("AUXILIARY_ACCOUNTING_ITEM4", ref fAUXILIARY_ACCOUNTING_ITEM4, value); }
        }
        string fAUXILIARY_ACCOUNTING_ITEM5;
        [Size(60)]
        public string AUXILIARY_ACCOUNTING_ITEM5
        {
            get { return fAUXILIARY_ACCOUNTING_ITEM5; }
            set { SetPropertyValue<string>("AUXILIARY_ACCOUNTING_ITEM5", ref fAUXILIARY_ACCOUNTING_ITEM5, value); }
        }
        string fAUXILIARY_ACCOUNTING_ITEM6;
        [Size(60)]
        public string AUXILIARY_ACCOUNTING_ITEM6
        {
            get { return fAUXILIARY_ACCOUNTING_ITEM6; }
            set { SetPropertyValue<string>("AUXILIARY_ACCOUNTING_ITEM6", ref fAUXILIARY_ACCOUNTING_ITEM6, value); }
        }
        public VIEW_JT_C_CGSHPZMX(Session session) : base(session) { }
        public VIEW_JT_C_CGSHPZMX() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class VIEW_JT_C_FKPZMX : XPLiteObject
    {
        string fENTRY_ID;
        [Size(16)]
        public string ENTRY_ID
        {
            get { return fENTRY_ID; }
            set { SetPropertyValue<string>("ENTRY_ID", ref fENTRY_ID, value); }
        }
        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }
        string fKMMC;
        [Size(80)]
        public string KMMC
        {
            get { return fKMMC; }
            set { SetPropertyValue<string>("KMMC", ref fKMMC, value); }
        }
        string fPZDMXID;
        [Key]
        [Size(16)]
        public string PZDMXID
        {
            get { return fPZDMXID; }
            set { SetPropertyValue<string>("PZDMXID", ref fPZDMXID, value); }
        }
        string fVOUCHERID;
        [Size(16)]
        public string VOUCHERID
        {
            get { return fVOUCHERID; }
            set { SetPropertyValue<string>("VOUCHERID", ref fVOUCHERID, value); }
        }
        string fACCOUNT_CODE;
        [Size(16)]
        public string ACCOUNT_CODE
        {
            get { return fACCOUNT_CODE; }
            set { SetPropertyValue<string>("ACCOUNT_CODE", ref fACCOUNT_CODE, value); }
        }
        string fABSTRACT;
        [Size(200)]
        public string ABSTRACT
        {
            get { return fABSTRACT; }
            set { SetPropertyValue<string>("ABSTRACT", ref fABSTRACT, value); }
        }
        string fSETTLEMENT;
        [Size(22)]
        public string SETTLEMENT
        {
            get { return fSETTLEMENT; }
            set { SetPropertyValue<string>("SETTLEMENT", ref fSETTLEMENT, value); }
        }
        string fDOCUMENT_ID;
        [Size(22)]
        public string DOCUMENT_ID
        {
            get { return fDOCUMENT_ID; }
            set { SetPropertyValue<string>("DOCUMENT_ID", ref fDOCUMENT_ID, value); }
        }
        DateTime fDOCUMENT_DATE;
        public DateTime DOCUMENT_DATE
        {
            get { return fDOCUMENT_DATE; }
            set { SetPropertyValue<DateTime>("DOCUMENT_DATE", ref fDOCUMENT_DATE, value); }
        }
        string fCURRENCY;
        [Size(10)]
        public string CURRENCY
        {
            get { return fCURRENCY; }
            set { SetPropertyValue<string>("CURRENCY", ref fCURRENCY, value); }
        }
        decimal fUNIT_PRICE;
        public decimal UNIT_PRICE
        {
            get { return fUNIT_PRICE; }
            set { SetPropertyValue<decimal>("UNIT_PRICE", ref fUNIT_PRICE, value); }
        }
        decimal fEXCHANGE_RATE1;
        public decimal EXCHANGE_RATE1
        {
            get { return fEXCHANGE_RATE1; }
            set { SetPropertyValue<decimal>("EXCHANGE_RATE1", ref fEXCHANGE_RATE1, value); }
        }
        decimal fEXCHANGE_RATE2;
        public decimal EXCHANGE_RATE2
        {
            get { return fEXCHANGE_RATE2; }
            set { SetPropertyValue<decimal>("EXCHANGE_RATE2", ref fEXCHANGE_RATE2, value); }
        }
        long fDEBIT_QUANTITY;
        public long DEBIT_QUANTITY
        {
            get { return fDEBIT_QUANTITY; }
            set { SetPropertyValue<long>("DEBIT_QUANTITY", ref fDEBIT_QUANTITY, value); }
        }
        decimal fPRIMARY_DEBIT_AMOUNT;
        public decimal PRIMARY_DEBIT_AMOUNT
        {
            get { return fPRIMARY_DEBIT_AMOUNT; }
            set { SetPropertyValue<decimal>("PRIMARY_DEBIT_AMOUNT", ref fPRIMARY_DEBIT_AMOUNT, value); }
        }
        decimal fSECONDARY_DEBIT_AMOUNT;
        public decimal SECONDARY_DEBIT_AMOUNT
        {
            get { return fSECONDARY_DEBIT_AMOUNT; }
            set { SetPropertyValue<decimal>("SECONDARY_DEBIT_AMOUNT", ref fSECONDARY_DEBIT_AMOUNT, value); }
        }
        decimal fNATURAL_DEBIT_CURRENCY;
        public decimal NATURAL_DEBIT_CURRENCY
        {
            get { return fNATURAL_DEBIT_CURRENCY; }
            set { SetPropertyValue<decimal>("NATURAL_DEBIT_CURRENCY", ref fNATURAL_DEBIT_CURRENCY, value); }
        }
        long fCREDIT_QUANTITY;
        public long CREDIT_QUANTITY
        {
            get { return fCREDIT_QUANTITY; }
            set { SetPropertyValue<long>("CREDIT_QUANTITY", ref fCREDIT_QUANTITY, value); }
        }
        decimal fPRIMARY_CREDIT_AMOUNT;
        public decimal PRIMARY_CREDIT_AMOUNT
        {
            get { return fPRIMARY_CREDIT_AMOUNT; }
            set { SetPropertyValue<decimal>("PRIMARY_CREDIT_AMOUNT", ref fPRIMARY_CREDIT_AMOUNT, value); }
        }
        decimal fSECONDARY_CREDIT_AMOUNT;
        public decimal SECONDARY_CREDIT_AMOUNT
        {
            get { return fSECONDARY_CREDIT_AMOUNT; }
            set { SetPropertyValue<decimal>("SECONDARY_CREDIT_AMOUNT", ref fSECONDARY_CREDIT_AMOUNT, value); }
        }
        decimal fNATURAL_CREDIT_CURRENCY;
        public decimal NATURAL_CREDIT_CURRENCY
        {
            get { return fNATURAL_CREDIT_CURRENCY; }
            set { SetPropertyValue<decimal>("NATURAL_CREDIT_CURRENCY", ref fNATURAL_CREDIT_CURRENCY, value); }
        }
        string fBILL_TYPE;
        [Size(16)]
        public string BILL_TYPE
        {
            get { return fBILL_TYPE; }
            set { SetPropertyValue<string>("BILL_TYPE", ref fBILL_TYPE, value); }
        }
        string fBILL_ID;
        [Size(16)]
        public string BILL_ID
        {
            get { return fBILL_ID; }
            set { SetPropertyValue<string>("BILL_ID", ref fBILL_ID, value); }
        }
        DateTime fBILL_DATE;
        public DateTime BILL_DATE
        {
            get { return fBILL_DATE; }
            set { SetPropertyValue<DateTime>("BILL_DATE", ref fBILL_DATE, value); }
        }
        string fAUXILIARY_ACCOUNTING_ITEM1;
        [Size(60)]
        public string AUXILIARY_ACCOUNTING_ITEM1
        {
            get { return fAUXILIARY_ACCOUNTING_ITEM1; }
            set { SetPropertyValue<string>("AUXILIARY_ACCOUNTING_ITEM1", ref fAUXILIARY_ACCOUNTING_ITEM1, value); }
        }
        string fAUXILIARY_ACCOUNTING_ITEM2;
        [Size(60)]
        public string AUXILIARY_ACCOUNTING_ITEM2
        {
            get { return fAUXILIARY_ACCOUNTING_ITEM2; }
            set { SetPropertyValue<string>("AUXILIARY_ACCOUNTING_ITEM2", ref fAUXILIARY_ACCOUNTING_ITEM2, value); }
        }
        string fAUXILIARY_ACCOUNTING_ITEM3;
        [Size(60)]
        public string AUXILIARY_ACCOUNTING_ITEM3
        {
            get { return fAUXILIARY_ACCOUNTING_ITEM3; }
            set { SetPropertyValue<string>("AUXILIARY_ACCOUNTING_ITEM3", ref fAUXILIARY_ACCOUNTING_ITEM3, value); }
        }
        string fAUXILIARY_ACCOUNTING_ITEM4;
        [Size(60)]
        public string AUXILIARY_ACCOUNTING_ITEM4
        {
            get { return fAUXILIARY_ACCOUNTING_ITEM4; }
            set { SetPropertyValue<string>("AUXILIARY_ACCOUNTING_ITEM4", ref fAUXILIARY_ACCOUNTING_ITEM4, value); }
        }
        string fAUXILIARY_ACCOUNTING_ITEM5;
        [Size(60)]
        public string AUXILIARY_ACCOUNTING_ITEM5
        {
            get { return fAUXILIARY_ACCOUNTING_ITEM5; }
            set { SetPropertyValue<string>("AUXILIARY_ACCOUNTING_ITEM5", ref fAUXILIARY_ACCOUNTING_ITEM5, value); }
        }
        string fAUXILIARY_ACCOUNTING_ITEM6;
        [Size(60)]
        public string AUXILIARY_ACCOUNTING_ITEM6
        {
            get { return fAUXILIARY_ACCOUNTING_ITEM6; }
            set { SetPropertyValue<string>("AUXILIARY_ACCOUNTING_ITEM6", ref fAUXILIARY_ACCOUNTING_ITEM6, value); }
        }
        public VIEW_JT_C_FKPZMX(Session session) : base(session) { }
        public VIEW_JT_C_FKPZMX() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class VIEW_JT_C_FHPZMX : XPLiteObject
    {
        string fENTRY_ID;
        [Size(16)]
        public string ENTRY_ID
        {
            get { return fENTRY_ID; }
            set { SetPropertyValue<string>("ENTRY_ID", ref fENTRY_ID, value); }
        }
        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }
        string fKMMC;
        [Size(80)]
        public string KMMC
        {
            get { return fKMMC; }
            set { SetPropertyValue<string>("KMMC", ref fKMMC, value); }
        }
        string fPZDMXID;
        [Key]
        [Size(16)]
        public string PZDMXID
        {
            get { return fPZDMXID; }
            set { SetPropertyValue<string>("PZDMXID", ref fPZDMXID, value); }
        }
        string fVOUCHERID;
        [Size(16)]
        public string VOUCHERID
        {
            get { return fVOUCHERID; }
            set { SetPropertyValue<string>("VOUCHERID", ref fVOUCHERID, value); }
        }
        string fACCOUNT_CODE;
        [Size(16)]
        public string ACCOUNT_CODE
        {
            get { return fACCOUNT_CODE; }
            set { SetPropertyValue<string>("ACCOUNT_CODE", ref fACCOUNT_CODE, value); }
        }
        string fABSTRACT;
        [Size(200)]
        public string ABSTRACT
        {
            get { return fABSTRACT; }
            set { SetPropertyValue<string>("ABSTRACT", ref fABSTRACT, value); }
        }
        string fSETTLEMENT;
        [Size(22)]
        public string SETTLEMENT
        {
            get { return fSETTLEMENT; }
            set { SetPropertyValue<string>("SETTLEMENT", ref fSETTLEMENT, value); }
        }
        string fDOCUMENT_ID;
        [Size(22)]
        public string DOCUMENT_ID
        {
            get { return fDOCUMENT_ID; }
            set { SetPropertyValue<string>("DOCUMENT_ID", ref fDOCUMENT_ID, value); }
        }
        DateTime fDOCUMENT_DATE;
        public DateTime DOCUMENT_DATE
        {
            get { return fDOCUMENT_DATE; }
            set { SetPropertyValue<DateTime>("DOCUMENT_DATE", ref fDOCUMENT_DATE, value); }
        }
        string fCURRENCY;
        [Size(10)]
        public string CURRENCY
        {
            get { return fCURRENCY; }
            set { SetPropertyValue<string>("CURRENCY", ref fCURRENCY, value); }
        }
        decimal fUNIT_PRICE;
        public decimal UNIT_PRICE
        {
            get { return fUNIT_PRICE; }
            set { SetPropertyValue<decimal>("UNIT_PRICE", ref fUNIT_PRICE, value); }
        }
        decimal fEXCHANGE_RATE1;
        public decimal EXCHANGE_RATE1
        {
            get { return fEXCHANGE_RATE1; }
            set { SetPropertyValue<decimal>("EXCHANGE_RATE1", ref fEXCHANGE_RATE1, value); }
        }
        decimal fEXCHANGE_RATE2;
        public decimal EXCHANGE_RATE2
        {
            get { return fEXCHANGE_RATE2; }
            set { SetPropertyValue<decimal>("EXCHANGE_RATE2", ref fEXCHANGE_RATE2, value); }
        }
        long fDEBIT_QUANTITY;
        public long DEBIT_QUANTITY
        {
            get { return fDEBIT_QUANTITY; }
            set { SetPropertyValue<long>("DEBIT_QUANTITY", ref fDEBIT_QUANTITY, value); }
        }
        decimal fPRIMARY_DEBIT_AMOUNT;
        public decimal PRIMARY_DEBIT_AMOUNT
        {
            get { return fPRIMARY_DEBIT_AMOUNT; }
            set { SetPropertyValue<decimal>("PRIMARY_DEBIT_AMOUNT", ref fPRIMARY_DEBIT_AMOUNT, value); }
        }
        decimal fSECONDARY_DEBIT_AMOUNT;
        public decimal SECONDARY_DEBIT_AMOUNT
        {
            get { return fSECONDARY_DEBIT_AMOUNT; }
            set { SetPropertyValue<decimal>("SECONDARY_DEBIT_AMOUNT", ref fSECONDARY_DEBIT_AMOUNT, value); }
        }
        decimal fNATURAL_DEBIT_CURRENCY;
        public decimal NATURAL_DEBIT_CURRENCY
        {
            get { return fNATURAL_DEBIT_CURRENCY; }
            set { SetPropertyValue<decimal>("NATURAL_DEBIT_CURRENCY", ref fNATURAL_DEBIT_CURRENCY, value); }
        }
        long fCREDIT_QUANTITY;
        public long CREDIT_QUANTITY
        {
            get { return fCREDIT_QUANTITY; }
            set { SetPropertyValue<long>("CREDIT_QUANTITY", ref fCREDIT_QUANTITY, value); }
        }
        decimal fPRIMARY_CREDIT_AMOUNT;
        public decimal PRIMARY_CREDIT_AMOUNT
        {
            get { return fPRIMARY_CREDIT_AMOUNT; }
            set { SetPropertyValue<decimal>("PRIMARY_CREDIT_AMOUNT", ref fPRIMARY_CREDIT_AMOUNT, value); }
        }
        decimal fSECONDARY_CREDIT_AMOUNT;
        public decimal SECONDARY_CREDIT_AMOUNT
        {
            get { return fSECONDARY_CREDIT_AMOUNT; }
            set { SetPropertyValue<decimal>("SECONDARY_CREDIT_AMOUNT", ref fSECONDARY_CREDIT_AMOUNT, value); }
        }
        decimal fNATURAL_CREDIT_CURRENCY;
        public decimal NATURAL_CREDIT_CURRENCY
        {
            get { return fNATURAL_CREDIT_CURRENCY; }
            set { SetPropertyValue<decimal>("NATURAL_CREDIT_CURRENCY", ref fNATURAL_CREDIT_CURRENCY, value); }
        }
        string fBILL_TYPE;
        [Size(16)]
        public string BILL_TYPE
        {
            get { return fBILL_TYPE; }
            set { SetPropertyValue<string>("BILL_TYPE", ref fBILL_TYPE, value); }
        }
        string fBILL_ID;
        [Size(16)]
        public string BILL_ID
        {
            get { return fBILL_ID; }
            set { SetPropertyValue<string>("BILL_ID", ref fBILL_ID, value); }
        }
        DateTime fBILL_DATE;
        public DateTime BILL_DATE
        {
            get { return fBILL_DATE; }
            set { SetPropertyValue<DateTime>("BILL_DATE", ref fBILL_DATE, value); }
        }
        string fAUXILIARY_ACCOUNTING_ITEM1;
        [Size(60)]
        public string AUXILIARY_ACCOUNTING_ITEM1
        {
            get { return fAUXILIARY_ACCOUNTING_ITEM1; }
            set { SetPropertyValue<string>("AUXILIARY_ACCOUNTING_ITEM1", ref fAUXILIARY_ACCOUNTING_ITEM1, value); }
        }
        string fAUXILIARY_ACCOUNTING_ITEM2;
        [Size(60)]
        public string AUXILIARY_ACCOUNTING_ITEM2
        {
            get { return fAUXILIARY_ACCOUNTING_ITEM2; }
            set { SetPropertyValue<string>("AUXILIARY_ACCOUNTING_ITEM2", ref fAUXILIARY_ACCOUNTING_ITEM2, value); }
        }
        string fAUXILIARY_ACCOUNTING_ITEM3;
        [Size(60)]
        public string AUXILIARY_ACCOUNTING_ITEM3
        {
            get { return fAUXILIARY_ACCOUNTING_ITEM3; }
            set { SetPropertyValue<string>("AUXILIARY_ACCOUNTING_ITEM3", ref fAUXILIARY_ACCOUNTING_ITEM3, value); }
        }
        string fAUXILIARY_ACCOUNTING_ITEM4;
        [Size(60)]
        public string AUXILIARY_ACCOUNTING_ITEM4
        {
            get { return fAUXILIARY_ACCOUNTING_ITEM4; }
            set { SetPropertyValue<string>("AUXILIARY_ACCOUNTING_ITEM4", ref fAUXILIARY_ACCOUNTING_ITEM4, value); }
        }
        string fAUXILIARY_ACCOUNTING_ITEM5;
        [Size(60)]
        public string AUXILIARY_ACCOUNTING_ITEM5
        {
            get { return fAUXILIARY_ACCOUNTING_ITEM5; }
            set { SetPropertyValue<string>("AUXILIARY_ACCOUNTING_ITEM5", ref fAUXILIARY_ACCOUNTING_ITEM5, value); }
        }
        string fAUXILIARY_ACCOUNTING_ITEM6;
        [Size(60)]
        public string AUXILIARY_ACCOUNTING_ITEM6
        {
            get { return fAUXILIARY_ACCOUNTING_ITEM6; }
            set { SetPropertyValue<string>("AUXILIARY_ACCOUNTING_ITEM6", ref fAUXILIARY_ACCOUNTING_ITEM6, value); }
        }
        public VIEW_JT_C_FHPZMX(Session session) : base(session) { }
        public VIEW_JT_C_FHPZMX() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class VIEW_JT_C_YSPZMX : XPLiteObject
    {
        string fENTRY_ID;
        [Size(16)]
        public string ENTRY_ID
        {
            get { return fENTRY_ID; }
            set { SetPropertyValue<string>("ENTRY_ID", ref fENTRY_ID, value); }
        }
        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }
        string fKMMC;
        [Size(80)]
        public string KMMC
        {
            get { return fKMMC; }
            set { SetPropertyValue<string>("KMMC", ref fKMMC, value); }
        }
        string fPZDMXID;
        [Key]
        [Size(16)]
        public string PZDMXID
        {
            get { return fPZDMXID; }
            set { SetPropertyValue<string>("PZDMXID", ref fPZDMXID, value); }
        }
        string fVOUCHERID;
        [Size(16)]
        public string VOUCHERID
        {
            get { return fVOUCHERID; }
            set { SetPropertyValue<string>("VOUCHERID", ref fVOUCHERID, value); }
        }
        string fACCOUNT_CODE;
        [Size(16)]
        public string ACCOUNT_CODE
        {
            get { return fACCOUNT_CODE; }
            set { SetPropertyValue<string>("ACCOUNT_CODE", ref fACCOUNT_CODE, value); }
        }
        string fABSTRACT;
        [Size(200)]
        public string ABSTRACT
        {
            get { return fABSTRACT; }
            set { SetPropertyValue<string>("ABSTRACT", ref fABSTRACT, value); }
        }
        string fSETTLEMENT;
        [Size(22)]
        public string SETTLEMENT
        {
            get { return fSETTLEMENT; }
            set { SetPropertyValue<string>("SETTLEMENT", ref fSETTLEMENT, value); }
        }
        string fDOCUMENT_ID;
        [Size(22)]
        public string DOCUMENT_ID
        {
            get { return fDOCUMENT_ID; }
            set { SetPropertyValue<string>("DOCUMENT_ID", ref fDOCUMENT_ID, value); }
        }
        DateTime fDOCUMENT_DATE;
        public DateTime DOCUMENT_DATE
        {
            get { return fDOCUMENT_DATE; }
            set { SetPropertyValue<DateTime>("DOCUMENT_DATE", ref fDOCUMENT_DATE, value); }
        }
        string fCURRENCY;
        [Size(10)]
        public string CURRENCY
        {
            get { return fCURRENCY; }
            set { SetPropertyValue<string>("CURRENCY", ref fCURRENCY, value); }
        }
        decimal fUNIT_PRICE;
        public decimal UNIT_PRICE
        {
            get { return fUNIT_PRICE; }
            set { SetPropertyValue<decimal>("UNIT_PRICE", ref fUNIT_PRICE, value); }
        }
        decimal fEXCHANGE_RATE1;
        public decimal EXCHANGE_RATE1
        {
            get { return fEXCHANGE_RATE1; }
            set { SetPropertyValue<decimal>("EXCHANGE_RATE1", ref fEXCHANGE_RATE1, value); }
        }
        decimal fEXCHANGE_RATE2;
        public decimal EXCHANGE_RATE2
        {
            get { return fEXCHANGE_RATE2; }
            set { SetPropertyValue<decimal>("EXCHANGE_RATE2", ref fEXCHANGE_RATE2, value); }
        }
        long fDEBIT_QUANTITY;
        public long DEBIT_QUANTITY
        {
            get { return fDEBIT_QUANTITY; }
            set { SetPropertyValue<long>("DEBIT_QUANTITY", ref fDEBIT_QUANTITY, value); }
        }
        decimal fPRIMARY_DEBIT_AMOUNT;
        public decimal PRIMARY_DEBIT_AMOUNT
        {
            get { return fPRIMARY_DEBIT_AMOUNT; }
            set { SetPropertyValue<decimal>("PRIMARY_DEBIT_AMOUNT", ref fPRIMARY_DEBIT_AMOUNT, value); }
        }
        decimal fSECONDARY_DEBIT_AMOUNT;
        public decimal SECONDARY_DEBIT_AMOUNT
        {
            get { return fSECONDARY_DEBIT_AMOUNT; }
            set { SetPropertyValue<decimal>("SECONDARY_DEBIT_AMOUNT", ref fSECONDARY_DEBIT_AMOUNT, value); }
        }
        decimal fNATURAL_DEBIT_CURRENCY;
        public decimal NATURAL_DEBIT_CURRENCY
        {
            get { return fNATURAL_DEBIT_CURRENCY; }
            set { SetPropertyValue<decimal>("NATURAL_DEBIT_CURRENCY", ref fNATURAL_DEBIT_CURRENCY, value); }
        }
        long fCREDIT_QUANTITY;
        public long CREDIT_QUANTITY
        {
            get { return fCREDIT_QUANTITY; }
            set { SetPropertyValue<long>("CREDIT_QUANTITY", ref fCREDIT_QUANTITY, value); }
        }
        decimal fPRIMARY_CREDIT_AMOUNT;
        public decimal PRIMARY_CREDIT_AMOUNT
        {
            get { return fPRIMARY_CREDIT_AMOUNT; }
            set { SetPropertyValue<decimal>("PRIMARY_CREDIT_AMOUNT", ref fPRIMARY_CREDIT_AMOUNT, value); }
        }
        decimal fSECONDARY_CREDIT_AMOUNT;
        public decimal SECONDARY_CREDIT_AMOUNT
        {
            get { return fSECONDARY_CREDIT_AMOUNT; }
            set { SetPropertyValue<decimal>("SECONDARY_CREDIT_AMOUNT", ref fSECONDARY_CREDIT_AMOUNT, value); }
        }
        decimal fNATURAL_CREDIT_CURRENCY;
        public decimal NATURAL_CREDIT_CURRENCY
        {
            get { return fNATURAL_CREDIT_CURRENCY; }
            set { SetPropertyValue<decimal>("NATURAL_CREDIT_CURRENCY", ref fNATURAL_CREDIT_CURRENCY, value); }
        }
        string fBILL_TYPE;
        [Size(16)]
        public string BILL_TYPE
        {
            get { return fBILL_TYPE; }
            set { SetPropertyValue<string>("BILL_TYPE", ref fBILL_TYPE, value); }
        }
        string fBILL_ID;
        [Size(16)]
        public string BILL_ID
        {
            get { return fBILL_ID; }
            set { SetPropertyValue<string>("BILL_ID", ref fBILL_ID, value); }
        }
        DateTime fBILL_DATE;
        public DateTime BILL_DATE
        {
            get { return fBILL_DATE; }
            set { SetPropertyValue<DateTime>("BILL_DATE", ref fBILL_DATE, value); }
        }
        string fAUXILIARY_ACCOUNTING_ITEM1;
        [Size(60)]
        public string AUXILIARY_ACCOUNTING_ITEM1
        {
            get { return fAUXILIARY_ACCOUNTING_ITEM1; }
            set { SetPropertyValue<string>("AUXILIARY_ACCOUNTING_ITEM1", ref fAUXILIARY_ACCOUNTING_ITEM1, value); }
        }
        string fAUXILIARY_ACCOUNTING_ITEM2;
        [Size(60)]
        public string AUXILIARY_ACCOUNTING_ITEM2
        {
            get { return fAUXILIARY_ACCOUNTING_ITEM2; }
            set { SetPropertyValue<string>("AUXILIARY_ACCOUNTING_ITEM2", ref fAUXILIARY_ACCOUNTING_ITEM2, value); }
        }
        string fAUXILIARY_ACCOUNTING_ITEM3;
        [Size(60)]
        public string AUXILIARY_ACCOUNTING_ITEM3
        {
            get { return fAUXILIARY_ACCOUNTING_ITEM3; }
            set { SetPropertyValue<string>("AUXILIARY_ACCOUNTING_ITEM3", ref fAUXILIARY_ACCOUNTING_ITEM3, value); }
        }
        string fAUXILIARY_ACCOUNTING_ITEM4;
        [Size(60)]
        public string AUXILIARY_ACCOUNTING_ITEM4
        {
            get { return fAUXILIARY_ACCOUNTING_ITEM4; }
            set { SetPropertyValue<string>("AUXILIARY_ACCOUNTING_ITEM4", ref fAUXILIARY_ACCOUNTING_ITEM4, value); }
        }
        string fAUXILIARY_ACCOUNTING_ITEM5;
        [Size(60)]
        public string AUXILIARY_ACCOUNTING_ITEM5
        {
            get { return fAUXILIARY_ACCOUNTING_ITEM5; }
            set { SetPropertyValue<string>("AUXILIARY_ACCOUNTING_ITEM5", ref fAUXILIARY_ACCOUNTING_ITEM5, value); }
        }
        string fAUXILIARY_ACCOUNTING_ITEM6;
        [Size(60)]
        public string AUXILIARY_ACCOUNTING_ITEM6
        {
            get { return fAUXILIARY_ACCOUNTING_ITEM6; }
            set { SetPropertyValue<string>("AUXILIARY_ACCOUNTING_ITEM6", ref fAUXILIARY_ACCOUNTING_ITEM6, value); }
        }
        public VIEW_JT_C_YSPZMX(Session session) : base(session) { }
        public VIEW_JT_C_YSPZMX() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class VIEW_JT_C_SKPZMX : XPLiteObject
    {
        string fENTRY_ID;
        [Size(16)]
        public string ENTRY_ID
        {
            get { return fENTRY_ID; }
            set { SetPropertyValue<string>("ENTRY_ID", ref fENTRY_ID, value); }
        }
        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }
        string fKMMC;
        [Size(80)]
        public string KMMC
        {
            get { return fKMMC; }
            set { SetPropertyValue<string>("KMMC", ref fKMMC, value); }
        }
        string fPZDMXID;
        [Key]
        [Size(16)]
        public string PZDMXID
        {
            get { return fPZDMXID; }
            set { SetPropertyValue<string>("PZDMXID", ref fPZDMXID, value); }
        }
        string fVOUCHERID;
        [Size(16)]
        public string VOUCHERID
        {
            get { return fVOUCHERID; }
            set { SetPropertyValue<string>("VOUCHERID", ref fVOUCHERID, value); }
        }
        string fACCOUNT_CODE;
        [Size(16)]
        public string ACCOUNT_CODE
        {
            get { return fACCOUNT_CODE; }
            set { SetPropertyValue<string>("ACCOUNT_CODE", ref fACCOUNT_CODE, value); }
        }
        string fABSTRACT;
        [Size(200)]
        public string ABSTRACT
        {
            get { return fABSTRACT; }
            set { SetPropertyValue<string>("ABSTRACT", ref fABSTRACT, value); }
        }
        string fSETTLEMENT;
        [Size(22)]
        public string SETTLEMENT
        {
            get { return fSETTLEMENT; }
            set { SetPropertyValue<string>("SETTLEMENT", ref fSETTLEMENT, value); }
        }
        string fDOCUMENT_ID;
        [Size(22)]
        public string DOCUMENT_ID
        {
            get { return fDOCUMENT_ID; }
            set { SetPropertyValue<string>("DOCUMENT_ID", ref fDOCUMENT_ID, value); }
        }
        DateTime fDOCUMENT_DATE;
        public DateTime DOCUMENT_DATE
        {
            get { return fDOCUMENT_DATE; }
            set { SetPropertyValue<DateTime>("DOCUMENT_DATE", ref fDOCUMENT_DATE, value); }
        }
        string fCURRENCY;
        [Size(10)]
        public string CURRENCY
        {
            get { return fCURRENCY; }
            set { SetPropertyValue<string>("CURRENCY", ref fCURRENCY, value); }
        }
        decimal fUNIT_PRICE;
        public decimal UNIT_PRICE
        {
            get { return fUNIT_PRICE; }
            set { SetPropertyValue<decimal>("UNIT_PRICE", ref fUNIT_PRICE, value); }
        }
        decimal fEXCHANGE_RATE1;
        public decimal EXCHANGE_RATE1
        {
            get { return fEXCHANGE_RATE1; }
            set { SetPropertyValue<decimal>("EXCHANGE_RATE1", ref fEXCHANGE_RATE1, value); }
        }
        decimal fEXCHANGE_RATE2;
        public decimal EXCHANGE_RATE2
        {
            get { return fEXCHANGE_RATE2; }
            set { SetPropertyValue<decimal>("EXCHANGE_RATE2", ref fEXCHANGE_RATE2, value); }
        }
        long fDEBIT_QUANTITY;
        public long DEBIT_QUANTITY
        {
            get { return fDEBIT_QUANTITY; }
            set { SetPropertyValue<long>("DEBIT_QUANTITY", ref fDEBIT_QUANTITY, value); }
        }
        decimal fPRIMARY_DEBIT_AMOUNT;
        public decimal PRIMARY_DEBIT_AMOUNT
        {
            get { return fPRIMARY_DEBIT_AMOUNT; }
            set { SetPropertyValue<decimal>("PRIMARY_DEBIT_AMOUNT", ref fPRIMARY_DEBIT_AMOUNT, value); }
        }
        decimal fSECONDARY_DEBIT_AMOUNT;
        public decimal SECONDARY_DEBIT_AMOUNT
        {
            get { return fSECONDARY_DEBIT_AMOUNT; }
            set { SetPropertyValue<decimal>("SECONDARY_DEBIT_AMOUNT", ref fSECONDARY_DEBIT_AMOUNT, value); }
        }
        decimal fNATURAL_DEBIT_CURRENCY;
        public decimal NATURAL_DEBIT_CURRENCY
        {
            get { return fNATURAL_DEBIT_CURRENCY; }
            set { SetPropertyValue<decimal>("NATURAL_DEBIT_CURRENCY", ref fNATURAL_DEBIT_CURRENCY, value); }
        }
        long fCREDIT_QUANTITY;
        public long CREDIT_QUANTITY
        {
            get { return fCREDIT_QUANTITY; }
            set { SetPropertyValue<long>("CREDIT_QUANTITY", ref fCREDIT_QUANTITY, value); }
        }
        decimal fPRIMARY_CREDIT_AMOUNT;
        public decimal PRIMARY_CREDIT_AMOUNT
        {
            get { return fPRIMARY_CREDIT_AMOUNT; }
            set { SetPropertyValue<decimal>("PRIMARY_CREDIT_AMOUNT", ref fPRIMARY_CREDIT_AMOUNT, value); }
        }
        decimal fSECONDARY_CREDIT_AMOUNT;
        public decimal SECONDARY_CREDIT_AMOUNT
        {
            get { return fSECONDARY_CREDIT_AMOUNT; }
            set { SetPropertyValue<decimal>("SECONDARY_CREDIT_AMOUNT", ref fSECONDARY_CREDIT_AMOUNT, value); }
        }
        decimal fNATURAL_CREDIT_CURRENCY;
        public decimal NATURAL_CREDIT_CURRENCY
        {
            get { return fNATURAL_CREDIT_CURRENCY; }
            set { SetPropertyValue<decimal>("NATURAL_CREDIT_CURRENCY", ref fNATURAL_CREDIT_CURRENCY, value); }
        }
        string fBILL_TYPE;
        [Size(16)]
        public string BILL_TYPE
        {
            get { return fBILL_TYPE; }
            set { SetPropertyValue<string>("BILL_TYPE", ref fBILL_TYPE, value); }
        }
        string fBILL_ID;
        [Size(16)]
        public string BILL_ID
        {
            get { return fBILL_ID; }
            set { SetPropertyValue<string>("BILL_ID", ref fBILL_ID, value); }
        }
        DateTime fBILL_DATE;
        public DateTime BILL_DATE
        {
            get { return fBILL_DATE; }
            set { SetPropertyValue<DateTime>("BILL_DATE", ref fBILL_DATE, value); }
        }
        string fAUXILIARY_ACCOUNTING_ITEM1;
        [Size(60)]
        public string AUXILIARY_ACCOUNTING_ITEM1
        {
            get { return fAUXILIARY_ACCOUNTING_ITEM1; }
            set { SetPropertyValue<string>("AUXILIARY_ACCOUNTING_ITEM1", ref fAUXILIARY_ACCOUNTING_ITEM1, value); }
        }
        string fAUXILIARY_ACCOUNTING_ITEM2;
        [Size(60)]
        public string AUXILIARY_ACCOUNTING_ITEM2
        {
            get { return fAUXILIARY_ACCOUNTING_ITEM2; }
            set { SetPropertyValue<string>("AUXILIARY_ACCOUNTING_ITEM2", ref fAUXILIARY_ACCOUNTING_ITEM2, value); }
        }
        string fAUXILIARY_ACCOUNTING_ITEM3;
        [Size(60)]
        public string AUXILIARY_ACCOUNTING_ITEM3
        {
            get { return fAUXILIARY_ACCOUNTING_ITEM3; }
            set { SetPropertyValue<string>("AUXILIARY_ACCOUNTING_ITEM3", ref fAUXILIARY_ACCOUNTING_ITEM3, value); }
        }
        string fAUXILIARY_ACCOUNTING_ITEM4;
        [Size(60)]
        public string AUXILIARY_ACCOUNTING_ITEM4
        {
            get { return fAUXILIARY_ACCOUNTING_ITEM4; }
            set { SetPropertyValue<string>("AUXILIARY_ACCOUNTING_ITEM4", ref fAUXILIARY_ACCOUNTING_ITEM4, value); }
        }
        string fAUXILIARY_ACCOUNTING_ITEM5;
        [Size(60)]
        public string AUXILIARY_ACCOUNTING_ITEM5
        {
            get { return fAUXILIARY_ACCOUNTING_ITEM5; }
            set { SetPropertyValue<string>("AUXILIARY_ACCOUNTING_ITEM5", ref fAUXILIARY_ACCOUNTING_ITEM5, value); }
        }
        string fAUXILIARY_ACCOUNTING_ITEM6;
        [Size(60)]
        public string AUXILIARY_ACCOUNTING_ITEM6
        {
            get { return fAUXILIARY_ACCOUNTING_ITEM6; }
            set { SetPropertyValue<string>("AUXILIARY_ACCOUNTING_ITEM6", ref fAUXILIARY_ACCOUNTING_ITEM6, value); }
        }
        public VIEW_JT_C_SKPZMX(Session session) : base(session) { }
        public VIEW_JT_C_SKPZMX() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class VIEW_JT_C_DBPZMX : XPLiteObject
    {
        string fENTRY_ID;
        [Size(16)]
        public string ENTRY_ID
        {
            get { return fENTRY_ID; }
            set { SetPropertyValue<string>("ENTRY_ID", ref fENTRY_ID, value); }
        }
        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }
        string fKMMC;
        [Size(80)]
        public string KMMC
        {
            get { return fKMMC; }
            set { SetPropertyValue<string>("KMMC", ref fKMMC, value); }
        }
        string fPZDMXID;
        [Key]
        [Size(16)]
        public string PZDMXID
        {
            get { return fPZDMXID; }
            set { SetPropertyValue<string>("PZDMXID", ref fPZDMXID, value); }
        }
        string fVOUCHERID;
        [Size(16)]
        public string VOUCHERID
        {
            get { return fVOUCHERID; }
            set { SetPropertyValue<string>("VOUCHERID", ref fVOUCHERID, value); }
        }
        string fACCOUNT_CODE;
        [Size(16)]
        public string ACCOUNT_CODE
        {
            get { return fACCOUNT_CODE; }
            set { SetPropertyValue<string>("ACCOUNT_CODE", ref fACCOUNT_CODE, value); }
        }
        string fABSTRACT;
        [Size(200)]
        public string ABSTRACT
        {
            get { return fABSTRACT; }
            set { SetPropertyValue<string>("ABSTRACT", ref fABSTRACT, value); }
        }
        string fSETTLEMENT;
        [Size(22)]
        public string SETTLEMENT
        {
            get { return fSETTLEMENT; }
            set { SetPropertyValue<string>("SETTLEMENT", ref fSETTLEMENT, value); }
        }
        string fDOCUMENT_ID;
        [Size(22)]
        public string DOCUMENT_ID
        {
            get { return fDOCUMENT_ID; }
            set { SetPropertyValue<string>("DOCUMENT_ID", ref fDOCUMENT_ID, value); }
        }
        DateTime fDOCUMENT_DATE;
        public DateTime DOCUMENT_DATE
        {
            get { return fDOCUMENT_DATE; }
            set { SetPropertyValue<DateTime>("DOCUMENT_DATE", ref fDOCUMENT_DATE, value); }
        }
        string fCURRENCY;
        [Size(10)]
        public string CURRENCY
        {
            get { return fCURRENCY; }
            set { SetPropertyValue<string>("CURRENCY", ref fCURRENCY, value); }
        }
        decimal fUNIT_PRICE;
        public decimal UNIT_PRICE
        {
            get { return fUNIT_PRICE; }
            set { SetPropertyValue<decimal>("UNIT_PRICE", ref fUNIT_PRICE, value); }
        }
        decimal fEXCHANGE_RATE1;
        public decimal EXCHANGE_RATE1
        {
            get { return fEXCHANGE_RATE1; }
            set { SetPropertyValue<decimal>("EXCHANGE_RATE1", ref fEXCHANGE_RATE1, value); }
        }
        decimal fEXCHANGE_RATE2;
        public decimal EXCHANGE_RATE2
        {
            get { return fEXCHANGE_RATE2; }
            set { SetPropertyValue<decimal>("EXCHANGE_RATE2", ref fEXCHANGE_RATE2, value); }
        }
        long fDEBIT_QUANTITY;
        public long DEBIT_QUANTITY
        {
            get { return fDEBIT_QUANTITY; }
            set { SetPropertyValue<long>("DEBIT_QUANTITY", ref fDEBIT_QUANTITY, value); }
        }
        decimal fPRIMARY_DEBIT_AMOUNT;
        public decimal PRIMARY_DEBIT_AMOUNT
        {
            get { return fPRIMARY_DEBIT_AMOUNT; }
            set { SetPropertyValue<decimal>("PRIMARY_DEBIT_AMOUNT", ref fPRIMARY_DEBIT_AMOUNT, value); }
        }
        decimal fSECONDARY_DEBIT_AMOUNT;
        public decimal SECONDARY_DEBIT_AMOUNT
        {
            get { return fSECONDARY_DEBIT_AMOUNT; }
            set { SetPropertyValue<decimal>("SECONDARY_DEBIT_AMOUNT", ref fSECONDARY_DEBIT_AMOUNT, value); }
        }
        decimal fNATURAL_DEBIT_CURRENCY;
        public decimal NATURAL_DEBIT_CURRENCY
        {
            get { return fNATURAL_DEBIT_CURRENCY; }
            set { SetPropertyValue<decimal>("NATURAL_DEBIT_CURRENCY", ref fNATURAL_DEBIT_CURRENCY, value); }
        }
        long fCREDIT_QUANTITY;
        public long CREDIT_QUANTITY
        {
            get { return fCREDIT_QUANTITY; }
            set { SetPropertyValue<long>("CREDIT_QUANTITY", ref fCREDIT_QUANTITY, value); }
        }
        decimal fPRIMARY_CREDIT_AMOUNT;
        public decimal PRIMARY_CREDIT_AMOUNT
        {
            get { return fPRIMARY_CREDIT_AMOUNT; }
            set { SetPropertyValue<decimal>("PRIMARY_CREDIT_AMOUNT", ref fPRIMARY_CREDIT_AMOUNT, value); }
        }
        decimal fSECONDARY_CREDIT_AMOUNT;
        public decimal SECONDARY_CREDIT_AMOUNT
        {
            get { return fSECONDARY_CREDIT_AMOUNT; }
            set { SetPropertyValue<decimal>("SECONDARY_CREDIT_AMOUNT", ref fSECONDARY_CREDIT_AMOUNT, value); }
        }
        decimal fNATURAL_CREDIT_CURRENCY;
        public decimal NATURAL_CREDIT_CURRENCY
        {
            get { return fNATURAL_CREDIT_CURRENCY; }
            set { SetPropertyValue<decimal>("NATURAL_CREDIT_CURRENCY", ref fNATURAL_CREDIT_CURRENCY, value); }
        }
        string fBILL_TYPE;
        [Size(16)]
        public string BILL_TYPE
        {
            get { return fBILL_TYPE; }
            set { SetPropertyValue<string>("BILL_TYPE", ref fBILL_TYPE, value); }
        }
        string fBILL_ID;
        [Size(16)]
        public string BILL_ID
        {
            get { return fBILL_ID; }
            set { SetPropertyValue<string>("BILL_ID", ref fBILL_ID, value); }
        }
        DateTime fBILL_DATE;
        public DateTime BILL_DATE
        {
            get { return fBILL_DATE; }
            set { SetPropertyValue<DateTime>("BILL_DATE", ref fBILL_DATE, value); }
        }
        string fAUXILIARY_ACCOUNTING_ITEM1;
        [Size(60)]
        public string AUXILIARY_ACCOUNTING_ITEM1
        {
            get { return fAUXILIARY_ACCOUNTING_ITEM1; }
            set { SetPropertyValue<string>("AUXILIARY_ACCOUNTING_ITEM1", ref fAUXILIARY_ACCOUNTING_ITEM1, value); }
        }
        string fAUXILIARY_ACCOUNTING_ITEM2;
        [Size(60)]
        public string AUXILIARY_ACCOUNTING_ITEM2
        {
            get { return fAUXILIARY_ACCOUNTING_ITEM2; }
            set { SetPropertyValue<string>("AUXILIARY_ACCOUNTING_ITEM2", ref fAUXILIARY_ACCOUNTING_ITEM2, value); }
        }
        string fAUXILIARY_ACCOUNTING_ITEM3;
        [Size(60)]
        public string AUXILIARY_ACCOUNTING_ITEM3
        {
            get { return fAUXILIARY_ACCOUNTING_ITEM3; }
            set { SetPropertyValue<string>("AUXILIARY_ACCOUNTING_ITEM3", ref fAUXILIARY_ACCOUNTING_ITEM3, value); }
        }
        string fAUXILIARY_ACCOUNTING_ITEM4;
        [Size(60)]
        public string AUXILIARY_ACCOUNTING_ITEM4
        {
            get { return fAUXILIARY_ACCOUNTING_ITEM4; }
            set { SetPropertyValue<string>("AUXILIARY_ACCOUNTING_ITEM4", ref fAUXILIARY_ACCOUNTING_ITEM4, value); }
        }
        string fAUXILIARY_ACCOUNTING_ITEM5;
        [Size(60)]
        public string AUXILIARY_ACCOUNTING_ITEM5
        {
            get { return fAUXILIARY_ACCOUNTING_ITEM5; }
            set { SetPropertyValue<string>("AUXILIARY_ACCOUNTING_ITEM5", ref fAUXILIARY_ACCOUNTING_ITEM5, value); }
        }
        string fAUXILIARY_ACCOUNTING_ITEM6;
        [Size(60)]
        public string AUXILIARY_ACCOUNTING_ITEM6
        {
            get { return fAUXILIARY_ACCOUNTING_ITEM6; }
            set { SetPropertyValue<string>("AUXILIARY_ACCOUNTING_ITEM6", ref fAUXILIARY_ACCOUNTING_ITEM6, value); }
        }
        public VIEW_JT_C_DBPZMX(Session session) : base(session) { }
        public VIEW_JT_C_DBPZMX() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class VIEW_JT_C_BFPZMX : XPLiteObject
    {
        string fENTRY_ID;
        [Size(16)]
        public string ENTRY_ID
        {
            get { return fENTRY_ID; }
            set { SetPropertyValue<string>("ENTRY_ID", ref fENTRY_ID, value); }
        }
        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }
        string fKMMC;
        [Size(80)]
        public string KMMC
        {
            get { return fKMMC; }
            set { SetPropertyValue<string>("KMMC", ref fKMMC, value); }
        }
        string fPZDMXID;
        [Key]
        [Size(16)]
        public string PZDMXID
        {
            get { return fPZDMXID; }
            set { SetPropertyValue<string>("PZDMXID", ref fPZDMXID, value); }
        }
        string fVOUCHERID;
        [Size(16)]
        public string VOUCHERID
        {
            get { return fVOUCHERID; }
            set { SetPropertyValue<string>("VOUCHERID", ref fVOUCHERID, value); }
        }
        string fACCOUNT_CODE;
        [Size(16)]
        public string ACCOUNT_CODE
        {
            get { return fACCOUNT_CODE; }
            set { SetPropertyValue<string>("ACCOUNT_CODE", ref fACCOUNT_CODE, value); }
        }
        string fABSTRACT;
        [Size(200)]
        public string ABSTRACT
        {
            get { return fABSTRACT; }
            set { SetPropertyValue<string>("ABSTRACT", ref fABSTRACT, value); }
        }
        string fSETTLEMENT;
        [Size(22)]
        public string SETTLEMENT
        {
            get { return fSETTLEMENT; }
            set { SetPropertyValue<string>("SETTLEMENT", ref fSETTLEMENT, value); }
        }
        string fDOCUMENT_ID;
        [Size(22)]
        public string DOCUMENT_ID
        {
            get { return fDOCUMENT_ID; }
            set { SetPropertyValue<string>("DOCUMENT_ID", ref fDOCUMENT_ID, value); }
        }
        DateTime fDOCUMENT_DATE;
        public DateTime DOCUMENT_DATE
        {
            get { return fDOCUMENT_DATE; }
            set { SetPropertyValue<DateTime>("DOCUMENT_DATE", ref fDOCUMENT_DATE, value); }
        }
        string fCURRENCY;
        [Size(10)]
        public string CURRENCY
        {
            get { return fCURRENCY; }
            set { SetPropertyValue<string>("CURRENCY", ref fCURRENCY, value); }
        }
        decimal fUNIT_PRICE;
        public decimal UNIT_PRICE
        {
            get { return fUNIT_PRICE; }
            set { SetPropertyValue<decimal>("UNIT_PRICE", ref fUNIT_PRICE, value); }
        }
        decimal fEXCHANGE_RATE1;
        public decimal EXCHANGE_RATE1
        {
            get { return fEXCHANGE_RATE1; }
            set { SetPropertyValue<decimal>("EXCHANGE_RATE1", ref fEXCHANGE_RATE1, value); }
        }
        decimal fEXCHANGE_RATE2;
        public decimal EXCHANGE_RATE2
        {
            get { return fEXCHANGE_RATE2; }
            set { SetPropertyValue<decimal>("EXCHANGE_RATE2", ref fEXCHANGE_RATE2, value); }
        }
        long fDEBIT_QUANTITY;
        public long DEBIT_QUANTITY
        {
            get { return fDEBIT_QUANTITY; }
            set { SetPropertyValue<long>("DEBIT_QUANTITY", ref fDEBIT_QUANTITY, value); }
        }
        decimal fPRIMARY_DEBIT_AMOUNT;
        public decimal PRIMARY_DEBIT_AMOUNT
        {
            get { return fPRIMARY_DEBIT_AMOUNT; }
            set { SetPropertyValue<decimal>("PRIMARY_DEBIT_AMOUNT", ref fPRIMARY_DEBIT_AMOUNT, value); }
        }
        decimal fSECONDARY_DEBIT_AMOUNT;
        public decimal SECONDARY_DEBIT_AMOUNT
        {
            get { return fSECONDARY_DEBIT_AMOUNT; }
            set { SetPropertyValue<decimal>("SECONDARY_DEBIT_AMOUNT", ref fSECONDARY_DEBIT_AMOUNT, value); }
        }
        decimal fNATURAL_DEBIT_CURRENCY;
        public decimal NATURAL_DEBIT_CURRENCY
        {
            get { return fNATURAL_DEBIT_CURRENCY; }
            set { SetPropertyValue<decimal>("NATURAL_DEBIT_CURRENCY", ref fNATURAL_DEBIT_CURRENCY, value); }
        }
        long fCREDIT_QUANTITY;
        public long CREDIT_QUANTITY
        {
            get { return fCREDIT_QUANTITY; }
            set { SetPropertyValue<long>("CREDIT_QUANTITY", ref fCREDIT_QUANTITY, value); }
        }
        decimal fPRIMARY_CREDIT_AMOUNT;
        public decimal PRIMARY_CREDIT_AMOUNT
        {
            get { return fPRIMARY_CREDIT_AMOUNT; }
            set { SetPropertyValue<decimal>("PRIMARY_CREDIT_AMOUNT", ref fPRIMARY_CREDIT_AMOUNT, value); }
        }
        decimal fSECONDARY_CREDIT_AMOUNT;
        public decimal SECONDARY_CREDIT_AMOUNT
        {
            get { return fSECONDARY_CREDIT_AMOUNT; }
            set { SetPropertyValue<decimal>("SECONDARY_CREDIT_AMOUNT", ref fSECONDARY_CREDIT_AMOUNT, value); }
        }
        decimal fNATURAL_CREDIT_CURRENCY;
        public decimal NATURAL_CREDIT_CURRENCY
        {
            get { return fNATURAL_CREDIT_CURRENCY; }
            set { SetPropertyValue<decimal>("NATURAL_CREDIT_CURRENCY", ref fNATURAL_CREDIT_CURRENCY, value); }
        }
        string fBILL_TYPE;
        [Size(16)]
        public string BILL_TYPE
        {
            get { return fBILL_TYPE; }
            set { SetPropertyValue<string>("BILL_TYPE", ref fBILL_TYPE, value); }
        }
        string fBILL_ID;
        [Size(16)]
        public string BILL_ID
        {
            get { return fBILL_ID; }
            set { SetPropertyValue<string>("BILL_ID", ref fBILL_ID, value); }
        }
        DateTime fBILL_DATE;
        public DateTime BILL_DATE
        {
            get { return fBILL_DATE; }
            set { SetPropertyValue<DateTime>("BILL_DATE", ref fBILL_DATE, value); }
        }
        string fAUXILIARY_ACCOUNTING_ITEM1;
        [Size(60)]
        public string AUXILIARY_ACCOUNTING_ITEM1
        {
            get { return fAUXILIARY_ACCOUNTING_ITEM1; }
            set { SetPropertyValue<string>("AUXILIARY_ACCOUNTING_ITEM1", ref fAUXILIARY_ACCOUNTING_ITEM1, value); }
        }
        string fAUXILIARY_ACCOUNTING_ITEM2;
        [Size(60)]
        public string AUXILIARY_ACCOUNTING_ITEM2
        {
            get { return fAUXILIARY_ACCOUNTING_ITEM2; }
            set { SetPropertyValue<string>("AUXILIARY_ACCOUNTING_ITEM2", ref fAUXILIARY_ACCOUNTING_ITEM2, value); }
        }
        string fAUXILIARY_ACCOUNTING_ITEM3;
        [Size(60)]
        public string AUXILIARY_ACCOUNTING_ITEM3
        {
            get { return fAUXILIARY_ACCOUNTING_ITEM3; }
            set { SetPropertyValue<string>("AUXILIARY_ACCOUNTING_ITEM3", ref fAUXILIARY_ACCOUNTING_ITEM3, value); }
        }
        string fAUXILIARY_ACCOUNTING_ITEM4;
        [Size(60)]
        public string AUXILIARY_ACCOUNTING_ITEM4
        {
            get { return fAUXILIARY_ACCOUNTING_ITEM4; }
            set { SetPropertyValue<string>("AUXILIARY_ACCOUNTING_ITEM4", ref fAUXILIARY_ACCOUNTING_ITEM4, value); }
        }
        string fAUXILIARY_ACCOUNTING_ITEM5;
        [Size(60)]
        public string AUXILIARY_ACCOUNTING_ITEM5
        {
            get { return fAUXILIARY_ACCOUNTING_ITEM5; }
            set { SetPropertyValue<string>("AUXILIARY_ACCOUNTING_ITEM5", ref fAUXILIARY_ACCOUNTING_ITEM5, value); }
        }
        string fAUXILIARY_ACCOUNTING_ITEM6;
        [Size(60)]
        public string AUXILIARY_ACCOUNTING_ITEM6
        {
            get { return fAUXILIARY_ACCOUNTING_ITEM6; }
            set { SetPropertyValue<string>("AUXILIARY_ACCOUNTING_ITEM6", ref fAUXILIARY_ACCOUNTING_ITEM6, value); }
        }
        public VIEW_JT_C_BFPZMX(Session session) : base(session) { }
        public VIEW_JT_C_BFPZMX() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class VIEW_JT_C_PDYKPZMX : XPLiteObject
    {
        string fENTRY_ID;
        [Size(16)]
        public string ENTRY_ID
        {
            get { return fENTRY_ID; }
            set { SetPropertyValue<string>("ENTRY_ID", ref fENTRY_ID, value); }
        }
        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }
        string fKMMC;
        [Size(80)]
        public string KMMC
        {
            get { return fKMMC; }
            set { SetPropertyValue<string>("KMMC", ref fKMMC, value); }
        }
        string fPZDMXID;
        [Key]
        [Size(16)]
        public string PZDMXID
        {
            get { return fPZDMXID; }
            set { SetPropertyValue<string>("PZDMXID", ref fPZDMXID, value); }
        }
        string fVOUCHERID;
        [Size(16)]
        public string VOUCHERID
        {
            get { return fVOUCHERID; }
            set { SetPropertyValue<string>("VOUCHERID", ref fVOUCHERID, value); }
        }
        string fACCOUNT_CODE;
        [Size(16)]
        public string ACCOUNT_CODE
        {
            get { return fACCOUNT_CODE; }
            set { SetPropertyValue<string>("ACCOUNT_CODE", ref fACCOUNT_CODE, value); }
        }
        string fABSTRACT;
        [Size(200)]
        public string ABSTRACT
        {
            get { return fABSTRACT; }
            set { SetPropertyValue<string>("ABSTRACT", ref fABSTRACT, value); }
        }
        string fSETTLEMENT;
        [Size(22)]
        public string SETTLEMENT
        {
            get { return fSETTLEMENT; }
            set { SetPropertyValue<string>("SETTLEMENT", ref fSETTLEMENT, value); }
        }
        string fDOCUMENT_ID;
        [Size(22)]
        public string DOCUMENT_ID
        {
            get { return fDOCUMENT_ID; }
            set { SetPropertyValue<string>("DOCUMENT_ID", ref fDOCUMENT_ID, value); }
        }
        DateTime fDOCUMENT_DATE;
        public DateTime DOCUMENT_DATE
        {
            get { return fDOCUMENT_DATE; }
            set { SetPropertyValue<DateTime>("DOCUMENT_DATE", ref fDOCUMENT_DATE, value); }
        }
        string fCURRENCY;
        [Size(10)]
        public string CURRENCY
        {
            get { return fCURRENCY; }
            set { SetPropertyValue<string>("CURRENCY", ref fCURRENCY, value); }
        }
        decimal fUNIT_PRICE;
        public decimal UNIT_PRICE
        {
            get { return fUNIT_PRICE; }
            set { SetPropertyValue<decimal>("UNIT_PRICE", ref fUNIT_PRICE, value); }
        }
        decimal fEXCHANGE_RATE1;
        public decimal EXCHANGE_RATE1
        {
            get { return fEXCHANGE_RATE1; }
            set { SetPropertyValue<decimal>("EXCHANGE_RATE1", ref fEXCHANGE_RATE1, value); }
        }
        decimal fEXCHANGE_RATE2;
        public decimal EXCHANGE_RATE2
        {
            get { return fEXCHANGE_RATE2; }
            set { SetPropertyValue<decimal>("EXCHANGE_RATE2", ref fEXCHANGE_RATE2, value); }
        }
        long fDEBIT_QUANTITY;
        public long DEBIT_QUANTITY
        {
            get { return fDEBIT_QUANTITY; }
            set { SetPropertyValue<long>("DEBIT_QUANTITY", ref fDEBIT_QUANTITY, value); }
        }
        decimal fPRIMARY_DEBIT_AMOUNT;
        public decimal PRIMARY_DEBIT_AMOUNT
        {
            get { return fPRIMARY_DEBIT_AMOUNT; }
            set { SetPropertyValue<decimal>("PRIMARY_DEBIT_AMOUNT", ref fPRIMARY_DEBIT_AMOUNT, value); }
        }
        decimal fSECONDARY_DEBIT_AMOUNT;
        public decimal SECONDARY_DEBIT_AMOUNT
        {
            get { return fSECONDARY_DEBIT_AMOUNT; }
            set { SetPropertyValue<decimal>("SECONDARY_DEBIT_AMOUNT", ref fSECONDARY_DEBIT_AMOUNT, value); }
        }
        decimal fNATURAL_DEBIT_CURRENCY;
        public decimal NATURAL_DEBIT_CURRENCY
        {
            get { return fNATURAL_DEBIT_CURRENCY; }
            set { SetPropertyValue<decimal>("NATURAL_DEBIT_CURRENCY", ref fNATURAL_DEBIT_CURRENCY, value); }
        }
        long fCREDIT_QUANTITY;
        public long CREDIT_QUANTITY
        {
            get { return fCREDIT_QUANTITY; }
            set { SetPropertyValue<long>("CREDIT_QUANTITY", ref fCREDIT_QUANTITY, value); }
        }
        decimal fPRIMARY_CREDIT_AMOUNT;
        public decimal PRIMARY_CREDIT_AMOUNT
        {
            get { return fPRIMARY_CREDIT_AMOUNT; }
            set { SetPropertyValue<decimal>("PRIMARY_CREDIT_AMOUNT", ref fPRIMARY_CREDIT_AMOUNT, value); }
        }
        decimal fSECONDARY_CREDIT_AMOUNT;
        public decimal SECONDARY_CREDIT_AMOUNT
        {
            get { return fSECONDARY_CREDIT_AMOUNT; }
            set { SetPropertyValue<decimal>("SECONDARY_CREDIT_AMOUNT", ref fSECONDARY_CREDIT_AMOUNT, value); }
        }
        decimal fNATURAL_CREDIT_CURRENCY;
        public decimal NATURAL_CREDIT_CURRENCY
        {
            get { return fNATURAL_CREDIT_CURRENCY; }
            set { SetPropertyValue<decimal>("NATURAL_CREDIT_CURRENCY", ref fNATURAL_CREDIT_CURRENCY, value); }
        }
        string fBILL_TYPE;
        [Size(16)]
        public string BILL_TYPE
        {
            get { return fBILL_TYPE; }
            set { SetPropertyValue<string>("BILL_TYPE", ref fBILL_TYPE, value); }
        }
        string fBILL_ID;
        [Size(16)]
        public string BILL_ID
        {
            get { return fBILL_ID; }
            set { SetPropertyValue<string>("BILL_ID", ref fBILL_ID, value); }
        }
        DateTime fBILL_DATE;
        public DateTime BILL_DATE
        {
            get { return fBILL_DATE; }
            set { SetPropertyValue<DateTime>("BILL_DATE", ref fBILL_DATE, value); }
        }
        string fAUXILIARY_ACCOUNTING_ITEM1;
        [Size(60)]
        public string AUXILIARY_ACCOUNTING_ITEM1
        {
            get { return fAUXILIARY_ACCOUNTING_ITEM1; }
            set { SetPropertyValue<string>("AUXILIARY_ACCOUNTING_ITEM1", ref fAUXILIARY_ACCOUNTING_ITEM1, value); }
        }
        string fAUXILIARY_ACCOUNTING_ITEM2;
        [Size(60)]
        public string AUXILIARY_ACCOUNTING_ITEM2
        {
            get { return fAUXILIARY_ACCOUNTING_ITEM2; }
            set { SetPropertyValue<string>("AUXILIARY_ACCOUNTING_ITEM2", ref fAUXILIARY_ACCOUNTING_ITEM2, value); }
        }
        string fAUXILIARY_ACCOUNTING_ITEM3;
        [Size(60)]
        public string AUXILIARY_ACCOUNTING_ITEM3
        {
            get { return fAUXILIARY_ACCOUNTING_ITEM3; }
            set { SetPropertyValue<string>("AUXILIARY_ACCOUNTING_ITEM3", ref fAUXILIARY_ACCOUNTING_ITEM3, value); }
        }
        string fAUXILIARY_ACCOUNTING_ITEM4;
        [Size(60)]
        public string AUXILIARY_ACCOUNTING_ITEM4
        {
            get { return fAUXILIARY_ACCOUNTING_ITEM4; }
            set { SetPropertyValue<string>("AUXILIARY_ACCOUNTING_ITEM4", ref fAUXILIARY_ACCOUNTING_ITEM4, value); }
        }
        string fAUXILIARY_ACCOUNTING_ITEM5;
        [Size(60)]
        public string AUXILIARY_ACCOUNTING_ITEM5
        {
            get { return fAUXILIARY_ACCOUNTING_ITEM5; }
            set { SetPropertyValue<string>("AUXILIARY_ACCOUNTING_ITEM5", ref fAUXILIARY_ACCOUNTING_ITEM5, value); }
        }
        string fAUXILIARY_ACCOUNTING_ITEM6;
        [Size(60)]
        public string AUXILIARY_ACCOUNTING_ITEM6
        {
            get { return fAUXILIARY_ACCOUNTING_ITEM6; }
            set { SetPropertyValue<string>("AUXILIARY_ACCOUNTING_ITEM6", ref fAUXILIARY_ACCOUNTING_ITEM6, value); }
        }
        public VIEW_JT_C_PDYKPZMX(Session session) : base(session) { }
        public VIEW_JT_C_PDYKPZMX() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class VIEW_JT_C_JZCBPZMX : XPLiteObject
    {
        string fENTRY_ID;
        [Size(16)]
        public string ENTRY_ID
        {
            get { return fENTRY_ID; }
            set { SetPropertyValue<string>("ENTRY_ID", ref fENTRY_ID, value); }
        }
        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }
        string fKMMC;
        [Size(80)]
        public string KMMC
        {
            get { return fKMMC; }
            set { SetPropertyValue<string>("KMMC", ref fKMMC, value); }
        }
        string fPZDMXID;
        [Key]
        [Size(16)]
        public string PZDMXID
        {
            get { return fPZDMXID; }
            set { SetPropertyValue<string>("PZDMXID", ref fPZDMXID, value); }
        }
        string fVOUCHERID;
        [Size(16)]
        public string VOUCHERID
        {
            get { return fVOUCHERID; }
            set { SetPropertyValue<string>("VOUCHERID", ref fVOUCHERID, value); }
        }
        string fACCOUNT_CODE;
        [Size(16)]
        public string ACCOUNT_CODE
        {
            get { return fACCOUNT_CODE; }
            set { SetPropertyValue<string>("ACCOUNT_CODE", ref fACCOUNT_CODE, value); }
        }
        string fABSTRACT;
        [Size(200)]
        public string ABSTRACT
        {
            get { return fABSTRACT; }
            set { SetPropertyValue<string>("ABSTRACT", ref fABSTRACT, value); }
        }
        string fSETTLEMENT;
        [Size(22)]
        public string SETTLEMENT
        {
            get { return fSETTLEMENT; }
            set { SetPropertyValue<string>("SETTLEMENT", ref fSETTLEMENT, value); }
        }
        string fDOCUMENT_ID;
        [Size(22)]
        public string DOCUMENT_ID
        {
            get { return fDOCUMENT_ID; }
            set { SetPropertyValue<string>("DOCUMENT_ID", ref fDOCUMENT_ID, value); }
        }
        DateTime fDOCUMENT_DATE;
        public DateTime DOCUMENT_DATE
        {
            get { return fDOCUMENT_DATE; }
            set { SetPropertyValue<DateTime>("DOCUMENT_DATE", ref fDOCUMENT_DATE, value); }
        }
        string fCURRENCY;
        [Size(10)]
        public string CURRENCY
        {
            get { return fCURRENCY; }
            set { SetPropertyValue<string>("CURRENCY", ref fCURRENCY, value); }
        }
        decimal fUNIT_PRICE;
        public decimal UNIT_PRICE
        {
            get { return fUNIT_PRICE; }
            set { SetPropertyValue<decimal>("UNIT_PRICE", ref fUNIT_PRICE, value); }
        }
        decimal fEXCHANGE_RATE1;
        public decimal EXCHANGE_RATE1
        {
            get { return fEXCHANGE_RATE1; }
            set { SetPropertyValue<decimal>("EXCHANGE_RATE1", ref fEXCHANGE_RATE1, value); }
        }
        decimal fEXCHANGE_RATE2;
        public decimal EXCHANGE_RATE2
        {
            get { return fEXCHANGE_RATE2; }
            set { SetPropertyValue<decimal>("EXCHANGE_RATE2", ref fEXCHANGE_RATE2, value); }
        }
        long fDEBIT_QUANTITY;
        public long DEBIT_QUANTITY
        {
            get { return fDEBIT_QUANTITY; }
            set { SetPropertyValue<long>("DEBIT_QUANTITY", ref fDEBIT_QUANTITY, value); }
        }
        decimal fPRIMARY_DEBIT_AMOUNT;
        public decimal PRIMARY_DEBIT_AMOUNT
        {
            get { return fPRIMARY_DEBIT_AMOUNT; }
            set { SetPropertyValue<decimal>("PRIMARY_DEBIT_AMOUNT", ref fPRIMARY_DEBIT_AMOUNT, value); }
        }
        decimal fSECONDARY_DEBIT_AMOUNT;
        public decimal SECONDARY_DEBIT_AMOUNT
        {
            get { return fSECONDARY_DEBIT_AMOUNT; }
            set { SetPropertyValue<decimal>("SECONDARY_DEBIT_AMOUNT", ref fSECONDARY_DEBIT_AMOUNT, value); }
        }
        decimal fNATURAL_DEBIT_CURRENCY;
        public decimal NATURAL_DEBIT_CURRENCY
        {
            get { return fNATURAL_DEBIT_CURRENCY; }
            set { SetPropertyValue<decimal>("NATURAL_DEBIT_CURRENCY", ref fNATURAL_DEBIT_CURRENCY, value); }
        }
        long fCREDIT_QUANTITY;
        public long CREDIT_QUANTITY
        {
            get { return fCREDIT_QUANTITY; }
            set { SetPropertyValue<long>("CREDIT_QUANTITY", ref fCREDIT_QUANTITY, value); }
        }
        decimal fPRIMARY_CREDIT_AMOUNT;
        public decimal PRIMARY_CREDIT_AMOUNT
        {
            get { return fPRIMARY_CREDIT_AMOUNT; }
            set { SetPropertyValue<decimal>("PRIMARY_CREDIT_AMOUNT", ref fPRIMARY_CREDIT_AMOUNT, value); }
        }
        decimal fSECONDARY_CREDIT_AMOUNT;
        public decimal SECONDARY_CREDIT_AMOUNT
        {
            get { return fSECONDARY_CREDIT_AMOUNT; }
            set { SetPropertyValue<decimal>("SECONDARY_CREDIT_AMOUNT", ref fSECONDARY_CREDIT_AMOUNT, value); }
        }
        decimal fNATURAL_CREDIT_CURRENCY;
        public decimal NATURAL_CREDIT_CURRENCY
        {
            get { return fNATURAL_CREDIT_CURRENCY; }
            set { SetPropertyValue<decimal>("NATURAL_CREDIT_CURRENCY", ref fNATURAL_CREDIT_CURRENCY, value); }
        }
        string fBILL_TYPE;
        [Size(16)]
        public string BILL_TYPE
        {
            get { return fBILL_TYPE; }
            set { SetPropertyValue<string>("BILL_TYPE", ref fBILL_TYPE, value); }
        }
        string fBILL_ID;
        [Size(16)]
        public string BILL_ID
        {
            get { return fBILL_ID; }
            set { SetPropertyValue<string>("BILL_ID", ref fBILL_ID, value); }
        }
        DateTime fBILL_DATE;
        public DateTime BILL_DATE
        {
            get { return fBILL_DATE; }
            set { SetPropertyValue<DateTime>("BILL_DATE", ref fBILL_DATE, value); }
        }
        string fAUXILIARY_ACCOUNTING_ITEM1;
        [Size(60)]
        public string AUXILIARY_ACCOUNTING_ITEM1
        {
            get { return fAUXILIARY_ACCOUNTING_ITEM1; }
            set { SetPropertyValue<string>("AUXILIARY_ACCOUNTING_ITEM1", ref fAUXILIARY_ACCOUNTING_ITEM1, value); }
        }
        string fAUXILIARY_ACCOUNTING_ITEM2;
        [Size(60)]
        public string AUXILIARY_ACCOUNTING_ITEM2
        {
            get { return fAUXILIARY_ACCOUNTING_ITEM2; }
            set { SetPropertyValue<string>("AUXILIARY_ACCOUNTING_ITEM2", ref fAUXILIARY_ACCOUNTING_ITEM2, value); }
        }
        string fAUXILIARY_ACCOUNTING_ITEM3;
        [Size(60)]
        public string AUXILIARY_ACCOUNTING_ITEM3
        {
            get { return fAUXILIARY_ACCOUNTING_ITEM3; }
            set { SetPropertyValue<string>("AUXILIARY_ACCOUNTING_ITEM3", ref fAUXILIARY_ACCOUNTING_ITEM3, value); }
        }
        string fAUXILIARY_ACCOUNTING_ITEM4;
        [Size(60)]
        public string AUXILIARY_ACCOUNTING_ITEM4
        {
            get { return fAUXILIARY_ACCOUNTING_ITEM4; }
            set { SetPropertyValue<string>("AUXILIARY_ACCOUNTING_ITEM4", ref fAUXILIARY_ACCOUNTING_ITEM4, value); }
        }
        string fAUXILIARY_ACCOUNTING_ITEM5;
        [Size(60)]
        public string AUXILIARY_ACCOUNTING_ITEM5
        {
            get { return fAUXILIARY_ACCOUNTING_ITEM5; }
            set { SetPropertyValue<string>("AUXILIARY_ACCOUNTING_ITEM5", ref fAUXILIARY_ACCOUNTING_ITEM5, value); }
        }
        string fAUXILIARY_ACCOUNTING_ITEM6;
        [Size(60)]
        public string AUXILIARY_ACCOUNTING_ITEM6
        {
            get { return fAUXILIARY_ACCOUNTING_ITEM6; }
            set { SetPropertyValue<string>("AUXILIARY_ACCOUNTING_ITEM6", ref fAUXILIARY_ACCOUNTING_ITEM6, value); }
        }
        public VIEW_JT_C_JZCBPZMX(Session session) : base(session) { }
        public VIEW_JT_C_JZCBPZMX() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class VIEW_JT_X_XSD_CCD : XPLiteObject
    {
        string fCCDID;
        [Key]
        [Size(16)]
        public string CCDID
        {
            get { return fCCDID; }
            set { SetPropertyValue<string>("CCDID", ref fCCDID, value); }
        }
        string fCCDH;
        [Size(22)]
        public string CCDH
        {
            get { return fCCDH; }
            set { SetPropertyValue<string>("CCDH", ref fCCDH, value); }
        }
        string fBMID;
        [Size(16)]
        public string BMID
        {
            get { return fBMID; }
            set { SetPropertyValue<string>("BMID", ref fBMID, value); }
        }
        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }
        DateTime fZDRQ;
        public DateTime ZDRQ
        {
            get { return fZDRQ; }
            set { SetPropertyValue<DateTime>("ZDRQ", ref fZDRQ, value); }
        }
        string fCZYID;
        [Size(16)]
        public string CZYID
        {
            get { return fCZYID; }
            set { SetPropertyValue<string>("CZYID", ref fCZYID, value); }
        }
        DateTime fCZRQ;
        public DateTime CZRQ
        {
            get { return fCZRQ; }
            set { SetPropertyValue<DateTime>("CZRQ", ref fCZRQ, value); }
        }
        long fCCSL;
        public long CCSL
        {
            get { return fCCSL; }
            set { SetPropertyValue<long>("CCSL", ref fCCSL, value); }
        }
        decimal fCCSY;
        public decimal CCSY
        {
            get { return fCCSY; }
            set { SetPropertyValue<decimal>("CCSY", ref fCCSY, value); }
        }
        decimal fCCMY;
        public decimal CCMY
        {
            get { return fCCMY; }
            set { SetPropertyValue<decimal>("CCMY", ref fCCMY, value); }
        }
        long fCCPZ;
        public long CCPZ
        {
            get { return fCCPZ; }
            set { SetPropertyValue<long>("CCPZ", ref fCCPZ, value); }
        }
        string fZT;
        [Size(4)]
        public string ZT
        {
            get { return fZT; }
            set { SetPropertyValue<string>("ZT", ref fZT, value); }
        }
        string fYZT;
        [Size(4)]
        public string YZT
        {
            get { return fYZT; }
            set { SetPropertyValue<string>("YZT", ref fYZT, value); }
        }
        string fKHMC;
        [Size(100)]
        public string KHMC
        {
            get { return fKHMC; }
            set { SetPropertyValue<string>("KHMC", ref fKHMC, value); }
        }
        string fSTATUSMC;
        [Size(16)]
        public string STATUSMC
        {
            get { return fSTATUSMC; }
            set { SetPropertyValue<string>("STATUSMC", ref fSTATUSMC, value); }
        }
        public VIEW_JT_X_XSD_CCD(Session session) : base(session) { }
        public VIEW_JT_X_XSD_CCD() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class VIEW_JT_C_ZTBMKHSPTZ : XPLiteObject
    {
        string fZTBMKHSPTZID;
        [Key]
        [Size(16)]
        public string ZTBMKHSPTZID
        {
            get { return fZTBMKHSPTZID; }
            set { SetPropertyValue<string>("ZTBMKHSPTZID", ref fZTBMKHSPTZID, value); }
        }
        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }
        string fYWBMMC;
        [Size(100)]
        public string YWBMMC
        {
            get { return fYWBMMC; }
            set { SetPropertyValue<string>("YWBMMC", ref fYWBMMC, value); }
        }
        string fKHMC;
        [Size(100)]
        public string KHMC
        {
            get { return fKHMC; }
            set { SetPropertyValue<string>("KHMC", ref fKHMC, value); }
        }
        string fPM;
        [Size(100)]
        public string PM
        {
            get { return fPM; }
            set { SetPropertyValue<string>("PM", ref fPM, value); }
        }
        string fYWBMID;
        [Size(16)]
        public string YWBMID
        {
            get { return fYWBMID; }
            set { SetPropertyValue<string>("YWBMID", ref fYWBMID, value); }
        }
        string fKHID;
        [Size(16)]
        public string KHID
        {
            get { return fKHID; }
            set { SetPropertyValue<string>("KHID", ref fKHID, value); }
        }
        string fSPXXID;
        [Size(16)]
        public string SPXXID
        {
            get { return fSPXXID; }
            set { SetPropertyValue<string>("SPXXID", ref fSPXXID, value); }
        }
        string fZDDM;
        [Size(15)]
        public string ZDDM
        {
            get { return fZDDM; }
            set { SetPropertyValue<string>("ZDDM", ref fZDDM, value); }
        }
        long fQCKC;
        public long QCKC
        {
            get { return fQCKC; }
            set { SetPropertyValue<long>("QCKC", ref fQCKC, value); }
        }
        decimal fQCMY;
        public decimal QCMY
        {
            get { return fQCMY; }
            set { SetPropertyValue<decimal>("QCMY", ref fQCMY, value); }
        }
        decimal fQCSY;
        public decimal QCSY
        {
            get { return fQCSY; }
            set { SetPropertyValue<decimal>("QCSY", ref fQCSY, value); }
        }
        long fJHSL;
        public long JHSL
        {
            get { return fJHSL; }
            set { SetPropertyValue<long>("JHSL", ref fJHSL, value); }
        }
        decimal fJHMY;
        public decimal JHMY
        {
            get { return fJHMY; }
            set { SetPropertyValue<decimal>("JHMY", ref fJHMY, value); }
        }
        decimal fJHSY;
        public decimal JHSY
        {
            get { return fJHSY; }
            set { SetPropertyValue<decimal>("JHSY", ref fJHSY, value); }
        }
        long fXSSL;
        public long XSSL
        {
            get { return fXSSL; }
            set { SetPropertyValue<long>("XSSL", ref fXSSL, value); }
        }
        decimal fXSMY;
        public decimal XSMY
        {
            get { return fXSMY; }
            set { SetPropertyValue<decimal>("XSMY", ref fXSMY, value); }
        }
        decimal fXSSY;
        public decimal XSSY
        {
            get { return fXSSY; }
            set { SetPropertyValue<decimal>("XSSY", ref fXSSY, value); }
        }
        long fJTSL;
        public long JTSL
        {
            get { return fJTSL; }
            set { SetPropertyValue<long>("JTSL", ref fJTSL, value); }
        }
        decimal fJTMY;
        public decimal JTMY
        {
            get { return fJTMY; }
            set { SetPropertyValue<decimal>("JTMY", ref fJTMY, value); }
        }
        decimal fJTSY;
        public decimal JTSY
        {
            get { return fJTSY; }
            set { SetPropertyValue<decimal>("JTSY", ref fJTSY, value); }
        }
        long fQMKC;
        public long QMKC
        {
            get { return fQMKC; }
            set { SetPropertyValue<long>("QMKC", ref fQMKC, value); }
        }
        decimal fQMMY;
        public decimal QMMY
        {
            get { return fQMMY; }
            set { SetPropertyValue<decimal>("QMMY", ref fQMMY, value); }
        }
        decimal fQMSY;
        public decimal QMSY
        {
            get { return fQMSY; }
            set { SetPropertyValue<decimal>("QMSY", ref fQMSY, value); }
        }
        long fJHCS;
        public long JHCS
        {
            get { return fJHCS; }
            set { SetPropertyValue<long>("JHCS", ref fJHCS, value); }
        }
        long fTHCS;
        public long THCS
        {
            get { return fTHCS; }
            set { SetPropertyValue<long>("THCS", ref fTHCS, value); }
        }
        string fZT;
        [Size(4)]
        public string ZT
        {
            get { return fZT; }
            set { SetPropertyValue<string>("ZT", ref fZT, value); }
        }
        string fYZT;
        [Size(4)]
        public string YZT
        {
            get { return fYZT; }
            set { SetPropertyValue<string>("YZT", ref fYZT, value); }
        }
        string fBZ;
        public string BZ
        {
            get { return fBZ; }
            set { SetPropertyValue<string>("BZ", ref fBZ, value); }
        }
        long fYJSL;
        public long YJSL
        {
            get { return fYJSL; }
            set { SetPropertyValue<long>("YJSL", ref fYJSL, value); }
        }
        decimal fYJSY;
        public decimal YJSY
        {
            get { return fYJSY; }
            set { SetPropertyValue<decimal>("YJSY", ref fYJSY, value); }
        }
        decimal fYJMY;
        public decimal YJMY
        {
            get { return fYJMY; }
            set { SetPropertyValue<decimal>("YJMY", ref fYJMY, value); }
        }
        long fYTCS;
        public long YTCS
        {
            get { return fYTCS; }
            set { SetPropertyValue<long>("YTCS", ref fYTCS, value); }
        }
        decimal fYTMY;
        public decimal YTMY
        {
            get { return fYTMY; }
            set { SetPropertyValue<decimal>("YTMY", ref fYTMY, value); }
        }
        decimal fYTSY;
        public decimal YTSY
        {
            get { return fYTSY; }
            set { SetPropertyValue<decimal>("YTSY", ref fYTSY, value); }
        }
        long fZZSL;
        public long ZZSL
        {
            get { return fZZSL; }
            set { SetPropertyValue<long>("ZZSL", ref fZZSL, value); }
        }
        decimal fZZSY;
        public decimal ZZSY
        {
            get { return fZZSY; }
            set { SetPropertyValue<decimal>("ZZSY", ref fZZSY, value); }
        }
        decimal fZZMY;
        public decimal ZZMY
        {
            get { return fZZMY; }
            set { SetPropertyValue<decimal>("ZZMY", ref fZZMY, value); }
        }
        long fKTZSL;
        public long KTZSL
        {
            get { return fKTZSL; }
            set { SetPropertyValue<long>("KTZSL", ref fKTZSL, value); }
        }
        long fSYSL;
        public long SYSL
        {
            get { return fSYSL; }
            set { SetPropertyValue<long>("SYSL", ref fSYSL, value); }
        }
        decimal fSYSY;
        public decimal SYSY
        {
            get { return fSYSY; }
            set { SetPropertyValue<decimal>("SYSY", ref fSYSY, value); }
        }
        decimal fSYMY;
        public decimal SYMY
        {
            get { return fSYMY; }
            set { SetPropertyValue<decimal>("SYMY", ref fSYMY, value); }
        }
        public VIEW_JT_C_ZTBMKHSPTZ(Session session) : base(session) { }
        public VIEW_JT_C_ZTBMKHSPTZ() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class VIEW_JT_C_ZTBMKHSPMX : XPLiteObject
    {
        string fPM;
        [Size(100)]
        public string PM
        {
            get { return fPM; }
            set { SetPropertyValue<string>("PM", ref fPM, value); }
        }
        decimal fJTMY;
        public decimal JTMY
        {
            get { return fJTMY; }
            set { SetPropertyValue<decimal>("JTMY", ref fJTMY, value); }
        }
        decimal fJTSY;
        public decimal JTSY
        {
            get { return fJTSY; }
            set { SetPropertyValue<decimal>("JTSY", ref fJTSY, value); }
        }
        long fQMKC;
        public long QMKC
        {
            get { return fQMKC; }
            set { SetPropertyValue<long>("QMKC", ref fQMKC, value); }
        }
        decimal fQMMY;
        public decimal QMMY
        {
            get { return fQMMY; }
            set { SetPropertyValue<decimal>("QMMY", ref fQMMY, value); }
        }
        decimal fQMSY;
        public decimal QMSY
        {
            get { return fQMSY; }
            set { SetPropertyValue<decimal>("QMSY", ref fQMSY, value); }
        }
        DateTime fJZRQ;
        public DateTime JZRQ
        {
            get { return fJZRQ; }
            set { SetPropertyValue<DateTime>("JZRQ", ref fJZRQ, value); }
        }
        string fXSFSID;
        [Size(16)]
        public string XSFSID
        {
            get { return fXSFSID; }
            set { SetPropertyValue<string>("XSFSID", ref fXSFSID, value); }
        }
        long fTHCS;
        public long THCS
        {
            get { return fTHCS; }
            set { SetPropertyValue<long>("THCS", ref fTHCS, value); }
        }
        string fZT;
        [Size(4)]
        public string ZT
        {
            get { return fZT; }
            set { SetPropertyValue<string>("ZT", ref fZT, value); }
        }
        string fYZT;
        [Size(4)]
        public string YZT
        {
            get { return fYZT; }
            set { SetPropertyValue<string>("YZT", ref fYZT, value); }
        }
        string fBZ;
        public string BZ
        {
            get { return fBZ; }
            set { SetPropertyValue<string>("BZ", ref fBZ, value); }
        }
        long fYJSL;
        public long YJSL
        {
            get { return fYJSL; }
            set { SetPropertyValue<long>("YJSL", ref fYJSL, value); }
        }
        decimal fYJSY;
        public decimal YJSY
        {
            get { return fYJSY; }
            set { SetPropertyValue<decimal>("YJSY", ref fYJSY, value); }
        }
        decimal fYJMY;
        public decimal YJMY
        {
            get { return fYJMY; }
            set { SetPropertyValue<decimal>("YJMY", ref fYJMY, value); }
        }
        long fYTCS;
        public long YTCS
        {
            get { return fYTCS; }
            set { SetPropertyValue<long>("YTCS", ref fYTCS, value); }
        }
        decimal fYTMY;
        public decimal YTMY
        {
            get { return fYTMY; }
            set { SetPropertyValue<decimal>("YTMY", ref fYTMY, value); }
        }
        decimal fYTSY;
        public decimal YTSY
        {
            get { return fYTSY; }
            set { SetPropertyValue<decimal>("YTSY", ref fYTSY, value); }
        }
        string fXSDMXID;
        [Size(16)]
        public string XSDMXID
        {
            get { return fXSDMXID; }
            set { SetPropertyValue<string>("XSDMXID", ref fXSDMXID, value); }
        }
        long fZZSL;
        public long ZZSL
        {
            get { return fZZSL; }
            set { SetPropertyValue<long>("ZZSL", ref fZZSL, value); }
        }
        decimal fZZSY;
        public decimal ZZSY
        {
            get { return fZZSY; }
            set { SetPropertyValue<decimal>("ZZSY", ref fZZSY, value); }
        }
        decimal fZZMY;
        public decimal ZZMY
        {
            get { return fZZMY; }
            set { SetPropertyValue<decimal>("ZZMY", ref fZZMY, value); }
        }
        long fKTSL;
        public long KTSL
        {
            get { return fKTSL; }
            set { SetPropertyValue<long>("KTSL", ref fKTSL, value); }
        }
        DateTime fTHQX;
        public DateTime THQX
        {
            get { return fTHQX; }
            set { SetPropertyValue<DateTime>("THQX", ref fTHQX, value); }
        }
        string fSFTZ;
        [Size(5)]
        public string SFTZ
        {
            get { return fSFTZ; }
            set { SetPropertyValue<string>("SFTZ", ref fSFTZ, value); }
        }
        long fSYSL;
        public long SYSL
        {
            get { return fSYSL; }
            set { SetPropertyValue<long>("SYSL", ref fSYSL, value); }
        }
        decimal fSYSY;
        public decimal SYSY
        {
            get { return fSYSY; }
            set { SetPropertyValue<decimal>("SYSY", ref fSYSY, value); }
        }
        decimal fSYMY;
        public decimal SYMY
        {
            get { return fSYMY; }
            set { SetPropertyValue<decimal>("SYMY", ref fSYMY, value); }
        }
        string fZTBMKHSPMXID;
        [Key]
        [Size(16)]
        public string ZTBMKHSPMXID
        {
            get { return fZTBMKHSPMXID; }
            set { SetPropertyValue<string>("ZTBMKHSPMXID", ref fZTBMKHSPMXID, value); }
        }
        string fZTBMKHSPTZID;
        [Size(16)]
        public string ZTBMKHSPTZID
        {
            get { return fZTBMKHSPTZID; }
            set { SetPropertyValue<string>("ZTBMKHSPTZID", ref fZTBMKHSPTZID, value); }
        }
        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }
        string fYWBMID;
        [Size(16)]
        public string YWBMID
        {
            get { return fYWBMID; }
            set { SetPropertyValue<string>("YWBMID", ref fYWBMID, value); }
        }
        string fKHID;
        [Size(16)]
        public string KHID
        {
            get { return fKHID; }
            set { SetPropertyValue<string>("KHID", ref fKHID, value); }
        }
        string fBMSPKFMXID;
        [Size(16)]
        public string BMSPKFMXID
        {
            get { return fBMSPKFMXID; }
            set { SetPropertyValue<string>("BMSPKFMXID", ref fBMSPKFMXID, value); }
        }
        string fSPXXID;
        [Size(16)]
        public string SPXXID
        {
            get { return fSPXXID; }
            set { SetPropertyValue<string>("SPXXID", ref fSPXXID, value); }
        }
        decimal fDJ;
        public decimal DJ
        {
            get { return fDJ; }
            set { SetPropertyValue<decimal>("DJ", ref fDJ, value); }
        }
        decimal fJZ;
        public decimal JZ
        {
            get { return fJZ; }
            set { SetPropertyValue<decimal>("JZ", ref fJZ, value); }
        }
        decimal fJJ;
        public decimal JJ
        {
            get { return fJJ; }
            set { SetPropertyValue<decimal>("JJ", ref fJJ, value); }
        }
        long fQCKC;
        public long QCKC
        {
            get { return fQCKC; }
            set { SetPropertyValue<long>("QCKC", ref fQCKC, value); }
        }
        decimal fQCMY;
        public decimal QCMY
        {
            get { return fQCMY; }
            set { SetPropertyValue<decimal>("QCMY", ref fQCMY, value); }
        }
        decimal fQCSY;
        public decimal QCSY
        {
            get { return fQCSY; }
            set { SetPropertyValue<decimal>("QCSY", ref fQCSY, value); }
        }
        long fJHSL;
        public long JHSL
        {
            get { return fJHSL; }
            set { SetPropertyValue<long>("JHSL", ref fJHSL, value); }
        }
        decimal fJHMY;
        public decimal JHMY
        {
            get { return fJHMY; }
            set { SetPropertyValue<decimal>("JHMY", ref fJHMY, value); }
        }
        decimal fJHSY;
        public decimal JHSY
        {
            get { return fJHSY; }
            set { SetPropertyValue<decimal>("JHSY", ref fJHSY, value); }
        }
        long fXSSL;
        public long XSSL
        {
            get { return fXSSL; }
            set { SetPropertyValue<long>("XSSL", ref fXSSL, value); }
        }
        decimal fXSMY;
        public decimal XSMY
        {
            get { return fXSMY; }
            set { SetPropertyValue<decimal>("XSMY", ref fXSMY, value); }
        }
        decimal fXSSY;
        public decimal XSSY
        {
            get { return fXSSY; }
            set { SetPropertyValue<decimal>("XSSY", ref fXSSY, value); }
        }
        long fJTSL;
        public long JTSL
        {
            get { return fJTSL; }
            set { SetPropertyValue<long>("JTSL", ref fJTSL, value); }
        }
        public VIEW_JT_C_ZTBMKHSPMX(Session session) : base(session) { }
        public VIEW_JT_C_ZTBMKHSPMX() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class VIEW_JT_C_ZTBMGYSSPMX : XPLiteObject
    {
        string fPM;
        [Size(100)]
        public string PM
        {
            get { return fPM; }
            set { SetPropertyValue<string>("PM", ref fPM, value); }
        }
        string fZTBMGYSSPMXID;
        [Key]
        [Size(16)]
        public string ZTBMGYSSPMXID
        {
            get { return fZTBMGYSSPMXID; }
            set { SetPropertyValue<string>("ZTBMGYSSPMXID", ref fZTBMGYSSPMXID, value); }
        }
        string fZTBMGYSSPTZID;
        [Size(16)]
        public string ZTBMGYSSPTZID
        {
            get { return fZTBMGYSSPTZID; }
            set { SetPropertyValue<string>("ZTBMGYSSPTZID", ref fZTBMGYSSPTZID, value); }
        }
        string fBMID;
        [Size(16)]
        public string BMID
        {
            get { return fBMID; }
            set { SetPropertyValue<string>("BMID", ref fBMID, value); }
        }
        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }
        string fGYSID;
        [Size(16)]
        public string GYSID
        {
            get { return fGYSID; }
            set { SetPropertyValue<string>("GYSID", ref fGYSID, value); }
        }
        string fZTBMSPKFMXID;
        [Size(16)]
        public string ZTBMSPKFMXID
        {
            get { return fZTBMSPKFMXID; }
            set { SetPropertyValue<string>("ZTBMSPKFMXID", ref fZTBMSPKFMXID, value); }
        }
        string fSPXXID;
        [Size(16)]
        public string SPXXID
        {
            get { return fSPXXID; }
            set { SetPropertyValue<string>("SPXXID", ref fSPXXID, value); }
        }
        string fZDDM;
        [Size(15)]
        public string ZDDM
        {
            get { return fZDDM; }
            set { SetPropertyValue<string>("ZDDM", ref fZDDM, value); }
        }
        decimal fDJ;
        public decimal DJ
        {
            get { return fDJ; }
            set { SetPropertyValue<decimal>("DJ", ref fDJ, value); }
        }
        decimal fJZ;
        public decimal JZ
        {
            get { return fJZ; }
            set { SetPropertyValue<decimal>("JZ", ref fJZ, value); }
        }
        decimal fJJ;
        public decimal JJ
        {
            get { return fJJ; }
            set { SetPropertyValue<decimal>("JJ", ref fJJ, value); }
        }
        long fQCKC;
        public long QCKC
        {
            get { return fQCKC; }
            set { SetPropertyValue<long>("QCKC", ref fQCKC, value); }
        }
        decimal fQCMY;
        public decimal QCMY
        {
            get { return fQCMY; }
            set { SetPropertyValue<decimal>("QCMY", ref fQCMY, value); }
        }
        decimal fQCSY;
        public decimal QCSY
        {
            get { return fQCSY; }
            set { SetPropertyValue<decimal>("QCSY", ref fQCSY, value); }
        }
        long fJHSL;
        public long JHSL
        {
            get { return fJHSL; }
            set { SetPropertyValue<long>("JHSL", ref fJHSL, value); }
        }
        decimal fJHMY;
        public decimal JHMY
        {
            get { return fJHMY; }
            set { SetPropertyValue<decimal>("JHMY", ref fJHMY, value); }
        }
        decimal fJHSY;
        public decimal JHSY
        {
            get { return fJHSY; }
            set { SetPropertyValue<decimal>("JHSY", ref fJHSY, value); }
        }
        long fXSSL;
        public long XSSL
        {
            get { return fXSSL; }
            set { SetPropertyValue<long>("XSSL", ref fXSSL, value); }
        }
        decimal fXSMY;
        public decimal XSMY
        {
            get { return fXSMY; }
            set { SetPropertyValue<decimal>("XSMY", ref fXSMY, value); }
        }
        decimal fXSSY;
        public decimal XSSY
        {
            get { return fXSSY; }
            set { SetPropertyValue<decimal>("XSSY", ref fXSSY, value); }
        }
        long fXTSL;
        public long XTSL
        {
            get { return fXTSL; }
            set { SetPropertyValue<long>("XTSL", ref fXTSL, value); }
        }
        decimal fXTMY;
        public decimal XTMY
        {
            get { return fXTMY; }
            set { SetPropertyValue<decimal>("XTMY", ref fXTMY, value); }
        }
        decimal fXTSY;
        public decimal XTSY
        {
            get { return fXTSY; }
            set { SetPropertyValue<decimal>("XTSY", ref fXTSY, value); }
        }
        long fJTSL;
        public long JTSL
        {
            get { return fJTSL; }
            set { SetPropertyValue<long>("JTSL", ref fJTSL, value); }
        }
        decimal fJTMY;
        public decimal JTMY
        {
            get { return fJTMY; }
            set { SetPropertyValue<decimal>("JTMY", ref fJTMY, value); }
        }
        decimal fJTSY;
        public decimal JTSY
        {
            get { return fJTSY; }
            set { SetPropertyValue<decimal>("JTSY", ref fJTSY, value); }
        }
        long fQMKC;
        public long QMKC
        {
            get { return fQMKC; }
            set { SetPropertyValue<long>("QMKC", ref fQMKC, value); }
        }
        decimal fQMMY;
        public decimal QMMY
        {
            get { return fQMMY; }
            set { SetPropertyValue<decimal>("QMMY", ref fQMMY, value); }
        }
        decimal fQMSY;
        public decimal QMSY
        {
            get { return fQMSY; }
            set { SetPropertyValue<decimal>("QMSY", ref fQMSY, value); }
        }
        DateTime fJZRQ;
        public DateTime JZRQ
        {
            get { return fJZRQ; }
            set { SetPropertyValue<DateTime>("JZRQ", ref fJZRQ, value); }
        }
        string fJHFSID;
        [Size(16)]
        public string JHFSID
        {
            get { return fJHFSID; }
            set { SetPropertyValue<string>("JHFSID", ref fJHFSID, value); }
        }
        long fTHCS;
        public long THCS
        {
            get { return fTHCS; }
            set { SetPropertyValue<long>("THCS", ref fTHCS, value); }
        }
        string fZT;
        [Size(4)]
        public string ZT
        {
            get { return fZT; }
            set { SetPropertyValue<string>("ZT", ref fZT, value); }
        }
        string fYZT;
        [Size(4)]
        public string YZT
        {
            get { return fYZT; }
            set { SetPropertyValue<string>("YZT", ref fYZT, value); }
        }
        string fZTBZ;
        [Size(5)]
        public string ZTBZ
        {
            get { return fZTBZ; }
            set { SetPropertyValue<string>("ZTBZ", ref fZTBZ, value); }
        }
        string fBZ;
        public string BZ
        {
            get { return fBZ; }
            set { SetPropertyValue<string>("BZ", ref fBZ, value); }
        }
        decimal fYJSL;
        public decimal YJSL
        {
            get { return fYJSL; }
            set { SetPropertyValue<decimal>("YJSL", ref fYJSL, value); }
        }
        decimal fYJSY;
        public decimal YJSY
        {
            get { return fYJSY; }
            set { SetPropertyValue<decimal>("YJSY", ref fYJSY, value); }
        }
        decimal fYJMY;
        public decimal YJMY
        {
            get { return fYJMY; }
            set { SetPropertyValue<decimal>("YJMY", ref fYJMY, value); }
        }
        string fCGSHMXID;
        [Size(16)]
        public string CGSHMXID
        {
            get { return fCGSHMXID; }
            set { SetPropertyValue<string>("CGSHMXID", ref fCGSHMXID, value); }
        }
        long fZZSL;
        public long ZZSL
        {
            get { return fZZSL; }
            set { SetPropertyValue<long>("ZZSL", ref fZZSL, value); }
        }
        decimal fZZSY;
        public decimal ZZSY
        {
            get { return fZZSY; }
            set { SetPropertyValue<decimal>("ZZSY", ref fZZSY, value); }
        }
        decimal fZZMY;
        public decimal ZZMY
        {
            get { return fZZMY; }
            set { SetPropertyValue<decimal>("ZZMY", ref fZZMY, value); }
        }
        long fYTSL;
        public long YTSL
        {
            get { return fYTSL; }
            set { SetPropertyValue<long>("YTSL", ref fYTSL, value); }
        }
        decimal fYTSY;
        public decimal YTSY
        {
            get { return fYTSY; }
            set { SetPropertyValue<decimal>("YTSY", ref fYTSY, value); }
        }
        decimal fYTMY;
        public decimal YTMY
        {
            get { return fYTMY; }
            set { SetPropertyValue<decimal>("YTMY", ref fYTMY, value); }
        }
        long fSXSL;
        public long SXSL
        {
            get { return fSXSL; }
            set { SetPropertyValue<long>("SXSL", ref fSXSL, value); }
        }
        decimal fSXMY;
        public decimal SXMY
        {
            get { return fSXMY; }
            set { SetPropertyValue<decimal>("SXMY", ref fSXMY, value); }
        }
        decimal fSXSY;
        public decimal SXSY
        {
            get { return fSXSY; }
            set { SetPropertyValue<decimal>("SXSY", ref fSXSY, value); }
        }
        decimal fXZ;
        public decimal XZ
        {
            get { return fXZ; }
            set { SetPropertyValue<decimal>("XZ", ref fXZ, value); }
        }
        decimal fXJ;
        public decimal XJ
        {
            get { return fXJ; }
            set { SetPropertyValue<decimal>("XJ", ref fXJ, value); }
        }
        string fJTBMSPKFMXID;
        [Size(16)]
        public string JTBMSPKFMXID
        {
            get { return fJTBMSPKFMXID; }
            set { SetPropertyValue<string>("JTBMSPKFMXID", ref fJTBMSPKFMXID, value); }
        }
        public VIEW_JT_C_ZTBMGYSSPMX(Session session) : base(session) { }
        public VIEW_JT_C_ZTBMGYSSPMX() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class VIEW_JT_C_ZTBMGYSSPTZ : XPLiteObject
    {
        string fZTBMGYSSPTZID;
        [Key]
        [Size(16)]
        public string ZTBMGYSSPTZID
        {
            get { return fZTBMGYSSPTZID; }
            set { SetPropertyValue<string>("ZTBMGYSSPTZID", ref fZTBMGYSSPTZID, value); }
        }
        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }
        string fBMMC;
        [Size(100)]
        public string BMMC
        {
            get { return fBMMC; }
            set { SetPropertyValue<string>("BMMC", ref fBMMC, value); }
        }
        string fGYSMC;
        [Size(100)]
        public string GYSMC
        {
            get { return fGYSMC; }
            set { SetPropertyValue<string>("GYSMC", ref fGYSMC, value); }
        }
        string fPM;
        [Size(100)]
        public string PM
        {
            get { return fPM; }
            set { SetPropertyValue<string>("PM", ref fPM, value); }
        }
        string fBMID;
        [Size(16)]
        public string BMID
        {
            get { return fBMID; }
            set { SetPropertyValue<string>("BMID", ref fBMID, value); }
        }
        string fGYSID;
        [Size(16)]
        public string GYSID
        {
            get { return fGYSID; }
            set { SetPropertyValue<string>("GYSID", ref fGYSID, value); }
        }
        string fSPXXID;
        [Size(16)]
        public string SPXXID
        {
            get { return fSPXXID; }
            set { SetPropertyValue<string>("SPXXID", ref fSPXXID, value); }
        }
        long fQCKC;
        public long QCKC
        {
            get { return fQCKC; }
            set { SetPropertyValue<long>("QCKC", ref fQCKC, value); }
        }
        decimal fQCMY;
        public decimal QCMY
        {
            get { return fQCMY; }
            set { SetPropertyValue<decimal>("QCMY", ref fQCMY, value); }
        }
        decimal fQCSY;
        public decimal QCSY
        {
            get { return fQCSY; }
            set { SetPropertyValue<decimal>("QCSY", ref fQCSY, value); }
        }
        long fJHSL;
        public long JHSL
        {
            get { return fJHSL; }
            set { SetPropertyValue<long>("JHSL", ref fJHSL, value); }
        }
        decimal fJHMY;
        public decimal JHMY
        {
            get { return fJHMY; }
            set { SetPropertyValue<decimal>("JHMY", ref fJHMY, value); }
        }
        decimal fJHSY;
        public decimal JHSY
        {
            get { return fJHSY; }
            set { SetPropertyValue<decimal>("JHSY", ref fJHSY, value); }
        }
        long fXSSL;
        public long XSSL
        {
            get { return fXSSL; }
            set { SetPropertyValue<long>("XSSL", ref fXSSL, value); }
        }
        decimal fXSMY;
        public decimal XSMY
        {
            get { return fXSMY; }
            set { SetPropertyValue<decimal>("XSMY", ref fXSMY, value); }
        }
        decimal fXSSY;
        public decimal XSSY
        {
            get { return fXSSY; }
            set { SetPropertyValue<decimal>("XSSY", ref fXSSY, value); }
        }
        long fXTSL;
        public long XTSL
        {
            get { return fXTSL; }
            set { SetPropertyValue<long>("XTSL", ref fXTSL, value); }
        }
        decimal fXTMY;
        public decimal XTMY
        {
            get { return fXTMY; }
            set { SetPropertyValue<decimal>("XTMY", ref fXTMY, value); }
        }
        decimal fXTSY;
        public decimal XTSY
        {
            get { return fXTSY; }
            set { SetPropertyValue<decimal>("XTSY", ref fXTSY, value); }
        }
        long fJTSL;
        public long JTSL
        {
            get { return fJTSL; }
            set { SetPropertyValue<long>("JTSL", ref fJTSL, value); }
        }
        decimal fJTMY;
        public decimal JTMY
        {
            get { return fJTMY; }
            set { SetPropertyValue<decimal>("JTMY", ref fJTMY, value); }
        }
        decimal fJTSY;
        public decimal JTSY
        {
            get { return fJTSY; }
            set { SetPropertyValue<decimal>("JTSY", ref fJTSY, value); }
        }
        long fQMKC;
        public long QMKC
        {
            get { return fQMKC; }
            set { SetPropertyValue<long>("QMKC", ref fQMKC, value); }
        }
        decimal fQMMY;
        public decimal QMMY
        {
            get { return fQMMY; }
            set { SetPropertyValue<decimal>("QMMY", ref fQMMY, value); }
        }
        decimal fQMSY;
        public decimal QMSY
        {
            get { return fQMSY; }
            set { SetPropertyValue<decimal>("QMSY", ref fQMSY, value); }
        }
        long fJHCS;
        public long JHCS
        {
            get { return fJHCS; }
            set { SetPropertyValue<long>("JHCS", ref fJHCS, value); }
        }
        long fTHCS;
        public long THCS
        {
            get { return fTHCS; }
            set { SetPropertyValue<long>("THCS", ref fTHCS, value); }
        }
        string fZT;
        [Size(4)]
        public string ZT
        {
            get { return fZT; }
            set { SetPropertyValue<string>("ZT", ref fZT, value); }
        }
        string fYZT;
        [Size(4)]
        public string YZT
        {
            get { return fYZT; }
            set { SetPropertyValue<string>("YZT", ref fYZT, value); }
        }
        string fZTBZ;
        [Size(1)]
        public string ZTBZ
        {
            get { return fZTBZ; }
            set { SetPropertyValue<string>("ZTBZ", ref fZTBZ, value); }
        }
        string fBZ;
        public string BZ
        {
            get { return fBZ; }
            set { SetPropertyValue<string>("BZ", ref fBZ, value); }
        }
        long fYJSL;
        public long YJSL
        {
            get { return fYJSL; }
            set { SetPropertyValue<long>("YJSL", ref fYJSL, value); }
        }
        decimal fYJSY;
        public decimal YJSY
        {
            get { return fYJSY; }
            set { SetPropertyValue<decimal>("YJSY", ref fYJSY, value); }
        }
        decimal fYJMY;
        public decimal YJMY
        {
            get { return fYJMY; }
            set { SetPropertyValue<decimal>("YJMY", ref fYJMY, value); }
        }
        long fZZSL;
        public long ZZSL
        {
            get { return fZZSL; }
            set { SetPropertyValue<long>("ZZSL", ref fZZSL, value); }
        }
        decimal fZZSY;
        public decimal ZZSY
        {
            get { return fZZSY; }
            set { SetPropertyValue<decimal>("ZZSY", ref fZZSY, value); }
        }
        decimal fZZMY;
        public decimal ZZMY
        {
            get { return fZZMY; }
            set { SetPropertyValue<decimal>("ZZMY", ref fZZMY, value); }
        }
        long fYTSL;
        public long YTSL
        {
            get { return fYTSL; }
            set { SetPropertyValue<long>("YTSL", ref fYTSL, value); }
        }
        decimal fYTSY;
        public decimal YTSY
        {
            get { return fYTSY; }
            set { SetPropertyValue<decimal>("YTSY", ref fYTSY, value); }
        }
        decimal fYTMY;
        public decimal YTMY
        {
            get { return fYTMY; }
            set { SetPropertyValue<decimal>("YTMY", ref fYTMY, value); }
        }
        long fSXSL;
        public long SXSL
        {
            get { return fSXSL; }
            set { SetPropertyValue<long>("SXSL", ref fSXSL, value); }
        }
        decimal fSXMY;
        public decimal SXMY
        {
            get { return fSXMY; }
            set { SetPropertyValue<decimal>("SXMY", ref fSXMY, value); }
        }
        decimal fSXSY;
        public decimal SXSY
        {
            get { return fSXSY; }
            set { SetPropertyValue<decimal>("SXSY", ref fSXSY, value); }
        }
        public VIEW_JT_C_ZTBMGYSSPTZ(Session session) : base(session) { }
        public VIEW_JT_C_ZTBMGYSSPTZ() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class VIEW_JC_C_ZTBMKHSPTZ : XPLiteObject
    {
        string fZTBMKHSPTZID;
        [Key]
        [Size(16)]
        public string ZTBMKHSPTZID
        {
            get { return fZTBMKHSPTZID; }
            set { SetPropertyValue<string>("ZTBMKHSPTZID", ref fZTBMKHSPTZID, value); }
        }
        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }
        string fYWBMMC;
        [Size(100)]
        public string YWBMMC
        {
            get { return fYWBMMC; }
            set { SetPropertyValue<string>("YWBMMC", ref fYWBMMC, value); }
        }
        string fKHMC;
        [Size(100)]
        public string KHMC
        {
            get { return fKHMC; }
            set { SetPropertyValue<string>("KHMC", ref fKHMC, value); }
        }
        string fPM;
        [Size(100)]
        public string PM
        {
            get { return fPM; }
            set { SetPropertyValue<string>("PM", ref fPM, value); }
        }
        string fYWBMID;
        [Size(16)]
        public string YWBMID
        {
            get { return fYWBMID; }
            set { SetPropertyValue<string>("YWBMID", ref fYWBMID, value); }
        }
        string fKHID;
        [Size(16)]
        public string KHID
        {
            get { return fKHID; }
            set { SetPropertyValue<string>("KHID", ref fKHID, value); }
        }
        string fSPXXID;
        [Size(16)]
        public string SPXXID
        {
            get { return fSPXXID; }
            set { SetPropertyValue<string>("SPXXID", ref fSPXXID, value); }
        }
        string fZDDM;
        [Size(15)]
        public string ZDDM
        {
            get { return fZDDM; }
            set { SetPropertyValue<string>("ZDDM", ref fZDDM, value); }
        }
        long fQCKC;
        public long QCKC
        {
            get { return fQCKC; }
            set { SetPropertyValue<long>("QCKC", ref fQCKC, value); }
        }
        decimal fQCMY;
        public decimal QCMY
        {
            get { return fQCMY; }
            set { SetPropertyValue<decimal>("QCMY", ref fQCMY, value); }
        }
        decimal fQCSY;
        public decimal QCSY
        {
            get { return fQCSY; }
            set { SetPropertyValue<decimal>("QCSY", ref fQCSY, value); }
        }
        long fJHSL;
        public long JHSL
        {
            get { return fJHSL; }
            set { SetPropertyValue<long>("JHSL", ref fJHSL, value); }
        }
        decimal fJHMY;
        public decimal JHMY
        {
            get { return fJHMY; }
            set { SetPropertyValue<decimal>("JHMY", ref fJHMY, value); }
        }
        decimal fJHSY;
        public decimal JHSY
        {
            get { return fJHSY; }
            set { SetPropertyValue<decimal>("JHSY", ref fJHSY, value); }
        }
        long fXSSL;
        public long XSSL
        {
            get { return fXSSL; }
            set { SetPropertyValue<long>("XSSL", ref fXSSL, value); }
        }
        decimal fXSMY;
        public decimal XSMY
        {
            get { return fXSMY; }
            set { SetPropertyValue<decimal>("XSMY", ref fXSMY, value); }
        }
        decimal fXSSY;
        public decimal XSSY
        {
            get { return fXSSY; }
            set { SetPropertyValue<decimal>("XSSY", ref fXSSY, value); }
        }
        long fJTSL;
        public long JTSL
        {
            get { return fJTSL; }
            set { SetPropertyValue<long>("JTSL", ref fJTSL, value); }
        }
        decimal fJTMY;
        public decimal JTMY
        {
            get { return fJTMY; }
            set { SetPropertyValue<decimal>("JTMY", ref fJTMY, value); }
        }
        decimal fJTSY;
        public decimal JTSY
        {
            get { return fJTSY; }
            set { SetPropertyValue<decimal>("JTSY", ref fJTSY, value); }
        }
        long fQMKC;
        public long QMKC
        {
            get { return fQMKC; }
            set { SetPropertyValue<long>("QMKC", ref fQMKC, value); }
        }
        decimal fQMMY;
        public decimal QMMY
        {
            get { return fQMMY; }
            set { SetPropertyValue<decimal>("QMMY", ref fQMMY, value); }
        }
        decimal fQMSY;
        public decimal QMSY
        {
            get { return fQMSY; }
            set { SetPropertyValue<decimal>("QMSY", ref fQMSY, value); }
        }
        long fJHCS;
        public long JHCS
        {
            get { return fJHCS; }
            set { SetPropertyValue<long>("JHCS", ref fJHCS, value); }
        }
        long fTHCS;
        public long THCS
        {
            get { return fTHCS; }
            set { SetPropertyValue<long>("THCS", ref fTHCS, value); }
        }
        string fZT;
        [Size(4)]
        public string ZT
        {
            get { return fZT; }
            set { SetPropertyValue<string>("ZT", ref fZT, value); }
        }
        string fYZT;
        [Size(4)]
        public string YZT
        {
            get { return fYZT; }
            set { SetPropertyValue<string>("YZT", ref fYZT, value); }
        }
        string fBZ;
        public string BZ
        {
            get { return fBZ; }
            set { SetPropertyValue<string>("BZ", ref fBZ, value); }
        }
        long fYJSL;
        public long YJSL
        {
            get { return fYJSL; }
            set { SetPropertyValue<long>("YJSL", ref fYJSL, value); }
        }
        decimal fYJSY;
        public decimal YJSY
        {
            get { return fYJSY; }
            set { SetPropertyValue<decimal>("YJSY", ref fYJSY, value); }
        }
        decimal fYJMY;
        public decimal YJMY
        {
            get { return fYJMY; }
            set { SetPropertyValue<decimal>("YJMY", ref fYJMY, value); }
        }
        long fYTCS;
        public long YTCS
        {
            get { return fYTCS; }
            set { SetPropertyValue<long>("YTCS", ref fYTCS, value); }
        }
        decimal fYTMY;
        public decimal YTMY
        {
            get { return fYTMY; }
            set { SetPropertyValue<decimal>("YTMY", ref fYTMY, value); }
        }
        decimal fYTSY;
        public decimal YTSY
        {
            get { return fYTSY; }
            set { SetPropertyValue<decimal>("YTSY", ref fYTSY, value); }
        }
        long fZZSL;
        public long ZZSL
        {
            get { return fZZSL; }
            set { SetPropertyValue<long>("ZZSL", ref fZZSL, value); }
        }
        decimal fZZSY;
        public decimal ZZSY
        {
            get { return fZZSY; }
            set { SetPropertyValue<decimal>("ZZSY", ref fZZSY, value); }
        }
        decimal fZZMY;
        public decimal ZZMY
        {
            get { return fZZMY; }
            set { SetPropertyValue<decimal>("ZZMY", ref fZZMY, value); }
        }
        long fKTZSL;
        public long KTZSL
        {
            get { return fKTZSL; }
            set { SetPropertyValue<long>("KTZSL", ref fKTZSL, value); }
        }
        long fSYSL;
        public long SYSL
        {
            get { return fSYSL; }
            set { SetPropertyValue<long>("SYSL", ref fSYSL, value); }
        }
        decimal fSYSY;
        public decimal SYSY
        {
            get { return fSYSY; }
            set { SetPropertyValue<decimal>("SYSY", ref fSYSY, value); }
        }
        decimal fSYMY;
        public decimal SYMY
        {
            get { return fSYMY; }
            set { SetPropertyValue<decimal>("SYMY", ref fSYMY, value); }
        }
        public VIEW_JC_C_ZTBMKHSPTZ(Session session) : base(session) { }
        public VIEW_JC_C_ZTBMKHSPTZ() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class VIEW_JC_C_ZTBMKHSPMX : XPLiteObject
    {
        string fPM;
        [Size(100)]
        public string PM
        {
            get { return fPM; }
            set { SetPropertyValue<string>("PM", ref fPM, value); }
        }
        decimal fJTMY;
        public decimal JTMY
        {
            get { return fJTMY; }
            set { SetPropertyValue<decimal>("JTMY", ref fJTMY, value); }
        }
        decimal fJTSY;
        public decimal JTSY
        {
            get { return fJTSY; }
            set { SetPropertyValue<decimal>("JTSY", ref fJTSY, value); }
        }
        long fQMKC;
        public long QMKC
        {
            get { return fQMKC; }
            set { SetPropertyValue<long>("QMKC", ref fQMKC, value); }
        }
        decimal fQMMY;
        public decimal QMMY
        {
            get { return fQMMY; }
            set { SetPropertyValue<decimal>("QMMY", ref fQMMY, value); }
        }
        decimal fQMSY;
        public decimal QMSY
        {
            get { return fQMSY; }
            set { SetPropertyValue<decimal>("QMSY", ref fQMSY, value); }
        }
        DateTime fJZRQ;
        public DateTime JZRQ
        {
            get { return fJZRQ; }
            set { SetPropertyValue<DateTime>("JZRQ", ref fJZRQ, value); }
        }
        string fXSFSID;
        [Size(16)]
        public string XSFSID
        {
            get { return fXSFSID; }
            set { SetPropertyValue<string>("XSFSID", ref fXSFSID, value); }
        }
        long fTHCS;
        public long THCS
        {
            get { return fTHCS; }
            set { SetPropertyValue<long>("THCS", ref fTHCS, value); }
        }
        string fZT;
        [Size(4)]
        public string ZT
        {
            get { return fZT; }
            set { SetPropertyValue<string>("ZT", ref fZT, value); }
        }
        string fYZT;
        [Size(4)]
        public string YZT
        {
            get { return fYZT; }
            set { SetPropertyValue<string>("YZT", ref fYZT, value); }
        }
        string fBZ;
        public string BZ
        {
            get { return fBZ; }
            set { SetPropertyValue<string>("BZ", ref fBZ, value); }
        }
        long fYJSL;
        public long YJSL
        {
            get { return fYJSL; }
            set { SetPropertyValue<long>("YJSL", ref fYJSL, value); }
        }
        decimal fYJSY;
        public decimal YJSY
        {
            get { return fYJSY; }
            set { SetPropertyValue<decimal>("YJSY", ref fYJSY, value); }
        }
        decimal fYJMY;
        public decimal YJMY
        {
            get { return fYJMY; }
            set { SetPropertyValue<decimal>("YJMY", ref fYJMY, value); }
        }
        long fYTCS;
        public long YTCS
        {
            get { return fYTCS; }
            set { SetPropertyValue<long>("YTCS", ref fYTCS, value); }
        }
        decimal fYTMY;
        public decimal YTMY
        {
            get { return fYTMY; }
            set { SetPropertyValue<decimal>("YTMY", ref fYTMY, value); }
        }
        decimal fYTSY;
        public decimal YTSY
        {
            get { return fYTSY; }
            set { SetPropertyValue<decimal>("YTSY", ref fYTSY, value); }
        }
        string fXSDMXID;
        [Size(16)]
        public string XSDMXID
        {
            get { return fXSDMXID; }
            set { SetPropertyValue<string>("XSDMXID", ref fXSDMXID, value); }
        }
        long fZZSL;
        public long ZZSL
        {
            get { return fZZSL; }
            set { SetPropertyValue<long>("ZZSL", ref fZZSL, value); }
        }
        decimal fZZSY;
        public decimal ZZSY
        {
            get { return fZZSY; }
            set { SetPropertyValue<decimal>("ZZSY", ref fZZSY, value); }
        }
        decimal fZZMY;
        public decimal ZZMY
        {
            get { return fZZMY; }
            set { SetPropertyValue<decimal>("ZZMY", ref fZZMY, value); }
        }
        long fKTSL;
        public long KTSL
        {
            get { return fKTSL; }
            set { SetPropertyValue<long>("KTSL", ref fKTSL, value); }
        }
        DateTime fTHQX;
        public DateTime THQX
        {
            get { return fTHQX; }
            set { SetPropertyValue<DateTime>("THQX", ref fTHQX, value); }
        }
        string fSFTZ;
        [Size(5)]
        public string SFTZ
        {
            get { return fSFTZ; }
            set { SetPropertyValue<string>("SFTZ", ref fSFTZ, value); }
        }
        long fSYSL;
        public long SYSL
        {
            get { return fSYSL; }
            set { SetPropertyValue<long>("SYSL", ref fSYSL, value); }
        }
        decimal fSYSY;
        public decimal SYSY
        {
            get { return fSYSY; }
            set { SetPropertyValue<decimal>("SYSY", ref fSYSY, value); }
        }
        decimal fSYMY;
        public decimal SYMY
        {
            get { return fSYMY; }
            set { SetPropertyValue<decimal>("SYMY", ref fSYMY, value); }
        }
        string fZTBMKHSPMXID;
        [Key]
        [Size(16)]
        public string ZTBMKHSPMXID
        {
            get { return fZTBMKHSPMXID; }
            set { SetPropertyValue<string>("ZTBMKHSPMXID", ref fZTBMKHSPMXID, value); }
        }
        string fZTBMKHSPTZID;
        [Size(16)]
        public string ZTBMKHSPTZID
        {
            get { return fZTBMKHSPTZID; }
            set { SetPropertyValue<string>("ZTBMKHSPTZID", ref fZTBMKHSPTZID, value); }
        }
        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }
        string fYWBMID;
        [Size(16)]
        public string YWBMID
        {
            get { return fYWBMID; }
            set { SetPropertyValue<string>("YWBMID", ref fYWBMID, value); }
        }
        string fKHID;
        [Size(16)]
        public string KHID
        {
            get { return fKHID; }
            set { SetPropertyValue<string>("KHID", ref fKHID, value); }
        }
        string fBMSPKFMXID;
        [Size(16)]
        public string BMSPKFMXID
        {
            get { return fBMSPKFMXID; }
            set { SetPropertyValue<string>("BMSPKFMXID", ref fBMSPKFMXID, value); }
        }
        string fSPXXID;
        [Size(16)]
        public string SPXXID
        {
            get { return fSPXXID; }
            set { SetPropertyValue<string>("SPXXID", ref fSPXXID, value); }
        }
        decimal fDJ;
        public decimal DJ
        {
            get { return fDJ; }
            set { SetPropertyValue<decimal>("DJ", ref fDJ, value); }
        }
        decimal fJZ;
        public decimal JZ
        {
            get { return fJZ; }
            set { SetPropertyValue<decimal>("JZ", ref fJZ, value); }
        }
        decimal fJJ;
        public decimal JJ
        {
            get { return fJJ; }
            set { SetPropertyValue<decimal>("JJ", ref fJJ, value); }
        }
        long fQCKC;
        public long QCKC
        {
            get { return fQCKC; }
            set { SetPropertyValue<long>("QCKC", ref fQCKC, value); }
        }
        decimal fQCMY;
        public decimal QCMY
        {
            get { return fQCMY; }
            set { SetPropertyValue<decimal>("QCMY", ref fQCMY, value); }
        }
        decimal fQCSY;
        public decimal QCSY
        {
            get { return fQCSY; }
            set { SetPropertyValue<decimal>("QCSY", ref fQCSY, value); }
        }
        long fJHSL;
        public long JHSL
        {
            get { return fJHSL; }
            set { SetPropertyValue<long>("JHSL", ref fJHSL, value); }
        }
        decimal fJHMY;
        public decimal JHMY
        {
            get { return fJHMY; }
            set { SetPropertyValue<decimal>("JHMY", ref fJHMY, value); }
        }
        decimal fJHSY;
        public decimal JHSY
        {
            get { return fJHSY; }
            set { SetPropertyValue<decimal>("JHSY", ref fJHSY, value); }
        }
        long fXSSL;
        public long XSSL
        {
            get { return fXSSL; }
            set { SetPropertyValue<long>("XSSL", ref fXSSL, value); }
        }
        decimal fXSMY;
        public decimal XSMY
        {
            get { return fXSMY; }
            set { SetPropertyValue<decimal>("XSMY", ref fXSMY, value); }
        }
        decimal fXSSY;
        public decimal XSSY
        {
            get { return fXSSY; }
            set { SetPropertyValue<decimal>("XSSY", ref fXSSY, value); }
        }
        long fJTSL;
        public long JTSL
        {
            get { return fJTSL; }
            set { SetPropertyValue<long>("JTSL", ref fJTSL, value); }
        }
        public VIEW_JC_C_ZTBMKHSPMX(Session session) : base(session) { }
        public VIEW_JC_C_ZTBMKHSPMX() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class VIEW_JC_C_ZTBMGYSSPMX : XPLiteObject
    {
        string fPM;
        [Size(100)]
        public string PM
        {
            get { return fPM; }
            set { SetPropertyValue<string>("PM", ref fPM, value); }
        }
        string fZTBMGYSSPMXID;
        [Key]
        [Size(16)]
        public string ZTBMGYSSPMXID
        {
            get { return fZTBMGYSSPMXID; }
            set { SetPropertyValue<string>("ZTBMGYSSPMXID", ref fZTBMGYSSPMXID, value); }
        }
        string fZTBMGYSSPTZID;
        [Size(16)]
        public string ZTBMGYSSPTZID
        {
            get { return fZTBMGYSSPTZID; }
            set { SetPropertyValue<string>("ZTBMGYSSPTZID", ref fZTBMGYSSPTZID, value); }
        }
        string fBMID;
        [Size(16)]
        public string BMID
        {
            get { return fBMID; }
            set { SetPropertyValue<string>("BMID", ref fBMID, value); }
        }
        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }
        string fGYSID;
        [Size(16)]
        public string GYSID
        {
            get { return fGYSID; }
            set { SetPropertyValue<string>("GYSID", ref fGYSID, value); }
        }
        string fZTBMSPKFMXID;
        [Size(16)]
        public string ZTBMSPKFMXID
        {
            get { return fZTBMSPKFMXID; }
            set { SetPropertyValue<string>("ZTBMSPKFMXID", ref fZTBMSPKFMXID, value); }
        }
        string fSPXXID;
        [Size(16)]
        public string SPXXID
        {
            get { return fSPXXID; }
            set { SetPropertyValue<string>("SPXXID", ref fSPXXID, value); }
        }
        string fZDDM;
        [Size(15)]
        public string ZDDM
        {
            get { return fZDDM; }
            set { SetPropertyValue<string>("ZDDM", ref fZDDM, value); }
        }
        decimal fDJ;
        public decimal DJ
        {
            get { return fDJ; }
            set { SetPropertyValue<decimal>("DJ", ref fDJ, value); }
        }
        decimal fJZ;
        public decimal JZ
        {
            get { return fJZ; }
            set { SetPropertyValue<decimal>("JZ", ref fJZ, value); }
        }
        decimal fJJ;
        public decimal JJ
        {
            get { return fJJ; }
            set { SetPropertyValue<decimal>("JJ", ref fJJ, value); }
        }
        long fQCKC;
        public long QCKC
        {
            get { return fQCKC; }
            set { SetPropertyValue<long>("QCKC", ref fQCKC, value); }
        }
        decimal fQCMY;
        public decimal QCMY
        {
            get { return fQCMY; }
            set { SetPropertyValue<decimal>("QCMY", ref fQCMY, value); }
        }
        decimal fQCSY;
        public decimal QCSY
        {
            get { return fQCSY; }
            set { SetPropertyValue<decimal>("QCSY", ref fQCSY, value); }
        }
        long fJHSL;
        public long JHSL
        {
            get { return fJHSL; }
            set { SetPropertyValue<long>("JHSL", ref fJHSL, value); }
        }
        decimal fJHMY;
        public decimal JHMY
        {
            get { return fJHMY; }
            set { SetPropertyValue<decimal>("JHMY", ref fJHMY, value); }
        }
        decimal fJHSY;
        public decimal JHSY
        {
            get { return fJHSY; }
            set { SetPropertyValue<decimal>("JHSY", ref fJHSY, value); }
        }
        long fXSSL;
        public long XSSL
        {
            get { return fXSSL; }
            set { SetPropertyValue<long>("XSSL", ref fXSSL, value); }
        }
        decimal fXSMY;
        public decimal XSMY
        {
            get { return fXSMY; }
            set { SetPropertyValue<decimal>("XSMY", ref fXSMY, value); }
        }
        decimal fXSSY;
        public decimal XSSY
        {
            get { return fXSSY; }
            set { SetPropertyValue<decimal>("XSSY", ref fXSSY, value); }
        }
        long fXTSL;
        public long XTSL
        {
            get { return fXTSL; }
            set { SetPropertyValue<long>("XTSL", ref fXTSL, value); }
        }
        decimal fXTMY;
        public decimal XTMY
        {
            get { return fXTMY; }
            set { SetPropertyValue<decimal>("XTMY", ref fXTMY, value); }
        }
        decimal fXTSY;
        public decimal XTSY
        {
            get { return fXTSY; }
            set { SetPropertyValue<decimal>("XTSY", ref fXTSY, value); }
        }
        long fJTSL;
        public long JTSL
        {
            get { return fJTSL; }
            set { SetPropertyValue<long>("JTSL", ref fJTSL, value); }
        }
        decimal fJTMY;
        public decimal JTMY
        {
            get { return fJTMY; }
            set { SetPropertyValue<decimal>("JTMY", ref fJTMY, value); }
        }
        decimal fJTSY;
        public decimal JTSY
        {
            get { return fJTSY; }
            set { SetPropertyValue<decimal>("JTSY", ref fJTSY, value); }
        }
        long fQMKC;
        public long QMKC
        {
            get { return fQMKC; }
            set { SetPropertyValue<long>("QMKC", ref fQMKC, value); }
        }
        decimal fQMMY;
        public decimal QMMY
        {
            get { return fQMMY; }
            set { SetPropertyValue<decimal>("QMMY", ref fQMMY, value); }
        }
        decimal fQMSY;
        public decimal QMSY
        {
            get { return fQMSY; }
            set { SetPropertyValue<decimal>("QMSY", ref fQMSY, value); }
        }
        DateTime fJZRQ;
        public DateTime JZRQ
        {
            get { return fJZRQ; }
            set { SetPropertyValue<DateTime>("JZRQ", ref fJZRQ, value); }
        }
        string fJHFSID;
        [Size(16)]
        public string JHFSID
        {
            get { return fJHFSID; }
            set { SetPropertyValue<string>("JHFSID", ref fJHFSID, value); }
        }
        long fTHCS;
        public long THCS
        {
            get { return fTHCS; }
            set { SetPropertyValue<long>("THCS", ref fTHCS, value); }
        }
        string fZT;
        [Size(4)]
        public string ZT
        {
            get { return fZT; }
            set { SetPropertyValue<string>("ZT", ref fZT, value); }
        }
        string fYZT;
        [Size(4)]
        public string YZT
        {
            get { return fYZT; }
            set { SetPropertyValue<string>("YZT", ref fYZT, value); }
        }
        string fZTBZ;
        [Size(5)]
        public string ZTBZ
        {
            get { return fZTBZ; }
            set { SetPropertyValue<string>("ZTBZ", ref fZTBZ, value); }
        }
        string fBZ;
        public string BZ
        {
            get { return fBZ; }
            set { SetPropertyValue<string>("BZ", ref fBZ, value); }
        }
        decimal fYJSL;
        public decimal YJSL
        {
            get { return fYJSL; }
            set { SetPropertyValue<decimal>("YJSL", ref fYJSL, value); }
        }
        decimal fYJSY;
        public decimal YJSY
        {
            get { return fYJSY; }
            set { SetPropertyValue<decimal>("YJSY", ref fYJSY, value); }
        }
        decimal fYJMY;
        public decimal YJMY
        {
            get { return fYJMY; }
            set { SetPropertyValue<decimal>("YJMY", ref fYJMY, value); }
        }
        string fCGSHMXID;
        [Size(16)]
        public string CGSHMXID
        {
            get { return fCGSHMXID; }
            set { SetPropertyValue<string>("CGSHMXID", ref fCGSHMXID, value); }
        }
        long fZZSL;
        public long ZZSL
        {
            get { return fZZSL; }
            set { SetPropertyValue<long>("ZZSL", ref fZZSL, value); }
        }
        decimal fZZSY;
        public decimal ZZSY
        {
            get { return fZZSY; }
            set { SetPropertyValue<decimal>("ZZSY", ref fZZSY, value); }
        }
        decimal fZZMY;
        public decimal ZZMY
        {
            get { return fZZMY; }
            set { SetPropertyValue<decimal>("ZZMY", ref fZZMY, value); }
        }
        long fYTSL;
        public long YTSL
        {
            get { return fYTSL; }
            set { SetPropertyValue<long>("YTSL", ref fYTSL, value); }
        }
        decimal fYTSY;
        public decimal YTSY
        {
            get { return fYTSY; }
            set { SetPropertyValue<decimal>("YTSY", ref fYTSY, value); }
        }
        decimal fYTMY;
        public decimal YTMY
        {
            get { return fYTMY; }
            set { SetPropertyValue<decimal>("YTMY", ref fYTMY, value); }
        }
        long fSXSL;
        public long SXSL
        {
            get { return fSXSL; }
            set { SetPropertyValue<long>("SXSL", ref fSXSL, value); }
        }
        decimal fSXMY;
        public decimal SXMY
        {
            get { return fSXMY; }
            set { SetPropertyValue<decimal>("SXMY", ref fSXMY, value); }
        }
        decimal fSXSY;
        public decimal SXSY
        {
            get { return fSXSY; }
            set { SetPropertyValue<decimal>("SXSY", ref fSXSY, value); }
        }
        decimal fXZ;
        public decimal XZ
        {
            get { return fXZ; }
            set { SetPropertyValue<decimal>("XZ", ref fXZ, value); }
        }
        decimal fXJ;
        public decimal XJ
        {
            get { return fXJ; }
            set { SetPropertyValue<decimal>("XJ", ref fXJ, value); }
        }
        string fJTBMSPKFMXID;
        [Size(16)]
        public string JTBMSPKFMXID
        {
            get { return fJTBMSPKFMXID; }
            set { SetPropertyValue<string>("JTBMSPKFMXID", ref fJTBMSPKFMXID, value); }
        }
        public VIEW_JC_C_ZTBMGYSSPMX(Session session) : base(session) { }
        public VIEW_JC_C_ZTBMGYSSPMX() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class VIEW_JC_C_ZTBMGYSSPTZ : XPLiteObject
    {
        string fZTBMGYSSPTZID;
        [Key]
        [Size(16)]
        public string ZTBMGYSSPTZID
        {
            get { return fZTBMGYSSPTZID; }
            set { SetPropertyValue<string>("ZTBMGYSSPTZID", ref fZTBMGYSSPTZID, value); }
        }
        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }
        string fBMMC;
        [Size(100)]
        public string BMMC
        {
            get { return fBMMC; }
            set { SetPropertyValue<string>("BMMC", ref fBMMC, value); }
        }
        string fGYSMC;
        [Size(100)]
        public string GYSMC
        {
            get { return fGYSMC; }
            set { SetPropertyValue<string>("GYSMC", ref fGYSMC, value); }
        }
        string fPM;
        [Size(100)]
        public string PM
        {
            get { return fPM; }
            set { SetPropertyValue<string>("PM", ref fPM, value); }
        }
        string fBMID;
        [Size(16)]
        public string BMID
        {
            get { return fBMID; }
            set { SetPropertyValue<string>("BMID", ref fBMID, value); }
        }
        string fGYSID;
        [Size(16)]
        public string GYSID
        {
            get { return fGYSID; }
            set { SetPropertyValue<string>("GYSID", ref fGYSID, value); }
        }
        string fSPXXID;
        [Size(16)]
        public string SPXXID
        {
            get { return fSPXXID; }
            set { SetPropertyValue<string>("SPXXID", ref fSPXXID, value); }
        }
        long fQCKC;
        public long QCKC
        {
            get { return fQCKC; }
            set { SetPropertyValue<long>("QCKC", ref fQCKC, value); }
        }
        decimal fQCMY;
        public decimal QCMY
        {
            get { return fQCMY; }
            set { SetPropertyValue<decimal>("QCMY", ref fQCMY, value); }
        }
        decimal fQCSY;
        public decimal QCSY
        {
            get { return fQCSY; }
            set { SetPropertyValue<decimal>("QCSY", ref fQCSY, value); }
        }
        long fJHSL;
        public long JHSL
        {
            get { return fJHSL; }
            set { SetPropertyValue<long>("JHSL", ref fJHSL, value); }
        }
        decimal fJHMY;
        public decimal JHMY
        {
            get { return fJHMY; }
            set { SetPropertyValue<decimal>("JHMY", ref fJHMY, value); }
        }
        decimal fJHSY;
        public decimal JHSY
        {
            get { return fJHSY; }
            set { SetPropertyValue<decimal>("JHSY", ref fJHSY, value); }
        }
        long fXSSL;
        public long XSSL
        {
            get { return fXSSL; }
            set { SetPropertyValue<long>("XSSL", ref fXSSL, value); }
        }
        decimal fXSMY;
        public decimal XSMY
        {
            get { return fXSMY; }
            set { SetPropertyValue<decimal>("XSMY", ref fXSMY, value); }
        }
        decimal fXSSY;
        public decimal XSSY
        {
            get { return fXSSY; }
            set { SetPropertyValue<decimal>("XSSY", ref fXSSY, value); }
        }
        long fXTSL;
        public long XTSL
        {
            get { return fXTSL; }
            set { SetPropertyValue<long>("XTSL", ref fXTSL, value); }
        }
        decimal fXTMY;
        public decimal XTMY
        {
            get { return fXTMY; }
            set { SetPropertyValue<decimal>("XTMY", ref fXTMY, value); }
        }
        decimal fXTSY;
        public decimal XTSY
        {
            get { return fXTSY; }
            set { SetPropertyValue<decimal>("XTSY", ref fXTSY, value); }
        }
        long fJTSL;
        public long JTSL
        {
            get { return fJTSL; }
            set { SetPropertyValue<long>("JTSL", ref fJTSL, value); }
        }
        decimal fJTMY;
        public decimal JTMY
        {
            get { return fJTMY; }
            set { SetPropertyValue<decimal>("JTMY", ref fJTMY, value); }
        }
        decimal fJTSY;
        public decimal JTSY
        {
            get { return fJTSY; }
            set { SetPropertyValue<decimal>("JTSY", ref fJTSY, value); }
        }
        long fQMKC;
        public long QMKC
        {
            get { return fQMKC; }
            set { SetPropertyValue<long>("QMKC", ref fQMKC, value); }
        }
        decimal fQMMY;
        public decimal QMMY
        {
            get { return fQMMY; }
            set { SetPropertyValue<decimal>("QMMY", ref fQMMY, value); }
        }
        decimal fQMSY;
        public decimal QMSY
        {
            get { return fQMSY; }
            set { SetPropertyValue<decimal>("QMSY", ref fQMSY, value); }
        }
        long fJHCS;
        public long JHCS
        {
            get { return fJHCS; }
            set { SetPropertyValue<long>("JHCS", ref fJHCS, value); }
        }
        long fTHCS;
        public long THCS
        {
            get { return fTHCS; }
            set { SetPropertyValue<long>("THCS", ref fTHCS, value); }
        }
        string fZT;
        [Size(4)]
        public string ZT
        {
            get { return fZT; }
            set { SetPropertyValue<string>("ZT", ref fZT, value); }
        }
        string fYZT;
        [Size(4)]
        public string YZT
        {
            get { return fYZT; }
            set { SetPropertyValue<string>("YZT", ref fYZT, value); }
        }
        string fZTBZ;
        [Size(1)]
        public string ZTBZ
        {
            get { return fZTBZ; }
            set { SetPropertyValue<string>("ZTBZ", ref fZTBZ, value); }
        }
        string fBZ;
        public string BZ
        {
            get { return fBZ; }
            set { SetPropertyValue<string>("BZ", ref fBZ, value); }
        }
        long fYJSL;
        public long YJSL
        {
            get { return fYJSL; }
            set { SetPropertyValue<long>("YJSL", ref fYJSL, value); }
        }
        decimal fYJSY;
        public decimal YJSY
        {
            get { return fYJSY; }
            set { SetPropertyValue<decimal>("YJSY", ref fYJSY, value); }
        }
        decimal fYJMY;
        public decimal YJMY
        {
            get { return fYJMY; }
            set { SetPropertyValue<decimal>("YJMY", ref fYJMY, value); }
        }
        long fZZSL;
        public long ZZSL
        {
            get { return fZZSL; }
            set { SetPropertyValue<long>("ZZSL", ref fZZSL, value); }
        }
        decimal fZZSY;
        public decimal ZZSY
        {
            get { return fZZSY; }
            set { SetPropertyValue<decimal>("ZZSY", ref fZZSY, value); }
        }
        decimal fZZMY;
        public decimal ZZMY
        {
            get { return fZZMY; }
            set { SetPropertyValue<decimal>("ZZMY", ref fZZMY, value); }
        }
        long fYTSL;
        public long YTSL
        {
            get { return fYTSL; }
            set { SetPropertyValue<long>("YTSL", ref fYTSL, value); }
        }
        decimal fYTSY;
        public decimal YTSY
        {
            get { return fYTSY; }
            set { SetPropertyValue<decimal>("YTSY", ref fYTSY, value); }
        }
        decimal fYTMY;
        public decimal YTMY
        {
            get { return fYTMY; }
            set { SetPropertyValue<decimal>("YTMY", ref fYTMY, value); }
        }
        long fSXSL;
        public long SXSL
        {
            get { return fSXSL; }
            set { SetPropertyValue<long>("SXSL", ref fSXSL, value); }
        }
        decimal fSXMY;
        public decimal SXMY
        {
            get { return fSXMY; }
            set { SetPropertyValue<decimal>("SXMY", ref fSXMY, value); }
        }
        decimal fSXSY;
        public decimal SXSY
        {
            get { return fSXSY; }
            set { SetPropertyValue<decimal>("SXSY", ref fSXSY, value); }
        }
        public VIEW_JC_C_ZTBMGYSSPTZ(Session session) : base(session) { }
        public VIEW_JC_C_ZTBMGYSSPTZ() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class VIEW_JT_X_XTD_CCD_FLTJ : XPLiteObject
    {
        string fCCDID;
        [Key]
        [Size(16)]
        public string CCDID
        {
            get { return fCCDID; }
            set { SetPropertyValue<string>("CCDID", ref fCCDID, value); }
        }
        string fXSBMMC;
        [Size(100)]
        public string XSBMMC
        {
            get { return fXSBMMC; }
            set { SetPropertyValue<string>("XSBMMC", ref fXSBMMC, value); }
        }
        string fKHMC;
        [Size(100)]
        public string KHMC
        {
            get { return fKHMC; }
            set { SetPropertyValue<string>("KHMC", ref fKHMC, value); }
        }
        long fCCSL;
        public long CCSL
        {
            get { return fCCSL; }
            set { SetPropertyValue<long>("CCSL", ref fCCSL, value); }
        }
        decimal fCCSY;
        public decimal CCSY
        {
            get { return fCCSY; }
            set { SetPropertyValue<decimal>("CCSY", ref fCCSY, value); }
        }
        decimal fCCMY;
        public decimal CCMY
        {
            get { return fCCMY; }
            set { SetPropertyValue<decimal>("CCMY", ref fCCMY, value); }
        }
        DateTime fZDRQ;
        public DateTime ZDRQ
        {
            get { return fZDRQ; }
            set { SetPropertyValue<DateTime>("ZDRQ", ref fZDRQ, value); }
        }
        long fSL;
        public long SL
        {
            get { return fSL; }
            set { SetPropertyValue<long>("SL", ref fSL, value); }
        }
        string fFXFLMC;
        [Size(80)]
        public string FXFLMC
        {
            get { return fFXFLMC; }
            set { SetPropertyValue<string>("FXFLMC", ref fFXFLMC, value); }
        }
        public VIEW_JT_X_XTD_CCD_FLTJ(Session session) : base(session) { }
        public VIEW_JT_X_XTD_CCD_FLTJ() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class VIEW_JT_G_JTD_CCD_FLTJ : XPLiteObject
    {
        string fCCDID;
        [Key]
        [Size(16)]
        public string CCDID
        {
            get { return fCCDID; }
            set { SetPropertyValue<string>("CCDID", ref fCCDID, value); }
        }
        string fJTBMMC;
        [Size(100)]
        public string JTBMMC
        {
            get { return fJTBMMC; }
            set { SetPropertyValue<string>("JTBMMC", ref fJTBMMC, value); }
        }
        string fGYSMC;
        [Size(100)]
        public string GYSMC
        {
            get { return fGYSMC; }
            set { SetPropertyValue<string>("GYSMC", ref fGYSMC, value); }
        }
        long fCCSL;
        public long CCSL
        {
            get { return fCCSL; }
            set { SetPropertyValue<long>("CCSL", ref fCCSL, value); }
        }
        decimal fCCSY;
        public decimal CCSY
        {
            get { return fCCSY; }
            set { SetPropertyValue<decimal>("CCSY", ref fCCSY, value); }
        }
        decimal fCCMY;
        public decimal CCMY
        {
            get { return fCCMY; }
            set { SetPropertyValue<decimal>("CCMY", ref fCCMY, value); }
        }
        DateTime fZDRQ;
        public DateTime ZDRQ
        {
            get { return fZDRQ; }
            set { SetPropertyValue<DateTime>("ZDRQ", ref fZDRQ, value); }
        }
        long fSL;
        public long SL
        {
            get { return fSL; }
            set { SetPropertyValue<long>("SL", ref fSL, value); }
        }
        string fFXFLMC;
        [Size(80)]
        public string FXFLMC
        {
            get { return fFXFLMC; }
            set { SetPropertyValue<string>("FXFLMC", ref fFXFLMC, value); }
        }
        public VIEW_JT_G_JTD_CCD_FLTJ(Session session) : base(session) { }
        public VIEW_JT_G_JTD_CCD_FLTJ() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class VIEW_JT_X_XSD_CCD_FLTJ : XPLiteObject
    {
        string fCCDID;
        [Key]
        [Size(16)]
        public string CCDID
        {
            get { return fCCDID; }
            set { SetPropertyValue<string>("CCDID", ref fCCDID, value); }
        }
        string fXSBMMC;
        [Size(100)]
        public string XSBMMC
        {
            get { return fXSBMMC; }
            set { SetPropertyValue<string>("XSBMMC", ref fXSBMMC, value); }
        }
        string fKHMC;
        [Size(100)]
        public string KHMC
        {
            get { return fKHMC; }
            set { SetPropertyValue<string>("KHMC", ref fKHMC, value); }
        }
        long fCCSL;
        public long CCSL
        {
            get { return fCCSL; }
            set { SetPropertyValue<long>("CCSL", ref fCCSL, value); }
        }
        decimal fCCSY;
        public decimal CCSY
        {
            get { return fCCSY; }
            set { SetPropertyValue<decimal>("CCSY", ref fCCSY, value); }
        }
        decimal fCCMY;
        public decimal CCMY
        {
            get { return fCCMY; }
            set { SetPropertyValue<decimal>("CCMY", ref fCCMY, value); }
        }
        DateTime fZDRQ;
        public DateTime ZDRQ
        {
            get { return fZDRQ; }
            set { SetPropertyValue<DateTime>("ZDRQ", ref fZDRQ, value); }
        }
        long fSL;
        public long SL
        {
            get { return fSL; }
            set { SetPropertyValue<long>("SL", ref fSL, value); }
        }
        string fFXFLMC;
        [Size(80)]
        public string FXFLMC
        {
            get { return fFXFLMC; }
            set { SetPropertyValue<string>("FXFLMC", ref fFXFLMC, value); }
        }
        public VIEW_JT_X_XSD_CCD_FLTJ(Session session) : base(session) { }
        public VIEW_JT_X_XSD_CCD_FLTJ() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class VIEW_JT_G_CGSH_CCD_FLTJ : XPLiteObject
    {
        string fCCDID;
        [Key]
        [Size(16)]
        public string CCDID
        {
            get { return fCCDID; }
            set { SetPropertyValue<string>("CCDID", ref fCCDID, value); }
        }
        string fCGBMMC;
        [Size(100)]
        public string CGBMMC
        {
            get { return fCGBMMC; }
            set { SetPropertyValue<string>("CGBMMC", ref fCGBMMC, value); }
        }
        string fGYSMC;
        [Size(100)]
        public string GYSMC
        {
            get { return fGYSMC; }
            set { SetPropertyValue<string>("GYSMC", ref fGYSMC, value); }
        }
        long fCCSL;
        public long CCSL
        {
            get { return fCCSL; }
            set { SetPropertyValue<long>("CCSL", ref fCCSL, value); }
        }
        decimal fCCSY;
        public decimal CCSY
        {
            get { return fCCSY; }
            set { SetPropertyValue<decimal>("CCSY", ref fCCSY, value); }
        }
        decimal fCCMY;
        public decimal CCMY
        {
            get { return fCCMY; }
            set { SetPropertyValue<decimal>("CCMY", ref fCCMY, value); }
        }
        DateTime fZDRQ;
        public DateTime ZDRQ
        {
            get { return fZDRQ; }
            set { SetPropertyValue<DateTime>("ZDRQ", ref fZDRQ, value); }
        }
        long fSL;
        public long SL
        {
            get { return fSL; }
            set { SetPropertyValue<long>("SL", ref fSL, value); }
        }
        string fFXFLMC;
        [Size(80)]
        public string FXFLMC
        {
            get { return fFXFLMC; }
            set { SetPropertyValue<string>("FXFLMC", ref fFXFLMC, value); }
        }
        public VIEW_JT_G_CGSH_CCD_FLTJ(Session session) : base(session) { }
        public VIEW_JT_G_CGSH_CCD_FLTJ() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class VIEW_JT_C_SYD_CCD_FLTJ : XPLiteObject
    {
        string fCCDID;
        [Key]
        [Size(16)]
        public string CCDID
        {
            get { return fCCDID; }
            set { SetPropertyValue<string>("CCDID", ref fCCDID, value); }
        }
        string fWLBMMC;
        [Size(100)]
        public string WLBMMC
        {
            get { return fWLBMMC; }
            set { SetPropertyValue<string>("WLBMMC", ref fWLBMMC, value); }
        }
        string fSYBMMC;
        [Size(100)]
        public string SYBMMC
        {
            get { return fSYBMMC; }
            set { SetPropertyValue<string>("SYBMMC", ref fSYBMMC, value); }
        }
        long fCCSL;
        public long CCSL
        {
            get { return fCCSL; }
            set { SetPropertyValue<long>("CCSL", ref fCCSL, value); }
        }
        decimal fCCSY;
        public decimal CCSY
        {
            get { return fCCSY; }
            set { SetPropertyValue<decimal>("CCSY", ref fCCSY, value); }
        }
        decimal fCCMY;
        public decimal CCMY
        {
            get { return fCCMY; }
            set { SetPropertyValue<decimal>("CCMY", ref fCCMY, value); }
        }
        DateTime fZDRQ;
        public DateTime ZDRQ
        {
            get { return fZDRQ; }
            set { SetPropertyValue<DateTime>("ZDRQ", ref fZDRQ, value); }
        }     
        string fFXFLMC;
        [Size(80)]
        public string FXFLMC
        {
            get { return fFXFLMC; }
            set { SetPropertyValue<string>("FXFLMC", ref fFXFLMC, value); }
        }
        public VIEW_JT_C_SYD_CCD_FLTJ(Session session) : base(session) { }
        public VIEW_JT_C_SYD_CCD_FLTJ() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class VIEW_JT_C_DBD_CCD_FLTJ : XPLiteObject
    {
        string fCCDID;
        [Key]
        [Size(16)]
        public string CCDID
        {
            get { return fCCDID; }
            set { SetPropertyValue<string>("CCDID", ref fCCDID, value); }
        }
        string fDCBMMC;
        [Size(100)]
        public string DCBMMC
        {
            get { return fDCBMMC; }
            set { SetPropertyValue<string>("DCBMMC", ref fDCBMMC, value); }
        }
        string fDRBMMC;
        [Size(100)]
        public string DRBMMC
        {
            get { return fDRBMMC; }
            set { SetPropertyValue<string>("DRBMMC", ref fDRBMMC, value); }
        }
        long fCCSL;
        public long CCSL
        {
            get { return fCCSL; }
            set { SetPropertyValue<long>("CCSL", ref fCCSL, value); }
        }
        decimal fCCSY;
        public decimal CCSY
        {
            get { return fCCSY; }
            set { SetPropertyValue<decimal>("CCSY", ref fCCSY, value); }
        }
        decimal fCCMY;
        public decimal CCMY
        {
            get { return fCCMY; }
            set { SetPropertyValue<decimal>("CCMY", ref fCCMY, value); }
        }
        DateTime fZDRQ;
        public DateTime ZDRQ
        {
            get { return fZDRQ; }
            set { SetPropertyValue<DateTime>("ZDRQ", ref fZDRQ, value); }
        }
        long fSL;
        public long SL
        {
            get { return fSL; }
            set { SetPropertyValue<long>("SL", ref fSL, value); }
        }
        string fFXFLMC;
        [Size(80)]
        public string FXFLMC
        {
            get { return fFXFLMC; }
            set { SetPropertyValue<string>("FXFLMC", ref fFXFLMC, value); }
        }
        public VIEW_JT_C_DBD_CCD_FLTJ(Session session) : base(session) { }
        public VIEW_JT_C_DBD_CCD_FLTJ() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class JT_J_KHLX : XPLiteObject
    {
        string fKHLXID;
        [Key]
        [Size(16)]
        public string KHLXID
        {
            get { return fKHLXID; }
            set { SetPropertyValue<string>("KHLXID", ref fKHLXID, value); }
        }
        string fKHLXBH;
        [Size(10)]
        public string KHLXBH
        {
            get { return fKHLXBH; }
            set { SetPropertyValue<string>("KHLXBH", ref fKHLXBH, value); }
        }
        string fKHLXMC;
        [Size(80)]
        public string KHLXMC
        {
            get { return fKHLXMC; }
            set { SetPropertyValue<string>("KHLXMC", ref fKHLXMC, value); }
        }
        string fKHLXJC;
        [Size(20)]
        public string KHLXJC
        {
            get { return fKHLXJC; }
            set { SetPropertyValue<string>("KHLXJC", ref fKHLXJC, value); }
        }
        string fZJM;
        [Size(10)]
        public string ZJM
        {
            get { return fZJM; }
            set { SetPropertyValue<string>("ZJM", ref fZJM, value); }
        }
        string fZT;
        [Size(4)]
        public string ZT
        {
            get { return fZT; }
            set { SetPropertyValue<string>("ZT", ref fZT, value); }
        }
        string fCJR;
        [Size(10)]
        public string CJR
        {
            get { return fCJR; }
            set { SetPropertyValue<string>("CJR", ref fCJR, value); }
        }
        string fTYR;
        [Size(10)]
        public string TYR
        {
            get { return fTYR; }
            set { SetPropertyValue<string>("TYR", ref fTYR, value); }
        }
        DateTime fCZRQ;
        public DateTime CZRQ
        {
            get { return fCZRQ; }
            set { SetPropertyValue<DateTime>("CZRQ", ref fCZRQ, value); }
        }
        public JT_J_KHLX(Session session) : base(session) { }
        public JT_J_KHLX() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class BASE_DEPARTTYPE : XPLiteObject
    {
        string fDEPARTTYPEID;
        [Key]
        [Size(16)]
        public string DEPARTTYPEID
        {
            get { return fDEPARTTYPEID; }
            set { SetPropertyValue<string>("DEPARTTYPEID", ref fDEPARTTYPEID, value); }
        }
        string fDEPARTTYPENO;
        [Size(10)]
        public string DEPARTTYPENO
        {
            get { return fDEPARTTYPENO; }
            set { SetPropertyValue<string>("DEPARTTYPENO", ref fDEPARTTYPENO, value); }
        }
        string fDEPARTTYPENAME;
        [Size(80)]
        public string DEPARTTYPENAME
        {
            get { return fDEPARTTYPENAME; }
            set { SetPropertyValue<string>("DEPARTTYPENAME", ref fDEPARTTYPENAME, value); }
        }
        string fDEPARTTYPESIMPLE;
        [Size(20)]
        public string DEPARTTYPESIMPLE
        {
            get { return fDEPARTTYPESIMPLE; }
            set { SetPropertyValue<string>("DEPARTTYPESIMPLE", ref fDEPARTTYPESIMPLE, value); }
        }
        string fFASTCODE;
        [Size(10)]
        public string FASTCODE
        {
            get { return fFASTCODE; }
            set { SetPropertyValue<string>("FASTCODE", ref fFASTCODE, value); }
        }
        string fZT;
        [Size(4)]
        public string ZT
        {
            get { return fZT; }
            set { SetPropertyValue<string>("ZT", ref fZT, value); }
        }
        public BASE_DEPARTTYPE(Session session) : base(session) { }
        public BASE_DEPARTTYPE() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class JT_J_CBSLX : XPLiteObject
    {
        string fZJM;
        [Size(10)]
        public string ZJM
        {
            get { return fZJM; }
            set { SetPropertyValue<string>("ZJM", ref fZJM, value); }
        }
        string fZT;
        [Size(4)]
        public string ZT
        {
            get { return fZT; }
            set { SetPropertyValue<string>("ZT", ref fZT, value); }
        }
        string fCJR;
        [Size(10)]
        public string CJR
        {
            get { return fCJR; }
            set { SetPropertyValue<string>("CJR", ref fCJR, value); }
        }
        string fTYR;
        [Size(10)]
        public string TYR
        {
            get { return fTYR; }
            set { SetPropertyValue<string>("TYR", ref fTYR, value); }
        }
        DateTime fCZRQ;
        public DateTime CZRQ
        {
            get { return fCZRQ; }
            set { SetPropertyValue<DateTime>("CZRQ", ref fCZRQ, value); }
        }
        string fCBSLXID;
        [Key]
        [Size(16)]
        public string CBSLXID
        {
            get { return fCBSLXID; }
            set { SetPropertyValue<string>("CBSLXID", ref fCBSLXID, value); }
        }
        string fLXBH;
        [Size(2)]
        public string LXBH
        {
            get { return fLXBH; }
            set { SetPropertyValue<string>("LXBH", ref fLXBH, value); }
        }
        string fCBSLX;
        [Size(80)]
        public string CBSLX
        {
            get { return fCBSLX; }
            set { SetPropertyValue<string>("CBSLX", ref fCBSLX, value); }
        }
        string fJC;
        [Size(20)]
        public string JC
        {
            get { return fJC; }
            set { SetPropertyValue<string>("JC", ref fJC, value); }
        }
        public JT_J_CBSLX(Session session) : base(session) { }
        public JT_J_CBSLX() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class JT_J_YSCLX : XPLiteObject
    {
        string fYSCLXID;
        [Key]
        [Size(16)]
        public string YSCLXID
        {
            get { return fYSCLXID; }
            set { SetPropertyValue<string>("YSCLXID", ref fYSCLXID, value); }
        }
        string fLXBH;
        [Size(2)]
        public string LXBH
        {
            get { return fLXBH; }
            set { SetPropertyValue<string>("LXBH", ref fLXBH, value); }
        }
        string fYSCDWLX;
        [Size(80)]
        public string YSCDWLX
        {
            get { return fYSCDWLX; }
            set { SetPropertyValue<string>("YSCDWLX", ref fYSCDWLX, value); }
        }
        string fJC;
        [Size(20)]
        public string JC
        {
            get { return fJC; }
            set { SetPropertyValue<string>("JC", ref fJC, value); }
        }
        string fZJM;
        [Size(10)]
        public string ZJM
        {
            get { return fZJM; }
            set { SetPropertyValue<string>("ZJM", ref fZJM, value); }
        }
        string fZT;
        [Size(4)]
        public string ZT
        {
            get { return fZT; }
            set { SetPropertyValue<string>("ZT", ref fZT, value); }
        }
        string fCJR;
        [Size(10)]
        public string CJR
        {
            get { return fCJR; }
            set { SetPropertyValue<string>("CJR", ref fCJR, value); }
        }
        string fTYR;
        [Size(10)]
        public string TYR
        {
            get { return fTYR; }
            set { SetPropertyValue<string>("TYR", ref fTYR, value); }
        }
        DateTime fCZRQ;
        public DateTime CZRQ
        {
            get { return fCZRQ; }
            set { SetPropertyValue<DateTime>("CZRQ", ref fCZRQ, value); }
        }
        public JT_J_YSCLX(Session session) : base(session) { }
        public JT_J_YSCLX() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class JT_J_GYSLX : XPLiteObject
    {
        string fGYSLXID;
        [Key]
        [Size(16)]
        public string GYSLXID
        {
            get { return fGYSLXID; }
            set { SetPropertyValue<string>("GYSLXID", ref fGYSLXID, value); }
        }
        string fLXBH;
        [Size(2)]
        public string LXBH
        {
            get { return fLXBH; }
            set { SetPropertyValue<string>("LXBH", ref fLXBH, value); }
        }
        string fGYSLX;
        [Size(80)]
        public string GYSLX
        {
            get { return fGYSLX; }
            set { SetPropertyValue<string>("GYSLX", ref fGYSLX, value); }
        }
        string fJC;
        [Size(20)]
        public string JC
        {
            get { return fJC; }
            set { SetPropertyValue<string>("JC", ref fJC, value); }
        }
        string fZJM;
        [Size(10)]
        public string ZJM
        {
            get { return fZJM; }
            set { SetPropertyValue<string>("ZJM", ref fZJM, value); }
        }
        string fZT;
        [Size(4)]
        public string ZT
        {
            get { return fZT; }
            set { SetPropertyValue<string>("ZT", ref fZT, value); }
        }
        string fCJR;
        [Size(10)]
        public string CJR
        {
            get { return fCJR; }
            set { SetPropertyValue<string>("CJR", ref fCJR, value); }
        }
        string fTYR;
        [Size(10)]
        public string TYR
        {
            get { return fTYR; }
            set { SetPropertyValue<string>("TYR", ref fTYR, value); }
        }
        DateTime fCZRQ;
        public DateTime CZRQ
        {
            get { return fCZRQ; }
            set { SetPropertyValue<DateTime>("CZRQ", ref fCZRQ, value); }
        }
        public JT_J_GYSLX(Session session) : base(session) { }
        public JT_J_GYSLX() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class JT_J_YSDWLX : XPLiteObject
    {
        string fYSDWLXID;
        [Key]
        [Size(16)]
        public string YSDWLXID
        {
            get { return fYSDWLXID; }
            set { SetPropertyValue<string>("YSDWLXID", ref fYSDWLXID, value); }
        }
        string fLXBH;
        [Size(2)]
        public string LXBH
        {
            get { return fLXBH; }
            set { SetPropertyValue<string>("LXBH", ref fLXBH, value); }
        }
        string fYSDWLX;
        [Size(80)]
        public string YSDWLX
        {
            get { return fYSDWLX; }
            set { SetPropertyValue<string>("YSDWLX", ref fYSDWLX, value); }
        }
        string fJC;
        [Size(20)]
        public string JC
        {
            get { return fJC; }
            set { SetPropertyValue<string>("JC", ref fJC, value); }
        }
        string fZJM;
        [Size(10)]
        public string ZJM
        {
            get { return fZJM; }
            set { SetPropertyValue<string>("ZJM", ref fZJM, value); }
        }
        string fZT;
        [Size(4)]
        public string ZT
        {
            get { return fZT; }
            set { SetPropertyValue<string>("ZT", ref fZT, value); }
        }
        string fCJR;
        [Size(10)]
        public string CJR
        {
            get { return fCJR; }
            set { SetPropertyValue<string>("CJR", ref fCJR, value); }
        }
        string fTYR;
        [Size(10)]
        public string TYR
        {
            get { return fTYR; }
            set { SetPropertyValue<string>("TYR", ref fTYR, value); }
        }
        DateTime fCZRQ;
        public DateTime CZRQ
        {
            get { return fCZRQ; }
            set { SetPropertyValue<DateTime>("CZRQ", ref fCZRQ, value); }
        }
        public JT_J_YSDWLX(Session session) : base(session) { }
        public JT_J_YSDWLX() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class JT_J_DWSX : XPLiteObject
    {
        string fDWSXID;
        [Key]
        [Size(16)]
        public string DWSXID
        {
            get { return fDWSXID; }
            set { SetPropertyValue<string>("DWSXID", ref fDWSXID, value); }
        }
        string fDWSXBH;
        [Size(2)]
        public string DWSXBH
        {
            get { return fDWSXBH; }
            set { SetPropertyValue<string>("DWSXBH", ref fDWSXBH, value); }
        }
        string fDWSX;
        [Size(80)]
        public string DWSX
        {
            get { return fDWSX; }
            set { SetPropertyValue<string>("DWSX", ref fDWSX, value); }
        }
        string fJC;
        [Size(20)]
        public string JC
        {
            get { return fJC; }
            set { SetPropertyValue<string>("JC", ref fJC, value); }
        }
        string fZJM;
        [Size(10)]
        public string ZJM
        {
            get { return fZJM; }
            set { SetPropertyValue<string>("ZJM", ref fZJM, value); }
        }
        string fZT;
        [Size(4)]
        public string ZT
        {
            get { return fZT; }
            set { SetPropertyValue<string>("ZT", ref fZT, value); }
        }
        string fCJR;
        [Size(10)]
        public string CJR
        {
            get { return fCJR; }
            set { SetPropertyValue<string>("CJR", ref fCJR, value); }
        }
        string fTYR;
        [Size(10)]
        public string TYR
        {
            get { return fTYR; }
            set { SetPropertyValue<string>("TYR", ref fTYR, value); }
        }
        DateTime fCZRQ;
        public DateTime CZRQ
        {
            get { return fCZRQ; }
            set { SetPropertyValue<DateTime>("CZRQ", ref fCZRQ, value); }
        }
        public JT_J_DWSX(Session session) : base(session) { }
        public JT_J_DWSX() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class JT_J_KFLX : XPLiteObject
    {
        string fKFLXID;
        [Key]
        [Size(16)]
        public string KFLXID
        {
            get { return fKFLXID; }
            set { SetPropertyValue<string>("KFLXID", ref fKFLXID, value); }
        }
        string fLXBH;
        [Size(2)]
        public string LXBH
        {
            get { return fLXBH; }
            set { SetPropertyValue<string>("LXBH", ref fLXBH, value); }
        }
        string fKFLX;
        [Size(80)]
        public string KFLX
        {
            get { return fKFLX; }
            set { SetPropertyValue<string>("KFLX", ref fKFLX, value); }
        }
        string fJC;
        [Size(20)]
        public string JC
        {
            get { return fJC; }
            set { SetPropertyValue<string>("JC", ref fJC, value); }
        }
        string fZJM;
        [Size(10)]
        public string ZJM
        {
            get { return fZJM; }
            set { SetPropertyValue<string>("ZJM", ref fZJM, value); }
        }
        string fZT;
        [Size(4)]
        public string ZT
        {
            get { return fZT; }
            set { SetPropertyValue<string>("ZT", ref fZT, value); }
        }
        string fCJR;
        [Size(10)]
        public string CJR
        {
            get { return fCJR; }
            set { SetPropertyValue<string>("CJR", ref fCJR, value); }
        }
        string fTYR;
        [Size(10)]
        public string TYR
        {
            get { return fTYR; }
            set { SetPropertyValue<string>("TYR", ref fTYR, value); }
        }
        DateTime fCZRQ;
        public DateTime CZRQ
        {
            get { return fCZRQ; }
            set { SetPropertyValue<DateTime>("CZRQ", ref fCZRQ, value); }
        }
        public JT_J_KFLX(Session session) : base(session) { }
        public JT_J_KFLX() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class VIEW_JT_C_CGJSD : XPLiteObject
    {
        string fCGJSDID;
        [Key]
        [Size(16)]
        public string CGJSDID
        {
            get { return fCGJSDID; }
            set { SetPropertyValue<string>("CGJSDID", ref fCGJSDID, value); }
        }


        string fCGFPH;
        [Size(22)]
        public string CGFPH
        {
            get { return fCGFPH; }
            set { SetPropertyValue<string>("CGFPH", ref fCGFPH, value); }
        }


        string fCGJSDH;
        [Size(22)]
        public string CGJSDH
        {
            get { return fCGJSDH; }
            set { SetPropertyValue<string>("CGJSDH", ref fCGJSDH, value); }
        }

        string fCWBMID;
        [Size(16)]
        public string CWBMID
        {
            get { return fCWBMID; }
            set { SetPropertyValue<string>("CWBMID", ref fCWBMID, value); }
        }

        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }


        string fGYSID;
        [Size(16)]
        public string GYSID
        {
            get { return fGYSID; }
            set { SetPropertyValue<string>("GYSID", ref fGYSID, value); }
        }

        decimal fJSHJ;
        public decimal JSHJ
        {
            get { return fJSHJ; }
            set { SetPropertyValue<decimal>("JSHJ", ref fJSHJ, value); }
        }

        decimal fFDE;
        public decimal FDE
        {
            get { return fFDE; }
            set { SetPropertyValue<decimal>("FDE", ref fFDE, value); }
        }

        decimal fPJZK;
        public decimal PJZK
        {
            get { return fPJZK; }
            set { SetPropertyValue<decimal>("PJZK", ref fPJZK, value); }
        }

        decimal fPJDJ;
        public decimal PJDJ
        {
            get { return fPJDJ; }
            set { SetPropertyValue<decimal>("PJDJ", ref fPJDJ, value); }
        }

        string fJSLX;
        [Size(10)]
        public string JSLX
        {
            get { return fJSLX; }
            set { SetPropertyValue<string>("JSLX", ref fJSLX, value); }
        }

        string fJSR;
        [Size(10)]
        public string JSR
        {
            get { return fJSR; }
            set { SetPropertyValue<string>("JSR", ref fJSR, value); }
        }

        string fJSFSID;
        [Size(16)]
        public string JSFSID
        {
            get { return fJSFSID; }
            set { SetPropertyValue<string>("JSFSID", ref fJSFSID, value); }
        }

        DateTime fZDRQ;
        public DateTime ZDRQ
        {
            get { return fZDRQ; }
            set { SetPropertyValue<DateTime>("ZDRQ", ref fZDRQ, value); }
        }

        string fCZYID;
        [Size(16)]
        public string CZYID
        {
            get { return fCZYID; }
            set { SetPropertyValue<string>("CZYID", ref fCZYID, value); }
        }

        long fPZS;
        public long PZS
        {
            get { return fPZS; }
            set { SetPropertyValue<long>("SL", ref fPZS, value); }
        }

        long fSHSL;
        public long SHSL
        {
            get { return fSHSL; }
            set { SetPropertyValue<long>("SHSL", ref fSHSL, value); }
        }

        decimal fSHSY;
        public decimal SHSY
        {
            get { return fSHSY; }
            set { SetPropertyValue<decimal>("SHSY", ref fSHSY, value); }
        }

        decimal fSHMY;
        public decimal SHMY
        {
            get { return fSHMY; }
            set { SetPropertyValue<decimal>("SHMY", ref fSHMY, value); }
        }



        long fSL;
        public long SL
        {
            get { return fSL; }
            set { SetPropertyValue<long>("SL", ref fSL, value); }
        }

        decimal fSE;
        public decimal SE
        {
            get { return fSE; }
            set { SetPropertyValue<decimal>("SE", ref fSE, value); }
        }

        decimal fZKE;
        public decimal ZKE
        {
            get { return fZKE; }
            set { SetPropertyValue<decimal>("ZKE", ref fZKE, value); }
        }

        decimal fWSJE;
        public decimal WSJE
        {
            get { return fWSJE; }
            set { SetPropertyValue<decimal>("WSJE", ref fWSJE, value); }
        }

        DateTime fSHHZRQ;
        public DateTime SHHZRQ
        {
            get { return fSHHZRQ; }
            set { SetPropertyValue<DateTime>("SHHZRQ", ref fSHHZRQ, value); }
        }

        string fSHHZDID;
        [Size(16)]
        public string SHHZDID
        {
            get { return fSHHZDID; }
            set { SetPropertyValue<string>("SHHZDID", ref fSHHZDID, value); }
        }

        string fCGFPID;
        [Size(16)]
        public string CGFPID
        {
            get { return fCGFPID; }
            set { SetPropertyValue<string>("CGFPID", ref fCGFPID, value); }
        }

        long fDJSL;
        public long DJSL
        {
            get { return fDJSL; }
            set { SetPropertyValue<long>("DJSL", ref fDJSL, value); }
        }

        decimal fDJJE;
        public decimal DJJE
        {
            get { return fDJJE; }
            set { SetPropertyValue<decimal>("DJJE", ref fDJJE, value); }
        }

        decimal fDJMY;
        public decimal DJMY
        {
            get { return fDJMY; }
            set { SetPropertyValue<decimal>("DJMY", ref fDJMY, value); }
        }

        long fYJSL;
        public long YJSL
        {
            get { return fYJSL; }
            set { SetPropertyValue<long>("YJSL", ref fYJSL, value); }
        }

        decimal fYJJE;
        public decimal YJJE
        {
            get { return fYJJE; }
            set { SetPropertyValue<decimal>("YJJE", ref fYJJE, value); }
        }

        decimal fYJMY;
        public decimal YJMY
        {
            get { return fYJMY; }
            set { SetPropertyValue<decimal>("YJMY", ref fYJMY, value); }
        }

        DateTime fQSJSRQ;
        public DateTime QSJSRQ
        {
            get { return fQSJSRQ; }
            set { SetPropertyValue<DateTime>("QSJSRQ", ref fQSJSRQ, value); }
        }

        DateTime fZHJSRQ;
        public DateTime ZHJSRQ
        {
            get { return fZHJSRQ; }
            set { SetPropertyValue<DateTime>("ZHJSRQ", ref fZHJSRQ, value); }
        }


        DateTime fCZRQ;
        public DateTime CZRQ
        {
            get { return fCZRQ; }
            set { SetPropertyValue<DateTime>("CZRQ", ref fCZRQ, value); }
        }


        string fZT;
        [Size(40)]
        public string ZT
        {
            get { return fZT; }
            set { SetPropertyValue<string>("ZT", ref fZT, value); }
        }


        string fYZT;
        [Size(40)]
        public string YZT
        {
            get { return fYZT; }
            set { SetPropertyValue<string>("YZT", ref fYZT, value); }
        }

        string fBZ;
        [Size(100)]
        public string BZ
        {
            get { return fBZ; }
            set { SetPropertyValue<string>("BZ", ref fBZ, value); }
        }


        DateTime fFKRQ;
        public DateTime FKRQ
        {
            get { return fFKRQ; }
            set { SetPropertyValue<DateTime>("FKRQ", ref fFKRQ, value); }
        }


        string fFKPZID;
        [Size(16)]
        public string FKPZID
        {
            get { return fFKPZID; }
            set { SetPropertyValue<string>("FKPZID", ref fFKPZID, value); }
        }



        string fSHPZID;
        [Size(16)]
        public string SHPZID
        {
            get { return fSHPZID; }
            set { SetPropertyValue<string>("SHPZID", ref fSHPZID, value); }
        }

        string fDWMC;
        [Size(16)]
        public string DWMC
        {
            get { return fDWMC; }
            set { SetPropertyValue<string>("DWMC", ref fDWMC, value); }
        }

        string fJSFSMC;
        [Size(16)]
        public string JSFSMC
        {
            get { return fJSFSMC; }
            set { SetPropertyValue<string>("JSFSMC", ref fJSFSMC, value); }
        }

        string fCZRMC;
        [Size(16)]
        public string CZRMC
        {
            get { return fCZRMC; }
            set { SetPropertyValue<string>("CZRMC", ref fCZRMC, value); }
        }

        string fZTMC;
        [Size(16)]
        public string ZTMC
        {
            get { return fZTMC; }
            set { SetPropertyValue<string>("ZTMC", ref fZTMC, value); }
        }

        string fFKPZH;
        [Size(16)]
        public string FKPZH
        {
            get { return fFKPZH; }
            set { SetPropertyValue<string>("FKPZH", ref fFKPZH, value); }
        }

        string fZTIDMC;
        [Size(16)]
        public string ZTIDMC
        {
            get { return fZTIDMC; }
            set { SetPropertyValue<string>("ZTIDMC", ref fZTIDMC, value); }
        }

        public VIEW_JT_C_CGJSD(Session session) : base(session) { }
        public VIEW_JT_C_CGJSD() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class VIEW_SYS_ROLE : XPLiteObject
    {

        string fROLE_ID;
        [Key]
        [Size(16)]
        public string ROLE_ID
        {
            get { return fROLE_ID; }
            set { SetPropertyValue<string>("ROLE_ID", ref fROLE_ID, value); }
        }

        string fROLE_NAME;
        [Size(30)]
        public string ROLE_NAME
        {
            get { return fROLE_NAME; }
            set { SetPropertyValue<string>("ROLE_NAME", ref fROLE_NAME, value); }
        }
        string fSUPER_ID;

        [Size(16)]
        public string SUPER_ID
        {
            get { return fSUPER_ID; }
            set { SetPropertyValue<string>("SUPER_IDD", ref fSUPER_ID, value); }
        }
        string fDESCRIPTION;
        [Size(512)]
        public string DESCRIPTION
        {
            get { return fDESCRIPTION; }
            set { SetPropertyValue<string>("DESCRIPTION", ref fDESCRIPTION, value); }
        }
        string fSTATE;
        [Size(6)]
        public string STATE
        {
            get { return fSTATE; }
            set { SetPropertyValue<string>("STATE", ref fSTATE, value); }
        }
        DateTime fSTATE_DATE;
        public DateTime STATE_DATE
        {
            get { return fSTATE_DATE; }
            set { SetPropertyValue<DateTime>("STATE_DATE", ref fSTATE_DATE, value); }
        }
        string fCREATOR;
        [Size(15)]
        public string CREATOR
        {
            get { return fCREATOR; }
            set { SetPropertyValue<string>("CREATOR", ref fCREATOR, value); }
        }
        DateTime fCREATE_DATE;
        public DateTime CREATE_DATE
        {
            get { return fCREATE_DATE; }
            set { SetPropertyValue<DateTime>("CREATE_DATE", ref fCREATE_DATE, value); }
        }
        string fTYPE;
        [Size(2)]
        public string TYPE
        {
            get { return fTYPE; }
            set { SetPropertyValue<string>("TYPE", ref fTYPE, value); }
        }
        long fROLE_LEVEL;
        public long ROLE_LEVEL
        {
            get { return fROLE_LEVEL; }
            set { SetPropertyValue<long>("ROLE_LEVEL", ref fROLE_LEVEL, value); }
        }


        public VIEW_SYS_ROLE(Session session) : base(session) { }
        public VIEW_SYS_ROLE() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }
    public class VIEW_SYS_MODEL : XPLiteObject
    {
        long fID;
        [Key]
        public long ID
        {
            get { return fID; }
            set { SetPropertyValue<long>("ID", ref fID, value); }
        }
        string fMODELNAME;
        [Size(20)]
        public string MODELNAME
        {
            get { return fMODELNAME; }
            set { SetPropertyValue<string>("MODELNAME", ref fMODELNAME, value); }
        }
        long fPARENTMODEL;
        public long PARENTMODEL
        {
            get { return fPARENTMODEL; }
            set { SetPropertyValue<long>("PARENTMODEL", ref fPARENTMODEL, value); }
        }
        string fLINK;
        [Size(200)]
        public string LINK
        {
            get { return fLINK; }
            set { SetPropertyValue<string>("LINK", ref fLINK, value); }
        }
        string fISVISABLED;

        [Size(4)]
        public string ISVISABLED
        {
            get { return fISVISABLED; }
            set { SetPropertyValue<string>("ISVISABLED", ref fISVISABLED, value); }
        }
        string fMODEL_SORTNO;
        [Size(10)]
        public string MODEL_SORTNO
        {
            get { return fMODEL_SORTNO; }
            set { SetPropertyValue<string>("MODEL_SORTNOE", ref fMODEL_SORTNO, value); }
        }
        string fMODEL_DLL;
        [Size(64)]
        public string MODEL_DLL
        {
            get { return fMODEL_DLL; }
            set { SetPropertyValue<string>("MODEL_DLL", ref fMODEL_DLL, value); }
        }
        string fSOURMODE;
        [Size(64)]
        public string SOURMODE
        {
            get { return fSOURMODE; }
            set { SetPropertyValue<string>("SOURMODE", ref fSOURMODE, value); }
        }
        string fPARENLEV;
        [Size(64)]
        public string PARENLEV
        {
            get { return fPARENLEV; }
            set { SetPropertyValue<string>("PARENLEV", ref fPARENLEV, value); }
        }
        string fCHILDMODE;
        [Size(64)]
        public string CHILDMODE
        {
            get { return fCHILDMODE; }
            set { SetPropertyValue<string>("CHILDMODE", ref fCHILDMODE, value); }
        }
        string fDBTYPE;
        [Size(2)]
        public string DBTYPE
        {
            get { return fDBTYPE; }
            set { SetPropertyValue<string>("DBTYPE", ref fDBTYPE, value); }
        }
        string fSYSTYPE;
        [Size(2)]
        public string SYSTYPE
        {
            get { return fSYSTYPE; }
            set { SetPropertyValue<string>("SYSTYPE", ref fSYSTYPE, value); }
        }
        string fFATHERNAME;
        [Size(20)]
        public string FATHERNAME
        {
            get { return fFATHERNAME; }
            set { SetPropertyValue<string>("FATHERNAME", ref fFATHERNAME, value); }
        }
        string fTYPENAME;
        [Size(20)]
        public string TYPENAME
        {
            get { return fTYPENAME; }
            set { SetPropertyValue<string>("TYPENAME", ref fTYPENAME, value); }
        }

        public VIEW_SYS_MODEL(Session session) : base(session) { }
        public VIEW_SYS_MODEL() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }
    public class VIEW_SYS_EMPLOYEES_SELECT : XPLiteObject
    {
        string fEMPLOYEEID;
        [Key]
        [Size(16)]
        public string EMPLOYEEID
        {
            get { return fEMPLOYEEID; }
            set { SetPropertyValue<string>("EMPLOYEEID", ref fEMPLOYEEID, value); }
        }
        string fEMPLOYEENO;
        [Size(22)]
        public string EMPLOYEENO
        {
            get { return fEMPLOYEENO; }
            set { SetPropertyValue<string>("EMPLOYEENO", ref fEMPLOYEENO, value); }
        }
        string fNAME;
        [Size(16)]
        public string NAME
        {
            get { return fNAME; }
            set { SetPropertyValue<string>("NAME", ref fNAME, value); }
        }
        string fFASTCODE;
        [Size(10)]
        public string FASTCODE
        {
            get { return fFASTCODE; }
            set { SetPropertyValue<string>("FASTCODE", ref fFASTCODE, value); }
        }
        string fSEX;
        [Size(2)]
        public string SEX
        {
            get { return fSEX; }
            set { SetPropertyValue<string>("SEX", ref fSEX, value); }
        }

        DateTime fBIRTHDAY;
        public DateTime BIRTHDAY
        {
            get { return fBIRTHDAY; }
            set { SetPropertyValue<DateTime>("BIRTHDAYE", ref fBIRTHDAY, value); }
        }



        string fEMAIL;
        [Size(50)]
        public string EMAIL
        {
            get { return fEMAIL; }
            set { SetPropertyValue<string>("EMAIL", ref fEMAIL, value); }
        }


        string fTXDZ;
        [Size(100)]
        public string TXDZ
        {
            get { return fTXDZ; }
            set { SetPropertyValue<string>("TXDZ", ref fTXDZ, value); }
        }


        string fTELEPHONE;
        [Size(16)]
        public string TELEPHONE
        {
            get { return fTELEPHONE; }
            set { SetPropertyValue<string>("TELEPHONE", ref fTELEPHONE, value); }
        }
        string fMOBILETELEPHONE;
        [Size(16)]
        public string MOBILETELEPHONE
        {
            get { return fMOBILETELEPHONE; }
            set { SetPropertyValue<string>("MOBILETELEPHONE", ref fMOBILETELEPHONE, value); }
        }
        string fSJDWID;
        [Size(16)]
        public string SJDWID
        {
            get { return fSJDWID; }
            set { SetPropertyValue<string>("SJDWID", ref fSJDWID, value); }
        }
        string fJCJCNO;
        [Size(16)]
        public string JCJCNO
        {
            get { return fJCJCNO; }
            set { SetPropertyValue<string>("JCJCNO", ref fJCJCNO, value); }
        }
        string fKHDNO;
        [Size(16)]
        public string KHDNO
        {
            get { return fKHDNO; }
            set { SetPropertyValue<string>("KHDNO", ref fKHDNO, value); }
        }
        string fDEPARTMENTNAME;
        [Size(22)]
        public string DEPARTMENTNAME
        {
            get { return fDEPARTMENTNAME; }
            set { SetPropertyValue<string>("KHDNO", ref fDEPARTMENTNAME, value); }
        }
        public VIEW_SYS_EMPLOYEES_SELECT(Session session) : base(session) { }
        public VIEW_SYS_EMPLOYEES_SELECT() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class VIEW_SYS_EMPLOYEES : XPLiteObject
    {
        string fEMPLOYEEID;
        [Key]
        [Size(16)]
        public string EMPLOYEEID
        {
            get { return fEMPLOYEEID; }
            set { SetPropertyValue<string>("EMPLOYEEID", ref fEMPLOYEEID, value); }
        }
        string fEMPLOYEENO;
        [Size(22)]
        public string EMPLOYEENO
        {
            get { return fEMPLOYEENO; }
            set { SetPropertyValue<string>("EMPLOYEENO", ref fEMPLOYEENO, value); }
        }
        string fNAME;
        [Size(16)]
        public string NAME
        {
            get { return fNAME; }
            set { SetPropertyValue<string>("NAME", ref fNAME, value); }
        }
        string fFASTCODE;
        [Size(10)]
        public string FASTCODE
        {
            get { return fFASTCODE; }
            set { SetPropertyValue<string>("FASTCODE", ref fFASTCODE, value); }
        }
        string fSEX;
        [Size(2)]
        public string SEX
        {
            get { return fSEX; }
            set { SetPropertyValue<string>("SEX", ref fSEX, value); }
        }

        DateTime fBIRTHDAY;
        public DateTime BIRTHDAY
        {
            get { return fBIRTHDAY; }
            set { SetPropertyValue<DateTime>("BIRTHDAYE", ref fBIRTHDAY, value); }
        }



        string fEMAIL;
        [Size(50)]
        public string EMAIL
        {
            get { return fEMAIL; }
            set { SetPropertyValue<string>("EMAIL", ref fEMAIL, value); }
        }


        string fTXDZ;
        [Size(100)]
        public string TXDZ
        {
            get { return fTXDZ; }
            set { SetPropertyValue<string>("TXDZ", ref fTXDZ, value); }
        }


        string fTELEPHONE;
        [Size(16)]
        public string TELEPHONE
        {
            get { return fTELEPHONE; }
            set { SetPropertyValue<string>("TELEPHONE", ref fTELEPHONE, value); }
        }
        string fMOBILETELEPHONE;
        [Size(16)]
        public string MOBILETELEPHONE
        {
            get { return fMOBILETELEPHONE; }
            set { SetPropertyValue<string>("MOBILETELEPHONE", ref fMOBILETELEPHONE, value); }
        }
        string fSJDWID;
        [Size(16)]
        public string SJDWID
        {
            get { return fSJDWID; }
            set { SetPropertyValue<string>("SJDWID", ref fSJDWID, value); }
        }
        string fJCJCNO;
        [Size(16)]
        public string JCJCNO
        {
            get { return fJCJCNO; }
            set { SetPropertyValue<string>("JCJCNO", ref fJCJCNO, value); }
        }
        string fKHDNO;
        [Size(16)]
        public string KHDNO
        {
            get { return fKHDNO; }
            set { SetPropertyValue<string>("KHDNO", ref fKHDNO, value); }
        }
        string fDEPARTMENTNAME;
        [Size(22)]
        public string DEPARTMENTNAME
        {
            get { return fDEPARTMENTNAME; }
            set { SetPropertyValue<string>("KHDNO", ref fDEPARTMENTNAME, value); }
        }
        public VIEW_SYS_EMPLOYEES(Session session) : base(session) { }
        public VIEW_SYS_EMPLOYEES() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }
    public class VIEW_SYS_USER : XPLiteObject
    {
        string fUSERID;
        [Key]
        [Size(16)]
        public string USERID
        {
            get { return fUSERID; }
            set { SetPropertyValue<string>("USERID", ref fUSERID, value); }
        }
        string fUSERNAME;
        [Size(22)]
        public string USERNAME
        {
            get { return fUSERNAME; }
            set { SetPropertyValue<string>("USERNAME", ref fUSERNAME, value); }
        }
        string fISLOCK;
        [Size(2)]
        public string ISLOCK
        {
            get { return fISLOCK; }
            set { SetPropertyValue<string>("ISLOCK", ref fISLOCK, value); }
        }
        string fPASSWORD;
        [Size(48)]
        public string PASSWORD
        {
            get { return fPASSWORD; }
            set { SetPropertyValue<string>("PASSWORD", ref fPASSWORD, value); }
        }
        string fDESCRIPTION;
        [Size(100)]
        public string DESCRIPTION
        {
            get { return fDESCRIPTION; }
            set { SetPropertyValue<string>("DESCRIPTION", ref fDESCRIPTION, value); }
        }

        DateTime fSTARTDATE;
        public DateTime STARTDATE
        {
            get { return fSTARTDATE; }
            set { SetPropertyValue<DateTime>("STARTDATE", ref fSTARTDATE, value); }
        }

        DateTime fSTOPDATE;
        public DateTime STOPDATE
        {
            get { return fSTOPDATE; }
            set { SetPropertyValue<DateTime>("STOPDATE", ref fSTOPDATE, value); }
        }



        string fEMPID;
        [Size(16)]
        public string EMPID
        {
            get { return fEMPID; }
            set { SetPropertyValue<string>("EMPID", ref fEMPID, value); }
        }


        string fLSKHDNO;
        [Size(16)]
        public string LSKHDNO
        {
            get { return fLSKHDNO; }
            set { SetPropertyValue<string>("LSKHDNO", ref fLSKHDNO, value); }
        }


        string fJCDJCNO;
        [Size(16)]
        public string JCDJCNO
        {
            get { return fJCDJCNO; }
            set { SetPropertyValue<string>("JCDJCNO", ref fJCDJCNO, value); }
        }
        string fYTHPTNO;
        [Size(16)]
        public string YTHPTNO
        {
            get { return fYTHPTNO; }
            set { SetPropertyValue<string>("YTHPTNO", ref fYTHPTNO, value); }
        }
        string fNAME;
        [Size(16)]
        public string NAME
        {
            get { return fNAME; }
            set { SetPropertyValue<string>("NAME", ref fNAME, value); }
        }

        public VIEW_SYS_USER(Session session) : base(session) { }
        public VIEW_SYS_USER() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }
    public class JT_C_XSD : XPLiteObject
    {
        string fXSDID;
        [Key]
        [Size(16)]
        public string XSDID
        {
            get { return fXSDID; }
            set { SetPropertyValue<string>("XSDID", ref fXSDID, value); }
        }
        string fXSDH;
        [Size(22)]
        public string XSDH
        {
            get { return fXSDH; }
            set { SetPropertyValue<string>("XSDH", ref fXSDH, value); }
        }
        string fXSBMID;
        [Size(16)]
        public string XSBMID
        {
            get { return fXSBMID; }
            set { SetPropertyValue<string>("XSBMID", ref fXSBMID, value); }
        }
        string fWLBMID;
        [Size(16)]
        public string WLBMID
        {
            get { return fWLBMID; }
            set { SetPropertyValue<string>("WLBMID", ref fWLBMID, value); }
        }
        string fKHID;
        [Size(16)]
        public string KHID
        {
            get { return fKHID; }
            set { SetPropertyValue<string>("KHID", ref fKHID, value); }
        }
        string fKHMC;
        [Size(16)]
        public string KHMC
        {
            get { return fKHMC; }
            set { SetPropertyValue<string>("KHMC", ref fKHMC, value); }
        }
        DateTime fZDRQ;
        public DateTime ZDRQ
        {
            get { return fZDRQ; }
            set { SetPropertyValue<DateTime>("ZDRQ", ref fZDRQ, value); }
        }

        string fCZYID;
        [Size(16)]
        public string CZYID
        {
            get { return fCZYID; }
            set { SetPropertyValue<string>("CZYID", ref fCZYID, value); }
        }

        long fPZS;
        public long PZS
        {
            get { return fPZS; }
            set { SetPropertyValue<long>("PZS", ref fPZS, value); }
        }

        long fXSSL;
        public long XSSL
        {
            get { return fXSSL; }
            set { SetPropertyValue<long>("XSSL", ref fXSSL, value); }
        }

        decimal fXSSY;
        public decimal XSSY
        {
            get { return fXSSY; }
            set { SetPropertyValue<decimal>("XSSY", ref fXSSY, value); }
        }
        decimal fXSMY;
        public decimal XSMY
        {
            get { return fXSMY; }
            set { SetPropertyValue<decimal>("XSMY", ref fXSMY, value); }
        }

        long fYSSL;
        public long YSSL
        {
            get { return fYSSL; }
            set { SetPropertyValue<long>("YSSL", ref fYSSL, value); }
        }

        decimal fYSSY;
        public decimal YSSY
        {
            get { return fYSSY; }
            set { SetPropertyValue<decimal>("YSSY", ref fYSSY, value); }
        }
        string fYSFSID;
        [Size(22)]
        public string YSFSID
        {
            get { return YSFSID; }
            set { SetPropertyValue<string>("YSFSID", ref fYSFSID, value); }
        }
        decimal fYSMY;
        public decimal YSMY
        {
            get { return fYSMY; }
            set { SetPropertyValue<decimal>("YSMY", ref fYSMY, value); }
        }


        string fZT;
        [Size(16)]
        public string ZT
        {
            get { return fZT; }
            set { SetPropertyValue<string>("ZT", ref fZT, value); }
        }
        string fYZT;
        [Size(16)]
        public string YZT
        {
            get { return fYZT; }
            set { SetPropertyValue<string>("YZT", ref fYZT, value); }
        }
        string fBZ;
        [Size(80)]
        public string BZ
        {
            get { return fBZ; }
            set { SetPropertyValue<string>("BZ", ref fBZ, value); }
        }
        DateTime fCZRQ;
        public DateTime CZRQ
        {
            get { return fCZRQ; }
            set { SetPropertyValue<DateTime>("CZRQ", ref fCZRQ, value); }
        }


        string fYDH;
        [Size(22)]
        public string YDH
        {
            get { return fYDH; }
            set { SetPropertyValue<string>("YDH", ref fYDH, value); }
        }

        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }
        string fSJLX;
        [Size(16)]
        public string SJLX
        {
            get { return fSJLX; }
            set { SetPropertyValue<string>("SJLX", ref fSJLX, value); }
        }

        string fJSDWID;
        [Size(16)]
        public string JSDWID
        {
            get { return fJSDWID; }
            set { SetPropertyValue<string>("JSDWID", ref fJSDWID, value); }
        }
        int fSL;
        public int SL
        {
            get { return fSL; }
            set { SetPropertyValue<int>("SL", ref fSL, value); }
        }
        string fJSFSID;
        [Size(16)]
        public string JSFSID
        {
            get { return fJSFSID; }
            set { SetPropertyValue<string>("JSFSID", ref fJSFSID, value); }
        }
        public JT_C_XSD(Session session) : base(session) { }
        public JT_C_XSD() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }
    public class JT_C_CGSH : XPLiteObject
    {
        string fCGSHID;
        [Key]
        [Size(16)]
        public string CGSHID
        {
            get { return fCGSHID; }
            set { SetPropertyValue<string>("CGSHID", ref fCGSHID, value); }
        }
        string fSHDH;
        [Size(22)]
        public string SHDH
        {
            get { return fSHDH; }
            set { SetPropertyValue<string>("SHDH", ref fSHDH, value); }
        }
        string fCGBMID;
        [Size(16)]
        public string CGBMID
        {
            get { return fCGBMID; }
            set { SetPropertyValue<string>("CGBMID", ref fCGBMID, value); }
        }
        string fWLBMID;
        [Size(16)]
        public string WLBMID
        {
            get { return fWLBMID; }
            set { SetPropertyValue<string>("WLBMID", ref fWLBMID, value); }
        }
        string fGYSID;
        [Size(16)]
        public string GYSID
        {
            get { return fGYSID; }
            set { SetPropertyValue<string>("GYSID", ref fGYSID, value); }
        }
        DateTime fZDRQ;
        public DateTime ZDRQ
        {
            get { return fZDRQ; }
            set { SetPropertyValue<DateTime>("ZDRQ", ref fZDRQ, value); }
        }

        string fCZYID;
        [Size(16)]
        public string CZYID
        {
            get { return fCZYID; }
            set { SetPropertyValue<string>("CZYID", ref fCZYID, value); }
        }

        long fSSPZ;
        public long SSPZ
        {
            get { return fSSPZ; }
            set { SetPropertyValue<long>("SSPZ", ref fSSPZ, value); }
        }

        long fSSSL;
        public long SSSL
        {
            get { return fSSSL; }
            set { SetPropertyValue<long>("SSSL", ref fSSSL, value); }
        }

        decimal fSSSY;
        public decimal SSSY
        {
            get { return fSSSY; }
            set { SetPropertyValue<decimal>("SSSY", ref fSSSY, value); }
        }
        decimal fSSMY;
        public decimal SSMY
        {
            get { return fSSMY; }
            set { SetPropertyValue<decimal>("SSMY", ref fSSMY, value); }
        }

        long fYFSL;
        public long YFSL
        {
            get { return fYFSL; }
            set { SetPropertyValue<long>("YFSL", ref fYFSL, value); }
        }

        decimal fYFSY;
        public decimal YFSY
        {
            get { return fSSSY; }
            set { SetPropertyValue<decimal>("YFSY", ref fYFSY, value); }
        }
        decimal fYFMY;
        public decimal YFMY
        {
            get { return fYFMY; }
            set { SetPropertyValue<decimal>("YFMY", ref fYFMY, value); }
        }



        string fZT;
        [Size(16)]
        public string ZT
        {
            get { return fZT; }
            set { SetPropertyValue<string>("ZT", ref fZT, value); }
        }
        string fYZT;
        [Size(16)]
        public string YZT
        {
            get { return fYZT; }
            set { SetPropertyValue<string>("YZT", ref fYZT, value); }
        }
        string fBZ;
        [Size(80)]
        public string BZ
        {
            get { return fBZ; }
            set { SetPropertyValue<string>("BZ", ref fBZ, value); }
        }
        DateTime fCZRQ;
        public DateTime CZRQ
        {
            get { return fCZRQ; }
            set { SetPropertyValue<DateTime>("CZRQ", ref fCZRQ, value); }
        }


        string fYSDH;
        [Size(22)]
        public string YSDH
        {
            get { return fYSDH; }
            set { SetPropertyValue<string>("YSDH", ref fYSDH, value); }
        }

        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }
        string fSJLX;
        [Size(16)]
        public string SJLX
        {
            get { return fSJLX; }
            set { SetPropertyValue<string>("SJLX", ref fSJLX, value); }
        }

        string fJSDWID;
        [Size(16)]
        public string JSDWID
        {
            get { return fJSDWID; }
            set { SetPropertyValue<string>("JSDWID", ref fJSDWID, value); }
        }
        int fSL;
        public int SL
        {
            get { return fSL; }
            set { SetPropertyValue<int>("SL", ref fSL, value); }
        }

        public JT_C_CGSH(Session session) : base(session) { }
        public JT_C_CGSH() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }
    public class VIEW_JC_C_XSTSDMX : XPLiteObject
    {

        string fXSTSDMXID;
        [Key]
        [Size(16)]
        public string XSTSDMXID
        {
            get { return fXSTSDMXID; }
            set { SetPropertyValue<string>("XSTSDMXID", ref fXSTSDMXID, value); }
        }

        string fXSTSDID;
        [Size(16)]
        public string XSTSDID
        {
            get { return fXSTSDID; }
            set { SetPropertyValue<string>("XSTSDID", ref fXSTSDID, value); }
        }
        string fXSJSDID;
        [Size(16)]
        public string XSJSDID
        {
            get { return fXSJSDID; }
            set { SetPropertyValue<string>("XSJSDID", ref fXSJSDID, value); }
        }

        long fSL;
        public long SL
        {
            get { return fSL; }
            set { SetPropertyValue<long>("PSL", ref fSL, value); }
        }

        decimal fWSJE;
        public decimal WSJE
        {
            get { return fWSJE; }
            set { SetPropertyValue<decimal>("WSJE", ref fWSJE, value); }
        }


        decimal fSE;
        public decimal SE
        {
            get { return fSE; }
            set { SetPropertyValue<decimal>("SE", ref fSE, value); }
        }

        decimal fJSHJ;
        public decimal JSHJ
        {
            get { return fJSHJ; }
            set { SetPropertyValue<decimal>("JSHJ", ref fJSHJ, value); }
        }

        string fBZ;
        [Size(100)]
        public string BZ
        {
            get { return fBZ; }
            set { SetPropertyValue<string>("BZ", ref fBZ, value); }
        }

        string fXSJSDH;
        [Size(22)]
        public string XSJSDH
        {
            get { return fXSJSDH; }
            set { SetPropertyValue<string>("XSJSDH", ref fXSJSDH, value); }
        }

        long fSHL;
        public long SHL
        {
            get { return fSHL; }
            set { SetPropertyValue<long>("SHL", ref fSHL, value); }
        }

        string fXSTSDH;
        [Size(22)]
        public string XSTSDH
        {
            get { return fXSTSDH; }
            set { SetPropertyValue<string>("XSTSDH", ref fXSTSDH, value); }
        }

        public VIEW_JC_C_XSTSDMX(Session session) : base(session) { }
        public VIEW_JC_C_XSTSDMX() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }
    public class VIEW_JC_C_XSTSD : XPLiteObject
    {
        string fXSTSDID;
        [Key]
        [Size(16)]
        public string XSTSDID
        {
            get { return fXSTSDID; }
            set { SetPropertyValue<string>("XSTSDID", ref fXSTSDID, value); }
        }
        string fXSTSDH;
        [Size(22)]
        public string XSTSDH
        {
            get { return fXSTSDH; }
            set { SetPropertyValue<string>("XSTSDH", ref fXSTSDH, value); }
        }
        string fYWBMID;
        [Size(16)]
        public string YWBMID
        {
            get { return fYWBMID; }
            set { SetPropertyValue<string>("YWBMID", ref fYWBMID, value); }
        }
        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }
        string fKHID;
        [Size(16)]
        public string KHID
        {
            get { return fKHID; }
            set { SetPropertyValue<string>("KHID", ref fKHID, value); }
        }

        decimal fTSJE;
        public decimal TSJE
        {
            get { return fTSJE; }
            set { SetPropertyValue<decimal>("TSJE", ref fTSJE, value); }
        }



        string fKHMC;
        [Size(22)]
        public string KHMC
        {
            get { return fKHMC; }
            set { SetPropertyValue<string>("KHMC", ref fKHMC, value); }
        }


        string fSH;
        [Size(100)]
        public string SH
        {
            get { return fSH; }
            set { SetPropertyValue<string>("SH", ref fSH, value); }
        }

        string fDZ;
        [Size(100)]
        public string DZ
        {
            get { return fDZ; }
            set { SetPropertyValue<string>("KDZ", ref fDZ, value); }
        }
        string fKHYH;
        [Size(16)]
        public string KHYH
        {
            get { return fKHYH; }
            set { SetPropertyValue<string>("KHYH", ref fKHYH, value); }
        }





        string fZH;
        [Size(100)]
        public string ZH
        {
            get { return fZH; }
            set { SetPropertyValue<string>("ZH", ref fZH, value); }
        }
        string fDH;
        [Size(40)]
        public string DH
        {
            get { return fDH; }
            set { SetPropertyValue<string>("DH", ref fDH, value); }
        }


        string fKXNRID;
        [Size(16)]
        public string KXNRID
        {
            get { return fKXNRID; }
            set { SetPropertyValue<string>("KXNRID", ref fKXNRID, value); }
        }
        string fTSPJMCID;
        [Size(16)]
        public string TSPJMCID
        {
            get { return fTSPJMCID; }
            set { SetPropertyValue<string>("TSPJMCID", ref fTSPJMCID, value); }
        }

        string fSPFYQKID;
        [Size(16)]
        public string SPFYQKID
        {
            get { return fSPFYQKID; }
            set { SetPropertyValue<string>("SPFYQKID", ref fSPFYQKID, value); }
        }
        string fCZYID;
        [Size(16)]
        public string CZYID
        {
            get { return fCZYID; }
            set { SetPropertyValue<string>("CZYID", ref fCZYID, value); }
        }

        string fXSHTID;
        [Size(16)]
        public string XSHTID
        {
            get { return fXSHTID; }
            set { SetPropertyValue<string>("XSHTID", ref fXSHTID, value); }
        }
        string fZDR;
        [Size(16)]
        public string ZDR
        {
            get { return fZDR; }
            set { SetPropertyValue<string>("ZDR", ref fZDR, value); }
        }


        DateTime fZDRQ;
        public DateTime ZDRQ
        {
            get { return fZDRQ; }
            set { SetPropertyValue<DateTime>("ZDRQ", ref fZDRQ, value); }
        }

        DateTime fCZRQ;
        public DateTime CZRQ
        {
            get { return fCZRQ; }
            set { SetPropertyValue<DateTime>("CZRQ", ref fCZRQ, value); }
        }



        string fZT;
        [Size(4)]
        public string ZT
        {
            get { return fZT; }
            set { SetPropertyValue<string>("ZT", ref fZT, value); }
        }
        string fYZT;
        [Size(4)]
        public string YZT
        {
            get { return fYZT; }
            set { SetPropertyValue<string>("YZT", ref fYZT, value); }
        }
        string fBZ;
        public string BZ
        {
            get { return fBZ; }
            set { SetPropertyValue<string>("BZ", ref fBZ, value); }
        }



        string fXSFPID;
        [Size(16)]
        public string XSFPID
        {
            get { return fXSFPID; }
            set { SetPropertyValue<string>("XSFPID", ref fXSFPID, value); }
        }


        string fCWBMMC;
        [Size(22)]
        public string CWBMMC
        {
            get { return fCWBMMC; }
            set { SetPropertyValue<string>("CWBMMC", ref fCWBMMC, value); }
        }




        string fZTIDMC;
        [Size(80)]
        public string ZTIDMC
        {
            get { return fZTIDMC; }
            set { SetPropertyValue<string>("ZTIDMC", ref fZTIDMC, value); }
        }



        string fZTMC;
        [Size(22)]
        public string ZTMC
        {
            get { return fZTMC; }
            set { SetPropertyValue<string>("ZTMC", ref fZTMC, value); }
        }



        string fCZRMC;
        [Size(12)]
        public string CZRMC
        {
            get { return fCZRMC; }
            set { SetPropertyValue<string>("CZRMC", ref fCZRMC, value); }
        }

        string fZDRMC;
        [Size(12)]
        public string ZDRMC
        {
            get { return fCZRMC; }
            set { SetPropertyValue<string>("ZDRMC", ref fZDRMC, value); }
        }

        string fXSFPH;
        [Size(22)]
        public string XSFPH
        {
            get { return fXSFPH; }
            set { SetPropertyValue<string>("XSFPH", ref fXSFPH, value); }
        }
        string fSJPH;
        [Size(22)]
        public string SJPH
        {
            get { return fSJPH; }
            set { SetPropertyValue<string>("SJPH", ref fSJPH, value); }
        }


        string fKXNRBH;
        [Size(22)]
        public string KXNRBH
        {
            get { return fKXNRBH; }
            set { SetPropertyValue<string>("KXNRBH", ref fKXNRBH, value); }
        }

        string fTSPJMCH;
        [Size(22)]
        public string TSPJMCH
        {
            get { return fTSPJMCH; }
            set { SetPropertyValue<string>("TSPJMCH", ref fTSPJMCH, value); }
        }

        string fSPFYQKDH;
        [Size(22)]
        public string SPFYQKDH
        {
            get { return fSPFYQKDH; }
            set { SetPropertyValue<string>("SPFYQKDH", ref fSPFYQKDH, value); }
        }








        public VIEW_JC_C_XSTSD(Session session) : base(session) { }
        public VIEW_JC_C_XSTSD() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }
    public class VIEW_JC_C_XSJSDMX : XPLiteObject
    {
        string fXSJSDMXID;
        [Key]
        [Size(16)]
        public string XSJSDMXID
        {
            get { return fXSJSDMXID; }
            set { SetPropertyValue<string>("XSJSDMXID", ref fXSJSDMXID, value); }
        }

        string fXSJSDID;
        [Size(16)]
        public string XSJSDID
        {
            get { return fXSJSDID; }
            set { SetPropertyValue<string>("XSJSDID", ref fXSJSDID, value); }
        }

        string fXSDID;
        [Size(16)]
        public string XSDID
        {
            get { return fXSDID; }
            set { SetPropertyValue<string>("XSDID", ref fXSDID, value); }
        }

        string fSJLX;
        [Size(4)]
        public string SJLX
        {
            get { return fSJLX; }
            set { SetPropertyValue<string>("SJLX", ref fSJLX, value); }
        }

        decimal fSE;
        public decimal SE
        {
            get { return fSE; }
            set { SetPropertyValue<decimal>("SE", ref fSE, value); }
        }

        string fXSDH;
        [Size(16)]
        public string XSDH
        {
            get { return fXSDH; }
            set { SetPropertyValue<string>("XSDH", ref fXSDH, value); }
        }

        string fKHID;
        [Size(16)]
        public string KHID
        {
            get { return fKHID; }
            set { SetPropertyValue<string>("KHID", ref fKHID, value); }
        }


        string fXSDMXID;
        [Size(16)]
        public string XSDMXID
        {
            get { return fXSDMXID; }
            set { SetPropertyValue<string>("XSDMXID", ref fXSDMXID, value); }
        }

        string fZDDM;
        [Size(16)]
        public string ZDDM
        {
            get { return fZDDM; }
            set { SetPropertyValue<string>("ZDDM", ref fZDDM, value); }
        }

        string fSPXXID;
        [Size(16)]
        public string SPXXID
        {
            get { return fSPXXID; }
            set { SetPropertyValue<string>("SPXXID", ref fSPXXID, value); }
        }


        decimal fDJ;
        public decimal DJ
        {
            get { return fDJ; }
            set { SetPropertyValue<decimal>("DJ", ref fDJ, value); }
        }

        decimal fXZ;
        public decimal XZ
        {
            get { return fXZ; }
            set { SetPropertyValue<decimal>("XZ", ref fXZ, value); }
        }

        decimal fXJ;
        public decimal XJ
        {
            get { return fXJ; }
            set { SetPropertyValue<decimal>("XJ", ref fXJ, value); }
        }


        decimal fFDXZ;
        public decimal FDXZ
        {
            get { return fFDXZ; }
            set { SetPropertyValue<decimal>("FDXZ", ref fFDXZ, value); }
        }

        decimal fFDXJ;
        public decimal FDXJ
        {
            get { return fFDXJ; }
            set { SetPropertyValue<decimal>("FDXJ", ref fFDXJ, value); }
        }


        long fSL;
        public long SL
        {
            get { return fSL; }
            set { SetPropertyValue<long>("SL", ref fSL, value); }
        }


        long fXSSL;
        public long XSSL
        {
            get { return fXSSL; }
            set { SetPropertyValue<long>("XSSL", ref fXSSL, value); }
        }
        decimal fXSSY;
        public decimal XSSY
        {
            get { return fXSSY; }
            set { SetPropertyValue<decimal>("XSSY", ref fXSSY, value); }
        }

        decimal fXSMY;
        public decimal XSMY
        {
            get { return fXSMY; }
            set { SetPropertyValue<decimal>("XSMY", ref fXSMY, value); }
        }


        decimal fFDE;
        public decimal FDE
        {
            get { return fFDE; }
            set { SetPropertyValue<decimal>("FDE", ref fFDE, value); }
        }

        decimal fJSHJ;
        public decimal JSHJ
        {
            get { return fJSHJ; }
            set { SetPropertyValue<decimal>("JSHJ", ref fJSHJ, value); }
        }


        long fDSSL;
        public long DSSL
        {
            get { return fDSSL; }
            set { SetPropertyValue<long>("DSSL", ref fDSSL, value); }
        }
        decimal fDSSY;
        public decimal DSSY
        {
            get { return fDSSY; }
            set { SetPropertyValue<decimal>("DSSY", ref fDSSY, value); }
        }

        decimal fDSMY;
        public decimal DSMY
        {
            get { return fDSMY; }
            set { SetPropertyValue<decimal>("DSMY", ref fDSMY, value); }
        }

        long fYJSL;
        public long YJSL
        {
            get { return fYJSL; }
            set { SetPropertyValue<long>("YJSL", ref fYJSL, value); }
        }
        decimal fYJSY;
        public decimal YJSY
        {
            get { return fYJSY; }
            set { SetPropertyValue<decimal>("YJSY", ref fYJSY, value); }
        }

        decimal fYJMY;
        public decimal YJMY
        {
            get { return fYJMY; }
            set { SetPropertyValue<decimal>("YJMY", ref fYJMY, value); }
        }


        string fZT;
        [Size(4)]
        public string ZT
        {
            get { return fZT; }
            set { SetPropertyValue<string>("ZT", ref fZT, value); }
        }

        string fYZT;
        [Size(4)]
        public string YZT
        {
            get { return fYZT; }
            set { SetPropertyValue<string>("YZT", ref fYZT, value); }
        }

        string fBZ;
        [Size(100)]
        public string BZ
        {
            get { return fBZ; }
            set { SetPropertyValue<string>("BZ", ref fBZ, value); }
        }


        string fXSFSID;
        [Size(16)]
        public string XSFSID
        {
            get { return fXSFSID; }
            set { SetPropertyValue<string>("XSFSID", ref fXSFSID, value); }
        }
        string fBMSPKFMXID;
        [Size(16)]
        public string BMSPKFMXID
        {
            get { return fBMSPKFMXID; }
            set { SetPropertyValue<string>("BMSPKFMXID", ref fBMSPKFMXID, value); }
        }

        string fKHSPMXID;
        [Size(16)]
        public string KHSPMXID
        {
            get { return fKHSPMXID; }
            set { SetPropertyValue<string>("KHSPMXID", ref fKHSPMXID, value); }
        }


        DateTime fTSRQ;
        public DateTime TSRQ
        {
            get { return fTSRQ; }
            set { SetPropertyValue<DateTime>("TSRQ", ref fTSRQ, value); }
        }


        long fTSCS;
        public long TSCS
        {
            get { return fTSCS; }
            set { SetPropertyValue<long>("TSCS", ref fTSCS, value); }
        }


        decimal fZKE;
        public decimal ZKE
        {
            get { return fZKE; }
            set { SetPropertyValue<decimal>("ZKEY", ref fZKE, value); }
        }

        decimal fWSJE;
        public decimal WSJE
        {
            get { return fWSJE; }
            set { SetPropertyValue<decimal>("WSJE", ref fWSJE, value); }
        }

        string fXSBMID;
        [Size(16)]
        public string XSBMID
        {
            get { return fXSBMID; }
            set { SetPropertyValue<string>("XSBMID", ref fXSBMID, value); }
        }

        string fLYDJMXID;
        [Size(16)]
        public string LYDJMXID
        {
            get { return fLYDJMXID; }
            set { SetPropertyValue<string>("LYDJMXID", ref fLYDJMXID, value); }
        }
        string fLYDJBID;
        [Size(16)]
        public string LYDJBID
        {
            get { return fLYDJBID; }
            set { SetPropertyValue<string>("LYDJBID", ref fLYDJBID, value); }
        }
        string fLYDJID;
        [Size(16)]
        public string LYDJID
        {
            get { return fLYDJID; }
            set { SetPropertyValue<string>("LYDJID", ref fLYDJID, value); }
        }
        string fLYBMID;
        [Size(16)]
        public string LYBMID
        {
            get { return fLYBMID; }
            set { SetPropertyValue<string>("LYBMID", ref fLYBMID, value); }
        }



        string fXSBMMC;
        [Size(22)]
        public string XSBMMC
        {
            get { return fXSBMMC; }
            set { SetPropertyValue<string>("XSBMMC", ref fXSBMMC, value); }
        }
        string fKHMC;
        [Size(22)]
        public string KHMC
        {
            get { return fKHMC; }
            set { SetPropertyValue<string>("KHMC", ref fKHMC, value); }
        }
        string fLYBMMC;
        [Size(16)]
        public string LYBMMC
        {
            get { return fLYBMMC; }
            set { SetPropertyValue<string>("LYBMMC", ref fLYBMMC, value); }
        }


        string fXSJSDH;
        [Size(22)]
        public string XSJSDH
        {
            get { return fXSJSDH; }
            set { SetPropertyValue<string>("XSJSDH", ref fXSJSDH, value); }
        }




        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }





        public VIEW_JC_C_XSJSDMX(Session session) : base(session) { }
        public VIEW_JC_C_XSJSDMX() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }

    }
    public class VIEW_JC_C_XSJSD : XPLiteObject
    {
        string fXSJSDID;
        [Key]
        [Size(16)]
        public string XSJSDID
        {
            get { return fXSJSDID; }
            set { SetPropertyValue<string>("XSJSDID", ref fXSJSDID, value); }
        }


        string fXSJSDH;
        [Size(22)]
        public string XSJSDH
        {
            get { return fXSJSDH; }
            set { SetPropertyValue<string>("XSJSDH", ref fXSJSDH, value); }
        }

        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }

        string fCWBMID;
        [Size(16)]
        public string CWBMID
        {
            get { return fCWBMID; }
            set { SetPropertyValue<string>("CWBMID", ref fCWBMID, value); }
        }

        string fGHDWID;
        [Size(16)]
        public string GHDWID
        {
            get { return fGHDWID; }
            set { SetPropertyValue<string>("GHDWID", ref fGHDWID, value); }
        }

        decimal fJSHJ;
        public decimal JSHJ
        {
            get { return fJSHJ; }
            set { SetPropertyValue<decimal>("JSHJ", ref fJSHJ, value); }
        }

        decimal fFDE;
        public decimal FDE
        {
            get { return fFDE; }
            set { SetPropertyValue<decimal>("FDE", ref fFDE, value); }
        }

        decimal fPJZK;
        public decimal PJZK
        {
            get { return fPJZK; }
            set { SetPropertyValue<decimal>("PJZK", ref fPJZK, value); }
        }

        decimal fPJDJ;
        public decimal PJDJ
        {
            get { return fPJDJ; }
            set { SetPropertyValue<decimal>("PJDJ", ref fPJDJ, value); }
        }

        string fJSLX;
        [Size(10)]
        public string JSLX
        {
            get { return fJSLX; }
            set { SetPropertyValue<string>("JSLX", ref fJSLX, value); }
        }


        string fJSR;
        [Size(10)]
        public string JSR
        {
            get { return fJSR; }
            set { SetPropertyValue<string>("JSR", ref fJSR, value); }
        }

        string fJSFSID;
        [Size(16)]
        public string JSFSID
        {
            get { return fJSFSID; }
            set { SetPropertyValue<string>("JSFSID", ref fJSFSID, value); }
        }

        DateTime fZDRQ;
        public DateTime ZDRQ
        {
            get { return fZDRQ; }
            set { SetPropertyValue<DateTime>("ZDRQ", ref fZDRQ, value); }
        }

        string fCZYID;
        [Size(16)]
        public string CZYID
        {
            get { return fCZYID; }
            set { SetPropertyValue<string>("CZYID", ref fCZYID, value); }
        }

        long fPZS;
        public long PZS
        {
            get { return fPZS; }
            set { SetPropertyValue<long>("SL", ref fPZS, value); }
        }


        long fXSSL;
        public long XSSL
        {
            get { return fXSSL; }
            set { SetPropertyValue<long>("XSSL", ref fXSSL, value); }
        }

        decimal fXSSY;
        public decimal XSSY
        {
            get { return fXSSY; }
            set { SetPropertyValue<decimal>("XSSY", ref fXSSY, value); }
        }

        decimal fXSMY;
        public decimal XSMY
        {
            get { return fXSMY; }
            set { SetPropertyValue<decimal>("XSMY", ref fXSMY, value); }
        }

        long fSL;
        public long SL
        {
            get { return fSL; }
            set { SetPropertyValue<long>("SL", ref fSL, value); }
        }

        decimal fSE;
        public decimal SE
        {
            get { return fSE; }
            set { SetPropertyValue<decimal>("SE", ref fSE, value); }
        }

        decimal fZKE;
        public decimal ZKE
        {
            get { return fZKE; }
            set { SetPropertyValue<decimal>("ZKE", ref fZKE, value); }
        }

        decimal fWSJE;
        public decimal WSJE
        {
            get { return fWSJE; }
            set { SetPropertyValue<decimal>("WSJE", ref fWSJE, value); }
        }


        long fTSZSL;
        public long TSZSL
        {
            get { return fTSZSL; }
            set { SetPropertyValue<long>("TSZSL", ref fTSZSL, value); }
        }

        decimal fTSZSY;
        public decimal TSZSY
        {
            get { return fTSZSY; }
            set { SetPropertyValue<decimal>("TSZSY", ref fTSZSY, value); }
        }

        decimal fTSZMY;
        public decimal TSZMY
        {
            get { return fTSZMY; }
            set { SetPropertyValue<decimal>("TSZMY", ref fTSZMY, value); }
        }

        DateTime fXSHZRQ;
        public DateTime XSHZRQ
        {
            get { return fXSHZRQ; }
            set { SetPropertyValue<DateTime>("XSHZRQ", ref fXSHZRQ, value); }
        }

        string fXSHZDID;
        [Size(22)]
        public string XSHZDID
        {
            get { return fXSHZDID; }
            set { SetPropertyValue<string>("XSHZDID", ref fXSHZDID, value); }
        }

        string fXSFPID;
        [Size(22)]
        public string XSFPID
        {
            get { return fXSFPID; }
            set { SetPropertyValue<string>("XSFPID", ref fXSFPID, value); }
        }


        long fDSSL;
        public long DSSL
        {
            get { return fDSSL; }
            set { SetPropertyValue<long>("DSSL", ref fDSSL, value); }
        }

        decimal fDSJE;
        public decimal DSJE
        {
            get { return fDSJE; }
            set { SetPropertyValue<decimal>("DSJE", ref fDSJE, value); }
        }

        decimal fDSMY;
        public decimal DSMY
        {
            get { return fXSMY; }
            set { SetPropertyValue<decimal>("DSMY", ref fDSMY, value); }
        }

        long fYSSL;
        public long YSSL
        {
            get { return fYSSL; }
            set { SetPropertyValue<long>("YSSL", ref fYSSL, value); }
        }

        decimal fYSJE;
        public decimal YSJE
        {
            get { return fYSJE; }
            set { SetPropertyValue<decimal>("YSJE", ref fYSJE, value); }
        }

        decimal fYSMY;
        public decimal YSMY
        {
            get { return fYSMY; }
            set { SetPropertyValue<decimal>("YSMY", ref fYSMY, value); }
        }

        DateTime fQSJSRQ;
        public DateTime QSJSRQ
        {
            get { return fQSJSRQ; }
            set { SetPropertyValue<DateTime>("QSJSRQ", ref fQSJSRQ, value); }
        }

        DateTime fZHJSRQ;
        public DateTime ZHJSRQ
        {
            get { return fZHJSRQ; }
            set { SetPropertyValue<DateTime>("ZHJSRQ", ref fZHJSRQ, value); }
        }


        DateTime fCZRQ;
        public DateTime CZRQ
        {
            get { return fCZRQ; }
            set { SetPropertyValue<DateTime>("CZRQ", ref fCZRQ, value); }
        }


        string fZT;
        [Size(40)]
        public string ZT
        {
            get { return fZT; }
            set { SetPropertyValue<string>("ZT", ref fZT, value); }
        }


        string fYZT;
        [Size(40)]
        public string YZT
        {
            get { return fYZT; }
            set { SetPropertyValue<string>("YZT", ref fYZT, value); }
        }

        string fBZ;
        [Size(100)]
        public string BZ
        {
            get { return fBZ; }
            set { SetPropertyValue<string>("BZ", ref fBZ, value); }
        }


        string fTSDMXID;
        [Size(16)]
        public string TSDMXID
        {
            get { return fTSDMXID; }
            set { SetPropertyValue<string>("TSDMXID", ref fTSDMXID, value); }
        }

        DateTime fHKRQ;
        public DateTime HKRQ
        {
            get { return fHKRQ; }
            set { SetPropertyValue<DateTime>("HKRQ", ref fHKRQ, value); }
        }


        string fSKPZID;
        [Size(16)]
        public string SKPZID
        {
            get { return fSKPZID; }
            set { SetPropertyValue<string>("SKPZID", ref fSKPZID, value); }
        }

        string fJZCBPZID;
        [Size(16)]
        public string JZCBPZID
        {
            get { return fJZCBPZID; }
            set { SetPropertyValue<string>("JZCBPZID", ref fJZCBPZID, value); }
        }


        DateTime fJZPZRQ;
        public DateTime JZPZRQ
        {
            get { return fJZPZRQ; }
            set { SetPropertyValue<DateTime>("JZPZRQ", ref fJZPZRQ, value); }
        }



        string fZTIDMC;
        [Size(16)]
        public string ZTIDMC
        {
            get { return fZTIDMC; }
            set { SetPropertyValue<string>("ZTIDMC", ref fZTIDMC, value); }
        }



        string fZTMC;
        [Size(16)]
        public string ZTMC
        {
            get { return fZTMC; }
            set { SetPropertyValue<string>("ZTMC", ref fZTMC, value); }
        }


        string fCZRMC;
        [Size(16)]
        public string CZRMC
        {
            get { return fCZRMC; }
            set { SetPropertyValue<string>("CZRMC", ref fCZRMC, value); }
        }


        string fJSFSMC;
        [Size(16)]
        public string JSFSMC
        {
            get { return fJSFSMC; }
            set { SetPropertyValue<string>("JSFSMC", ref fJSFSMC, value); }
        }



        string fCWBMMC;
        [Size(22)]
        public string CWBMMC
        {
            get { return fCWBMMC; }
            set { SetPropertyValue<string>("CWBMMC", ref fCWBMMC, value); }
        }

        string fGHDWMC;
        [Size(22)]
        public string GHDWMC
        {
            get { return fGHDWMC; }
            set { SetPropertyValue<string>("GHDWMC", ref fGHDWMC, value); }
        }

        string fXSFPH;
        [Size(22)]
        public string XSFPH
        {
            get { return fXSFPH; }
            set { SetPropertyValue<string>("XSFPH", ref fXSFPH, value); }
        }



        string fSKPZH;
        [Size(22)]
        public string SKPZH
        {
            get { return fSKPZH; }
            set { SetPropertyValue<string>("SKPZH", ref fSKPZH, value); }
        }

        string fXSHZDH;
        [Size(22)]
        public string XSHZDH
        {
            get { return fXSHZDH; }
            set { SetPropertyValue<string>("XSHZDH", ref fXSHZDH, value); }
        }

        string fJZCBPZH;
        [Size(22)]
        public string JZCBPZH
        {
            get { return fJZCBPZH; }
            set { SetPropertyValue<string>("JZCBPZH", ref fJZCBPZH, value); }
        }

        string fYSPZH;
        [Size(22)]
        public string YSPZH
        {
            get { return fYSPZH; }
            set { SetPropertyValue<string>("YSPZH", ref fYSPZH, value); }
        }

        string fTSDMXDH;
        [Size(22)]
        public string TSDMXDH
        {
            get { return fTSDMXDH; }
            set { SetPropertyValue<string>("TSDMXDH", ref fTSDMXDH, value); }
        }




        public VIEW_JC_C_XSJSD(Session session) : base(session) { }
        public VIEW_JC_C_XSJSD() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }
    public class VIEW_JC_C_XSFPMX : XPLiteObject
    {
        string fXSFPMXID;
        [Key]
        [Size(16)]
        public string XSFPMXID
        {
            get { return fXSFPMXID; }
            set { SetPropertyValue<string>("XSFPMXID", ref fXSFPMXID, value); }
        }

        string fXSFPID;
        [Size(16)]
        public string XSFPID
        {
            get { return fXSFPID; }
            set { SetPropertyValue<string>("XSFPID", ref fXSFPID, value); }
        }

        string fXSTSDID;
        [Size(16)]
        public string XSTSDID
        {
            get { return fXSTSDID; }
            set { SetPropertyValue<string>("XSTSDID", ref fXSTSDID, value); }
        }


        string fXSJSDID;
        [Size(16)]
        public string XSJSDID
        {
            get { return fXSJSDID; }
            set { SetPropertyValue<string>("XSJSDID", ref fXSJSDID, value); }
        }


        decimal fPJDJ;
        public decimal PJDJ
        {
            get { return fPJDJ; }
            set { SetPropertyValue<decimal>("PJDJ", ref fPJDJ, value); }
        }

        decimal fJSHJ;
        public decimal JSHJ
        {
            get { return fJSHJ; }
            set { SetPropertyValue<decimal>("JSHJ", ref fJSHJ, value); }
        }

        long fSL;
        public long SL
        {
            get { return fSL; }
            set { SetPropertyValue<long>("SL", ref fSL, value); }
        }

        decimal fSE;
        public decimal SE
        {
            get { return fSE; }
            set { SetPropertyValue<decimal>("SE", ref fSE, value); }
        }

        decimal fWSJE;
        public decimal WSJE
        {
            get { return fWSJE; }
            set { SetPropertyValue<decimal>("WSJE", ref fWSJE, value); }
        }

        string fJSFSID;
        [Size(16)]
        public string JSFSID
        {
            get { return fJSFSID; }
            set { SetPropertyValue<string>("JSFSID", ref fJSFSID, value); }
        }

        long fXSSL;
        public long XSSL
        {
            get { return fXSSL; }
            set { SetPropertyValue<long>("XSSL", ref fXSSL, value); }
        }

        string fXSJSDH;
        [Size(16)]
        public string XSJSDH
        {
            get { return fXSJSDH; }
            set { SetPropertyValue<string>("XSJSDH", ref fXSJSDH, value); }
        }

        string fHW;
        [Size(16)]
        public string HW
        {
            get { return fHW; }
            set { SetPropertyValue<string>("HW", ref fHW, value); }
        }

        string fGGXH;
        [Size(16)]
        public string GGXH
        {
            get { return fGGXH; }
            set { SetPropertyValue<string>("GGXH", ref fGGXH, value); }
        }

        string fDW;
        [Size(16)]
        public string DW
        {
            get { return fDW; }
            set { SetPropertyValue<string>("DW", ref fDW, value); }
        }

        string fBZ;
        [Size(16)]
        public string BZ
        {
            get { return fBZ; }
            set { SetPropertyValue<string>("BZ", ref fBZ, value); }
        }

        string fXSFPH;
        [Size(16)]
        public string XSFPH
        {
            get { return fXSFPH; }
            set { SetPropertyValue<string>("XSFPH", ref fXSFPH, value); }
        }

        string fXSTSDH;
        [Size(16)]
        public string JXSTSDH
        {
            get { return fJSFSMC; }
            set { SetPropertyValue<string>("XSTSDH", ref fXSTSDH, value); }
        }

        string fJSFSMC;
        [Size(16)]
        public string JSFSMC
        {
            get { return fJSFSMC; }
            set { SetPropertyValue<string>("JSFSMC", ref fJSFSMC, value); }
        }
        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }
        public VIEW_JC_C_XSFPMX(Session session) : base(session) { }
        public VIEW_JC_C_XSFPMX() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }
    public class VIEW_JC_C_XSFP : XPLiteObject
    {
        string fXSFPID;
        [Key]
        [Size(16)]
        public string XSFPID
        {
            get { return fXSFPID; }
            set { SetPropertyValue<string>("XSFPID", ref fXSFPID, value); }
        }
        string fXSFPH;
        [Size(22)]
        public string XSFPH
        {
            get { return fXSFPH; }
            set { SetPropertyValue<string>("XSFPH", ref fXSFPH, value); }
        }
        string fSJPH;
        [Size(22)]
        public string SJPH
        {
            get { return fSJPH; }
            set { SetPropertyValue<string>("SJPH", ref fSJPH, value); }
        }
        string fFPLXID;
        [Size(16)]
        public string FPLXID
        {
            get { return fFPLXID; }
            set { SetPropertyValue<string>("JHFSID", ref fFPLXID, value); }
        }
        string fKHID;
        [Size(15)]
        public string KHID
        {
            get { return fKHID; }
            set { SetPropertyValue<string>("KHID", ref fKHID, value); }
        }
        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }


        string fCZYID;
        [Size(16)]
        public string CZYID
        {
            get { return fCZYID; }
            set { SetPropertyValue<string>("CZYID", ref fCZYID, value); }
        }



        string fKPRID;
        [Size(16)]
        public string KPRID
        {
            get { return fKPRID; }
            set { SetPropertyValue<string>("KPRID", ref fKPRID, value); }
        }



        long fSL;
        public long SL
        {
            get { return fSL; }
            set { SetPropertyValue<long>("SL", ref fSL, value); }
        }

        decimal fWSJE;
        public decimal WSJE
        {
            get { return fWSJE; }
            set { SetPropertyValue<decimal>("WSJE", ref fWSJE, value); }
        }


        decimal fSE;
        public decimal SE
        {
            get { return fSE; }
            set { SetPropertyValue<decimal>("SE", ref fSE, value); }
        }

        decimal fJSHJ;
        public decimal JSHJ
        {
            get { return fJSHJ; }
            set { SetPropertyValue<decimal>("JSHJ", ref fJSHJ, value); }
        }

        string fYWBMID;
        [Size(16)]
        public string YWBMID
        {
            get { return fYWBMID; }
            set { SetPropertyValue<string>("YWBMID", ref fYWBMID, value); }
        }

        string fKHMC;
        [Size(80)]
        public string KHMC
        {
            get { return fKHMC; }
            set { SetPropertyValue<string>("KHMC", ref fKHMC, value); }
        }


        string fSH;
        [Size(100)]
        public string SH
        {
            get { return fSH; }
            set { SetPropertyValue<string>("SH", ref fSH, value); }
        }

        string fDZ;
        [Size(100)]
        public string DZ
        {
            get { return fDZ; }
            set { SetPropertyValue<string>("DZ", ref fDZ, value); }
        }

        string fZT;
        [Size(4)]
        public string ZT
        {
            get { return fZT; }
            set { SetPropertyValue<string>("ZT", ref fZT, value); }
        }

        string fKHYH;
        [Size(100)]
        public string KHYH
        {
            get { return fKHYH; }
            set { SetPropertyValue<string>("KHYH", ref fKHYH, value); }
        }




        string fZH;
        [Size(100)]
        public string ZH
        {
            get { return fZH; }
            set { SetPropertyValue<string>("ZH", ref fZH, value); }
        }

        string fDH;
        [Size(40)]
        public string DH
        {
            get { return fDH; }
            set { SetPropertyValue<string>("DH", ref fDH, value); }
        }

        DateTime fZDRQ;
        public DateTime ZDRQ
        {
            get { return fZDRQ; }
            set { SetPropertyValue<DateTime>("ZDRQ", ref fZDRQ, value); }
        }
        DateTime fCZRQ;
        public DateTime CZRQ
        {
            get { return fCZRQ; }
            set { SetPropertyValue<DateTime>("CZRQ", ref fCZRQ, value); }
        }


        string fYZT;
        [Size(4)]
        public string YZT
        {
            get { return fYZT; }
            set { SetPropertyValue<string>("YZT", ref fYZT, value); }
        }
        string fBZ;
        [Size(100)]
        public string BZ
        {
            get { return fBZ; }
            set { SetPropertyValue<string>("BZ", ref fBZ, value); }
        }


        string fFPLXMC;
        [Size(16)]
        public string FPLXMC
        {
            get { return fFPLXMC; }
            set { SetPropertyValue<string>("FPLXMC", ref fFPLXMC, value); }
        }

        string fZTMC;
        [Size(16)]
        public string ZTMC
        {
            get { return fZTMC; }
            set { SetPropertyValue<string>("ZTMC", ref fZTMC, value); }
        }

        string fKPRMC;
        [Size(16)]
        public string KPRMC
        {
            get { return fKPRMC; }
            set { SetPropertyValue<string>("KPRMC", ref fKPRMC, value); }
        }
        string fBMMC;
        [Size(16)]
        public string BMMC
        {
            get { return fBMMC; }
            set { SetPropertyValue<string>("BMMC", ref fBMMC, value); }
        }

        string fCZYMC;
        [Size(16)]
        public string CZYMC
        {
            get { return fCZYMC; }
            set { SetPropertyValue<string>("CZYMC", ref fCZYMC, value); }
        }

        string fZTIDMC;
        [Size(16)]
        public string ZTIDMC
        {
            get { return fZTIDMC; }
            set { SetPropertyValue<string>("ZTIDMC", ref fZTIDMC, value); }
        }



        public VIEW_JC_C_XSFP(Session session) : base(session) { }
        public VIEW_JC_C_XSFP() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }
    public class VIEW_JC_C_CGFPMX : XPLiteObject
    {
        string fCGFPMXID;
        [Key]
        [Size(16)]
        public string CGFPMXID
        {
            get { return fCGFPMXID; }
            set { SetPropertyValue<string>("CGFPMXID", ref fCGFPMXID, value); }
        }

        string fCGFPID;
        [Size(16)]
        public string CGFPID
        {
            get { return fCGFPID; }
            set { SetPropertyValue<string>("CGFPID", ref fCGFPID, value); }
        }

        string fCGTSDID;
        [Size(16)]
        public string CGTSDID
        {
            get { return fCGTSDID; }
            set { SetPropertyValue<string>("CGTSDID", ref fCGTSDID, value); }
        }

        string fCGJSDID;
        [Size(16)]
        public string CGJSDID
        {
            get { return fCGJSDID; }
            set { SetPropertyValue<string>("CGJSDID", ref fCGJSDID, value); }
        }

        decimal fPJDJ;
        public decimal PJDJ
        {
            get { return fPJDJ; }
            set { SetPropertyValue<decimal>("PJDJ", ref fPJDJ, value); }
        }

        decimal fJSHJ;
        public decimal JSHJ
        {
            get { return fJSHJ; }
            set { SetPropertyValue<decimal>("JSHJ", ref fJSHJ, value); }
        }

        long fSL;
        public long SL
        {
            get { return fSL; }
            set { SetPropertyValue<long>("SL", ref fSL, value); }
        }

        decimal fSE;
        public decimal SE
        {
            get { return fSE; }
            set { SetPropertyValue<decimal>("SE", ref fSE, value); }
        }

        decimal fWSJE;
        public decimal WSJE
        {
            get { return fWSJE; }
            set { SetPropertyValue<decimal>("WSJE", ref fWSJE, value); }
        }

        string fJSFSID;
        [Size(16)]
        public string JSFSID
        {
            get { return fJSFSID; }
            set { SetPropertyValue<string>("JSFSID", ref fJSFSID, value); }
        }

        long fSHSL;
        public long SHSL
        {
            get { return fSHSL; }
            set { SetPropertyValue<long>("SHSL", ref fSHSL, value); }
        }

        string fGYSJSDH;
        [Size(16)]
        public string GYSJSDH
        {
            get { return fGYSJSDH; }
            set { SetPropertyValue<string>("GYSJSDH", ref fGYSJSDH, value); }
        }

        string fHW;
        [Size(16)]
        public string HW
        {
            get { return fHW; }
            set { SetPropertyValue<string>("HW", ref fHW, value); }
        }

        string fGGXH;
        [Size(16)]
        public string GGXH
        {
            get { return fGGXH; }
            set { SetPropertyValue<string>("GGXH", ref fGGXH, value); }
        }

        string fDW;
        [Size(16)]
        public string DW
        {
            get { return fDW; }
            set { SetPropertyValue<string>("DW", ref fDW, value); }
        }

        string fBZ;
        [Size(80)]
        public string BZ
        {
            get { return fBZ; }
            set { SetPropertyValue<string>("BZ", ref fBZ, value); }
        }

        string fCGFPH;
        [Size(22)]
        public string CGFPH
        {
            get { return fCGFPH; }
            set { SetPropertyValue<string>("CGFPH", ref fCGFPH, value); }
        }

        string fJSFSMC;
        [Size(16)]
        public string JSFSMC
        {
            get { return fJSFSMC; }
            set { SetPropertyValue<string>("JSFSMC", ref fJSFSMC, value); }
        }

        string fCGTSDH;
        [Size(22)]
        public string CGTSDH
        {
            get { return fCGTSDH; }
            set { SetPropertyValue<string>("CGTSDH", ref fCGTSDH, value); }
        }


        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }

        public VIEW_JC_C_CGFPMX(Session session) : base(session) { }
        public VIEW_JC_C_CGFPMX() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }
    public class VIEW_JC_C_CGFP : XPLiteObject
    {
        string fCGFPID;
        [Key]
        [Size(16)]
        public string CGFPID
        {
            get { return fCGFPID; }
            set { SetPropertyValue<string>("CGFPID", ref fCGFPID, value); }
        }
        string fCGFPH;
        [Size(16)]
        public string CGFPH
        {
            get { return fCGFPH; }
            set { SetPropertyValue<string>("CGFPH", ref fCGFPH, value); }
        }
        string fSJPH;
        [Size(16)]
        public string SJPH
        {
            get { return fSJPH; }
            set { SetPropertyValue<string>("SJPH", ref fSJPH, value); }
        }
        string fFPLXID;
        [Size(16)]
        public string FPLXID
        {
            get { return fFPLXID; }
            set { SetPropertyValue<string>("JHFSID", ref fFPLXID, value); }
        }
        string fGYSID;
        [Size(15)]
        public string GYSID
        {
            get { return fGYSID; }
            set { SetPropertyValue<string>("GYSID", ref fGYSID, value); }
        }
        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }


        string fCZYID;
        [Size(16)]
        public string CZYID
        {
            get { return fCZYID; }
            set { SetPropertyValue<string>("CZYID", ref fCZYID, value); }
        }



        string fKPRID;
        [Size(16)]
        public string KPRID
        {
            get { return fKPRID; }
            set { SetPropertyValue<string>("KPRID", ref fKPRID, value); }
        }



        long fSL;
        public long SL
        {
            get { return fSL; }
            set { SetPropertyValue<long>("SL", ref fSL, value); }
        }

        decimal fWSJE;
        public decimal WSJE
        {
            get { return fWSJE; }
            set { SetPropertyValue<decimal>("WSJE", ref fWSJE, value); }
        }


        decimal fSE;
        public decimal SE
        {
            get { return fSE; }
            set { SetPropertyValue<decimal>("SE", ref fSE, value); }
        }

        decimal fJSHJ;
        public decimal JSHJ
        {
            get { return fJSHJ; }
            set { SetPropertyValue<decimal>("JSHJ", ref fJSHJ, value); }
        }

        string fYWBMID;
        [Size(16)]
        public string YWBMID
        {
            get { return fYWBMID; }
            set { SetPropertyValue<string>("YWBMID", ref fYWBMID, value); }
        }

        string fGYS;
        [Size(16)]
        public string GYS
        {
            get { return fGYS; }
            set { SetPropertyValue<string>("GYS", ref fGYS, value); }
        }


        string fSH;
        [Size(16)]
        public string SH
        {
            get { return fSH; }
            set { SetPropertyValue<string>("SH", ref fSH, value); }
        }

        string fDZ;
        [Size(16)]
        public string DZ
        {
            get { return fDZ; }
            set { SetPropertyValue<string>("DZ", ref fDZ, value); }
        }

       

        string fKHYH;
        [Size(16)]
        public string KHYH
        {
            get { return fKHYH; }
            set { SetPropertyValue<string>("KHYH", ref fKHYH, value); }
        }




        string fZH;
        [Size(16)]
        public string ZH
        {
            get { return fZH; }
            set { SetPropertyValue<string>("ZH", ref fZH, value); }
        }

        string fDH;
        [Size(16)]
        public string DH
        {
            get { return fDH; }
            set { SetPropertyValue<string>("DH", ref fDH, value); }
        }

        DateTime fZDRQ;
        public DateTime ZDRQ
        {
            get { return fZDRQ; }
            set { SetPropertyValue<DateTime>("ZDRQ", ref fZDRQ, value); }
        }
        DateTime fCZRQ;
        public DateTime CZRQ
        {
            get { return fCZRQ; }
            set { SetPropertyValue<DateTime>("CZRQ", ref fCZRQ, value); }
        }

        string fZT;
        [Size(16)]
        public string ZT
        {
            get { return fZT; }
            set { SetPropertyValue<string>("ZT", ref fZT, value); }
        }
        string fYZT;
        [Size(16)]
        public string YZT
        {
            get { return fYZT; }
            set { SetPropertyValue<string>("YZT", ref fYZT, value); }
        }
        string fBZ;
        [Size(16)]
        public string BZ
        {
            get { return fBZ; }
            set { SetPropertyValue<string>("BZ", ref fBZ, value); }
        }

      //  long fYGYS;
      //  public long YGYS
      //  {
      //      get { return fYGYS; }
     //       set { SetPropertyValue<long>("YGYS", ref fYGYS, value); }
     //   }
        string fFPLXMC;
        [Size(16)]
        public string FPLXMC
        {
            get { return fFPLXMC; }
            set { SetPropertyValue<string>("FPLXMC", ref fFPLXMC, value); }
        }

        string fZTMC;
        [Size(16)]
        public string ZTMC
        {
            get { return fZTMC; }
            set { SetPropertyValue<string>("ZTMC", ref fZTMC, value); }
        }

        string fKPRMC;
        [Size(16)]
        public string KPRMC
        {
            get { return fKPRMC; }
            set { SetPropertyValue<string>("KPRMC", ref fKPRMC, value); }
        }
        string fBMMC;
        [Size(16)]
        public string BMMC
        {
            get { return fBMMC; }
            set { SetPropertyValue<string>("BMMC", ref fBMMC, value); }
        }



        public VIEW_JC_C_CGFP(Session session) : base(session) { }
        public VIEW_JC_C_CGFP() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class VIEW_JC_C_YCKC : XPLiteObject
    {
        string fYCKCID;
        [Key]
        [Size(16)]
        public string YCKCID
        {
            get { return fYCKCID; }
            set { SetPropertyValue<string>("YCKCID", ref fYCKCID, value); }
        }

        string fSPXXID;
        [Size(16)]
        public string SPXXID
        {
            get { return fSPXXID; }
            set { SetPropertyValue<string>("SPXXID", ref fSPXXID, value); }
        }

        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }

        decimal fYCCS;
        public decimal YCCS
        {
            get { return fYCCS; }
            set { SetPropertyValue<decimal>("YCCS", ref fYCCS, value); }
        }

        string fCZYID;
        [Size(16)]
        public string CZYID
        {
            get { return fCZYID; }
            set { SetPropertyValue<string>("CZYID", ref fCZYID, value); }
        }

        DateTime fCZRQ;
        public DateTime CZRQ
        {
            get { return fCZRQ; }
            set { SetPropertyValue<DateTime>("CZRQ", ref fCZRQ, value); }
        }

        string fCLZT;
        [Size(1)]
        public string CLZT
        {
            get { return fCLZT; }
            set { SetPropertyValue<string>("CLZT", ref fCLZT, value); }
        }

        decimal fKTCS;
        public decimal KTCS
        {
            get { return fKTCS; }
            set { SetPropertyValue<decimal>("KTCS", ref fKTCS, value); }
        }
        decimal fYTCS;
        public decimal YTCS
        {
            get { return fYTCS; }
            set { SetPropertyValue<decimal>("YTCS", ref fYTCS, value); }
        }


        string fZTIDMC;
        [Size(22)]
        public string ZTIDMC
        {
            get { return fZTIDMC; }
            set { SetPropertyValue<string>("ZTIDMC", ref fZTIDMC, value); }
        }


        string fCZYMC;
        [Size(22)]
        public string CZYMC
        {
            get { return fCZYMC; }
            set { SetPropertyValue<string>("CZYMC", ref fCZYMC, value); }
        }
        string fSPBH;
        [Size(22)]
        public string SPBH
        {
            get { return fSPBH; }
            set { SetPropertyValue<string>("SPBH", ref fSPBH, value); }
        }
        decimal fDJ;
        public decimal DJ
        {
            get { return fDJ; }
            set { SetPropertyValue<decimal>("DJ", ref fDJ, value); }
        }

        string fSPMC;
        [Size(22)]
        public string SPMC
        {
            get { return fSPMC; }
            set { SetPropertyValue<string>("SPMC", ref fSPMC, value); }
        }

        string fGYSID;
        [Size(16)]
        public string GYSID
        {
            get { return fGYSID; }
            set { SetPropertyValue<string>("GYSID", ref fGYSID, value); }
        }

        string fBDWID;
        [Size(16)]
        public string BDWID
        {
            get { return fBDWID; }
            set { SetPropertyValue<string>("BDWID", ref fBDWID, value); }
        }
        public VIEW_JC_C_YCKC(Session session) : base(session) { }
        public VIEW_JC_C_YCKC() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }
    public class VIEW_JC_C_CGJSDMX : XPLiteObject
    {
        string fCGJSDMXID;
        [Key]
        [Size(16)]
        public string CGJSDMXID
        {
            get { return fCGJSDMXID; }
            set { SetPropertyValue<string>("CGJSDMXID", ref fCGJSDMXID, value); }
        }

        string fCGJSDID;
        [Size(16)]
        public string CGJSDID
        {
            get { return fCGJSDID; }
            set { SetPropertyValue<string>("CGJSDID", ref fCGJSDID, value); }
        }

        string fSHDID;
        [Size(16)]
        public string SHDID
        {
            get { return fSHDID; }
            set { SetPropertyValue<string>("SHDID", ref fSHDID, value); }
        }

        string fSJLX;
        [Size(4)]
        public string SJLX
        {
            get { return fSJLX; }
            set { SetPropertyValue<string>("SJLX", ref fSJLX, value); }
        }

        decimal fSE;
        public decimal SE
        {
            get { return fSE; }
            set { SetPropertyValue<decimal>("SE", ref fSE, value); }
        }

        string fSHDH;
        [Size(16)]
        public string SHDH
        {
            get { return fSHDH; }
            set { SetPropertyValue<string>("SHDH", ref fSHDH, value); }
        }

        string fCGBMID;
        [Size(16)]
        public string CGBMID
        {
            get { return fCGBMID; }
            set { SetPropertyValue<string>("CGBMID", ref fCGBMID, value); }
        }


        string fGYSID;
        [Size(16)]
        public string GYSID
        {
            get { return fGYSID; }
            set { SetPropertyValue<string>("GYSID", ref fGYSID, value); }
        }

        string fLYDJBID;
        [Size(16)]
        public string LYDJBID
        {
            get { return fLYDJBID; }
            set { SetPropertyValue<string>("LYDJBID", ref fLYDJBID, value); }
        }

        string fLYDJID;
        [Size(16)]
        public string LYDJID
        {
            get { return fLYDJID; }
            set { SetPropertyValue<string>("LYDJID", ref fLYDJID, value); }
        }

        string fLYDJMXID;
        [Size(16)]
        public string LYDJMXID
        {
            get { return fLYDJMXID; }
            set { SetPropertyValue<string>("LYDJMXID", ref fLYDJMXID, value); }
        }

        string fLYBMID;
        [Size(16)]
        public string LYBMID
        {
            get { return fLYBMID; }
            set { SetPropertyValue<string>("LYBMID", ref fLYBMID, value); }
        }

        string fCGSHMXID;
        [Size(16)]
        public string CGSHMXID
        {
            get { return fCGSHMXID; }
            set { SetPropertyValue<string>("CGSHMXID", ref fCGSHMXID, value); }
        }

        string fZDDM;
        [Size(16)]
        public string ZDDM
        {
            get { return fZDDM; }
            set { SetPropertyValue<string>("ZDDM", ref fZDDM, value); }
        }

        string fSPXXID;
        [Size(16)]
        public string SPXXID
        {
            get { return fSPXXID; }
            set { SetPropertyValue<string>("SPXXID", ref fSPXXID, value); }
        }

        decimal fDJ;
        public decimal DJ
        {
            get { return fDJ; }
            set { SetPropertyValue<decimal>("DJ", ref fDJ, value); }
        }
        //    decimal fSHMY;
        //     public decimal SHMY
        //     {
        //        get { return fSHMY; }
        //        set { SetPropertyValue<decimal>("SHMY", ref fSHMY, value); }
        //    }
        decimal fJZ;
        public decimal JZ
        {
            get { return fJZ; }
            set { SetPropertyValue<decimal>("JZ", ref fJZ, value); }
        }


        decimal fJJ;
        public decimal JJ
        {
            get { return fJJ; }
            set { SetPropertyValue<decimal>("JJ", ref fJJ, value); }
        }

        decimal fFDJZ;
        public decimal FDJZ
        {
            get { return fFDJZ; }
            set { SetPropertyValue<decimal>("FDJZ", ref fFDJZ, value); }
        }


        decimal fFDJJ;
        public decimal FDJJ
        {
            get { return fFDJJ; }
            set { SetPropertyValue<decimal>("FDJJ", ref fFDJJ, value); }
        }


        long fSL;
        public long SL
        {
            get { return fSL; }
            set { SetPropertyValue<long>("SL", ref fSL, value); }
        }

        long fSHSL;
        public long SHSL
        {
            get { return fSHSL; }
            set { SetPropertyValue<long>("SHSL", ref fSHSL, value); }
        }
        decimal fSHSY;
        public decimal SHSY
        {
            get { return fSHSY; }
            set { SetPropertyValue<decimal>("SHSY", ref fSHSY, value); }
        }

        decimal fSHMY;
        public decimal SHMY
        {
            get { return fSHMY; }
            set { SetPropertyValue<decimal>("SHMY", ref fSHMY, value); }
        }


        decimal fFDE;
        public decimal FDE
        {
            get { return fFDE; }
            set { SetPropertyValue<decimal>("FDE", ref fFDE, value); }
        }

        decimal fJSHJ;
        public decimal JSHJ
        {
            get { return fJSHJ; }
            set { SetPropertyValue<decimal>("JSHJ", ref fJSHJ, value); }
        }

        long fDFSL;
        public long DFSL
        {
            get { return fDFSL; }
            set { SetPropertyValue<long>("DFSL", ref fDFSL, value); }
        }

        decimal fDFSY;
        public decimal DFSY
        {
            get { return fDFSY; }
            set { SetPropertyValue<decimal>("DFSY", ref fDFSY, value); }
        }

        decimal fDFMY;
        public decimal DFMY
        {
            get { return fDFMY; }
            set { SetPropertyValue<decimal>("DFMY", ref fDFMY, value); }
        }

        long fYFSL;
        public long YFSL
        {
            get { return fYFSL; }
            set { SetPropertyValue<long>("YFSL", ref fYFSL, value); }
        }


        decimal fYFSY;
        public decimal YFSY
        {
            get { return fYFSY; }
            set { SetPropertyValue<decimal>("YFSY", ref fYFSY, value); }
        }

        decimal fYFMY;
        public decimal YFMY
        {
            get { return fYFMY; }
            set { SetPropertyValue<decimal>("YFMY", ref fYFMY, value); }
        }

        DateTime fQSJSRQ;
        public DateTime QSJSRQ
        {
            get { return fQSJSRQ; }
            set { SetPropertyValue<DateTime>("QSJSRQ", ref fQSJSRQ, value); }
        }

        DateTime fZHJSRQ;
        public DateTime ZHJSRQ
        {
            get { return fZHJSRQ; }
            set { SetPropertyValue<DateTime>("ZHJSRQ", ref fZHJSRQ, value); }
        }

        string fZT;
        [Size(4)]
        public string ZT
        {
            get { return fZT; }
            set { SetPropertyValue<string>("ZT", ref fZT, value); }
        }

        string fYZT;
        [Size(4)]
        public string YZT
        {
            get { return fYZT; }
            set { SetPropertyValue<string>("YZT", ref fYZT, value); }
        }

        string fBZ;
        [Size(100)]
        public string BZ
        {
            get { return fBZ; }
            set { SetPropertyValue<string>("BZ", ref fBZ, value); }
        }

        string fJHFSID;
        [Size(16)]
        public string JHFSID
        {
            get { return fJHFSID; }
            set { SetPropertyValue<string>("JHFSID", ref fJHFSID, value); }
        }

        string fBMSPKFMXID;
        [Size(16)]
        public string BMSPKFMXID
        {
            get { return fBMSPKFMXID; }
            set { SetPropertyValue<string>("BMSPKFMXID", ref fBMSPKFMXID, value); }
        }

        string fGYSSPMXID;
        [Size(16)]
        public string GYSSPMXID
        {
            get { return fGYSSPMXID; }
            set { SetPropertyValue<string>("GYSSPMXID", ref fGYSSPMXID, value); }
        }


        DateTime fQSZZRQ;
        public DateTime QSZZRQ
        {
            get { return fQSZZRQ; }
            set { SetPropertyValue<DateTime>("QSZZRQ", ref fQSZZRQ, value); }
        }

        DateTime fTSRQ;
        public DateTime TSRQ
        {
            get { return fTSRQ; }
            set { SetPropertyValue<DateTime>("TSRQ", ref fTSRQ, value); }
        }


        long fTSCS;
        public long TSCS
        {
            get { return fTSCS; }
            set { SetPropertyValue<long>("TSCS", ref fTSCS, value); }
        }


        string fYSDH;
        [Size(40)]
        public string YSDH
        {
            get { return fYSDH; }
            set { SetPropertyValue<string>("YSDH", ref fYSDH, value); }
        }
        string fCGJSDH;
        [Size(40)]
        public string CGJSDH
        {
            get { return fCGJSDH; }
            set { SetPropertyValue<string>("CGJSDH", ref fCGJSDH, value); }
        }
        string fSPXXMC;
        [Size(40)]
        public string SPXXMC
        {
            get { return fSPXXMC; }
            set { SetPropertyValue<string>("SPXXMC", ref fSPXXMC, value); }
        }


        string fSPBH;
        [Size(40)]
        public string SPBH
        {
            get { return fSPBH; }
            set { SetPropertyValue<string>("SPBH", ref fSPBH, value); }
        }

        string fDWMC;
        [Size(40)]
        public string DWMC
        {
            get { return fDWMC; }
            set { SetPropertyValue<string>("DWMC", ref fDWMC, value); }
        }

        decimal fZKE;
        public decimal ZKE
        {
            get { return fZKE; }
            set { SetPropertyValue<decimal>("ZKEY", ref fZKE, value); }
        }

        decimal fWSJE;
        public decimal WSJE
        {
            get { return fWSJE; }
            set { SetPropertyValue<decimal>("WSJE", ref fWSJE, value); }
        }
        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }


        public VIEW_JC_C_CGJSDMX(Session session) : base(session) { }
        public VIEW_JC_C_CGJSDMX() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }

    }
    public class VIEW_JC_C_CGJSD : XPLiteObject
    {
        string fCGJSDID;
        [Key]
        [Size(16)]
        public string CGJSDID
        {
            get { return fCGJSDID; }
            set { SetPropertyValue<string>("CGJSDID", ref fCGJSDID, value); }
        }


        string fCGFPH;
        [Size(22)]
        public string CGFPH
        {
            get { return fCGFPH; }
            set { SetPropertyValue<string>("CGFPH", ref fCGFPH, value); }
        }


        string fCGJSDH;
        [Size(22)]
        public string CGJSDH
        {
            get { return fCGJSDH; }
            set { SetPropertyValue<string>("CGJSDH", ref fCGJSDH, value); }
        }

        string fCWBMID;
        [Size(16)]
        public string CWBMID
        {
            get { return fCWBMID; }
            set { SetPropertyValue<string>("CWBMID", ref fCWBMID, value); }
        }

        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }


        string fGYSID;
        [Size(16)]
        public string GYSID
        {
            get { return fGYSID; }
            set { SetPropertyValue<string>("GYSID", ref fGYSID, value); }
        }

        decimal fJSHJ;
        public decimal JSHJ
        {
            get { return fJSHJ; }
            set { SetPropertyValue<decimal>("JSHJ", ref fJSHJ, value); }
        }

        decimal fFDE;
        public decimal FDE
        {
            get { return fFDE; }
            set { SetPropertyValue<decimal>("FDE", ref fFDE, value); }
        }

        decimal fPJZK;
        public decimal PJZK
        {
            get { return fPJZK; }
            set { SetPropertyValue<decimal>("PJZK", ref fPJZK, value); }
        }

        decimal fPJDJ;
        public decimal PJDJ
        {
            get { return fPJDJ; }
            set { SetPropertyValue<decimal>("PJDJ", ref fPJDJ, value); }
        }

        string fJSLX;
        [Size(10)]
        public string JSLX
        {
            get { return fJSLX; }
            set { SetPropertyValue<string>("JSLX", ref fJSLX, value); }
        }

        string fJSR;
        [Size(10)]
        public string JSR
        {
            get { return fJSR; }
            set { SetPropertyValue<string>("JSR", ref fJSR, value); }
        }

        string fJSFSID;
        [Size(16)]
        public string JSFSID
        {
            get { return fJSFSID; }
            set { SetPropertyValue<string>("JSFSID", ref fJSFSID, value); }
        }

        DateTime fZDRQ;
        public DateTime ZDRQ
        {
            get { return fZDRQ; }
            set { SetPropertyValue<DateTime>("ZDRQ", ref fZDRQ, value); }
        }

        string fCZYID;
        [Size(16)]
        public string CZYID
        {
            get { return fCZYID; }
            set { SetPropertyValue<string>("CZYID", ref fCZYID, value); }
        }

        long fPZS;
        public long PZS
        {
            get { return fPZS; }
            set { SetPropertyValue<long>("SL", ref fPZS, value); }
        }

        long fSHSL;
        public long SHSL
        {
            get { return fSHSL; }
            set { SetPropertyValue<long>("SHSL", ref fSHSL, value); }
        }

        decimal fSHSY;
        public decimal SHSY
        {
            get { return fSHSY; }
            set { SetPropertyValue<decimal>("SHSY", ref fSHSY, value); }
        }

        decimal fSHMY;
        public decimal SHMY
        {
            get { return fSHMY; }
            set { SetPropertyValue<decimal>("SHMY", ref fSHMY, value); }
        }



        long fSL;
        public long SL
        {
            get { return fSL; }
            set { SetPropertyValue<long>("SL", ref fSL, value); }
        }

        decimal fSE;
        public decimal SE
        {
            get { return fSE; }
            set { SetPropertyValue<decimal>("SE", ref fSE, value); }
        }

        decimal fZKE;
        public decimal ZKE
        {
            get { return fZKE; }
            set { SetPropertyValue<decimal>("ZKE", ref fZKE, value); }
        }

        decimal fWSJE;
        public decimal WSJE
        {
            get { return fWSJE; }
            set { SetPropertyValue<decimal>("WSJE", ref fWSJE, value); }
        }

        DateTime fSHHZRQ;
        public DateTime SHHZRQ
        {
            get { return fSHHZRQ; }
            set { SetPropertyValue<DateTime>("SHHZRQ", ref fSHHZRQ, value); }
        }

        string fSHHZDID;
        [Size(16)]
        public string SHHZDID
        {
            get { return fSHHZDID; }
            set { SetPropertyValue<string>("SHHZDID", ref fSHHZDID, value); }
        }

        string fCGFPID;
        [Size(16)]
        public string CGFPID
        {
            get { return fCGFPID; }
            set { SetPropertyValue<string>("CGFPID", ref fCGFPID, value); }
        }

        long fDJSL;
        public long DJSL
        {
            get { return fDJSL; }
            set { SetPropertyValue<long>("DJSL", ref fDJSL, value); }
        }

        decimal fDJJE;
        public decimal DJJE
        {
            get { return fDJJE; }
            set { SetPropertyValue<decimal>("DJJE", ref fDJJE, value); }
        }

        decimal fDJMY;
        public decimal DJMY
        {
            get { return fDJMY; }
            set { SetPropertyValue<decimal>("DJMY", ref fDJMY, value); }
        }

        long fYJSL;
        public long YJSL
        {
            get { return fYJSL; }
            set { SetPropertyValue<long>("YJSL", ref fYJSL, value); }
        }

        decimal fYJJE;
        public decimal YJJE
        {
            get { return fYJJE; }
            set { SetPropertyValue<decimal>("YJJE", ref fYJJE, value); }
        }

        decimal fYJMY;
        public decimal YJMY
        {
            get { return fYJMY; }
            set { SetPropertyValue<decimal>("YJMY", ref fYJMY, value); }
        }

        DateTime fQSJSRQ;
        public DateTime QSJSRQ
        {
            get { return fQSJSRQ; }
            set { SetPropertyValue<DateTime>("QSJSRQ", ref fQSJSRQ, value); }
        }

        DateTime fZHJSRQ;
        public DateTime ZHJSRQ
        {
            get { return fZHJSRQ; }
            set { SetPropertyValue<DateTime>("ZHJSRQ", ref fZHJSRQ, value); }
        }


        DateTime fCZRQ;
        public DateTime CZRQ
        {
            get { return fCZRQ; }
            set { SetPropertyValue<DateTime>("CZRQ", ref fCZRQ, value); }
        }


        string fZT;
        [Size(40)]
        public string ZT
        {
            get { return fZT; }
            set { SetPropertyValue<string>("ZT", ref fZT, value); }
        }


        string fYZT;
        [Size(40)]
        public string YZT
        {
            get { return fYZT; }
            set { SetPropertyValue<string>("YZT", ref fYZT, value); }
        }

        string fBZ;
        [Size(100)]
        public string BZ
        {
            get { return fBZ; }
            set { SetPropertyValue<string>("BZ", ref fBZ, value); }
        }


        DateTime fFKRQ;
        public DateTime FKRQ
        {
            get { return fFKRQ; }
            set { SetPropertyValue<DateTime>("FKRQ", ref fFKRQ, value); }
        }


        string fFKPZID;
        [Size(16)]
        public string FKPZID
        {
            get { return fFKPZID; }
            set { SetPropertyValue<string>("FKPZID", ref fFKPZID, value); }
        }



        string fCWBMMC;
        [Size(16)]
        public string CWBMMC
        {
            get { return fCWBMMC; }
            set { SetPropertyValue<string>("CWBMMC", ref fCWBMMC, value); }
        }

        string fDWMC;
        [Size(16)]
        public string DWMC
        {
            get { return fDWMC; }
            set { SetPropertyValue<string>("DWMC", ref fDWMC, value); }
        }

        string fJSFSMC;
        [Size(16)]
        public string JSFSMC
        {
            get { return fJSFSMC; }
            set { SetPropertyValue<string>("JSFSMC", ref fJSFSMC, value); }
        }

        string fCZRMC;
        [Size(16)]
        public string CZRMC
        {
            get { return fCZRMC; }
            set { SetPropertyValue<string>("CZRMC", ref fCZRMC, value); }
        }

        string fZTMC;
        [Size(16)]
        public string ZTMC
        {
            get { return fZTMC; }
            set { SetPropertyValue<string>("ZTMC", ref fZTMC, value); }
        }

        string fFKPZH;
        [Size(16)]
        public string FKPZH
        {
            get { return fFKPZH; }
            set { SetPropertyValue<string>("FKPZH", ref fFKPZH, value); }
        }

        string fZTIDMC;
        [Size(16)]
        public string ZTIDMC
        {
            get { return fZTIDMC; }
            set { SetPropertyValue<string>("ZTIDMC", ref fZTIDMC, value); }
        }

        public VIEW_JC_C_CGJSD(Session session) : base(session) { }
        public VIEW_JC_C_CGJSD() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }
    public class VIEW_JT_C_XSTSDMX : XPLiteObject
    {

        string fXSTSDMXID;
        [Key]
        [Size(16)]
        public string XSTSDMXID
        {
            get { return fXSTSDMXID; }
            set { SetPropertyValue<string>("XSTSDMXID", ref fXSTSDMXID, value); }
        }

        string fXSTSDID;
        [Size(16)]
        public string XSTSDID
        {
            get { return fXSTSDID; }
            set { SetPropertyValue<string>("XSTSDID", ref fXSTSDID, value); }
        }
        string fXSJSDID;
        [Size(16)]
        public string XSJSDID
        {
            get { return fXSJSDID; }
            set { SetPropertyValue<string>("XSJSDID", ref fXSJSDID, value); }
        }

        long fSL;
        public long SL
        {
            get { return fSL; }
            set { SetPropertyValue<long>("PSL", ref fSL, value); }
        }

        decimal fWSJE;
        public decimal WSJE
        {
            get { return fWSJE; }
            set { SetPropertyValue<decimal>("WSJE", ref fWSJE, value); }
        }


        decimal fSE;
        public decimal SE
        {
            get { return fSE; }
            set { SetPropertyValue<decimal>("SE", ref fSE, value); }
        }

        decimal fJSHJ;
        public decimal JSHJ
        {
            get { return fJSHJ; }
            set { SetPropertyValue<decimal>("JSHJ", ref fJSHJ, value); }
        }

        string fBZ;
        [Size(100)]
        public string BZ
        {
            get { return fBZ; }
            set { SetPropertyValue<string>("BZ", ref fBZ, value); }
        }

        string fXSJSDH;
        [Size(22)]
        public string XSJSDH
        {
            get { return fXSJSDH; }
            set { SetPropertyValue<string>("XSJSDH", ref fXSJSDH, value); }
        }
        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }
        long fSHL;
        public long SHL
        {
            get { return fSHL; }
            set { SetPropertyValue<long>("SHL", ref fSHL, value); }
        }

        string fXSTSDH;
        [Size(22)]
        public string XSTSDH
        {
            get { return fXSTSDH; }
            set { SetPropertyValue<string>("XSTSDH", ref fXSTSDH, value); }
        }

        public VIEW_JT_C_XSTSDMX(Session session) : base(session) { }
        public VIEW_JT_C_XSTSDMX() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }
    public class VIEW_JT_C_XSTSD : XPLiteObject
    {
        string fXSTSDID;
        [Key]
        [Size(16)]
        public string XSTSDID
        {
            get { return fXSTSDID; }
            set { SetPropertyValue<string>("XSTSDID", ref fXSTSDID, value); }
        }
        string fXSTSDH;
        [Size(22)]
        public string XSTSDH
        {
            get { return fXSTSDH; }
            set { SetPropertyValue<string>("XSTSDH", ref fXSTSDH, value); }
        }
        string fYWBMID;
        [Size(16)]
        public string YWBMID
        {
            get { return fYWBMID; }
            set { SetPropertyValue<string>("YWBMID", ref fYWBMID, value); }
        }
        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }
        string fKHID;
        [Size(16)]
        public string KHID
        {
            get { return fKHID; }
            set { SetPropertyValue<string>("KHID", ref fKHID, value); }
        }

        decimal fTSJE;
        public decimal TSJE
        {
            get { return fTSJE; }
            set { SetPropertyValue<decimal>("TSJE", ref fTSJE, value); }
        }



        string fKHMC;
        [Size(22)]
        public string KHMC
        {
            get { return fKHMC; }
            set { SetPropertyValue<string>("KHMC", ref fKHMC, value); }
        }


        string fSH;
        [Size(100)]
        public string SH
        {
            get { return fSH; }
            set { SetPropertyValue<string>("SH", ref fSH, value); }
        }

        string fDZ;
        [Size(100)]
        public string DZ
        {
            get { return fDZ; }
            set { SetPropertyValue<string>("KDZ", ref fDZ, value); }
        }
        string fKHYH;
        [Size(16)]
        public string KHYH
        {
            get { return fKHYH; }
            set { SetPropertyValue<string>("KHYH", ref fKHYH, value); }
        }





        string fZH;
        [Size(100)]
        public string ZH
        {
            get { return fZH; }
            set { SetPropertyValue<string>("ZH", ref fZH, value); }
        }
        string fDH;
        [Size(40)]
        public string DH
        {
            get { return fDH; }
            set { SetPropertyValue<string>("DH", ref fDH, value); }
        }


        string fKXNRID;
        [Size(16)]
        public string KXNRID
        {
            get { return fKXNRID; }
            set { SetPropertyValue<string>("KXNRID", ref fKXNRID, value); }
        }
        string fTSPJMCID;
        [Size(16)]
        public string TSPJMCID
        {
            get { return fTSPJMCID; }
            set { SetPropertyValue<string>("TSPJMCID", ref fTSPJMCID, value); }
        }

        string fSPFYQKID;
        [Size(16)]
        public string SPFYQKID
        {
            get { return fSPFYQKID; }
            set { SetPropertyValue<string>("SPFYQKID", ref fSPFYQKID, value); }
        }
        string fCZYID;
        [Size(16)]
        public string CZYID
        {
            get { return fCZYID; }
            set { SetPropertyValue<string>("CZYID", ref fCZYID, value); }
        }

        string fXSHTID;
        [Size(16)]
        public string XSHTID
        {
            get { return fXSHTID; }
            set { SetPropertyValue<string>("XSHTID", ref fXSHTID, value); }
        }
        string fZDR;
        [Size(22)]
        public string ZDR
        {
            get { return fZDR; }
            set { SetPropertyValue<string>("ZDR", ref fZDR, value); }
        }


        DateTime fZDRQ;
        public DateTime ZDRQ
        {
            get { return fZDRQ; }
            set { SetPropertyValue<DateTime>("ZDRQ", ref fZDRQ, value); }
        }

        DateTime fCZRQ;
        public DateTime CZRQ
        {
            get { return fCZRQ; }
            set { SetPropertyValue<DateTime>("CZRQ", ref fCZRQ, value); }
        }



        string fZT;
        [Size(16)]
        public string ZT
        {
            get { return fZT; }
            set { SetPropertyValue<string>("ZT", ref fZT, value); }
        }
        string fYZT;
        [Size(16)]
        public string YZT
        {
            get { return fYZT; }
            set { SetPropertyValue<string>("YZT", ref fYZT, value); }
        }
        string fBZ;
        public string BZ
        {
            get { return fBZ; }
            set { SetPropertyValue<string>("BZ", ref fBZ, value); }
        }



        string fXSFPID;
        [Size(16)]
        public string XSFPID
        {
            get { return fXSFPID; }
            set { SetPropertyValue<string>("XSFPID", ref fXSFPID, value); }
        }


        string fCWBMMC;
        [Size(22)]
        public string CWBMMC
        {
            get { return fCWBMMC; }
            set { SetPropertyValue<string>("CWBMMC", ref fCWBMMC, value); }
        }




        string fZTIDMC;
        [Size(22)]
        public string ZTIDMC
        {
            get { return fZTIDMC; }
            set { SetPropertyValue<string>("ZTIDMC", ref fZTIDMC, value); }
        }



        string fZTMC;
        [Size(22)]
        public string ZTMC
        {
            get { return fZTMC; }
            set { SetPropertyValue<string>("ZTMC", ref fZTMC, value); }
        }



        string fCZRMC;
        [Size(12)]
        public string CZRMC
        {
            get { return fCZRMC; }
            set { SetPropertyValue<string>("CZRMC", ref fCZRMC, value); }
        }

        string fZDRMC;
        [Size(12)]
        public string ZDRMC
        {
            get { return fCZRMC; }
            set { SetPropertyValue<string>("ZDRMC", ref fZDRMC, value); }
        }

        string fXSFPH;
        [Size(22)]
        public string XSFPH
        {
            get { return fXSFPH; }
            set { SetPropertyValue<string>("XSFPH", ref fXSFPH, value); }
        }
        string fSJPH;
        [Size(22)]
        public string SJPH
        {
            get { return fSJPH; }
            set { SetPropertyValue<string>("SJPH", ref fSJPH, value); }
        }


        string fKXNRBH;
        [Size(22)]
        public string KXNRBH
        {
            get { return fKXNRBH; }
            set { SetPropertyValue<string>("KXNRBH", ref fKXNRBH, value); }
        }

        string fTSPJMCH;
        [Size(22)]
        public string TSPJMCH
        {
            get { return fTSPJMCH; }
            set { SetPropertyValue<string>("TSPJMCH", ref fTSPJMCH, value); }
        }

        string fSPFYQKDH;
        [Size(22)]
        public string SPFYQKDH
        {
            get { return fSPFYQKDH; }
            set { SetPropertyValue<string>("SPFYQKDH", ref fSPFYQKDH, value); }
        }








        public VIEW_JT_C_XSTSD(Session session) : base(session) { }
        public VIEW_JT_C_XSTSD() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }


    public class VIEW_JT_C_ZTBMSPKFMX : XPLiteObject
    {

        string fZTBMSPKFMXID;
        [Key]
        [Size(16)]
        public string ZTBMSPKFMXID
        {
            get { return fZTBMSPKFMXID; }
            set { SetPropertyValue<string>("ZTBMSPKFMXID", ref fZTBMSPKFMXID, value); }
        }


        string fZTBMSPKFTZID;
        [Size(16)]
        public string ZTBMSPKFTZID
        {
            get { return fZTBMSPKFTZID; }
            set { SetPropertyValue<string>("ZTBMSPKFTZID", ref fZTBMSPKFTZID, value); }
        }

        string fZTBMSPTZID;
        [Size(16)]
        public string ZTBMSPTZID
        {
            get { return fZTBMSPTZID; }
            set { SetPropertyValue<string>("ZTBMSPTZID", ref fZTBMSPTZID, value); }
        }


        string fZTBMTZID;
        [Size(16)]
        public string ZTBMTZID
        {
            get { return fZTBMTZID; }
            set { SetPropertyValue<string>("ZTBMTZID", ref fZTBMTZID, value); }
        }

        string fZTTZID;
        [Size(16)]
        public string ZTTZID
        {
            get { return fZTTZID; }
            set { SetPropertyValue<string>("ZTTZID", ref fZTTZID, value); }
        }

        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }

        string fBMID;
        [Size(16)]
        public string BMID
        {
            get { return fBMID; }
            set { SetPropertyValue<string>("BMID", ref fBMID, value); }
        }

        string fWLBMID;
        [Size(16)]
        public string WLBMID
        {
            get { return fWLBMID; }
            set { SetPropertyValue<string>("WLBMID", ref fWLBMID, value); }
        }




        string fSPXXID;
        [Size(16)]
        public string SPXXID
        {
            get { return fSPXXID; }
            set { SetPropertyValue<string>("SPXXID", ref fSPXXID, value); }
        }

        long fQCKC;
        public long QCKC
        {
            get { return fQCKC; }
            set { SetPropertyValue<long>("QCKC", ref fQCKC, value); }
        }

        decimal fQCMY;
        public decimal QCMY
        {
            get { return fQCMY; }
            set { SetPropertyValue<decimal>("QCMY", ref fQCMY, value); }
        }

        decimal fQCSY;
        public decimal QCSY
        {
            get { return fQCSY; }
            set { SetPropertyValue<decimal>("QCSY", ref fQCSY, value); }
        }

        long fJHSL;
        public long JHSL
        {
            get { return fJHSL; }
            set { SetPropertyValue<long>("JHSL", ref fJHSL, value); }
        }

        decimal fJHMY;
        public decimal JHMY
        {
            get { return fJHMY; }
            set { SetPropertyValue<decimal>("JHMY", ref fJHMY, value); }
        }

        decimal fJHSY;
        public decimal JHSY
        {
            get { return fJHSY; }
            set { SetPropertyValue<decimal>("JHSY", ref fJHSY, value); }
        }

        long fXTSL;
        public long XTSL
        {
            get { return fXTSL; }
            set { SetPropertyValue<long>("XTSL", ref fXTSL, value); }
        }

        decimal fXTMY;
        public decimal XTMY
        {
            get { return fXTMY; }
            set { SetPropertyValue<decimal>("XTMY", ref fXTMY, value); }
        }

        decimal fXTSY;
        public decimal XTSY
        {
            get { return fXTSY; }
            set { SetPropertyValue<decimal>("XTSY", ref fXTSY, value); }
        }


        long fDRSL;
        public long DRSL
        {
            get { return fDRSL; }
            set { SetPropertyValue<long>("DRSL", ref fDRSL, value); }
        }

        decimal fDRMY;
        public decimal DRMY
        {
            get { return fDRMY; }
            set { SetPropertyValue<decimal>("DRMY", ref fDRMY, value); }
        }

        decimal fDRSY;
        public decimal DRSY
        {
            get { return fDRSY; }
            set { SetPropertyValue<decimal>("DRSY", ref fDRSY, value); }
        }

        long fJRSL;
        public long JRSL
        {
            get { return fJRSL; }
            set { SetPropertyValue<long>("JRSL", ref fJRSL, value); }
        }

        decimal fJRMY;
        public decimal JRMY
        {
            get { return fJRMY; }
            set { SetPropertyValue<decimal>("JRMY", ref fJRMY, value); }
        }

        decimal fJRSY;
        public decimal JRSY
        {
            get { return fJRSY; }
            set { SetPropertyValue<decimal>("JRSY", ref fJRSY, value); }
        }

        long fXSSL;
        public long XSSL
        {
            get { return fXSSL; }
            set { SetPropertyValue<long>("XSSL", ref fXSSL, value); }
        }

        decimal fXSMY;
        public decimal XSMY
        {
            get { return fXSMY; }
            set { SetPropertyValue<decimal>("XSMY", ref fXSMY, value); }
        }

        decimal fXSSY;
        public decimal XSSY
        {
            get { return fXSSY; }
            set { SetPropertyValue<decimal>("XSSY", ref fXSSY, value); }
        }


        long fJTSL;
        public long JTSL
        {
            get { return fJTSL; }
            set { SetPropertyValue<long>("JTSL", ref fJTSL, value); }
        }

        decimal fJTMY;
        public decimal JTMY
        {
            get { return fJTMY; }
            set { SetPropertyValue<decimal>("JTMY", ref fJTMY, value); }
        }

        decimal fJTSY;
        public decimal JTSY
        {
            get { return fJTSY; }
            set { SetPropertyValue<decimal>("JTSY", ref fJTSY, value); }
        }

        long fDCSL;
        public long DCSL
        {
            get { return fDCSL; }
            set { SetPropertyValue<long>("DCSL", ref fDCSL, value); }
        }

        decimal fDCMY;
        public decimal DCMY
        {
            get { return fDCMY; }
            set { SetPropertyValue<decimal>("DCMY", ref fDCMY, value); }
        }

        decimal fDCSY;
        public decimal DCSY
        {
            get { return fDCSY; }
            set { SetPropertyValue<decimal>("DCSY", ref fDCSY, value); }
        }







        long fJCSL;
        public long JCSL
        {
            get { return fJCSL; }
            set { SetPropertyValue<long>("JCSL", ref fJCSL, value); }
        }

        decimal fJCMY;
        public decimal JCMY
        {
            get { return fJCMY; }
            set { SetPropertyValue<decimal>("JCMY", ref fJCMY, value); }
        }

        decimal fJCSY;
        public decimal JCSY
        {
            get { return fJCSY; }
            set { SetPropertyValue<decimal>("JCSY", ref fJCSY, value); }
        }


        long fBFSL;
        public long BFSL
        {
            get { return fBFSL; }
            set { SetPropertyValue<long>("BFSL", ref fBFSL, value); }
        }

        decimal fBFMY;
        public decimal BFMY
        {
            get { return fBFMY; }
            set { SetPropertyValue<decimal>("BFMY", ref fBFMY, value); }
        }

        decimal fBFSY;
        public decimal BFSY
        {
            get { return fBFSY; }
            set { SetPropertyValue<decimal>("BFSY", ref fBFSY, value); }
        }

        long fSYSL;
        public long SYSL
        {
            get { return fSYSL; }
            set { SetPropertyValue<long>("SYSL", ref fSYSL, value); }
        }

        decimal fSYMY;
        public decimal SYMY
        {
            get { return fSYMY; }
            set { SetPropertyValue<decimal>("SYMY", ref fSYMY, value); }
        }

        decimal fSYSY;
        public decimal SYSY
        {
            get { return fSYSY; }
            set { SetPropertyValue<decimal>("SYSY", ref fSYSY, value); }
        }


        long fQMKC;
        public long QMKC
        {
            get { return fQMKC; }
            set { SetPropertyValue<long>("QMKC", ref fQMKC, value); }
        }

        decimal fQMMY;
        public decimal QMMY
        {
            get { return fQMMY; }
            set { SetPropertyValue<decimal>("QMMY", ref fQMMY, value); }
        }

        decimal fQMSY;
        public decimal QMSY
        {
            get { return fQMSY; }
            set { SetPropertyValue<decimal>("QMSY", ref fQMSY, value); }
        }


        long fZRSL;
        public long ZRSL
        {
            get { return fZRSL; }
            set { SetPropertyValue<long>("ZRSL", ref fZRSL, value); }
        }

        decimal fZRMY;
        public decimal ZRMY
        {
            get { return fZRMY; }
            set { SetPropertyValue<decimal>("ZRMY", ref fZRMY, value); }
        }

        decimal fZRSY;
        public decimal ZRSY
        {
            get { return fZRSY; }
            set { SetPropertyValue<decimal>("ZRSY", ref fZRSY, value); }
        }

        long fZCSL;
        public long ZCSL
        {
            get { return fZCSL; }
            set { SetPropertyValue<long>("ZCSL", ref fZCSL, value); }
        }

        decimal fZCMY;
        public decimal ZCMY
        {
            get { return fZCMY; }
            set { SetPropertyValue<decimal>("ZCMY", ref fZCMY, value); }
        }

        decimal fZCSY;
        public decimal ZCSY
        {
            get { return fZCSY; }
            set { SetPropertyValue<decimal>("ZCSY", ref fZCSY, value); }
        }





        string fZT;
        [Size(4)]
        public string ZT
        {
            get { return fZT; }
            set { SetPropertyValue<string>("ZT", ref fZT, value); }
        }

        string fYZT;
        [Size(4)]
        public string YZT
        {
            get { return fYZT; }
            set { SetPropertyValue<string>("YZT", ref fYZT, value); }
        }

        string fBZ;
        [Size(100)]
        public string BZ
        {
            get { return fBZ; }
            set { SetPropertyValue<string>("BZ", ref fBZ, value); }
        }

        long fPFSL;
        public long PFSL
        {
            get { return fPFSL; }
            set { SetPropertyValue<long>("PFSL", ref fPFSL, value); }
        }

        decimal fPFMY;
        public decimal PFMY
        {
            get { return fPFMY; }
            set { SetPropertyValue<decimal>("PFMY", ref fPFMY, value); }
        }

        decimal fPFSY;
        public decimal PFSY
        {
            get { return fPFSY; }
            set { SetPropertyValue<decimal>("PFSY", ref fPFSY, value); }
        }

        long fYTSL;
        public long YTSL
        {
            get { return fYTSL; }
            set { SetPropertyValue<long>("YTSL", ref fYTSL, value); }
        }

        decimal fYTSY;
        public decimal YTSY
        {
            get { return fYTSY; }
            set { SetPropertyValue<decimal>("YTSY", ref fYTSY, value); }
        }

        decimal fYTMY;
        public decimal YTMY
        {
            get { return fYTMY; }
            set { SetPropertyValue<decimal>("YTMY", ref fYTMY, value); }
        }


        decimal fDJ;
        public decimal DJ
        {
            get { return fDJ; }
            set { SetPropertyValue<decimal>("DJ", ref fDJ, value); }
        }



        string fZTIDMC;
        [Size(22)]
        public string ZTIDMC
        {
            get { return fZTIDMC; }
            set { SetPropertyValue<string>("ZTIDMC", ref fZTIDMC, value); }
        }


        string fZTMC;
        [Size(22)]
        public string ZTMC
        {
            get { return fZTMC; }
            set { SetPropertyValue<string>("ZTMC", ref fZTMC, value); }
        }

        string fBMMC;
        [Size(22)]
        public string BMMC
        {
            get { return fBMMC; }
            set { SetPropertyValue<string>("BMMC", ref fBMMC, value); }
        }

        string fSPMC;
        [Size(22)]
        public string SPMC
        {
            get { return fSPMC; }
            set { SetPropertyValue<string>("SPMC", ref fSPMC, value); }
        }

        string fWLBMMC;
        [Size(22)]
        public string WLBMMC
        {
            get { return fWLBMMC; }
            set { SetPropertyValue<string>("WLBMMC", ref fWLBMMC, value); }
        }


        string fGYSID;
        [Size(16)]
        public string GYSID
        {
            get { return fGYSID; }
            set { SetPropertyValue<string>("GYSID", ref fGYSID, value); }
        }


        string fJHFSID;
        [Size(16)]
        public string JHFSID
        {
            get { return fJHFSID; }
            set { SetPropertyValue<string>("JHFSID", ref fJHFSID, value); }
        }


        decimal fJZ;
        public decimal JZ
        {
            get { return fJZ; }
            set { SetPropertyValue<decimal>("JZ", ref fJZ, value); }
        }

        decimal fJJ;
        public decimal JJ
        {
            get { return fJJ; }
            set { SetPropertyValue<decimal>("JJ", ref fJJ, value); }
        }

        decimal fXZ;
        public decimal XZ
        {
            get { return fXZ; }
            set { SetPropertyValue<decimal>("XZ", ref fXZ, value); }
        }


        decimal fXJ;
        public decimal XJ
        {
            get { return fXJ; }
            set { SetPropertyValue<decimal>("XJ", ref fXJ, value); }
        }




        string fZDDM;
        [Size(15)]
        public string ZDDM
        {
            get { return fZDDM; }
            set { SetPropertyValue<string>("ZDDM", ref fZDDM, value); }
        }

        string fJTBMSPKFMXID;
        [Size(15)]
        public string JTBMSPKFMXID
        {
            get { return fJTBMSPKFMXID; }
            set { SetPropertyValue<string>("JTBMSPKFMXID", ref fJTBMSPKFMXID, value); }
        }


        DateTime fJZRQ;
        public DateTime JZRQ
        {
            get { return fJZRQ; }
            set { SetPropertyValue<DateTime>("JZRQ", ref fJZRQ, value); }
        }





        public VIEW_JT_C_ZTBMSPKFMX(Session session) : base(session) { }
        public VIEW_JT_C_ZTBMSPKFMX() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }
    public class VIEW_JT_C_ZTBMSPKFTZ : XPLiteObject
    {


        string fZTBMSPKFTZID;
        [Key]
        [Size(16)]
        public string ZTBMSPKFTZID
        {
            get { return fZTBMSPKFTZID; }
            set { SetPropertyValue<string>("ZTBMSPKFTZID", ref fZTBMSPKFTZID, value); }
        }

        string fZTBMSPTZID;
        [Size(16)]
        public string ZTBMSPTZID
        {
            get { return fZTBMSPTZID; }
            set { SetPropertyValue<string>("ZTBMSPTZID", ref fZTBMSPTZID, value); }
        }


        string fZTBMTZID;
        [Size(16)]
        public string ZTBMTZID
        {
            get { return fZTBMTZID; }
            set { SetPropertyValue<string>("ZTBMTZID", ref fZTBMTZID, value); }
        }

        string fZTTZID;
        [Size(16)]
        public string ZTTZID
        {
            get { return fZTTZID; }
            set { SetPropertyValue<string>("ZTTZID", ref fZTTZID, value); }
        }

        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }

        string fBMID;
        [Size(16)]
        public string BMID
        {
            get { return fBMID; }
            set { SetPropertyValue<string>("BMID", ref fBMID, value); }
        }

        string fWLBMID;
        [Size(16)]
        public string WLBMID
        {
            get { return fWLBMID; }
            set { SetPropertyValue<string>("WLBMID", ref fWLBMID, value); }
        }




        string fSPXXID;
        [Size(16)]
        public string SPXXID
        {
            get { return fSPXXID; }
            set { SetPropertyValue<string>("SPXXID", ref fSPXXID, value); }
        }

        long fQCKC;
        public long QCKC
        {
            get { return fQCKC; }
            set { SetPropertyValue<long>("QCKC", ref fQCKC, value); }
        }

        decimal fQCMY;
        public decimal QCMY
        {
            get { return fQCMY; }
            set { SetPropertyValue<decimal>("QCMY", ref fQCMY, value); }
        }

        decimal fQCSY;
        public decimal QCSY
        {
            get { return fQCSY; }
            set { SetPropertyValue<decimal>("QCSY", ref fQCSY, value); }
        }

        long fJHSL;
        public long JHSL
        {
            get { return fJHSL; }
            set { SetPropertyValue<long>("JHSL", ref fJHSL, value); }
        }

        decimal fJHMY;
        public decimal JHMY
        {
            get { return fJHMY; }
            set { SetPropertyValue<decimal>("JHMY", ref fJHMY, value); }
        }

        decimal fJHSY;
        public decimal JHSY
        {
            get { return fJHSY; }
            set { SetPropertyValue<decimal>("JHSY", ref fJHSY, value); }
        }

        long fXTSL;
        public long XTSL
        {
            get { return fXTSL; }
            set { SetPropertyValue<long>("XTSL", ref fXTSL, value); }
        }

        decimal fXTMY;
        public decimal XTMY
        {
            get { return fXTMY; }
            set { SetPropertyValue<decimal>("XTMY", ref fXTMY, value); }
        }

        decimal fXTSY;
        public decimal XTSY
        {
            get { return fXTSY; }
            set { SetPropertyValue<decimal>("XTSY", ref fXTSY, value); }
        }


        long fDRSL;
        public long DRSL
        {
            get { return fDRSL; }
            set { SetPropertyValue<long>("DRSL", ref fDRSL, value); }
        }

        decimal fDRMY;
        public decimal DRMY
        {
            get { return fDRMY; }
            set { SetPropertyValue<decimal>("DRMY", ref fDRMY, value); }
        }

        decimal fDRSY;
        public decimal DRSY
        {
            get { return fDRSY; }
            set { SetPropertyValue<decimal>("DRSY", ref fDRSY, value); }
        }

        long fJRSL;
        public long JRSL
        {
            get { return fJRSL; }
            set { SetPropertyValue<long>("JRSL", ref fJRSL, value); }
        }

        decimal fJRMY;
        public decimal JRMY
        {
            get { return fJRMY; }
            set { SetPropertyValue<decimal>("JRMY", ref fJRMY, value); }
        }

        decimal fJRSY;
        public decimal JRSY
        {
            get { return fJRSY; }
            set { SetPropertyValue<decimal>("JRSY", ref fJRSY, value); }
        }

        long fXSSL;
        public long XSSL
        {
            get { return fXSSL; }
            set { SetPropertyValue<long>("XSSL", ref fXSSL, value); }
        }

        decimal fXSMY;
        public decimal XSMY
        {
            get { return fXSMY; }
            set { SetPropertyValue<decimal>("XSMY", ref fXSMY, value); }
        }

        decimal fXSSY;
        public decimal XSSY
        {
            get { return fXSSY; }
            set { SetPropertyValue<decimal>("XSSY", ref fXSSY, value); }
        }


        long fJTSL;
        public long JTSL
        {
            get { return fJTSL; }
            set { SetPropertyValue<long>("JTSL", ref fJTSL, value); }
        }

        decimal fJTMY;
        public decimal JTMY
        {
            get { return fJTMY; }
            set { SetPropertyValue<decimal>("JTMY", ref fJTMY, value); }
        }

        decimal fJTSY;
        public decimal JTSY
        {
            get { return fJTSY; }
            set { SetPropertyValue<decimal>("JTSY", ref fJTSY, value); }
        }

        long fDCSL;
        public long DCSL
        {
            get { return fDCSL; }
            set { SetPropertyValue<long>("DCSL", ref fDCSL, value); }
        }

        decimal fDCMY;
        public decimal DCMY
        {
            get { return fDCMY; }
            set { SetPropertyValue<decimal>("DCMY", ref fDCMY, value); }
        }

        decimal fDCSY;
        public decimal DCSY
        {
            get { return fDCSY; }
            set { SetPropertyValue<decimal>("DCSY", ref fDCSY, value); }
        }







        long fJCSL;
        public long JCSL
        {
            get { return fJCSL; }
            set { SetPropertyValue<long>("JCSL", ref fJCSL, value); }
        }

        decimal fJCMY;
        public decimal JCMY
        {
            get { return fJCMY; }
            set { SetPropertyValue<decimal>("JCMY", ref fJCMY, value); }
        }

        decimal fJCSY;
        public decimal JCSY
        {
            get { return fJCSY; }
            set { SetPropertyValue<decimal>("JCSY", ref fJCSY, value); }
        }


        long fBFSL;
        public long BFSL
        {
            get { return fBFSL; }
            set { SetPropertyValue<long>("BFSL", ref fBFSL, value); }
        }

        decimal fBFMY;
        public decimal BFMY
        {
            get { return fBFMY; }
            set { SetPropertyValue<decimal>("BFMY", ref fBFMY, value); }
        }

        decimal fBFSY;
        public decimal BFSY
        {
            get { return fBFSY; }
            set { SetPropertyValue<decimal>("BFSY", ref fBFSY, value); }
        }

        long fSYSL;
        public long SYSL
        {
            get { return fSYSL; }
            set { SetPropertyValue<long>("SYSL", ref fSYSL, value); }
        }

        decimal fSYMY;
        public decimal SYMY
        {
            get { return fSYMY; }
            set { SetPropertyValue<decimal>("SYMY", ref fSYMY, value); }
        }

        decimal fSYSY;
        public decimal SYSY
        {
            get { return fSYSY; }
            set { SetPropertyValue<decimal>("SYSY", ref fSYSY, value); }
        }


        long fQMKC;
        public long QMKC
        {
            get { return fQMKC; }
            set { SetPropertyValue<long>("QMKC", ref fQMKC, value); }
        }

        decimal fQMMY;
        public decimal QMMY
        {
            get { return fQMMY; }
            set { SetPropertyValue<decimal>("QMMY", ref fQMMY, value); }
        }

        decimal fQMSY;
        public decimal QMSY
        {
            get { return fQMSY; }
            set { SetPropertyValue<decimal>("QMSY", ref fQMSY, value); }
        }


        long fZRSL;
        public long ZRSL
        {
            get { return fZRSL; }
            set { SetPropertyValue<long>("ZRSL", ref fZRSL, value); }
        }

        decimal fZRMY;
        public decimal ZRMY
        {
            get { return fZRMY; }
            set { SetPropertyValue<decimal>("ZRMY", ref fZRMY, value); }
        }

        decimal fZRSY;
        public decimal ZRSY
        {
            get { return fZRSY; }
            set { SetPropertyValue<decimal>("ZRSY", ref fZRSY, value); }
        }

        long fZCSL;
        public long ZCSL
        {
            get { return fZCSL; }
            set { SetPropertyValue<long>("ZCSL", ref fZCSL, value); }
        }

        decimal fZCMY;
        public decimal ZCMY
        {
            get { return fZCMY; }
            set { SetPropertyValue<decimal>("ZCMY", ref fZCMY, value); }
        }

        decimal fZCSY;
        public decimal ZCSY
        {
            get { return fZCSY; }
            set { SetPropertyValue<decimal>("ZCSY", ref fZCSY, value); }
        }





        string fZT;
        [Size(4)]
        public string ZT
        {
            get { return fZT; }
            set { SetPropertyValue<string>("ZT", ref fZT, value); }
        }

        string fYZT;
        [Size(4)]
        public string YZT
        {
            get { return fYZT; }
            set { SetPropertyValue<string>("YZT", ref fYZT, value); }
        }

        string fBZ;
        [Size(100)]
        public string BZ
        {
            get { return fBZ; }
            set { SetPropertyValue<string>("BZ", ref fBZ, value); }
        }

        long fPFSL;
        public long PFSL
        {
            get { return fPFSL; }
            set { SetPropertyValue<long>("PFSL", ref fPFSL, value); }
        }

        decimal fPFMY;
        public decimal PFMY
        {
            get { return fPFMY; }
            set { SetPropertyValue<decimal>("PFMY", ref fPFMY, value); }
        }

        decimal fPFSY;
        public decimal PFSY
        {
            get { return fPFSY; }
            set { SetPropertyValue<decimal>("PFSY", ref fPFSY, value); }
        }

        long fYTSL;
        public long YTSL
        {
            get { return fYTSL; }
            set { SetPropertyValue<long>("YTSL", ref fYTSL, value); }
        }

        decimal fYTSY;
        public decimal YTSY
        {
            get { return fYTSY; }
            set { SetPropertyValue<decimal>("YTSY", ref fYTSY, value); }
        }

        decimal fYTMY;
        public decimal YTMY
        {
            get { return fYTMY; }
            set { SetPropertyValue<decimal>("YTMY", ref fYTMY, value); }
        }


        decimal fDJ;
        public decimal DJ
        {
            get { return fDJ; }
            set { SetPropertyValue<decimal>("DJ", ref fDJ, value); }
        }



        string fZTIDMC;
        [Size(22)]
        public string ZTIDMC
        {
            get { return fZTIDMC; }
            set { SetPropertyValue<string>("ZTIDMC", ref fZTIDMC, value); }
        }


        string fZTMC;
        [Size(22)]
        public string ZTMC
        {
            get { return fZTMC; }
            set { SetPropertyValue<string>("ZTMC", ref fZTMC, value); }
        }

        string fBMMC;
        [Size(22)]
        public string BMMC
        {
            get { return fBMMC; }
            set { SetPropertyValue<string>("BMMC", ref fBMMC, value); }
        }

        string fSPMC;
        [Size(22)]
        public string SPMC
        {
            get { return fSPMC; }
            set { SetPropertyValue<string>("SPMC", ref fSPMC, value); }
        }

        string fWLBMMC;
        [Size(22)]
        public string WLBMMC
        {
            get { return fWLBMMC; }
            set { SetPropertyValue<string>("WLBMMC", ref fWLBMMC, value); }
        }




        public VIEW_JT_C_ZTBMSPKFTZ(Session session) : base(session) { }
        public VIEW_JT_C_ZTBMSPKFTZ() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }
    public class VIEW_JT_C_ZTBMSPTZ : XPLiteObject
    {

        string fZTBMSPTZID;
        [Key]
        [Size(16)]
        public string ZTBMSPTZID
        {
            get { return fZTBMSPTZID; }
            set { SetPropertyValue<string>("ZTBMSPTZID", ref fZTBMSPTZID, value); }
        }


        string fZTBMTZID;
        [Size(16)]
        public string ZTBMTZID
        {
            get { return fZTBMTZID; }
            set { SetPropertyValue<string>("ZTBMTZID", ref fZTBMTZID, value); }
        }

        string fZTTZID;
        [Size(16)]
        public string ZTTZID
        {
            get { return fZTTZID; }
            set { SetPropertyValue<string>("ZTTZID", ref fZTTZID, value); }
        }

        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }

        string fBMID;
        [Size(16)]
        public string BMID
        {
            get { return fBMID; }
            set { SetPropertyValue<string>("BMID", ref fBMID, value); }
        }

        string fSPXXID;
        [Size(16)]
        public string SPXXID
        {
            get { return fSPXXID; }
            set { SetPropertyValue<string>("SPXXID", ref fSPXXID, value); }
        }

        long fQCKC;
        public long QCKC
        {
            get { return fQCKC; }
            set { SetPropertyValue<long>("QCKC", ref fQCKC, value); }
        }

        decimal fQCMY;
        public decimal QCMY
        {
            get { return fQCMY; }
            set { SetPropertyValue<decimal>("QCMY", ref fQCMY, value); }
        }

        decimal fQCSY;
        public decimal QCSY
        {
            get { return fQCSY; }
            set { SetPropertyValue<decimal>("QCSY", ref fQCSY, value); }
        }

        long fJHSL;
        public long JHSL
        {
            get { return fJHSL; }
            set { SetPropertyValue<long>("JHSL", ref fJHSL, value); }
        }

        decimal fJHMY;
        public decimal JHMY
        {
            get { return fJHMY; }
            set { SetPropertyValue<decimal>("JHMY", ref fJHMY, value); }
        }

        decimal fJHSY;
        public decimal JHSY
        {
            get { return fJHSY; }
            set { SetPropertyValue<decimal>("JHSY", ref fJHSY, value); }
        }

        long fXTSL;
        public long XTSL
        {
            get { return fXTSL; }
            set { SetPropertyValue<long>("XTSL", ref fXTSL, value); }
        }

        decimal fXTMY;
        public decimal XTMY
        {
            get { return fXTMY; }
            set { SetPropertyValue<decimal>("XTMY", ref fXTMY, value); }
        }

        decimal fXTSY;
        public decimal XTSY
        {
            get { return fXTSY; }
            set { SetPropertyValue<decimal>("XTSY", ref fXTSY, value); }
        }


        long fDRSL;
        public long DRSL
        {
            get { return fDRSL; }
            set { SetPropertyValue<long>("DRSL", ref fDRSL, value); }
        }

        decimal fDRMY;
        public decimal DRMY
        {
            get { return fDRMY; }
            set { SetPropertyValue<decimal>("DRMY", ref fDRMY, value); }
        }

        decimal fDRSY;
        public decimal DRSY
        {
            get { return fDRSY; }
            set { SetPropertyValue<decimal>("DRSY", ref fDRSY, value); }
        }

        long fJRSL;
        public long JRSL
        {
            get { return fJRSL; }
            set { SetPropertyValue<long>("JRSL", ref fJRSL, value); }
        }

        decimal fJRMY;
        public decimal JRMY
        {
            get { return fJRMY; }
            set { SetPropertyValue<decimal>("JRMY", ref fJRMY, value); }
        }

        decimal fJRSY;
        public decimal JRSY
        {
            get { return fJRSY; }
            set { SetPropertyValue<decimal>("JRSY", ref fJRSY, value); }
        }

        long fXSSL;
        public long XSSL
        {
            get { return fXSSL; }
            set { SetPropertyValue<long>("XSSL", ref fXSSL, value); }
        }

        decimal fXSMY;
        public decimal XSMY
        {
            get { return fXSMY; }
            set { SetPropertyValue<decimal>("XSMY", ref fXSMY, value); }
        }

        decimal fXSSY;
        public decimal XSSY
        {
            get { return fXSSY; }
            set { SetPropertyValue<decimal>("XSSY", ref fXSSY, value); }
        }


        long fJTSL;
        public long JTSL
        {
            get { return fJTSL; }
            set { SetPropertyValue<long>("JTSL", ref fJTSL, value); }
        }

        decimal fJTMY;
        public decimal JTMY
        {
            get { return fJTMY; }
            set { SetPropertyValue<decimal>("JTMY", ref fJTMY, value); }
        }

        decimal fJTSY;
        public decimal JTSY
        {
            get { return fJTSY; }
            set { SetPropertyValue<decimal>("JTSY", ref fJTSY, value); }
        }

        long fDCSL;
        public long DCSL
        {
            get { return fDCSL; }
            set { SetPropertyValue<long>("DCSL", ref fDCSL, value); }
        }

        decimal fDCMY;
        public decimal DCMY
        {
            get { return fDCMY; }
            set { SetPropertyValue<decimal>("DCMY", ref fDCMY, value); }
        }

        decimal fDCSY;
        public decimal DCSY
        {
            get { return fDCSY; }
            set { SetPropertyValue<decimal>("DCSY", ref fDCSY, value); }
        }







        long fJCSL;
        public long JCSL
        {
            get { return fJCSL; }
            set { SetPropertyValue<long>("JCSL", ref fJCSL, value); }
        }

        decimal fJCMY;
        public decimal JCMY
        {
            get { return fJCMY; }
            set { SetPropertyValue<decimal>("JCMY", ref fJCMY, value); }
        }

        decimal fJCSY;
        public decimal JCSY
        {
            get { return fJCSY; }
            set { SetPropertyValue<decimal>("JCSY", ref fJCSY, value); }
        }


        long fBFSL;
        public long BFSL
        {
            get { return fBFSL; }
            set { SetPropertyValue<long>("BFSL", ref fBFSL, value); }
        }

        decimal fBFMY;
        public decimal BFMY
        {
            get { return fBFMY; }
            set { SetPropertyValue<decimal>("BFMY", ref fBFMY, value); }
        }

        decimal fBFSY;
        public decimal BFSY
        {
            get { return fBFSY; }
            set { SetPropertyValue<decimal>("BFSY", ref fBFSY, value); }
        }

        long fSYSL;
        public long SYSL
        {
            get { return fSYSL; }
            set { SetPropertyValue<long>("SYSL", ref fSYSL, value); }
        }

        decimal fSYMY;
        public decimal SYMY
        {
            get { return fSYMY; }
            set { SetPropertyValue<decimal>("SYMY", ref fSYMY, value); }
        }

        decimal fSYSY;
        public decimal SYSY
        {
            get { return fSYSY; }
            set { SetPropertyValue<decimal>("SYSY", ref fSYSY, value); }
        }


        long fQMKC;
        public long QMKC
        {
            get { return fQMKC; }
            set { SetPropertyValue<long>("QMKC", ref fQMKC, value); }
        }

        decimal fQMMY;
        public decimal QMMY
        {
            get { return fQMMY; }
            set { SetPropertyValue<decimal>("QMMY", ref fQMMY, value); }
        }

        decimal fQMSY;
        public decimal QMSY
        {
            get { return fQMSY; }
            set { SetPropertyValue<decimal>("QMSY", ref fQMSY, value); }
        }


        long fZRSL;
        public long ZRSL
        {
            get { return fZRSL; }
            set { SetPropertyValue<long>("ZRSL", ref fZRSL, value); }
        }

        decimal fZRMY;
        public decimal ZRMY
        {
            get { return fZRMY; }
            set { SetPropertyValue<decimal>("ZRMY", ref fZRMY, value); }
        }

        decimal fZRSY;
        public decimal ZRSY
        {
            get { return fZRSY; }
            set { SetPropertyValue<decimal>("ZRSY", ref fZRSY, value); }
        }

        long fZCSL;
        public long ZCSL
        {
            get { return fZCSL; }
            set { SetPropertyValue<long>("ZCSL", ref fZCSL, value); }
        }

        decimal fZCMY;
        public decimal ZCMY
        {
            get { return fZCMY; }
            set { SetPropertyValue<decimal>("ZCMY", ref fZCMY, value); }
        }

        decimal fZCSY;
        public decimal ZCSY
        {
            get { return fZCSY; }
            set { SetPropertyValue<decimal>("ZCSY", ref fZCSY, value); }
        }





        string fZT;
        [Size(4)]
        public string ZT
        {
            get { return fZT; }
            set { SetPropertyValue<string>("ZT", ref fZT, value); }
        }

        string fYZT;
        [Size(4)]
        public string YZT
        {
            get { return fYZT; }
            set { SetPropertyValue<string>("YZT", ref fYZT, value); }
        }

        string fBZ;
        [Size(100)]
        public string BZ
        {
            get { return fBZ; }
            set { SetPropertyValue<string>("BZ", ref fBZ, value); }
        }

        string fZTIDMC;
        [Size(22)]
        public string ZTIDMC
        {
            get { return fZTIDMC; }
            set { SetPropertyValue<string>("ZTIDMC", ref fZTIDMC, value); }
        }


        string fZTMC;
        [Size(22)]
        public string ZTMC
        {
            get { return fZTMC; }
            set { SetPropertyValue<string>("ZTMC", ref fZTMC, value); }
        }

        string fBMMC;
        [Size(22)]
        public string BMMC
        {
            get { return fBMMC; }
            set { SetPropertyValue<string>("BMMC", ref fBMMC, value); }
        }

        string fSPMC;
        [Size(22)]
        public string SPMC
        {
            get { return fSPMC; }
            set { SetPropertyValue<string>("SPMC", ref fSPMC, value); }
        }




        public VIEW_JT_C_ZTBMSPTZ(Session session) : base(session) { }
        public VIEW_JT_C_ZTBMSPTZ() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }
    public class VIEW_JT_C_ZTBMTZ : XPLiteObject
    {
        string fZTBMTZID;
        [Key]
        [Size(16)]
        public string ZTBMTZID
        {
            get { return fZTBMTZID; }
            set { SetPropertyValue<string>("ZTBMTZID", ref fZTBMTZID, value); }
        }

        string fZTTZID;
        [Size(16)]
        public string ZTTZID
        {
            get { return fZTTZID; }
            set { SetPropertyValue<string>("ZTTZID", ref fZTTZID, value); }
        }

        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }

        string fBMID;
        [Size(16)]
        public string BMID
        {
            get { return fBMID; }
            set { SetPropertyValue<string>("BMID", ref fBMID, value); }
        }

        long fQCKC;
        public long QCKC
        {
            get { return fQCKC; }
            set { SetPropertyValue<long>("QCKC", ref fQCKC, value); }
        }

        decimal fQCMY;
        public decimal QCMY
        {
            get { return fQCMY; }
            set { SetPropertyValue<decimal>("QCMY", ref fQCMY, value); }
        }

        decimal fQCSY;
        public decimal QCSY
        {
            get { return fQCSY; }
            set { SetPropertyValue<decimal>("QCSY", ref fQCSY, value); }
        }

        long fJHSL;
        public long JHSL
        {
            get { return fJHSL; }
            set { SetPropertyValue<long>("JHSL", ref fJHSL, value); }
        }

        decimal fJHMY;
        public decimal JHMY
        {
            get { return fJHMY; }
            set { SetPropertyValue<decimal>("JHMY", ref fJHMY, value); }
        }

        decimal fJHSY;
        public decimal JHSY
        {
            get { return fJHSY; }
            set { SetPropertyValue<decimal>("JHSY", ref fJHSY, value); }
        }

        long fXTSL;
        public long XTSL
        {
            get { return fXTSL; }
            set { SetPropertyValue<long>("XTSL", ref fXTSL, value); }
        }

        decimal fXTMY;
        public decimal XTMY
        {
            get { return fXTMY; }
            set { SetPropertyValue<decimal>("XTMY", ref fXTMY, value); }
        }

        decimal fXTSY;
        public decimal XTSY
        {
            get { return fXTSY; }
            set { SetPropertyValue<decimal>("XTSY", ref fXTSY, value); }
        }


        long fDRSL;
        public long DRSL
        {
            get { return fDRSL; }
            set { SetPropertyValue<long>("DRSL", ref fDRSL, value); }
        }

        decimal fDRMY;
        public decimal DRMY
        {
            get { return fDRMY; }
            set { SetPropertyValue<decimal>("DRMY", ref fDRMY, value); }
        }

        decimal fDRSY;
        public decimal DRSY
        {
            get { return fDRSY; }
            set { SetPropertyValue<decimal>("DRSY", ref fDRSY, value); }
        }

        long fJRSL;
        public long JRSL
        {
            get { return fJRSL; }
            set { SetPropertyValue<long>("JRSL", ref fJRSL, value); }
        }

        decimal fJRMY;
        public decimal JRMY
        {
            get { return fJRMY; }
            set { SetPropertyValue<decimal>("JRMY", ref fJRMY, value); }
        }

        decimal fJRSY;
        public decimal JRSY
        {
            get { return fJRSY; }
            set { SetPropertyValue<decimal>("JRSY", ref fJRSY, value); }
        }

        long fXSSL;
        public long XSSL
        {
            get { return fXSSL; }
            set { SetPropertyValue<long>("XSSL", ref fXSSL, value); }
        }

        decimal fXSMY;
        public decimal XSMY
        {
            get { return fXSMY; }
            set { SetPropertyValue<decimal>("XSMY", ref fXSMY, value); }
        }

        decimal fXSSY;
        public decimal XSSY
        {
            get { return fXSSY; }
            set { SetPropertyValue<decimal>("XSSY", ref fXSSY, value); }
        }


        long fJTSL;
        public long JTSL
        {
            get { return fJTSL; }
            set { SetPropertyValue<long>("JTSL", ref fJTSL, value); }
        }

        decimal fJTMY;
        public decimal JTMY
        {
            get { return fJTMY; }
            set { SetPropertyValue<decimal>("JTMY", ref fJTMY, value); }
        }

        decimal fJTSY;
        public decimal JTSY
        {
            get { return fJTSY; }
            set { SetPropertyValue<decimal>("JTSY", ref fJTSY, value); }
        }

        long fDCSL;
        public long DCSL
        {
            get { return fDCSL; }
            set { SetPropertyValue<long>("DCSL", ref fDCSL, value); }
        }

        decimal fDCMY;
        public decimal DCMY
        {
            get { return fDCMY; }
            set { SetPropertyValue<decimal>("DCMY", ref fDCMY, value); }
        }

        decimal fDCSY;
        public decimal DCSY
        {
            get { return fDCSY; }
            set { SetPropertyValue<decimal>("DCSY", ref fDCSY, value); }
        }







        long fJCSL;
        public long JCSL
        {
            get { return fJCSL; }
            set { SetPropertyValue<long>("JCSL", ref fJCSL, value); }
        }

        decimal fJCMY;
        public decimal JCMY
        {
            get { return fJCMY; }
            set { SetPropertyValue<decimal>("JCMY", ref fJCMY, value); }
        }

        decimal fJCSY;
        public decimal JCSY
        {
            get { return fJCSY; }
            set { SetPropertyValue<decimal>("JCSY", ref fJCSY, value); }
        }


        long fBFSL;
        public long BFSL
        {
            get { return fBFSL; }
            set { SetPropertyValue<long>("BFSL", ref fBFSL, value); }
        }

        decimal fBFMY;
        public decimal BFMY
        {
            get { return fBFMY; }
            set { SetPropertyValue<decimal>("BFMY", ref fBFMY, value); }
        }

        decimal fBFSY;
        public decimal BFSY
        {
            get { return fBFSY; }
            set { SetPropertyValue<decimal>("BFSY", ref fBFSY, value); }
        }

        long fSYSL;
        public long SYSL
        {
            get { return fSYSL; }
            set { SetPropertyValue<long>("SYSL", ref fSYSL, value); }
        }

        decimal fSYMY;
        public decimal SYMY
        {
            get { return fSYMY; }
            set { SetPropertyValue<decimal>("SYMY", ref fSYMY, value); }
        }

        decimal fSYSY;
        public decimal SYSY
        {
            get { return fSYSY; }
            set { SetPropertyValue<decimal>("SYSY", ref fSYSY, value); }
        }


        long fQMKC;
        public long QMKC
        {
            get { return fQMKC; }
            set { SetPropertyValue<long>("QMKC", ref fQMKC, value); }
        }

        decimal fQMMY;
        public decimal QMMY
        {
            get { return fQMMY; }
            set { SetPropertyValue<decimal>("QMMY", ref fQMMY, value); }
        }

        decimal fQMSY;
        public decimal QMSY
        {
            get { return fQMSY; }
            set { SetPropertyValue<decimal>("QMSY", ref fQMSY, value); }
        }


        long fZRSL;
        public long ZRSL
        {
            get { return fZRSL; }
            set { SetPropertyValue<long>("ZRSL", ref fZRSL, value); }
        }

        decimal fZRMY;
        public decimal ZRMY
        {
            get { return fZRMY; }
            set { SetPropertyValue<decimal>("ZRMY", ref fZRMY, value); }
        }

        decimal fZRSY;
        public decimal ZRSY
        {
            get { return fZRSY; }
            set { SetPropertyValue<decimal>("ZRSY", ref fZRSY, value); }
        }

        long fZCSL;
        public long ZCSL
        {
            get { return fZCSL; }
            set { SetPropertyValue<long>("ZCSL", ref fZCSL, value); }
        }

        decimal fZCMY;
        public decimal ZCMY
        {
            get { return fZCMY; }
            set { SetPropertyValue<decimal>("ZCMY", ref fZCMY, value); }
        }

        decimal fZCSY;
        public decimal ZCSY
        {
            get { return fZCSY; }
            set { SetPropertyValue<decimal>("ZCSY", ref fZCSY, value); }
        }





        string fZT;
        [Size(4)]
        public string ZT
        {
            get { return fZT; }
            set { SetPropertyValue<string>("ZT", ref fZT, value); }
        }

        string fYZT;
        [Size(4)]
        public string YZT
        {
            get { return fYZT; }
            set { SetPropertyValue<string>("YZT", ref fYZT, value); }
        }

        string fBZ;
        [Size(100)]
        public string BZ
        {
            get { return fBZ; }
            set { SetPropertyValue<string>("BZ", ref fBZ, value); }
        }

        string fZTIDMC;
        [Size(22)]
        public string ZTIDMC
        {
            get { return fZTIDMC; }
            set { SetPropertyValue<string>("ZTIDMC", ref fZTIDMC, value); }
        }


        string fZTMC;
        [Size(22)]
        public string ZTMC
        {
            get { return fZTMC; }
            set { SetPropertyValue<string>("ZTMC", ref fZTMC, value); }
        }

        string fBMMC;
        [Size(22)]
        public string BMMC
        {
            get { return fBMMC; }
            set { SetPropertyValue<string>("BMMC", ref fBMMC, value); }
        }



        public VIEW_JT_C_ZTBMTZ(Session session) : base(session) { }
        public VIEW_JT_C_ZTBMTZ() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }
    public class VIEW_JT_C_ZTTZ : XPLiteObject
    {
        string fZTTZID;
        [Key]
        [Size(16)]
        public string ZTTZID
        {
            get { return fZTTZID; }
            set { SetPropertyValue<string>("ZTTZID", ref fZTTZID, value); }
        }

        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }

        long fQCKC;
        public long QCKC
        {
            get { return fQCKC; }
            set { SetPropertyValue<long>("QCKC", ref fQCKC, value); }
        }

        decimal fQCMY;
        public decimal QCMY
        {
            get { return fQCMY; }
            set { SetPropertyValue<decimal>("QCMY", ref fQCMY, value); }
        }

        decimal fQCSY;
        public decimal QCSY
        {
            get { return fQCSY; }
            set { SetPropertyValue<decimal>("QCSY", ref fQCSY, value); }
        }

        long fJHSL;
        public long JHSL
        {
            get { return fJHSL; }
            set { SetPropertyValue<long>("JHSL", ref fJHSL, value); }
        }

        decimal fJHMY;
        public decimal JHMY
        {
            get { return fJHMY; }
            set { SetPropertyValue<decimal>("JHMY", ref fJHMY, value); }
        }

        decimal fJHSY;
        public decimal JHSY
        {
            get { return fJHSY; }
            set { SetPropertyValue<decimal>("JHSY", ref fJHSY, value); }
        }

        long fXTSL;
        public long XTSL
        {
            get { return fXTSL; }
            set { SetPropertyValue<long>("XTSL", ref fXTSL, value); }
        }

        decimal fXTMY;
        public decimal XTMY
        {
            get { return fXTMY; }
            set { SetPropertyValue<decimal>("XTMY", ref fXTMY, value); }
        }

        decimal fXTSY;
        public decimal XTSY
        {
            get { return fXTSY; }
            set { SetPropertyValue<decimal>("XTSY", ref fXTSY, value); }
        }


        long fDRSL;
        public long DRSL
        {
            get { return fDRSL; }
            set { SetPropertyValue<long>("DRSL", ref fDRSL, value); }
        }

        decimal fDRMY;
        public decimal DRMY
        {
            get { return fDRMY; }
            set { SetPropertyValue<decimal>("DRMY", ref fDRMY, value); }
        }

        decimal fDRSY;
        public decimal DRSY
        {
            get { return fDRSY; }
            set { SetPropertyValue<decimal>("DRSY", ref fDRSY, value); }
        }

        long fJRSL;
        public long JRSL
        {
            get { return fJRSL; }
            set { SetPropertyValue<long>("JRSL", ref fJRSL, value); }
        }

        decimal fJRMY;
        public decimal JRMY
        {
            get { return fJRMY; }
            set { SetPropertyValue<decimal>("JRMY", ref fJRMY, value); }
        }

        decimal fJRSY;
        public decimal JRSY
        {
            get { return fJRSY; }
            set { SetPropertyValue<decimal>("JRSY", ref fJRSY, value); }
        }

        long fXSSL;
        public long XSSL
        {
            get { return fXSSL; }
            set { SetPropertyValue<long>("XSSL", ref fXSSL, value); }
        }

        decimal fXSMY;
        public decimal XSMY
        {
            get { return fXSMY; }
            set { SetPropertyValue<decimal>("XSMY", ref fXSMY, value); }
        }

        decimal fXSSY;
        public decimal XSSY
        {
            get { return fXSSY; }
            set { SetPropertyValue<decimal>("XSSY", ref fXSSY, value); }
        }


        long fJTSL;
        public long JTSL
        {
            get { return fJTSL; }
            set { SetPropertyValue<long>("JTSL", ref fJTSL, value); }
        }

        decimal fJTMY;
        public decimal JTMY
        {
            get { return fJTMY; }
            set { SetPropertyValue<decimal>("JTMY", ref fJTMY, value); }
        }

        decimal fJTSY;
        public decimal JTSY
        {
            get { return fJTSY; }
            set { SetPropertyValue<decimal>("JTSY", ref fJTSY, value); }
        }

        long fDCSL;
        public long DCSL
        {
            get { return fDCSL; }
            set { SetPropertyValue<long>("DCSL", ref fDCSL, value); }
        }

        decimal fDCMY;
        public decimal DCMY
        {
            get { return fDCMY; }
            set { SetPropertyValue<decimal>("DCMY", ref fDCMY, value); }
        }

        decimal fDCSY;
        public decimal DCSY
        {
            get { return fDCSY; }
            set { SetPropertyValue<decimal>("DCSY", ref fDCSY, value); }
        }







        long fJCSL;
        public long JCSL
        {
            get { return fJCSL; }
            set { SetPropertyValue<long>("JCSL", ref fJCSL, value); }
        }

        decimal fJCMY;
        public decimal JCMY
        {
            get { return fJCMY; }
            set { SetPropertyValue<decimal>("JCMY", ref fJCMY, value); }
        }

        decimal fJCSY;
        public decimal JCSY
        {
            get { return fJCSY; }
            set { SetPropertyValue<decimal>("JCSY", ref fJCSY, value); }
        }


        long fBFSL;
        public long BFSL
        {
            get { return fBFSL; }
            set { SetPropertyValue<long>("BFSL", ref fBFSL, value); }
        }

        decimal fBFMY;
        public decimal BFMY
        {
            get { return fBFMY; }
            set { SetPropertyValue<decimal>("BFMY", ref fBFMY, value); }
        }

        decimal fBFSY;
        public decimal BFSY
        {
            get { return fBFSY; }
            set { SetPropertyValue<decimal>("BFSY", ref fBFSY, value); }
        }

        long fSYSL;
        public long SYSL
        {
            get { return fSYSL; }
            set { SetPropertyValue<long>("SYSL", ref fSYSL, value); }
        }

        decimal fSYMY;
        public decimal SYMY
        {
            get { return fSYMY; }
            set { SetPropertyValue<decimal>("SYMY", ref fSYMY, value); }
        }

        decimal fSYSY;
        public decimal SYSY
        {
            get { return fSYSY; }
            set { SetPropertyValue<decimal>("SYSY", ref fSYSY, value); }
        }


        long fQMKC;
        public long QMKC
        {
            get { return fQMKC; }
            set { SetPropertyValue<long>("QMKC", ref fQMKC, value); }
        }

        decimal fQMMY;
        public decimal QMMY
        {
            get { return fQMMY; }
            set { SetPropertyValue<decimal>("QMMY", ref fQMMY, value); }
        }

        decimal fQMSY;
        public decimal QMSY
        {
            get { return fQMSY; }
            set { SetPropertyValue<decimal>("QMSY", ref fQMSY, value); }
        }


        long fZRSL;
        public long ZRSL
        {
            get { return fZRSL; }
            set { SetPropertyValue<long>("ZRSL", ref fZRSL, value); }
        }

        decimal fZRMY;
        public decimal ZRMY
        {
            get { return fZRMY; }
            set { SetPropertyValue<decimal>("ZRMY", ref fZRMY, value); }
        }

        decimal fZRSY;
        public decimal ZRSY
        {
            get { return fZRSY; }
            set { SetPropertyValue<decimal>("ZRSY", ref fZRSY, value); }
        }

        long fZCSL;
        public long ZCSL
        {
            get { return fZCSL; }
            set { SetPropertyValue<long>("ZCSL", ref fZCSL, value); }
        }

        decimal fZCMY;
        public decimal ZCMY
        {
            get { return fZCMY; }
            set { SetPropertyValue<decimal>("ZCMY", ref fZCMY, value); }
        }

        decimal fZCSY;
        public decimal ZCSY
        {
            get { return fZCSY; }
            set { SetPropertyValue<decimal>("ZCSY", ref fZCSY, value); }
        }





        string fZT;
        [Size(4)]
        public string ZT
        {
            get { return fZT; }
            set { SetPropertyValue<string>("ZT", ref fZT, value); }
        }

        string fYZT;
        [Size(4)]
        public string YZT
        {
            get { return fYZT; }
            set { SetPropertyValue<string>("YZT", ref fYZT, value); }
        }

        string fBZ;
        [Size(100)]
        public string BZ
        {
            get { return fBZ; }
            set { SetPropertyValue<string>("BZ", ref fBZ, value); }
        }

        string fZTIDMC;
        [Size(22)]
        public string ZTIDMC
        {
            get { return fZTIDMC; }
            set { SetPropertyValue<string>("ZTIDMC", ref fZTIDMC, value); }
        }


        string fZTMC;
        [Size(22)]
        public string ZTMC
        {
            get { return fZTMC; }
            set { SetPropertyValue<string>("ZTMC", ref fZTMC, value); }
        }



        public VIEW_JT_C_ZTTZ(Session session) : base(session) { }
        public VIEW_JT_C_ZTTZ() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }
    public class VIEW_JT_C_XSJSDMX : XPLiteObject
    {
        string fXSJSDMXID;
        [Key]
        [Size(16)]
        public string XSJSDMXID
        {
            get { return fXSJSDMXID; }
            set { SetPropertyValue<string>("XSJSDMXID", ref fXSJSDMXID, value); }
        }

        string fXSJSDID;
        [Size(16)]
        public string XSJSDID
        {
            get { return fXSJSDID; }
            set { SetPropertyValue<string>("XSJSDID", ref fXSJSDID, value); }
        }

        string fXSDID;
        [Size(16)]
        public string XSDID
        {
            get { return fXSDID; }
            set { SetPropertyValue<string>("XSDID", ref fXSDID, value); }
        }

        string fSJLX;
        [Size(4)]
        public string SJLX
        {
            get { return fSJLX; }
            set { SetPropertyValue<string>("SJLX", ref fSJLX, value); }
        }

        decimal fSE;
        public decimal SE
        {
            get { return fSE; }
            set { SetPropertyValue<decimal>("SE", ref fSE, value); }
        }

        string fXSDH;
        [Size(16)]
        public string XSDH
        {
            get { return fXSDH; }
            set { SetPropertyValue<string>("XSDH", ref fXSDH, value); }
        }

        string fKHID;
        [Size(16)]
        public string KHID
        {
            get { return fKHID; }
            set { SetPropertyValue<string>("KHID", ref fKHID, value); }
        }


        string fXSDMXID;
        [Size(16)]
        public string XSDMXID
        {
            get { return fXSDMXID; }
            set { SetPropertyValue<string>("XSDMXID", ref fXSDMXID, value); }
        }

        string fZDDM;
        [Size(16)]
        public string ZDDM
        {
            get { return fZDDM; }
            set { SetPropertyValue<string>("ZDDM", ref fZDDM, value); }
        }

        string fSPXXID;
        [Size(16)]
        public string SPXXID
        {
            get { return fSPXXID; }
            set { SetPropertyValue<string>("SPXXID", ref fSPXXID, value); }
        }


        decimal fDJ;
        public decimal DJ
        {
            get { return fDJ; }
            set { SetPropertyValue<decimal>("DJ", ref fDJ, value); }
        }

        decimal fXZ;
        public decimal XZ
        {
            get { return fXZ; }
            set { SetPropertyValue<decimal>("XZ", ref fXZ, value); }
        }

        decimal fXJ;
        public decimal XJ
        {
            get { return fXJ; }
            set { SetPropertyValue<decimal>("XJ", ref fXJ, value); }
        }


        decimal fFDXZ;
        public decimal FDXZ
        {
            get { return fFDXZ; }
            set { SetPropertyValue<decimal>("FDXZ", ref fFDXZ, value); }
        }

        decimal fFDXJ;
        public decimal FDXJ
        {
            get { return fFDXJ; }
            set { SetPropertyValue<decimal>("FDXJ", ref fFDXJ, value); }
        }


        long fSL;
        public long SL
        {
            get { return fSL; }
            set { SetPropertyValue<long>("SL", ref fSL, value); }
        }


        long fXSSL;
        public long XSSL
        {
            get { return fXSSL; }
            set { SetPropertyValue<long>("XSSL", ref fXSSL, value); }
        }
        decimal fXSSY;
        public decimal XSSY
        {
            get { return fXSSY; }
            set { SetPropertyValue<decimal>("XSSY", ref fXSSY, value); }
        }

        decimal fXSMY;
        public decimal XSMY
        {
            get { return fXSMY; }
            set { SetPropertyValue<decimal>("XSMY", ref fXSMY, value); }
        }


        decimal fFDE;
        public decimal FDE
        {
            get { return fFDE; }
            set { SetPropertyValue<decimal>("FDE", ref fFDE, value); }
        }

        decimal fJSHJ;
        public decimal JSHJ
        {
            get { return fJSHJ; }
            set { SetPropertyValue<decimal>("JSHJ", ref fJSHJ, value); }
        }


        long fDSSL;
        public long DSSL
        {
            get { return fDSSL; }
            set { SetPropertyValue<long>("DSSL", ref fDSSL, value); }
        }
        decimal fDSSY;
        public decimal DSSY
        {
            get { return fDSSY; }
            set { SetPropertyValue<decimal>("DSSY", ref fDSSY, value); }
        }

        decimal fDSMY;
        public decimal DSMY
        {
            get { return fDSMY; }
            set { SetPropertyValue<decimal>("DSMY", ref fDSMY, value); }
        }

        long fYJSL;
        public long YJSL
        {
            get { return fYJSL; }
            set { SetPropertyValue<long>("YJSL", ref fYJSL, value); }
        }
        decimal fYJSY;
        public decimal YJSY
        {
            get { return fYJSY; }
            set { SetPropertyValue<decimal>("YJSY", ref fYJSY, value); }
        }

        decimal fYJMY;
        public decimal YJMY
        {
            get { return fYJMY; }
            set { SetPropertyValue<decimal>("YJMY", ref fYJMY, value); }
        }


        string fZT;
        [Size(4)]
        public string ZT
        {
            get { return fZT; }
            set { SetPropertyValue<string>("ZT", ref fZT, value); }
        }

        string fYZT;
        [Size(4)]
        public string YZT
        {
            get { return fYZT; }
            set { SetPropertyValue<string>("YZT", ref fYZT, value); }
        }

        string fBZ;
        [Size(100)]
        public string BZ
        {
            get { return fBZ; }
            set { SetPropertyValue<string>("BZ", ref fBZ, value); }
        }


        string fXSFSID;
        [Size(16)]
        public string XSFSID
        {
            get { return fXSFSID; }
            set { SetPropertyValue<string>("XSFSID", ref fXSFSID, value); }
        }
        string fBMSPKFMXID;
        [Size(16)]
        public string BMSPKFMXID
        {
            get { return fBMSPKFMXID; }
            set { SetPropertyValue<string>("BMSPKFMXID", ref fBMSPKFMXID, value); }
        }

        string fKHSPMXID;
        [Size(16)]
        public string KHSPMXID
        {
            get { return fKHSPMXID; }
            set { SetPropertyValue<string>("KHSPMXID", ref fKHSPMXID, value); }
        }


        DateTime fTSRQ;
        public DateTime TSRQ
        {
            get { return fTSRQ; }
            set { SetPropertyValue<DateTime>("TSRQ", ref fTSRQ, value); }
        }


        long fTSCS;
        public long TSCS
        {
            get { return fTSCS; }
            set { SetPropertyValue<long>("TSCS", ref fTSCS, value); }
        }


        decimal fZKE;
        public decimal ZKE
        {
            get { return fZKE; }
            set { SetPropertyValue<decimal>("ZKEY", ref fZKE, value); }
        }

        decimal fWSJE;
        public decimal WSJE
        {
            get { return fWSJE; }
            set { SetPropertyValue<decimal>("WSJE", ref fWSJE, value); }
        }

        string fXSBMID;
        [Size(16)]
        public string XSBMID
        {
            get { return fXSBMID; }
            set { SetPropertyValue<string>("XSBMID", ref fXSBMID, value); }
        }

        string fLYDJMXID;
        [Size(16)]
        public string LYDJMXID
        {
            get { return fLYDJMXID; }
            set { SetPropertyValue<string>("LYDJMXID", ref fLYDJMXID, value); }
        }
        string fLYDJBID;
        [Size(16)]
        public string LYDJBID
        {
            get { return fLYDJBID; }
            set { SetPropertyValue<string>("LYDJBID", ref fLYDJBID, value); }
        }
        string fLYDJID;
        [Size(16)]
        public string LYDJID
        {
            get { return fLYDJID; }
            set { SetPropertyValue<string>("LYDJID", ref fLYDJID, value); }
        }
        string fLYBMID;
        [Size(16)]
        public string LYBMID
        {
            get { return fLYBMID; }
            set { SetPropertyValue<string>("LYBMID", ref fLYBMID, value); }
        }



        string fXSBMMC;
        [Size(22)]
        public string XSBMMC
        {
            get { return fXSBMMC; }
            set { SetPropertyValue<string>("XSBMMC", ref fXSBMMC, value); }
        }
        string fKHMC;
        [Size(22)]
        public string KHMC
        {
            get { return fKHMC; }
            set { SetPropertyValue<string>("KHMC", ref fKHMC, value); }
        }
        string fLYBMMC;
        [Size(16)]
        public string LYBMMC
        {
            get { return fLYBMMC; }
            set { SetPropertyValue<string>("LYBMMC", ref fLYBMMC, value); }
        }


        string fXSJSDH;
        [Size(22)]
        public string XSJSDH
        {
            get { return fXSJSDH; }
            set { SetPropertyValue<string>("XSJSDH", ref fXSJSDH, value); }
        }


        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }





        public VIEW_JT_C_XSJSDMX(Session session) : base(session) { }
        public VIEW_JT_C_XSJSDMX() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }

    }
    public class VIEW_JT_C_XSJSD : XPLiteObject
    {
        string fXSJSDID;
        [Key]
        [Size(16)]
        public string XSJSDID
        {
            get { return fXSJSDID; }
            set { SetPropertyValue<string>("XSJSDID", ref fXSJSDID, value); }
        }


        string fXSJSDH;
        [Size(22)]
        public string XSJSDH
        {
            get { return fXSJSDH; }
            set { SetPropertyValue<string>("XSJSDH", ref fXSJSDH, value); }
        }

        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }

        string fCWBMID;
        [Size(16)]
        public string CWBMID
        {
            get { return fCWBMID; }
            set { SetPropertyValue<string>("CWBMID", ref fCWBMID, value); }
        }

        string fGHDWID;
        [Size(16)]
        public string GHDWID
        {
            get { return fGHDWID; }
            set { SetPropertyValue<string>("GHDWID", ref fGHDWID, value); }
        }

        decimal fJSHJ;
        public decimal JSHJ
        {
            get { return fJSHJ; }
            set { SetPropertyValue<decimal>("JSHJ", ref fJSHJ, value); }
        }

        decimal fFDE;
        public decimal FDE
        {
            get { return fFDE; }
            set { SetPropertyValue<decimal>("FDE", ref fFDE, value); }
        }

        decimal fPJZK;
        public decimal PJZK
        {
            get { return fPJZK; }
            set { SetPropertyValue<decimal>("PJZK", ref fPJZK, value); }
        }

        decimal fPJDJ;
        public decimal PJDJ
        {
            get { return fPJDJ; }
            set { SetPropertyValue<decimal>("PJDJ", ref fPJDJ, value); }
        }

        string fJSLX;
        [Size(10)]
        public string JSLX
        {
            get { return fJSLX; }
            set { SetPropertyValue<string>("JSLX", ref fJSLX, value); }
        }


        string fJSR;
        [Size(10)]
        public string JSR
        {
            get { return fJSR; }
            set { SetPropertyValue<string>("JSR", ref fJSR, value); }
        }

        string fJSFSID;
        [Size(16)]
        public string JSFSID
        {
            get { return fJSFSID; }
            set { SetPropertyValue<string>("JSFSID", ref fJSFSID, value); }
        }

        DateTime fZDRQ;
        public DateTime ZDRQ
        {
            get { return fZDRQ; }
            set { SetPropertyValue<DateTime>("ZDRQ", ref fZDRQ, value); }
        }

        string fCZYID;
        [Size(16)]
        public string CZYID
        {
            get { return fCZYID; }
            set { SetPropertyValue<string>("CZYID", ref fCZYID, value); }
        }

        long fPZS;
        public long PZS
        {
            get { return fPZS; }
            set { SetPropertyValue<long>("SL", ref fPZS, value); }
        }


        long fXSSL;
        public long XSSL
        {
            get { return fXSSL; }
            set { SetPropertyValue<long>("XSSL", ref fXSSL, value); }
        }

        decimal fXSSY;
        public decimal XSSY
        {
            get { return fXSSY; }
            set { SetPropertyValue<decimal>("XSSY", ref fXSSY, value); }
        }

        decimal fXSMY;
        public decimal XSMY
        {
            get { return fXSMY; }
            set { SetPropertyValue<decimal>("XSMY", ref fXSMY, value); }
        }

        long fSL;
        public long SL
        {
            get { return fSL; }
            set { SetPropertyValue<long>("SL", ref fSL, value); }
        }

        decimal fSE;
        public decimal SE
        {
            get { return fSE; }
            set { SetPropertyValue<decimal>("SE", ref fSE, value); }
        }

        decimal fZKE;
        public decimal ZKE
        {
            get { return fZKE; }
            set { SetPropertyValue<decimal>("ZKE", ref fZKE, value); }
        }

        decimal fWSJE;
        public decimal WSJE
        {
            get { return fWSJE; }
            set { SetPropertyValue<decimal>("WSJE", ref fWSJE, value); }
        }


        long fTSZSL;
        public long TSZSL
        {
            get { return fTSZSL; }
            set { SetPropertyValue<long>("TSZSL", ref fTSZSL, value); }
        }

        decimal fTSZSY;
        public decimal TSZSY
        {
            get { return fTSZSY; }
            set { SetPropertyValue<decimal>("TSZSY", ref fTSZSY, value); }
        }

        decimal fTSZMY;
        public decimal TSZMY
        {
            get { return fTSZMY; }
            set { SetPropertyValue<decimal>("TSZMY", ref fTSZMY, value); }
        }

        DateTime fXSHZRQ;
        public DateTime XSHZRQ
        {
            get { return fXSHZRQ; }
            set { SetPropertyValue<DateTime>("XSHZRQ", ref fXSHZRQ, value); }
        }

        string fXSHZDID;
        [Size(22)]
        public string XSHZDID
        {
            get { return fXSHZDID; }
            set { SetPropertyValue<string>("XSHZDID", ref fXSHZDID, value); }
        }

        string fXSFPID;
        [Size(22)]
        public string XSFPID
        {
            get { return fXSFPID; }
            set { SetPropertyValue<string>("XSFPID", ref fXSFPID, value); }
        }


        long fDSSL;
        public long DSSL
        {
            get { return fDSSL; }
            set { SetPropertyValue<long>("DSSL", ref fDSSL, value); }
        }

        decimal fDSJE;
        public decimal DSJE
        {
            get { return fDSJE; }
            set { SetPropertyValue<decimal>("DSJE", ref fDSJE, value); }
        }

        decimal fDSMY;
        public decimal DSMY
        {
            get { return fXSMY; }
            set { SetPropertyValue<decimal>("DSMY", ref fDSMY, value); }
        }

        long fYSSL;
        public long YSSL
        {
            get { return fYSSL; }
            set { SetPropertyValue<long>("YSSL", ref fYSSL, value); }
        }

        decimal fYSJE;
        public decimal YSJE
        {
            get { return fYSJE; }
            set { SetPropertyValue<decimal>("YSJE", ref fYSJE, value); }
        }

        decimal fYSMY;
        public decimal YSMY
        {
            get { return fYSMY; }
            set { SetPropertyValue<decimal>("YSMY", ref fYSMY, value); }
        }

        DateTime fQSJSRQ;
        public DateTime QSJSRQ
        {
            get { return fQSJSRQ; }
            set { SetPropertyValue<DateTime>("QSJSRQ", ref fQSJSRQ, value); }
        }

        DateTime fZHJSRQ;
        public DateTime ZHJSRQ
        {
            get { return fZHJSRQ; }
            set { SetPropertyValue<DateTime>("ZHJSRQ", ref fZHJSRQ, value); }
        }


        DateTime fCZRQ;
        public DateTime CZRQ
        {
            get { return fCZRQ; }
            set { SetPropertyValue<DateTime>("CZRQ", ref fCZRQ, value); }
        }


        string fZT;
        [Size(40)]
        public string ZT
        {
            get { return fZT; }
            set { SetPropertyValue<string>("ZT", ref fZT, value); }
        }


        string fYZT;
        [Size(40)]
        public string YZT
        {
            get { return fYZT; }
            set { SetPropertyValue<string>("YZT", ref fYZT, value); }
        }

        string fBZ;
        [Size(100)]
        public string BZ
        {
            get { return fBZ; }
            set { SetPropertyValue<string>("BZ", ref fBZ, value); }
        }


        string fTSDMXID;
        [Size(16)]
        public string TSDMXID
        {
            get { return fTSDMXID; }
            set { SetPropertyValue<string>("TSDMXID", ref fTSDMXID, value); }
        }

        DateTime fHKRQ;
        public DateTime HKRQ
        {
            get { return fHKRQ; }
            set { SetPropertyValue<DateTime>("HKRQ", ref fHKRQ, value); }
        }


        string fSKPZID;
        [Size(16)]
        public string SKPZID
        {
            get { return fSKPZID; }
            set { SetPropertyValue<string>("SKPZID", ref fSKPZID, value); }
        }
        string fYSPZID;
        [Size(16)]
        public string YSPZID
        {
            get { return fYSPZID; }
            set { SetPropertyValue<string>("YSPZID", ref fYSPZID, value); }
        }


        DateTime fYSPZRQ;
        public DateTime YSPZRQ
        {
            get { return fYSPZRQ; }
            set { SetPropertyValue<DateTime>("YSPZRQ", ref fYSPZRQ, value); }
        }

        string fJZCBPZID;
        [Size(16)]
        public string JZCBPZID
        {
            get { return fJZCBPZID; }
            set { SetPropertyValue<string>("JZCBPZID", ref fJZCBPZID, value); }
        }


        DateTime fJZPZRQ;
        public DateTime JZPZRQ
        {
            get { return fJZPZRQ; }
            set { SetPropertyValue<DateTime>("JZPZRQ", ref fJZPZRQ, value); }
        }



        string fZTIDMC;
        [Size(16)]
        public string ZTIDMC
        {
            get { return fZTIDMC; }
            set { SetPropertyValue<string>("ZTIDMC", ref fZTIDMC, value); }
        }



        string fZTMC;
        [Size(16)]
        public string ZTMC
        {
            get { return fZTMC; }
            set { SetPropertyValue<string>("ZTMC", ref fZTMC, value); }
        }


        string fCZRMC;
        [Size(16)]
        public string CZRMC
        {
            get { return fCZRMC; }
            set { SetPropertyValue<string>("CZRMC", ref fCZRMC, value); }
        }


        string fJSFSMC;
        [Size(16)]
        public string JSFSMC
        {
            get { return fJSFSMC; }
            set { SetPropertyValue<string>("JSFSMC", ref fJSFSMC, value); }
        }



        string fCWBMMC;
        [Size(22)]
        public string CWBMMC
        {
            get { return fCWBMMC; }
            set { SetPropertyValue<string>("CWBMMC", ref fCWBMMC, value); }
        }

        string fGHDWMC;
        [Size(22)]
        public string GHDWMC
        {
            get { return fGHDWMC; }
            set { SetPropertyValue<string>("GHDWMC", ref fGHDWMC, value); }
        }

        string fXSFPH;
        [Size(22)]
        public string XSFPH
        {
            get { return fXSFPH; }
            set { SetPropertyValue<string>("XSFPH", ref fXSFPH, value); }
        }



        string fSKPZH;
        [Size(22)]
        public string SKPZH
        {
            get { return fSKPZH; }
            set { SetPropertyValue<string>("SKPZH", ref fSKPZH, value); }
        }

        string fXSHZDH;
        [Size(22)]
        public string XSHZDH
        {
            get { return fXSHZDH; }
            set { SetPropertyValue<string>("XSHZDH", ref fXSHZDH, value); }
        }

        string fJZCBPZH;
        [Size(22)]
        public string JZCBPZH
        {
            get { return fJZCBPZH; }
            set { SetPropertyValue<string>("JZCBPZH", ref fJZCBPZH, value); }
        }

        string fYSPZH;
        [Size(22)]
        public string YSPZH
        {
            get { return fYSPZH; }
            set { SetPropertyValue<string>("YSPZH", ref fYSPZH, value); }
        }

        string fTSDMXDH;
        [Size(22)]
        public string TSDMXDH
        {
            get { return fTSDMXDH; }
            set { SetPropertyValue<string>("TSDMXDH", ref fTSDMXDH, value); }
        }




        public VIEW_JT_C_XSJSD(Session session) : base(session) { }
        public VIEW_JT_C_XSJSD() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }
    public class VIEW_JT_C_XSFPMX : XPLiteObject
    {
        string fXSFPMXID;
        [Key]
        [Size(16)]
        public string XSFPMXID
        {
            get { return fXSFPMXID; }
            set { SetPropertyValue<string>("XSFPMXID", ref fXSFPMXID, value); }
        }

        string fXSFPID;
        [Size(16)]
        public string XSFPID
        {
            get { return fXSFPID; }
            set { SetPropertyValue<string>("XSFPID", ref fXSFPID, value); }
        }

        string fXSTSDID;
        [Size(16)]
        public string XSTSDID
        {
            get { return fXSTSDID; }
            set { SetPropertyValue<string>("XSTSDID", ref fXSTSDID, value); }
        }


        string fXSJSDID;
        [Size(16)]
        public string XSJSDID
        {
            get { return fXSJSDID; }
            set { SetPropertyValue<string>("XSJSDID", ref fXSJSDID, value); }
        }


        decimal fPJDJ;
        public decimal PJDJ
        {
            get { return fPJDJ; }
            set { SetPropertyValue<decimal>("PJDJ", ref fPJDJ, value); }
        }

        decimal fJSHJ;
        public decimal JSHJ
        {
            get { return fJSHJ; }
            set { SetPropertyValue<decimal>("JSHJ", ref fJSHJ, value); }
        }

        long fSL;
        public long SL
        {
            get { return fSL; }
            set { SetPropertyValue<long>("SL", ref fSL, value); }
        }

        decimal fSE;
        public decimal SE
        {
            get { return fSE; }
            set { SetPropertyValue<decimal>("SE", ref fSE, value); }
        }

        decimal fWSJE;
        public decimal WSJE
        {
            get { return fWSJE; }
            set { SetPropertyValue<decimal>("WSJE", ref fWSJE, value); }
        }

        string fJSFSID;
        [Size(16)]
        public string JSFSID
        {
            get { return fJSFSID; }
            set { SetPropertyValue<string>("JSFSID", ref fJSFSID, value); }
        }

        long fXSSL;
        public long XSSL
        {
            get { return fXSSL; }
            set { SetPropertyValue<long>("XSSL", ref fXSSL, value); }
        }

        string fXSJSDH;
        [Size(16)]
        public string XSJSDH
        {
            get { return fXSJSDH; }
            set { SetPropertyValue<string>("XSJSDH", ref fXSJSDH, value); }
        }

        string fHW;
        [Size(16)]
        public string HW
        {
            get { return fHW; }
            set { SetPropertyValue<string>("HW", ref fHW, value); }
        }

        string fGGXH;
        [Size(16)]
        public string GGXH
        {
            get { return fGGXH; }
            set { SetPropertyValue<string>("GGXH", ref fGGXH, value); }
        }

        string fDW;
        [Size(16)]
        public string DW
        {
            get { return fDW; }
            set { SetPropertyValue<string>("DW", ref fDW, value); }
        }

        string fBZ;
        [Size(16)]
        public string BZ
        {
            get { return fBZ; }
            set { SetPropertyValue<string>("BZ", ref fBZ, value); }
        }

        string fXSFPH;
        [Size(16)]
        public string XSFPH
        {
            get { return fXSFPH; }
            set { SetPropertyValue<string>("XSFPH", ref fXSFPH, value); }
        }

        string fXSTSDH;
        [Size(16)]
        public string JXSTSDH
        {
            get { return fJSFSMC; }
            set { SetPropertyValue<string>("XSTSDH", ref fXSTSDH, value); }
        }

        string fJSFSMC;
        [Size(16)]
        public string JSFSMC
        {
            get { return fJSFSMC; }
            set { SetPropertyValue<string>("JSFSMC", ref fJSFSMC, value); }
        }
        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }
        public VIEW_JT_C_XSFPMX(Session session) : base(session) { }
        public VIEW_JT_C_XSFPMX() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }
    public class VIEW_JT_C_XSFP : XPLiteObject
    {
        string fXSFPID;
        [Key]
        [Size(16)]
        public string XSFPID
        {
            get { return fXSFPID; }
            set { SetPropertyValue<string>("XSFPID", ref fXSFPID, value); }
        }
        string fXSFPH;
        [Size(22)]
        public string XSFPH
        {
            get { return fXSFPH; }
            set { SetPropertyValue<string>("XSFPH", ref fXSFPH, value); }
        }
        string fSJPH;
        [Size(22)]
        public string SJPH
        {
            get { return fSJPH; }
            set { SetPropertyValue<string>("SJPH", ref fSJPH, value); }
        }
        string fFPLXID;
        [Size(16)]
        public string FPLXID
        {
            get { return fFPLXID; }
            set { SetPropertyValue<string>("JHFSID", ref fFPLXID, value); }
        }
        string fKHID;
        [Size(15)]
        public string KHID
        {
            get { return fKHID; }
            set { SetPropertyValue<string>("KHID", ref fKHID, value); }
        }
        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }


        string fCZYID;
        [Size(16)]
        public string CZYID
        {
            get { return fCZYID; }
            set { SetPropertyValue<string>("CZYID", ref fCZYID, value); }
        }



        string fKPRID;
        [Size(16)]
        public string KPRID
        {
            get { return fKPRID; }
            set { SetPropertyValue<string>("KPRID", ref fKPRID, value); }
        }



        long fSL;
        public long SL
        {
            get { return fSL; }
            set { SetPropertyValue<long>("SL", ref fSL, value); }
        }

        decimal fWSJE;
        public decimal WSJE
        {
            get { return fWSJE; }
            set { SetPropertyValue<decimal>("WSJE", ref fWSJE, value); }
        }


        decimal fSE;
        public decimal SE
        {
            get { return fSE; }
            set { SetPropertyValue<decimal>("SE", ref fSE, value); }
        }

        decimal fJSHJ;
        public decimal JSHJ
        {
            get { return fJSHJ; }
            set { SetPropertyValue<decimal>("JSHJ", ref fJSHJ, value); }
        }

        string fYWBMID;
        [Size(16)]
        public string YWBMID
        {
            get { return fYWBMID; }
            set { SetPropertyValue<string>("YWBMID", ref fYWBMID, value); }
        }

        string fKHMC;
        [Size(80)]
        public string KHMC
        {
            get { return fKHMC; }
            set { SetPropertyValue<string>("KHMC", ref fKHMC, value); }
        }


        string fSH;
        [Size(100)]
        public string SH
        {
            get { return fSH; }
            set { SetPropertyValue<string>("SH", ref fSH, value); }
        }

        string fDZ;
        [Size(100)]
        public string DZ
        {
            get { return fDZ; }
            set { SetPropertyValue<string>("DZ", ref fDZ, value); }
        }

        string fZT;
        [Size(4)]
        public string ZT
        {
            get { return fZT; }
            set { SetPropertyValue<string>("ZT", ref fZT, value); }
        }

        string fKHYH;
        [Size(100)]
        public string KHYH
        {
            get { return fKHYH; }
            set { SetPropertyValue<string>("KHYH", ref fKHYH, value); }
        }




        string fZH;
        [Size(100)]
        public string ZH
        {
            get { return fZH; }
            set { SetPropertyValue<string>("ZH", ref fZH, value); }
        }

        string fDH;
        [Size(40)]
        public string DH
        {
            get { return fDH; }
            set { SetPropertyValue<string>("DH", ref fDH, value); }
        }

        DateTime fZDRQ;
        public DateTime ZDRQ
        {
            get { return fZDRQ; }
            set { SetPropertyValue<DateTime>("ZDRQ", ref fZDRQ, value); }
        }
        DateTime fCZRQ;
        public DateTime CZRQ
        {
            get { return fCZRQ; }
            set { SetPropertyValue<DateTime>("CZRQ", ref fCZRQ, value); }
        }


        string fYZT;
        [Size(4)]
        public string YZT
        {
            get { return fYZT; }
            set { SetPropertyValue<string>("YZT", ref fYZT, value); }
        }
        string fBZ;
        [Size(100)]
        public string BZ
        {
            get { return fBZ; }
            set { SetPropertyValue<string>("BZ", ref fBZ, value); }
        }


        string fFPLXMC;
        [Size(16)]
        public string FPLXMC
        {
            get { return fFPLXMC; }
            set { SetPropertyValue<string>("FPLXMC", ref fFPLXMC, value); }
        }

        string fZTMC;
        [Size(16)]
        public string ZTMC
        {
            get { return fZTMC; }
            set { SetPropertyValue<string>("ZTMC", ref fZTMC, value); }
        }

        string fKPRMC;
        [Size(16)]
        public string KPRMC
        {
            get { return fKPRMC; }
            set { SetPropertyValue<string>("KPRMC", ref fKPRMC, value); }
        }
        string fBMMC;
        [Size(16)]
        public string BMMC
        {
            get { return fBMMC; }
            set { SetPropertyValue<string>("BMMC", ref fBMMC, value); }
        }

        string fCZYMC;
        [Size(16)]
        public string CZYMC
        {
            get { return fCZYMC; }
            set { SetPropertyValue<string>("CZYMC", ref fCZYMC, value); }
        }

        string fZTIDMC;
        [Size(16)]
        public string ZTIDMC
        {
            get { return fZTIDMC; }
            set { SetPropertyValue<string>("ZTIDMC", ref fZTIDMC, value); }
        }



        public VIEW_JT_C_XSFP(Session session) : base(session) { }
        public VIEW_JT_C_XSFP() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }
    public class VIEW_JT_C_CGJSDMX : XPLiteObject
    {
        string fCGJSDMXID;
        [Key]
        [Size(16)]
        public string CGJSDMXID
        {
            get { return fCGJSDMXID; }
            set { SetPropertyValue<string>("CGJSDMXID", ref fCGJSDMXID, value); }
        }

        string fCGJSDID;
        [Size(16)]
        public string CGJSDID
        {
            get { return fCGJSDID; }
            set { SetPropertyValue<string>("CGJSDID", ref fCGJSDID, value); }
        }

        string fSHDID;
        [Size(16)]
        public string SHDID
        {
            get { return fSHDID; }
            set { SetPropertyValue<string>("SHDID", ref fSHDID, value); }
        }

        string fSJLX;
        [Size(4)]
        public string SJLX
        {
            get { return fSJLX; }
            set { SetPropertyValue<string>("SJLX", ref fSJLX, value); }
        }

        decimal fSE;
        public decimal SE
        {
            get { return fSE; }
            set { SetPropertyValue<decimal>("SE", ref fSE, value); }
        }

        string fSHDH;
        [Size(16)]
        public string SHDH
        {
            get { return fSHDH; }
            set { SetPropertyValue<string>("SHDH", ref fSHDH, value); }
        }

        string fCGBMID;
        [Size(16)]
        public string CGBMID
        {
            get { return fCGBMID; }
            set { SetPropertyValue<string>("CGBMID", ref fCGBMID, value); }
        }


        string fGYSID;
        [Size(16)]
        public string GYSID
        {
            get { return fGYSID; }
            set { SetPropertyValue<string>("GYSID", ref fGYSID, value); }
        }

        string fLYDJBID;
        [Size(16)]
        public string LYDJBID
        {
            get { return fLYDJBID; }
            set { SetPropertyValue<string>("LYDJBID", ref fLYDJBID, value); }
        }

        string fLYDJID;
        [Size(16)]
        public string LYDJID
        {
            get { return fLYDJID; }
            set { SetPropertyValue<string>("LYDJID", ref fLYDJID, value); }
        }

        string fLYDJMXID;
        [Size(16)]
        public string LYDJMXID
        {
            get { return fLYDJMXID; }
            set { SetPropertyValue<string>("LYDJMXID", ref fLYDJMXID, value); }
        }

        string fLYBMID;
        [Size(16)]
        public string LYBMID
        {
            get { return fLYBMID; }
            set { SetPropertyValue<string>("LYBMID", ref fLYBMID, value); }
        }

        string fCGSHMXID;
        [Size(16)]
        public string CGSHMXID
        {
            get { return fCGSHMXID; }
            set { SetPropertyValue<string>("CGSHMXID", ref fCGSHMXID, value); }
        }

        string fZDDM;
        [Size(16)]
        public string ZDDM
        {
            get { return fZDDM; }
            set { SetPropertyValue<string>("ZDDM", ref fZDDM, value); }
        }

        string fSPXXID;
        [Size(16)]
        public string SPXXID
        {
            get { return fSPXXID; }
            set { SetPropertyValue<string>("SPXXID", ref fSPXXID, value); }
        }

        decimal fDJ;
        public decimal DJ
        {
            get { return fDJ; }
            set { SetPropertyValue<decimal>("DJ", ref fDJ, value); }
        }

        decimal fJZ;
        public decimal JZ
        {
            get { return fJZ; }
            set { SetPropertyValue<decimal>("JZ", ref fJZ, value); }
        }


        decimal fJJ;
        public decimal JJ
        {
            get { return fJJ; }
            set { SetPropertyValue<decimal>("JJ", ref fJJ, value); }
        }

        decimal fFDJZ;
        public decimal FDJZ
        {
            get { return fFDJZ; }
            set { SetPropertyValue<decimal>("FDJZ", ref fFDJZ, value); }
        }


        decimal fFDJJ;
        public decimal FDJJ
        {
            get { return fFDJJ; }
            set { SetPropertyValue<decimal>("FDJJ", ref fFDJJ, value); }
        }


        long fSL;
        public long SL
        {
            get { return fSL; }
            set { SetPropertyValue<long>("SL", ref fSL, value); }
        }

        long fSHSL;
        public long SHSL
        {
            get { return fSHSL; }
            set { SetPropertyValue<long>("SHSL", ref fSHSL, value); }
        }
        decimal fSHSY;
        public decimal SHSY
        {
            get { return fSHSY; }
            set { SetPropertyValue<decimal>("SHSY", ref fSHSY, value); }
        }

        decimal fSHMY;
        public decimal SHMY
        {
            get { return fSHMY; }
            set { SetPropertyValue<decimal>("SHMY", ref fSHMY, value); }
        }


        decimal fFDE;
        public decimal FDE
        {
            get { return fFDE; }
            set { SetPropertyValue<decimal>("FDE", ref fFDE, value); }
        }

        decimal fJSHJ;
        public decimal JSHJ
        {
            get { return fJSHJ; }
            set { SetPropertyValue<decimal>("JSHJ", ref fJSHJ, value); }
        }

        long fDFSL;
        public long DFSL
        {
            get { return fDFSL; }
            set { SetPropertyValue<long>("DFSL", ref fDFSL, value); }
        }

        decimal fDFSY;
        public decimal DFSY
        {
            get { return fDFSY; }
            set { SetPropertyValue<decimal>("DFSY", ref fDFSY, value); }
        }

        decimal fDFMY;
        public decimal DFMY
        {
            get { return fDFMY; }
            set { SetPropertyValue<decimal>("DFMY", ref fDFMY, value); }
        }

        long fYFSL;
        public long YFSL
        {
            get { return fYFSL; }
            set { SetPropertyValue<long>("YFSL", ref fYFSL, value); }
        }


        decimal fYFSY;
        public decimal YFSY
        {
            get { return fYFSY; }
            set { SetPropertyValue<decimal>("YFSY", ref fYFSY, value); }
        }

        decimal fYFMY;
        public decimal YFMY
        {
            get { return fYFMY; }
            set { SetPropertyValue<decimal>("YFMY", ref fYFMY, value); }
        }

        DateTime fQSJSRQ;
        public DateTime QSJSRQ
        {
            get { return fQSJSRQ; }
            set { SetPropertyValue<DateTime>("QSJSRQ", ref fQSJSRQ, value); }
        }

        DateTime fZHJSRQ;
        public DateTime ZHJSRQ
        {
            get { return fZHJSRQ; }
            set { SetPropertyValue<DateTime>("ZHJSRQ", ref fZHJSRQ, value); }
        }

        string fZT;
        [Size(4)]
        public string ZT
        {
            get { return fZT; }
            set { SetPropertyValue<string>("ZT", ref fZT, value); }
        }

        string fYZT;
        [Size(4)]
        public string YZT
        {
            get { return fYZT; }
            set { SetPropertyValue<string>("YZT", ref fYZT, value); }
        }

        string fBZ;
        [Size(100)]
        public string BZ
        {
            get { return fBZ; }
            set { SetPropertyValue<string>("BZ", ref fBZ, value); }
        }

        string fJHFSID;
        [Size(16)]
        public string JHFSID
        {
            get { return fJHFSID; }
            set { SetPropertyValue<string>("JHFSID", ref fJHFSID, value); }
        }

        string fBMSPKFMXID;
        [Size(16)]
        public string BMSPKFMXID
        {
            get { return fBMSPKFMXID; }
            set { SetPropertyValue<string>("BMSPKFMXID", ref fBMSPKFMXID, value); }
        }

        string fGYSSPMXID;
        [Size(16)]
        public string GYSSPMXID
        {
            get { return fGYSSPMXID; }
            set { SetPropertyValue<string>("GYSSPMXID", ref fGYSSPMXID, value); }
        }


        DateTime fQSZZRQ;
        public DateTime QSZZRQ
        {
            get { return fQSZZRQ; }
            set { SetPropertyValue<DateTime>("QSZZRQ", ref fQSZZRQ, value); }
        }

        DateTime fTSRQ;
        public DateTime TSRQ
        {
            get { return fTSRQ; }
            set { SetPropertyValue<DateTime>("TSRQ", ref fTSRQ, value); }
        }


        long fTSCS;
        public long TSCS
        {
            get { return fTSCS; }
            set { SetPropertyValue<long>("TSCS", ref fTSCS, value); }
        }


        string fYSDH;
        [Size(40)]
        public string YSDH
        {
            get { return fYSDH; }
            set { SetPropertyValue<string>("YSDH", ref fYSDH, value); }
        }
        string fCGJSDH;
        [Size(40)]
        public string CGJSDH
        {
            get { return fCGJSDH; }
            set { SetPropertyValue<string>("CGJSDH", ref fCGJSDH, value); }
        }
        string fSPXXMC;
        [Size(40)]
        public string SPXXMC
        {
            get { return fSPXXMC; }
            set { SetPropertyValue<string>("SPXXMC", ref fSPXXMC, value); }
        }


        string fSPBH;
        [Size(40)]
        public string SPBH
        {
            get { return fSPBH; }
            set { SetPropertyValue<string>("SPBH", ref fSPBH, value); }
        }

        string fDWMC;
        [Size(40)]
        public string DWMC
        {
            get { return fDWMC; }
            set { SetPropertyValue<string>("DWMC", ref fDWMC, value); }
        }
        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }
        decimal fZKE;
        public decimal ZKE
        {
            get { return fZKE; }
            set { SetPropertyValue<decimal>("ZKEY", ref fZKE, value); }
        }

        decimal fWSJE;
        public decimal WSJE
        {
            get { return fWSJE; }
            set { SetPropertyValue<decimal>("WSJE", ref fWSJE, value); }
        }

        public VIEW_JT_C_CGJSDMX(Session session) : base(session) { }
        public VIEW_JT_C_CGJSDMX() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }

    }

    public class VIEW_JT_C_CGFPMX : XPLiteObject
    {
        string fCGFPMXID;
        [Key]
        [Size(16)]
        public string CGFPMXID
        {
            get { return fCGFPMXID; }
            set { SetPropertyValue<string>("CGFPMXID", ref fCGFPMXID, value); }
        }

        string fCGFPID;
        [Size(16)]
        public string CGFPID
        {
            get { return fCGFPID; }
            set { SetPropertyValue<string>("CGFPID", ref fCGFPID, value); }
        }

        string fCGTSDID;
        [Size(16)]
        public string CGTSDID
        {
            get { return fCGTSDID; }
            set { SetPropertyValue<string>("CGTSDID", ref fCGTSDID, value); }
        }

        string fCGJSDID;
        [Size(16)]
        public string CGJSDID
        {
            get { return fCGJSDID; }
            set { SetPropertyValue<string>("CGJSDID", ref fCGJSDID, value); }
        }

        decimal fPJDJ;
        public decimal PJDJ
        {
            get { return fPJDJ; }
            set { SetPropertyValue<decimal>("PJDJ", ref fPJDJ, value); }
        }

        decimal fJSHJ;
        public decimal JSHJ
        {
            get { return fJSHJ; }
            set { SetPropertyValue<decimal>("JSHJ", ref fJSHJ, value); }
        }

        long fSL;
        public long SL
        {
            get { return fSL; }
            set { SetPropertyValue<long>("SL", ref fSL, value); }
        }

        decimal fSE;
        public decimal SE
        {
            get { return fSE; }
            set { SetPropertyValue<decimal>("SE", ref fSE, value); }
        }

        decimal fWSJE;
        public decimal WSJE
        {
            get { return fWSJE; }
            set { SetPropertyValue<decimal>("WSJE", ref fWSJE, value); }
        }

        string fJSFSID;
        [Size(16)]
        public string JSFSID
        {
            get { return fJSFSID; }
            set { SetPropertyValue<string>("JSFSID", ref fJSFSID, value); }
        }

        long fSHSL;
        public long SHSL
        {
            get { return fSHSL; }
            set { SetPropertyValue<long>("SHSL", ref fSHSL, value); }
        }

        string fGYSJSDH;
        [Size(16)]
        public string GYSJSDH
        {
            get { return fGYSJSDH; }
            set { SetPropertyValue<string>("GYSJSDH", ref fGYSJSDH, value); }
        }

        string fHW;
        [Size(16)]
        public string HW
        {
            get { return fHW; }
            set { SetPropertyValue<string>("HW", ref fHW, value); }
        }

        string fGGXH;
        [Size(16)]
        public string GGXH
        {
            get { return fGGXH; }
            set { SetPropertyValue<string>("GGXH", ref fGGXH, value); }
        }

        string fDW;
        [Size(16)]
        public string DW
        {
            get { return fDW; }
            set { SetPropertyValue<string>("DW", ref fDW, value); }
        }

        string fBZ;
        [Size(80)]
        public string BZ
        {
            get { return fBZ; }
            set { SetPropertyValue<string>("BZ", ref fBZ, value); }
        }

        string fCGFPH;
        [Size(16)]
        public string CGFPH
        {
            get { return fCGFPH; }
            set { SetPropertyValue<string>("CGFPH", ref fCGFPH, value); }
        }

        string fJSFSMC;
        [Size(16)]
        public string JSFSMC
        {
            get { return fJSFSMC; }
            set { SetPropertyValue<string>("JSFSMC", ref fJSFSMC, value); }
        }

        string fCGJSDH;
        [Size(16)]
        public string CGJSDH
        {
            get { return fCGJSDH; }
            set { SetPropertyValue<string>("CGJSDH", ref fCGJSDH, value); }
        }

        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }


        public VIEW_JT_C_CGFPMX(Session session) : base(session) { }
        public VIEW_JT_C_CGFPMX() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }
    public class VIEW_JT_C_CGFP : XPLiteObject
    {
        string fCGFPID;
        [Key]
        [Size(16)]
        public string CGFPID
        {
            get { return fCGFPID; }
            set { SetPropertyValue<string>("CGFPID", ref fCGFPID, value); }
        }
        string fCGFPH;
        [Size(16)]
        public string CGFPH
        {
            get { return fCGFPH; }
            set { SetPropertyValue<string>("CGFPH", ref fCGFPH, value); }
        }
        string fSJPH;
        [Size(16)]
        public string SJPH
        {
            get { return fSJPH; }
            set { SetPropertyValue<string>("SJPH", ref fSJPH, value); }
        }
        string fFPLXID;
        [Size(16)]
        public string FPLXID
        {
            get { return fFPLXID; }
            set { SetPropertyValue<string>("JHFSID", ref fFPLXID, value); }
        }
        string fGYSID;
        [Size(15)]
        public string GYSID
        {
            get { return fGYSID; }
            set { SetPropertyValue<string>("GYSID", ref fGYSID, value); }
        }
        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }


        string fCZYID;
        [Size(16)]
        public string CZYID
        {
            get { return fCZYID; }
            set { SetPropertyValue<string>("CZYID", ref fCZYID, value); }
        }



        string fKPRID;
        [Size(16)]
        public string KPRID
        {
            get { return fKPRID; }
            set { SetPropertyValue<string>("KPRID", ref fKPRID, value); }
        }



        long fSL;
        public long SL
        {
            get { return fSL; }
            set { SetPropertyValue<long>("SL", ref fSL, value); }
        }

        decimal fWSJE;
        public decimal WSJE
        {
            get { return fWSJE; }
            set { SetPropertyValue<decimal>("WSJE", ref fWSJE, value); }
        }


        decimal fSE;
        public decimal SE
        {
            get { return fSE; }
            set { SetPropertyValue<decimal>("SE", ref fSE, value); }
        }

        decimal fJSHJ;
        public decimal JSHJ
        {
            get { return fJSHJ; }
            set { SetPropertyValue<decimal>("JSHJ", ref fJSHJ, value); }
        }

        string fYWBMID;
        [Size(16)]
        public string YWBMID
        {
            get { return fYWBMID; }
            set { SetPropertyValue<string>("YWBMID", ref fYWBMID, value); }
        }

        string fGYS;
        [Size(16)]
        public string GYS
        {
            get { return fGYS; }
            set { SetPropertyValue<string>("GYS", ref fGYS, value); }
        }


        string fSH;
        [Size(16)]
        public string SH
        {
            get { return fSH; }
            set { SetPropertyValue<string>("SH", ref fSH, value); }
        }

        string fDZ;
        [Size(16)]
        public string DZ
        {
            get { return fDZ; }
            set { SetPropertyValue<string>("DZ", ref fDZ, value); }
        }

        string fZT;
        [Size(16)]
        public string ZT
        {
            get { return fZT; }
            set { SetPropertyValue<string>("ZT", ref fZT, value); }
        }

        string fKHYH;
        [Size(16)]
        public string KHYH
        {
            get { return fKHYH; }
            set { SetPropertyValue<string>("KHYH", ref fKHYH, value); }
        }




        string fZH;
        [Size(16)]
        public string ZH
        {
            get { return fZH; }
            set { SetPropertyValue<string>("ZH", ref fZH, value); }
        }

        string fDH;
        [Size(16)]
        public string DH
        {
            get { return fDH; }
            set { SetPropertyValue<string>("DH", ref fDH, value); }
        }

        DateTime fZDRQ;
        public DateTime ZDRQ
        {
            get { return fZDRQ; }
            set { SetPropertyValue<DateTime>("ZDRQ", ref fZDRQ, value); }
        }
        DateTime fCZRQ;
        public DateTime CZRQ
        {
            get { return fCZRQ; }
            set { SetPropertyValue<DateTime>("CZRQ", ref fCZRQ, value); }
        }


        string fYZT;
        [Size(16)]
        public string YZT
        {
            get { return fYZT; }
            set { SetPropertyValue<string>("YZT", ref fYZT, value); }
        }
        string fBZ;
        [Size(16)]
        public string BZ
        {
            get { return fBZ; }
            set { SetPropertyValue<string>("BZ", ref fBZ, value); }
        }


        string fFPLXMC;
        [Size(16)]
        public string FPLXMC
        {
            get { return fFPLXMC; }
            set { SetPropertyValue<string>("FPLXMC", ref fFPLXMC, value); }
        }

        string fZTMC;
        [Size(16)]
        public string ZTMC
        {
            get { return fZTMC; }
            set { SetPropertyValue<string>("ZTMC", ref fZTMC, value); }
        }

        string fKPRMC;
        [Size(16)]
        public string KPRMC
        {
            get { return fKPRMC; }
            set { SetPropertyValue<string>("KPRMC", ref fKPRMC, value); }
        }
        string fBMMC;
        [Size(16)]
        public string BMMC
        {
            get { return fBMMC; }
            set { SetPropertyValue<string>("BMMC", ref fBMMC, value); }
        }



        public VIEW_JT_C_CGFP(Session session) : base(session) { }
        public VIEW_JT_C_CGFP() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class VIEW_JT_C_ZTBMSP_KFMX : XPLiteObject
    {

        string fZTBMSPKFMXID;
        [Key]
        [Size(16)]
        public string ZTBMSPKFMXID
        {
            get { return fZTBMSPKFMXID; }
            set { SetPropertyValue<string>("ZTBMSPKFMXID", ref fZTBMSPKFMXID, value); }
        }


        string fZTBMSPKFTZID;
        [Key]
        public string ZTBMSPKFTZID
        {
            get { return fZTBMSPKFTZID; }
            set { SetPropertyValue<string>("ZTBMSPKFTZID", ref fZTBMSPKFTZID, value); }
        }

        string fZTBMSPTZID;
        [Size(16)]
        public string ZTBMSPTZID
        {
            get { return fZTBMSPTZID; }
            set { SetPropertyValue<string>("ZTBMSPTZID", ref fZTBMSPTZID, value); }
        }


        string fZTBMTZID;
        [Size(16)]
        public string ZTBMTZID
        {
            get { return fZTBMTZID; }
            set { SetPropertyValue<string>("ZTBMTZID", ref fZTBMTZID, value); }
        }

        string fZTTZID;
        [Size(16)]
        public string ZTTZID
        {
            get { return fZTTZID; }
            set { SetPropertyValue<string>("ZTTZID", ref fZTTZID, value); }
        }

        string fZTID;
        [Size(16)]
        public string ZTID
        {
            get { return fZTID; }
            set { SetPropertyValue<string>("ZTID", ref fZTID, value); }
        }

        string fBMID;
        [Size(16)]
        public string BMID
        {
            get { return fBMID; }
            set { SetPropertyValue<string>("BMID", ref fBMID, value); }
        }

        string fWLBMID;
        [Size(16)]
        public string WLBMID
        {
            get { return fWLBMID; }
            set { SetPropertyValue<string>("WLBMID", ref fWLBMID, value); }
        }




        string fSPXXID;
        [Size(16)]
        public string SPXXID
        {
            get { return fSPXXID; }
            set { SetPropertyValue<string>("SPXXID", ref fSPXXID, value); }
        }

        long fQCKC;
        public long QCKC
        {
            get { return fQCKC; }
            set { SetPropertyValue<long>("QCKC", ref fQCKC, value); }
        }

        decimal fQCMY;
        public decimal QCMY
        {
            get { return fQCMY; }
            set { SetPropertyValue<decimal>("QCMY", ref fQCMY, value); }
        }

        decimal fQCSY;
        public decimal QCSY
        {
            get { return fQCSY; }
            set { SetPropertyValue<decimal>("QCSY", ref fQCSY, value); }
        }

        long fJHSL;
        public long JHSL
        {
            get { return fJHSL; }
            set { SetPropertyValue<long>("JHSL", ref fJHSL, value); }
        }

        decimal fJHMY;
        public decimal JHMY
        {
            get { return fJHMY; }
            set { SetPropertyValue<decimal>("JHMY", ref fJHMY, value); }
        }

        decimal fJHSY;
        public decimal JHSY
        {
            get { return fJHSY; }
            set { SetPropertyValue<decimal>("JHSY", ref fJHSY, value); }
        }

        long fXTSL;
        public long XTSL
        {
            get { return fXTSL; }
            set { SetPropertyValue<long>("XTSL", ref fXTSL, value); }
        }

        decimal fXTMY;
        public decimal XTMY
        {
            get { return fXTMY; }
            set { SetPropertyValue<decimal>("XTMY", ref fXTMY, value); }
        }

        decimal fXTSY;
        public decimal XTSY
        {
            get { return fXTSY; }
            set { SetPropertyValue<decimal>("XTSY", ref fXTSY, value); }
        }


        long fDRSL;
        public long DRSL
        {
            get { return fDRSL; }
            set { SetPropertyValue<long>("DRSL", ref fDRSL, value); }
        }

        decimal fDRMY;
        public decimal DRMY
        {
            get { return fDRMY; }
            set { SetPropertyValue<decimal>("DRMY", ref fDRMY, value); }
        }

        decimal fDRSY;
        public decimal DRSY
        {
            get { return fDRSY; }
            set { SetPropertyValue<decimal>("DRSY", ref fDRSY, value); }
        }

        long fJRSL;
        public long JRSL
        {
            get { return fJRSL; }
            set { SetPropertyValue<long>("JRSL", ref fJRSL, value); }
        }

        decimal fJRMY;
        public decimal JRMY
        {
            get { return fJRMY; }
            set { SetPropertyValue<decimal>("JRMY", ref fJRMY, value); }
        }

        decimal fJRSY;
        public decimal JRSY
        {
            get { return fJRSY; }
            set { SetPropertyValue<decimal>("JRSY", ref fJRSY, value); }
        }

        long fXSSL;
        public long XSSL
        {
            get { return fXSSL; }
            set { SetPropertyValue<long>("XSSL", ref fXSSL, value); }
        }

        decimal fXSMY;
        public decimal XSMY
        {
            get { return fXSMY; }
            set { SetPropertyValue<decimal>("XSMY", ref fXSMY, value); }
        }

        decimal fXSSY;
        public decimal XSSY
        {
            get { return fXSSY; }
            set { SetPropertyValue<decimal>("XSSY", ref fXSSY, value); }
        }


        long fJTSL;
        public long JTSL
        {
            get { return fJTSL; }
            set { SetPropertyValue<long>("JTSL", ref fJTSL, value); }
        }

        decimal fJTMY;
        public decimal JTMY
        {
            get { return fJTMY; }
            set { SetPropertyValue<decimal>("JTMY", ref fJTMY, value); }
        }

        decimal fJTSY;
        public decimal JTSY
        {
            get { return fJTSY; }
            set { SetPropertyValue<decimal>("JTSY", ref fJTSY, value); }
        }

        long fDCSL;
        public long DCSL
        {
            get { return fDCSL; }
            set { SetPropertyValue<long>("DCSL", ref fDCSL, value); }
        }

        decimal fDCMY;
        public decimal DCMY
        {
            get { return fDCMY; }
            set { SetPropertyValue<decimal>("DCMY", ref fDCMY, value); }
        }

        decimal fDCSY;
        public decimal DCSY
        {
            get { return fDCSY; }
            set { SetPropertyValue<decimal>("DCSY", ref fDCSY, value); }
        }







        long fJCSL;
        public long JCSL
        {
            get { return fJCSL; }
            set { SetPropertyValue<long>("JCSL", ref fJCSL, value); }
        }

        decimal fJCMY;
        public decimal JCMY
        {
            get { return fJCMY; }
            set { SetPropertyValue<decimal>("JCMY", ref fJCMY, value); }
        }

        decimal fJCSY;
        public decimal JCSY
        {
            get { return fJCSY; }
            set { SetPropertyValue<decimal>("JCSY", ref fJCSY, value); }
        }


        long fBFSL;
        public long BFSL
        {
            get { return fBFSL; }
            set { SetPropertyValue<long>("BFSL", ref fBFSL, value); }
        }

        decimal fBFMY;
        public decimal BFMY
        {
            get { return fBFMY; }
            set { SetPropertyValue<decimal>("BFMY", ref fBFMY, value); }
        }

        decimal fBFSY;
        public decimal BFSY
        {
            get { return fBFSY; }
            set { SetPropertyValue<decimal>("BFSY", ref fBFSY, value); }
        }

        long fSYSL;
        public long SYSL
        {
            get { return fSYSL; }
            set { SetPropertyValue<long>("SYSL", ref fSYSL, value); }
        }

        decimal fSYMY;
        public decimal SYMY
        {
            get { return fSYMY; }
            set { SetPropertyValue<decimal>("SYMY", ref fSYMY, value); }
        }

        decimal fSYSY;
        public decimal SYSY
        {
            get { return fSYSY; }
            set { SetPropertyValue<decimal>("SYSY", ref fSYSY, value); }
        }


        long fQMKC;
        public long QMKC
        {
            get { return fQMKC; }
            set { SetPropertyValue<long>("QMKC", ref fQMKC, value); }
        }

        decimal fQMMY;
        public decimal QMMY
        {
            get { return fQMMY; }
            set { SetPropertyValue<decimal>("QMMY", ref fQMMY, value); }
        }

        decimal fQMSY;
        public decimal QMSY
        {
            get { return fQMSY; }
            set { SetPropertyValue<decimal>("QMSY", ref fQMSY, value); }
        }


        long fZRSL;
        public long ZRSL
        {
            get { return fZRSL; }
            set { SetPropertyValue<long>("ZRSL", ref fZRSL, value); }
        }

        decimal fZRMY;
        public decimal ZRMY
        {
            get { return fZRMY; }
            set { SetPropertyValue<decimal>("ZRMY", ref fZRMY, value); }
        }

        decimal fZRSY;
        public decimal ZRSY
        {
            get { return fZRSY; }
            set { SetPropertyValue<decimal>("ZRSY", ref fZRSY, value); }
        }

        long fZCSL;
        public long ZCSL
        {
            get { return fZCSL; }
            set { SetPropertyValue<long>("ZCSL", ref fZCSL, value); }
        }

        decimal fZCMY;
        public decimal ZCMY
        {
            get { return fZCMY; }
            set { SetPropertyValue<decimal>("ZCMY", ref fZCMY, value); }
        }

        decimal fZCSY;
        public decimal ZCSY
        {
            get { return fZCSY; }
            set { SetPropertyValue<decimal>("ZCSY", ref fZCSY, value); }
        }





        string fZT;
        [Size(4)]
        public string ZT
        {
            get { return fZT; }
            set { SetPropertyValue<string>("ZT", ref fZT, value); }
        }

        string fYZT;
        [Size(4)]
        public string YZT
        {
            get { return fYZT; }
            set { SetPropertyValue<string>("YZT", ref fYZT, value); }
        }

        string fBZ;
        [Size(100)]
        public string BZ
        {
            get { return fBZ; }
            set { SetPropertyValue<string>("BZ", ref fBZ, value); }
        }

        long fPFSL;
        public long PFSL
        {
            get { return fPFSL; }
            set { SetPropertyValue<long>("PFSL", ref fPFSL, value); }
        }

        decimal fPFMY;
        public decimal PFMY
        {
            get { return fPFMY; }
            set { SetPropertyValue<decimal>("PFMY", ref fPFMY, value); }
        }

        decimal fPFSY;
        public decimal PFSY
        {
            get { return fPFSY; }
            set { SetPropertyValue<decimal>("PFSY", ref fPFSY, value); }
        }

        long fYTSL;
        public long YTSL
        {
            get { return fYTSL; }
            set { SetPropertyValue<long>("YTSL", ref fYTSL, value); }
        }

        decimal fYTSY;
        public decimal YTSY
        {
            get { return fYTSY; }
            set { SetPropertyValue<decimal>("YTSY", ref fYTSY, value); }
        }

        decimal fYTMY;
        public decimal YTMY
        {
            get { return fYTMY; }
            set { SetPropertyValue<decimal>("YTMY", ref fYTMY, value); }
        }


        decimal fDJ;
        public decimal DJ
        {
            get { return fDJ; }
            set { SetPropertyValue<decimal>("DJ", ref fDJ, value); }
        }



        string fZTIDMC;
        [Size(22)]
        public string ZTIDMC
        {
            get { return fZTIDMC; }
            set { SetPropertyValue<string>("ZTIDMC", ref fZTIDMC, value); }
        }


        string fZTMC;
        [Size(22)]
        public string ZTMC
        {
            get { return fZTMC; }
            set { SetPropertyValue<string>("ZTMC", ref fZTMC, value); }
        }

        string fBMMC;
        [Size(22)]
        public string BMMC
        {
            get { return fBMMC; }
            set { SetPropertyValue<string>("BMMC", ref fBMMC, value); }
        }

        string fSPMC;
        [Size(22)]
        public string SPMC
        {
            get { return fSPMC; }
            set { SetPropertyValue<string>("SPMC", ref fSPMC, value); }
        }

        string fWLBMMC;
        [Size(22)]
        public string WLBMMC
        {
            get { return fWLBMMC; }
            set { SetPropertyValue<string>("WLBMMC", ref fWLBMMC, value); }
        }


        string fGYSID;
        [Size(16)]
        public string GYSID
        {
            get { return fGYSID; }
            set { SetPropertyValue<string>("GYSID", ref fGYSID, value); }
        }


        string fJHFSID;
        [Size(16)]
        public string JHFSID
        {
            get { return fJHFSID; }
            set { SetPropertyValue<string>("JHFSID", ref fJHFSID, value); }
        }


        decimal fJZ;
        public decimal JZ
        {
            get { return fJZ; }
            set { SetPropertyValue<decimal>("JZ", ref fJZ, value); }
        }

        decimal fJJ;
        public decimal JJ
        {
            get { return fJJ; }
            set { SetPropertyValue<decimal>("JJ", ref fJJ, value); }
        }

        decimal fXZ;
        public decimal XZ
        {
            get { return fXZ; }
            set { SetPropertyValue<decimal>("XZ", ref fXZ, value); }
        }


        decimal fXJ;
        public decimal XJ
        {
            get { return fXJ; }
            set { SetPropertyValue<decimal>("XJ", ref fXJ, value); }
        }




        string fZDDM;
        [Size(15)]
        public string ZDDM
        {
            get { return fZDDM; }
            set { SetPropertyValue<string>("ZDDM", ref fZDDM, value); }
        }

        string fJTBMSPKFMXID;
        [Size(15)]
        public string JTBMSPKFMXID
        {
            get { return fJTBMSPKFMXID; }
            set { SetPropertyValue<string>("JTBMSPKFMXID", ref fJTBMSPKFMXID, value); }
        }


        DateTime fJZRQ;
        public DateTime JZRQ
        {
            get { return fJZRQ; }
            set { SetPropertyValue<DateTime>("JZRQ", ref fJZRQ, value); }
        }




        public VIEW_JT_C_ZTBMSP_KFMX(Session session) : base(session) { }
        public VIEW_JT_C_ZTBMSP_KFMX() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }
    public class VIEW_JT_C_CGJSDMX_JDXS : XPLiteObject
    {
        string fCGJSDMXID;
        [Key]
        [Size(16)]
        public string CGJSDMXID
        {
            get { return fCGJSDMXID; }
            set { SetPropertyValue<string>("CGJSDMXID", ref fCGJSDMXID, value); }
        }

        string fCGJSDID;
        [Size(16)]
        public string CGJSDID
        {
            get { return fCGJSDID; }
            set { SetPropertyValue<string>("CGJSDID", ref fCGJSDID, value); }
        }

        string fSJLX;
        [Size(16)]
        public string SJLX
        {
            get { return fSJLX; }
            set { SetPropertyValue<string>("SJLX", ref fSJLX, value); }
        }

        string fSHDH;
        [Size(16)]
        public string SHDH
        {
            get { return fSHDH; }
            set { SetPropertyValue<string>("SHDH", ref fSHDH, value); }
        }

        long fSHSL;
        public long SHSL
        {
            get { return fSHSL; }
            set { SetPropertyValue<long>("SHSL", ref fSHSL, value); }
        }

        decimal fSHSY;
        public decimal SHSY
        {
            get { return fSHSY; }
            set { SetPropertyValue<decimal>("SHSY", ref fSHSY, value); }
        }

        decimal fSHMY;
        public decimal SHMY
        {
            get { return fSHMY; }
            set { SetPropertyValue<decimal>("SHMY", ref fSHMY, value); }
        }

        string fDWMC;
        [Size(100)]
        public string DWMC
        {
            get { return fDWMC; }
            set { SetPropertyValue<string>("DWMC", ref fDWMC, value); }
        }

        string fCGJSDH;
        [Size(16)]
        public string CGJSDH
        {
            get { return fCGJSDH; }
            set { SetPropertyValue<string>("CGJSDH", ref fCGJSDH, value); }
        }


        public VIEW_JT_C_CGJSDMX_JDXS(Session session) : base(session) { }
        public VIEW_JT_C_CGJSDMX_JDXS() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }


    public static class XINHUASprocHelper
    {

    }


}
