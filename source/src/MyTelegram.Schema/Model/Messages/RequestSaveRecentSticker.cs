﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;

///<summary>
///See <a href="https://core.telegram.org/method/messages.saveRecentSticker" />
///</summary>
[TlObject(0x392718f8)]
public sealed class RequestSaveRecentSticker : IRequest<IBool>
{
    public uint ConstructorId => 0x392718f8;
    public BitArray Flags { get; set; } = new BitArray(32);
    public bool Attached { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/InputDocument" />
    ///</summary>
    public MyTelegram.Schema.IInputDocument Id { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/Bool" />
    ///</summary>
    public bool Unsave { get; set; }

    public void ComputeFlag()
    {
        if (Attached) { Flags[0] = true; }

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Flags);
        Id.Serialize(bw);
        bw.Serialize(Unsave);
    }

    public void Deserialize(BinaryReader br)
    {
        Flags = br.Deserialize<BitArray>();
        if (Flags[0]) { Attached = true; }
        Id = br.Deserialize<MyTelegram.Schema.IInputDocument>();
        Unsave = br.Deserialize<bool>();
    }
}
