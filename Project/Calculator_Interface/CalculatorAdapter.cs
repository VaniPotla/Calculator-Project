using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net;
using System.Text;


namespace Calculator_Interface
{
    public class CalculatorAdapter : ICalculatorAdapter
    {
        private string apiUrl = "https://localhost:44314/api/Home/";
        private bool _includeAPIAndDB = false;
        public int Add(int start, int amount)
        {
            if (_includeAPIAndDB)
            {
                // Calling with API and DB
                using (var client = new WebClient())
                {
                    var urlAddress = apiUrl + "Add" + "?start=" + start + "&amount=" + amount;
                    var result = client.DownloadString(urlAddress);
                    return !string.IsNullOrEmpty(result) ? Convert.ToInt32(result) : 0;
                }
            }
            else
            {
                // Calling without API and DB
                return start + amount;
            }
        }

        public int Subtract(int start, int amount)
        {
            if (_includeAPIAndDB)
            {
                // Calling with API and DB
                using (var client = new WebClient())
                {
                    var urlAddress = apiUrl + "Subtract" + "?start=" + start + "&amount=" + amount;
                    var result = client.DownloadString(urlAddress);
                    return !string.IsNullOrEmpty(result) ? Convert.ToInt32(result) : 0;
                }
            }
            else
            {
                // Calling without API and DB
                return start - amount;
            }
        }

        public int Divide(int start, int by)
        {
            if (_includeAPIAndDB)
            {
                // Calling with API and DB
                using (var client = new WebClient())
                {
                    var urlAddress = apiUrl + "Divide" + "?start=" + start + "&by=" + by;
                    var result = client.DownloadString(urlAddress);
                    return !string.IsNullOrEmpty(result) ? Convert.ToInt32(result) : 0;
                }
            }
            else
            {
                // Calling without API and DB
                return start / by;
            }
        }

        public int Multiply(int start, int by)
        {
            if (_includeAPIAndDB)
            {
                // Calling with API and DB
                using (var client = new WebClient())
                {
                    var urlAddress = apiUrl + "Multiply" + "?start=" + start + "&by=" + by;
                    var result = client.DownloadString(urlAddress);
                    return !string.IsNullOrEmpty(result) ? Convert.ToInt32(result) : 0;
                }
            }
            else
            {
                // Calling without API and DB
                return start * by;
            }
        }
    }
}