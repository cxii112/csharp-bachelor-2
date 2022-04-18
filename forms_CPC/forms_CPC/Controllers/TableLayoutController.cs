using System.Collections.Generic;
using forms_CPC.Models;

namespace forms_CPC.Controllers
{
    public class TableLayoutController
    {
        public TableLayoutController(ITableView view)
        {
            _view = view;
        }

        private readonly ITableView _view;
        private readonly double _xStart = 5.3;
        private readonly double _xEnd = 10.3;
        private readonly double _deltaX = 0.25;

        public void AddFunctionData()
        {
            List<FunctionData> data = GenerateFunctionData();
            _view.AddFunctionData(data);
        }

        public List<FunctionData> GenerateFunctionData()
        {
            List<FunctionData> functionData = new List<FunctionData>();
            for (double x = _xStart; x <= _xEnd; x += _deltaX)
            {
                functionData.Add(new FunctionData(x));
            }

            return functionData;
        }
    }
}