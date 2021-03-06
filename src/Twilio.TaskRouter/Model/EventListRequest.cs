﻿using System;

namespace Twilio.TaskRouter
{
    public class EventListRequest
    {
        /// <summary>
        /// Gets or sets the minutes.
        /// </summary>
        public int? Minutes { get; set; }
        /// <summary>
        /// Gets or sets the start date.
        /// </summary>
        public DateTime? StartDate { get; set; }
        /// <summary>
        /// Gets or sets the end date.
        /// </summary>
        public DateTime? EndDate { get; set; }
        /// <summary>
        /// Gets or sets the resource sid.
        /// </summary>
        public string ResourceSid { get; set; }
        /// <summary>
        /// Gets or sets the type of the event.
        /// </summary>
        public string EventType { get; set; }
        /// <summary>
        /// Gets or sets the page token.
        /// </summary>
        public string PageToken { get; set; }
        /// <summary>
        /// Gets or sets the count.
        /// </summary>
        public int? Count { get; set; }
    }
}

