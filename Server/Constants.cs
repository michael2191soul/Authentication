namespace Server
{
    public static class Constants
    {
        public const string Issuer = "Audience";
        public const string Audience = "https://localhost:44345/";
        public const string Secret = "not_too_short_secret_otherwise_it_may_cause_error";
    }
}
