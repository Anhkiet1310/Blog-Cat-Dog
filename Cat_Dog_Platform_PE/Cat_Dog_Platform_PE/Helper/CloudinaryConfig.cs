﻿using CloudinaryDotNet;

namespace Cat_Dog_Platform_PE.Helper
{
    public class CloudinaryConfig
    {
        public Cloudinary cloudinary;
        public CloudinaryConfig()
        {
            Account account = new Account(
                "dddywpfov",
                "653594513686496",
                "hwZfrhZFzbCNYafvv3E0pgLiaJg");

            cloudinary = new Cloudinary(account);
        }
    }
}
