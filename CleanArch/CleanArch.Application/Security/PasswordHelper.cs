﻿using System;
using System.Security.Cryptography;
using System.Text;

namespace CleanArch.Application.Security
{
    public static class PasswordHelper
    {
        public static string EncodePasswordMd5(string pass)//Encrypt using MD5
        {
            Byte[] originalBytes;
            Byte[] encodedBytes;
            MD5 md5;
            //Instantiate MD5CryptoServiceProvider, get bytes for original password and compute hash (encoded password)   
            md5 = new MD5CryptoServiceProvider();
            originalBytes = Encoding.Default.GetBytes(pass);
            encodedBytes = md5.ComputeHash(originalBytes);
            //Convert encoded bytes back to a 'readable' string   
            return BitConverter.ToString(encodedBytes);
        }
    }
}
