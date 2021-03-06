using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v25.datatype
{

///<summary>
/// <p>The HL7 NA (Numeric Array) data type.  Consists of the following components: </p><ol>
/// <li>Value1 (NM)</li>
/// <li>Value2 (NM)</li>
/// <li>Value3 (NM)</li>
/// <li>Value4 (NM)</li>
/// </ol>
///</summary>
[Serializable]
public class NA : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a NA.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public NA(Message message) : this(message, null){}

	///<summary>
	/// Creates a NA.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public NA(Message message, string description) : base(message, description){
		data = new Type[4];
		data[0] = new NM(message,"Value1");
		data[1] = new NM(message,"Value2");
		data[2] = new NM(message,"Value3");
		data[3] = new NM(message,"Value4");
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
			throw new DataTypeException("Element " + number + " doesn't exist in 4 element NA composite"); 
		} 
	} 
	///<summary>
	/// Returns Value1 (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public NM Value1 {
get{
	   NM ret = null;
	   try {
	      ret = (NM)getComponent(0);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Value2 (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public NM Value2 {
get{
	   NM ret = null;
	   try {
	      ret = (NM)getComponent(1);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Value3 (component #2).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public NM Value3 {
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
	///<summary>
	/// Returns Value4 (component #3).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public NM Value4 {
get{
	   NM ret = null;
	   try {
	      ret = (NM)getComponent(3);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
}}