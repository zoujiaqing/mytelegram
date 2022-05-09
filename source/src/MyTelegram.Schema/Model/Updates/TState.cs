﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Updates;


///<summary>
///See <a href="https://core.telegram.org/constructor/updates.state" />
///</summary>
[TlObject(0xa56c2a3e)]
public class TState : IState
{
    public uint ConstructorId => 0xa56c2a3e;
    public int Pts { get; set; }
    public int Qts { get; set; }
    public int Date { get; set; }
    public int Seq { get; set; }
    public int UnreadCount { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Write(Pts);
        bw.Write(Qts);
        bw.Write(Date);
        bw.Write(Seq);
        bw.Write(UnreadCount);
    }

    public void Deserialize(BinaryReader br)
    {
        Pts = br.ReadInt32();
        Qts = br.ReadInt32();
        Date = br.ReadInt32();
        Seq = br.ReadInt32();
        UnreadCount = br.ReadInt32();
    }
}