﻿// Copyright Matteo Beltrame

using Newtonsoft.Json;
using System;

namespace NFTGenerator.Metadata;

[Serializable]
internal class AttributeMetadata : IEquatable<AttributeMetadata>
{
    [JsonProperty("trait_type")]
    public string Trait { get; init; }

    [JsonProperty("value")]
    public string Value { get; init; }

    [JsonProperty("rarity")]
    public float Rarity { get; set; }

    public AttributeMetadata()
    {
        Trait = string.Empty;
        Value = string.Empty;
    }

    public bool Equals(AttributeMetadata other) => Trait.Equals(other.Trait);

    public override string ToString() => "{" + Trait + ": " + Value + "}";
}