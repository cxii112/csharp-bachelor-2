using System.Collections.Generic;
using forms_CPC.Models;

namespace forms_CPC.Controllers
{
    public interface ITableView
    {
        void AddFunctionData(List<FunctionData> source);
    }
}
