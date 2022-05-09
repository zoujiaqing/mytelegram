﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/channelAdminLogEventActionTogglePreHistoryHidden" />
///</summary>
[TlObject(0x5f5c95f1)]
public class TChannelAdminLogEventActionTogglePreHistoryHidden : IChannelAdminLogEventAction
{
    public uint ConstructorId => 0x5f5c95f1;

    ///<summary>
    ///See <a href="https://core.telegram.org/type/Bool" />
    ///</summary>
    public bool NewValue { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(NewValue);
    }

    public void Deserialize(BinaryReader br)
    {
        NewValue = br.Deserialize<bool>();
    }
}