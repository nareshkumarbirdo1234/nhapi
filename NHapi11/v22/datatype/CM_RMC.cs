using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v22.datatype
{

///<summary>
/// <p>The HL7 CM_RMC (Room Coverage) data type.  Consists of the following components: </p><ol>
/// <li>room type (ID)</li>
/// <li>amount type (ID)</li>
/// <li>coverage amount (NM)</li>
/// </ol>
///</summary>
[Serializable]
public class CM_RMC : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a CM_RMC.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public CM_RMC(Message message) : this(message, null){}

	///<summary>
	/// Creates a CM_RMC.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public CM_RMC(Message message, string description) : base(message, description){
		data = new Type[3];
		data[0] = new ID(message, 0,"Room type");
		data[1] = new ID(message, 0,"Amount type");
		data[2] = new NM(message,"Coverage amount");
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
			throw new DataTypeException("Element " + number + " doesn't exist in 3 element CM_RMC composite"); 
		} 
	} 
	///<summary>
	/// Returns room type (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ID RoomType {
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
	/// Returns amount type (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ID AmountType {
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
	/// Returns coverage amount (component #2).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public NM CoverageAmount {
get{
	   NM ret = null;
	   try {
	      ret = (NM)getComponent(2);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
}}