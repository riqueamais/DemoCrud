using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace DAL
{
    public class Repositorio
    {

        private IMongoCollection<Agenda> _agenda;
        public List<Agenda> ListaAgenda
        {
            get
            {
                var filter = Builders<Agenda>.Filter.Empty;
                return _agenda.Find<Agenda>(filter).ToList<Agenda>();
            }
        }
        public Repositorio()
        {
            var MongoClient = new MongoClient("mongodb+srv://henrique216914:Fdchenry101@cluster0.mjh74e2.mongodb.net/?retryWrites=true&w=majority");
            var mongoDatabase = MongoClient.GetDatabase("AppDeskTop");
            _agenda = mongoDatabase.GetCollection<Agenda>("Agenda");
        }
    }
}
