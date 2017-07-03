namespace Zukini.API.Examples.Features.Ccmsi.IdentityServer.Request
{
    public class IdentityServerTokenDTO
    {
        public string access_token { get; set; }
        public int expires_in { get; set; }
        public string token_type { get; set; }
        public string refresh_token { get; set; }
    }
}