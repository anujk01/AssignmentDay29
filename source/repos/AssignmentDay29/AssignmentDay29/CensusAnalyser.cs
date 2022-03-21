using System;
using System.Collections.Generic;

namespace IndianStatesCensusAnalyser
{
    public class CensusAnalyser
    {
        public enum Country
        {
            INDIA, US, BRAZIL
        }

        Dictionary<string, CensusDTO> dataMap;

        public Dictionary<string, CensusDTO> LoadCensusData(Country country, string csvFilePath, string dataHeaders)
        {
            dataMap = new CSVAdapterFactory().LoadCsvData(country, csvFilePath, dataHeaders);
            return dataMap;
        }

        internal Dictionary<string, CensusDTO> LoadCensusData(object iNDIA, string indianStateCensusFilePath, string indianStateCensusHeaders)
        {
            throw new NotImplementedException();
        }
    }
}