using System;
using DevExpress.Xpo;
namespace XINHUA
{

    public class TEMP_SAVE_ID : XPLiteObject
    {
        string fID;
        [Size(16)]
        public string ID
        {
            get { return fID; }
            set { SetPropertyValue<string>("ID", ref fID, value); }
        }
        string fTEMPID;
        [Key]
        [Size(16)]
        public string TEMPID
        {
            get { return fTEMPID; }
            set { SetPropertyValue<string>("TEMPID", ref fTEMPID, value); }
        }
        string fWLBMID;
        [Size(16)]
        public string WLBMID
        {
            get { return fWLBMID; }
            set { SetPropertyValue<string>("WLBMID", ref fWLBMID, value); }
        }
        string fUSERID;
        [Size(16)]
        public string USERID
        {
            get { return fUSERID; }
            set { SetPropertyValue<string>("USERID", ref fUSERID, value); }
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
        long fSL;
        public long SL
        {
            get { return fSL; }
            set { SetPropertyValue<long>("SL", ref fSL, value); }
        }
        public TEMP_SAVE_ID(Session session) : base(session) { }
        public TEMP_SAVE_ID() : base(Session.DefaultSession) { }
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

    public class SYS_ROLE : XPLiteObject
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
            set { SetPropertyValue<string>("SUPER_ID", ref fSUPER_ID, value); }
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
        [Size(1)]
        public string TYPE
        {
            get { return fTYPE; }
            set { SetPropertyValue<string>("TYPE", ref fTYPE, value); }
        }
        byte fROLE_LEVEL;
        public byte ROLE_LEVEL
        {
            get { return fROLE_LEVEL; }
            set { SetPropertyValue<byte>("ROLE_LEVEL", ref fROLE_LEVEL, value); }
        }
        public SYS_ROLE(Session session) : base(session) { }
        public SYS_ROLE() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class SYS_GROUP_USER : XPLiteObject
    {
        string fID;
        [Key]
        [Size(16)]
        public string ID
        {
            get { return fID; }
            set { SetPropertyValue<string>("ID", ref fID, value); }
        }
        string fGROUPID;
        [Size(16)]
        public string GROUPID
        {
            get { return fGROUPID; }
            set { SetPropertyValue<string>("GROUPID", ref fGROUPID, value); }
        }
        string fUSERID;
        [Size(16)]
        public string USERID
        {
            get { return fUSERID; }
            set { SetPropertyValue<string>("USERID", ref fUSERID, value); }
        }
        string fDESCRIPTION;
        [Size(120)]
        public string DESCRIPTION
        {
            get { return fDESCRIPTION; }
            set { SetPropertyValue<string>("DESCRIPTION", ref fDESCRIPTION, value); }
        }
        public SYS_GROUP_USER(Session session) : base(session) { }
        public SYS_GROUP_USER() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class JT_G_CGSHMX_TEST : XPLiteObject
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
        public JT_G_CGSHMX_TEST(Session session) : base(session) { }
        public JT_G_CGSHMX_TEST() : base(Session.DefaultSession) { }
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

    public class JT_X_XSD : XPLiteObject
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
        public JT_X_XSD(Session session) : base(session) { }
        public JT_X_XSD() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class SYS_ZTBM : XPLiteObject
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
        public SYS_ZTBM(Session session) : base(session) { }
        public SYS_ZTBM() : base(Session.DefaultSession) { }
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

    public class JT_J_CBSLX : XPLiteObject
    {
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
        public JT_J_CBSLX(Session session) : base(session) { }
        public JT_J_CBSLX() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class JT_J_DWXX : XPLiteObject
    {
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
        public JT_J_DWXX(Session session) : base(session) { }
        public JT_J_DWXX() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class SYS_ROLE_MODULE : XPLiteObject
    {
        string fID;
        [Key]
        [Size(16)]
        public string ID
        {
            get { return fID; }
            set { SetPropertyValue<string>("ID", ref fID, value); }
        }
        string fROLE_ID;
        [Size(16)]
        public string ROLE_ID
        {
            get { return fROLE_ID; }
            set { SetPropertyValue<string>("ROLE_ID", ref fROLE_ID, value); }
        }
        string fMODULE_ID;
        [Size(16)]
        public string MODULE_ID
        {
            get { return fMODULE_ID; }
            set { SetPropertyValue<string>("MODULE_ID", ref fMODULE_ID, value); }
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
        DateTime fEFF_DATE;
        public DateTime EFF_DATE
        {
            get { return fEFF_DATE; }
            set { SetPropertyValue<DateTime>("EFF_DATE", ref fEFF_DATE, value); }
        }
        DateTime fEXP_DATE;
        public DateTime EXP_DATE
        {
            get { return fEXP_DATE; }
            set { SetPropertyValue<DateTime>("EXP_DATE", ref fEXP_DATE, value); }
        }
        public SYS_ROLE_MODULE(Session session) : base(session) { }
        public SYS_ROLE_MODULE() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class JT_G_CGSH_TEST : XPLiteObject
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
        public JT_G_CGSH_TEST(Session session) : base(session) { }
        public JT_G_CGSH_TEST() : base(Session.DefaultSession) { }
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

    public class SYS_USER_ROLE : XPLiteObject
    {
        string fDEPTID;
        [Size(16)]
        public string DEPTID
        {
            get { return fDEPTID; }
            set { SetPropertyValue<string>("DEPTID", ref fDEPTID, value); }
        }
        string fID;
        [Key]
        [Size(16)]
        public string ID
        {
            get { return fID; }
            set { SetPropertyValue<string>("ID", ref fID, value); }
        }
        string fUSERNAME;
        [Size(16)]
        public string USERNAME
        {
            get { return fUSERNAME; }
            set { SetPropertyValue<string>("USERNAME", ref fUSERNAME, value); }
        }
        string fROLEID;
        [Size(16)]
        public string ROLEID
        {
            get { return fROLEID; }
            set { SetPropertyValue<string>("ROLEID", ref fROLEID, value); }
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
        DateTime fEFF_DATE;
        public DateTime EFF_DATE
        {
            get { return fEFF_DATE; }
            set { SetPropertyValue<DateTime>("EFF_DATE", ref fEFF_DATE, value); }
        }
        DateTime fEXP_DATE;
        public DateTime EXP_DATE
        {
            get { return fEXP_DATE; }
            set { SetPropertyValue<DateTime>("EXP_DATE", ref fEXP_DATE, value); }
        }
        public SYS_USER_ROLE(Session session) : base(session) { }
        public SYS_USER_ROLE() : base(Session.DefaultSession) { }
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
        [Size(2)]
        public string ZT
        {
            get { return fZT; }
            set { SetPropertyValue<string>("ZT", ref fZT, value); }
        }
        public BASE_DEPARTTYPE(Session session) : base(session) { }
        public BASE_DEPARTTYPE() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class SYS_GROUP : XPLiteObject
    {
        string fGROUPID;
        [Key]
        [Size(16)]
        public string GROUPID
        {
            get { return fGROUPID; }
            set { SetPropertyValue<string>("GROUPID", ref fGROUPID, value); }
        }
        string fGROUPNAME;
        [Size(20)]
        public string GROUPNAME
        {
            get { return fGROUPNAME; }
            set { SetPropertyValue<string>("GROUPNAME", ref fGROUPNAME, value); }
        }
        string fDESCRIPTION;
        [Size(120)]
        public string DESCRIPTION
        {
            get { return fDESCRIPTION; }
            set { SetPropertyValue<string>("DESCRIPTION", ref fDESCRIPTION, value); }
        }
        public SYS_GROUP(Session session) : base(session) { }
        public SYS_GROUP() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class JT_X_XSDMX : XPLiteObject
    {
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
        string fPFDMXID;
        [Size(16)]
        public string PFDMXID
        {
            get { return fPFDMXID; }
            set { SetPropertyValue<string>("PFDMXID", ref fPFDMXID, value); }
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
        public JT_X_XSDMX(Session session) : base(session) { }
        public JT_X_XSDMX() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class SYS_GROUP_ROLE : XPLiteObject
    {
        string fID;
        [Key]
        [Size(16)]
        public string ID
        {
            get { return fID; }
            set { SetPropertyValue<string>("ID", ref fID, value); }
        }
        string fGROUPID;
        [Size(16)]
        public string GROUPID
        {
            get { return fGROUPID; }
            set { SetPropertyValue<string>("GROUPID", ref fGROUPID, value); }
        }
        string fROLEID;
        [Size(16)]
        public string ROLEID
        {
            get { return fROLEID; }
            set { SetPropertyValue<string>("ROLEID", ref fROLEID, value); }
        }
        public SYS_GROUP_ROLE(Session session) : base(session) { }
        public SYS_GROUP_ROLE() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class SYS_DEPARTMENT : XPLiteObject
    {
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
        public SYS_DEPARTMENT(Session session) : base(session) { }
        public SYS_DEPARTMENT() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class SYS_USER : XPLiteObject
    {
        string fUSERID;
        [Key]
        [Size(16)]
        public string USERID
        {
            get { return fUSERID; }
            set { SetPropertyValue<string>("USERID", ref fUSERID, value); }
        }
        string fEMPID;
        [Size(16)]
        public string EMPID
        {
            get { return fEMPID; }
            set { SetPropertyValue<string>("EMPID", ref fEMPID, value); }
        }
        string fUSERNAME;
        [Size(16)]
        public string USERNAME
        {
            get { return fUSERNAME; }
            set { SetPropertyValue<string>("USERNAME", ref fUSERNAME, value); }
        }
        string fISLOCK;
        [Size(1)]
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
        string fLSKHDNO;
        [Size(20)]
        public string LSKHDNO
        {
            get { return fLSKHDNO; }
            set { SetPropertyValue<string>("LSKHDNO", ref fLSKHDNO, value); }
        }
        string fJCDJCNO;
        [Size(20)]
        public string JCDJCNO
        {
            get { return fJCDJCNO; }
            set { SetPropertyValue<string>("JCDJCNO", ref fJCDJCNO, value); }
        }
        string fYTHPTNO;
        [Size(20)]
        public string YTHPTNO
        {
            get { return fYTHPTNO; }
            set { SetPropertyValue<string>("YTHPTNO", ref fYTHPTNO, value); }
        }
        public SYS_USER(Session session) : base(session) { }
        public SYS_USER() : base(Session.DefaultSession) { }
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
    public static class XINHUASprocHelper
    {
    }


}
