using System;
using MongoDB.Bson.Serialization.Attributes;

namespace Genealogy.Core
{
    public class Person : ICloneable
    {
        [BsonId]
        public string Id { get; set; }

        public string Name { get; set; }

        public object Clone()
        {
            var copy = this.MemberwiseClone();
            return copy;
        }
    }
}