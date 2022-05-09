﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Contacts;

///<summary>
///See <a href="https://core.telegram.org/method/contacts.getTopPeers" />
///</summary>
[TlObject(0x973478b6)]
public sealed class RequestGetTopPeers : IRequest<MyTelegram.Schema.Contacts.ITopPeers>
{
    public uint ConstructorId => 0x973478b6;
    public BitArray Flags { get; set; } = new BitArray(32);
    public bool Correspondents { get; set; }
    public bool BotsPm { get; set; }
    public bool BotsInline { get; set; }
    public bool PhoneCalls { get; set; }
    public bool ForwardUsers { get; set; }
    public bool ForwardChats { get; set; }
    public bool Groups { get; set; }
    public bool Channels { get; set; }
    public int Offset { get; set; }
    public int Limit { get; set; }
    public long Hash { get; set; }

    public void ComputeFlag()
    {
        if (Correspondents) { Flags[0] = true; }
        if (BotsPm) { Flags[1] = true; }
        if (BotsInline) { Flags[2] = true; }
        if (PhoneCalls) { Flags[3] = true; }
        if (ForwardUsers) { Flags[4] = true; }
        if (ForwardChats) { Flags[5] = true; }
        if (Groups) { Flags[10] = true; }
        if (Channels) { Flags[15] = true; }

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Flags);
        bw.Write(Offset);
        bw.Write(Limit);
        bw.Write(Hash);
    }

    public void Deserialize(BinaryReader br)
    {
        Flags = br.Deserialize<BitArray>();
        if (Flags[0]) { Correspondents = true; }
        if (Flags[1]) { BotsPm = true; }
        if (Flags[2]) { BotsInline = true; }
        if (Flags[3]) { PhoneCalls = true; }
        if (Flags[4]) { ForwardUsers = true; }
        if (Flags[5]) { ForwardChats = true; }
        if (Flags[10]) { Groups = true; }
        if (Flags[15]) { Channels = true; }
        Offset = br.ReadInt32();
        Limit = br.ReadInt32();
        Hash = br.ReadInt64();
    }
}
