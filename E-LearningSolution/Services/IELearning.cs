using E_LearningSolution.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_LearningSolution.Services
{
    public interface IELearning
    {
        public IEnumerable<ELearningModel> GetAll();
        public Task<ELearningModel> Get(long Id);

        public Task<ELearningModel> Add(ELearningModel eLearningModel );

        public Task<ELearningModel> Update(ELearningModel eLearningModel );
        public Task<ELearningModel> Delete(long Id);
    }
}
