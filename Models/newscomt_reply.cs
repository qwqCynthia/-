﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class newscomt_reply
    {
        public int newsreply_id { get; set; }
        public int newscomt_id { get; set; }
        public int reply_aim { get; set; }
        public int user_id { get; set; }
        public DateTime reply_time { get; set; }
        public string reply_cont { get; set; }
        public int count { get; set; }
    }
}
