﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;

///<summary>
///See <a href="https://core.telegram.org/method/messages.sendMessage" />
///</summary>
[TlObject(0x520c3870)]
public sealed class RequestSendMessage : IRequest<MyTelegram.Schema.IUpdates>
{
    public uint ConstructorId => 0x520c3870;
    public BitArray Flags { get; set; } = new BitArray(32);
    public bool NoWebpage { get; set; }
    public bool Silent { get; set; }
    public bool Background { get; set; }
    public bool ClearDraft { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/InputPeer" />
    ///</summary>
    public MyTelegram.Schema.IInputPeer Peer { get; set; }
    public int? ReplyToMsgId { get; set; }
    public string Message { get; set; }
    public long RandomId { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/ReplyMarkup" />
    ///</summary>
    public MyTelegram.Schema.IReplyMarkup? ReplyMarkup { get; set; }
    public TVector<MyTelegram.Schema.IMessageEntity>? Entities { get; set; }
    public int? ScheduleDate { get; set; }

    public void ComputeFlag()
    {
        if (NoWebpage) { Flags[1] = true; }
        if (Silent) { Flags[5] = true; }
        if (Background) { Flags[6] = true; }
        if (ClearDraft) { Flags[7] = true; }
        if (ReplyToMsgId != 0 && ReplyToMsgId.HasValue) { Flags[0] = true; }
        if (ReplyMarkup != null) { Flags[2] = true; }
        if (Entities?.Count > 0) { Flags[3] = true; }
        if (ScheduleDate != 0 && ScheduleDate.HasValue) { Flags[10] = true; }
    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Flags);
        Peer.Serialize(bw);
        if (Flags[0]) { bw.Write(ReplyToMsgId.Value); }
        bw.Serialize(Message);
        bw.Write(RandomId);
        if (Flags[2]) { ReplyMarkup.Serialize(bw); }
        if (Flags[3]) { Entities.Serialize(bw); }
        if (Flags[10]) { bw.Write(ScheduleDate.Value); }
    }

    public void Deserialize(BinaryReader br)
    {
        Flags = br.Deserialize<BitArray>();
        if (Flags[1]) { NoWebpage = true; }
        if (Flags[5]) { Silent = true; }
        if (Flags[6]) { Background = true; }
        if (Flags[7]) { ClearDraft = true; }
        Peer = br.Deserialize<MyTelegram.Schema.IInputPeer>();
        if (Flags[0]) { ReplyToMsgId = br.ReadInt32(); }
        Message = br.Deserialize<string>();
        RandomId = br.ReadInt64();
        if (Flags[2]) { ReplyMarkup = br.Deserialize<MyTelegram.Schema.IReplyMarkup>(); }
        if (Flags[3]) { Entities = br.Deserialize<TVector<MyTelegram.Schema.IMessageEntity>>(); }
        if (Flags[10]) { ScheduleDate = br.ReadInt32(); }
    }
}
