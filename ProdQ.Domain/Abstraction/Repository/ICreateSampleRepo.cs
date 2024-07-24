using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ProdQ.Domain.Abstraction.Repository
{
    public interface ICreateSampleRepo
    {
        //Task <TestModel01> SampleRepo();        
        void GetSampleRepo(int id);
        void AddSampleRepo();
        void UpdateSampleRepo();
        void DeleteSampleRepo();
        
        
    }
}
