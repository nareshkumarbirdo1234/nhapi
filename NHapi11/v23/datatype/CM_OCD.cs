using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v23.datatype
{

///<summary>
/// <p>The HL7 CM_OCD (occurence) data type.  Consists of the following components: </p><ol>
/// <li>occurrence code (CE)</li>
/// <li>occurrence date (DT)</li>
/// </ol>
///</summary>
[Serializable]
public class CM_OCD : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a CM_OCD.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public CM_OCD(Message message) : this(message, null){}

	///<summary>
	/// Creates a CM_OCD.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public CM_OCD(Message message, string description) : base(message, description){
		data = new Type[2];
		data[0] = new CE(message,"Occurrence code");
		data[1] = new DT(message,"Occurrence date");
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
			throw new DataTypeException("Element " + number + " doesn't exist in 2 element CM_OCD composite"); 
		} 
	} 
	///<summary>
	/// Returns occurrence code (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public CE OccurrenceCode {
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
	/// Returns occurrence date (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public DT OccurrenceDate {
get{
	   DT ret = null;
	   try {
	      ret = (DT)getComponent(1);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
}}