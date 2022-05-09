﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;

///<summary>
///See <a href="https://core.telegram.org/method/messages.requestUrlAuth" />
///</summary>
[TlObject(0x198fb446)]
public sealed class RequestRequestUrlAuth : IRequest<MyTelegram.Schema.IUrlAuthResult>
{
    public uint ConstructorId => 0x198fb446;
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    ///See <a href="https://core.telegram.org/type/InputPeer" />
    ///</summary>
    public MyTelegram.Schema.IInputPeer? Peer { get; set; }
    public int? MsgId { get; set; }
    public int? ButtonId { get; set; }
    public string? Url { get; set; }

    public void ComputeFlag()
    {
        if (Peer != null) { Flags[1] = true; }
        if (MsgId != 0 && MsgId.HasValue) { Flags[1] = true; }
        if (ButtonId != 0 && ButtonId.HasValue) { Flags[1] = true; }
        if (Url != null) { Flags[2] = true; }
    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Flags);
        if (Flags[1]) { Peer.Serialize(bw); }
        if (Flags[1]) { bw.Write(MsgId.Value); }
        if (Flags[1]) { bw.Write(ButtonId.Value); }
        if (Flags[2]) { bw.Serialize(Url); }
    }

    public void Deserialize(BinaryReader br)
    {
        Flags = br.Deserialize<BitArray>();
        if (Flags[1]) { Peer = br.Deserialize<MyTelegram.Schema.IInputPeer>(); }
        if (Flags[1]) { MsgId = br.ReadInt32(); }
        if (Flags[1]) { ButtonId = br.ReadInt32(); }
        if (Flags[2]) { Url = br.Deserialize<string>(); }
    }
}
