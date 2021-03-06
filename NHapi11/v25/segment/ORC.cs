using System;
using ca.uhn.hl7v2.model;
using ca.uhn.hl7v2.model.v25.datatype;

using ca.uhn.log;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;

namespace ca.uhn.hl7v2.model.v25.segment{

/**
 * <p>Represents an HL7 ORC message segment. 
 * This segment has the following fields:</p><p>
 * ORC-1: Order Control (ID)<br> 
 * ORC-2: Placer Order Number (EI)<br> 
 * ORC-3: Filler Order Number (EI)<br> 
 * ORC-4: Placer Group Number (EI)<br> 
 * ORC-5: Order Status (ID)<br> 
 * ORC-6: Response Flag (ID)<br> 
 * ORC-7: Quantity/Timing (TQ)<br> 
 * ORC-8: Parent (EIP)<br> 
 * ORC-9: Date/Time of Transaction (TS)<br> 
 * ORC-10: Entered By (XCN)<br> 
 * ORC-11: Verified By (XCN)<br> 
 * ORC-12: Ordering Provider (XCN)<br> 
 * ORC-13: Enterer's Location (PL)<br> 
 * ORC-14: Call Back Phone Number (XTN)<br> 
 * ORC-15: Order Effective Date/Time (TS)<br> 
 * ORC-16: Order Control Code Reason (CE)<br> 
 * ORC-17: Entering Organization (CE)<br> 
 * ORC-18: Entering Device (CE)<br> 
 * ORC-19: Action By (XCN)<br> 
 * ORC-20: Advanced Beneficiary Notice Code (CE)<br> 
 * ORC-21: Ordering Facility Name (XON)<br> 
 * ORC-22: Ordering Facility Address (XAD)<br> 
 * ORC-23: Ordering Facility Phone Number (XTN)<br> 
 * ORC-24: Ordering Provider Address (XAD)<br> 
 * ORC-25: Order Status Modifier (CWE)<br> 
 * ORC-26: Advanced Beneficiary Notice Override Reason (CWE)<br> 
 * ORC-27: Filler's Expected Availability Date/Time (TS)<br> 
 * ORC-28: Confidentiality Code (CWE)<br> 
 * ORC-29: Order Type (CWE)<br> 
 * ORC-30: Enterer Authorization Mode (CNE)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class ORC : AbstractSegment  {

  /**
   * Creates a ORC (Common Order) segment object that belongs to the given 
   * message.  
   */
  public ORC(Group parent, ModelClassFactory factory) : base(parent,factory) {
    Message message = Message;
    try {
       this.add(typeof(ID), true, 1, 2, new System.Object[]{message, 119}, "Order Control");
       this.add(typeof(EI), false, 1, 22, new System.Object[]{message}, "Placer Order Number");
       this.add(typeof(EI), false, 1, 22, new System.Object[]{message}, "Filler Order Number");
       this.add(typeof(EI), false, 1, 22, new System.Object[]{message}, "Placer Group Number");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 38}, "Order Status");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 121}, "Response Flag");
       this.add(typeof(TQ), false, 0, 200, new System.Object[]{message}, "Quantity/Timing");
       this.add(typeof(EIP), false, 1, 200, new System.Object[]{message}, "Parent");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Date/Time of Transaction");
       this.add(typeof(XCN), false, 0, 250, new System.Object[]{message}, "Entered By");
       this.add(typeof(XCN), false, 0, 250, new System.Object[]{message}, "Verified By");
       this.add(typeof(XCN), false, 0, 250, new System.Object[]{message}, "Ordering Provider");
       this.add(typeof(PL), false, 1, 80, new System.Object[]{message}, "Enterer's Location");
       this.add(typeof(XTN), false, 0, 250, new System.Object[]{message}, "Call Back Phone Number");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Order Effective Date/Time");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Order Control Code Reason");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Entering Organization");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Entering Device");
       this.add(typeof(XCN), false, 0, 250, new System.Object[]{message}, "Action By");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Advanced Beneficiary Notice Code");
       this.add(typeof(XON), false, 0, 250, new System.Object[]{message}, "Ordering Facility Name");
       this.add(typeof(XAD), false, 0, 250, new System.Object[]{message}, "Ordering Facility Address");
       this.add(typeof(XTN), false, 0, 250, new System.Object[]{message}, "Ordering Facility Phone Number");
       this.add(typeof(XAD), false, 0, 250, new System.Object[]{message}, "Ordering Provider Address");
       this.add(typeof(CWE), false, 1, 250, new System.Object[]{message}, "Order Status Modifier");
       this.add(typeof(CWE), false, 1, 60, new System.Object[]{message}, "Advanced Beneficiary Notice Override Reason");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Filler's Expected Availability Date/Time");
       this.add(typeof(CWE), false, 1, 250, new System.Object[]{message}, "Confidentiality Code");
       this.add(typeof(CWE), false, 1, 250, new System.Object[]{message}, "Order Type");
       this.add(typeof(CNE), false, 1, 250, new System.Object[]{message}, "Enterer Authorization Mode");
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + this.getStructureName(), he);
    }
  }

	/**
	* Returns Order Control(ORC-1).
	*/
	public ID OrderControl
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(1, 0);
				ret = (ID)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Placer Order Number(ORC-2).
	*/
	public EI PlacerOrderNumber
	{
		get{
			EI ret = null;
			try
			{
			Type t = this.getField(2, 0);
				ret = (EI)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Filler Order Number(ORC-3).
	*/
	public EI FillerOrderNumber
	{
		get{
			EI ret = null;
			try
			{
			Type t = this.getField(3, 0);
				ret = (EI)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Placer Group Number(ORC-4).
	*/
	public EI PlacerGroupNumber
	{
		get{
			EI ret = null;
			try
			{
			Type t = this.getField(4, 0);
				ret = (EI)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Order Status(ORC-5).
	*/
	public ID OrderStatus
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(5, 0);
				ret = (ID)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Response Flag(ORC-6).
	*/
	public ID ResponseFlag
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(6, 0);
				ret = (ID)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns a single repetition of Quantity/Timing(ORC-7).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public TQ getQuantityTiming(int rep)
	{
			TQ ret = null;
			try
			{
			Type t = this.getField(7, rep);
				ret = (TQ)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Quantity/Timing (ORC-7).
   */
  public TQ[] getQuantityTiming() {
     TQ[] ret = null;
    try {
        Type[] t = this.getField(7);  
        ret = new TQ[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (TQ)t[i];
        }
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
    } catch (System.Exception cce) {
        HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
  }
 return ret;
}

	/**
	* Returns Parent(ORC-8).
	*/
	public EIP Parent
	{
		get{
			EIP ret = null;
			try
			{
			Type t = this.getField(8, 0);
				ret = (EIP)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Date/Time of Transaction(ORC-9).
	*/
	public TS DateTimeOfTransaction
	{
		get{
			TS ret = null;
			try
			{
			Type t = this.getField(9, 0);
				ret = (TS)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns a single repetition of Entered By(ORC-10).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public XCN getEnteredBy(int rep)
	{
			XCN ret = null;
			try
			{
			Type t = this.getField(10, rep);
				ret = (XCN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Entered By (ORC-10).
   */
  public XCN[] getEnteredBy() {
     XCN[] ret = null;
    try {
        Type[] t = this.getField(10);  
        ret = new XCN[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (XCN)t[i];
        }
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
    } catch (System.Exception cce) {
        HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
  }
 return ret;
}

	/**
	* Returns a single repetition of Verified By(ORC-11).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public XCN getVerifiedBy(int rep)
	{
			XCN ret = null;
			try
			{
			Type t = this.getField(11, rep);
				ret = (XCN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Verified By (ORC-11).
   */
  public XCN[] getVerifiedBy() {
     XCN[] ret = null;
    try {
        Type[] t = this.getField(11);  
        ret = new XCN[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (XCN)t[i];
        }
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
    } catch (System.Exception cce) {
        HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
  }
 return ret;
}

	/**
	* Returns a single repetition of Ordering Provider(ORC-12).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public XCN getOrderingProvider(int rep)
	{
			XCN ret = null;
			try
			{
			Type t = this.getField(12, rep);
				ret = (XCN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Ordering Provider (ORC-12).
   */
  public XCN[] getOrderingProvider() {
     XCN[] ret = null;
    try {
        Type[] t = this.getField(12);  
        ret = new XCN[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (XCN)t[i];
        }
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
    } catch (System.Exception cce) {
        HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
  }
 return ret;
}

	/**
	* Returns Enterer's Location(ORC-13).
	*/
	public PL EntererSLocation
	{
		get{
			PL ret = null;
			try
			{
			Type t = this.getField(13, 0);
				ret = (PL)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns a single repetition of Call Back Phone Number(ORC-14).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public XTN getCallBackPhoneNumber(int rep)
	{
			XTN ret = null;
			try
			{
			Type t = this.getField(14, rep);
				ret = (XTN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Call Back Phone Number (ORC-14).
   */
  public XTN[] getCallBackPhoneNumber() {
     XTN[] ret = null;
    try {
        Type[] t = this.getField(14);  
        ret = new XTN[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (XTN)t[i];
        }
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
    } catch (System.Exception cce) {
        HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
  }
 return ret;
}

	/**
	* Returns Order Effective Date/Time(ORC-15).
	*/
	public TS OrderEffectiveDateTime
	{
		get{
			TS ret = null;
			try
			{
			Type t = this.getField(15, 0);
				ret = (TS)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Order Control Code Reason(ORC-16).
	*/
	public CE OrderControlCodeReason
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(16, 0);
				ret = (CE)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Entering Organization(ORC-17).
	*/
	public CE EnteringOrganization
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(17, 0);
				ret = (CE)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Entering Device(ORC-18).
	*/
	public CE EnteringDevice
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(18, 0);
				ret = (CE)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns a single repetition of Action By(ORC-19).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public XCN getActionBy(int rep)
	{
			XCN ret = null;
			try
			{
			Type t = this.getField(19, rep);
				ret = (XCN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Action By (ORC-19).
   */
  public XCN[] getActionBy() {
     XCN[] ret = null;
    try {
        Type[] t = this.getField(19);  
        ret = new XCN[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (XCN)t[i];
        }
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
    } catch (System.Exception cce) {
        HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
  }
 return ret;
}

	/**
	* Returns Advanced Beneficiary Notice Code(ORC-20).
	*/
	public CE AdvancedBeneficiaryNoticeCode
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(20, 0);
				ret = (CE)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns a single repetition of Ordering Facility Name(ORC-21).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public XON getOrderingFacilityName(int rep)
	{
			XON ret = null;
			try
			{
			Type t = this.getField(21, rep);
				ret = (XON)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Ordering Facility Name (ORC-21).
   */
  public XON[] getOrderingFacilityName() {
     XON[] ret = null;
    try {
        Type[] t = this.getField(21);  
        ret = new XON[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (XON)t[i];
        }
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
    } catch (System.Exception cce) {
        HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
  }
 return ret;
}

	/**
	* Returns a single repetition of Ordering Facility Address(ORC-22).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public XAD getOrderingFacilityAddress(int rep)
	{
			XAD ret = null;
			try
			{
			Type t = this.getField(22, rep);
				ret = (XAD)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Ordering Facility Address (ORC-22).
   */
  public XAD[] getOrderingFacilityAddress() {
     XAD[] ret = null;
    try {
        Type[] t = this.getField(22);  
        ret = new XAD[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (XAD)t[i];
        }
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
    } catch (System.Exception cce) {
        HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
  }
 return ret;
}

	/**
	* Returns a single repetition of Ordering Facility Phone Number(ORC-23).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public XTN getOrderingFacilityPhoneNumber(int rep)
	{
			XTN ret = null;
			try
			{
			Type t = this.getField(23, rep);
				ret = (XTN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Ordering Facility Phone Number (ORC-23).
   */
  public XTN[] getOrderingFacilityPhoneNumber() {
     XTN[] ret = null;
    try {
        Type[] t = this.getField(23);  
        ret = new XTN[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (XTN)t[i];
        }
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
    } catch (System.Exception cce) {
        HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
  }
 return ret;
}

	/**
	* Returns a single repetition of Ordering Provider Address(ORC-24).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public XAD getOrderingProviderAddress(int rep)
	{
			XAD ret = null;
			try
			{
			Type t = this.getField(24, rep);
				ret = (XAD)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Ordering Provider Address (ORC-24).
   */
  public XAD[] getOrderingProviderAddress() {
     XAD[] ret = null;
    try {
        Type[] t = this.getField(24);  
        ret = new XAD[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (XAD)t[i];
        }
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
    } catch (System.Exception cce) {
        HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
  }
 return ret;
}

	/**
	* Returns Order Status Modifier(ORC-25).
	*/
	public CWE OrderStatusModifier
	{
		get{
			CWE ret = null;
			try
			{
			Type t = this.getField(25, 0);
				ret = (CWE)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Advanced Beneficiary Notice Override Reason(ORC-26).
	*/
	public CWE AdvancedBeneficiaryNoticeOverrideReason
	{
		get{
			CWE ret = null;
			try
			{
			Type t = this.getField(26, 0);
				ret = (CWE)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Filler's Expected Availability Date/Time(ORC-27).
	*/
	public TS FillerSExpectedAvailabilityDateTime
	{
		get{
			TS ret = null;
			try
			{
			Type t = this.getField(27, 0);
				ret = (TS)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Confidentiality Code(ORC-28).
	*/
	public CWE ConfidentialityCode
	{
		get{
			CWE ret = null;
			try
			{
			Type t = this.getField(28, 0);
				ret = (CWE)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Order Type(ORC-29).
	*/
	public CWE OrderType
	{
		get{
			CWE ret = null;
			try
			{
			Type t = this.getField(29, 0);
				ret = (CWE)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Enterer Authorization Mode(ORC-30).
	*/
	public CNE EntererAuthorizationMode
	{
		get{
			CNE ret = null;
			try
			{
			Type t = this.getField(30, 0);
				ret = (CNE)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }


}}