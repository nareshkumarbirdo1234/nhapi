using ca.uhn.log;
using ca.uhn.hl7v2.model.v23.group;
using ca.uhn.hl7v2.model.v23.segment;
using ca.uhn.hl7v2;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2.model;

/**
 * <p>Represents a MFN_M04 message structure (see chapter [AAA]). This structure contains the 
 * following elements: </p>
 * 0: MSH (Message header segment) <b></b><br>
 * 1: MFI (Master file identification segment) <b></b><br>
 * 2: MFN_M04_MF_CDM (a Group object) <b>repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v23.message

{
	public class MFN_M04 : AbstractMessage  
	{

		/** 
		 * Creates a new MFN_M04 Group with custom ModelClassFactory.
		 */
		public MFN_M04(ModelClassFactory factory) : base(factory)
		{
			init(factory);
		}

		/**
		 * Creates a new MFN_M04 Group with DefaultModelClassFactory. 
		 */ 
		public MFN_M04() : base(new DefaultModelClassFactory()) 
		{ 
			init(new DefaultModelClassFactory());
		}

		private void init(ModelClassFactory factory) 
		{
			try 
			{
				this.add(typeof(MSH), true, false);
				this.add(typeof(MFI), true, false);
				this.add(typeof(MFN_M04_MF_CDM), true, true);
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating MFN_M04 - this is probably a bug in the source code generator.", e);
			}
		}

		/**
		 * Returns MSH (Message header segment) - creates it if necessary
		 */
		public MSH MSH 
		{ 
			get
			{
				MSH ret = null;
				try 
				{
					ret = (MSH)this.get_Renamed("MSH");
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
		 * Returns MFI (Master file identification segment) - creates it if necessary
		 */
		public MFI MFI 
		{ 
			get
			{
				MFI ret = null;
				try 
				{
					ret = (MFI)this.get_Renamed("MFI");
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
		 * Returns  first repetition of MFN_M04_MF_CDM (a Group object) - creates it if necessary
		 */
		public MFN_M04_MF_CDM getMF_CDM() 
		{
			MFN_M04_MF_CDM ret = null;
			try 
			{
				ret = (MFN_M04_MF_CDM)this.get_Renamed("MF_CDM");
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
				throw new System.Exception("An unexpected error ocurred",e);
			}
			return ret;
		}

		/**
		 * Returns a specific repetition of MFN_M04_MF_CDM
		 * (a Group object) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public MFN_M04_MF_CDM getMF_CDM(int rep) 
		{ 
			return (MFN_M04_MF_CDM)this.get_Renamed("MF_CDM", rep);
		}

		/** 
		 * Returns the number of existing repetitions of MFN_M04_MF_CDM 
		 */ 
		public int MF_CDMReps 
		{ 
			get
			{
				int reps = -1; 
				try 
				{ 
					reps = this.getAll("MF_CDM").Length; 
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
