using Refit;
using TestApp.Contracts;

namespace TestApp
{
    public interface ISuggestionApi
    {
        [Get("/geocoding/v5/mapbox.places/{text}.json?access_token=pk.eyJ1IjoidWxhZHppc2xhdS0xOTk1IiwiYSI6ImNrdTExZnRrbDJhYmQyd21yZ3o0aTZrNWgifQ.yOLgxESWjvKiqsTLdhYzeQ&autocomplete=true&limit=5&types=place")]
        Task<GeocodingResponse> GetSuggestions(string text);
    }
}