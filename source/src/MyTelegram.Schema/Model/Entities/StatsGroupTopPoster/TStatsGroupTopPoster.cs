﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/statsGroupTopPoster" />
///</summary>
[TlObject(0x9d04af9b)]
public class TStatsGroupTopPoster : IStatsGroupTopPoster
{
    public uint ConstructorId => 0x9d04af9b;
    public long UserId { get; set; }
    public int Messages { get; set; }
    public int AvgChars { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Write(UserId);
        bw.Write(Messages);
        bw.Write(AvgChars);
    }

    public void Deserialize(BinaryReader br)
    {
        UserId = br.ReadInt64();
        Messages = br.ReadInt32();
        AvgChars = br.ReadInt32();
    }
}