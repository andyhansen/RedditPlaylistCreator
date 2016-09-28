namespace RedditPlaylistCreator.Models.RedditModels
{
    public class PostJson
    {

        public class Rootobject
        {
            public string kind { get; set; }
            public Data data { get; set; }
        }

        public class Data
        {
            public bool contest_mode { get; set; }
            public object banned_by { get; set; }
            public string domain { get; set; }
            public string subreddit { get; set; }
            public object selftext_html { get; set; }
            public string selftext { get; set; }
            public object likes { get; set; }
            public object suggested_sort { get; set; }
            public object[] user_reports { get; set; }
            public object secure_media { get; set; }
            public bool saved { get; set; }
            public string id { get; set; }
            public int gilded { get; set; }
            public Secure_Media_Embed secure_media_embed { get; set; }
            public bool clicked { get; set; }
            public object report_reasons { get; set; }
            public string author { get; set; }
            public object media { get; set; }
            public string name { get; set; }
            public int score { get; set; }
            public object approved_by { get; set; }
            public bool over_18 { get; set; }
            public object removal_reason { get; set; }
            public bool hidden { get; set; }
            public string thumbnail { get; set; }
            public string subreddit_id { get; set; }
            public bool edited { get; set; }
            public object link_flair_css_class { get; set; }
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
            public object author_flair_text { get; set; }
            public bool quarantine { get; set; }
            public string title { get; set; }
            public int created_utc { get; set; }
            public object link_flair_text { get; set; }
            public object distinguished { get; set; }
            public int num_comments { get; set; }
            public bool visited { get; set; }
            public object num_reports { get; set; }
            public int ups { get; set; }
        }

        public class Secure_Media_Embed
        {
        }

        public class Media_Embed
        {
        }

    }
}
