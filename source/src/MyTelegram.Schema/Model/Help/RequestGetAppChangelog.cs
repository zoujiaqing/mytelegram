﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Help;

///<summary>
///See <a href="https://core.telegram.org/method/help.getAppChangelog" />
///</summary>
[TlObject(0x9010ef6f)]
public sealed class RequestGetAppChangelog : IRequest<MyTelegram.Schema.IUpdates>
{
    public uint ConstructorId => 0x9010ef6f;
    public string PrevAppVersion { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(PrevAppVersion);
    }

    public void Deserialize(BinaryReader br)
    {
        PrevAppVersion = br.Deserialize<string>();
    }
}
