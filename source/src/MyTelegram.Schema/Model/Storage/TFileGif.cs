﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Storage;


///<summary>
///See <a href="https://core.telegram.org/constructor/storage.fileGif" />
///</summary>
[TlObject(0xcae1aadf)]
public class TFileGif : IFileType
{
    public uint ConstructorId => 0xcae1aadf;


    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);

    }

    public void Deserialize(BinaryReader br)
    {

    }
}