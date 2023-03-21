using Microsoft.VisualStudio.TestTools.UnitTesting;
using NyRestOPGWYR.Models;
using NyRestOPGWYR.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NyRestOPGWYR.Repository.Tests
{
    [TestClass()]
    public class RecordRepositoryTests
    {
        [TestMethod()]
        public void RecordRepositoryTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetAllTest()
        {
            RecordRepository repository = new RecordRepository();
            List<Record> records = repository.GetAll("Hey", "title");
            Assert.IsNotNull(records);
            Assert.IsTrue(records.Count() > 0);
        }

        [TestMethod()]
        public void GetByIdTest()
        {
            RecordRepository repository = new RecordRepository();
            Record record = repository.GetById(1);
            Assert.AreEqual(record.Id, 1);
            Assert.AreEqual(record.Title, "Hey Baby");
            Assert.AreEqual(record.Duration, 4);
            Assert.AreEqual(record.PublicationYear, 2023);
            Assert.AreEqual(record.Artist, "Wame");
        }

        [TestMethod()]
        public void AddTest()
        {
            RecordRepository recordRepository = new RecordRepository();
            Record record = new Record();
            recordRepository.Add(record);
            
        }

        [TestMethod()]
        public void DeleteTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void UpdateTest()
        {
            Assert.Fail();
        }
    }
}