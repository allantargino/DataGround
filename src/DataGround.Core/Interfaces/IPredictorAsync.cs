using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataGround.Core.Interfaces
{
    public interface IPredictorAsync<M, I, O>
        where M:class
        where I:IInput
        where O:IOutput
    {
        void Init(M model);
        Task<O> ComputeAsync(I input);
    }
}
