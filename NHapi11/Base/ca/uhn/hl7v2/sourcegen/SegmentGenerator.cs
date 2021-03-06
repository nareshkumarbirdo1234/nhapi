/// <summary> The contents of this file are subject to the Mozilla Public License Version 1.1
/// (the "License"); you may not use this file except in compliance with the License.
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/
/// Software distributed under the License is distributed on an "AS IS" basis,
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the
/// specific language governing rights and limitations under the License.
/// 
/// The Original Code is "SegmentGenerator.java".  Description:
/// "This class is responsible for generating source code for HL7 segment objects"
/// 
/// The Initial Developer of the Original Code is University Health Network. Copyright (C)
/// 2001.  All Rights Reserved.
/// 
/// Contributor(s):  Eric Poiseau. 
/// 
/// Alternatively, the contents of this file may be used under the terms of the
/// GNU General Public License (the  �GPL�), in which case the provisions of the GPL are
/// applicable instead of those above.  If you wish to allow use of your version of this
/// file only under the terms of the GPL and not to allow others to use your version
/// of this file under the MPL, indicate your decision by deleting  the provisions above
/// and replace  them with the notice and other provisions required by the GPL License.
/// If you do not delete the provisions above, a recipient may use your version of
/// this file under either the MPL or the GPL.
/// 
/// </summary>
using System;
using NormativeDatabase = ca.uhn.hl7v2.NormativeDatabase;
using HL7Exception = ca.uhn.hl7v2.HL7Exception;
using HapiLog = ca.uhn.log.HapiLog;
using HapiLogFactory = ca.uhn.log.HapiLogFactory;
namespace ca.uhn.hl7v2.sourcegen
{
	
	
	/// <summary> This class is responsible for generating source code for HL7 segment objects.
	/// Each automatically generated segment inherits from AbstractSegment.
	/// 
	/// </summary>
	/// <author>  Bryan Tripp (bryan_tripp@sourceforge.net)
	/// </author>
	/// <author>  Eric Poiseau
	/// </author>
	public class SegmentGenerator:System.Object
	{
		
		//UPGRADE_NOTE: Final was removed from the declaration of 'log '. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1003'"
		//UPGRADE_NOTE: The initialization of  'log' was moved to static method 'ca.uhn.hl7v2.sourcegen.SegmentGenerator'. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1005'"
		private static readonly HapiLog log;
		
		/// <summary> <p>Creates skeletal source code (without correct data structure but no business
		/// logic) for all segments found in the normative database.  </p>
		/// </summary>
		public static void  makeAll(System.String baseDirectory, System.String version)
		{
			//make base directory
			if (!(baseDirectory.EndsWith("\\") || baseDirectory.EndsWith("/")))
			{
				baseDirectory = baseDirectory + "/";
			}
			System.IO.FileInfo targetDir = SourceGenerator.makeDirectory(baseDirectory + SourceGenerator.getVersionPackageDirectory(version) + "segment");
			
			//get list of data types
			//UPGRADE_NOTE: There are other database providers or managers under System.Data namespace which can be used optionally to better fit the application requirements. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1208'"
			System.Data.OleDb.OleDbConnection conn = NormativeDatabase.Instance.Connection;
			
			//UPGRADE_TODO: Method 'java.sql.Connection.createStatement' was converted to 'SupportClass.TransactionManager.manager.CreateStatement' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073_javasqlConnectioncreateStatement'"
			System.String sql = "SELECT seg_code, [section] from HL7Segments, HL7Versions where HL7Segments.version_id = HL7Versions.version_id AND hl7_version = '" + version + "'";
			System.Data.OleDb.OleDbCommand temp_OleDbCommand = new System.Data.OleDb.OleDbCommand();
			temp_OleDbCommand.Connection = conn;
			temp_OleDbCommand.CommandText = sql;
			System.Data.OleDb.OleDbDataReader rs = temp_OleDbCommand.ExecuteReader();
		
			
			System.Collections.ArrayList segments = new System.Collections.ArrayList();
			while (rs.Read())
			{
				System.String segName = System.Convert.ToString(rs[1 - 1]);
				if (System.Char.IsLetter(segName[0]))
					segments.Add(altSegName(segName));
			}
			//UPGRADE_ISSUE: Method 'java.sql.Statement.close' was not converted. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1000_javasqlStatementclose'"
			temp_OleDbCommand.Dispose();
			NormativeDatabase.Instance.returnConnection(conn);
			
			if (segments.Count == 0)
			{
				//UPGRADE_ISSUE: Method 'java.lang.System.getProperty' was not converted. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1000_javalangSystem'"
				log.warn("No version " + version + " segments found in database " + conn.Database);
			}
			
			for (int i = 0; i < segments.Count; i++)
			{
				try
				{
					System.String seg = (System.String) segments[i];
					System.String source = makeSegment(seg, version);
					//UPGRADE_WARNING: At least one expression was used more than once in the target code. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1181'"
					//UPGRADE_TODO: Constructor 'java.io.FileWriter.FileWriter' was converted to 'System.IO.StreamWriter' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073_javaioFileWriterFileWriter_javalangString_boolean'"
					//UPGRADE_TODO: Class 'java.io.FileWriter' was converted to 'System.IO.StreamWriter' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073_javaioFileWriter'"
					using(System.IO.StreamWriter w = new System.IO.StreamWriter(targetDir.ToString() + "/" + seg + ".cs"))
					{
						w.Write(source);
						w.Write("}");//Ending namespace
					}
				}
				catch (System.Exception e)
				{
					//UPGRADE_TODO: The equivalent in .NET for method 'java.lang.Throwable.getMessage' may return a different value. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1043'"
					System.Console.Error.WriteLine("Error creating source code for all segments: " + e.Message);
					SupportClass.WriteStackTrace(e, Console.Error);
				}
			}
			
		}
		
