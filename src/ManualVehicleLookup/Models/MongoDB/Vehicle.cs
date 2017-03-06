using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ManualVehicleLookup.Models
{
    public class Vehicle
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public int ABICode { get; set; }
        public string ProductClass { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string Trim { get; set; }
        public string FullDescription { get; set; }
        public string EngineCapacity { get; set; }
        public string EngineSize { get; set; }
        public string StartYear { get; set; }
        public string EndYear { get; set; }
        public string NumberOfDoors { get; set; }
        public string BodyShape { get; set; }
        public string FuelType { get; set; }
        public string Transmission { get; set; }
        public string LiabilityCategory { get; set; }
        public string LCVBody { get; set; }
        public string GrossWeight { get; set; }
        public string MaxValue { get; set; }
        public string SecurityDeviceCategory { get; set; }
        public string GreyImport { get; set; }
        public string LiabilitySubCategory { get; set; }
        public string Status { get; set; }
        public string EffectiveDate { get; set; }
        public string BodyStyle { get; set; }
        public string EngineDescription { get; set; }
        public string ShortDescription { get; set; }
        public string SequenceNumber { get; set; }
        public BsonDocument Payload { get; set; }
    }
}