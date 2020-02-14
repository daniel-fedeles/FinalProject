namespace MovieLibrary.Services
{
    public class TMDB
    {
        public string ApiKey { get; set; }
        public string Url { get; set; }

        public string Query { get; set; }


        public string ComposeUrl()
        {
            return Url + ApiKey + "&language=en-US&query=" + Query + "&page=1&include_adult=false";
        }
    }
}