using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v25.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the BAR_P06_PATIENT Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: PID (Patient Identification) <b></b><br>
 * 1: PV1 (Patient Visit) <b>optional </b><br>
 */
namespace ca.uhn.hl7v2.model.v25.group
{
[Serializable]
public class BAR_P06_PATIENT : AbstractGroup {

	/** 
	 * Creates a new BAR_P06_PATIENT Group.
	 */
	public BAR_P06_PATIENT(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("PID", "2.5"), true, false);
	      this.add(factory.getSegmentClass("PV1", "2.5"), false, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating BAR_P06_PATIENT - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns PID (Patient Identification) - creates it if necessary
	 */
	public PID PID { 
get{
	   PID ret = null;
	   try {
	      ret = (PID)this.get_Renamed("PID");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns PV1 (Patient Visit) - creates it if necessary
	 */
	public PV1 PV1 { 
get{
	   PV1 ret = null;
	   try {
	      ret = (PV1)this.get_Renamed("PV1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}