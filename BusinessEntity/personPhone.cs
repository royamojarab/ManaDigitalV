﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity
{
 
    public class personPhone 
    {
        public int Id { get; set; }
        public int personDataId { get; set; }
        public person personData { get; set; }
        public string phoneNumber { get; set; }
        public string phoneNumberType { get; set; }

    }
   
}
