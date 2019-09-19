using MicroRabbit.MVC.Models.DTO;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace MicroRabbit.MVC.Services
{
    public class TransferService : ITransferService
    {
        private readonly HttpClient apiClient;

        public TransferService(HttpClient apiClient)
        {
            this.apiClient = apiClient;
        }

        public async Task Transfer(TransferDTO transfer)
        {
            var uri = "https://localhost:5001/api/banking";
            var transferContent = new StringContent(JsonConvert.SerializeObject(transfer),
                System.Text.Encoding.UTF8, "application/json");
            var response = await apiClient.PostAsync(uri, transferContent);
            response.EnsureSuccessStatusCode();
        }
    }
}
