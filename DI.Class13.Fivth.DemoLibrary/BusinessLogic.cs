using DI.Class13.Fivth.DemoLibrarySecond.Utilities;
using System;

namespace DI.Class13.Fivth.DemoLibrarySecond
{
    public class BusinessLogic : IBusinessLogic
    {
        private ILogger _logger;
        private IDataAccess _dataAccess;

        public BusinessLogic(ILogger logger, IDataAccess dataAccess)
        {
            _logger = logger;
            _dataAccess = dataAccess;
        }

        public void ProcessData()
        {
            _logger.Log("Staring the processing of the data...");
            _logger.Log("Processing the data ");
            _dataAccess.LoadData();
            _dataAccess.SaveData("Processed Info : ");
            _logger.Log("Finished the processing data");
        }
    }
}
