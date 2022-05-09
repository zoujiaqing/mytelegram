﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Account;


///<summary>
///See <a href="https://core.telegram.org/constructor/account.contentSettings" />
///</summary>
[TlObject(0x57e28221)]
public class TContentSettings : IContentSettings
{
    public uint ConstructorId => 0x57e28221;
    public BitArray Flags { get; set; } = new BitArray(32);
    public bool SensitiveEnabled { get; set; }
    public bool SensitiveCanChange { get; set; }

    public void ComputeFlag()
    {
        if (SensitiveEnabled) { Flags[0] = true; }
        if (SensitiveCanChange) { Flags[1] = true; }
    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Flags);

    }

    public void Deserialize(BinaryReader br)
    {
        Flags = br.Deserialize<BitArray>();
        if (Flags[0]) { SensitiveEnabled = true; }
        if (Flags[1]) { SensitiveCanChange = true; }
    }
}