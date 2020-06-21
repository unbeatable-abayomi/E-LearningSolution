using ELearningWebApp.Data;
using ELearningWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ELearningWebApp.ServicesRepo
{
    public class ELearningRepository: IELearning
    {
        public readonly DataContext _dataContext;

        public ELearningRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }



        public IEnumerable<ELearningModel> GetELearnings => _dataContext.ELearningTable.ToList();

        public void AddELearning(ELearningModel eLearningModel)
        {
            _dataContext.ELearningTable.Add(eLearningModel);
            _dataContext.SaveChanges();
        }
        public ELearningModel Delete(long Id)
        {
            ELearningModel eLearningModel = _dataContext.ELearningTable.Find(Id);
            if(eLearningModel != null)
            {
                _dataContext.ELearningTable.Remove(eLearningModel);
                _dataContext.SaveChanges();
            }

            return eLearningModel;
        }

         public ELearningModel GetELearning(long Id)
        {
           return _dataContext.ELearningTable.Find(Id);

        }

        public void EditELearning(ELearningModel eLearningModel)
        {
            _dataContext.Entry(eLearningModel).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _dataContext.SaveChanges();
        }

       public IQueryable<ELearningModel> Search(string course)
        {
            var learning = _dataContext.ELearningTable.Where(c => c.CourseName.Contains(course) || c.CourseCode.Contains(course));

            return learning;      
        }
    }
}
