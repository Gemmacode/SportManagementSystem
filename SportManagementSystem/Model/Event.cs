﻿using SportManagementSystem.Model.Enum;

namespace SportManagementSystem.Model
{
    public class Event : BaseEntity
    {
        public string EventName { get; set; }
        public string Location { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public EventStatus Status { get; set; }
    }
}
