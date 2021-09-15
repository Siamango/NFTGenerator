﻿using Newtonsoft.Json;

namespace NFTGenerator.JsonObjects
{
    internal class FileMetadata
    {
        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("cdn")]
        public bool Cdn { get; set; }
    }
}