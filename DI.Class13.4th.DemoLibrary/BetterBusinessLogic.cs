using DI.Class13._4th.DemoLibrary.Utilities;
using System;

namespace DI.Class13._4th.DemoLibrary
{
    public class BetterBusinessLogic : IBusinessLogic
    {
        private ILogger _logger;
        private IDataAccess _dataAccess;

        public BetterBusinessLogic(ILogger logger, IDataAccess dataAccess)
        {
            _logger = logger;
            _dataAccess = dataAccess;
        }

        public void ProcessData()
        {
            _logger.Log("Starting the processing of data on BetterBusinessLogic...");
            Console.WriteLine("Processing the data...");
            _dataAccess.LoadData();
            _dataAccess.SaveData("ProcessedInfo ");
            _logger.Log("Finished processing of the data...");
        }
    }
}
