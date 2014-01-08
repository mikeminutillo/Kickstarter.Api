using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Kickstarter.Api.Model
{
    [DataContract]
    public class Project : HypermediaItem
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "blurb")]
        public string Blurb { get; set; }

        [DataMember(Name = "goal")]
        public decimal Goal { get; set; }

        [DataMember(Name = "pledged")]
        public decimal Pledged { get; set; }

        [DataMember(Name = "state")]
        public string State { get; set; }

        [DataMember(Name = "slug")]
        public string Slug { get; set; }

        [DataMember(Name = "disable_communication")]
        public string DisableCommunication { get; set; }

        [DataMember(Name = "country")]
        public string Country { get; set; }

        [DataMember(Name = "currency")]
        public string Currency { get; set; }

        [DataMember(Name = "currency_symbol")]
        public string CurrencySymbol { get; set; }

        [DataMember(Name = "currency_trailing_code")]
        public bool CurrencyTrailingCode { get; set; }

        [DataMember(Name = "deadline")]
        public DateTime Deadline { get; set; }

        [DataMember(Name = "state_changed_at")]
        public DateTime StateChangedAt { get; set; }

        [DataMember(Name = "created_at")]
        public DateTime CreatedAt { get; set; }

        [DataMember(Name = "launched_at")]
        public DateTime LaunchedAt { get; set; }

        [DataMember(Name = "backers_count")]
        public int BackersCount { get; set; }

        [DataMember(Name = "photo")]
        public IDictionary<string, string> Photo { get; set; }

        [DataMember(Name = "creator")]
        public UserReference Creator { get; set; }

        [DataMember(Name = "location")]
        public Location Location { get; set; }

        [DataMember(Name = "category")]
        public CategoryReference Category { get; set; }

        [DataMember(Name = "updated_at")]
        public DateTime UpdatedAt { get; set; }

        [DataMember(Name = "video")]
        public Video Video { get; set; }
    }
}