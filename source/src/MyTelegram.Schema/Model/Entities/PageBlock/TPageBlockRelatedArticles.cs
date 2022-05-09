﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/pageBlockRelatedArticles" />
///</summary>
[TlObject(0x16115a96)]
public class TPageBlockRelatedArticles : IPageBlock
{
    public uint ConstructorId => 0x16115a96;

    ///<summary>
    ///See <a href="https://core.telegram.org/type/RichText" />
    ///</summary>
    public MyTelegram.Schema.IRichText Title { get; set; }
    public TVector<MyTelegram.Schema.IPageRelatedArticle> Articles { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        Title.Serialize(bw);
        Articles.Serialize(bw);
    }

    public void Deserialize(BinaryReader br)
    {
        Title = br.Deserialize<MyTelegram.Schema.IRichText>();
        Articles = br.Deserialize<TVector<MyTelegram.Schema.IPageRelatedArticle>>();
    }
}