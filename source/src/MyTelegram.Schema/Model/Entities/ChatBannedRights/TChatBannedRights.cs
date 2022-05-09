﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/chatBannedRights" />
///</summary>
[TlObject(0x9f120418)]
public class TChatBannedRights : IChatBannedRights
{
    public uint ConstructorId => 0x9f120418;
    public BitArray Flags { get; set; } = new BitArray(32);
    public bool ViewMessages { get; set; }
    public bool SendMessages { get; set; }
    public bool SendMedia { get; set; }
    public bool SendStickers { get; set; }
    public bool SendGifs { get; set; }
    public bool SendGames { get; set; }
    public bool SendInline { get; set; }
    public bool EmbedLinks { get; set; }
    public bool SendPolls { get; set; }
    public bool ChangeInfo { get; set; }
    public bool InviteUsers { get; set; }
    public bool PinMessages { get; set; }
    public int UntilDate { get; set; }

    public void ComputeFlag()
    {
        if (ViewMessages) { Flags[0] = true; }
        if (SendMessages) { Flags[1] = true; }
        if (SendMedia) { Flags[2] = true; }
        if (SendStickers) { Flags[3] = true; }
        if (SendGifs) { Flags[4] = true; }
        if (SendGames) { Flags[5] = true; }
        if (SendInline) { Flags[6] = true; }
        if (EmbedLinks) { Flags[7] = true; }
        if (SendPolls) { Flags[8] = true; }
        if (ChangeInfo) { Flags[10] = true; }
        if (InviteUsers) { Flags[15] = true; }
        if (PinMessages) { Flags[17] = true; }

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Flags);
        bw.Write(UntilDate);
    }

    public void Deserialize(BinaryReader br)
    {
        Flags = br.Deserialize<BitArray>();
        if (Flags[0]) { ViewMessages = true; }
        if (Flags[1]) { SendMessages = true; }
        if (Flags[2]) { SendMedia = true; }
        if (Flags[3]) { SendStickers = true; }
        if (Flags[4]) { SendGifs = true; }
        if (Flags[5]) { SendGames = true; }
        if (Flags[6]) { SendInline = true; }
        if (Flags[7]) { EmbedLinks = true; }
        if (Flags[8]) { SendPolls = true; }
        if (Flags[10]) { ChangeInfo = true; }
        if (Flags[15]) { InviteUsers = true; }
        if (Flags[17]) { PinMessages = true; }
        UntilDate = br.ReadInt32();
    }
}