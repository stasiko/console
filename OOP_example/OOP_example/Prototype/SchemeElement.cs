using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_example.Prototype
{
    public abstract class SchemeElement
    {
        public uint Id { get; set; }

        public string Title { get; set; }

        public virtual SchemeElement Clone()
        {
            return (SchemeElement) MemberwiseClone();
        }
    }

    public class BoxElement : SchemeElement { }
    public class CircleElement : SchemeElement { }
    public class ConnectorElement: SchemeElement { }

    public class Operations
    {
        public void InsertCopy(IEnumerable<SchemeElement> selectedElements)
        {
            foreach (var selectedElement in selectedElements)
            {
                SchemeElement newElement = (SchemeElement) selectedElement.Clone();

                // The Id must be unique
                //newElement.Id = this.GetNewId();

                //TODO: Setup the new element

                // Add the element to the scheme
                //this.AddNewElement(newElement);
            }
        }
    }
}
