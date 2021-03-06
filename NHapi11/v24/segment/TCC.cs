using System;
using ca.uhn.hl7v2.model;
using ca.uhn.hl7v2.model.v24.datatype;

using ca.uhn.log;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;

namespace ca.uhn.hl7v2.model.v24.segment{

/**
 * <p>Represents an HL7 TCC message segment. 
 * This segment has the following fields:</p><p>
 * TCC-1: Universal Service Identifier (CE)<br> 
 * TCC-2: Test Application Identifier (EI)<br> 
 * TCC-3: Specimen Source (SPS)<br> 
 * TCC-4: Auto-Dilution Factor Default (SN)<br> 
 * TCC-5: Rerun Dilution Factor Default (SN)<br> 
 * TCC-6: Pre-Dilution Factor Default (SN)<br> 
 * TCC-7: Endogenous Content of Pre-Dilution Diluent (SN)<br> 
 * TCC-8: Inventory Limits Warning Level (NM)<br> 
 * TCC-9: Automatic Rerun Allowed (ID)<br> 
 * TCC-10: Automatic Repeat Allowed (ID)<br> 
 * TCC-11: Automatic Reflex Allowed (ID)<br> 
 * TCC-12: Equipment Dynamic Range (SN)<br> 
 * TCC-13: Units (CE)<br> 
 * TCC-14: Processing Type (CE)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class TCC : AbstractSegment  {

  /**
   * Creates a TCC (Test Code Configuration) segment object that belongs to the given 
   * message.  
   */
  public TCC(Group parent, ModelClassFactory factory) : base(parent,factory) {
    Message message = Message;
    try {
       this.add(typeof(CE), true, 1, 250, new System.Object[]{message}, "Universal Service Identifier");
       this.add(typeof(EI), true, 1, 80, new System.Object[]{message}, "Test Application Identifier");
       this.add(typeof(SPS), false, 1, 300, new System.Object[]{message}, "Specimen Source");
       this.add(typeof(SN), false, 1, 20, new System.Object[]{message}, "Auto-Dilution Factor Default");
       this.add(typeof(SN), false, 1, 20, new System.Object[]{message}, "Rerun Dilution Factor Default");
       this.add(typeof(SN), false, 1, 20, new System.Object[]{message}, "Pre-Dilution Factor Default");
       this.add(typeof(SN), false, 1, 20, new System.Object[]{message}, "Endogenous Content of Pre-Dilution Diluent");
       this.add(typeof(NM), false, 1, 10, new System.Object[]{message}, "Inventory Limits Warning Level");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136}, "Automatic Rerun Allowed");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136}, "Automatic Repeat Allowed");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136}, "Automatic Reflex Allowed");
       this.add(typeof(SN), false, 1, 20, new System.Object[]{message}, "Equipment Dynamic Range");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Units");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Processing Type");
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + this.getStructureName(), he);
    }
  }

	/**
	* Returns Universal Service Identifier(TCC-1).
	*/
	public CE UniversalServiceIdentifier
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(1, 0);
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

	/**
	* Returns Test Application Identifier(TCC-2).
	*/
	public EI TestApplicationIdentifier
	{
		get{
			EI ret = null;
			try
			{
			Type t = this.getField(2, 0);
				ret = (EI)t;
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

	/**
	* Returns Specimen Source(TCC-3).
	*/
	public SPS SpecimenSource
	{
		get{
			SPS ret = null;
			try
			{
			Type t = this.getField(3, 0);
				ret = (SPS)t;
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

	/**
	* Returns Auto-Dilution Factor Default(TCC-4).
	*/
	public SN AutoDilutionFactorDefault
	{
		get{
			SN ret = null;
			try
			{
			Type t = this.getField(4, 0);
				ret = (SN)t;
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

	/**
	* Returns Rerun Dilution Factor Default(TCC-5).
	*/
	public SN RerunDilutionFactorDefault
	{
		get{
			SN ret = null;
			try
			{
			Type t = this.getField(5, 0);
				ret = (SN)t;
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

	/**
	* Returns Pre-Dilution Factor Default(TCC-6).
	*/
	public SN PreDilutionFactorDefault
	{
		get{
			SN ret = null;
			try
			{
			Type t = this.getField(6, 0);
				ret = (SN)t;
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

	/**
	* Returns Endogenous Content of Pre-Dilution Diluent(TCC-7).
	*/
	public SN EndogenousContentOfPreDilutionDiluent
	{
		get{
			SN ret = null;
			try
			{
			Type t = this.getField(7, 0);
				ret = (SN)t;
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

	/**
	* Returns Inventory Limits Warning Level(TCC-8).
	*/
	public NM InventoryLimitsWarningLevel
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(8, 0);
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

	/**
	* Returns Automatic Rerun Allowed(TCC-9).
	*/
	public ID AutomaticRerunAllowed
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(9, 0);
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

	/**
	* Returns Automatic Repeat Allowed(TCC-10).
	*/
	public ID AutomaticRepeatAllowed
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(10, 0);
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

	/**
	* Returns Automatic Reflex Allowed(TCC-11).
	*/
	public ID AutomaticReflexAllowed
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(11, 0);
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

	/**
	* Returns Equipment Dynamic Range(TCC-12).
	*/
	public SN EquipmentDynamicRange
	{
		get{
			SN ret = null;
			try
			{
			Type t = this.getField(12, 0);
				ret = (SN)t;
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

	/**
	* Returns Units(TCC-13).
	*/
	public CE Units
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(13, 0);
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

	/**
	* Returns Processing Type(TCC-14).
	*/
	public CE ProcessingType
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(14, 0);
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


}}