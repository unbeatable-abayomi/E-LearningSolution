using ELearningWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ELearningWebApp.ServicesRepo
{
     public interface IELearning
    {
        IEnumerable <ELearningModel> GetELearnings { get; }

        public void AddELearning(ELearningModel eLearningModel);
        ELearningModel Delete(long Id);

        ELearningModel GetELearning(long Id);

        public void EditELearning(ELearningModel eLearningModel);

        IQueryable<ELearningModel> Search(string course);
    }
}
