namespace Contact
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Contacts
    {
        [JsonProperty("rehber")]
        [Required]
        public List<Rehber> rehber { get; set; }
    }

    public partial class Rehber
    {
        [JsonProperty("isim")]
        [Required]
        public string isim { get; set; }

        [JsonProperty("tel")]
        [Required]
        public string tel { get; set; }

        [JsonProperty("kod")]
        [Required]
        public long kod { get; set; }
    }
}