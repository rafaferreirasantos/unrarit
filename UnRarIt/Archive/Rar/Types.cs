﻿using System;
using UnRarIt.Interop;
using System.IO;
namespace UnRarIt.Archive.Rar
{
    public enum RarStatus : int
    {
        SUCCESS = 0,
        END_ARCHIVE = 10,
        NO_MEMORY = 11,
        BAD_DATA = 12,
        BAD_ARCHIVE = 13,
        UNKNOWN_FORMAT = 14,
        EOPEN = 15,
        ECREATE = 16,
        ECLOSE = 17,
        EREAD = 18,
        EWRITE = 19,
        SMALL_BUF = 20,
        UNKNOWN = 21,
        MISSING_PASSWORD = 22,
        USER_BREAK = 255
    }

    internal enum RarOpenMode : uint
    {
        LIST = 0,
        EXTRACT = 1,
        LIST_INCSPLIT = 2,
    }

    internal enum RarOperation : int
    {
        SKIP = 0,
        TEST = 1,
        EXTRACT = 2
    }

    internal enum RarMessage : uint
    {
        CHANGEVOLUME = 0,
        PROCESSDATA = 1,
        NEEDPASSWORD = 2
    }

    internal enum RarVolumeMsg : uint
    {
        ASK = 0,
        NOTIFY = 1
    }

    public class RarException : ArchiveException
    {
        RarStatus result;
        public RarStatus Result
        {
            get { return result; }
        }
        public RarException(RarStatus aResult)
            : base(aResult.ToString())
        {
            result = aResult;
        }
    }

    #region RarItemInfo
    public class RarItemInfo : IArchiveEntry
    {
        string fileName;
        bool isEncrypted;
        ulong packed;
        ulong unpacked;
        UInt32 crc;
        DateTime fileTime;
        uint version;
        uint method;
        uint attributes;


        FileInfo dest;

        public string Name
        {
            get { return fileName; }
        }
        public bool IsCrypted
        {
            get { return isEncrypted; }
        }
        public ulong Size
        {
            get { return unpacked; }
        }
        public ulong CompressedSize
        {
            get { return packed; }
        }
        public UInt32 Crc
        {
            get { return crc; }
        }
        public DateTime DateTime
        {
            get { return fileTime; }
        }
        public uint Version
        {
            get { return version; }
        }
        public uint Attributes
        {
            get { return attributes; }
        }
        public FileInfo Destination
        {
            get { return dest; }
            set { dest = value; }
        }

        public RarItemInfo(string aFileName, bool aIsEncrypted, ulong aPacked, ulong aUnpacked, UInt32 aCRC, DateTime aFileTime, uint aVersion, uint aMethod, uint aAttributes)
        {
            fileName = Reimplement.CleanFileName(aFileName);
            isEncrypted = aIsEncrypted;
            packed = aPacked;
            unpacked = aUnpacked;
            crc = aCRC;
            fileTime = aFileTime;
            version = aVersion;
            method = aMethod;
            attributes = aAttributes;
        }
    }
    #endregion
}