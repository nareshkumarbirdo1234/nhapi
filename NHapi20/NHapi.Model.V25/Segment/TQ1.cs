using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V25.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V25.Segment{

///<summary>
/// Represents an HL7 TQ1 message segment. 
/// This segment has the following fields:
/// * TQ1-1: Set ID - TQ1 (SI)
/// * TQ1-2: Quantity (CQ)
/// * TQ1-3: Repeat Pattern (RPT)
/// * TQ1-4: Explicit Time (TM)
/// * TQ1-5: Relative Time and Units (CQ)
/// * TQ1-6: Service Duration (CQ)
/// * TQ1-7: Start date/time (TS)
/// * TQ1-8: End date/time (TS)
/// * TQ1-9: Priority (CWE)
/// * TQ1-10: Condition text (TX)
/// * TQ1-11: Text instruction (TX)
/// * TQ1-12: Conjunction (ID)
/// * TQ1-13: Occurrence duration (CQ)
/// * TQ1-14: Total occurrence's (NM)
/// The get...() methods return data from individual fields.  These methods 
/// do not throw exceptions and may therefore have to handle exceptions internally.  
/// If an exception is handled internally, it is logged and null is returned.  
/// This is not expected to happen - if it does happen this indicates not so much 
/// an exceptional circumstance as a bug in the code for this class.
///</summary>
[Serializable]
public class TQ1 : AbstractSegment  {

  /**
   * Creates a TQ1 (Timing/Quantity) segment object that belongs to the given 
   * message.  
   */
	public TQ1(IGroup parent, IModelClassFactory factory) : base(parent,factory) {
	IMessage message = Message;
    try {
       this.add(typeof(SI), false, 1, 4, new System.Object[]{message}, "Set ID - TQ1");
       this.add(typeof(CQ), false, 1, 20, new System.Object[]{message}, "Quantity");
       this.add(typeof(RPT), false, 0, 540, new System.Object[]{message}, "Repeat Pattern");
       this.add(typeof(TM), false, 0, 20, new System.Object[]{message}, "Explicit Time");
       this.add(typeof(CQ), false, 0, 20, new System.Object[]{message}, "Relative Time and Units");
       this.add(typeof(CQ), false, 1, 20, new System.Object[]{message}, "Service Duration");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Start date/time");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "End date/time");
       this.add(typeof(CWE), false, 0, 250, new System.Object[]{message}, "Priority");
       this.add(typeof(TX), false, 1, 250, new System.Object[]{message}, "Condition text");
       this.add(typeof(TX), false, 1, 250, new System.Object[]{message}, "Text instruction");
       this.add(typeof(ID), false, 1, 10, new System.Object[]{message, 427}, "Conjunction");
       this.add(typeof(CQ), false, 1, 20, new System.Object[]{message}, "Occurrence duration");
       this.add(typeof(NM), false, 1, 10, new System.Object[]{message}, "Total occurrence's");
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + GetType().Name, he);
    }
  }

	///<summary>
	/// Returns Set ID - TQ1(TQ1-1).
	///</summary>
	public SI SetIDTQ1
	{
		get{
			SI ret = null;
			try
			{
			IType t = this.GetField(1, 0);
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

	///<summary>
	/// Returns Quantity(TQ1-2).
	///</summary>
	public CQ Quantity
	{
		get{
			CQ ret = null;
			try
			{
			IType t = this.GetField(2, 0);
				ret = (CQ)t;
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

	///<summary>
	/// Returns a single repetition of Repeat Pattern(TQ1-3).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public RPT getRepeatPattern(int rep)
	{
			RPT ret = null;
			try
			{
			IType t = this.GetField(3, rep);
				ret = (RPT)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Repeat Pattern (TQ1-3).
   ///</summary>
  public RPT[] getRepeatPattern() {
     RPT[] ret = null;
    try {
        IType[] t = this.GetField(3);  
        ret = new RPT[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (RPT)t[i];
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

	///<summary>
	/// Returns a single repetition of Explicit Time(TQ1-4).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public TM getExplicitTime(int rep)
	{
			TM ret = null;
			try
			{
			IType t = this.GetField(4, rep);
				ret = (TM)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Explicit Time (TQ1-4).
   ///</summary>
  public TM[] getExplicitTime() {
     TM[] ret = null;
    try {
        IType[] t = this.GetField(4);  
        ret = new TM[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (TM)t[i];
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

	///<summary>
	/// Returns a single repetition of Relative Time and Units(TQ1-5).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public CQ getRelativeTimeAndUnits(int rep)
	{
			CQ ret = null;
			try
			{
			IType t = this.GetField(5, rep);
				ret = (CQ)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Relative Time and Units (TQ1-5).
   ///</summary>
  public CQ[] getRelativeTimeAndUnits() {
     CQ[] ret = null;
    try {
        IType[] t = this.GetField(5);  
        ret = new CQ[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CQ)t[i];
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

	///<summary>
	/// Returns Service Duration(TQ1-6).
	///</summary>
	public CQ ServiceDuration
	{
		get{
			CQ ret = null;
			try
			{
			IType t = this.GetField(6, 0);
				ret = (CQ)t;
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

	///<summary>
	/// Returns Start date/time(TQ1-7).
	///</summary>
	public TS StartDateTime
	{
		get{
			TS ret = null;
			try
			{
			IType t = this.GetField(7, 0);
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

	///<summary>
	/// Returns End date/time(TQ1-8).
	///</summary>
	public TS EndDateTime
	{
		get{
			TS ret = null;
			try
			{
			IType t = this.GetField(8, 0);
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

	///<summary>
	/// Returns a single repetition of Priority(TQ1-9).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public CWE getPriority(int rep)
	{
			CWE ret = null;
			try
			{
			IType t = this.GetField(9, rep);
				ret = (CWE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Priority (TQ1-9).
   ///</summary>
  public CWE[] getPriority() {
     CWE[] ret = null;
    try {
        IType[] t = this.GetField(9);  
        ret = new CWE[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CWE)t[i];
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

	///<summary>
	/// Returns Condition text(TQ1-10).
	///</summary>
	public TX ConditionText
	{
		get{
			TX ret = null;
			try
			{
			IType t = this.GetField(10, 0);
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

	///<summary>
	/// Returns Text instruction(TQ1-11).
	///</summary>
	public TX TextInstruction
	{
		get{
			TX ret = null;
			try
			{
			IType t = this.GetField(11, 0);
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

	///<summary>
	/// Returns Conjunction(TQ1-12).
	///</summary>
	public ID Conjunction
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.GetField(12, 0);
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

	///<summary>
	/// Returns Occurrence duration(TQ1-13).
	///</summary>
	public CQ OccurrenceDuration
	{
		get{
			CQ ret = null;
			try
			{
			IType t = this.GetField(13, 0);
				ret = (CQ)t;
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

	///<summary>
	/// Returns Total occurrence's(TQ1-14).
	///</summary>
	public NM TotalOccurrenceS
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.GetField(14, 0);
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


}}