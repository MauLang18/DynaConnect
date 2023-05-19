using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Xml.Linq;

namespace Dynamics.Controllers
{
    [Route("dynamics")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        //Api para obtener datos por el idtra de manera basica
        [HttpGet]
        [Route("listarId")]
        public async Task<string> IdAsync(string name)
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "incidents";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=new_contenedor,new_bcf,new_confirmacinzarpe,new_destino,new_eta,new_etd1,new_instcliente,new_ingreso,new_ingresoabodegas,new_nombrebuque,new_origen,new_poe,new_pol,new_transporte,title,new_preestado2,modifiedon&$filter=contains(title,'{name}')&$orderby=title asc");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        //Api para obterner datos por el po de manera basica
        [HttpGet]
        [Route("listarPo")]
        public async Task<string> PoAsync(string name)
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "incidents";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=new_contenedor,new_bcf,new_confirmacinzarpe,new_destino,new_eta,new_etd1,new_instcliente,new_ingreso,new_ingresoabodegas,new_nombrebuque,new_origen,new_poe,new_pol,new_transporte,title,new_preestado2,modifiedon&$filter=contains(new_po,'{name}')&$orderby=title asc");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        //Api para obtener datos por el bcf de manera basica
        [HttpGet]
        [Route("listarBcf")]
        public async Task<string> BcfAsync(string name)
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "incidents";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=new_contenedor,new_bcf,new_confirmacinzarpe,new_destino,new_eta,new_etd1,new_instcliente,new_ingreso,new_ingresoabodegas,new_nombrebuque,new_origen,new_poe,new_pol,new_transporte,title,new_preestado2,modifiedon&$filter=contains(new_bcf,'{name}')&$orderby=new_bcf asc");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        //Api para obtener datos por el contenedor de manera basica
        [HttpGet]
        [Route("listarContenedor")]
        public async Task<string> ContenedorAsync(string name)
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "incidents";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=new_contenedor,new_bcf,new_confirmacinzarpe,new_destino,new_eta,new_etd1,new_instcliente,new_ingreso,new_ingresoabodegas,new_nombrebuque,new_origen,new_poe,new_pol,new_transporte,title,new_preestado2,modifiedon&$filter=contains(new_contenedor,'{name}')&$orderby=new_contenedor asc");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        //Api para obtener los datos de los tramites finalizados de un cliente
        [HttpGet]
        [Route("listarClienteF")]
        public async Task<string> ClienteFAsync(string name)
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "incidents";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=new_contenedor,new_factura,new_bcf,new_cantequipo,new_commodity,new_confirmacinzarpe,new_contidadbultos,new_destino,new_eta,new_etd1,modifiedon,new_incoterm,new_origen,new_po,new_poe,new_pol,new_preestado2,new_seal,_new_shipper_value,new_statuscliente,new_tamaoequipo,new_new_facturacompaia,new_transporte,title,new_lugarcolocacion,new_redestino,new_diasdetransito,new_nombrebuque,new_numeroviaje,_customerid_value&$filter=(new_subiralaweb eq true and (_customerid_value eq {name}) and (new_preestado2 eq 100000023 or new_preestado2 eq 100000022 or new_preestado2 eq 100000021 or new_preestado2 eq 100000019 or new_preestado2 eq 100000012 or new_preestado2 eq 100000008 or new_preestado2 eq 100000009 or new_preestado2 eq 100000010 or new_preestado2 eq 100000011))&$orderby=title desc");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        //Api para obtener los datos de los tramites activos de un cliente
        [HttpGet]
        [Route("listarClienteA")]
        public async Task<string> ClienteAAsync(string name)
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "incidents";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=new_contenedor,new_factura,new_bcf,new_cantequipo,new_commodity,new_confirmacinzarpe,new_contidadbultos,new_destino,new_eta,new_etd1,modifiedon,new_incoterm,new_origen,new_po,new_poe,new_pol,new_preestado2,new_seal,_new_shipper_value,new_statuscliente,new_tamaoequipo,new_transporte,new_new_facturacompaia,title,new_lugarcolocacion,new_redestino,new_diasdetransito,new_nombrebuque,new_numeroviaje,_customerid_value&$filter=(new_subiralaweb eq true and (_customerid_value eq {name}) and (new_preestado2 eq 100000000 or new_preestado2 eq 100000016 or new_preestado2 eq 100000001 or new_preestado2 eq 100000017 or new_preestado2 eq 100000002 or new_preestado2 eq 100000003 or new_preestado2 eq 100000004 or new_preestado2 eq 100000005 or new_preestado2 eq 100000006 or new_preestado2 eq 100000018 or new_preestado2 eq 100000007 or new_preestado2 eq 100000024 or new_preestado2 eq 100000025 or new_preestado2 eq 100000026))&$orderby=title desc");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        //Api para obtener el nombre del cliente
        [HttpGet]
        [Route("listarClienteNombre")]
        public async Task<string> ClienteNombreAsync(string name)
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "accounts";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=name&$filter=accountid eq {name}");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        //Api para obtener los datos basicos de los tramites activos de un cliente
        [HttpGet]
        [Route("listarClienteFiltroA")]
        public async Task<string> ClienteFiltroAAsync(string name, string name2)
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "incidents";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=new_factura,new_ingreso,new_contenedor,new_bcf,new_po,new_poe,new_pol,new_preestado2,title,_customerid_value&$filter=(new_subiralaweb eq true and (_customerid_value eq {name}) and (new_preestado2 eq 100000000 or new_preestado2 eq 100000016 or new_preestado2 eq 100000001 or new_preestado2 eq 100000017 or new_preestado2 eq 100000002 or new_preestado2 eq 100000003 or new_preestado2 eq 100000004 or new_preestado2 eq 100000005 or new_preestado2 eq 100000006 or new_preestado2 eq 100000018 or new_preestado2 eq 100000007 or new_preestado2 eq 100000024 or new_preestado2 eq 100000025 or new_preestado2 eq 100000026 or new_preestado2 eq 100000015))&$orderby=title desc");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        //Api para obtener los datos basicos de los tramites finalizados de un cliente
        [HttpGet]
        [Route("listarClienteFiltroF")]
        public async Task<string> ClienteFiltroFAsync(string name, string name2)
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "incidents";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=new_factura,new_ingreso,new_contenedor,new_bcf,new_po,new_poe,new_pol,new_preestado2,title,_customerid_value&$filter=(new_subiralaweb eq true and (_customerid_value eq {name}) and (new_preestado2 eq 100000023 or new_preestado2 eq 100000022 or new_preestado2 eq 100000021 or new_preestado2 eq 100000019 or new_preestado2 eq 100000012 or new_preestado2 eq 100000008 or new_preestado2 eq 100000009 or new_preestado2 eq 100000010 or new_preestado2 eq 100000011))&$orderby=title desc");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        //Api para obtener los datos avanzados por idtra
        [HttpGet]
        [Route("listarClienteIdtra")]
        public async Task<string> ClienteIdtraAsync(string name)
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "incidents";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=new_contenedor,new_factura,new_bcf,new_cantequipo,new_commodity,new_confirmacinzarpe,new_contidadbultos,new_destino,new_eta,new_etd1,modifiedon,new_incoterm,new_origen,new_po,new_poe,new_pol,new_preestado2,new_seal,_new_shipper_value,new_statuscliente,new_tamaoequipo,new_transporte,new_ingreso,new_new_facturacompaia,new_ingresoabodegas,new_instcliente,new_nombrebuque,title&$filter=(contains(title,'{name}'))&$orderby=title asc");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        //Api para obtener los datos avanzados por bcf
        [HttpGet]
        [Route("listarClienteBcf")]
        public async Task<string> ClienteBcfAsync(string name)
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "incidents";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=new_contenedor,new_factura,new_bcf,new_cantequipo,new_commodity,new_confirmacinzarpe,new_contidadbultos,new_destino,new_eta,new_etd1,modifiedon,new_incoterm,new_origen,new_po,new_poe,new_pol,new_preestado2,new_seal,_new_shipper_value,new_statuscliente,new_tamaoequipo,new_transporte,new_ingreso,new_new_facturacompaia,new_ingresoabodegas,new_instcliente,new_nombrebuque,title&$filter=(contains(new_bcf,'{name}'))&$orderby=title asc");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        //Api para obtener los datos avanzados por contenedor
        [HttpGet]
        [Route("listarClienteContenedor")]
        public async Task<string> ClienteContenedorAsync(string name)
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "incidents";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=new_contenedor,new_factura,new_bcf,new_cantequipo,new_commodity,new_confirmacinzarpe,new_contidadbultos,new_destino,new_eta,new_etd1,modifiedon,new_incoterm,new_origen,new_po,new_poe,new_pol,new_preestado2,new_seal,_new_shipper_value,new_statuscliente,new_tamaoequipo,new_transporte,new_ingreso,new_new_facturacompaia,new_ingresoabodegas,new_instcliente,new_nombrebuque,title&$filter=(contains(new_contenedor,'{name}'))&$orderby=title asc");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        //Api para obtener los datos avanzados por po
        [HttpGet]
        [Route("listarClientePo")]
        public async Task<string> ClientePoAsync(string name)
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "incidents";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=new_contenedor,new_factura,new_bcf,new_cantequipo,new_commodity,new_confirmacinzarpe,new_contidadbultos,new_destino,new_eta,new_etd1,modifiedon,new_incoterm,new_origen,new_po,new_poe,new_pol,new_preestado2,new_seal,_new_shipper_value,new_statuscliente,new_tamaoequipo,new_transporte,new_ingreso,new_new_facturacompaia,new_ingresoabodegas,new_instcliente,new_nombrebuque,title&$filter=(contains(new_po,'{name}'))&$orderby=title asc");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        //Api para obtener los datos basicos de los tramites activos de un ejecutivo
        [HttpGet]
        [Route("listarEjecutivoFiltroA")]
        public async Task<string> EjecutivoFiltroAAsync(string name)
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "incidents";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=new_contenedor,new_bcf,new_po,new_poe,new_pol,new_preestado2,_customerid_value,title&$filter=(new_producto1 eq {name} and (new_preestado2 eq 100000000 or new_preestado2 eq 100000016 or new_preestado2 eq 100000001 or new_preestado2 eq 100000017 or new_preestado2 eq 100000002 or new_preestado2 eq 100000003 or new_preestado2 eq 100000004 or new_preestado2 eq 100000005 or new_preestado2 eq 100000006 or new_preestado2 eq 100000018 or new_preestado2 eq 100000007, new_preestado2 eq 100000024 or new_preestado2 eq 100000025 or new_preestado2 eq 100000026 or new_preestado2 eq 100000015))&$orderby=title desc");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        //Api para obtener los datos basicos de los tramites finalizados de un ejecutivo
        [HttpGet]
        [Route("listarEjecutivoFiltroF")]
        public async Task<string> EjecutivoFiltroFAsync(string name)
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "incidents";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=new_contenedor,new_bcf,new_po,new_poe,new_pol,new_preestado2,_customerid_value,title&$filter=(new_producto1 eq {name} and (new_preestado2 eq 100000023 or new_preestado2 eq 100000022 or new_preestado2 eq 100000021 or new_preestado2 eq 100000019 or new_preestado2 eq 100000012 or new_preestado2 eq 100000008 or new_preestado2 eq 100000009 or new_preestado2 eq 100000010 or new_preestado2 eq 100000011))&$orderby=title desc");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        //Api para obtener los datos avanzados por idtra
        [HttpGet]
        [Route("listarEjecutivoIdtra")]
        public async Task<string> EjecutivoIdtraAsync(string name, string name2)
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "incidents";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=new_contenedor,new_factura,new_bcf,new_cantequipo,new_commodity,new_confirmacinzarpe,new_contidadbultos,new_destino,new_eta,new_etd1,modifiedon,new_incoterm,new_origen,new_po,new_poe,new_pol,new_preestado2,new_seal,_new_shipper_value,new_statuscliente,new_tamaoequipo,new_transporte,new_ingreso,new_new_facturacompaia,new_ingresoabodegas,new_instcliente,new_nombrebuque,_customerid_value,title&$filter=(contains(title,'{name}') and new_producto1 eq {name2})&$orderby=title asc");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        //Api para obtener los datos avanzados por bcf
        [HttpGet]
        [Route("listarEjecutivobCF")]
        public async Task<string> EjecutivoBcfAsync(string name, string name2)
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "incidents";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=new_contenedor,new_factura,new_bcf,new_cantequipo,new_commodity,new_confirmacinzarpe,new_contidadbultos,new_destino,new_eta,new_etd1,modifiedon,new_incoterm,new_origen,new_po,new_poe,new_pol,new_preestado2,new_seal,_new_shipper_value,new_statuscliente,new_tamaoequipo,new_transporte,new_ingreso,new_new_facturacompaia,new_ingresoabodegas,new_instcliente,new_nombrebuque,_customerid_value,title&$filter=(contains(new_bcf,'{name}') and new_producto1 eq {name2})&$orderby=title asc");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        //Api para obtener los datos avanzados por contenedor
        [HttpGet]
        [Route("listarEjecutivoContenedor")]
        public async Task<string> EjecutivoContenedorAsync(string name, string name2)
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "incidents";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=new_contenedor,new_factura,new_bcf,new_cantequipo,new_commodity,new_confirmacinzarpe,new_contidadbultos,new_destino,new_eta,new_etd1,modifiedon,new_incoterm,new_origen,new_po,new_poe,new_pol,new_preestado2,new_seal,_new_shipper_value,new_statuscliente,new_tamaoequipo,new_transporte,new_ingreso,new_new_facturacompaia,new_ingresoabodegas,new_instcliente,new_nombrebuque,_customerid_value,title&$filter=(contains(new_contenedor,'{name}') and new_producto1 eq {name2})&$orderby=title asc");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        //Api para obtener los datos avanzados por po
        [HttpGet]
        [Route("listarEjecutivoPo")]
        public async Task<string> EjecutivoPoAsync(string name, string name2)
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "incidents";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=new_contenedor,new_factura,new_bcf,new_cantequipo,new_commodity,new_confirmacinzarpe,new_contidadbultos,new_destino,new_eta,new_etd1,modifiedon,new_incoterm,new_origen,new_po,new_poe,new_pol,new_preestado2,new_seal,_new_shipper_value,new_statuscliente,new_tamaoequipo,new_transporte,new_ingreso,new_new_facturacompaia,new_ingresoabodegas,new_instcliente,new_nombrebuque,_customerid_value,title&$filter=(contains(new_po,'{name}') and new_producto1 eq {name2})&$orderby=title asc");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        //Api para tracking en vista general
        [HttpGet]
        [Route("VistaGeneral")]
        public async Task<string> VistaGeneralAsync(string name, string name2, string name3)
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "incidents";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=new_actualizacionbconfirmation,new_etadestino,new_bcf,new_confirmacinzarpe,title,new_contenedorcargado,new_destino,new_eta,new_etd1,new_ingreso,new_ingresoabodegas,new_lugarcolocacion,new_nombrebuque,new_numeroviaje,new_ofertatarifaid,new_origen,new_poe,new_pol,new_redestino,new_statuscliente,new_tipodemovimiento1,new_pricecalculationdate,_new_consignatario_value,new_infoconsignatario,new_infonotificar,new_inforeceptorbl,new_infoshipper,_new_notificar_value,_new_receptorbl_value,_new_shipper_value,new_diasdetransito&$filter=(contains(new_bcf,'{name}') and (_customerid_value eq {name2} or _new_agenteduelodelacueta_value eq {name3}))&$orderby=title asc");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        //Api para tracking en contenedores
        [HttpGet]
        [Route("Contenedores")]
        public async Task<string> ContenedoresAsync(string name, string name2, string name3)
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "incidents";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=new_contenedor,new_cbm1,new_commodity,new_confirmacinzarpe,new_contenedorcargado,new_destino,new_eta,new_etd1,new_ingreso,new_ingresoabodegas,new_lugarcolocacion,new_nombrebuque,new_numeroviaje,new_origen,new_peso,new_poe,new_pol,new_redestino,new_statuscliente,new_tamaoequipo&$filter=(contains(new_bcf,'{name}') and (_customerid_value eq {name2} or _new_agenteduelodelacueta_value eq {name3}))&$orderby=title asc");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        //Api para tracking en precios
        [HttpGet]
        [Route("Precios")]
        public async Task<string> PreciosAsync(string name, string name2, string name3)
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "incidents";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=new_destinooferta,new_fleteoferta,new_origenoferta,_new_pagadopor_value,_new_pagadopor2_value,_new_pagadopor3_value,new_terminodepago,new_terminodepago1,new_terminodepago2&$filter=(contains(new_bcf,'{name}') and (_customerid_value eq {name2} or _new_agenteduelodelacueta_value eq {name3}))&$orderby=title asc");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        //Api para obtener los datos avanzados por idtra
        [HttpGet]
        [Route("listarRJIdtra")]
        public async Task<string> RJIdtraAsync(string name)
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "incidents";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=new_contenedor,new_factura,new_bcf,new_cantequipo,new_commodity,new_confirmacinzarpe,new_contidadbultos,new_destino,new_eta,new_etd1,modifiedon,new_incoterm,new_origen,new_po,new_poe,new_pol,new_preestado2,new_seal,_new_shipper_value,new_statuscliente,new_tamaoequipo,new_transporte,new_ingreso,new_new_facturacompaia,new_ingresoabodegas,new_instcliente,new_nombrebuque,title&$filter=contains(title,'{name}')&$orderby=title asc");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        //Api para obtener los datos avanzados por bcf
        [HttpGet]
        [Route("listarRJBcf")]
        public async Task<string> RJBcfAsync(string name)
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "incidents";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=new_contenedor,new_factura,new_bcf,new_cantequipo,new_commodity,new_confirmacinzarpe,new_contidadbultos,new_destino,new_eta,new_etd1,modifiedon,new_incoterm,new_origen,new_po,new_poe,new_pol,new_preestado2,new_seal,_new_shipper_value,new_statuscliente,new_tamaoequipo,new_transporte,new_ingreso,new_new_facturacompaia,new_ingresoabodegas,new_instcliente,new_nombrebuque,title&$filter=contains(new_bcf,'{name}')&$orderby=title asc");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        //Api para obtener los datos avanzados por contenedor
        [HttpGet]
        [Route("listarRJContenedor")]
        public async Task<string> RJContenedorAsync(string name)
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "incidents";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=new_contenedor,new_factura,new_bcf,new_cantequipo,new_commodity,new_confirmacinzarpe,new_contidadbultos,new_destino,new_eta,new_etd1,modifiedon,new_incoterm,new_origen,new_po,new_poe,new_pol,new_preestado2,new_seal,_new_shipper_value,new_statuscliente,new_tamaoequipo,new_transporte,new_ingreso,new_new_facturacompaia,new_ingresoabodegas,new_instcliente,new_nombrebuque,title&$filter=contains(new_contenedor,'{name}')&$orderby=title asc");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        //Api para obtener los datos avanzados por po
        [HttpGet]
        [Route("listarRJPo")]
        public async Task<string> RJPoAsync(string name)
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "incidents";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=new_contenedor,new_factura,new_bcf,new_cantequipo,new_commodity,new_confirmacinzarpe,new_contidadbultos,new_destino,new_eta,new_etd1,modifiedon,new_incoterm,new_origen,new_po,new_poe,new_pol,new_preestado2,new_seal,_new_shipper_value,new_statuscliente,new_tamaoequipo,new_transporte,new_ingreso,new_new_facturacompaia,new_ingresoabodegas,new_instcliente,new_nombrebuque,title&$filter=contains(new_po,'{name}')&$orderby=title asc");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        //Api para obtener los datos basicos de los tramites activos
        [HttpGet]
        [Route("listarFiltroA")]
        public async Task<string> FiltroAAsync()
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "incidents";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=new_factura,new_ingreso,new_contenedor,new_bcf,new_po,new_poe,new_pol,new_preestado2,title&$filter=(new_preestado2 eq 100000000 or new_preestado2 eq 100000016 or new_preestado2 eq 100000001 or new_preestado2 eq 100000017 or new_preestado2 eq 100000002 or new_preestado2 eq 100000003 or new_preestado2 eq 100000004 or new_preestado2 eq 100000005 or new_preestado2 eq 100000006 or new_preestado2 eq 100000018 or new_preestado2 eq 100000007 or new_preestado2 eq 100000024 or new_preestado2 eq 100000025 or new_preestado2 eq 100000026 or new_preestado2 eq 100000015)&$orderby=title desc");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        //Api para tracking en vista general
        [HttpGet]
        [Route("VistaGeneral2")]
        public async Task<string> VistaGeneral2Async(string name)
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "incidents";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=new_actualizacionbconfirmation,new_etadestino,new_bcf,new_confirmacinzarpe,title,new_contenedorcargado,new_destino,new_eta,new_etd1,new_ingreso,new_ingresoabodegas,new_lugarcolocacion,new_nombrebuque,new_numeroviaje,new_ofertatarifaid,new_origen,new_poe,new_pol,new_redestino,new_statuscliente,new_tipodemovimiento1,new_pricecalculationdate,_new_consignatario_value,new_infoconsignatario,new_infonotificar,new_inforeceptorbl,new_infoshipper,_new_notificar_value,_new_receptorbl_value,_new_shipper_value,new_diasdetransito&$filter=contains(new_bcf,'{name}')&$orderby=title asc");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        //Api para tracking en contenedores
        [HttpGet]
        [Route("Contenedores2")]
        public async Task<string> Contenedores2Async(string name)
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "incidents";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=new_contenedor,new_cbm1,new_commodity,new_confirmacinzarpe,new_contenedorcargado,new_destino,new_eta,new_etd1,new_ingreso,new_ingresoabodegas,new_lugarcolocacion,new_nombrebuque,new_numeroviaje,new_origen,new_peso,new_poe,new_pol,new_redestino,new_statuscliente,new_tamaoequipo&$filter=contains(new_bcf,'{name}')&$orderby=title asc");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        //Api para tracking en precios
        [HttpGet]
        [Route("Precios2")]
        public async Task<string> Precios2Async(string name)
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "incidents";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=new_destinooferta,new_fleteoferta,new_origenoferta,_new_pagadopor_value,_new_pagadopor2_value,_new_pagadopor3_value,new_terminodepago,new_terminodepago1,new_terminodepago2&$filter=contains(new_bcf,'{name}')&$orderby=title asc");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        //Api para obtener los datos de cotizaciones en seguimiento del cliente
        [HttpGet]
        [Route("listarCotizacionesS")]
        public async Task<string> ListarCotizacionesFiltroSAsync(string name)
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "quotes";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=new_cantidadequipos,_msdyn_account_value,quotenumber,revisionnumber,name,new_poe,new_pol,new_total,effectivefrom,effectiveto,new_equipo&$filter=(new_subiralaweb eq true and new_notifrespuestacotizacion eq null and _msdyn_account_value eq {name})&$orderby=createdon desc");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        //Api para obtener los datos de cotizaciones activas del cliente
        [HttpGet]
        [Route("listarCotizacionesA")]
        public async Task<string> ListarCotizacionesFiltroAAsync(string name)
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "quotes";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=new_cantidadequipos,_msdyn_account_value,quotenumber,revisionnumber,_new_idtra1_value,name,new_poe,new_pol,new_total,effectivefrom,effectiveto,new_equipo&$filter=(new_subiralaweb eq true and new_notifrespuestacotizacion eq 100000000 and _msdyn_account_value eq {name})&$orderby=createdon desc");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        //Api para obtener los datos de cotizaciones en seguimiento
        [HttpGet]
        [Route("listarCotizacionesRJS")]
        public async Task<string> ListarCotizacionesRJSAsync()
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "quotes";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=new_cantidadequipos,_msdyn_account_value,quotenumber,revisionnumber,name,new_poe,new_pol,new_total,effectivefrom,effectiveto,new_equipo&$filter=(new_subiralaweb eq true and new_notifrespuestacotizacion eq null)&$orderby=createdon desc");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        //Api para obtener los datos de cotizaciones acticas
        [HttpGet]
        [Route("listarCotizacionesRJA")]
        public async Task<string> ListarCotizacionesRJAAsync()
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "quotes";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=new_cantidadequipos,_msdyn_account_value,_new_idtra1_value,quotenumber,revisionnumber,name,new_poe,new_pol,new_total,effectivefrom,effectiveto,new_equipo&$filter=(new_subiralaweb eq true and new_notifrespuestacotizacion eq 100000000)&$orderby=createdon desc");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        //Api para obtener el IDTRA
        [HttpGet]
        [Route("listarCaso")]
        public async Task<string> CasoAsync(string name)
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "incidents";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=title&$filter=incidentid eq {name}");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        //Api para obtener las tarifas del meercado 
        [HttpGet]
        [Route("listarTarifasMercadoS")]
        public async Task<string> ListarTarifasMercadoSAsync()
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "quotes";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=new_cantidadequipos,_msdyn_account_value,_new_idtra1_value,quotenumber,revisionnumber,name,new_poe,new_pol,new_total,effectivefrom,effectiveto,new_equipo,freighttermscode,new_modalidaddeenvio,shippingmethodcode,new_pod&$filter=(new_subiralaweb eq true and _msdyn_account_value eq 4ce2db85-5375-ec11-8943-002248086629 and new_notifrespuestacotizacion eq null)&$orderby=createdon desc");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        //GRAFICOS TRAMITES SOFIA
        [HttpGet]
        [Route("TramitesOrigenSS")]
        public async Task<string> DatosTramitesPorOrigenSSAsync()
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "incidents";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=new_origen,new_preestado2&$filter=(new_operaciones eq 100000002 and (new_preestado2 eq 100000000 or new_preestado2 eq 100000016 or new_preestado2 eq 100000001 or new_preestado2 eq 100000017 or new_preestado2 eq 100000002 or new_preestado2 eq 100000003 or new_preestado2 eq 100000004 or new_preestado2 eq 100000005 or new_preestado2 eq 100000006 or new_preestado2 eq 100000018 or new_preestado2 eq 100000007 or new_preestado2 eq 100000024 or new_preestado2 eq 100000025 or new_preestado2 eq 100000026 or new_preestado2 eq 100000015))");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        //GRAFICOS TRAMITES ANDREA
        [HttpGet]
        [Route("TramitesOrigenAM")]
        public async Task<string> DatosTramitesPorOrigenAMAsync()
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "incidents";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=new_origen,new_preestado2&$filter=(new_operaciones eq 100000004 and (new_preestado2 eq 100000000 or new_preestado2 eq 100000016 or new_preestado2 eq 100000001 or new_preestado2 eq 100000017 or new_preestado2 eq 100000002 or new_preestado2 eq 100000003 or new_preestado2 eq 100000004 or new_preestado2 eq 100000005 or new_preestado2 eq 100000006 or new_preestado2 eq 100000018 or new_preestado2 eq 100000007 or new_preestado2 eq 100000024 or new_preestado2 eq 100000025 or new_preestado2 eq 100000026 or new_preestado2 eq 100000015))");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        //GRAFICOS TRAMITES DANNA
        [HttpGet]
        [Route("TramitesOrigenDS")]
        public async Task<string> DatosTramitesPorOrigenDSAsync()
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "incidents";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=new_origen,new_preestado2&$filter=(new_operaciones eq 100000001 and (new_preestado2 eq 100000000 or new_preestado2 eq 100000016 or new_preestado2 eq 100000001 or new_preestado2 eq 100000017 or new_preestado2 eq 100000002 or new_preestado2 eq 100000003 or new_preestado2 eq 100000004 or new_preestado2 eq 100000005 or new_preestado2 eq 100000006 or new_preestado2 eq 100000018 or new_preestado2 eq 100000007 or new_preestado2 eq 100000024 or new_preestado2 eq 100000025 or new_preestado2 eq 100000026 or new_preestado2 eq 100000015))");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        //GRAFICOS TRAMITES ASHLEY
        [HttpGet]
        [Route("TramitesOrigenAH")]
        public async Task<string> DatosTramitesPorOrigenAHAsync()
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "incidents";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=new_origen,new_preestado2&$filter=(new_operaciones eq 100000003 and (new_preestado2 eq 100000000 or new_preestado2 eq 100000016 or new_preestado2 eq 100000001 or new_preestado2 eq 100000017 or new_preestado2 eq 100000002 or new_preestado2 eq 100000003 or new_preestado2 eq 100000004 or new_preestado2 eq 100000005 or new_preestado2 eq 100000006 or new_preestado2 eq 100000018 or new_preestado2 eq 100000007 or new_preestado2 eq 100000024 or new_preestado2 eq 100000025 or new_preestado2 eq 100000026 or new_preestado2 eq 100000015))");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        //CERTIFICADOS DE RE-EXPORTACION ACTIVOS
        [HttpGet]
        [Route("listarCertificadosA")]
        public async Task<string> CertificadosActivosAsync(string name)
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "incidents";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=new_decertificadodereexportacion,new_factura,new_bcf,_customerid_value,new_observacionescertificadosreexportacion,new_preestado2,new_statusdecertificado,title&$filter=((new_subiralaweb eq true and _customerid_value eq {name} and new_aplicacertificadoreexportacion eq true) and (new_preestado2 eq 100000025 or new_preestado2 eq 100000026 or new_preestado2 eq 100000004 or new_preestado2 eq 100000005 or new_preestado2 eq 100000024 or new_preestado2 eq 100000007))&$orderby=title desc");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        //CERTIFICADOS DE RE-EXPORTACION ACTIVOS JOSUE
        [HttpGet]
        [Route("listarCertificadosARJ")]
        public async Task<string> CertificadosActivosRJAsync(string name)
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "incidents";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=new_decertificadodereexportacion,new_factura,new_observacionescertificadosreexportacion,new_statusdecertificado,title&$filter=((_customerid_value eq {name} and new_aplicacertificadoreexportacion eq true) or (new_preestado2 eq 100000025 and new_preestado2 eq 100000026 and new_preestado2 eq 100000004 and new_preestado2 eq 100000005 and new_preestado2 eq 100000024 and new_preestado2 eq 100000007))");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        //CERTIFICADOS DE RE-ESPORTACION FINALIZADOS
        [HttpGet]
        [Route("listarCertificadosF")]
        public async Task<string> CertificadosFinalizadosAsync(string name)
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "incidents";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=new_decertificadodereexportacion,new_factura,new_bcf,_customerid_value,new_observacionescertificadosreexportacion,new_preestado2,new_statusdecertificado,title&$filter=((new_subiralaweb eq true and _customerid_value eq {name} and new_aplicacertificadoreexportacion eq true) and (new_preestado2 eq 100000009 or new_preestado2 eq 100000008 or new_preestado2 eq 100000023 or new_preestado2 eq 100000022 or new_preestado2 eq 100000020 or new_preestado2 eq 100000019 or new_preestado2 eq 100000010 or new_preestado2 eq 100000011))&$orderby=title desc");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        //CERTIFICADOS DE RE-EXPORTACION POR FACTURA
        [HttpGet]
        [Route("listarCertificadosFactura")]
        public async Task<string> CertificadosFacturaAsync(string name, string name2)
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "incidents";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=new_decertificadodereexportacion,new_factura,new_bcf,_customerid_value,new_observacionescertificadosreexportacion,new_preestado2,new_statusdecertificado,title&$filter=((_customerid_value eq {name} and contains(new_factura,'{name2}')))");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;

            //ACTUALIZAR BL HIJOS EN DYANMICS

        }

