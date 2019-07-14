using System.Net.Http;

namespace ExemploPJe
{
    class PJeService
    {

        private const string ENDPOINT = "https://wwwh.cnj.jus.br/pjemni-2x/intercomunicacao?wsdl";

        public static void Get(out string result)
        {
            result = string.Empty;

            //// Create an HttpClient instance 
            //HttpClient client = new HttpClient();

            //PJe.consultarProcesso consultar = new PJe.consultarProcesso();
            //consultar.idConsultante = "75293730215";
            //consultar.senhaConsultante = "admin123";
            //consultar.numeroProcesso = "0030244-77.2016.2.00.0000";

            //// Send a request asynchronously continue when complete 
            //client.GetStringAsync(ENDPOINT).ContinueWith(
            //    (requestTask) =>
            //    {
            //        // Get HTTP response from completed task. 
            //        HttpResponseMessage response = requestTask.Result;

            //        // Check that response was successful or throw exception 
            //        response.EnsureSuccessStatusCode();

            //        // Read response asynchronously as JsonValue and write out top facts for each country 
            //        response.Content.ReadAsStringAsync().ContinueWith(
            //            (readTask) =>
            //            {
            //                result = readTask.Status.ToString();
            //            });
            //    });
        }
    }
}