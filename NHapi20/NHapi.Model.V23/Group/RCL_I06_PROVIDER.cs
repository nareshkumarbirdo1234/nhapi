using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V23.Segment;

using NHapi.Base.Model;

namespace NHapi.Model.V23.Group
{
    ///<summary>
    ///Represents the RCL_I06_PROVIDER Group.  A Group is an ordered collection of message 
    /// segments that can repeat together or be optionally in/excluded together.
    /// This Group contains the following elements: 
    /// * 0: PRD (Provider Data) 
    /// * 1: CTD (Contact Data) optional repeating
    ///</summary>
    [Serializable]
    public class RCL_I06_PROVIDER : AbstractGroup
    {

        ///<summary> 
        /// Creates a new RCL_I06_PROVIDER Group.
        ///</summary>
        public RCL_I06_PROVIDER(IGroup parent, IModelClassFactory factory)
            : base(parent, factory)
        {
            try
            {
                this.add(typeof(PRD), true, false);
                this.add(typeof(CTD), false, true);
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating RCL_I06_PROVIDER - this is probably a bug in the source code generator.", e);
            }
        }

        ///<summary>
        /// Returns PRD (Provider Data) - creates it if necessary
        ///</summary>
        public PRD PRD
        {
            get
            {
                PRD ret = null;
                try
                {
                    ret = (PRD)this.GetStructure("PRD");
                }
                catch (HL7Exception e)
                {
                    HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                    throw new System.Exception("An unexpected error ocurred", e);
                }
                return ret;
            }
        }

        ///<summary>
        /// Returns  first repetition of CTD (Contact Data) - creates it if necessary
        ///</summary>
        public CTD getCTD()
        {
            CTD ret = null;
            try
            {
                ret = (CTD)this.GetStructure("CTD");
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                throw new System.Exception("An unexpected error ocurred", e);
            }
            return ret;
        }

        ///<summary>
        ///Returns a specific repetition of CTD
        /// * (Contact Data) - creates it if necessary
        /// throws HL7Exception if the repetition requested is more than one 
        ///     greater than the number of existing repetitions.
        ///</summary>
        public CTD getCTD(int rep)
        {
            return (CTD)this.GetStructure("CTD", rep);
        }

        /** 
         * Returns the number of existing repetitions of CTD 
         */
        public int CTDReps
        {
            get
            {
                int reps = -1;
                try
                {
                    reps = this.GetAll("CTD").Length;
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