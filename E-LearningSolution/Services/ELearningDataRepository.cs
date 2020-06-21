using E_LearningSolution.Data;
using E_LearningSolution.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_LearningSolution.Services
{
    public class ELearningDataRepository : IELearning
    {
        private readonly DataContext _context;

        public ELearningDataRepository(DataContext dataContext)
        {
            _context = dataContext;
        }

        public async Task<ELearningModel> Add(ELearningModel eLearningModel)
        {
            _context.ELearningTable.Add(eLearningModel);
            await _context.SaveChangesAsync();
            return eLearningModel;
        }

        public async Task<ELearningModel> Delete(long Id)
        {
            ELearningModel eLearningModel = _context.ELearningTable.Find(Id);
            if (eLearningModel != null)
            {
                _context.ELearningTable.Remove(eLearningModel);
                await _context.SaveChangesAsync();

            }
            return eLearningModel;
        }

        public async Task<ELearningModel> Get(long Id)
        {
            ELearningModel eLearningModel = _context.ELearningTable.Find(Id);

            await _context.SaveChangesAsync();
            return eLearningModel;


        }

        public IEnumerable<ELearningModel> GetAll()
        {
            return _context.ELearningTable;
        }

        public async Task<ELearningModel> Update(ELearningModel eLearningModel)
        {
            _context.ELearningTable.Update(eLearningModel);
            await _context.SaveChangesAsync();

            return eLearningModel;
        }
    }
}
