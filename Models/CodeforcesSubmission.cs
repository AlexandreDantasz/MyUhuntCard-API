﻿using System.Text.Json.Serialization;

namespace MyUhuntCard.Models
{
    public enum Verdict
    {
        FAILED,
        OK,
        PARTIAL,
        COMPILATION_ERROR,
        RUNTIME_ERROR,
        WRONG_ANSWER,
        PRESENTATION_ERROR,
        TIME_LIMIT_EXCEEDED,
        MEMORY_LIMIT_EXCEEDED,
        IDLENESS_LIMIT_EXCEEDED,
        SECURITY_VIOLATED,
        CRASHED,
        INPUT_PREPARATION_CRASHED,
        CHALLENGED,
        SKIPPED,
        TESTING,
        REJECTED
    }
    public class CodeforcesSubmission
    {
        [JsonConverter(typeof(JsonStringEnumConverter))]
        [JsonPropertyName("verdict")]
        public Verdict? Verdict {  get; set; }

    }
}
