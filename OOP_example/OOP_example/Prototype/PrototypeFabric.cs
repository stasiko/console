using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_example.Prototype
{
    public static class ElementFactory
    {
        private static readonly BoxElement _boxPrototype;
        private static readonly CircleElement _circleProrotype;
        private static readonly ConnectorElement _connectorPrototype;

        static ElementFactory()
        {
            _boxPrototype = new BoxElement();
            _boxPrototype.Title = "New box element.";

            _circleProrotype = new CircleElement();
            _circleProrotype.Title = "New circle element";

            _connectorPrototype = new ConnectorElement();
            _connectorPrototype.Title = "New connector element";

        }

        static BoxElement CreateBox()
        {
            return (BoxElement)_boxPrototype.Clone();
        }

        static CircleElement CreateCircle()
        {
            return (CircleElement)_circleProrotype.Clone();
        }

        static ConnectorElement CreateConnector()
        {
            return (ConnectorElement)_connectorPrototype.Clone();
         }

        static void Implementation()
        {
            BoxElement newBox = CreateBox();
        }



    }
}
