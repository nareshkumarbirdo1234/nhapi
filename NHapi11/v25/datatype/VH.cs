using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v25.datatype
{

///<summary>
/// <p>The HL7 VH (Visiting Hours) data type.  Consists of the following components: </p><ol>
/// <li>Start Day Range (ID)</li>
/// <li>End Day Range (ID)</li>
/// <li>Start Hour Range (TM)</li>
/// <li>End Hour Range (TM)</li>
/// </ol>
///</summary>
[Serializable]
public class VH : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a VH.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public VH(Message message) : this(message, null){}

	///<summary>
	/// Creates a VH.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public VH(Message message, string description) : base(message, description){
		data = new Type[4];
		data[0] = new ID(message, 267,"Start Day Range");
		data[1] = new ID(message, 267,"End Day Range");
		data[2] = new TM(message,"Start Hour Range");
		data[3] = new TM(message,"End Hour Range");
	}

	///<summary>
	/// Returns an array containing the data elements.
	///</summary>
	public Type[] Components
	{ 
		get{
			return this.data; 
		}
	}

	///<summary>
	/// Returns an individual data component.
	/// @throws DataTypeException if the given element number is out of range.
	///<param name="number">The ordinal item to get</param>
	///<returns>The data component (as a type) at the requested number (ordinal)</returns>
	///<summary>
	public Type getComponent(int number) { 

		try { 
			return this.data[number]; 
		} catch (System.ArgumentOutOfRangeException) { 
			throw new DataTypeException("Element " + number + " doesn't exist in 4 element VH composite"); 
		} 
	} 
	///<summary>
	/// Returns Start Day Range (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ID StartDayRange {
get{
	   ID ret = null;
	   try {
	      ret = (ID)getComponent(0);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns End Day Range (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ID EndDayRange {
get{
	   ID ret = null;
	   try {
	      ret = (ID)getComponent(1);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Start Hour Range (component #2).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public TM StartHourRange {
get{
	   TM ret = null;
	   try {
	      ret = (TM)getComponent(2);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns End Hour Range (component #3).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public TM EndHourRange {
get{
	   TM ret = null;
	   try {
	      ret = (TM)getComponent(3);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
}}