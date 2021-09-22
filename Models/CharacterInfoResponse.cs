using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Marvel.Models
{
    public class CharacterInfoResponse
    {
        public string AttributionText { get; set; }
        public Datawrapper Data { get; set; }

        public class Datawrapper
        {
            public List<Result> Results { get; set; }
        }

        public class Result
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public Image Thumbnail { get; set; }
            public ResourceList Comics { get; set; }

            public class Image
            {
                public string Path { get; set; }
                public string Extension { get; set; }
            }

            public class ResourceList
            {
                public int Available { get; set; }
                public int Returned { get; set; }
                public string CollectionURI { get; set; }
                public List<Items> Items { get; set; }
            }
            public class Items
            {
                public string ResourceURI { get; set; }
                public string Name { get; set; }
            }

        }
    }
}
