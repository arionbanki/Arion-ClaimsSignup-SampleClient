using Arion.ClaimsSignup.SampleClient.ApiHelper;
using Arion.ClaimsSignup.SampleClient.Models.Entities;
using Arion.ClaimsSignup.SampleClient.Models.Enums;
using Arion.ClaimsSignup.SampleClient.Models.Requests;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Serialization;

namespace IsIT.Claims.Sandbox.DeveloperConsole;

class Programs
{
    // UserApplication api key obtained from Developer Portal
    private static readonly string APIKEY = "[Place your ApiKey from the developer portal in here]";

    // User (PSU) identifier. Reserverd User from Developer Portal
    private static readonly string NATIONAL_REGISTRY_ID = "[Place your created user's national registry id from the developer portal in here]";

    // Base path for the api, this is the production endpoint  
    private static readonly string BASE_PATH = "https://apigw.arionbanki.is/claims/api/v1";

    // client id
    private static readonly string CLIENT_ID = "[Place your client id from the developer portal in here]";

    // client secret
    private static readonly string CLIENT_SECRET = "[Place your client secret from the developer portal in here]";

    // client scopes
    private static readonly string CLIENT_SCOPES = "profile claims.readwrite";

    // ID of the request, unique to the call, as determined by the initiating party.
    private static readonly string REQUESTID = Guid.NewGuid().ToString();

    // Access Token created in Developer Portal from UserApplication and User.
    private static readonly string ACCESS_TOKEN = "[Place your token from the developer portal in here]"; // To get access token on production, use https://curity-prod.arionbanki.is/oauth/v2/oauth-token
                                                                                                          // Wellknown OpenId enpoint on production can be found here: https://curity.arionbanki.is/oauth/v2/oauth-anonymous/.well-known/openid-configuration

    static async Task Main(string[] args)
    {
        bool showMenu = true;
        while (showMenu)
        {
            showMenu = await MainMenu();
        }
    }

    private static async Task<bool> MainMenu()
    {
        Console.WriteLine("");
        Console.WriteLine("==== IOBWS 3.0 Claims");
        Console.WriteLine("1) Files - Upload Agreement");
        Console.WriteLine("2) Create Claimant");
        Console.WriteLine("3) Get Claimant Status");
        Console.WriteLine("4) Create Template");
        Console.WriteLine("5) Get Template Satatus");
        Console.WriteLine("6) Echo");
        Console.Write("\r\nSelect an option: ");

        switch (Console.ReadLine())
        {
            case "1":
                await CreateClaimant();
                return true;
            case "2":
                await GetClaimantStatus();
                return true;
            case "3":
                await CreateTemplate();
                return true;
            case "4":
                await GetTemplateStatus();
                return true;
            case "5":
                await Echo();
                return true;
        }

        return true;
    }

    #region ApiRequests

    // POST /api/v1/claimants
    private static async Task CreateClaimant()
    {
        // Build Request
        var requestBodies = new RequestBodies();
        var createClaimant = requestBodies.CreateClaimantRequest();
        var createClaimantRequest = ApiHelper.CreateSerializedRequest(createClaimant);

        // Api call
        HttpClient clientWithCertificate = await SetupHttpClient();
        var createClaimantStatus = await clientWithCertificate.PostAsync($"{BASE_PATH}/claimants", createClaimantRequest);

        // Results
        var result = await createClaimantStatus.Content.ReadAsStringAsync();
    }

    // GET /api/v1/claimants/{claimantId}/status
    private static async Task GetClaimantStatus()
    {
        // Build Request
        var claimantId = NATIONAL_REGISTRY_ID;

        // Api call
        HttpClient clientWithCertificate = await SetupHttpClient();
        var getClaimantStatus = await clientWithCertificate.GetAsync($"{BASE_PATH}/claimants/{claimantId}/status");

        // Results
        var result = await getClaimantStatus.Content.ReadAsStringAsync();
    }

    // POST /api/v1/claimtemplates
    private static async Task CreateTemplate()
    {
        // Build Request
        var requestBodies = new RequestBodies();
        var createTemplate = requestBodies.CreateClaimTemplateRequest();
        var createTemplateRequest = ApiHelper.CreateSerializedRequest(createTemplate);

        // Api call
        HttpClient clientWithCertificate = await SetupHttpClient();

        //var createTemplateStatus = await clientWithCertificate.PostAsync($"{BASE_PATH}/claimtemplates", createTemplateRequest);
        var createTemplateStatus = await clientWithCertificate.PostAsync($"{BASE_PATH}/claimtemplates", createTemplateRequest);


        // Results
        var result = await createTemplateStatus.Content.ReadAsStringAsync();
    }

