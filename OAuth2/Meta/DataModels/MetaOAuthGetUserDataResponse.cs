using System.Text.Json.Serialization;

namespace OAuth2.Meta.DataModels;

public class MetaOAuthGetUserDataResponse
{
    // TODO: For all fields add data
    public string? Id { get; set; }
    public string? Name { get; set; }
    public string? Email { get; set; }
    public MetaOAuthGetUserDataPictureData? Picture { get; set; }
}

public class MetaOAuthGetUserDataPictureData
{
    public class Data
    {
        public int? Height { get; set; }
        public int? Width { get; set; }

        [JsonPropertyName("is_silhouette")]
        public bool? IsSilhouette { get; set; }

        public string? Url { get; set; }
    }
}