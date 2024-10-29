using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.VMModel;

namespace BusinessRepository
{
   public interface IRepository
    {
        Status AddLoginDetails(VMLogin vmlogin);
    }
}