    // GET /api/v1/claimtemplates/{claimTemplateId}/status
    private static async Task GetTemplateStatus()
    {
        var templateId = "";

        HttpClient clientWithCertificate = await SetupHttpClient();

        // Get /api/v1/claimtemplates/{claimTemplateId}/status
        var getTemplateStatus = await clientWithCertificate.GetAsync($"{BASE_PATH}/claimtemplates/{templateId}/status");

        // Result
        var result = await getTemplateStatus.Content.ReadAsStringAsync();
    }

    // GET /api/v1/echo
    private static async Task Echo()
    {
        // Get HttpClient
        HttpClient clientWithCertificate = await SetupHttpClient();

        // Api call
        var echoStatus = await clientWithCertificate.GetAsync($"{BASE_PATH}/echo");

        // Results
        var result = await echoStatus.Content.ReadAsStringAsync();
    }
    #endregion

    #region Helpers
    private static async Task<HttpClient> SetupHttpClient()
    {
        var nvc = new List<KeyValuePair<string, string>>();
        nvc.Add(new KeyValuePair<string, string>("grant_type", "client_credentials"));
        nvc.Add(new KeyValuePair<string, string>("client_id", CLIENT_ID));
        nvc.Add(new KeyValuePair<string, string>("client_secret", CLIENT_SECRET));
        nvc.Add(new KeyValuePair<string, string>("scope", CLIENT_SCOPES));

        var clientCertificate = new X509Certificate2(Path.Combine(Environment.CurrentDirectory, "GefandiNew.pfx"), "Gefandi2022");
        var handler = new HttpClientHandler();
        handler.ClientCertificates.Add(clientCertificate);

        HttpClient clientWithCertificate = new HttpClient(handler);

        clientWithCertificate.DefaultRequestHeaders.Add("X-Request-ID", REQUESTID);                                        // Id of Consent.
        clientWithCertificate.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", APIKEY);                              // Azure Apim Subscription key
        clientWithCertificate.DefaultRequestHeaders.Add("Accept", "application/json");
        clientWithCertificate.DefaultRequestHeaders.Add("x-forwarded-tls-client-cert", "");

        clientWithCertificate.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", ACCESS_TOKEN); // PSU Bearer token

        return clientWithCertificate;
    }

    internal class Token
    {
        [JsonPropertyName("access_token")]
        public string? AccessToken { get; set; }

        [JsonPropertyName("token_type")]
        public string? TokenType { get; set; }

        [JsonPropertyName("expires_in")]
        public int ExpiresIn { get; set; }

        [JsonPropertyName("refresh_token")]
        public string? RefreshToken { get; set; }
    }

    public class RequestBodies
    {
        public CreateClaimant CreateClaimantRequest()
        {
            var createClaimant = new CreateClaimant
            {
                ClaimantId = NATIONAL_REGISTRY_ID
            };
            return createClaimant;
        }

        public TemplateRequest CreateClaimTemplateRequest()
        {
            var template = new TemplateRequest
            {
                ClaimantStatementExtendedReferenceType = ClaimantStatementExtendedReferenceType.ReferenceNumber,
                ClaimantStatementReferenceType = ClaimantStatementReferenceType.DueDate,
                ClaimantId = NATIONAL_REGISTRY_ID,
                Bank = "[place your 4 digit bank account here]",
                TemplateCode = "[place your 3 digit template code here]",
                Category = "[place your 2 digit category here]",
                PayorStatementExtendedReferenceType = PayorStatementExtendedReferenceType.ClaimantId,
                DepositAccount = new DepositAccount
                {
                    Id = "[place your 12 digit deposit account id here]",
                },
                WithdrawalAccount = "[place your 12 digit withdrawal account here]",
                AdditionalDepositAccounts = new List<AdditionalDepositAccount>
                {
                    new AdditionalDepositAccount
                    {
                        Id = "[place your 12 digit additional deposit account id here]",
                        OwnerId = NATIONAL_REGISTRY_ID,
                        Type = AdditionalDepositAccountType.NoticeAndPaymentFee,
                        Code = "[place your 4 digit additional depostit account code here]",
                        Priority = 6,
                        DepositAmount = new DepositAmount
                        {
                            Value = 10,
                            ValueType = Arion.ClaimsSignup.SampleClient.Models.Enums.ValueType.FixedAmount
                        }
                    }
                }
            };
            return template;
        }
    }
    #endregion Helper
}