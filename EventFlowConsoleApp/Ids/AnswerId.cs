﻿using System.Text.Json.Serialization;
using EventFlow.Core;
using EventFlow.ValueObjects;

namespace EventFlowConsoleApp.Ids
{
    [JsonConverter(typeof(SingleValueObjectConverter))]
    public class AnswerId : Identity<AnswerId>
    {
        public AnswerId(string value) : base(value) { }
    }
}
