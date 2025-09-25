using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Collections.Generic;

public class ICD10Service
{
    private readonly HttpClient _httpClient;

    public ICD10Service(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<(List<ICD10Code> Codes, string? ErrorMessage)> GetICD10CodesAsync(string query)
    {
        try
        {
            // Replace with your actual ICD10 API endpoint
            var url = $"https://icd10api.com/?q={query}";
            var codes = await _httpClient.GetFromJsonAsync<List<ICD10Code>>(url);

            if (codes == null || codes.Count == 0)
            {
                return (new List<ICD10Code>(), "No results found.");
            }

            return (codes, null);
        }
        catch (HttpRequestException ex)
        {
            // Handle network-related errors
            return (new List<ICD10Code>(), "Network error occurred. Please try again.");
        }
        catch (Exception ex)
        {
            // Handle other unexpected errors
            return (new List<ICD10Code>(), "An unexpected error occurred. Please try again.");
        }
    }
}