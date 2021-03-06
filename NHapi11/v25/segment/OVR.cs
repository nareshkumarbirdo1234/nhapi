using System;
using ca.uhn.hl7v2.model;
using ca.uhn.hl7v2.model.v25.datatype;

using ca.uhn.log;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;

namespace ca.uhn.hl7v2.model.v25.segment{

/**
 * <p>Represents an HL7 OVR message segment. 
 * This segment has the following fields:</p><p>
 * OVR-1: Business Rule Override Type (CWE)<br> 
 * OVR-2: Business Rule Override Code (CWE)<br> 
 * OVR-3: Override Comments (TX)<br> 
 * OVR-4: Override Entered By (XCN)<br> 
 * OVR-5: Override Authorized By (XCN)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class OVR : AbstractSegment  {

  /**
   * Creates a OVR (Override Segment) segment object that belongs to the given 
   * message.  
   */
  public OVR(Group parent, ModelClassFactory factory) : base(parent,factory) {
    Message message = Message;
    try {
       this.add(typeof(CWE), false, 1, 705, new System.Object[]{message}, "Business Rule Override Type");
       this.add(typeof(CWE), false, 1, 705, new System.Object[]{message}, "Business Rule Override Code");
       this.add(typeof(TX), false, 1, 200, new System.Object[]{message}, "Override Comments");
       this.add(typeof(XCN), false, 1, 250, new System.Object[]{message}, "Override Entered By");
       this.add(typeof(XCN), false, 1, 250, new System.Object[]{message}, "Override Authorized By");
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + this.getStructureName(), he);
    }
  }

	/**
	* Returns Business Rule Override Type(OVR-1).
	*/
	public CWE BusinessRuleOverrideType
	{
		get{
			CWE ret = null;
			try
			{
			Type t = this.getField(1, 0);
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
	* Returns Business Rule Override Code(OVR-2).
	*/
	public CWE BusinessRuleOverrideCode
	{
		get{
			CWE ret = null;
			try
			{
			Type t = this.getField(2, 0);
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
	* Returns Override Comments(OVR-3).
	*/
	public TX OverrideComments
	{
		get{
			TX ret = null;
			try
			{
			Type t = this.getField(3, 0);
				ret = (TX)t;
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
	* Returns Override Entered By(OVR-4).
	*/
	public XCN OverrideEnteredBy
	{
		get{
			XCN ret = null;
			try
			{
			Type t = this.getField(4, 0);
				ret = (XCN)t;
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
	* Returns Override Authorized By(OVR-5).
	*/
	public XCN OverrideAuthorizedBy
	{
		get{
			XCN ret = null;
			try
			{
			Type t = this.getField(5, 0);
				ret = (XCN)t;
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