using Kreta.Shared.Dtos;
using Kreta.Shared.Extensions;
using Kreta.Shared.Models;
using Kreta.Shared.Models.SchoolCitizens;
using Kreta.Shared.Responses;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Net;
using System.Net.Http.Json;

namespace Kreta.HttpService.Service
{
    public class AddressService : IAddressService
    {
        private readonly HttpClient? _httpClient;

        public AddressService()
        {
            _httpClient = new HttpClient();
        }

        public AddressService(IHttpClientFactory? httpClientFactory)
        {
            if (httpClientFactory is not null)
            {
                _httpClient = httpClientFactory.CreateClient("KretaApi");
            }
        }

        public async Task<List<Address>> SelectAllAddressAsync()
        {
            if (_httpClient is not null)
            {
                try
                {
                    List<AddressDto>? resultDto = await _httpClient.GetFromJsonAsync<List<AddressDto>>("api/Address");
                    if (resultDto is not null)
                    {
                        List<Address> result = resultDto.Select(addressDto => addressDto.ToModel()).ToList();
                        return result;
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }
            return new List<Address>();
        }

        public async Task<ControllerResponse> UpdateAsync(Address address)
        {
            ControllerResponse defaultResponse = new();
            if (_httpClient is not null)
            {
                try
                {
                    AddressDto addressDto = address.ToDto();
                    HttpResponseMessage httpResponse = await _httpClient.PutAsJsonAsync("api/Student", addressDto);
                    if (httpResponse.StatusCode == HttpStatusCode.BadRequest)
                    {
                        string content = await httpResponse.Content.ReadAsStringAsync();
                        ControllerResponse? response = JsonConvert.DeserializeObject<ControllerResponse>(content);
                        if (response is null)
                        {
                            defaultResponse.ClearAndAddError("A módosítás http kérés hibát okozott!");
                        }
                        else return response;
                    }
                    else if (!httpResponse.IsSuccessStatusCode)
                    {
                        httpResponse.EnsureSuccessStatusCode();
                    }
                    else
                    {
                        return defaultResponse;
                    }
                }

                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }
            defaultResponse.ClearAndAddError("Az adatok frissítés nem lehetséges!");
            return defaultResponse;
        }


        public async Task<ControllerResponse> DeleteAsync(Guid id)
        {
            ControllerResponse defaultResponse = new();
            if (_httpClient is not null)
            {
                try
                {
                    HttpResponseMessage httpResponse = await _httpClient.DeleteAsync($"api/Student/{id}");
                    if (httpResponse.StatusCode == HttpStatusCode.BadRequest)
                    {
                        string content = await httpResponse.Content.ReadAsStringAsync();
                        ControllerResponse? response = JsonConvert.DeserializeObject<ControllerResponse>(content);
                        if (response is null)
                        {
                            defaultResponse.ClearAndAddError("A törlés http kérés hibát okozott!");
                        }
                        else return response;
                    }
                    else if (!httpResponse.IsSuccessStatusCode)
                    {
                        httpResponse.EnsureSuccessStatusCode();
                    }
                    else
                    {
                        return defaultResponse;
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }
            defaultResponse.ClearAndAddError("Az adatok törlése nem lehetséges!");
            return defaultResponse;
        }

        public async Task<ControllerResponse> InsertAsync(Address address)
        {
            ControllerResponse defaultResponse = new();
            if (_httpClient is not null)
            {
                try
                {
                    AddressDto addressDto = address.ToDto();
                    HttpResponseMessage httpResponse = await _httpClient.PostAsJsonAsync("api/Student", addressDto);
                    if (httpResponse.StatusCode == HttpStatusCode.BadRequest)
                    {
                        string content = await httpResponse.Content.ReadAsStringAsync();
                        ControllerResponse? response = JsonConvert.DeserializeObject<ControllerResponse>(content);
                        if (response is null)
                        {
                            defaultResponse.ClearAndAddError("A mentés http kérés hibát okozott!");
                        }
                        else return response;
                    }
                    else if (!httpResponse.IsSuccessStatusCode)
                    {
                        httpResponse.EnsureSuccessStatusCode();
                    }
                    else
                    {
                        return defaultResponse;
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }
            defaultResponse.ClearAndAddError("Az adatok mentése nem lehetséges!");
            return defaultResponse;
        }    

       
    }
}
