﻿using System;
namespace Movie.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }

        public string Name { get; set; }

        public byte DurationInMonth { get; set; }

        public byte DiscountRate { get; set; }
    }
}
