using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V25.Segment;

using NHapi.Base.Model;

namespace NHapi.Model.V25.Group
{
///<summary>
///Represents the PEX_P07_STUDY Group.  A Group is an ordered collection of message 
/// segments that can repeat together or be optionally in/excluded together.
/// This Group contains the following elements: 
/// * 0: CSR (Clinical Study Registration) 
/// * 1: CSP (Clinical Study Phase) optional repeating
///</summary>
[Serializable]
public class PEX_P07_STUDY : AbstractGroup {

	///<summary> 
	/// Creates a new PEX_P07_STUDY Group.
	///</summary>
	public PEX_P07_STUDY(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(CSR), true, false);
	      this.add(typeof(CSP), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating PEX_P07_STUDY - this is probably a bug in the source code generator.", e);
	   }
	}

	///<summary>
	/// Returns CSR (Clinical Study Registration) - creates it if necessary
	///</summary>
	public CSR CSR { 
get{
	   CSR ret = null;
	   try {
	      ret = (CSR)this.GetStructure("CSR");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns  first repetition of CSP (Clinical Study Phase) - creates it if necessary
	///</summary>
	public CSP getCSP() {
	   CSP ret = null;
	   try {
	      ret = (CSP)this.GetStructure("CSP");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of CSP
	/// * (Clinical Study Phase) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public CSP getCSP(int rep) { 
	   return (CSP)this.GetStructure("CSP", rep);
	}

	/** 
	 * Returns the number of existing repetitions of CSP 
	 */ 
	public int CSPReps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("CSP").Length; 
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
