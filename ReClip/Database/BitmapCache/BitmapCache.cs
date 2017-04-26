﻿using LiteDB;
using System;
using System.IO;
using System.Linq;
        {
            return collection.FindOne(item => item.CRC32 == crc32);
        }
        {
            Remove(bitmap.GetCRC32());
        }
        {
            return db.Contains(bitmap);
        }
        {
            var item = db.GetCacheItem(crc32);

            if (item == null)
                return null;
            
            return new Bitmap(new MemoryStream(item.Binary));
        }