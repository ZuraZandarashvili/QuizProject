using Quiz.BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.BL.Services
{
    public interface IRecordService
    {
        List<RecordModel> GetRecords();
        RecordModel SaveRecord(RecordModel record);
    }
}
