using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V21.Segment;

using NHapi.Base.Model;
/**
 * <p>Represents the ORM_O01_ORDER_DETAIL Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: OBR (OBSERVATION REQUEST) <b></b><br>
 * 1: ORO (ORDER OTHER) <b></b><br>
 * 2: RX1 (PHARMACY ORDER) <b></b><br>
 * 3: NTE (NOTES AND COMMENTS) <b>optional repeating</b><br>
 * 4: OBX (RESULT) <b>optional repeating</b><br>
 * 5: NTE (NOTES AND COMMENTS) <b>optional repeating</b><br>
 */
namespace NHapi.Model.V21.Group
{
[Serializable]
public class ORM_O01_ORDER_DETAIL : AbstractGroup {

	/** 
	 * Creates a new ORM_O01_ORDER_DETAIL Group.
	 */
	public ORM_O01_ORDER_DETAIL(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(OBR), true, false);
	      this.add(typeof(ORO), true, false);
	      this.add(typeof(RX1), true, false);
	      this.add(typeof(NTE), false, true);
	      this.add(typeof(OBX), false, true);
	      this.add(typeof(NTE), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating ORM_O01_ORDER_DETAIL - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns OBR (OBSERVATION REQUEST) - creates it if necessary
	 */
	public OBR OBR { 
get{
	   OBR ret = null;
	   try {
	      ret = (OBR)this.getStructure("OBR");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns ORO (ORDER OTHER) - creates it if necessary
	 */
	public ORO ORO { 
get{
	   ORO ret = null;
	   try {
	      ret = (ORO)this.getStructure("ORO");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns RX1 (PHARMACY ORDER) - creates it if necessary
	 */
	public RX1 RX1 { 
get{
	   RX1 ret = null;
	   try {
	      ret = (RX1)this.getStructure("RX1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of NTE (NOTES AND COMMENTS) - creates it if necessary
	 */
	public NTE getNTE() {
	   NTE ret = null;
	   try {
	      ret = (NTE)this.getStructure("NTE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of NTE
	 * (NOTES AND COMMENTS) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public NTE getNTE(int rep) { 
	   return (NTE)this.getStructure("NTE", rep);
	}

	/** 
	 * Returns the number of existing repetitions of NTE 
	 */ 
	public int NTEReps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.getAll("NTE").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.getHapiLog(GetType()).error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/**
	 * Returns  first repetition of OBX (RESULT) - creates it if necessary
	 */
	public OBX getOBX() {
	   OBX ret = null;
	   try {
	      ret = (OBX)this.getStructure("OBX");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of OBX
	 * (RESULT) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public OBX getOBX(int rep) { 
	   return (OBX)this.getStructure("OBX", rep);
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
	 * Returns  first repetition of NTE2 (NOTES AND COMMENTS) - creates it if necessary
	 */
	public NTE getNTE2() {
	   NTE ret = null;
	   try {
	      ret = (NTE)this.getStructure("NTE2");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of NTE2
	 * (NOTES AND COMMENTS) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public NTE getNTE2(int rep) { 
	   return (NTE)this.getStructure("NTE2", rep);
	}

	/** 
	 * Returns the number of existing repetitions of NTE2 
	 */ 
	public int NTE2Reps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.getAll("NTE2").Length; 
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