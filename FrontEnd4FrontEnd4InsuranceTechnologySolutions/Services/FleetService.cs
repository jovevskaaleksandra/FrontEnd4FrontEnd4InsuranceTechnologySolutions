using FrontEnd4FrontEnd4InsuranceTechnologySolutions.Models;

namespace FrontEnd4FrontEnd4InsuranceTechnologySolutions.Services
{
    public class FleetService
    {
        private readonly HttpClient _http;

        public FleetService(HttpClient http)
        {
            _http = http;
        }

        public async Task<FleetResponse?> GetRandomFleetAsync()
        {
            try
            {
                return await _http.GetFromJsonAsync<FleetResponse>("https://esa.instech.no/api/fleets/random");
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR fetching fleet: " + ex.Message);
                return null;
            }
        }
    }
}