        //CERTIFICADOS DE RE-EXPORTACION POR IDTRA
        [HttpGet]
        [Route("listarCertificadosIdtra")]
        public async Task<string> CertificadosIdtraAsync(string name, string name2)
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "incidents";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=new_decertificadodereexportacion,new_factura,new_bcf,_customerid_value,new_observacionescertificadosreexportacion,new_preestado2,new_statusdecertificado,title&$filter=((_customerid_value eq {name} and contains(title,'{name2}')))");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        //GRAFICOS DE CERTIFICADOS DE RE-EXPORTACION
        [HttpGet]
        [Route("DatosCertificados")]
        public async Task<string> DatosCertificadosAsync()
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "incidents";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=new_preestado2,new_statusdecertificado&$filter=((new_preestado2 eq 100000025 or new_preestado2 eq 100000004 or new_preestado2 eq 100000026 or new_preestado2 eq 100000007 or new_preestado2 eq 100000024 or new_preestado2 eq 100000005) and new_aplicacertificadoreexportacion eq true)");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        //COLOCACIONES CRC EN ALMACEN A257
        [HttpGet]
        [Route("ColocacionesPtoAlmacen")]
        public async Task<string> ColocacionesPtoAlmaceAsync()
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "incidents";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=new_contenedor,new_bcf,_customerid_value,title&$filter=((new_preestado2 eq 100000007 and contains(new_redestino,'A257')))");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        //MOVIMIENTO PANAMA TO CRC
        [HttpGet]
        [Route("MovimientoPanamaCrc")]
        public async Task<string> MovimientoPanamaCrcAsync()
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "incidents";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=new_contenedor,new_bcf,_customerid_value,title&$filter=(new_preestado2 eq 100000024)");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        //ALMACEN FISCAL POR IDTRA
        [HttpGet]
        [Route("AlmacenFiscalIdtra")]
        public async Task<string> AlmacenFiscalIdtraAsync(string name)
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "incidents";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=new_contenedor,new_bcf,new_cantequipo,_customerid_value,new_commodity,new_contidadbultos,new_fechacolocacin,new_preestado2,new_statuscliente,new_tamaoequipo,new_tipoembalaje,title,new_peso&$filter=(contains(title,'{name}'))");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        //ALMACEN FISCAR POR PO
        [HttpGet]
        [Route("AlmacenFiscalPo")]
        public async Task<string> AlmacenFiscalPoAsync(string name)
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "incidents";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=new_contenedor,new_bcf,new_cantequipo,_customerid_value,new_commodity,new_contidadbultos,new_fechacolocacin,new_preestado2,new_statuscliente,new_tamaoequipo,new_tipoembalaje,title,new_peso&$filter=(contains(new_po,'{name}'))");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        //ALAMCEN FISCAL POR FACTURA
        [HttpGet]
        [Route("AlmacenFiscalFactura")]
        public async Task<string> AlmacenFiscalFacturaAsync(string name)
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "incidents";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=new_contenedor,new_bcf,new_cantequipo,_customerid_value,new_commodity,new_contidadbultos,new_fechacolocacin,new_preestado2,new_statuscliente,new_tamaoequipo,new_tipoembalaje,title,new_peso&$filter=(contains(new_factura,'{name}'))");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        //ALMACEN FISCAL POR BCF
        [HttpGet]
        [Route("AlmacenFiscalBcf")]
        public async Task<string> AlmacenFiscalBcfAsync(string name)
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "incidents";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=new_contenedor,new_bcf,new_cantequipo,_customerid_value,new_commodity,new_contidadbultos,new_fechacolocacin,new_preestado2,new_statuscliente,new_tamaoequipo,new_tipoembalaje,title,new_peso&$filter=(contains(new_bcf,'{name}'))");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        //ALMACEN FISCAL POR CONTENEDOR
        [HttpGet]
        [Route("AlmacenFiscalContenedor")]
        public async Task<string> AlmacenFiscalContenedorAsync(string name)
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "incidents";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=new_contenedor,new_bcf,new_cantequipo,_customerid_value,new_commodity,new_contidadbultos,new_fechacolocacin,new_preestado2,new_statuscliente,new_tamaoequipo,new_tipoembalaje,title,new_peso&$filter=(contains(new_contenedor,'{name}'))");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        //WHS MIAMI EN PRE-ALERTA
        [HttpGet]
        [Route("WHSMiamiPreAlerta")]
        public async Task<string> WhsMiamiPreAlertaAsync(string name)
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "incidents";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=new_contenedor,new_factura,new_bcf,_customerid_value,new_contidadbultos,new_fechaingresobodegawhs,new_habilitarbodega,new_po,new_preestado2,_new_shipper_value,new_statuscliente,new_tipoembalaje,new_obersvaciones,title,new_warehousetrackingident&$filter=((new_subiralaweb eq true and new_habilitarbodega eq 100000000 and _customerid_value eq {name}) and new_preestado2 eq 100000014)&$orderby=title desc");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        //WHS MIAMI EN BODEGA
        [HttpGet]
        [Route("WHSMiamiBodega")]
        public async Task<string> WhsMiamiBodegaAsync(string name)
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "incidents";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=new_contenedor,new_factura,new_bcf,_customerid_value,new_contidadbultos,new_fechaingresobodegawhs,new_habilitarbodega,new_po,new_preestado2,_new_shipper_value,new_statuscliente,new_tipoembalaje,new_obersvaciones,title,new_warehousetrackingident&$filter=((new_subiralaweb eq true and new_habilitarbodega eq 100000000 and _customerid_value eq {name}) and (new_preestado2 eq 100000015 or new_preestado2 eq 100000017 or new_preestado2 eq 100000001))&$orderby=title desc");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        //WHS MIAMI EN DESPACHO
        [HttpGet]
        [Route("WHSMiamiDespacho")]
        public async Task<string> WhsMiamiDespachoAsync(string name)
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "incidents";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=new_contenedor,new_factura,new_bcf,_customerid_value,new_contidadbultos,new_fechaingresobodegawhs,new_habilitarbodega,new_po,new_preestado2,_new_shipper_value,new_statuscliente,new_tipoembalaje,new_obersvaciones,title,new_warehousetrackingident&$filter=((new_subiralaweb eq true and new_habilitarbodega eq 100000000 and _customerid_value eq {name}) and (new_preestado2 eq 100000007 or new_preestado2 eq 100000011 or new_preestado2 eq 100000002 or new_preestado2 eq 100000003 or new_preestado2 eq 100000004 or new_preestado2 eq 100000005 or new_preestado2 eq 100000006 or new_preestado2 eq 100000018 or new_preestado2 eq 100000009 or new_preestado2 eq 100000008 or new_preestado2 eq 100000023 or new_preestado2 eq 100000022 or new_preestado2 eq 100000020 or new_preestado2 eq 100000019 or new_preestado2 eq 100000010))&$orderby=title desc");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        //WHS MIAMI POR BCF
        [HttpGet]
        [Route("WHSMiamiBcf")]
        public async Task<string> WhsMiamiBcfAsync(string name)
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "incidents";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=new_cbm1,new_contenedor,new_factura,new_bcf,_customerid_value,new_contidadbultos,new_fechaingresobodegawhs,new_habilitarbodega,new_po,new_preestado2,_new_shipper_value,new_statuscliente,new_tipoembalaje,new_obersvaciones,title,new_warehousetrackingident&$filter=contains(new_bcf,'{name}')");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        //WHS MIAMI POR CONTENEDOR
        [HttpGet]
        [Route("WHSMiamiContenedor")]
        public async Task<string> WhsMiamiContenedorAsync(string name)
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "incidents";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=new_cbm1,new_contenedor,new_factura,new_bcf,_customerid_value,new_contidadbultos,new_fechaingresobodegawhs,new_habilitarbodega,new_po,new_preestado2,_new_shipper_value,new_statuscliente,new_tipoembalaje,new_obersvaciones,title,new_warehousetrackingident&$filter=contains(new_contenedor,'{name}')");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        //WHS MIAMI POR TRACKING
        [HttpGet]
        [Route("WHSMiamiTracking")]
        public async Task<string> WhsMiamiTrackingAsync(string name)
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "incidents";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=new_cbm1,new_contenedor,new_factura,new_bcf,_customerid_value,new_contidadbultos,new_fechaingresobodegawhs,new_habilitarbodega,new_po,new_preestado2,_new_shipper_value,new_statuscliente,new_tipoembalaje,new_obersvaciones,title,new_warehousetrackingident&$filter=contains(new_obersvaciones,'{name}')");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        //WHS MIAMI POR IDTRA
        [HttpGet]
        [Route("WHSMiamiIdtra")]
        public async Task<string> WhsMiamiIdtraAsync(string name)
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "incidents";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=new_cbm1,new_contenedor,new_factura,new_bcf,_customerid_value,new_contidadbultos,new_fechaingresobodegawhs,new_habilitarbodega,new_po,new_preestado2,_new_shipper_value,new_statuscliente,new_tipoembalaje,new_obersvaciones,title,new_warehousetrackingident&$filter=contains(title,'{name}')");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        //WHS MIAMI POR FACTURA
        [HttpGet]
        [Route("WHSMiamiFactura")]
        public async Task<string> WhsMiamiFacturaAsync(string name)
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "incidents";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=new_cbm1,new_contenedor,new_factura,new_bcf,_customerid_value,new_contidadbultos,new_fechaingresobodegawhs,new_habilitarbodega,new_po,new_preestado2,_new_shipper_value,new_statuscliente,new_tipoembalaje,new_obersvaciones,title,new_warehousetrackingident&$filter=contains(new_factura,'{name}')");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        //WHS MIAMI POR PO
        [HttpGet]
        [Route("WHSMiamiPo")]
        public async Task<string> WhsMiamiPoAsync(string name)
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "incidents";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=new_cbm1,new_contenedor,new_factura,new_bcf,_customerid_value,new_contidadbultos,new_fechaingresobodegawhs,new_habilitarbodega,new_po,new_preestado2,_new_shipper_value,new_statuscliente,new_tipoembalaje,new_obersvaciones,title,new_warehousetrackingident&$filter=contains(new_po,'{name}')");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        //WHS MIAMI POR WHS
        [HttpGet]
        [Route("WHSMiamiWhs")]
        public async Task<string> WhsMiamiWhsAsync(string name)
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "incidents";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=new_cbm1,new_contenedor,new_factura,new_bcf,_customerid_value,new_contidadbultos,new_fechaingresobodegawhs,new_habilitarbodega,new_po,new_preestado2,_new_shipper_value,new_statuscliente,new_tipoembalaje,new_obersvaciones,title,new_warehousetrackingident&$filter=contains(new_warehousetrackingident,'{name}')");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        //WHS PANAMA EN TRANSITO
        [HttpGet]
        [Route("WHSPanamaTransito")]
        public async Task<string> WhsPanamaTransitoAsync(string name)
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "incidents";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=new_peso,new_contenedor,new_factura,new_bcf,_customerid_value,new_contidadbultos,new_fechaingresobodegawhs,new_habilitarbodega,new_po,new_preestado2,_new_shipper_value,new_statuscliente,new_tipoembalaje,new_obersvaciones,title,new_warehousetrackingident&$filter=((new_subiralaweb eq true and new_habilitarbodega eq 100000002 and _customerid_value eq {name}) and (new_preestado2 eq 100000002 or new_preestado2 eq 100000003))&$orderby=title desc");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        //WHS PANAMA EN BODEGA
        [HttpGet]
        [Route("WHSPanamaBodega")]
        public async Task<string> WhsPanamaBodegaAsync(string name)
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "incidents";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=new_peso,new_contenedor,new_factura,new_bcf,_customerid_value,new_contidadbultos,new_fechaingresobodegawhs,new_habilitarbodega,new_po,new_preestado2,_new_shipper_value,new_statuscliente,new_tipoembalaje,new_obersvaciones,title,new_warehousetrackingident&$filter=((new_subiralaweb eq true and new_habilitarbodega eq 100000002 and _customerid_value eq {name}) and (new_preestado2 eq 100000025 or new_preestado2 eq 100000026))&$orderby=title desc");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        //WHS PANAMA EN DESPACHO
        [HttpGet]
        [Route("WHSPanamaDespacho")]
        public async Task<string> WhsPanamaDespachoAsync(string name)
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "incidents";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=new_peso,new_contenedor,new_factura,new_bcf,_customerid_value,new_contidadbultos,new_fechaingresobodegawhs,new_habilitarbodega,new_po,new_preestado2,_new_shipper_value,new_statuscliente,new_tipoembalaje,new_obersvaciones,title,new_warehousetrackingident&$filter=((new_subiralaweb eq true and new_habilitarbodega eq 100000002 and _customerid_value eq {name}) and (new_preestado2 eq 100000024 or new_preestado2 eq 100000004 or new_preestado2 eq 100000008 or new_preestado2 eq 100000009 or new_preestado2 eq 100000005 or new_preestado2 eq 100000007 or new_preestado2 eq 100000023 or new_preestado2 eq 100000022 or new_preestado2 eq 100000020 or new_preestado2 eq 100000019 or new_preestado2 eq 100000010 or new_preestado2 eq 100000011))&$orderby=title desc");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        //WHS PANAMA POR BCF
        [HttpGet]
        [Route("WHSPanamaBcf")]
        public async Task<string> WhsPanamaBcfAsync(string name)
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "incidents";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=new_montodebodegajepanama,new_cbm1,new_contenedor,new_factura,new_bcf,_customerid_value,new_contidadbultos,new_fechaingresobodegawhs,new_habilitarbodega,new_po,new_preestado2,_new_shipper_value,new_statuscliente,new_tipoembalaje,new_obersvaciones,title,new_warehousetrackingident&$filter=contains(new_bcf,'{name}')");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        //WHS PANAMA POR CONTENEDOR 
        [HttpGet]
        [Route("WHSPanamaContenedor")]
        public async Task<string> WhsPanamaContenedorAsync(string name)
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "incidents";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=new_montodebodegajepanama,new_cbm1,new_contenedor,new_factura,new_bcf,_customerid_value,new_contidadbultos,new_fechaingresobodegawhs,new_habilitarbodega,new_po,new_preestado2,_new_shipper_value,new_statuscliente,new_tipoembalaje,new_obersvaciones,title,new_warehousetrackingident&$filter=contains(new_contenedor,'{name}')");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        //WHS PANAMA POR TRACKING
        [HttpGet]
        [Route("WHSPanamaTracking")]
        public async Task<string> WhsPanamaTrackingAsync(string name)
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "incidents";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=new_montodebodegajepanama,new_cbm1,new_contenedor,new_factura,new_bcf,_customerid_value,new_contidadbultos,new_fechaingresobodegawhs,new_habilitarbodega,new_po,new_preestado2,_new_shipper_value,new_statuscliente,new_tipoembalaje,new_obersvaciones,title,new_warehousetrackingident&$filter=contains(new_obersvaciones,'{name}')");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        //WHS PANAMA POR IDTRA
        [HttpGet]
        [Route("WHSPanamaIdtra")]
        public async Task<string> WhsPanamaIdtraAsync(string name)
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "incidents";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=new_montodebodegajepanama,new_cbm1,new_contenedor,new_factura,new_bcf,_customerid_value,new_contidadbultos,new_fechaingresobodegawhs,new_habilitarbodega,new_po,new_preestado2,_new_shipper_value,new_statuscliente,new_tipoembalaje,new_obersvaciones,title,new_warehousetrackingident&$filter=contains(title,'{name}')");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        //WHS PANAMA POR FACTURA
        [HttpGet]
        [Route("WHSPanamaFactura")]
        public async Task<string> WhsMiamiPanamaAsync(string name)
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "incidents";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=new_montodebodegajepanama,new_cbm1,new_contenedor,new_factura,new_bcf,_customerid_value,new_contidadbultos,new_fechaingresobodegawhs,new_habilitarbodega,new_po,new_preestado2,_new_shipper_value,new_statuscliente,new_tipoembalaje,new_obersvaciones,title,new_warehousetrackingident&$filter=contains(new_factura,'{name}')");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        //WHS PANAMA POR PO
        [HttpGet]
        [Route("WHSPanamaPo")]
        public async Task<string> WhsPanamaPoAsync(string name)
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "incidents";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=new_montodebodegajepanama,new_cbm1,new_contenedor,new_factura,new_bcf,_customerid_value,new_contidadbultos,new_fechaingresobodegawhs,new_habilitarbodega,new_po,new_preestado2,_new_shipper_value,new_statuscliente,new_tipoembalaje,new_obersvaciones,title,new_warehousetrackingident&$filter=contains(new_po,'{name}')");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        //WHS PANAMA POR WHS
        [HttpGet]
        [Route("WHSPanamaWhs")]
        public async Task<string> WhsPanamaWhsAsync(string name)
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "incidents";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=new_montodebodegajepanama,new_cbm1,new_contenedor,new_factura,new_bcf,_customerid_value,new_contidadbultos,new_fechaingresobodegawhs,new_habilitarbodega,new_po,new_preestado2,_new_shipper_value,new_statuscliente,new_tipoembalaje,new_obersvaciones,title,new_warehousetrackingident&$filter=contains(new_warehousetrackingident,'{name}')");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        [HttpPatch]
        [Route("UpdateDynamics")]
        public async Task<string> UpdateAsync(string id, string bcf)
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "incidents";

