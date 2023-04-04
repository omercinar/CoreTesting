namespace CoreTesting
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }

    public class requestmodel
    {
        public string _searchKey;
        public string SearchKey
        {
            get
            {
                //if (!string.IsNullOrEmpty(_searchKey))
                //    _searchKey = _searchKey.ToLower().Trim();
                return _searchKey;
            }

            set
            {
                _searchKey = value;
            }
        }

        public bool IsActive { get; set; }

        public bool Global { get; set; }

        public string MenuCode { get; set; }

        public bool CollarControl { get; set; }

        public int? CollarType { get; set; }

        public bool? IncludeCompanyStartDateGreaterThanTodayDate { get; set; }

        public string ExceptEmployeeStatus { get; set; }
        public bool BypassPopulationPermission { get; set; } = false;
    }
}