// Code generated by a template
using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using TabularEditor.PropertyGridUI;
using TabularEditor.UndoFramework;
using TOM = Microsoft.AnalysisServices.Tabular;

namespace TabularEditor.TOMWrapper
{
  
    /// <summary>
	/// Base class declaration for Measure
	/// </summary>
	[TypeConverter(typeof(DynamicPropertyConverter))]
	public partial class Measure: TabularNamedObject, IDetailObject, IHideableObject, IErrorMessageObject, ITabularTableObject, IDescriptionObject, IExpressionObject, IAnnotationObject, ITranslatableObject, IClonableObject
	{
	    protected internal new TOM.Measure MetadataObject { get { return base.MetadataObject as TOM.Measure; } internal set { base.MetadataObject = value; } }

		public string GetAnnotation(string name) {
		    return MetadataObject.Annotations.Find(name)?.Value;
		}
		public void SetAnnotation(string name, string value, bool undoable = true) {
			if(MetadataObject.Annotations.Contains(name)) {
				MetadataObject.Annotations[name].Value = value;
			} else {
				MetadataObject.Annotations.Add(new TOM.Annotation{ Name = name, Value = value });
			}
			if (undoable) Handler.UndoManager.Add(new UndoAnnotationAction(this, name, value));
		}
		        /// <summary>
        /// Gets or sets the Description of the Measure.
        /// </summary>
		[DisplayName("Description")]
		[Category("Basic"),IntelliSense("The Description of this Measure.")]
		public string Description {
			get {
			    return MetadataObject.Description;
			}
			set {
				var oldValue = Description;
				if (oldValue == value) return;
				bool undoable = true;
				bool cancel = false;
				OnPropertyChanging("Description", value, ref undoable, ref cancel);
				if (cancel) return;
				MetadataObject.Description = value;
				if(undoable) Handler.UndoManager.Add(new UndoPropertyChangedAction(this, "Description", oldValue, value));
				OnPropertyChanged("Description", oldValue, value);
			}
		}
		private bool ShouldSerializeDescription() { return false; }
        /// <summary>
        /// Gets or sets the DataType of the Measure.
        /// </summary>
		[DisplayName("Data Type")]
		[Category("Metadata"),IntelliSense("The Data Type of this Measure.")]
		public TOM.DataType DataType {
			get {
			    return MetadataObject.DataType;
			}
			
		}
		private bool ShouldSerializeDataType() { return false; }
        /// <summary>
        /// Gets or sets the Expression of the Measure.
        /// </summary>
		[DisplayName("Expression")]
		[Category("Options"),IntelliSense("The Expression of this Measure.")][Editor(typeof(System.ComponentModel.Design.MultilineStringEditor), typeof(System.Drawing.Design.UITypeEditor))]
		public string Expression {
			get {
			    return MetadataObject.Expression;
			}
			set {
				var oldValue = Expression;
				if (oldValue == value) return;
				bool undoable = true;
				bool cancel = false;
				OnPropertyChanging("Expression", value, ref undoable, ref cancel);
				if (cancel) return;
				MetadataObject.Expression = value;
				if(undoable) Handler.UndoManager.Add(new UndoPropertyChangedAction(this, "Expression", oldValue, value));
				OnPropertyChanged("Expression", oldValue, value);
			}
		}
		private bool ShouldSerializeExpression() { return false; }
        /// <summary>
        /// Gets or sets the FormatString of the Measure.
        /// </summary>
		[DisplayName("Format String")]
		[Category("Options"),IntelliSense("The Format String of this Measure.")]
		public string FormatString {
			get {
			    return MetadataObject.FormatString;
			}
			set {
				var oldValue = FormatString;
				if (oldValue == value) return;
				bool undoable = true;
				bool cancel = false;
				OnPropertyChanging("FormatString", value, ref undoable, ref cancel);
				if (cancel) return;
				MetadataObject.FormatString = value;
				if(undoable) Handler.UndoManager.Add(new UndoPropertyChangedAction(this, "FormatString", oldValue, value));
				OnPropertyChanged("FormatString", oldValue, value);
			}
		}
		private bool ShouldSerializeFormatString() { return false; }
        /// <summary>
        /// Gets or sets the IsHidden of the Measure.
        /// </summary>
		[DisplayName("Hidden")]
		[Category("Basic"),IntelliSense("The Hidden of this Measure.")]
		public bool IsHidden {
			get {
			    return MetadataObject.IsHidden;
			}
			set {
				var oldValue = IsHidden;
				if (oldValue == value) return;
				bool undoable = true;
				bool cancel = false;
				OnPropertyChanging("IsHidden", value, ref undoable, ref cancel);
				if (cancel) return;
				MetadataObject.IsHidden = value;
				if(undoable) Handler.UndoManager.Add(new UndoPropertyChangedAction(this, "IsHidden", oldValue, value));
				OnPropertyChanged("IsHidden", oldValue, value);
				Handler.UpdateObject(this);
			}
		}
		private bool ShouldSerializeIsHidden() { return false; }
        /// <summary>
        /// Gets or sets the State of the Measure.
        /// </summary>
		[DisplayName("State")]
		[Category("Metadata"),IntelliSense("The State of this Measure.")]
		public TOM.ObjectState State {
			get {
			    return MetadataObject.State;
			}
			
		}
		private bool ShouldSerializeState() { return false; }
        /// <summary>
        /// Gets or sets the IsSimpleMeasure of the Measure.
        /// </summary>
		[DisplayName("Simple Measure")]
		[Category("Other"),IntelliSense("The Simple Measure of this Measure.")]
		public bool IsSimpleMeasure {
			get {
			    return MetadataObject.IsSimpleMeasure;
			}
			set {
				var oldValue = IsSimpleMeasure;
				if (oldValue == value) return;
				bool undoable = true;
				bool cancel = false;
				OnPropertyChanging("IsSimpleMeasure", value, ref undoable, ref cancel);
				if (cancel) return;
				MetadataObject.IsSimpleMeasure = value;
				if(undoable) Handler.UndoManager.Add(new UndoPropertyChangedAction(this, "IsSimpleMeasure", oldValue, value));
				OnPropertyChanged("IsSimpleMeasure", oldValue, value);
			}
		}
		private bool ShouldSerializeIsSimpleMeasure() { return false; }
        /// <summary>
        /// Gets or sets the ErrorMessage of the Measure.
        /// </summary>
		[DisplayName("Error Message")]
		[Category("Metadata"),IntelliSense("The Error Message of this Measure.")]
		public string ErrorMessage {
			get {
			    return MetadataObject.ErrorMessage;
			}
			
		}
		private bool ShouldSerializeErrorMessage() { return false; }
        /// <summary>
        /// Gets or sets the DisplayFolder of the Measure.
        /// </summary>
		[DisplayName("Display Folder")]
		[Category("Basic"),IntelliSense("The Display Folder of this Measure.")][Editor(typeof(CustomDialogEditor), typeof(System.Drawing.Design.UITypeEditor))]
		public string DisplayFolder {
			get {
			    return MetadataObject.DisplayFolder;
			}
			set {
				var oldValue = DisplayFolder;
				if (oldValue == value) return;
				bool undoable = true;
				bool cancel = false;
				OnPropertyChanging("DisplayFolder", value, ref undoable, ref cancel);
				if (cancel) return;
				MetadataObject.DisplayFolder = value;
				if(undoable) Handler.UndoManager.Add(new UndoPropertyChangedAction(this, "DisplayFolder", oldValue, value));
				OnPropertyChanged("DisplayFolder", oldValue, value);
				Handler.UpdateFolders(Table);
			}
		}
		private bool ShouldSerializeDisplayFolder() { return false; }
        /// <summary>
        /// Collection of localized Display Folders for this Measure.
        /// </summary>
        [Browsable(true),DisplayName("Display Folders"),Category("Translations and Perspectives")]
	    public TranslationIndexer TranslatedDisplayFolders { private set; get; }
		[Browsable(false)]
		public Table Table
		{ 
			get 
			{ 
				TabularObject t = null;
				if(MetadataObject == null || MetadataObject.Table == null) return null;
				if(!Handler.WrapperLookup.TryGetValue(MetadataObject.Table, out t)) {
				    t = Model.Tables[MetadataObject.Table.Name];
				}
				return t as Table;
			} 
		}
        /// <summary>
        /// Gets or sets the KPI of the Measure.
        /// </summary>
		[DisplayName("KPI")]
		[Category("Other"),IntelliSense("The KPI of this Measure.")]
		public KPI KPI {
			get {
				if (MetadataObject.KPI == null) return null;
			    return Handler.WrapperLookup[MetadataObject.KPI] as KPI;
            }
			set {
				var oldValue = KPI;
				if (oldValue?.MetadataObject == value?.MetadataObject) return;
				bool undoable = true;
				bool cancel = false;
				OnPropertyChanging("KPI", value, ref undoable, ref cancel);
				if (cancel) return;
				MetadataObject.KPI = value?.MetadataObject;
				if(undoable) Handler.UndoManager.Add(new UndoPropertyChangedAction(this, "KPI", oldValue, value));
				OnPropertyChanged("KPI", oldValue, value);
			}
		}
		private bool ShouldSerializeKPI() { return false; }

