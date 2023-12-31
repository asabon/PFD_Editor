﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFD_Editor
{
    public class PfdWorkProduct : PfdItem
    {
        public PfdWorkProduct()
        {
            this.id = 0;
            this.subject = "";
            this.description = "";
            this.type = PfdItemType.WorkProduct;
        }

        public PfdWorkProduct(PfdWorkProduct original)
        {
            this.id = original.id;
            this.subject = original.subject;
            this.description = original.description;
            this.type = PfdItemType.WorkProduct;
        }
    }
}
