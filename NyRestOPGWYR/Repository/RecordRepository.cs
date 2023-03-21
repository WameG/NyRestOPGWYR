using NyRestOPGWYR.Models;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

        public List<Record> GetAll(string title, string sortBy)
        {
            List<Record> musics = new List<Record>(_records);

            if (title != null)
            {
                musics = musics.FindAll(musics => musics.Title != null && musics.Title.StartsWith(title));
            }
            if (sortBy != null)
            {
                switch (sortBy.ToLower())
                {
                    case "title":
                        musics = musics.OrderBy(musics => musics.Title).ToList();
                        break;
                }
            }
            return musics;
        }

        public Record? GetById(int id)
        {
            return _records.Find(musics => musics.Id == id);
        }

        public Record Add(Record newMusic)
        {
            newMusic.Id = _nextId++;
            _records.Add(newMusic);
            return newMusic;
        }

        public Record? Delete(int id)
        {
            Record? music = _records.Find(music1 => music1.Id == id);
            if (music == null) return null;
            _records.Remove(music);
            return music;
        }

        public Record? Update(int id, Record updates)
        {
            Record? music = _records.Find(music1 => music1.Id == id);
            if (music == null) return null;
            music.Title = updates.Title;
            music.Duration = updates.Duration;
            return music;
        }
    }
}
