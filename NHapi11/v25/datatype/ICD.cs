using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v25.datatype
{

///<summary>
/// <p>The HL7 ICD (Insurance Certification Definition) data type.  Consists of the following components: </p><ol>
/// <li>Certification Patient Type (IS)</li>
/// <li>Certification Required (ID)</li>
/// <li>Date/Time Certification Required (TS)</li>
/// </ol>
///</summary>
[Serializable]
public class ICD : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a ICD.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public ICD(Message message) : this(message, null){}

	///<summary>
	/// Creates a ICD.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public ICD(Message message, string description) : base(message, description){
		data = new Type[3];
		data[0] = new IS(message, 150,"Certification Patient Type");
		data[1] = new ID(message, 136,"Certification Required");
		data[2] = new TS(message,"Date/Time Certification Required");
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
			throw new DataTypeException("Element " + number + " doesn't exist in 3 element ICD composite"); 
		} 
	} 
	///<summary>
	/// Returns Certification Patient Type (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public IS CertificationPatientType {
get{
	   IS ret = null;
	   try {
	      ret = (IS)getComponent(0);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Certification Required (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ID CertificationRequired {
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
	/// Returns Date/Time Certification Required (component #2).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public TS DateTimeCertificationRequired {
get{
	   TS ret = null;
	   try {
	      ret = (TS)getComponent(2);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
}}