        /// <summary>
        /// Collection of localized descriptions for this Measure.
        /// </summary>
        [Browsable(true),DisplayName("Descriptions"),Category("Translations and Perspectives")]
	    public TranslationIndexer TranslatedDescriptions { private set; get; }
        /// <summary>
        /// Collection of localized names for this Measure.
        /// </summary>
        [Browsable(true),DisplayName("Names"),Category("Translations and Perspectives")]
	    public TranslationIndexer TranslatedNames { private set; get; }



		/// <summary>
		/// Creates a new Measure and adds it to the parent Table.
		/// </summary>
		public Measure(Table parent) : this(new TOM.Measure()) {
			MetadataObject.Name = parent.MetadataObject.Measures.GetNewName("New Measure");
			parent.Measures.Add(this);
		}


		public Measure Clone(string newName = null, bool includeTranslations = true) {
		    Handler.BeginUpdate("Clone Measure");

				var tom = MetadataObject.Clone() as TOM.Measure;
				tom.Name = Parent.Measures.MetadataObjectCollection.GetNewName(string.IsNullOrEmpty(newName) ? tom.Name + " copy" : newName);
				var obj = new Measure(tom);

            Handler.EndUpdate();

            return obj;
		}

		TabularNamedObject IClonableObject.Clone(string newName, bool includeTranslations) {
			
			return Clone(newName, includeTranslations);
		}

	
        internal override void RenewMetadataObject()
        {
            var tom = new TOM.Measure();
            Handler.WrapperLookup.Remove(MetadataObject);
            MetadataObject.CopyTo(tom);
            MetadataObject = tom;
            Handler.WrapperLookup.Add(MetadataObject, this);
        }


