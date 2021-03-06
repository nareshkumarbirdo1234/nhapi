using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v22.datatype
{

///<summary>
/// <p>The HL7 CM_PARENT_RESULT (Undefined CM data type) data type.  Consists of the following components: </p><ol>
/// <li>observation identifier (OBX-3) of parent result (CE)</li>
/// <li>sub-ID (OBX-4) of parent result (ST)</li>
/// <li>result (OBX-5) from parent (CE)</li>
/// </ol>
///</summary>
[Serializable]
public class CM_PARENT_RESULT : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a CM_PARENT_RESULT.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public CM_PARENT_RESULT(Message message) : this(message, null){}

	///<summary>
	/// Creates a CM_PARENT_RESULT.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public CM_PARENT_RESULT(Message message, string description) : base(message, description){
		data = new Type[3];
		data[0] = new CE(message,"Observation identifier (OBX-3) of parent result");
		data[1] = new ST(message,"Sub-ID (OBX-4) of parent result");
		data[2] = new CE(message,"Result (OBX-5) from parent");
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
			throw new DataTypeException("Element " + number + " doesn't exist in 3 element CM_PARENT_RESULT composite"); 
		} 
	} 
	///<summary>
	/// Returns observation identifier (OBX-3) of parent result (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public CE ObservationIdentifierOBX3OfParentResult {
get{
	   CE ret = null;
	   try {
	      ret = (CE)getComponent(0);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns sub-ID (OBX-4) of parent result (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST SubIDOBX4OfParentResult {
get{
	   ST ret = null;
	   try {
	      ret = (ST)getComponent(1);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns result (OBX-5) from parent (component #2).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public CE ResultOBX5FromParent {
get{
	   CE ret = null;
	   try {
	      ret = (CE)getComponent(2);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
}}