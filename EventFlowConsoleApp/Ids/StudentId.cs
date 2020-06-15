﻿using System.Text.Json.Serialization;
using EventFlow.Core;
using EventFlow.ValueObjects;

namespace EventFlowConsoleApp.Ids
{
    [JsonConverter(typeof(SingleValueObjectConverter))]
    public class StudentId : Identity<StudentId>
    {
        public StudentId(string value) : base(value) { }
    }
}
