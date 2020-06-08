using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Trash
{
	// Token: 0x0200000F RID: 15
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[XmlSchemaProvider("GetTypedDataSetSchema")]
	[XmlRoot("POSdbDataSet")]
	[HelpKeyword("vs.data.DataSet")]
	[Serializable]
	public class POSdbDataSet : DataSet
	{
		// Token: 0x060000A0 RID: 160 RVA: 0x00009BD0 File Offset: 0x00007DD0
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public POSdbDataSet()
		{
			base.BeginInit();
			this.InitClass();
			CollectionChangeEventHandler value = new CollectionChangeEventHandler(this.SchemaChanged);
			base.Tables.CollectionChanged += value;
			base.Relations.CollectionChanged += value;
			base.EndInit();
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00009C24 File Offset: 0x00007E24
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected POSdbDataSet(SerializationInfo info, StreamingContext context) : base(info, context, false)
		{
			if (base.IsBinarySerialized(info, context))
			{
				this.InitVars(false);
				CollectionChangeEventHandler value = new CollectionChangeEventHandler(this.SchemaChanged);
				this.Tables.CollectionChanged += value;
				this.Relations.CollectionChanged += value;
				return;
			}
			string s = (string)info.GetValue("XmlSchema", typeof(string));
			if (base.DetermineSchemaSerializationMode(info, context) == SchemaSerializationMode.IncludeSchema)
			{
				DataSet dataSet = new DataSet();
				dataSet.ReadXmlSchema(new XmlTextReader(new StringReader(s)));
				if (dataSet.Tables["Itemdb"] != null)
				{
					base.Tables.Add(new POSdbDataSet.ItemdbDataTable(dataSet.Tables["Itemdb"]));
				}
				base.DataSetName = dataSet.DataSetName;
				base.Prefix = dataSet.Prefix;
				base.Namespace = dataSet.Namespace;
				base.Locale = dataSet.Locale;
				base.CaseSensitive = dataSet.CaseSensitive;
				base.EnforceConstraints = dataSet.EnforceConstraints;
				base.Merge(dataSet, false, MissingSchemaAction.Add);
				this.InitVars();
			}
			else
			{
				base.ReadXmlSchema(new XmlTextReader(new StringReader(s)));
			}
			base.GetSerializationData(info, context);
			CollectionChangeEventHandler value2 = new CollectionChangeEventHandler(this.SchemaChanged);
			base.Tables.CollectionChanged += value2;
			this.Relations.CollectionChanged += value2;
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x000025E7 File Offset: 0x000007E7
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public POSdbDataSet.ItemdbDataTable Itemdb
		{
			get
			{
				return this.tableItemdb;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x000025EF File Offset: 0x000007EF
		// (set) Token: 0x060000A4 RID: 164 RVA: 0x000025F7 File Offset: 0x000007F7
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		[Browsable(true)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		public override SchemaSerializationMode SchemaSerializationMode
		{
			get
			{
				return this._schemaSerializationMode;
			}
			set
			{
				this._schemaSerializationMode = value;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x00002600 File Offset: 0x00000800
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public new DataTableCollection Tables
		{
			get
			{
				return base.Tables;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x00002608 File Offset: 0x00000808
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public new DataRelationCollection Relations
		{
			get
			{
				return base.Relations;
			}
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00002610 File Offset: 0x00000810
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void InitializeDerivedDataSet()
		{
			base.BeginInit();
			this.InitClass();
			base.EndInit();
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00002624 File Offset: 0x00000824
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public override DataSet Clone()
		{
			POSdbDataSet posdbDataSet = (POSdbDataSet)base.Clone();
			posdbDataSet.InitVars();
			posdbDataSet.SchemaSerializationMode = this.SchemaSerializationMode;
			return posdbDataSet;
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00002643 File Offset: 0x00000843
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override bool ShouldSerializeTables()
		{
			return false;
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00002643 File Offset: 0x00000843
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override bool ShouldSerializeRelations()
		{
			return false;
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00009D84 File Offset: 0x00007F84
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void ReadXmlSerializable(XmlReader reader)
		{
			if (base.DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
			{
				this.Reset();
				DataSet dataSet = new DataSet();
				dataSet.ReadXml(reader);
				if (dataSet.Tables["Itemdb"] != null)
				{
					base.Tables.Add(new POSdbDataSet.ItemdbDataTable(dataSet.Tables["Itemdb"]));
				}
				base.DataSetName = dataSet.DataSetName;
				base.Prefix = dataSet.Prefix;
				base.Namespace = dataSet.Namespace;
				base.Locale = dataSet.Locale;
				base.CaseSensitive = dataSet.CaseSensitive;
				base.EnforceConstraints = dataSet.EnforceConstraints;
				base.Merge(dataSet, false, MissingSchemaAction.Add);
				this.InitVars();
				return;
			}
			base.ReadXml(reader);
			this.InitVars();
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00009E4C File Offset: 0x0000804C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override XmlSchema GetSchemaSerializable()
		{
			MemoryStream memoryStream = new MemoryStream();
			base.WriteXmlSchema(new XmlTextWriter(memoryStream, null));
			memoryStream.Position = 0L;
			return XmlSchema.Read(new XmlTextReader(memoryStream), null);
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00002646 File Offset: 0x00000846
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal void InitVars()
		{
			this.InitVars(true);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x0000264F File Offset: 0x0000084F
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal void InitVars(bool initTable)
		{
			this.tableItemdb = (POSdbDataSet.ItemdbDataTable)base.Tables["Itemdb"];
			if (initTable && this.tableItemdb != null)
			{
				this.tableItemdb.InitVars();
			}
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00009E80 File Offset: 0x00008080
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		private void InitClass()
		{
			base.DataSetName = "POSdbDataSet";
			base.Prefix = "";
			base.Namespace = "http://tempuri.org/POSdbDataSet.xsd";
			base.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tableItemdb = new POSdbDataSet.ItemdbDataTable();
			base.Tables.Add(this.tableItemdb);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00002643 File Offset: 0x00000843
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		private bool ShouldSerializeItemdb()
		{
			return false;
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00002682 File Offset: 0x00000882
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		private void SchemaChanged(object sender, CollectionChangeEventArgs e)
		{
			if (e.Action == CollectionChangeAction.Remove)
			{
				this.InitVars();
			}
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00009ED8 File Offset: 0x000080D8
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
		{
			POSdbDataSet posdbDataSet = new POSdbDataSet();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = posdbDataSet.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = posdbDataSet.GetSchemaSerializable();
			if (xs.Contains(schemaSerializable.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					schemaSerializable.Write(memoryStream);
					foreach (object obj in xs.Schemas(schemaSerializable.TargetNamespace))
					{
						XmlSchema xmlSchema = (XmlSchema)obj;
						memoryStream2.SetLength(0L);
						xmlSchema.Write(memoryStream2);
						if (memoryStream.Length == memoryStream2.Length)
						{
							memoryStream.Position = 0L;
							memoryStream2.Position = 0L;
							while (memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte())
							{
							}
							if (memoryStream.Position == memoryStream.Length)
							{
								return xmlSchemaComplexType;
							}
						}
					}
				}
				finally
				{
					if (memoryStream != null)
					{
						memoryStream.Close();
					}
					if (memoryStream2 != null)
					{
						memoryStream2.Close();
					}
				}
			}
			xs.Add(schemaSerializable);
			return xmlSchemaComplexType;
		}

		// Token: 0x04000091 RID: 145
		private POSdbDataSet.ItemdbDataTable tableItemdb;

		// Token: 0x04000092 RID: 146
		private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

		// Token: 0x02000010 RID: 16
		// (Invoke) Token: 0x060000B4 RID: 180
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public delegate void ItemdbRowChangeEventHandler(object sender, POSdbDataSet.ItemdbRowChangeEvent e);

		// Token: 0x02000011 RID: 17
		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class ItemdbDataTable : TypedTableBase<POSdbDataSet.ItemdbRow>
		{
			// Token: 0x060000B7 RID: 183 RVA: 0x00002693 File Offset: 0x00000893
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			public ItemdbDataTable()
			{
				base.TableName = "Itemdb";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			// Token: 0x060000B8 RID: 184 RVA: 0x0000A018 File Offset: 0x00008218
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			internal ItemdbDataTable(DataTable table)
			{
				base.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					base.CaseSensitive = table.CaseSensitive;
				}
				if (table.Locale.ToString() != table.DataSet.Locale.ToString())
				{
					base.Locale = table.Locale;
				}
				if (table.Namespace != table.DataSet.Namespace)
				{
					base.Namespace = table.Namespace;
				}
				base.Prefix = table.Prefix;
				base.MinimumCapacity = table.MinimumCapacity;
			}

			// Token: 0x060000B9 RID: 185 RVA: 0x000026B8 File Offset: 0x000008B8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			protected ItemdbDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			// Token: 0x17000021 RID: 33
			// (get) Token: 0x060000BA RID: 186 RVA: 0x000026C8 File Offset: 0x000008C8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			public DataColumn Item_codeColumn
			{
				get
				{
					return this.columnItem_code;
				}
			}

			// Token: 0x17000022 RID: 34
			// (get) Token: 0x060000BB RID: 187 RVA: 0x000026D0 File Offset: 0x000008D0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			public DataColumn Item_nameColumn
			{
				get
				{
					return this.columnItem_name;
				}
			}

			// Token: 0x17000023 RID: 35
			// (get) Token: 0x060000BC RID: 188 RVA: 0x000026D8 File Offset: 0x000008D8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			public DataColumn Item_priceColumn
			{
				get
				{
					return this.columnItem_price;
				}
			}

			// Token: 0x17000024 RID: 36
			// (get) Token: 0x060000BD RID: 189 RVA: 0x000026E0 File Offset: 0x000008E0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			[Browsable(false)]
			public int Count
			{
				get
				{
					return base.Rows.Count;
				}
			}

			// Token: 0x17000025 RID: 37
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			public POSdbDataSet.ItemdbRow this[int index]
			{
				get
				{
					return (POSdbDataSet.ItemdbRow)base.Rows[index];
				}
			}

			// Token: 0x14000001 RID: 1
			// (add) Token: 0x060000BF RID: 191 RVA: 0x0000A0C0 File Offset: 0x000082C0
			// (remove) Token: 0x060000C0 RID: 192 RVA: 0x0000A0F8 File Offset: 0x000082F8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			public event POSdbDataSet.ItemdbRowChangeEventHandler ItemdbRowChanging;

			// Token: 0x14000002 RID: 2
			// (add) Token: 0x060000C1 RID: 193 RVA: 0x0000A130 File Offset: 0x00008330
			// (remove) Token: 0x060000C2 RID: 194 RVA: 0x0000A168 File Offset: 0x00008368
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			public event POSdbDataSet.ItemdbRowChangeEventHandler ItemdbRowChanged;

			// Token: 0x14000003 RID: 3
			// (add) Token: 0x060000C3 RID: 195 RVA: 0x0000A1A0 File Offset: 0x000083A0
			// (remove) Token: 0x060000C4 RID: 196 RVA: 0x0000A1D8 File Offset: 0x000083D8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			public event POSdbDataSet.ItemdbRowChangeEventHandler ItemdbRowDeleting;

			// Token: 0x14000004 RID: 4
			// (add) Token: 0x060000C5 RID: 197 RVA: 0x0000A210 File Offset: 0x00008410
			// (remove) Token: 0x060000C6 RID: 198 RVA: 0x0000A248 File Offset: 0x00008448
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			public event POSdbDataSet.ItemdbRowChangeEventHandler ItemdbRowDeleted;

			// Token: 0x060000C7 RID: 199 RVA: 0x00002700 File Offset: 0x00000900
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			public void AddItemdbRow(POSdbDataSet.ItemdbRow row)
			{
				base.Rows.Add(row);
			}

			// Token: 0x060000C8 RID: 200 RVA: 0x0000A280 File Offset: 0x00008480
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			public POSdbDataSet.ItemdbRow AddItemdbRow(int Item_code, string Item_name, decimal Item_price)
			{
				POSdbDataSet.ItemdbRow itemdbRow = (POSdbDataSet.ItemdbRow)base.NewRow();
				object[] itemArray = new object[]
				{
					Item_code,
					Item_name,
					Item_price
				};
				itemdbRow.ItemArray = itemArray;
				base.Rows.Add(itemdbRow);
				return itemdbRow;
			}

			// Token: 0x060000C9 RID: 201 RVA: 0x0000270E File Offset: 0x0000090E
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			public POSdbDataSet.ItemdbRow FindByItem_code(int Item_code)
			{
				return (POSdbDataSet.ItemdbRow)base.Rows.Find(new object[]
				{
					Item_code
				});
			}

			// Token: 0x060000CA RID: 202 RVA: 0x0000272F File Offset: 0x0000092F
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			public override DataTable Clone()
			{
				POSdbDataSet.ItemdbDataTable itemdbDataTable = (POSdbDataSet.ItemdbDataTable)base.Clone();
				itemdbDataTable.InitVars();
				return itemdbDataTable;
			}

			// Token: 0x060000CB RID: 203 RVA: 0x00002742 File Offset: 0x00000942
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new POSdbDataSet.ItemdbDataTable();
			}

			// Token: 0x060000CC RID: 204 RVA: 0x0000A2CC File Offset: 0x000084CC
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			internal void InitVars()
			{
				this.columnItem_code = base.Columns["Item_code"];
				this.columnItem_name = base.Columns["Item_name"];
				this.columnItem_price = base.Columns["Item_price"];
			}

			// Token: 0x060000CD RID: 205 RVA: 0x0000A31C File Offset: 0x0000851C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			private void InitClass()
			{
				this.columnItem_code = new DataColumn("Item_code", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnItem_code);
				this.columnItem_name = new DataColumn("Item_name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnItem_name);
				this.columnItem_price = new DataColumn("Item_price", typeof(decimal), null, MappingType.Element);
				base.Columns.Add(this.columnItem_price);
				base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[]
				{
					this.columnItem_code
				}, true));
				this.columnItem_code.AllowDBNull = false;
				this.columnItem_code.Unique = true;
				this.columnItem_name.AllowDBNull = false;
				this.columnItem_name.MaxLength = int.MaxValue;
				this.columnItem_price.AllowDBNull = false;
			}

			// Token: 0x060000CE RID: 206 RVA: 0x00002749 File Offset: 0x00000949
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			public POSdbDataSet.ItemdbRow NewItemdbRow()
			{
				return (POSdbDataSet.ItemdbRow)base.NewRow();
			}

			// Token: 0x060000CF RID: 207 RVA: 0x00002756 File Offset: 0x00000956
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new POSdbDataSet.ItemdbRow(builder);
			}

			// Token: 0x060000D0 RID: 208 RVA: 0x0000275E File Offset: 0x0000095E
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(POSdbDataSet.ItemdbRow);
			}

			// Token: 0x060000D1 RID: 209 RVA: 0x0000276A File Offset: 0x0000096A
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.ItemdbRowChanged != null)
				{
					this.ItemdbRowChanged(this, new POSdbDataSet.ItemdbRowChangeEvent((POSdbDataSet.ItemdbRow)e.Row, e.Action));
				}
			}

			// Token: 0x060000D2 RID: 210 RVA: 0x0000279D File Offset: 0x0000099D
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.ItemdbRowChanging != null)
				{
					this.ItemdbRowChanging(this, new POSdbDataSet.ItemdbRowChangeEvent((POSdbDataSet.ItemdbRow)e.Row, e.Action));
				}
			}

			// Token: 0x060000D3 RID: 211 RVA: 0x000027D0 File Offset: 0x000009D0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.ItemdbRowDeleted != null)
				{
					this.ItemdbRowDeleted(this, new POSdbDataSet.ItemdbRowChangeEvent((POSdbDataSet.ItemdbRow)e.Row, e.Action));
				}
			}

			// Token: 0x060000D4 RID: 212 RVA: 0x00002803 File Offset: 0x00000A03
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.ItemdbRowDeleting != null)
				{
					this.ItemdbRowDeleting(this, new POSdbDataSet.ItemdbRowChangeEvent((POSdbDataSet.ItemdbRow)e.Row, e.Action));
				}
			}

			// Token: 0x060000D5 RID: 213 RVA: 0x00002836 File Offset: 0x00000A36
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			public void RemoveItemdbRow(POSdbDataSet.ItemdbRow row)
			{
				base.Rows.Remove(row);
			}

			// Token: 0x060000D6 RID: 214 RVA: 0x0000A418 File Offset: 0x00008618
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				POSdbDataSet posdbDataSet = new POSdbDataSet();
				XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
				xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
				xmlSchemaAny.MinOccurs = 0m;
				xmlSchemaAny.MaxOccurs = decimal.MaxValue;
				xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
				xmlSchemaSequence.Items.Add(xmlSchemaAny);
				XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
				xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
				xmlSchemaAny2.MinOccurs = 1m;
				xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
				xmlSchemaSequence.Items.Add(xmlSchemaAny2);
				XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
				xmlSchemaAttribute.Name = "namespace";
				xmlSchemaAttribute.FixedValue = posdbDataSet.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "ItemdbDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = posdbDataSet.GetSchemaSerializable();
				if (xs.Contains(schemaSerializable.TargetNamespace))
				{
					MemoryStream memoryStream = new MemoryStream();
					MemoryStream memoryStream2 = new MemoryStream();
					try
					{
						schemaSerializable.Write(memoryStream);
						foreach (object obj in xs.Schemas(schemaSerializable.TargetNamespace))
						{
							XmlSchema xmlSchema = (XmlSchema)obj;
							memoryStream2.SetLength(0L);
							xmlSchema.Write(memoryStream2);
							if (memoryStream.Length == memoryStream2.Length)
							{
								memoryStream.Position = 0L;
								memoryStream2.Position = 0L;
								while (memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte())
								{
								}
								if (memoryStream.Position == memoryStream.Length)
								{
									return xmlSchemaComplexType;
								}
							}
						}
					}
					finally
					{
						if (memoryStream != null)
						{
							memoryStream.Close();
						}
						if (memoryStream2 != null)
						{
							memoryStream2.Close();
						}
					}
				}
				xs.Add(schemaSerializable);
				return xmlSchemaComplexType;
			}

			// Token: 0x04000093 RID: 147
			private DataColumn columnItem_code;

			// Token: 0x04000094 RID: 148
			private DataColumn columnItem_name;

			// Token: 0x04000095 RID: 149
			private DataColumn columnItem_price;
		}

		// Token: 0x02000012 RID: 18
		public class ItemdbRow : DataRow
		{
			// Token: 0x060000D7 RID: 215 RVA: 0x00002844 File Offset: 0x00000A44
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			internal ItemdbRow(DataRowBuilder rb) : base(rb)
			{
				this.tableItemdb = (POSdbDataSet.ItemdbDataTable)base.Table;
			}

			// Token: 0x17000026 RID: 38
			// (get) Token: 0x060000D8 RID: 216 RVA: 0x0000285E File Offset: 0x00000A5E
			// (set) Token: 0x060000D9 RID: 217 RVA: 0x00002876 File Offset: 0x00000A76
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			public int Item_code
			{
				get
				{
					return (int)base[this.tableItemdb.Item_codeColumn];
				}
				set
				{
					base[this.tableItemdb.Item_codeColumn] = value;
				}
			}

			// Token: 0x17000027 RID: 39
			// (get) Token: 0x060000DA RID: 218 RVA: 0x0000288F File Offset: 0x00000A8F
			// (set) Token: 0x060000DB RID: 219 RVA: 0x000028A7 File Offset: 0x00000AA7
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			public string Item_name
			{
				get
				{
					return (string)base[this.tableItemdb.Item_nameColumn];
				}
				set
				{
					base[this.tableItemdb.Item_nameColumn] = value;
				}
			}

			// Token: 0x17000028 RID: 40
			// (get) Token: 0x060000DC RID: 220 RVA: 0x000028BB File Offset: 0x00000ABB
			// (set) Token: 0x060000DD RID: 221 RVA: 0x000028D3 File Offset: 0x00000AD3
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			public decimal Item_price
			{
				get
				{
					return (decimal)base[this.tableItemdb.Item_priceColumn];
				}
				set
				{
					base[this.tableItemdb.Item_priceColumn] = value;
				}
			}

			// Token: 0x0400009A RID: 154
			private POSdbDataSet.ItemdbDataTable tableItemdb;
		}

		// Token: 0x02000013 RID: 19
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public class ItemdbRowChangeEvent : EventArgs
		{
			// Token: 0x060000DE RID: 222 RVA: 0x000028EC File Offset: 0x00000AEC
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			public ItemdbRowChangeEvent(POSdbDataSet.ItemdbRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}

			// Token: 0x17000029 RID: 41
			// (get) Token: 0x060000DF RID: 223 RVA: 0x00002902 File Offset: 0x00000B02
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			public POSdbDataSet.ItemdbRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			// Token: 0x1700002A RID: 42
			// (get) Token: 0x060000E0 RID: 224 RVA: 0x0000290A File Offset: 0x00000B0A
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			// Token: 0x0400009B RID: 155
			private POSdbDataSet.ItemdbRow eventRow;

			// Token: 0x0400009C RID: 156
			private DataRowAction eventAction;
		}
	}
}
