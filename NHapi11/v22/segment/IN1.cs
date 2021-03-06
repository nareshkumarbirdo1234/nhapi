using System;
using ca.uhn.hl7v2.model;
using ca.uhn.hl7v2.model.v22.datatype;

using ca.uhn.log;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;

namespace ca.uhn.hl7v2.model.v22.segment{

/**
 * <p>Represents an HL7 IN1 message segment. 
 * This segment has the following fields:</p><p>
 * IN1-1: Set ID - insurance (SI)<br> 
 * IN1-2: Insurance plan ID (ID)<br> 
 * IN1-3: Insurance company ID (ST)<br> 
 * IN1-4: Insurance company name (ST)<br> 
 * IN1-5: Insurance company address (AD)<br> 
 * IN1-6: Insurance company contact pers (PN)<br> 
 * IN1-7: Insurance company phone number (TN)<br> 
 * IN1-8: Group number (ST)<br> 
 * IN1-9: Group name (ST)<br> 
 * IN1-10: Insured's group employer ID (ST)<br> 
 * IN1-11: Insured's group employer name (ST)<br> 
 * IN1-12: Plan effective date (DT)<br> 
 * IN1-13: Plan expiration date (DT)<br> 
 * IN1-14: Authorization information (CM_AUI)<br> 
 * IN1-15: Plan type (ID)<br> 
 * IN1-16: Name of insured (PN)<br> 
 * IN1-17: Insured's relationship to patient (ID)<br> 
 * IN1-18: Insured's date of birth (DT)<br> 
 * IN1-19: Insured's address (AD)<br> 
 * IN1-20: Assignment of benefits (ID)<br> 
 * IN1-21: Coordination of benefits (ID)<br> 
 * IN1-22: Coordination of benefits - priority (ST)<br> 
 * IN1-23: Notice of admission code (ID)<br> 
 * IN1-24: Notice of admission date (DT)<br> 
 * IN1-25: Report of eligibility code (ID)<br> 
 * IN1-26: Report of eligibility date (DT)<br> 
 * IN1-27: Release information code (ID)<br> 
 * IN1-28: Pre-admit certification (PAC) (ST)<br> 
 * IN1-29: Verification date / time (TS)<br> 
 * IN1-30: Verification by (CN_PERSON)<br> 
 * IN1-31: Type of agreement code (ID)<br> 
 * IN1-32: Billing status (ID)<br> 
 * IN1-33: Lifetime reserve days (NM)<br> 
 * IN1-34: Delay before lifetime reserve days (NM)<br> 
 * IN1-35: Company plan code (ID)<br> 
 * IN1-36: Policy number (ST)<br> 
 * IN1-37: Policy deductible (NM)<br> 
 * IN1-38: Policy limit - amount (NM)<br> 
 * IN1-39: Policy limit - days (NM)<br> 
 * IN1-40: Room rate - semi-private (NM)<br> 
 * IN1-41: Room rate - private (NM)<br> 
 * IN1-42: Insured's employment status (CE)<br> 
 * IN1-43: Insured's sex (ID)<br> 
 * IN1-44: Insured's employer address (AD)<br> 
 * IN1-45: Verification status (ST)<br> 
 * IN1-46: Prior insurance plan ID (ID)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class IN1 : AbstractSegment  {

  /**
   * Creates a IN1 (INSURANCE) segment object that belongs to the given 
   * message.  
   */
  public IN1(Group parent, ModelClassFactory factory) : base(parent,factory) {
    Message message = Message;
    try {
       this.add(typeof(SI), true, 1, 4, new System.Object[]{message}, "Set ID - insurance");
       this.add(typeof(ID), true, 1, 8, new System.Object[]{message, 72}, "Insurance plan ID");
       this.add(typeof(ST), true, 1, 9, new System.Object[]{message}, "Insurance company ID");
       this.add(typeof(ST), false, 1, 45, new System.Object[]{message}, "Insurance company name");
       this.add(typeof(AD), false, 1, 106, new System.Object[]{message}, "Insurance company address");
       this.add(typeof(PN), false, 1, 48, new System.Object[]{message}, "Insurance company contact pers");
       this.add(typeof(TN), false, 3, 40, new System.Object[]{message}, "Insurance company phone number");
       this.add(typeof(ST), false, 1, 12, new System.Object[]{message}, "Group number");
       this.add(typeof(ST), false, 1, 35, new System.Object[]{message}, "Group name");
       this.add(typeof(ST), false, 1, 12, new System.Object[]{message}, "Insured's group employer ID");
       this.add(typeof(ST), false, 1, 45, new System.Object[]{message}, "Insured's group employer name");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "Plan effective date");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "Plan expiration date");
       this.add(typeof(CM_AUI), false, 1, 55, new System.Object[]{message}, "Authorization information");
       this.add(typeof(ID), false, 1, 5, new System.Object[]{message, 86}, "Plan type");
       this.add(typeof(PN), false, 1, 48, new System.Object[]{message}, "Name of insured");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 63}, "Insured's relationship to patient");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "Insured's date of birth");
       this.add(typeof(AD), false, 1, 106, new System.Object[]{message}, "Insured's address");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 135}, "Assignment of benefits");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 173}, "Coordination of benefits");
       this.add(typeof(ST), false, 1, 2, new System.Object[]{message}, "Coordination of benefits - priority");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 136}, "Notice of admission code");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "Notice of admission date");
       this.add(typeof(ID), false, 1, 4, new System.Object[]{message, 0}, "Report of eligibility code");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "Report of eligibility date");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 93}, "Release information code");
       this.add(typeof(ST), false, 1, 15, new System.Object[]{message}, "Pre-admit certification (PAC)");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Verification date / time");
       this.add(typeof(CN_PERSON), false, 1, 60, new System.Object[]{message}, "Verification by");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 98}, "Type of agreement code");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 22}, "Billing status");
       this.add(typeof(NM), false, 1, 4, new System.Object[]{message}, "Lifetime reserve days");
       this.add(typeof(NM), false, 1, 4, new System.Object[]{message}, "Delay before lifetime reserve days");
       this.add(typeof(ID), false, 1, 8, new System.Object[]{message, 42}, "Company plan code");
       this.add(typeof(ST), false, 1, 15, new System.Object[]{message}, "Policy number");
       this.add(typeof(NM), false, 1, 12, new System.Object[]{message}, "Policy deductible");
       this.add(typeof(NM), false, 1, 12, new System.Object[]{message}, "Policy limit - amount");
       this.add(typeof(NM), false, 1, 4, new System.Object[]{message}, "Policy limit - days");
       this.add(typeof(NM), false, 1, 12, new System.Object[]{message}, "Room rate - semi-private");
       this.add(typeof(NM), false, 1, 12, new System.Object[]{message}, "Room rate - private");
       this.add(typeof(CE), false, 1, 60, new System.Object[]{message}, "Insured's employment status");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 1}, "Insured's sex");
       this.add(typeof(AD), false, 1, 106, new System.Object[]{message}, "Insured's employer address");
       this.add(typeof(ST), false, 1, 2, new System.Object[]{message}, "Verification status");
       this.add(typeof(ID), false, 1, 8, new System.Object[]{message, 72}, "Prior insurance plan ID");
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + this.getStructureName(), he);
    }
  }

	/**
	* Returns Set ID - insurance(IN1-1).
	*/
	public SI SetIDInsurance
	{
		get{
			SI ret = null;
			try
			{
			Type t = this.getField(1, 0);
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

	/**
	* Returns Insurance plan ID(IN1-2).
	*/
	public ID InsurancePlanID
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(2, 0);
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
	* Returns Insurance company ID(IN1-3).
	*/
	public ST InsuranceCompanyID
	{
		get{
			ST ret = null;
			try
			{
			Type t = this.getField(3, 0);
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

	/**
	* Returns Insurance company name(IN1-4).
	*/
	public ST InsuranceCompanyName
	{
		get{
			ST ret = null;
			try
			{
			Type t = this.getField(4, 0);
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

	/**
	* Returns Insurance company address(IN1-5).
	*/
	public AD InsuranceCompanyAddress
	{
		get{
			AD ret = null;
			try
			{
			Type t = this.getField(5, 0);
				ret = (AD)t;
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
	* Returns Insurance company contact pers(IN1-6).
	*/
	public PN InsuranceCompanyContactPers
	{
		get{
			PN ret = null;
			try
			{
			Type t = this.getField(6, 0);
				ret = (PN)t;
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
	* Returns a single repetition of Insurance company phone number(IN1-7).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public TN getInsuranceCompanyPhoneNumber(int rep)
	{
			TN ret = null;
			try
			{
			Type t = this.getField(7, rep);
				ret = (TN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Insurance company phone number (IN1-7).
   */
  public TN[] getInsuranceCompanyPhoneNumber() {
     TN[] ret = null;
    try {
        Type[] t = this.getField(7);  
        ret = new TN[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (TN)t[i];
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

	/**
	* Returns Group number(IN1-8).
	*/
	public ST GroupNumber
	{
		get{
			ST ret = null;
			try
			{
			Type t = this.getField(8, 0);
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

	/**
	* Returns Group name(IN1-9).
	*/
	public ST GroupName
	{
		get{
			ST ret = null;
			try
			{
			Type t = this.getField(9, 0);
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

	/**
	* Returns Insured's group employer ID(IN1-10).
	*/
	public ST InsuredSGroupEmployerID
	{
		get{
			ST ret = null;
			try
			{
			Type t = this.getField(10, 0);
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

	/**
	* Returns Insured's group employer name(IN1-11).
	*/
	public ST InsuredSGroupEmployerName
	{
		get{
			ST ret = null;
			try
			{
			Type t = this.getField(11, 0);
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

	/**
	* Returns Plan effective date(IN1-12).
	*/
	public DT PlanEffectiveDate
	{
		get{
			DT ret = null;
			try
			{
			Type t = this.getField(12, 0);
				ret = (DT)t;
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
	* Returns Plan expiration date(IN1-13).
	*/
	public DT PlanExpirationDate
	{
		get{
			DT ret = null;
			try
			{
			Type t = this.getField(13, 0);
				ret = (DT)t;
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
	* Returns Authorization information(IN1-14).
	*/
	public CM_AUI AuthorizationInformation
	{
		get{
			CM_AUI ret = null;
			try
			{
			Type t = this.getField(14, 0);
				ret = (CM_AUI)t;
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
	* Returns Plan type(IN1-15).
	*/
	public ID PlanType
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(15, 0);
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
	* Returns Name of insured(IN1-16).
	*/
	public PN NameOfInsured
	{
		get{
			PN ret = null;
			try
			{
			Type t = this.getField(16, 0);
				ret = (PN)t;
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
	* Returns Insured's relationship to patient(IN1-17).
	*/
	public ID InsuredSRelationshipToPatient
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(17, 0);
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
	* Returns Insured's date of birth(IN1-18).
	*/
	public DT InsuredSDateOfBirth
	{
		get{
			DT ret = null;
			try
			{
			Type t = this.getField(18, 0);
				ret = (DT)t;
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
	* Returns Insured's address(IN1-19).
	*/
	public AD InsuredSAddress
	{
		get{
			AD ret = null;
			try
			{
			Type t = this.getField(19, 0);
				ret = (AD)t;
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
	* Returns Assignment of benefits(IN1-20).
	*/
	public ID AssignmentOfBenefits
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(20, 0);
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
	* Returns Coordination of benefits(IN1-21).
	*/
	public ID CoordinationOfBenefits
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(21, 0);
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
	* Returns Coordination of benefits - priority(IN1-22).
	*/
	public ST CoordinationOfBenefitsPriority
	{
		get{
			ST ret = null;
			try
			{
			Type t = this.getField(22, 0);
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

	/**
	* Returns Notice of admission code(IN1-23).
	*/
	public ID NoticeOfAdmissionCode
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(23, 0);
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
	* Returns Notice of admission date(IN1-24).
	*/
	public DT NoticeOfAdmissionDate
	{
		get{
			DT ret = null;
			try
			{
			Type t = this.getField(24, 0);
				ret = (DT)t;
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
	* Returns Report of eligibility code(IN1-25).
	*/
	public ID ReportOfEligibilityCode
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(25, 0);
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
	* Returns Report of eligibility date(IN1-26).
	*/
	public DT ReportOfEligibilityDate
	{
		get{
			DT ret = null;
			try
			{
			Type t = this.getField(26, 0);
				ret = (DT)t;
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
	* Returns Release information code(IN1-27).
	*/
	public ID ReleaseInformationCode
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(27, 0);
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
	* Returns Pre-admit certification (PAC)(IN1-28).
	*/
	public ST PreAdmitCertification
	{
		get{
			ST ret = null;
			try
			{
			Type t = this.getField(28, 0);
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

	/**
	* Returns Verification date / time(IN1-29).
	*/
	public TS VerificationDateTime
	{
		get{
			TS ret = null;
			try
			{
			Type t = this.getField(29, 0);
				ret = (TS)t;
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
	* Returns Verification by(IN1-30).
	*/
	public CN_PERSON VerificationBy
	{
		get{
			CN_PERSON ret = null;
			try
			{
			Type t = this.getField(30, 0);
				ret = (CN_PERSON)t;
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
	* Returns Type of agreement code(IN1-31).
	*/
	public ID TypeOfAgreementCode
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(31, 0);
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
	* Returns Billing status(IN1-32).
	*/
	public ID BillingStatus
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(32, 0);
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
	* Returns Lifetime reserve days(IN1-33).
	*/
	public NM LifetimeReserveDays
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(33, 0);
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
	* Returns Delay before lifetime reserve days(IN1-34).
	*/
	public NM DelayBeforeLifetimeReserveDays
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(34, 0);
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
	* Returns Company plan code(IN1-35).
	*/
	public ID CompanyPlanCode
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(35, 0);
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
	* Returns Policy number(IN1-36).
	*/
	public ST PolicyNumber
	{
		get{
			ST ret = null;
			try
			{
			Type t = this.getField(36, 0);
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

	/**
	* Returns Policy deductible(IN1-37).
	*/
	public NM PolicyDeductible
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(37, 0);
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
	* Returns Policy limit - amount(IN1-38).
	*/
	public NM PolicyLimitAmount
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(38, 0);
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
	* Returns Policy limit - days(IN1-39).
	*/
	public NM PolicyLimitDays
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(39, 0);
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
	* Returns Room rate - semi-private(IN1-40).
	*/
	public NM RoomRateSemiPrivate
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(40, 0);
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
	* Returns Room rate - private(IN1-41).
	*/
	public NM RoomRatePrivate
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(41, 0);
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
	* Returns Insured's employment status(IN1-42).
	*/
	public CE InsuredSEmploymentStatus
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(42, 0);
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
	* Returns Insured's sex(IN1-43).
	*/
	public ID InsuredSSex
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(43, 0);
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
	* Returns Insured's employer address(IN1-44).
	*/
	public AD InsuredSEmployerAddress
	{
		get{
			AD ret = null;
			try
			{
			Type t = this.getField(44, 0);
				ret = (AD)t;
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
	* Returns Verification status(IN1-45).
	*/
	public ST VerificationStatus
	{
		get{
			ST ret = null;
			try
			{
			Type t = this.getField(45, 0);
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

	/**
	* Returns Prior insurance plan ID(IN1-46).
	*/
	public ID PriorInsurancePlanID
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(46, 0);
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


}}