		/// <summary> <p>Returns an alternate segment name to replace the given segment name.  Substitutions
		/// made include:  </p>
		/// <ul><li>Replacing Z.. with Z</li>
		/// <li>Replacing ??? with ???</li></ul>
		/// </summary>
		public static System.String altSegName(System.String segmentName)
		{
			System.String ret = segmentName;
			if (ret.Equals("Z.."))
				ret = "Z";
			return ret;
		}
		
		/// <summary> Returns the Java source code for a class that represents the specified segment.</summary>
		public static System.String makeSegment(System.String name, System.String version)
		{
			Console.WriteLine("Making segment " + name);
			System.Text.StringBuilder source = new System.Text.StringBuilder();
			try
			{
				//UPGRADE_NOTE: There are other database providers or managers under System.Data namespace which can be used optionally to better fit the application requirements. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1208'"
				System.Collections.ArrayList elements = new System.Collections.ArrayList();
				SegmentElement se;
				System.String segDesc = null;
				using(System.Data.OleDb.OleDbConnection conn = NormativeDatabase.Instance.Connection)
				{
					System.Text.StringBuilder sql = new System.Text.StringBuilder();
					sql.Append("SELECT HL7SegmentDataElements.seg_code, HL7SegmentDataElements.seq_no, ");
					sql.Append("HL7SegmentDataElements.repetitional, HL7SegmentDataElements.repetitions, ");
					sql.Append("HL7DataElements.description, HL7DataElements.length, HL7DataElements.table_id, ");
					sql.Append("HL7SegmentDataElements.req_opt, HL7Segments.description, HL7DataElements.data_structure ");
					sql.Append("FROM HL7Versions RIGHT JOIN (HL7Segments INNER JOIN (HL7DataElements INNER JOIN HL7SegmentDataElements ");
					sql.Append("ON (HL7DataElements.version_id = HL7SegmentDataElements.version_id) ");
					sql.Append("AND (HL7DataElements.data_item = HL7SegmentDataElements.data_item)) ");
					sql.Append("ON (HL7Segments.version_id = HL7SegmentDataElements.version_id) ");
					sql.Append("AND (HL7Segments.seg_code = HL7SegmentDataElements.seg_code)) ");
					sql.Append("ON (HL7Versions.version_id = HL7Segments.version_id) ");
					sql.Append("WHERE HL7SegmentDataElements.seg_code = '");
					sql.Append(name);
					sql.Append("' and HL7Versions.hl7_version = '");
					sql.Append(version);
					sql.Append("' ORDER BY HL7SegmentDataElements.seg_code, HL7SegmentDataElements.seq_no;");
					//System.out.println(sql.toString());  //for debugging 	           
					//UPGRADE_TODO: Method 'java.sql.Connection.createStatement' was converted to 'SupportClass.TransactionManager.manager.CreateStatement' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073_javasqlConnectioncreateStatement'"
					System.Data.OleDb.OleDbCommand stmt = SupportClass.TransactionManager.manager.CreateStatement(conn);
					//UPGRADE_TODO: Interface 'java.sql.ResultSet' was converted to 'System.Data.OleDb.OleDbDataReader' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073_javasqlResultSet'"
					System.Data.OleDb.OleDbCommand temp_OleDbCommand;
					temp_OleDbCommand = stmt;
					temp_OleDbCommand.CommandText = sql.ToString();
					System.Data.OleDb.OleDbDataReader rs = temp_OleDbCommand.ExecuteReader();
					
					while (rs.Read())
					{
						if (segDesc == null)
							segDesc = System.Convert.ToString(rs[9 - 1]);
						se = new SegmentElement();
						se.field = Convert.ToInt32(rs.GetValue(2 - 1));
						se.rep = System.Convert.ToString(rs[3 - 1]);
						if(rs.IsDBNull(4-1))
							se.repetitions=0;
						else
							se.repetitions = Convert.ToInt32(rs.GetValue(4 - 1));

						if (se.repetitions == 0)
						{
							if (se.rep == null || !se.rep.ToUpper().Equals("Y".ToUpper()))
							{
								se.repetitions = 1;
							}
						}
						se.desc = System.Convert.ToString(rs[5 - 1]);
						if(!rs.IsDBNull(6-1))
							se.length = Convert.ToInt32(rs.GetValue(6 - 1));
						se.table = Convert.ToInt32(rs.GetValue(7 - 1));
						se.opt = System.Convert.ToString(rs[8 - 1]);
						se.type = System.Convert.ToString(rs[10 - 1]);
						//shorten CE_x to CE
						if (se.type.StartsWith("CE"))
							se.type = "CE";
					
						elements.Add(se);
						/*System.out.println("Segment: " + name + " Field: " + se.field + " Rep: " + se.rep +
						" Repetitions: " + se.repetitions + " Desc: " + se.desc + " Length: " + se.length +
						" Table: " + se.table + " Segment Desc: " + segDesc);*/
					}
					rs.Close();
					//UPGRADE_ISSUE: Method 'java.sql.Statement.close' was not converted. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1000_javasqlStatementclose'"
					stmt.Dispose();
					NormativeDatabase.Instance.returnConnection(conn);
				}
				
				//write imports, class documentation, etc ...
				source.Append("using System;\r\n");
				source.Append("using ca.uhn.hl7v2.model;\r\n");
				source.Append("using ");
				source.Append(SourceGenerator.getVersionPackageName(version));
				source.Append("datatype;\r\n\r\n");
				source.Append("using ca.uhn.log;\r\n");
				source.Append("using ca.uhn.hl7v2.parser;\r\n");
				source.Append("using ca.uhn.hl7v2;\r\n\r\n");
				
				source.Append("namespace ");
				source.Append(SourceGenerator.getVersionPackageName(version));
				source.Append("segment{\r\n\r\n");
				source.Append("/**\r\n");
				source.Append(" * <p>Represents an HL7 ");
				source.Append(name);
				source.Append(" message segment. \r\n");
				source.Append(" * This segment has the following fields:</p><p>\r\n");
				for (int i = 0; i < elements.Count; i++)
				{
					se = (SegmentElement) elements[i];
					source.Append(" * ");
					source.Append(name);
					source.Append("-");
					source.Append(se.field);
					source.Append(": ");
					source.Append(se.desc);
					source.Append(" (");
					source.Append(se.type);
					source.Append(")<br> \r\n");
				}
				source.Append(" * </p><p>The get...() methods return data from individual fields.  These methods \r\n");
				source.Append(" * do not throw exceptions and may therefore have to handle exceptions internally.  \r\n");
				source.Append(" * If an exception is handled internally, it is logged and null is returned.  \r\n");
				source.Append(" * This is not expected to happen - if it does happen this indicates not so much \r\n");
				source.Append(" * an exceptional circumstance as a bug in the code for this class.</p>    \r\n");
				source.Append(" */\r\n");
				source.Append("[Serializable]\r\n");
				source.Append("public class ");
				source.Append(name);
				source.Append(" : AbstractSegment ");
				
				//implement interface from model.control package if required
				/*Class correspondingControlInterface = Control.getInterfaceImplementedBy(name);
				if (correspondingControlInterface != null) {
				source.append("implements ");
				source.append(correspondingControlInterface.getName());
				} */
				
				source.Append(" {\r\n\r\n");
				source.Append("  /**\r\n");
				source.Append("   * Creates a ");
				source.Append(name);
				source.Append(" (");
				source.Append(segDesc);
				source.Append(") segment object that belongs to the given \r\n");
				source.Append("   * message.  \r\n");
				source.Append("   */\r\n");
				
				//write constructor
				source.Append("  public ");
				source.Append(name);
				source.Append("(Group parent, ModelClassFactory factory) : base(parent,factory) {\r\n");
				source.Append("    Message message = Message;\r\n");
				if (elements.Count > 0)
				{
					source.Append("    try {\r\n");
					for (int i = 0; i < elements.Count; i++)
					{
						se = (SegmentElement) elements[i];
						System.String type = SourceGenerator.getAlternateType(se.type, version);
						source.Append("       this.add(");
						source.Append("typeof(" + type + ")");
						//                    if (type.equalsIgnoreCase("Varies")) {
						//                    } else {
						//                        source.append("factory.getTypeClass(\"");
						//                        source.append(type);
						//                        source.append("\", \"");
						//                        source.append(version);
						//                        source.append("\")");
						//                    }
						source.Append(", ");
						if (se.opt == null)
						{
							source.Append("false");
						}
						else
						{
							if (se.opt.ToUpper().Equals("R".ToUpper()))
							{
								source.Append("true");
							}
							else
							{
								source.Append("false");
							}
						}
						source.Append(", ");
						source.Append(se.repetitions);
						source.Append(", ");
						source.Append(se.length);
						source.Append(", ");
						if (se.type.Equals("ID") || se.type.Equals("IS"))
						{
							source.Append("new System.Object[]{message, ");
							source.Append(se.table);
							source.Append("}");
						}
						else
						{
							source.Append("new System.Object[]{message}");
						}
						if(se.desc!=null && se.desc.Trim().Length>0)
						{
							source.Append(", ");
							

							source.Append("\"" + se.GetDescriptionWithoutSpecialCharacters() + "\"");
						}
						source.Append(");\r\n");
					}
					source.Append("    } catch (HL7Exception he) {\r\n");
					source.Append("        HapiLogFactory.getHapiLog(GetType()).error(\"Can't instantiate \" + this.getStructureName(), he);\r\n");
					source.Append("    }\r\n");
				}
				source.Append("  }\r\n\r\n");
				
				//write a datatype-specific accessor for each field
				for (int i = 0; i < elements.Count; i++)
				{
					se = (SegmentElement) elements[i];
					if (!se.desc.ToUpper().Equals("UNUSED".ToUpper()))
					{
						//some entries in 2.1 DB say "unused"
						System.String type = SourceGenerator.getAlternateType(se.type, version);
						source.Append("\t/**\r\n");
						source.Append("\t* Returns ");
						if (se.repetitions != 1)
							source.Append("a single repetition of ");
						source.Append(se.desc);
						source.Append("(");
						source.Append(name);
						source.Append("-");
						source.Append(se.field);
						source.Append(").\r\n");
						if (se.repetitions != 1)
						{
							source.Append("\t* @param rep the repetition number (this is a repeating field)\r\n");
							source.Append("\t* @throws HL7Exception if the repetition number is invalid.\r\n");
						}
						source.Append("\t*/\r\n");
						source.Append("\tpublic ");
						source.Append(type);
						source.Append(" ");
						source.Append(SourceGenerator.makeAccessorNameCSharp(se.desc, se.repetitions));						
						if (se.repetitions != 1)
							source.Append("(int rep)");
						source.Append("\n\t{\r\n");
						if(se.repetitions==1)
							source.Append("\t\tget{\r\n");
						source.Append("\t\t\t");
						source.Append(type);
						source.Append(" ret = null;\r\n");
						source.Append("\t\t\ttry\n\t\t\t{\r\n");
						source.Append("\t\t\tType t = this.getField(");
						source.Append(se.field);
						source.Append(", ");
						if (se.repetitions == 1)
						{
							source.Append("0");
						}
						else
						{
							source.Append("rep");
						}
						source.Append(");\r\n");
						source.Append("\t\t\t\tret = (");
						source.Append(type);
						source.Append(")t;\r\n");
						if (se.repetitions == 1)
						{
							source.Append("\t\t\t}\n\t\t\t catch (HL7Exception he) {\r\n");
							source.Append("\t\t\tHapiLogFactory.getHapiLog(GetType()).error(\"Unexpected problem obtaining field value.  This is a bug.\", he);\r\n");
							source.Append("\t\t\t\tthrow new System.Exception(\"An unexpected error ocurred\", he);\r\n");
						}
						source.Append("\t\t} catch (System.Exception ex) {\r\n");
						source.Append("\t\t\tHapiLogFactory.getHapiLog(GetType()).error(\"Unexpected problem obtaining field value.  This is a bug.\", ex);\r\n");
						source.Append("\t\t\t\tthrow new System.Exception(\"An unexpected error ocurred\", ex);\r\n");
						source.Append("    }\r\n");
						source.Append("\t\t\treturn ret;\r\n");
						if(se.repetitions==1)
							source.Append("\t}\r\n"); //End get
						source.Append("  }\r\n\r\n");
						
						
						//add an array accessor as well for repeating fields
						if (se.repetitions != 1)
						{
							source.Append("  /**\r\n");
							source.Append("   * Returns all repetitions of ");
							source.Append(se.desc);
							source.Append(" (");
							source.Append(name);
							source.Append("-");
							source.Append(se.field);
							source.Append(").\r\n");
							source.Append("   */\r\n");
							source.Append("  public ");
							source.Append(type);
							source.Append("[] ");
							source.Append(SourceGenerator.makeAccessorName(se.desc));
							source.Append("() {\r\n");
							source.Append("     ");
							source.Append(type);
							source.Append("[] ret = null;\r\n");
							source.Append("    try {\r\n");
							source.Append("        Type[] t = this.getField(");
							source.Append(se.field);
							source.Append(");  \r\n");
							source.Append("        ret = new ");
							source.Append(type);
							source.Append("[t.Length];\r\n");
							source.Append("        for (int i = 0; i < ret.Length; i++) {\r\n");
							source.Append("            ret[i] = (");
							source.Append(type);
							source.Append(")t[i];\r\n");
							source.Append("        }\r\n");
							source.Append("    } catch (HL7Exception he) {\r\n");
							source.Append("        HapiLogFactory.getHapiLog(this.GetType()).error(\"Unexpected problem obtaining field value.  This is a bug.\", he);\r\n");
							source.Append("        throw new System.Exception(\"An unexpected error ocurred\", he);\r\n");
							source.Append("    } catch (System.Exception cce) {\r\n");
							source.Append("        HapiLogFactory.getHapiLog(GetType()).error(\"Unexpected problem obtaining field value.  This is a bug.\", cce);\r\n");
							source.Append("        throw new System.Exception(\"An unexpected error ocurred\", cce);\r\n");
							source.Append("  }\r\n");
							source.Append(" return ret;\r\n");
							source.Append("}\r\n\r\n");
						}
					}
				}
				
				//add adapter method code for control package if it exists
				//source.append(Control.getImplementation(correspondingControlInterface, version));
				
				source.Append("\n}");
			}
			catch (System.Data.OleDb.OleDbException sqle)
			{
				SupportClass.WriteStackTrace(sqle, Console.Error);
			}
			
			return source.ToString();
		}

		
		
		
		[STAThread]
		public static void  Main(System.String[] args)
		{
			if (args.Length != 1 && args.Length != 2)
			{
				System.Console.Out.WriteLine("Usage: SegmentGenerator target_dir [segment_name]");
				System.Environment.Exit(1);
			}
			
			//System.setProperty("ca.on.uhn.hl7.database.url", "jdbc:odbc:hl7");
			
			try
			{
				//UPGRADE_TODO: The differences in the format  of parameters for method 'java.lang.Class.forName'  may cause compilation errors.  "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1092'"
				System.Type.GetType("sun.jdbc.odbc.JdbcOdbcDriver");
				if (args.Length == 1)
				{
					makeAll(args[0], "2.4");
				}
				else
				{
					System.String source = makeSegment(args[1], "2.4");
					//UPGRADE_WARNING: At least one expression was used more than once in the target code. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1181'"
					//UPGRADE_TODO: Constructor 'java.io.FileWriter.FileWriter' was converted to 'System.IO.StreamWriter' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073_javaioFileWriterFileWriter_javalangString_boolean'"
					//UPGRADE_TODO: Class 'java.io.FileWriter' was converted to 'System.IO.StreamWriter' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073_javaioFileWriter'"
					System.IO.StreamWriter w = new System.IO.StreamWriter(new System.IO.StreamWriter(args[0] + "/" + args[1] + ".java", false, System.Text.Encoding.Default).BaseStream, new System.IO.StreamWriter(args[0] + "/" + args[1] + ".java", false, System.Text.Encoding.Default).Encoding);
					w.Write(source);
					w.Flush();
					w.Close();
				}
			}
			catch (System.Exception e)
			{
				SupportClass.WriteStackTrace(e, Console.Error);
			}
		}
		static SegmentGenerator()
		{
			log = HapiLogFactory.getHapiLog(typeof(SegmentGenerator));
		}
	}
}