using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V25.Segment;

using NHapi.Base.Model;

namespace NHapi.Model.V25.Group
{
///<summary>
///Represents the ORL_O22_ORDER Group.  A Group is an ordered collection of message 
/// segments that can repeat together or be optionally in/excluded together.
/// This Group contains the following elements: 
/// * 0: ORC (Common Order) 
/// * 1: ORL_O22_TIMING (a Group object) 
/// * 2: ORL_O22_OBSERVATION_REQUEST (a Group object) optional 
///</summary>
[Serializable]
public class ORL_O22_ORDER : AbstractGroup {

	///<summary> 
	/// Creates a new ORL_O22_ORDER Group.
	///</summary>
	public ORL_O22_ORDER(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(ORC), true, false);
	      this.add(typeof(ORL_O22_TIMING), true, false);
	      this.add(typeof(ORL_O22_OBSERVATION_REQUEST), false, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating ORL_O22_ORDER - this is probably a bug in the source code generator.", e);
	   }
	}

	///<summary>
	/// Returns ORC (Common Order) - creates it if necessary
	///</summary>
	public ORC ORC { 
get{
	   ORC ret = null;
	   try {
	      ret = (ORC)this.GetStructure("ORC");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns ORL_O22_TIMING (a Group object) - creates it if necessary
	///</summary>
	public ORL_O22_TIMING TIMING { 
get{
	   ORL_O22_TIMING ret = null;
	   try {
	      ret = (ORL_O22_TIMING)this.GetStructure("TIMING");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns ORL_O22_OBSERVATION_REQUEST (a Group object) - creates it if necessary
	///</summary>
	public ORL_O22_OBSERVATION_REQUEST OBSERVATION_REQUEST { 
get{
	   ORL_O22_OBSERVATION_REQUEST ret = null;
	   try {
	      ret = (ORL_O22_OBSERVATION_REQUEST)this.GetStructure("OBSERVATION_REQUEST");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
