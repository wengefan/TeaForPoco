﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareWizard.TeaForPoco
{
    public class EnumItem
    {
        public string Name { get; set; }

        public List<EnumMemberItem> EnumMemberItems { get; set; }
    }
}
