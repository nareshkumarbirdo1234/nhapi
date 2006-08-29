using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V25.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V25.Segment{

///<summary>
/// Represents an HL7 OM4 message segment. 
/// This segment has the following fields:
/// * OM4-1: Sequence Number - Test/Observation Master File (NM)
/// * OM4-2: Derived Specimen (ID)
/// * OM4-3: Container Description (TX)
/// * OM4-4: Container Volume (NM)
/// * OM4-5: Container Units (CE)
/// * OM4-6: Specimen (CE)
/// * OM4-7: Additive (CWE)
/// * OM4-8: Preparation (TX)
/// * OM4-9: Special Handling Requirements (TX)
/// * OM4-10: Normal Collection Volume (CQ)
/// * OM4-11: Minimum Collection Volume (CQ)
/// * OM4-12: Specimen Requirements (TX)
/// * OM4-13: Specimen Priorities (ID)
/// * OM4-14: Specimen Retention Time (CQ)
/// The get...() methods return data from individual fields.  These methods 
/// do not throw exceptions and may therefore have to handle exceptions internally.  
/// If an exception is handled internally, it is logged and null is returned.  
/// This is not expected to happen - if it does happen this indicates not so much 
/// an exceptional circumstance as a bug in the code for this class.
///</summary>
[Serializable]
public class OM4 : AbstractSegment  {

  /**
   * Creates a OM4 (Observations that Require Specimens) segment object that belongs to the given 
   * message.  
   */
	public OM4(IGroup parent, IModelClassFactory factory) : base(parent,factory) {
	IMessage message = Message;
    try {
       this.add(typeof(NM), false, 1, 4, new System.Object[]{message}, "Sequence Number - Test/Observation Master File");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 170}, "Derived Specimen");
       this.add(typeof(TX), false, 1, 60, new System.Object[]{message}, "Container Description");
       this.add(typeof(NM), false, 1, 20, new System.Object[]{message}, "Container Volume");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Container Units");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Specimen");
       this.add(typeof(CWE), false, 1, 250, new System.Object[]{message}, "Additive");
       this.add(typeof(TX), false, 1, 10240, new System.Object[]{message}, "Preparation");
       this.add(typeof(TX), false, 1, 10240, new System.Object[]{message}, "Special Handling Requirements");
       this.add(typeof(CQ), false, 1, 20, new System.Object[]{message}, "Normal Collection Volume");
       this.add(typeof(CQ), false, 1, 20, new System.Object[]{message}, "Minimum Collection Volume");
       this.add(typeof(TX), false, 1, 10240, new System.Object[]{message}, "Specimen Requirements");
       this.add(typeof(ID), false, 0, 1, new System.Object[]{message, 27}, "Specimen Priorities");
       this.add(typeof(CQ), false, 1, 20, new System.Object[]{message}, "Specimen Retention Time");
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + GetType().Name, he);
    }
  }

	///<summary>
	/// Returns Sequence Number - Test/Observation Master File(OM4-1).
	///</summary>
	public NM SequenceNumberTestObservationMasterFile
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.GetField(1, 0);
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

	///<summary>
	/// Returns Derived Specimen(OM4-2).
	///</summary>
	public ID DerivedSpecimen
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.GetField(2, 0);
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
	/// Returns Container Description(OM4-3).
	///</summary>
	public TX ContainerDescription
	{
		get{
			TX ret = null;
			try
			{
			IType t = this.GetField(3, 0);
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
	/// Returns Container Volume(OM4-4).
	///</summary>
	public NM ContainerVolume
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.GetField(4, 0);
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

	///<summary>
	/// Returns Container Units(OM4-5).
	///</summary>
	public CE ContainerUnits
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(5, 0);
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

	///<summary>
	/// Returns Specimen(OM4-6).
	///</summary>
	public CE Specimen
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(6, 0);
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

	///<summary>
	/// Returns Additive(OM4-7).
	///</summary>
	public CWE Additive
	{
		get{
			CWE ret = null;
			try
			{
			IType t = this.GetField(7, 0);
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

	///<summary>
	/// Returns Preparation(OM4-8).
	///</summary>
	public TX Preparation
	{
		get{
			TX ret = null;
			try
			{
			IType t = this.GetField(8, 0);
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
	/// Returns Special Handling Requirements(OM4-9).
	///</summary>
	public TX SpecialHandlingRequirements
	{
		get{
			TX ret = null;
			try
			{
			IType t = this.GetField(9, 0);
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
	/// Returns Normal Collection Volume(OM4-10).
	///</summary>
	public CQ NormalCollectionVolume
	{
		get{
			CQ ret = null;
			try
			{
			IType t = this.GetField(10, 0);
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
	/// Returns Minimum Collection Volume(OM4-11).
	///</summary>
	public CQ MinimumCollectionVolume
	{
		get{
			CQ ret = null;
			try
			{
			IType t = this.GetField(11, 0);
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
	/// Returns Specimen Requirements(OM4-12).
	///</summary>
	public TX SpecimenRequirements
	{
		get{
			TX ret = null;
			try
			{
			IType t = this.GetField(12, 0);
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
	/// Returns a single repetition of Specimen Priorities(OM4-13).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public ID getSpecimenPriorities(int rep)
	{
			ID ret = null;
			try
			{
			IType t = this.GetField(13, rep);
				ret = (ID)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Specimen Priorities (OM4-13).
   ///</summary>
  public ID[] getSpecimenPriorities() {
     ID[] ret = null;
    try {
        IType[] t = this.GetField(13);  
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
	/// Returns Specimen Retention Time(OM4-14).
	///</summary>
	public CQ SpecimenRetentionTime
	{
		get{
			CQ ret = null;
			try
			{
			IType t = this.GetField(14, 0);
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


}}