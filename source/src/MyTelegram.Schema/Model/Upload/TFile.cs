﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Upload;


///<summary>
///See <a href="https://core.telegram.org/constructor/upload.file" />
///</summary>
[TlObject(0x96a18d5)]
public class TFile : IFile
{
    public uint ConstructorId => 0x96a18d5;

    ///<summary>
    ///See <a href="https://core.telegram.org/type/storage.FileType" />
    ///</summary>
    public MyTelegram.Schema.Storage.IFileType Type { get; set; }
    public int Mtime { get; set; }
    public byte[] Bytes { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        Type.Serialize(bw);
        bw.Write(Mtime);
        bw.Serialize(Bytes);
    }

    public void Deserialize(BinaryReader br)
    {
        Type = br.Deserialize<MyTelegram.Schema.Storage.IFileType>();
        Mtime = br.ReadInt32();
        Bytes = br.Deserialize<byte[]>();
    }
}