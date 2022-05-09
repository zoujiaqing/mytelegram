﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/updateDialogPinned" />
///</summary>
[TlObject(0x6e6fe51c)]
public class TUpdateDialogPinned : IUpdate
{
    public uint ConstructorId => 0x6e6fe51c;
    public BitArray Flags { get; set; } = new BitArray(32);
    public bool Pinned { get; set; }
    public int? FolderId { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/DialogPeer" />
    ///</summary>
    public MyTelegram.Schema.IDialogPeer Peer { get; set; }

    public void ComputeFlag()
    {
        if (Pinned) { Flags[0] = true; }
        if (FolderId != 0 && FolderId.HasValue) { Flags[1] = true; }

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Flags);
        if (Flags[1]) { bw.Write(FolderId.Value); }
        Peer.Serialize(bw);
    }

    public void Deserialize(BinaryReader br)
    {
        Flags = br.Deserialize<BitArray>();
        if (Flags[0]) { Pinned = true; }
        if (Flags[1]) { FolderId = br.ReadInt32(); }
        Peer = br.Deserialize<MyTelegram.Schema.IDialogPeer>();
    }
}