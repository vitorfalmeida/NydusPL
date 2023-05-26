using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace NydusPL.Service
{
    public class ReceitaWSService : IReceitaWSService
    {
        private readonly HttpClient _httpClient;

        public ReceitaWSService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<bool> IsValidCnpj(string cnpj)
        {
            try
            {
                // Aqui você pode adicionar a lógica de chamada à API da ReceitaWS para validar o CNPJ
                // Por exemplo, você pode usar o HttpClient para enviar uma solicitação HTTP

                // Suponha que você tenha uma rota 'api/receitaws' para validar o CNPJ
                string requestUrl = "api/receitaws/validarcnpj?cnpj=" + cnpj;

                HttpResponseMessage response = await _httpClient.GetAsync(requestUrl);
                response.EnsureSuccessStatusCode();

                // Aqui você pode analisar a resposta e verificar se o CNPJ é válido
                // Por exemplo, você pode verificar o status de retorno, o conteúdo JSON retornado, etc.

                // Suponha que a resposta seja um objeto JSON contendo uma propriedade 'isValid'
                var responseContent = await response.Content.ReadAsStringAsync();
                var responseObject = JsonConvert.DeserializeObject<dynamic>(responseContent);
                bool isValid = responseObject.isValid;

                return isValid;
            }
            catch (Exception ex)
            {
                // Trate as exceções adequadamente de acordo com a sua lógica de erro
                // Por exemplo, você pode registrar o erro, lançar uma exceção personalizada, etc.
                throw new Exception("Erro ao validar o CNPJ na ReceitaWS.", ex);
            }
        }

        public async Task<bool> ValidarCNPJ(string cnpj)
        {
            // Construa a URL da API ReceitaWS com o CNPJ fornecido
            string url = $"https://www.receitaws.com.br/v1/cnpj/{cnpj}";

            // Faça a chamada HTTP GET para a API ReceitaWS
            HttpResponseMessage response = await _httpClient.GetAsync(url);

            // Verifique se a resposta foi bem-sucedida (código 200)
            if (response.IsSuccessStatusCode)
            {
                // Leia o conteúdo da resposta
                string content = await response.Content.ReadAsStringAsync();

                // Verifique se o CNPJ está ativo
                // A implementação exata dependerá da estrutura do JSON retornado pela API ReceitaWS
                // Neste exemplo, consideraremos que a resposta contém um campo "situacao" que indica o status da empresa
                bool ativo = content.Contains("\"situacao\":\"ATIVA\"");

                return ativo;
            }

            // A resposta não foi bem-sucedida, retorne false
            return false;
        }
    }
}