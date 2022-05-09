﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/botInlineMediaResult" />
///</summary>
[TlObject(0x17db940b)]
public class TBotInlineMediaResult : IBotInlineResult
{
    public uint ConstructorId => 0x17db940b;
    public BitArray Flags { get; set; } = new BitArray(32);
    public string Id { get; set; }
    public string Type { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/Photo" />
    ///</summary>
    public MyTelegram.Schema.IPhoto? Photo { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/Document" />
    ///</summary>
    public MyTelegram.Schema.IDocument? Document { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/BotInlineMessage" />
    ///</summary>
    public MyTelegram.Schema.IBotInlineMessage SendMessage { get; set; }

    public void ComputeFlag()
    {
        if (Photo != null) { Flags[0] = true; }
        if (Document != null) { Flags[1] = true; }
        if (Title != null) { Flags[2] = true; }
        if (Description != null) { Flags[3] = true; }

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Flags);
        bw.Serialize(Id);
        bw.Serialize(Type);
        if (Flags[0]) { Photo.Serialize(bw); }
        if (Flags[1]) { Document.Serialize(bw); }
        if (Flags[2]) { bw.Serialize(Title); }
        if (Flags[3]) { bw.Serialize(Description); }
        SendMessage.Serialize(bw);
    }

    public void Deserialize(BinaryReader br)
    {
        Flags = br.Deserialize<BitArray>();
        Id = br.Deserialize<string>();
        Type = br.Deserialize<string>();
        if (Flags[0]) { Photo = br.Deserialize<MyTelegram.Schema.IPhoto>(); }
        if (Flags[1]) { Document = br.Deserialize<MyTelegram.Schema.IDocument>(); }
        if (Flags[2]) { Title = br.Deserialize<string>(); }
        if (Flags[3]) { Description = br.Deserialize<string>(); }
        SendMessage = br.Deserialize<MyTelegram.Schema.IBotInlineMessage>();
    }
}