                dynamic content = new JObject();
                content.new_bcf = bcf;
                HttpContent httpContent = new StringContent(content.ToString(), UnicodeEncoding.UTF8, "application/json");
                httpClient.DefaultRequestHeaders.Add("Prefer", "return=representation");
                httpClient.DefaultRequestHeaders.Add("If-Match", "*");
                HttpResponseMessage httpResponseMessage = await httpClient.PatchAsync($"api/data/v9.1/{entityName}({id})", httpContent);
                var response = httpResponseMessage.EnsureSuccessStatusCode();
                HttpStatusCode statusCode;
                statusCode = response.StatusCode;

                if ((int)response.StatusCode == 200)
                {
                    response2 = "Actualizado";
                }
                //response2 = httpContent.ToString();

                Console.WriteLine(response);
            }

            return response2;
        }

        [HttpGet]
        [Route("listarCodigoCaso")]
        public async Task<string> CasoCodeAsync(string name)
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "incidents";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=incidentid&$filter=contains(title,'{name}')");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        [HttpGet]
        [Route("listarTramitesAduanalesF")]
        public async Task<string> TramitesAduanalesFAsync(string name)
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "competitors";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=new_factura,new_solicitud,new_facturac12,new_aplicacertificadodeorigen2,new_aplicacertificadodeorigen,new_cantequipo2,new_cantequipo,new_commodity,new_commodity2,_new_idtra_value,new_llevaexoneracion,new_llevaexoneracion2,new_llevapermisos,new_llevapermisos2,name,new_statusaduanal,new_tamaoequipo,new_tamaoequipo2,new_facturac22,new_facturac2,new_facturac32,new_facturac3,new_facturac42,new_facturac4,new_facturac5,new_facturac52&$filter=(_new_cliente_value eq {name} and (new_statusaduanal eq 100000010 or new_statusaduanal eq 100000011 or new_statusaduanal eq 100000012 or new_statusaduanal eq 100000013))");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        [HttpGet]
        [Route("listarTramitesAduanalesA")]
        public async Task<string> TramitesAduanalesAAsync(string name)
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "competitors";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=new_factura,new_solicitud,new_facturac12,new_aplicacertificadodeorigen2,new_aplicacertificadodeorigen,new_cantequipo2,new_cantequipo,new_commodity,new_commodity2,_new_idtra_value,new_llevaexoneracion,new_llevaexoneracion2,new_llevapermisos,new_llevapermisos2,name,new_statusaduanal,new_tamaoequipo,new_tamaoequipo2,new_facturac22,new_facturac2,new_facturac32,new_facturac3,new_facturac42,new_facturac4,new_facturac5,new_facturac52&$filter=(_new_cliente_value eq {name} and (new_statusaduanal eq 100000000 or new_statusaduanal eq 100000001 or new_statusaduanal eq 100000002 or new_statusaduanal eq 100000003 or new_statusaduanal eq 100000004 or new_statusaduanal eq 100000005 or new_statusaduanal eq 100000006 or new_statusaduanal eq 100000007 or new_statusaduanal eq 100000008 or new_statusaduanal eq 100000009))");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        [HttpGet]
        [Route("listarAduanaIdtra")]
        public async Task<string> AduanaIdtraAsync(string name)
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "competitors";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=new_factura,new_facturac12,new_aplicacertificadodeorigen2,new_aplicacertificadodeorigen,new_cantequipo2,new_cantequipo,new_commodity,new_commodity2,_new_idtra_value,new_llevaexoneracion,new_llevaexoneracion2,new_llevapermisos,new_llevapermisos2,name,new_statusaduanal,new_tamaoequipo,new_tamaoequipo2,new_facturac22,new_facturac2,new_facturac32,new_facturac3,new_facturac42,new_facturac4,new_facturac5,new_facturac52&$filter=(_new_idtra_value eq {name})");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        [HttpGet]
        [Route("listarAduanaRecibo")]
        public async Task<string> AduanaReciboAsync(string name)
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "competitors";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=new_factura,new_facturac12,new_aplicacertificadodeorigen2,new_aplicacertificadodeorigen,new_cantequipo2,new_cantequipo,new_commodity,new_commodity2,_new_idtra_value,new_llevaexoneracion,new_llevaexoneracion2,new_llevapermisos,new_llevapermisos2,name,new_statusaduanal,new_tamaoequipo,new_tamaoequipo2,new_facturac22,new_facturac2,new_facturac32,new_facturac3,new_facturac42,new_facturac4,new_facturac5,new_facturac52&$filter=(contains(name,'{name}'))");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        [HttpGet]
        [Route("listarAduanaSolicitud")]
        public async Task<string> AduanaSolicitudAsync(string name)
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "competitors";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=new_factura,new_facturac12,new_aplicacertificadodeorigen2,new_aplicacertificadodeorigen,new_cantequipo2,new_cantequipo,new_commodity,new_commodity2,_new_idtra_value,new_llevaexoneracion,new_llevaexoneracion2,new_llevapermisos,new_llevapermisos2,name,new_statusaduanal,new_tamaoequipo,new_tamaoequipo2,new_facturac22,new_facturac2,new_facturac32,new_facturac3,new_facturac42,new_facturac4,new_facturac5,new_facturac52&$filter=(new_solicitud,'{name}'))");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        [HttpGet]
        [Route("listarAduanaBl")]
        public async Task<string> AduanaBlAsync(string name)
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "competitors";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=new_factura,new_facturac12,new_aplicacertificadodeorigen2,new_aplicacertificadodeorigen,new_cantequipo2,new_cantequipo,new_commodity,new_commodity2,_new_idtra_value,new_llevaexoneracion,new_llevaexoneracion2,new_llevapermisos,new_llevapermisos2,name,new_statusaduanal,new_tamaoequipo,new_tamaoequipo2,new_facturac22,new_facturac2,new_facturac32,new_facturac3,new_facturac42,new_facturac4,new_facturac5,new_facturac52&$filter=(new_bl,'{name}'))");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        [HttpGet]
        [Route("listarExoneracionesA")]
        public async Task<string> ExoneracionesAAsync(string name)
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "salesliteratures";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=new_autorizacin,new_solicitud,_new_idtravinculadocorrecto_value,new_statusexoneracion,new_tipoexoneracin,name,new_validahasta&$filter=(_new_cliente_value eq {name} and (new_statusexoneracion eq 100000000 or new_statusexoneracion eq 100000001 or new_statusexoneracion eq 100000002 or new_statusexoneracion eq 100000003))");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        [HttpGet]
        [Route("listarExoneracionesF")]
        public async Task<string> ExoneracionesFAsync(string name)
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "salesliteratures";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=new_autorizacin,new_solicitud,_new_idtravinculadocorrecto_value,new_statusexoneracion,new_tipoexoneracin,name,new_validahasta&$filter=(_new_cliente_value eq {name} and (new_statusexoneracion eq 100000004))");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        [HttpGet]
        [Route("listarExoneracionesIdtra")]
        public async Task<string> ExoneracionesIdtraAsync(string name)
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "salesliteratures";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=new_autorizacin,new_solicitud,_new_idtravinculadocorrecto_value,new_statusexoneracion,new_tipoexoneracin,name,new_validahasta&$filter=(_new_idtravinculadocorrecto_valu eq {name})");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        [HttpGet]
        [Route("listarExoneracionesProducto")]
        public async Task<string> ExoneracionesProductoAsync(string name)
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "salesliteratures";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=new_autorizacin,new_solicitud,_new_idtravinculadocorrecto_value,new_statusexoneracion,new_tipoexoneracin,name,new_validahasta&$filter=(contains(name,'{name}'))");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        [HttpGet]
        [Route("listarExoneracionesSolicitud")]
        public async Task<string> ExoneracionesSolicitudAsync(string name)
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "salesliteratures";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=new_autorizacin,new_solicitud,_new_idtravinculadocorrecto_value,new_statusexoneracion,new_tipoexoneracin,name,new_validahasta&$filter=(contains(new_solicitud,'{name}'))");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        [HttpGet]
        [Route("listarExoneracionesAutorizacion")]
        public async Task<string> ExoneracionesAutorizacionAsync(string name)
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "salesliteratures";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$select=new_autorizacin,new_solicitud,_new_idtravinculadocorrecto_value,new_statusexoneracion,new_tipoexoneracin,name,new_validahasta&$filter=(contains(new_autorizacin,'{name}'))");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }

        [HttpGet]
        [Route("ClienteIdtra")]
        public async Task<string> ClienteIdtra1Async(string name)
        {
            string clientId = "04f616d1-fb10-4c4f-ba02-45d2562fa9a8";
            string clientSecrets = "1cn8Q~reOm4kQQ5fuaMUbR_X.cmtbQwyxv22IaVH";
            string authority = "https://login.microsoftonline.com/48f7ad87-a406-4c72-98f5-d1c996e7e6f2";
            string crmUrl = "https://sibaja07.crm.dynamics.com/";
            string response2 = "";

            string accessToken = string.Empty;

            ClientCredential credentials = new ClientCredential(clientId, clientSecrets);
            var authContext = new AuthenticationContext(authority);
            var result = await authContext.AcquireTokenAsync(crmUrl, credentials);
            accessToken = result.AccessToken;
            Console.WriteLine(accessToken);

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(crmUrl);
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                httpClient.DefaultRequestHeaders.Add("OData-Version", "4.0");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                string entityName = "incidents";

                /*HttpResponseMessage whoAmIResponse = await httpClient.GetAsync("api/data/v9.2/WhoAmI");
                whoAmIResponse.EnsureSuccessStatusCode();
                var response = await whoAmIResponse.Content.ReadAsStringAsync();*/

                HttpResponseMessage httpResponseMessaje = await httpClient.GetAsync($"api/data/v9.2/{entityName}?$incidents?$select=_customerid_value&$filter=contains(title,'{name}')");
                httpResponseMessaje.EnsureSuccessStatusCode();
                var response = await httpResponseMessaje.Content.ReadAsStringAsync();

                response2 = response;

                Console.WriteLine(response);
            }

            return response2;
        }


    }
}
