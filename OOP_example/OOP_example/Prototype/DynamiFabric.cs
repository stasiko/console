using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace OOP_example.Prototype
{
    public static class DynamiFabric
    {
        private static Dictionary<Type, object> _prototypes = new Dictionary<Type, object>();

        public interface IShallowCloneable
        {
            object ShallowClone();
        }

        public interface IDeepCloneable
        {
            object DeepClone();
        }

        public static void AddPrototype(object prototype)
        {
            IDeepCloneable iClone = prototype as IDeepCloneable;

            if (iClone == null)
            {
                throw new ArgumentException("prototype must implement ICloneable");
            }

            _prototypes.Add(prototype.GetType(), prototype);
        }

        public static object CreateObject(Type type)
        {
            object prototype;
            _prototypes.TryGetValue(type, out prototype);

            IDeepCloneable iClone = prototype as IDeepCloneable;

            if (iClone == null)
            {
                throw new ArgumentException("unknown type:" + type.ToString());
                // or return null
            }

            return iClone.DeepClone();
        }

        public static void Implement()
        {
            BoxElement boxPrototype = new BoxElement();
            DynamiFabric.AddPrototype(boxPrototype);

            CircleElement circlePrototype = new CircleElement();
            DynamiFabric.AddPrototype(circlePrototype);

            ConnectorElement connectorPrototype = new ConnectorElement();
            DynamiFabric.AddPrototype(connectorPrototype);

            BoxElement newBox = (BoxElement)DynamiFabric.CreateObject((typeof(BoxElement)));
        }

        [Serializable]
        public class MyClass : IShallowCloneable, IDeepCloneable, ICloneable
        {

            // TODO: Add properties
            // TODO: Add fields
            // TODO: Add methods



            public object Clone()
            {
                return DeepClone();
            }

            public object DeepClone()
            {
                object clone = null;

                //Make deep copy using serialization
                using (MemoryStream tempStream = new MemoryStream())
                {
                    BinaryFormatter binFormatter = new BinaryFormatter(null,new StreamingContext(StreamingContextStates.Clone));

                    binFormatter.Serialize(tempStream,this);
                    tempStream.Seek(0, SeekOrigin.Begin);

                    clone = binFormatter.Deserialize(tempStream);
                }

                return clone;
            }

            public object ShallowClone()
            {
                return MemberwiseClone();
            }
        }

    }
}
