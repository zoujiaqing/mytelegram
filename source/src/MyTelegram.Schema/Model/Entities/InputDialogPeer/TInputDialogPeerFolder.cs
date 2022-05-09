﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/inputDialogPeerFolder" />
///</summary>
[TlObject(0x64600527)]
public class TInputDialogPeerFolder : IInputDialogPeer
{
    public uint ConstructorId => 0x64600527;
    public int FolderId { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Write(FolderId);
    }

    public void Deserialize(BinaryReader br)
    {
        FolderId = br.ReadInt32();
    }
}