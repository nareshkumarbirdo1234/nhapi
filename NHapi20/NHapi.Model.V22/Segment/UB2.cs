using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V22.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V22.Segment{

///<summary>
/// Represents an HL7 UB2 message segment. 
/// This segment has the following fields:<ol>
///<li>UB2-1: Set ID - UB92 (SI)</li>
///<li>UB2-2: Co-insurance days (9) (ST)</li>
///<li>UB2-3: Condition code (24-30) (ID)</li>
///<li>UB2-4: Covered days (7) (ST)</li>
///<li>UB2-5: Non-covered days (8) (ST)</li>
///<li>UB2-6: Value amount and code (39-41) (CM_UVC)</li>
///<li>UB2-7: Occurrence code and date (32-35) (CM_OCD)</li>
///<li>UB2-8: Occurrence span code / dates (36) (CM_OSP)</li>
///<li>UB2-9: UB92 locator 2 (state) (ST)</li>
///<li>UB2-10: UB92 locator 11 (state) (ST)</li>
///<li>UB2-11: UB92 locator 31 (national) (ST)</li>
///<li>UB2-12: Document control number (37) (ST)</li>
///<li>UB2-13: UB92 locator 49 (national) (ST)</li>
///<li>UB2-14: UB92 locator 56 (state) (ST)</li>
///<li>UB2-15: UB92 locator 57 (national) (ST)</li>
///<li>UB2-16: UB92 Locator 78 (state) (ST)</li>
///</ol>
/// The get...() methods return data from individual fields.  These methods 
/// do not throw exceptions and may therefore have to handle exceptions internally.  
/// If an exception is handled internally, it is logged and null is returned.  
/// This is not expected to happen - if it does happen this indicates not so much 
/// an exceptional circumstance as a bug in the code for this class.
///</summary>
[Serializable]
public class UB2 : AbstractSegment  {

  /**
   * Creates a UB2 (UB92 DATA) segment object that belongs to the given 
   * message.  
   */
	public UB2(IGroup parent, IModelClassFactory factory) : base(parent,factory) {
	IMessage message = Message;
    try {
       this.add(typeof(SI), false, 1, 4, new System.Object[]{message}, "Set ID - UB92");
       this.add(typeof(ST), false, 1, 3, new System.Object[]{message}, "Co-insurance days (9)");
       this.add(typeof(ID), false, 7, 2, new System.Object[]{message, 43}, "Condition code (24-30)");
       this.add(typeof(ST), false, 1, 3, new System.Object[]{message}, "Covered days (7)");
       this.add(typeof(ST), false, 1, 4, new System.Object[]{message}, "Non-covered days (8)");
       this.add(typeof(CM_UVC), false, 12, 11, new System.Object[]{message}, "Value amount and code (39-41)");
       this.add(typeof(CM_OCD), false, 8, 11, new System.Object[]{message}, "Occurrence code and date (32-35)");
       this.add(typeof(CM_OSP), false, 2, 28, new System.Object[]{message}, "Occurrence span code / dates (36)");
       this.add(typeof(ST), false, 2, 29, new System.Object[]{message}, "UB92 locator 2 (state)");
       this.add(typeof(ST), false, 2, 12, new System.Object[]{message}, "UB92 locator 11 (state)");
       this.add(typeof(ST), false, 1, 5, new System.Object[]{message}, "UB92 locator 31 (national)");
       this.add(typeof(ST), false, 3, 23, new System.Object[]{message}, "Document control number (37)");
       this.add(typeof(ST), false, 23, 4, new System.Object[]{message}, "UB92 locator 49 (national)");
       this.add(typeof(ST), false, 5, 14, new System.Object[]{message}, "UB92 locator 56 (state)");
       this.add(typeof(ST), false, 1, 27, new System.Object[]{message}, "UB92 locator 57 (national)");
       this.add(typeof(ST), false, 2, 2, new System.Object[]{message}, "UB92 Locator 78 (state)");
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + GetType().Name, he);
    }
  }

	///<summary>
	/// Returns Set ID - UB92(UB2-1).
	///</summary>
	public SI SetIDUB92
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
	/// Returns Co-insurance days (9)(UB2-2).
	///</summary>
	public ST CoInsuranceDays9
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.GetField(2, 0);
				ret = (ST)t;
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
	/// Returns a single repetition of Condition code (24-30)(UB2-3).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public ID GetConditionCode2430(int rep)
	{
			ID ret = null;
			try
			{
			IType t = this.GetField(3, rep);
				ret = (ID)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Condition code (24-30) (UB2-3).
   ///</summary>
  public ID[] GetConditionCode2430() {
     ID[] ret = null;
    try {
        IType[] t = this.GetField(3);  
        ret = new ID[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (ID)t[i];
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
  /// Returns the total repetitions of Condition code (24-30) (UB2-3).
   ///</summary>
  public int ConditionCode2430RepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(3);
    }
catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
} catch (System.Exception cce) {
        HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
}
}
}
	///<summary>
	/// Returns Covered days (7)(UB2-4).
	///</summary>
	public ST CoveredDays7
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.GetField(4, 0);
				ret = (ST)t;
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
	/// Returns Non-covered days (8)(UB2-5).
	///</summary>
	public ST NonCoveredDays8
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.GetField(5, 0);
				ret = (ST)t;
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
	/// Returns a single repetition of Value amount and code (39-41)(UB2-6).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public CM_UVC GetValueAmountAndCode3941(int rep)
	{
			CM_UVC ret = null;
			try
			{
			IType t = this.GetField(6, rep);
				ret = (CM_UVC)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Value amount and code (39-41) (UB2-6).
   ///</summary>
  public CM_UVC[] GetValueAmountAndCode3941() {
     CM_UVC[] ret = null;
    try {
        IType[] t = this.GetField(6);  
        ret = new CM_UVC[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CM_UVC)t[i];
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
  /// Returns the total repetitions of Value amount and code (39-41) (UB2-6).
   ///</summary>
  public int ValueAmountAndCode3941RepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(6);
    }
catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
} catch (System.Exception cce) {
        HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
}
}
}
	///<summary>
	/// Returns a single repetition of Occurrence code and date (32-35)(UB2-7).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public CM_OCD GetOccurrenceCodeAndDate3235(int rep)
	{
			CM_OCD ret = null;
			try
			{
			IType t = this.GetField(7, rep);
				ret = (CM_OCD)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Occurrence code and date (32-35) (UB2-7).
   ///</summary>
  public CM_OCD[] GetOccurrenceCodeAndDate3235() {
     CM_OCD[] ret = null;
    try {
        IType[] t = this.GetField(7);  
        ret = new CM_OCD[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CM_OCD)t[i];
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
  /// Returns the total repetitions of Occurrence code and date (32-35) (UB2-7).
   ///</summary>
  public int OccurrenceCodeAndDate3235RepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(7);
    }
catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
} catch (System.Exception cce) {
        HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
}
}
}
	///<summary>
	/// Returns a single repetition of Occurrence span code / dates (36)(UB2-8).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public CM_OSP GetOccurrenceSpanCodeDates(int rep)
	{
			CM_OSP ret = null;
			try
			{
			IType t = this.GetField(8, rep);
				ret = (CM_OSP)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Occurrence span code / dates (36) (UB2-8).
   ///</summary>
  public CM_OSP[] GetOccurrenceSpanCodeDates() {
     CM_OSP[] ret = null;
    try {
        IType[] t = this.GetField(8);  
        ret = new CM_OSP[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CM_OSP)t[i];
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
  /// Returns the total repetitions of Occurrence span code / dates (36) (UB2-8).
   ///</summary>
  public int OccurrenceSpanCodeDatesRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(8);
    }
catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
} catch (System.Exception cce) {
        HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
}
}
}
	///<summary>
	/// Returns a single repetition of UB92 locator 2 (state)(UB2-9).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public ST GetUB92Locator2State(int rep)
	{
			ST ret = null;
			try
			{
			IType t = this.GetField(9, rep);
				ret = (ST)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of UB92 locator 2 (state) (UB2-9).
   ///</summary>
  public ST[] GetUB92Locator2State() {
     ST[] ret = null;
    try {
        IType[] t = this.GetField(9);  
        ret = new ST[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (ST)t[i];
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
  /// Returns the total repetitions of UB92 locator 2 (state) (UB2-9).
   ///</summary>
  public int UB92Locator2StateRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(9);
    }
catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
} catch (System.Exception cce) {
        HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
}
}
}
	///<summary>
	/// Returns a single repetition of UB92 locator 11 (state)(UB2-10).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public ST GetUB92Locator11State(int rep)
	{
			ST ret = null;
			try
			{
			IType t = this.GetField(10, rep);
				ret = (ST)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of UB92 locator 11 (state) (UB2-10).
   ///</summary>
  public ST[] GetUB92Locator11State() {
     ST[] ret = null;
    try {
        IType[] t = this.GetField(10);  
        ret = new ST[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (ST)t[i];
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
  /// Returns the total repetitions of UB92 locator 11 (state) (UB2-10).
   ///</summary>
  public int UB92Locator11StateRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(10);
    }
catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
} catch (System.Exception cce) {
        HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
}
}
}
	///<summary>
	/// Returns UB92 locator 31 (national)(UB2-11).
	///</summary>
	public ST UB92Locator31National
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.GetField(11, 0);
				ret = (ST)t;
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
	/// Returns a single repetition of Document control number (37)(UB2-12).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public ST GetDocumentControlNumber(int rep)
	{
			ST ret = null;
			try
			{
			IType t = this.GetField(12, rep);
				ret = (ST)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Document control number (37) (UB2-12).
   ///</summary>
  public ST[] GetDocumentControlNumber() {
     ST[] ret = null;
    try {
        IType[] t = this.GetField(12);  
        ret = new ST[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (ST)t[i];
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
  /// Returns the total repetitions of Document control number (37) (UB2-12).
   ///</summary>
  public int DocumentControlNumberRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(12);
    }
catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
} catch (System.Exception cce) {
        HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
}
}
}
	///<summary>
	/// Returns a single repetition of UB92 locator 49 (national)(UB2-13).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public ST GetUB92Locator49National(int rep)
	{
			ST ret = null;
			try
			{
			IType t = this.GetField(13, rep);
				ret = (ST)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of UB92 locator 49 (national) (UB2-13).
   ///</summary>
  public ST[] GetUB92Locator49National() {
     ST[] ret = null;
    try {
        IType[] t = this.GetField(13);  
        ret = new ST[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (ST)t[i];
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
  /// Returns the total repetitions of UB92 locator 49 (national) (UB2-13).
   ///</summary>
  public int UB92Locator49NationalRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(13);
    }
catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
} catch (System.Exception cce) {
        HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
}
}
}
	///<summary>
	/// Returns a single repetition of UB92 locator 56 (state)(UB2-14).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public ST GetUB92Locator56State(int rep)
	{
			ST ret = null;
			try
			{
			IType t = this.GetField(14, rep);
				ret = (ST)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of UB92 locator 56 (state) (UB2-14).
   ///</summary>
  public ST[] GetUB92Locator56State() {
     ST[] ret = null;
    try {
        IType[] t = this.GetField(14);  
        ret = new ST[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (ST)t[i];
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
  /// Returns the total repetitions of UB92 locator 56 (state) (UB2-14).
   ///</summary>
  public int UB92Locator56StateRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(14);
    }
catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
} catch (System.Exception cce) {
        HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
}
}
}
	///<summary>
	/// Returns UB92 locator 57 (national)(UB2-15).
	///</summary>
	public ST UB92Locator57National
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.GetField(15, 0);
				ret = (ST)t;
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
	/// Returns a single repetition of UB92 Locator 78 (state)(UB2-16).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public ST GetUB92Locator78State(int rep)
	{
			ST ret = null;
			try
			{
			IType t = this.GetField(16, rep);
				ret = (ST)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of UB92 Locator 78 (state) (UB2-16).
   ///</summary>
  public ST[] GetUB92Locator78State() {
     ST[] ret = null;
    try {
        IType[] t = this.GetField(16);  
        ret = new ST[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (ST)t[i];
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
  /// Returns the total repetitions of UB92 Locator 78 (state) (UB2-16).
   ///</summary>
  public int UB92Locator78StateRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(16);
    }
catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
} catch (System.Exception cce) {
        HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
}
}
}

}}