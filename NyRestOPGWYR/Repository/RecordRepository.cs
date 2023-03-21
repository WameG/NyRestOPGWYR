using NyRestOPGWYR.Models;
using System.Runtime.CompilerServices;

namespace NyRestOPGWYR.Repository
{
    public class RecordRepository
    {
        private int _nextId;
        private List<Record> _records;

        public RecordRepository()
        {
            _nextId = 1;
            _records = new List<Record>()
            {
                new Record() { Id = _nextId++, Artist = "Wame", Duration = 4, PublicationYear = 2023, Title = "Hey baby" },
                new Record() { Id = _nextId++, Artist = "Yusaf", Duration = 4, PublicationYear = 2022, Title = "Hey johnsi" },
                new Record() { Id = _nextId++, Artist = "Renas", Duration = 3, PublicationYear = 2023, Title = "Hey Jones" },
                new Record() { Id = _nextId++, Artist = "Gargamel", Duration = 5, PublicationYear = 2021, Title = "Hey smølf" },
            };
        }
    }
}
