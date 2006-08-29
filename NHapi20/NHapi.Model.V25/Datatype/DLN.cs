using System;
using NHapi.Base.Model;
using NHapi.Base.Log;
using NHapi.Base;
using NHapi.Base.Model.Primitive;

namespace NHapi.Model.V25.Datatype
{

///<summary>
/// <p>The HL7 DLN (Driver_s License Number) data type.  Consists of the following components: </p><ol>
/// <li>License Number (ST)</li>
/// <li>Issuing State, Province, Country (IS)</li>
/// <li>Expiration Date (DT)</li>
/// </ol>
///</summary>
[Serializable]
public class DLN : AbstractType, IComposite{
	private IType[] data;

	///<summary>
	/// Creates a DLN.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public DLN(IMessage message) : this(message, null){}

	///<summary>
	/// Creates a DLN.
	/// <param name="message">The Message to which this Type belongs</param>
	/// <param name="description">The description of this type</param>
	///</summary>
	public DLN(IMessage message, string description) : base(message, description){
		data = new IType[3];
		data[0] = new ST(message,"License Number");
		data[1] = new IS(message, 333,"Issuing State, Province, Country");
		data[2] = new DT(message,"Expiration Date");
	}

	///<summary>
	/// Returns an array containing the data elements.
	///</summary>
	public IType[] Components
	{ 
		get{
			return this.data; 
		}
	}

	///<summary>
	/// Returns an individual data component.
	/// @throws DataTypeException if the given element number is out of range.
	///<param name="index">The index item to get (zero based)</param>
	///<returns>The data component (as a type) at the requested number (ordinal)</returns>
	///</summary>
	public IType this[int index] { 

get{
		try { 
			return this.data[index]; 
		} catch (System.ArgumentOutOfRangeException) { 
			throw new DataTypeException("Element " + index + " doesn't exist in 3 element DLN composite"); 
		} 
	} 
	} 
	///<summary>
	/// Returns License Number (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST LicenseNumber {
get{
	   ST ret = null;
	   try {
	      ret = (ST)this[0];
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Issuing State, Province, Country (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public IS IssuingStateProvinceCountry {
get{
	   IS ret = null;
	   try {
	      ret = (IS)this[1];
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Expiration Date (component #2).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public DT ExpirationDate {
get{
	   DT ret = null;
	   try {
	      ret = (DT)this[2];
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
}}