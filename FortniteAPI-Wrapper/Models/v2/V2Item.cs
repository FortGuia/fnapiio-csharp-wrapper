﻿using System;
using FortniteAPI.Models.Utility;
using Newtonsoft.Json;

namespace FortniteAPI.Models.v2
{
    public class V2Item
    {
        [JsonProperty("id")] public string Id;
        [JsonProperty("type")] public V2TranslatableInfo Type;
        [JsonProperty("name")] public string Name;
        [JsonProperty("description")] public string Description;
        [JsonProperty("rarity")] public V2TranslatableInfo Rarity;
        [JsonProperty("series")] public V2TranslatableInfo Series;
        [JsonProperty("price")] public int Price;
        [JsonProperty("added")] public V2Added Added;
        [JsonProperty("builtInEmote")] public V2Item BuiltInEmote;
        [JsonProperty("copyrightedAudio")] public bool CopyrightedAudio;
        [JsonProperty("upcoming")] public bool Upcoming;
        [JsonProperty("reactive")] public bool Reactive;
        [JsonProperty("releaseDate")] public DateTime ReleaseDate;
        [JsonProperty("lastAppearance")] public DateTime LastAppearance;
        [JsonProperty("interest")] public double Interest;
        [JsonProperty("images")] public Images Images;
        [JsonProperty("video")] public string Video;
        [JsonProperty("gameplayTags")] public string[] GameplayTags;
        [JsonProperty("battlepass")] public V2BPInfo Battlepass;
        [JsonProperty("set")] public V2TranslatableInfo Set;
    }
}