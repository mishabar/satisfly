using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EliteRoute.Data.Model;
using MongoDB.Driver;
using MongoDB.Driver.Builders;

namespace EliteRoute.Data.Repositories
{
    public class ComplaintRepository : IComplaintRepository
    {
        MongoCollection<Complaint> _collection = null;

        public ComplaintRepository(MongoDatabase db)
        {
            _collection = db.GetCollection<Complaint>("complaints");
        }

        public Complaint Create(Complaint complaint)
        {
            _collection.Save(complaint);
            return complaint;
        }

        public IEnumerable<Complaint> GetAllByEmail(string email)
        {
            return _collection.Find(Query<Complaint>.EQ(c => c.Email, email)).AsEnumerable();
        }

        public Complaint GetByID(string email, long id)
        {
            return _collection.FindOne(Query.And(Query<Complaint>.EQ(c => c.Email, email), Query<Complaint>.EQ(c => c.ID, id)));
        }
    }
}
