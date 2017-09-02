using DataGround.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataGround.Core.Interfaces
{
    public interface ITrainerAsync<I,M>
    {
        Task<M> TrainAsync(I inputs);
        void Cancel();
    }
}
