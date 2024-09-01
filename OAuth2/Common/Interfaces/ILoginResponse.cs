namespace BurakKontas.OAuth2.Common.Interfaces;

public interface ILoginResponse
{
    public string AccessToken { get; set; }
    public int ExpiresIn { get; set; }
    public string TokenType { get; set; }
}