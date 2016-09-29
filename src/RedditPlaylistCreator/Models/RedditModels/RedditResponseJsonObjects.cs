namespace RedditPlaylistCreator.Models.RedditModels
{

    public class RedditListingResponseJson
    {
        public string kind { get; set; }
        public Data data { get; set; }
    }

    public class Data
    {
        public string modhash { get; set; }
        public RedditPostHeaderJson[] children { get; set; }
        public string after { get; set; }
        public string before { get; set; }
    }

    public class RedditPostHeaderJson
    {
        public string kind { get; set; }
        public RedditPostJson data { get; set; }
    }

    public class RedditPostJson
    {
        public bool contest_mode { get; set; }
        public object banned_by { get; set; }
        public string domain { get; set; }
        public string subreddit { get; set; }
        public string selftext_html { get; set; }
        public string selftext { get; set; }
        public object likes { get; set; }
        public object suggested_sort { get; set; }
        public object[] user_reports { get; set; }
        public Secure_Media secure_media { get; set; }
        public bool saved { get; set; }
        public string id { get; set; }
        public int gilded { get; set; }
        public Secure_Media_Embed secure_media_embed { get; set; }
        public bool clicked { get; set; }
        public object report_reasons { get; set; }
        public string author { get; set; }
        public Media media { get; set; }
        public string name { get; set; }
        public int score { get; set; }
        public object approved_by { get; set; }
        public bool over_18 { get; set; }
        public object removal_reason { get; set; }
        public bool hidden { get; set; }
        public string thumbnail { get; set; }
        public string subreddit_id { get; set; }
        public object edited { get; set; }
        public string link_flair_css_class { get; set; }
        public object author_flair_css_class { get; set; }
        public int downs { get; set; }
        public object[] mod_reports { get; set; }
        public bool archived { get; set; }
        public Media_Embed media_embed { get; set; }
        public bool is_self { get; set; }
        public bool hide_score { get; set; }
        public string permalink { get; set; }
        public bool locked { get; set; }
        public bool stickied { get; set; }
        public int created { get; set; }
        public string url { get; set; }
        public string author_flair_text { get; set; }
        public bool quarantine { get; set; }
        public string title { get; set; }
        public int created_utc { get; set; }
        public string link_flair_text { get; set; }
        public string distinguished { get; set; }
        public int num_comments { get; set; }
        public bool visited { get; set; }
        public object num_reports { get; set; }
        public int ups { get; set; }
    }

    public class Secure_Media
    {
        public string type { get; set; }
        public Oembed oembed { get; set; }
    }

    public class Oembed
    {
        public string provider_url { get; set; }
        public string title { get; set; }
        public string html { get; set; }
        public int thumbnail_width { get; set; }
        public int height { get; set; }
        public int width { get; set; }
        public string version { get; set; }
        public string author_name { get; set; }
        public string provider_name { get; set; }
        public string thumbnail_url { get; set; }
        public string type { get; set; }
        public int thumbnail_height { get; set; }
        public string author_url { get; set; }
    }

    public class Secure_Media_Embed
    {
        public string content { get; set; }
        public int width { get; set; }
        public bool scrolling { get; set; }
        public int height { get; set; }
    }

    public class Media
    {
        public string type { get; set; }
        public Oembed1 oembed { get; set; }
    }

    public class Oembed1
    {
        public string provider_url { get; set; }
        public string title { get; set; }
        public string html { get; set; }
        public int thumbnail_width { get; set; }
        public int height { get; set; }
        public int width { get; set; }
        public string version { get; set; }
        public string author_name { get; set; }
        public string provider_name { get; set; }
        public string thumbnail_url { get; set; }
        public string type { get; set; }
        public int thumbnail_height { get; set; }
        public string author_url { get; set; }
    }

    public class Media_Embed
    {
        public string content { get; set; }
        public int width { get; set; }
        public bool scrolling { get; set; }
        public int height { get; set; }
    }

}
