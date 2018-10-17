﻿using Newtonsoft.Json.Linq;
using System;

namespace TripAssistantSearchEngineApi
{
    public class CoreResponse
    {
        public string Type { get; set; }
        public JObject ActivityList { get; set; }
        public JObject HotelList { get; set; }
        public string ResponseQuery { get; set; }
    }
}
