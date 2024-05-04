using System.Text.Json;

namespace otusHomeWorkPrototype.TestClass.Transport
{
    [Serializable]
    public class Ship : Transport
    {
        //Класс корабль

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override object Clone()
        {
            return DeepClone();
        }

        public override Ship DeepClone()
        {
            var serialized = JsonSerializer.Serialize(this);
            var copy = JsonSerializer.Deserialize<Ship>(serialized);

            return copy;
        }

        public override Transport ShallowClone()
        {
            return (Transport)MemberwiseClone();
        }
    }
}
