using System;
using NHapi.Base.Log;
using NHapi.Model.V24.Group;
using NHapi.Model.V24.Segment;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;

namespace NHapi.Model.V24.Message

{
///<summary>
/// Represents a PTR_PCF message structure (see chapter 12). This structure contains the 
/// following elements:
/// * 0: MSH (Message Header) 
/// * 1: MSA (Message Acknowledgment) 
/// * 2: ERR (Error) optional 
/// * 3: QAK (Query Acknowledgment) optional 
/// * 4: QRD (Original-Style Query Definition) 
/// * 5: PTR_PCF_PATIENT (a Group object) repeating
///</summary>
[Serializable]
public class PTR_PCF : AbstractMessage  {

	///<summary> 
	/// Creates a new PTR_PCF Group with custom IModelClassFactory.
	///</summary>
	public PTR_PCF(IModelClassFactory factory) : base(factory){
	   init(factory);
	}

	///<summary>
	/// Creates a new PTR_PCF Group with DefaultModelClassFactory. 
	///</summary> 
	public PTR_PCF() : base(new DefaultModelClassFactory()) { 
	   init(new DefaultModelClassFactory());
	}

	///<summary>
	/// initalize method for PTR_PCF.  This does the segment setup for the message. 
	///</summary> 
	private void init(IModelClassFactory factory) {
	   try {
	      this.add(typeof(MSH), true, false);
	      this.add(typeof(MSA), true, false);
	      this.add(typeof(ERR), false, false);
	      this.add(typeof(QAK), false, false);
	      this.add(typeof(QRD), true, false);
	      this.add(typeof(PTR_PCF_PATIENT), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating PTR_PCF - this is probably a bug in the source code generator.", e);
	   }
	}

	///<summary>
	/// Returns MSH (Message Header) - creates it if necessary
	///</summary>
	public MSH MSH { 
get{
	   MSH ret = null;
	   try {
	      ret = (MSH)this.GetStructure("MSH");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns MSA (Message Acknowledgment) - creates it if necessary
	///</summary>
	public MSA MSA { 
get{
	   MSA ret = null;
	   try {
	      ret = (MSA)this.GetStructure("MSA");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns ERR (Error) - creates it if necessary
	///</summary>
	public ERR ERR { 
get{
	   ERR ret = null;
	   try {
	      ret = (ERR)this.GetStructure("ERR");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns QAK (Query Acknowledgment) - creates it if necessary
	///</summary>
	public QAK QAK { 
get{
	   QAK ret = null;
	   try {
	      ret = (QAK)this.GetStructure("QAK");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns QRD (Original-Style Query Definition) - creates it if necessary
	///</summary>
	public QRD QRD { 
get{
	   QRD ret = null;
	   try {
	      ret = (QRD)this.GetStructure("QRD");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns  first repetition of PTR_PCF_PATIENT (a Group object) - creates it if necessary
	///</summary>
	public PTR_PCF_PATIENT getPATIENT() {
	   PTR_PCF_PATIENT ret = null;
	   try {
	      ret = (PTR_PCF_PATIENT)this.GetStructure("PATIENT");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of PTR_PCF_PATIENT
	/// * (a Group object) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public PTR_PCF_PATIENT getPATIENT(int rep) { 
	   return (PTR_PCF_PATIENT)this.GetStructure("PATIENT", rep);
	}

	/** 
	 * Returns the number of existing repetitions of PTR_PCF_PATIENT 
	 */ 
	public int PATIENTReps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("PATIENT").Length; 
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