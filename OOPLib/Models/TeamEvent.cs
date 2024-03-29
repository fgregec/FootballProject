﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLib.Models
{
    public class TeamEvent
    {
        [JsonProperty("id")]
        public long? Id { get; set; }

        [JsonProperty("type_of_event")]
        public String TypeOfEvent { get; set; }

        [JsonProperty("player")]
        public String Player { get; set; }

        [JsonProperty("time")]
        public String Time { get; set; }
    }
}
