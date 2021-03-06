using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using ca.uhn.hl7v2.model.v23.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the RRI_I15_PROCEDURE Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: PR1 (Procedures) <b></b><br>
 * 1: RRI_I15_AUTHORIZATION (a Group object) <b>optional </b><br>
 */
namespace ca.uhn.hl7v2.model.v23.group
{
	public class RRI_I15_PROCEDURE : AbstractGroup 
	{

		/** 
		 * Creates a new RRI_I15_PROCEDURE Group.
		 */
		public RRI_I15_PROCEDURE(Group parent, ModelClassFactory factory) : base(parent, factory)
		{
			try 
			{
				this.add(typeof(PR1), true, false);
				this.add(typeof(RRI_I15_AUTHORIZATION), false, false);
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating RRI_I15_PROCEDURE - this is probably a bug in the source code generator.", e);
			}
		}

		/**
		 * Returns PR1 (Procedures) - creates it if necessary
		 */
		public PR1 PR1 
		{ 
			get
			{
				PR1 ret = null;
				try 
				{
					ret = (PR1)this.get_Renamed("PR1");
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
		 * Returns RRI_I15_AUTHORIZATION (a Group object) - creates it if necessary
		 */
		public RRI_I15_AUTHORIZATION AUTHORIZATION 
		{ 
			get
			{
				RRI_I15_AUTHORIZATION ret = null;
				try 
				{
					ret = (RRI_I15_AUTHORIZATION)this.get_Renamed("AUTHORIZATION");
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
