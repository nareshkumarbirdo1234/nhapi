using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using ca.uhn.hl7v2.model.v24.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the MFN_M07_MF_CLIN_STUDY_SCHED Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: MFE (Master File Entry) <b></b><br>
 * 1: CM0 (Clinical Study Master) <b></b><br>
 * 2: CM2 (Clinical Study Schedule Master) <b>optional repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v24.group
{
	public class MFN_M07_MF_CLIN_STUDY_SCHED : AbstractGroup 
	{

		/** 
		 * Creates a new MFN_M07_MF_CLIN_STUDY_SCHED Group.
		 */
		public MFN_M07_MF_CLIN_STUDY_SCHED(Group parent, ModelClassFactory factory) : base(parent, factory)
		{
			try 
			{
				this.add(typeof(MFE), true, false);
				this.add(typeof(CM0), true, false);
				this.add(typeof(CM2), false, true);
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating MFN_M07_MF_CLIN_STUDY_SCHED - this is probably a bug in the source code generator.", e);
			}
		}

		/**
		 * Returns MFE (Master File Entry) - creates it if necessary
		 */
		public MFE MFE 
		{ 
			get
			{
				MFE ret = null;
				try 
				{
					ret = (MFE)this.get_Renamed("MFE");
				} 
				catch(HL7Exception e) 
				{
					HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
					throw new System.Exception("An unexpected error ocurred",e);
				}
				return ret;
			}
		}

		/**
		 * Returns CM0 (Clinical Study Master) - creates it if necessary
		 */
		public CM0 CM0 
		{ 
			get
			{
				CM0 ret = null;
				try 
				{
					ret = (CM0)this.get_Renamed("CM0");
				} 
				catch(HL7Exception e) 
				{
					HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
					throw new System.Exception("An unexpected error ocurred",e);
				}
				return ret;
			}
		}

		/**
		 * Returns  first repetition of CM2 (Clinical Study Schedule Master) - creates it if necessary
		 */
		public CM2 getCM2() 
		{
			CM2 ret = null;
			try 
			{
				ret = (CM2)this.get_Renamed("CM2");
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
				throw new System.Exception("An unexpected error ocurred",e);
			}
			return ret;
		}

		/**
		 * Returns a specific repetition of CM2
		 * (Clinical Study Schedule Master) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public CM2 getCM2(int rep) 
		{ 
			return (CM2)this.get_Renamed("CM2", rep);
		}

		/** 
		 * Returns the number of existing repetitions of CM2 
		 */ 
		public int CM2Reps 
		{ 
			get
			{
				int reps = -1; 
				try 
				{ 
					reps = this.getAll("CM2").Length; 
				} 
				catch (HL7Exception e) 
				{ 
					string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
					HapiLogFactory.getHapiLog(GetType()).error(message, e); 
					throw new System.Exception(message);
				} 
				return reps; 
			}
		} 

	}
}
