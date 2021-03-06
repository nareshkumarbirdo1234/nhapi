using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using ca.uhn.hl7v2.model.v24.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the ADT_A39_PATIENT Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: PID (Patient identification) <b></b><br>
 * 1: PD1 (patient additional demographic) <b>optional </b><br>
 * 2: MRG (Merge patient information) <b></b><br>
 * 3: PV1 (Patient visit) <b>optional </b><br>
 */
namespace ca.uhn.hl7v2.model.v24.group
{
	public class ADT_A39_PATIENT : AbstractGroup 
	{

		/** 
		 * Creates a new ADT_A39_PATIENT Group.
		 */
		public ADT_A39_PATIENT(Group parent, ModelClassFactory factory) : base(parent, factory)
		{
			try 
			{
				this.add(typeof(PID), true, false);
				this.add(typeof(PD1), false, false);
				this.add(typeof(MRG), true, false);
				this.add(typeof(PV1), false, false);
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating ADT_A39_PATIENT - this is probably a bug in the source code generator.", e);
			}
		}

		/**
		 * Returns PID (Patient identification) - creates it if necessary
		 */
		public PID PID 
		{ 
			get
			{
				PID ret = null;
				try 
				{
					ret = (PID)this.get_Renamed("PID");
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
		 * Returns PD1 (patient additional demographic) - creates it if necessary
		 */
		public PD1 PD1 
		{ 
			get
			{
				PD1 ret = null;
				try 
				{
					ret = (PD1)this.get_Renamed("PD1");
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
		 * Returns MRG (Merge patient information) - creates it if necessary
		 */
		public MRG MRG 
		{ 
			get
			{
				MRG ret = null;
				try 
				{
					ret = (MRG)this.get_Renamed("MRG");
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
		 * Returns PV1 (Patient visit) - creates it if necessary
		 */
		public PV1 PV1 
		{ 
			get
			{
				PV1 ret = null;
				try 
				{
					ret = (PV1)this.get_Renamed("PV1");
				} 
				catch(HL7Exception e) 
				{
					HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
					throw new System.Exception("An unexpected error ocurred",e);
				}
				return ret;
			}
		}

	}
}
