using Quiz.BL.Models;
using Quiz.BL.Services;
using System;
using System.Collections.Generic;

namespace Quiz.UI.TestServices
{
    public class RecordService : IRecordService
    {
        List<RecordModel> records = new List<RecordModel>
            {
                new RecordModel
                {
                    PlayerName = "David",
                    Score = 10,
                    Time = DateTime.Now,
                },

                new RecordModel
                {
                    PlayerName = "Levan",
                    Score = 20,
                    Time = DateTime.Now,
                },

                new RecordModel
                {
                    PlayerName = "Misho",
                    Score = 15,
                    Time = DateTime.Now,
                },

                new RecordModel
                {
                    PlayerName = "Giorgi",
                    Score = 17,
                    Time = DateTime.Now,
                },
            };

        public List<RecordModel> GetRecords()
        {
            return records;
        }

        public RecordModel SaveRecord(RecordModel record)
        {
            records.Add(record);
            return record;
        }
    }
}