		public Table Parent { 
			get {
				return Handler.WrapperLookup[MetadataObject.Parent] as Table;
			}
		}
		
		/// <summary>
		/// Creates a Measure object representing an existing TOM Measure.
		/// </summary>
		internal Measure(TOM.Measure metadataObject) : base(metadataObject)
		{
			TranslatedNames = new TranslationIndexer(this, TOM.TranslatedProperty.Caption);
			TranslatedDescriptions = new TranslationIndexer(this, TOM.TranslatedProperty.Description);
			TranslatedDisplayFolders = new TranslationIndexer(this, TOM.TranslatedProperty.DisplayFolder);
			
		}	
    }

	/// <summary>
	/// Collection class for Measure. Provides convenient properties for setting a property on multiple objects at once.
	/// </summary>
	public partial class MeasureCollection: TabularObjectCollection<Measure, TOM.Measure, TOM.Table>
	{
		public Table Parent { get; private set; }

		public MeasureCollection(string collectionName, TOM.MeasureCollection metadataObjectCollection, Table parent) : base(collectionName, metadataObjectCollection)
		{
			Parent = parent;

			// Construct child objects (they are automatically added to the Handler's WrapperLookup dictionary):
			foreach(var obj in MetadataObjectCollection) {
				new Measure(obj) { Collection = this };
			}
		}

		[Description("Sets the Description property of all objects in the collection at once.")]
		public string Description {
			set {
				if(Handler == null) return;
				Handler.UndoManager.BeginBatch(UndoPropertyChangedAction.GetActionNameFromProperty("Description"));
				this.ToList().ForEach(item => { item.Description = value; });
				Handler.UndoManager.EndBatch();
			}
		}
		[Description("Sets the Expression property of all objects in the collection at once.")]
		public string Expression {
			set {
				if(Handler == null) return;
				Handler.UndoManager.BeginBatch(UndoPropertyChangedAction.GetActionNameFromProperty("Expression"));
				this.ToList().ForEach(item => { item.Expression = value; });
				Handler.UndoManager.EndBatch();
			}
		}
		[Description("Sets the FormatString property of all objects in the collection at once.")]
		public string FormatString {
			set {
				if(Handler == null) return;
				Handler.UndoManager.BeginBatch(UndoPropertyChangedAction.GetActionNameFromProperty("FormatString"));
				this.ToList().ForEach(item => { item.FormatString = value; });
				Handler.UndoManager.EndBatch();
			}
		}
		[Description("Sets the IsHidden property of all objects in the collection at once.")]
		public bool IsHidden {
			set {
				if(Handler == null) return;
				Handler.UndoManager.BeginBatch(UndoPropertyChangedAction.GetActionNameFromProperty("IsHidden"));
				this.ToList().ForEach(item => { item.IsHidden = value; });
				Handler.UndoManager.EndBatch();
			}
		}
		[Description("Sets the IsSimpleMeasure property of all objects in the collection at once.")]
		public bool IsSimpleMeasure {
			set {
				if(Handler == null) return;
				Handler.UndoManager.BeginBatch(UndoPropertyChangedAction.GetActionNameFromProperty("IsSimpleMeasure"));
				this.ToList().ForEach(item => { item.IsSimpleMeasure = value; });
				Handler.UndoManager.EndBatch();
			}
		}
		[Description("Sets the DisplayFolder property of all objects in the collection at once.")]
		public string DisplayFolder {
			set {
				if(Handler == null) return;
				Handler.UndoManager.BeginBatch(UndoPropertyChangedAction.GetActionNameFromProperty("DisplayFolder"));
				this.ToList().ForEach(item => { item.DisplayFolder = value; });
				Handler.UndoManager.EndBatch();
			}
		}
		[Description("Sets the KPI property of all objects in the collection at once.")]
		public KPI KPI {
			set {
				if(Handler == null) return;
				Handler.UndoManager.BeginBatch(UndoPropertyChangedAction.GetActionNameFromProperty("KPI"));
				this.ToList().ForEach(item => { item.KPI = value; });
				Handler.UndoManager.EndBatch();
			}
		}

		public override string ToString() {
			return string.Format("({0} {1})", Count, (Count == 1 ? "Measure" : "Measures").ToLower());
		}
	}
}
