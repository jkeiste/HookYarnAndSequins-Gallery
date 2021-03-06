﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HookYarnSequinsGallery.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Inventory { get; set; }
        public string DescriptionHtml { get; set; }
        public bool PopularItem { get; set; }

        public string DisplayText
        {
            get
            {
                return ProductName;
            }
        }

        public string CoverImageFileName
        {
            get
            {
                return ProductName.Replace(" ", "-")
                    .ToLower() + ".jpg";
            }
        }
    }
}