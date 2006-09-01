using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V24.Segment;

using NHapi.Base.Model;

namespace NHapi.Model.V24.Group
{
///<summary>
///Represents the MFN_M05_MF_LOC_DEPT Group.  A Group is an ordered collection of message 
/// segments that can repeat together or be optionally in/excluded together.
/// This Group contains the following elements: 
/// * 0: LDP (Location Department) 
/// * 1: LCH (Location Characteristic) optional repeating
/// * 2: LCC (Location Charge Code) optional repeating
///</summary>
[Serializable]
public class MFN_M05_MF_LOC_DEPT : AbstractGroup {

	///<summary> 
	/// Creates a new MFN_M05_MF_LOC_DEPT Group.
	///</summary>
	public MFN_M05_MF_LOC_DEPT(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(LDP), true, false);
	      this.add(typeof(LCH), false, true);
	      this.add(typeof(LCC), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating MFN_M05_MF_LOC_DEPT - this is probably a bug in the source code generator.", e);
	   }
	}

	///<summary>
	/// Returns LDP (Location Department) - creates it if necessary
	///</summary>
	public LDP LDP { 
get{
	   LDP ret = null;
	   try {
	      ret = (LDP)this.GetStructure("LDP");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns  first repetition of LCH (Location Characteristic) - creates it if necessary
	///</summary>
	public LCH getLCH() {
	   LCH ret = null;
	   try {
	      ret = (LCH)this.GetStructure("LCH");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of LCH
	/// * (Location Characteristic) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public LCH getLCH(int rep) { 
	   return (LCH)this.GetStructure("LCH", rep);
	}

	/** 
	 * Returns the number of existing repetitions of LCH 
	 */ 
	public int LCHReps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("LCH").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.getHapiLog(GetType()).error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	///<summary>
	/// Returns  first repetition of LCC (Location Charge Code) - creates it if necessary
	///</summary>
	public LCC getLCC() {
	   LCC ret = null;
	   try {
	      ret = (LCC)this.GetStructure("LCC");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of LCC
	/// * (Location Charge Code) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public LCC getLCC(int rep) { 
	   return (LCC)this.GetStructure("LCC", rep);
	}

	/** 
	 * Returns the number of existing repetitions of LCC 
	 */ 
	public int LCCReps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("LCC").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.getHapiLog(GetType()).error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

}
}