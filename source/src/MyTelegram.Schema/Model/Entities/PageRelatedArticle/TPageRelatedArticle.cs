﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/pageRelatedArticle" />
///</summary>
[TlObject(0xb390dc08)]
public class TPageRelatedArticle : IPageRelatedArticle
{
    public uint ConstructorId => 0xb390dc08;
    public BitArray Flags { get; set; } = new BitArray(32);
    public string Url { get; set; }
    public long WebpageId { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public long? PhotoId { get; set; }
    public string? Author { get; set; }
    public int? PublishedDate { get; set; }

    public void ComputeFlag()
    {
        if (Title != null) { Flags[0] = true; }
        if (Description != null) { Flags[1] = true; }
        if (PhotoId != 0 && PhotoId.HasValue) { Flags[2] = true; }
        if (Author != null) { Flags[3] = true; }
        if (PublishedDate != 0 && PublishedDate.HasValue) { Flags[4] = true; }
    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Flags);
        bw.Serialize(Url);
        bw.Write(WebpageId);
        if (Flags[0]) { bw.Serialize(Title); }
        if (Flags[1]) { bw.Serialize(Description); }
        if (Flags[2]) { bw.Write(PhotoId.Value); }
        if (Flags[3]) { bw.Serialize(Author); }
        if (Flags[4]) { bw.Write(PublishedDate.Value); }
    }

    public void Deserialize(BinaryReader br)
    {
        Flags = br.Deserialize<BitArray>();
        Url = br.Deserialize<string>();
        WebpageId = br.ReadInt64();
        if (Flags[0]) { Title = br.Deserialize<string>(); }
        if (Flags[1]) { Description = br.Deserialize<string>(); }
        if (Flags[2]) { PhotoId = br.ReadInt64(); }
        if (Flags[3]) { Author = br.Deserialize<string>(); }
        if (Flags[4]) { PublishedDate = br.ReadInt32(); }
    }
}