using System;
using ca.uhn.hl7v2.model;
using ca.uhn.hl7v2.model.v25.datatype;

using ca.uhn.log;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;

namespace ca.uhn.hl7v2.model.v25.segment{

/**
 * <p>Represents an HL7 AIL message segment. 
 * This segment has the following fields:</p><p>
 * AIL-1: Set ID - AIL (SI)<br> 
 * AIL-2: Segment Action Code (ID)<br> 
 * AIL-3: Location Resource ID (PL)<br> 
 * AIL-4: Location Type-AIL (CE)<br> 
 * AIL-5: Location Group (CE)<br> 
 * AIL-6: Start Date/Time (TS)<br> 
 * AIL-7: Start Date/Time Offset (NM)<br> 
 * AIL-8: Start Date/Time Offset Units (CE)<br> 
 * AIL-9: Duration (NM)<br> 
 * AIL-10: Duration Units (CE)<br> 
 * AIL-11: Allow Substitution Code (IS)<br> 
 * AIL-12: Filler Status Code (CE)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class AIL : AbstractSegment  {

  /**
   * Creates a AIL (Appointment Information _ Location Resource) segment object that belongs to the given 
   * message.  
   */
  public AIL(Group parent, ModelClassFactory factory) : base(parent,factory) {
    Message message = Message;
    try {
       this.add(typeof(SI), true, 1, 4, new System.Object[]{message}, "Set ID - AIL");
       this.add(typeof(ID), false, 1, 3, new System.Object[]{message, 206}, "Segment Action Code");
       this.add(typeof(PL), false, 0, 80, new System.Object[]{message}, "Location Resource ID");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Location Type-AIL");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Location Group");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Start Date/Time");
       this.add(typeof(NM), false, 1, 20, new System.Object[]{message}, "Start Date/Time Offset");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Start Date/Time Offset Units");
       this.add(typeof(NM), false, 1, 20, new System.Object[]{message}, "Duration");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Duration Units");
       this.add(typeof(IS), false, 1, 10, new System.Object[]{message, 279}, "Allow Substitution Code");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Filler Status Code");
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + this.getStructureName(), he);
    }
  }

	/**
	* Returns Set ID - AIL(AIL-1).
	*/
	public SI SetIDAIL
	{
		get{
			SI ret = null;
			try
			{
			Type t = this.getField(1, 0);
				ret = (SI)t;
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
	* Returns Segment Action Code(AIL-2).
	*/
	public ID SegmentActionCode
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(2, 0);
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
	* Returns a single repetition of Location Resource ID(AIL-3).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public PL getLocationResourceID(int rep)
	{
			PL ret = null;
			try
			{
			Type t = this.getField(3, rep);
				ret = (PL)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Location Resource ID (AIL-3).
   */
  public PL[] getLocationResourceID() {
     PL[] ret = null;
    try {
        Type[] t = this.getField(3);  
        ret = new PL[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (PL)t[i];
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
	* Returns Location Type-AIL(AIL-4).
	*/
	public CE LocationTypeAIL
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(4, 0);
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
	* Returns Location Group(AIL-5).
	*/
	public CE LocationGroup
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(5, 0);
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
	* Returns Start Date/Time(AIL-6).
	*/
	public TS StartDateTime
	{
		get{
			TS ret = null;
			try
			{
			Type t = this.getField(6, 0);
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
	* Returns Start Date/Time Offset(AIL-7).
	*/
	public NM StartDateTimeOffset
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(7, 0);
				ret = (NM)t;
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
	* Returns Start Date/Time Offset Units(AIL-8).
	*/
	public CE StartDateTimeOffsetUnits
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(8, 0);
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
	* Returns Duration(AIL-9).
	*/
	public NM Duration
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(9, 0);
				ret = (NM)t;
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
	* Returns Duration Units(AIL-10).
	*/
	public CE DurationUnits
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(10, 0);
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
	* Returns Allow Substitution Code(AIL-11).
	*/
	public IS AllowSubstitutionCode
	{
		get{
			IS ret = null;
			try
			{
			Type t = this.getField(11, 0);
				ret = (IS)t;
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
	* Returns Filler Status Code(AIL-12).
	*/
	public CE FillerStatusCode
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(12, 0);
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


}}