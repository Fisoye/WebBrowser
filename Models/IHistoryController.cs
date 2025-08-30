using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest.Models
{
    public interface IHistoryController
    {
        List<HistoryModel> GetHistory(string filePath);
        HistoryModel? SearchHistory(string filePath, int id);
        void ClearHistory(string filePath);
    }
}
