﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/phoneCallProtocol" />
///</summary>
[TlObject(0xfc878fc8)]
public class TPhoneCallProtocol : IPhoneCallProtocol
{
    public uint ConstructorId => 0xfc878fc8;
    public BitArray Flags { get; set; } = new BitArray(32);
    public bool UdpP2p { get; set; }
    public bool UdpReflector { get; set; }
    public int MinLayer { get; set; }
    public int MaxLayer { get; set; }
    public TVector<string> LibraryVersions { get; set; }

    public void ComputeFlag()
    {
        if (UdpP2p) { Flags[0] = true; }
        if (UdpReflector) { Flags[1] = true; }

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Flags);
        bw.Write(MinLayer);
        bw.Write(MaxLayer);
        LibraryVersions.Serialize(bw);
    }

    public void Deserialize(BinaryReader br)
    {
        Flags = br.Deserialize<BitArray>();
        if (Flags[0]) { UdpP2p = true; }
        if (Flags[1]) { UdpReflector = true; }
        MinLayer = br.ReadInt32();
        MaxLayer = br.ReadInt32();
        LibraryVersions = br.Deserialize<TVector<string>>();
    }
}