﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/channelAdminLogEventActionExportedInviteDelete" />
///</summary>
[TlObject(0x5a50fca4)]
public class TChannelAdminLogEventActionExportedInviteDelete : IChannelAdminLogEventAction
{
    public uint ConstructorId => 0x5a50fca4;

    ///<summary>
    ///See <a href="https://core.telegram.org/type/ExportedChatInvite" />
    ///</summary>
    public MyTelegram.Schema.IExportedChatInvite Invite { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        Invite.Serialize(bw);
    }

    public void Deserialize(BinaryReader br)
    {
        Invite = br.Deserialize<MyTelegram.Schema.IExportedChatInvite>();
    }
}