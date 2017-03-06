using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace ManualVehicleLookup.Models
{
    public class MongoManufacturerRepository : IManufacturerRepository
    {
        MongoClient _client;
        //        MongoServer _server;
        private readonly IMongoDatabase _db = null;

        public MongoManufacturerRepository()
        {
            _client = new MongoClient("mongodb://localhost:27017");
            //            _server = _client.GetServer();
            _db = _client.GetDatabase("AbiData");
        }

//        public async Task<Note> GetNote(string id)
//        {
//            var filter = Builders<Note>.Filter.Eq("Id", id);
//            return await _context.Notes
//                                 .Find(filter)
//                                 .FirstOrDefaultAsync();
//        }
           

        public List<string> GetAllManufacturers()
        {
            var manufacturers = new List<string>();

//            var filter = Builders<Vehicle>.Filter.Eq("Id", id);
//            var mongoCursor = _db.GetCollection<Vehicle>("Vehicle").Find();
//            
//            foreach (var vehicle in mongoCursor.ToList())
//            {
//                if (!manufacturers.Contains(vehicle.Manufacturer.ToLower()))
//                    manufacturers.Add(vehicle.Manufacturer.ToLower());
//            }

            return manufacturers; //TODO: Sort the list
        }

        public List<string> GetAllManufacturers(string productClass)
        {
            var manufacturers = new List<string>();

            var productClassFilter = Builders<Vehicle>.Filter.Eq("ProductClass", productClass.ToUpper());
            IAsyncCursor<Vehicle> results = _db.GetCollection<Vehicle>("Vehicle").FindSync(productClassFilter);

            try
            {
                while (results.MoveNext())
                {
                    using (var enumerator = results.Current.GetEnumerator())
                    {
                        while (enumerator.MoveNext())
                        {
                            if (!manufacturers.Contains(enumerator.Current.Manufacturer.ToLower()))
                                manufacturers.Add(enumerator.Current.Manufacturer.ToLower());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                var message = ex.Message;
            }

            manufacturers.Sort();

            return manufacturers; 
        }

        //
        //        public List<string> GetAllManufacturers(string productClass)
        //        {
        //            var vehicleCollection = _db.GetCollection<Vehicle>("Vehicle");
        //
        //            var query = Query.And.Filter.Eq(x => x.ProductClass, productClass);
        //            var documents = vehicleCollection.Find(query);
        //
        //            var manufacturers = new List<string>();
        //
        //            foreach (var vehicle in documents.ToList())
        //            {
        //                if (!manufacturers.Contains(vehicle.Manufacturer))
        //                    manufacturers.Add(vehicle.Manufacturer.ToLower());
        //            }
        //
        //            return manufacturers; //TODO: Sort the list
        //        }
    }
}