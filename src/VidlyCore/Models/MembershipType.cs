﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace VidlyCore.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }

        public short SignUpFee { get; set; }

        public byte DurationInMonth { get; set; }

        public byte DiscountRate { get; set; }
    }
}