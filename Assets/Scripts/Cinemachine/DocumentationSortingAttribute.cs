using UnityEngine;

namespace Cinemachine
{
    [Cinemachine.DocumentationSortingAttribute]
    public sealed class DocumentationSortingAttribute : Attribute
    {
        // Fields
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private float <SortOrder>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private Cinemachine.DocumentationSortingAttribute.Level <Category>k__BackingField;
        
        // Properties
        public float SortOrder { get; set; }
        public Cinemachine.DocumentationSortingAttribute.Level Category { get; set; }
        
        // Methods
        public DocumentationSortingAttribute(float sortOrder, Cinemachine.DocumentationSortingAttribute.Level category)
        {
            this.<Category>k__BackingField = category;
            this.<SortOrder>k__BackingField = sortOrder;
        }
        public float get_SortOrder()
        {
            return (float)this.<SortOrder>k__BackingField;
        }
        private void set_SortOrder(float value)
        {
            this.<SortOrder>k__BackingField = value;
        }
        public Cinemachine.DocumentationSortingAttribute.Level get_Category()
        {
            return (Level)this.<Category>k__BackingField;
        }
        private void set_Category(Cinemachine.DocumentationSortingAttribute.Level value)
        {
            this.<Category>k__BackingField = value;
        }
    
    }

}
