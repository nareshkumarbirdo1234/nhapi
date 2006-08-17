using System;
using System.Collections;

namespace NHapi.Base.model
{
	
	/// <summary> An unspecified Composite datatype that has an undefined number of components, each 
	/// of which is a Varies.  
	/// This is used to store Varies data, when the data type is unknown.  It is also 
	/// used to store unrecognized message constituents.  
	/// </summary>
	/// <author>  Bryan Tripp
	/// </author>
	public class GenericComposite:AbstractType, IComposite
	{
        private ArrayList components;
        private IMessage message;

		/// <summary> Returns an array containing the components of this field.</summary>
		virtual public IType[] Components
		{
			get
			{
                IType[] ret = new IType[components.Count];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (IType) components[i];
				}
				return ret;

			}
			
		}

        ///// <summary> Returns the single component of this composite at the specified position (starting at 0) - 
        ///// Creates it (and any nonexistent components before it) if necessary.  
        ///// </summary>
        public IType this[int index]
        {
            get
            {
                for (int i = components.Count; i <= index; i++)
                {
                    components.Add(new Varies(message));
                }
                return (IType)components[index];
            }

        }
		/// <summary>Returns the name of the type (used in XML encoding and profile checking)  </summary>
		override public System.String Name
		{
			get
			{
				return "UNKNOWN";
			}
			
		}
		
		
		
		/// <summary>Creates a new instance of GenericComposite </summary>
		public GenericComposite(IMessage message):base(message)
		{
			this.message = message;
            components = new ArrayList();
		}
		
        ///// <summary> Returns the single component of this composite at the specified position (starting at 0) - 
        ///// Creates it (and any nonexistent components before it) if necessary.  
        ///// </summary>
        //public virtual IType getComponent(int number)
        //{
        //    for (int i = components.Count; i <= number; i++)
        //    {
        //        components.Add(new Varies(message));
        //    }
        //    return (IType) components[number];
        //}
	}
}