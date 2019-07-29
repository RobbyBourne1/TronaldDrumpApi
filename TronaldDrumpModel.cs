using System;
using System.Collections.Generic;
using System.IO;

namespace TronaldDrumpApi
{
    public class Self
    {
        public string href { get; set; }
    }

    public class Links
    {
        public Self self { get; set; }
    }

    public class Author
    {
        public DateTime created_at { get; set; }
        public object bio { get; set; }
        public string author_id { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
        public DateTime updated_at { get; set; }
    }

    public class Source
    {
        public DateTime created_at { get; set; }
        public object filename { get; set; }
        public string quote_source_id { get; set; }
        public object remarks { get; set; }
        public DateTime updated_at { get; set; }
        public string url { get; set; }
    }

    public class Embedded2
    {
        public List<Author> author { get; set; }
        public List<Source> source { get; set; }
    }

    public class Quote
    {
        public DateTime appeared_at { get; set; }
        public DateTime created_at { get; set; }
        public string quote_id { get; set; }
        public List<string> tags { get; set; }
        public DateTime updated_at { get; set; }
        public string value { get; set; }
        public Links _links { get; set; }
        public Embedded2 _embedded { get; set; }
    }

    public class Embedded
    {
        public List<Quote> quotes { get; set; }
    }

    public class Self2
    {
        public string href { get; set; }
    }

    public class Prev
    {
        public string href { get; set; }
    }

    public class Next
    {
        public string href { get; set; }
    }

    public class First
    {
        public string href { get; set; }
    }

    public class Last
    {
        public string href { get; set; }
    }

    public class Links2
    {
        public Self2 self { get; set; }
        public Prev prev { get; set; }
        public Next next { get; set; }
        public First first { get; set; }
        public Last last { get; set; }
    }

    public class RootObject
    {
        public int count { get; set; }
        public int total { get; set; }
        public Embedded _embedded { get; set; }
        public Links2 _links { get; set; }
    }
}