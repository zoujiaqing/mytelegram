﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/updateDeleteMessages" />
///</summary>
[TlObject(0xa20db0e5)]
public class TUpdateDeleteMessages : IUpdate
{
    public uint ConstructorId => 0xa20db0e5;
    public TVector<int> Messages { get; set; }
    public int Pts { get; set; }
    public int PtsCount { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        Messages.Serialize(bw);
        bw.Write(Pts);
        bw.Write(PtsCount);
    }

    public void Deserialize(BinaryReader br)
    {
        Messages = br.Deserialize<TVector<int>>();
        Pts = br.ReadInt32();
        PtsCount = br.ReadInt32();
    }
}