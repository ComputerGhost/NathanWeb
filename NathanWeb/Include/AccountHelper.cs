﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;

namespace NathanWeb.Include
{
    public class AccountHelper
    {
        public static byte[] GenerateSalt()
        {
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);
            return salt;
        }

        public static byte[] Hash(string password, byte[] salt)
        {
            return new Rfc2898DeriveBytes(password, salt).GetBytes(20);
        }
    }
}