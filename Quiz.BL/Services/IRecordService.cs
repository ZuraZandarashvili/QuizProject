using Quiz.BL.Models;
using System.Collections.Generic;

namespace Quiz.BL.Services
{
    public interface IRecordService
    {
        List<RecordModel> GetRecords();
        RecordModel SaveRecord(RecordModel record);
    }
}
