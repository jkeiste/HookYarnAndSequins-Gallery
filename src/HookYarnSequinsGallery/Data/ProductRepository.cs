using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HookYarnSequinsGallery.Models;

namespace HookYarnSequinsGallery.Data
{
    public class ProductRepository
    {
        private static Product[] _products = new Product[]
        {
            new Product()
            {
                Id = 1,
                ProductName = "Beatrice the Bunny",
                ItemNumber = 1,
                DescriptionHtml = "<p>Meet Beatrice the Bunny.</br></p><p>Beatrice the bunny is perfect for cuddling and playtime and is a great gift for everyone, age 0 to 100. She is made with moveable legs, making it easier for her to sit or lay down.</br></p><p>Beatrice is 15in tall standing, 10in tall sitting, and her body is 3.5in wide.</br></p><p>Beatrice the Bunny is available in several color options.</br></p><p>Please note: Beatrice can be made with safety eyes and embroidered eyes. While safety eyes are cute and are technically designed to avoid becoming a choking hazard for small children, this is not a certainty. Therefore, I recommend that if you are purchasing Beatrice for a small child or anyone who you fear may choke on small items please consider the embroidered eyes.</br></p><p>If you have any questions or would like to customize Beatrice the Bunny please feel free to send a message!</br></p><p>*adapted from pattern on bhookedcrochet.com</br></p>",
                Favorite = false
            },
            new Product()
            {
                Id = 2,
                ProductName = "Bertie the Bunny",
                ItemNumber = 2,
                DescriptionHtml = "<p>Meet Bertie the Bunny.</br></p><p>Bertie the bunny is made from very soft yarn and is perfect for cuddling and is a great companion for everyone, age 0 to 100. She is made with moveable legs, making it easier to seat her or lay her down.</br></p><p>Bertie is 33in tall standing, 19in tall sitting, and her body is 6in wide.</br></p><p>Bertie the Bunny is available in several color options (options 19-25 will form stripes).</br></p><p>Bertie shown in the picture above was made with a tweed yarn (not shown in yarn ball color options pictures because there is only 1 Tweed Bertie the Bunny available).</br></p><p>If you have any questions or would like to customize Bertie the Bunny please feel free to send a message!</br></p><p>*adapted from pattern on bhookedcrochet.com</br></p>",
                Favorite = true
            },
            new Product()
            {
                Id = 3,
                ProductName = "Jamie and Jules the Jellyfish",
                ItemNumber = 3,
                DescriptionHtml = "<p>Meet Jamie and Jules the Jellyfish. They are perfect for playtime and will love to take your imagination on a tour of the ocean!</br></p><p>The jellyfish are 15.5in long, The body is 3.5in long and the longest tentacles are 12in long.</br></p><p>Jamie and Jules are available as a set. They are made to order and can be customized. If you would like to select a color option not listed in the drop down menus please select the custom option and send me a message with which colors you would like for each jellyfish's Body and accent tentacles, and which type of eyes you would prefer (embroidered or safety eyes). I added a string loop to the top of the jellyfish to hang them to help take pictures, if you would like to have the string included to hang Jules and Jamie please let me know and I’ll be sure to add it.</br></p><p>Please note: Jules and Jamie can be made with safety eyes and embroidered eyes. While safety eyes are cute and are technically designed to avoid becoming a choking hazard for small children, this is not a certainty. Therefore, I recommend that if you are purchasing the jellyfish for a small child or anyone who you fear may choke on small items please consider the embroidered eyes.</br></p><p>Also please be careful playing with Jules and Jamie, it may be possible to get tangled up in their tentacles.</br></p><p>If you have any questions please feel free to send a message!</br></p><p>*adapted from pattern on 1dogwoof.com</br></p>",
                Favorite = false
            },
            new Product()
            {
                Id = 4,
                ProductName = "Walter the Whale",
                ItemNumber = 4,
                DescriptionHtml = "<p>Meet Walter the Whale!</br></p><p>Walter loves hugs, snuggles and is the perfect friend for everyone, age 0 to 100. He is 24 inches long from nose to tail, 19 inches wide from fin to fin and 12 inches tall from belly to top fin.</br></p><p>Walter is available in several colors for his back and a white stomach.</br></p><p>Please note: Walter can be made with safety eyes and embroidered eyes. While safety eyes are cute and are technically designed to avoid becoming a choking hazard for small children, this is not a certainty. Therefore, I recommend that if you are purchasing Walter for a small child or anyone who you fear may choke on small items please consider the embroidered eyes.</br></p><p>If you have any questions or would like to customize Walter the Whale in a way not listed please feel free to send a message!</br></p><p>*adapted from pattern on 1dogwoof.com</br></p>",
                Favorite = false
            }
        };

        public Product[] GetProducts()
        {
            return _products;
        }

        public Product GetProduct(int id)
        {
            Product productToReturn = null;

            foreach (var product in _products)
            {
                if (product.Id == id)
                {
                    productToReturn = product;

                    break;
                }
            }

            return productToReturn;
        }
    }
}