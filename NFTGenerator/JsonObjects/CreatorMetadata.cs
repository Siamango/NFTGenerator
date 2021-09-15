﻿using Newtonsoft.Json;

namespace NFTGenerator.JsonObjects
{
    [System.Serializable]
    internal class CreatorMetadata
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("share")]
        public int Share { get; set; }

        public bool Valid()
        {
            if (Address.Equals(string.Empty))
            {
                Logger.LogError("Creator Address is empty");
                return false;
            }
            if (Share <= 0)
            {
                Logger.LogError("Creator Share is set to " + Share);
                return false;
            }
            return true;
        }
    }
}