using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v25.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the ADR_A19_QUERY_RESPONSE Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: EVN (Event Type) <b>optional </b><br>
 * 1: PID (Patient Identification) <b></b><br>
 * 2: PD1 (Patient Additional Demographic) <b>optional </b><br>
 * 3: ROL (Role) <b>optional repeating</b><br>
 * 4: NK1 (Next of Kin / Associated Parties) <b>optional repeating</b><br>
 * 5: PV1 (Patient Visit) <b></b><br>
 * 6: PV2 (Patient Visit - Additional Information) <b>optional </b><br>
 * 7: ROL (Role) <b>optional repeating</b><br>
 * 8: DB1 (Disability) <b>optional repeating</b><br>
 * 9: OBX (Observation/Result) <b>optional repeating</b><br>
 * 10: AL1 (Patient Allergy Information) <b>optional repeating</b><br>
 * 11: DG1 (Diagnosis) <b>optional repeating</b><br>
 * 12: DRG (Diagnosis Related Group) <b>optional </b><br>
 * 13: ADR_A19_PROCEDURE (a Group object) <b></b><br>
 * 14: GT1 (Guarantor) <b>optional repeating</b><br>
 * 15: ADR_A19_INSURANCE (a Group object) <b></b><br>
 * 16: ACC (Accident) <b>optional </b><br>
 * 17: UB1 (UB82) <b>optional </b><br>
 * 18: UB2 (UB92 Data) <b>optional </b><br>
 */
namespace ca.uhn.hl7v2.model.v25.group
{
[Serializable]
public class ADR_A19_QUERY_RESPONSE : AbstractGroup {

	/** 
	 * Creates a new ADR_A19_QUERY_RESPONSE Group.
	 */
	public ADR_A19_QUERY_RESPONSE(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(EVN), false, false);
	      this.add(typeof(PID), true, false);
	      this.add(typeof(PD1), false, false);
	      this.add(typeof(ROL), false, true);
	      this.add(typeof(NK1), false, true);
	      this.add(typeof(PV1), true, false);
	      this.add(typeof(PV2), false, false);
	      this.add(typeof(ROL), false, true);
	      this.add(typeof(DB1), false, true);
	      this.add(typeof(OBX), false, true);
	      this.add(typeof(AL1), false, true);
	      this.add(typeof(DG1), false, true);
	      this.add(typeof(DRG), false, false);
	      this.add(typeof(ADR_A19_PROCEDURE), true, false);
	      this.add(typeof(GT1), false, true);
	      this.add(typeof(ADR_A19_INSURANCE), true, false);
	      this.add(typeof(ACC), false, false);
	      this.add(typeof(UB1), false, false);
	      this.add(typeof(UB2), false, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating ADR_A19_QUERY_RESPONSE - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns EVN (Event Type) - creates it if necessary
	 */
	public EVN EVN { 
get{
	   EVN ret = null;
	   try {
	      ret = (EVN)this.get_Renamed("EVN");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
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
	 * Returns PD1 (Patient Additional Demographic) - creates it if necessary
	 */
	public PD1 PD1 { 
get{
	   PD1 ret = null;
	   try {
	      ret = (PD1)this.get_Renamed("PD1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of ROL (Role) - creates it if necessary
	 */
	public ROL getROL() {
	   ROL ret = null;
	   try {
	      ret = (ROL)this.get_Renamed("ROL");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of ROL
	 * (Role) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public ROL getROL(int rep) { 
	   return (ROL)this.get_Renamed("ROL", rep);
	}

	/** 
	 * Returns the number of existing repetitions of ROL 
	 */ 
	public int ROLReps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.getAll("ROL").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.getHapiLog(GetType()).error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/**
	 * Returns  first repetition of NK1 (Next of Kin / Associated Parties) - creates it if necessary
	 */
	public NK1 getNK1() {
	   NK1 ret = null;
	   try {
	      ret = (NK1)this.get_Renamed("NK1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of NK1
	 * (Next of Kin / Associated Parties) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public NK1 getNK1(int rep) { 
	   return (NK1)this.get_Renamed("NK1", rep);
	}

	/** 
	 * Returns the number of existing repetitions of NK1 
	 */ 
	public int NK1Reps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.getAll("NK1").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.getHapiLog(GetType()).error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
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

	/**
	 * Returns PV2 (Patient Visit - Additional Information) - creates it if necessary
	 */
	public PV2 PV2 { 
get{
	   PV2 ret = null;
	   try {
	      ret = (PV2)this.get_Renamed("PV2");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of ROL2 (Role) - creates it if necessary
	 */
	public ROL getROL2() {
	   ROL ret = null;
	   try {
	      ret = (ROL)this.get_Renamed("ROL2");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of ROL2
	 * (Role) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public ROL getROL2(int rep) { 
	   return (ROL)this.get_Renamed("ROL2", rep);
	}

	/** 
	 * Returns the number of existing repetitions of ROL2 
	 */ 
	public int ROL2Reps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.getAll("ROL2").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.getHapiLog(GetType()).error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/**
	 * Returns  first repetition of DB1 (Disability) - creates it if necessary
	 */
	public DB1 getDB1() {
	   DB1 ret = null;
	   try {
	      ret = (DB1)this.get_Renamed("DB1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of DB1
	 * (Disability) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public DB1 getDB1(int rep) { 
	   return (DB1)this.get_Renamed("DB1", rep);
	}

	/** 
	 * Returns the number of existing repetitions of DB1 
	 */ 
	public int DB1Reps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.getAll("DB1").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.getHapiLog(GetType()).error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/**
	 * Returns  first repetition of OBX (Observation/Result) - creates it if necessary
	 */
	public OBX getOBX() {
	   OBX ret = null;
	   try {
	      ret = (OBX)this.get_Renamed("OBX");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of OBX
	 * (Observation/Result) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public OBX getOBX(int rep) { 
	   return (OBX)this.get_Renamed("OBX", rep);
	}

	/** 
	 * Returns the number of existing repetitions of OBX 
	 */ 
	public int OBXReps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.getAll("OBX").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.getHapiLog(GetType()).error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/**
	 * Returns  first repetition of AL1 (Patient Allergy Information) - creates it if necessary
	 */
	public AL1 getAL1() {
	   AL1 ret = null;
	   try {
	      ret = (AL1)this.get_Renamed("AL1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of AL1
	 * (Patient Allergy Information) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public AL1 getAL1(int rep) { 
	   return (AL1)this.get_Renamed("AL1", rep);
	}

	/** 
	 * Returns the number of existing repetitions of AL1 
	 */ 
	public int AL1Reps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.getAll("AL1").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.getHapiLog(GetType()).error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/**
	 * Returns  first repetition of DG1 (Diagnosis) - creates it if necessary
	 */
	public DG1 getDG1() {
	   DG1 ret = null;
	   try {
	      ret = (DG1)this.get_Renamed("DG1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of DG1
	 * (Diagnosis) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public DG1 getDG1(int rep) { 
	   return (DG1)this.get_Renamed("DG1", rep);
	}

	/** 
	 * Returns the number of existing repetitions of DG1 
	 */ 
	public int DG1Reps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.getAll("DG1").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.getHapiLog(GetType()).error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/**
	 * Returns DRG (Diagnosis Related Group) - creates it if necessary
	 */
	public DRG DRG { 
get{
	   DRG ret = null;
	   try {
	      ret = (DRG)this.get_Renamed("DRG");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns ADR_A19_PROCEDURE (a Group object) - creates it if necessary
	 */
	public ADR_A19_PROCEDURE PROCEDURE { 
get{
	   ADR_A19_PROCEDURE ret = null;
	   try {
	      ret = (ADR_A19_PROCEDURE)this.get_Renamed("PROCEDURE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of GT1 (Guarantor) - creates it if necessary
	 */
	public GT1 getGT1() {
	   GT1 ret = null;
	   try {
	      ret = (GT1)this.get_Renamed("GT1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of GT1
	 * (Guarantor) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public GT1 getGT1(int rep) { 
	   return (GT1)this.get_Renamed("GT1", rep);
	}

	/** 
	 * Returns the number of existing repetitions of GT1 
	 */ 
	public int GT1Reps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.getAll("GT1").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.getHapiLog(GetType()).error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/**
	 * Returns ADR_A19_INSURANCE (a Group object) - creates it if necessary
	 */
	public ADR_A19_INSURANCE INSURANCE { 
get{
	   ADR_A19_INSURANCE ret = null;
	   try {
	      ret = (ADR_A19_INSURANCE)this.get_Renamed("INSURANCE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns ACC (Accident) - creates it if necessary
	 */
	public ACC ACC { 
get{
	   ACC ret = null;
	   try {
	      ret = (ACC)this.get_Renamed("ACC");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns UB1 (UB82) - creates it if necessary
	 */
	public UB1 UB1 { 
get{
	   UB1 ret = null;
	   try {
	      ret = (UB1)this.get_Renamed("UB1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns UB2 (UB92 Data) - creates it if necessary
	 */
	public UB2 UB2 { 
get{
	   UB2 ret = null;
	   try {
	      ret = (UB2)this.get_Renamed("UB2");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
